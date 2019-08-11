Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF
Imports Infragistics.Win
Imports Infragistics.Shared
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinEditors
Imports System.Configuration
Imports Infragistics.Win.CalcEngine
Imports Infragistics.Win.UltraWinDataSource

Public Class frm_TipoVehiculo
    Inherits ISL.Win.frm_MenuPadre

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared Operacion As String
    Private Shared instancia As frm_TipoVehiculo = Nothing

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_TipoVehiculo()
        End If
        instancia.Activate()
        Return instancia
    End Function

#Region "Declaración de variables"

    Dim oeCombo As e_Combo
    Dim olCombo As l_Combo
    Dim ListViaje As List(Of e_Combo)

    Dim _ingresando_datos As Boolean = False

    Dim oeTipoVehiculo As e_TipoVehiculo
    Dim olTipoVehiculo As l_TipoVehiculo
#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            If griLista.Rows.Count > 0 Then
                MyBase.Consultar(Activo)
            Else
                MyBase.Consultar()
            End If
            Operacion = "Inicializa"
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            oeTipoVehiculo = New e_TipoVehiculo
            oeTipoVehiculo.TipoOperacion = "I"
            MostrarTabs(1, tcTipoVehiculo, 1)
            Inicializar()
            Operacion = "Nuevo"
            MyBase.Nuevo()
            verIndTipoVehiculo.Focus()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            If griLista.Selected.Rows.Count > 0 Then
                olTipoVehiculo = New l_TipoVehiculo
                oeTipoVehiculo = New e_TipoVehiculo
                MostrarTipoVehiculo()
                oeTipoVehiculo.TipoOperacion = "A"
                Operacion = "Editar"
                MyBase.Editar()
                verIndTipoVehiculo.Focus()
            Else
                mensajeEmergente.Problema("Seleccione registro")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarTipoVehiculo() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, tcTipoVehiculo, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                Case Windows.Forms.DialogResult.Yes
                    If GuardarTipoVehiculo() Then
                        MostrarTabs(0, tcTipoVehiculo, 2)
                        _ingresando_datos = False
                        Operacion = "Inicializa"
                        MyBase.Consultar(True)
                    Else
                        _ingresando_datos = True
                        MostrarTabs(1, tcTipoVehiculo, 1)
                    End If
                    'Exit Sub
                Case Windows.Forms.DialogResult.No
                    MostrarTabs(0, tcTipoVehiculo, 2)
                    _ingresando_datos = False
                    Operacion = "Inicializa"
                    MyBase.Consultar(True)
                    'Exit Sub
            End Select
            '_ingresando_datos = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            If griLista.Selected.Rows.Count > 0 Then
                With griLista
                    If ValidarGrilla(griLista, "Tipo Vehiculo") Then
                        oeTipoVehiculo.Id = .ActiveRow.Cells("ID").Value
                        oeTipoVehiculo = olTipoVehiculo.Obtener(oeTipoVehiculo)
                        If oeTipoVehiculo.Activo Then
                            If MessageBox.Show("Esta seguro de eliminar el Tipo Vehiculo: " & _
                                     .ActiveRow.Cells("Nombre").Value.ToString & " ?", _
                                     "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                                oeTipoVehiculo.TipoOperacion = "E"
                                olTipoVehiculo.Eliminar(oeTipoVehiculo)
                                Consultar(True)
                            End If
                        Else
                            Throw New Exception("La informacion  se encuentra eliminada en " & Me.Text)
                        End If
                    End If
                End With
            Else
                mensajeEmergente.Problema("Seleccione registro")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try
            If griLista.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griLista)
            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        MyBase.Imprimir()
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Métodos"
    Private Function GuardarTipoVehiculo() As Boolean
        Try
            olTipoVehiculo = New l_TipoVehiculo
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            If cboTipoVehiculoOrigen.SelectedIndex < 0 Then
                cboTipoVehiculoOrigen.Focus()
                Throw New Exception("Seleccione Tipo Veh. Origen válido")
            End If
            With oeTipoVehiculo
                .Codigo = txtCodigo.Text.Trim
                .Nombre = txtNombre.Text
                .Abreviatura = txtAbreviatura.Text
                .Descripcion = txtDescripcion.Text
                .Motriz = IIf(verMotriz.Checked, 1, 0)
                .Carga = IIf(verCarga.Checked, 1, 0)
                .IndicadorFuncional = IIf(verIndFuncional.Checked, 1, 0)
                .IdTipoVehiculoOrigen = cboTipoVehiculoOrigen.Value
                .UsuarioCreacion = gUsuarioSGI.Id
                .IndTipoVehiculo = IIf(verIndTipoVehiculo.Checked, 1, 0)
                .IndSunarp = IIf(verIndSunarp.Checked, 1, 0)
            End With
            If olTipoVehiculo.Guardar(oeTipoVehiculo) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                MostrarTabs(0, tcTipoVehiculo, 2)
                Consultar(True)
                griLista.Focus()
                Return True
            End If
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
            Enfocar(ex.Message)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Function

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            olTipoVehiculo = New l_TipoVehiculo
            oeTipoVehiculo = New e_TipoVehiculo
            oeTipoVehiculo.TipoOperacion = "1"
            With griLista
                .DataSource = olTipoVehiculo.Listar(oeTipoVehiculo)
                .Focus()
                If .Rows.Count > 0 Then
                    .Rows(0).Activate()
                    .Rows(0).Selected = True
                End If
            End With
            ugb_Espera.Visible = False
        Catch ex As Exception
            Throw ex
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub Enfocar(ByVal excepcion As String)
        If excepcion.Contains("codigo") Then
            txtCodigo.Focus()
        End If
        If excepcion.Contains("nombre") Then
            txtNombre.Focus()
        End If
        If excepcion.Contains("abreviatura") Then
            txtAbreviatura.Focus()
        End If
    End Sub

    Private Sub Inicializar()
        txtId.Clear()
        txtCodigo.Clear()
        txtAbreviatura.Clear()
        txtNombre.Clear()
        txtDescripcion.Clear()
        verMotriz.Checked = False
        verTipoVehiculoOrigen.Checked = False
        cboTipoVehiculoOrigen.Enabled = False
        cboTipoVehiculoOrigen.SelectedIndex = -1
        verIndFuncional.Checked = 0
        verIndSunarp.Checked = 0
        verIndTipoVehiculo.Checked = 0
        txtNombre.Focus()
    End Sub

    Private Sub MostrarTipoVehiculo()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            If griLista.ActiveRow.Cells("ID").Value.ToString.Length > 0 Then
                Inicializar()
                oeTipoVehiculo.Id = griLista.ActiveRow.Cells("Id").Value.ToString
                oeTipoVehiculo = olTipoVehiculo.Obtener(oeTipoVehiculo)
                With oeTipoVehiculo
                    txtId.Text = .Id
                    txtCodigo.Text = .Codigo
                    txtNombre.Text = .Nombre
                    txtAbreviatura.Text = .Abreviatura
                    txtDescripcion.Text = .Descripcion
                    verMotriz.Checked = .Motriz
                    verMotriz_Validated(Nothing, Nothing)
                    verCarga.Checked = .Carga
                    verIndFuncional.Checked = .IndicadorFuncional
                    If .IdTipoVehiculoOrigen <> "" Then
                        cboTipoVehiculoOrigen.Value = .IdTipoVehiculoOrigen
                        verTipoVehiculoOrigen.Checked = True
                    End If
                End With
                MostrarTabs(1, tcTipoVehiculo, 1)
                MyBase.Editar()
            End If
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Sub LlenaCombos()

    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_Tipo_Vehiculo_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Select Case _Operacion
            Case "Nuevo", "Editar"
                Me.Activate()
                Me.Cancelar()
        End Select
        e.Cancel = _ingresando_datos
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_Tipo_Vehiculo_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_Tipo_Vehiculo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        Tiempo1.Enabled = False
        MostrarTabs(0, tcTipoVehiculo)
        InicializaTiempo()
        LlenaCombos()
    End Sub

#End Region

    Private Sub griLista_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griLista.DoubleClick
        If griLista.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub verTipoVehiculoOrigen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verTipoVehiculoOrigen.CheckedChanged
        If Operacion = "Nuevo" Or Operacion = "Editar" Then
            If verTipoVehiculoOrigen.Checked Then
                cboTipoVehiculoOrigen.Enabled = True
                cboTipoVehiculoOrigen.Focus()
                verMotriz_Validated(Nothing, Nothing)
            Else
                cboTipoVehiculoOrigen.Enabled = False
                cboTipoVehiculoOrigen.SelectedIndex = -1
                oeTipoVehiculo.IdTipoVehiculoOrigen = ""
            End If
        End If
    End Sub

#Region "Control de tiempo de respuesta y actualización"

#End Region

#Region "Menú contextual del maestro de Tipo de Vehículo"

    Private Sub AsociarMenu()
        griLista.ContextMenuStrip = MenuContextual1
    End Sub

    Private Sub InsertarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertarToolStripMenuItem.Click
        Nuevo()
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarToolStripMenuItem.Click
        Editar()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        Eliminar()
    End Sub

    Private Sub MenuContextual1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuContextual1.Opening
        MenuContextual1.Items("InsertarToolStripMenuItem").Visible = True
        If griLista.Selected.Rows.Count > 0 Then
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = True
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = True
        Else
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = False
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = False
        End If
    End Sub

#End Region

    Private Sub verMotriz_Validated(sender As Object, e As EventArgs) Handles verMotriz.Validated
        Try
            olCombo = New l_Combo
            oeCombo = New e_Combo
            With oeCombo
                .Id = IIf(verMotriz.Checked, 1, 0)
                .Nombre = "UNIDADTIPOVEHICULO"
                .Descripcion = "TIPOVEHICULOPADRE"
            End With
            LlenarComboMaestro(cboTipoVehiculoOrigen, olCombo.Listar(oeCombo), -1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Private Sub frm_TipoVehiculo_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Select Case Operacion
            Case "Nuevo"
                MyBase.Nuevo()
            Case "Editar"
                MyBase.Editar()
            Case "Inicializa"
                MostrarTabs(0, tcTipoVehiculo)
                If _Activo Then
                    ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
                Else
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                End If
        End Select
    End Sub

    Private Sub frm_TipoVehiculo_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub

    Private Sub griLista_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles griLista.InitializeLayout
        agrTotalModeloVehiculo.Text = "Total Registros: " & e.Layout.Rows.Count
    End Sub

    Private Sub griLista_CellChange(sender As Object, e As CellEventArgs) Handles griLista.CellChange
        griLista.UpdateData()
    End Sub

    Private Sub griLista_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griLista.BeforeRowsDeleted
        Try
            e.DisplayPromptMsg = False
            e.Cancel = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griLista_ClickCellButton(sender As Object, e As CellEventArgs) Handles griLista.ClickCellButton
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Select Case e.Cell.Column.Key
                Case "Codigo"
                    olTipoVehiculo = New l_TipoVehiculo
                    oeTipoVehiculo = New e_TipoVehiculo
                    With oeTipoVehiculo
                        .TipoOperacion = "1"
                        .Id = RTrim(griLista.ActiveRow.Cells("Id").Value)
                        .Motriz = griLista.ActiveRow.Cells("Motriz").Value
                        .Carga = griLista.ActiveRow.Cells("Carga").Value
                        .IndicadorFuncional = griLista.ActiveRow.Cells("IndicadorFuncional").Value
                        .IndTipoVehiculo = griLista.ActiveRow.Cells("IndTipoVehiculo").Value
                        .IndSunarp = griLista.ActiveRow.Cells("IndSunarp").Value
                    End With
                    If olTipoVehiculo.Guardar(oeTipoVehiculo) Then
                        griLista.ActiveRow.CellAppearance.BackColor = Me.ColorBloque.Color
                    End If
            End Select
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub txtDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescripcion.KeyPress
        Try
            If e.KeyChar = Chr(13) Then
                e.Handled = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_TipoVehiculo_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case tcTipoVehiculo.SelectedTab.Index
                Case 0
                Case 1
                    Select Case e.KeyCode
                        Case Keys.Enter
                            SendKeys.Send("{TAB}")
                    End Select
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

End Class
