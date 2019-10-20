'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ERP.EntidadesWCF

Public Class frm_ModeloVehiculo
    Inherits ISL.Win.frm_MenuPadre

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Shared instancia As frm_ModeloVehiculo = Nothing

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_ModeloVehiculo()
        End If
        instancia.Activate()
        Return instancia
    End Function

#Region "Declaración de variables"
    Dim oeModeloVehiculo As e_Modelo
    Dim olModeloVehiculo As l_Modelo

    Dim oeMarca As e_Marca
    Dim olMarca As l_Marca

    Dim _ingresando_datos As Boolean = False

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
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        oeModeloVehiculo = New e_Modelo
        oeModeloVehiculo.TipoOperacion = "I"
        MostrarTabs(1, tcModeloVehiculo, 1)
        Inicializar()
        MyBase.Nuevo()
        cmbMarca.Focus()
    End Sub

    Public Overrides Sub Editar()
        If griLista.Selected.Rows.Count > 0 Then
            oeModeloVehiculo = New e_Modelo
            MostrarModeloVehiculo()
            oeModeloVehiculo.TipoOperacion = "A"
            txtCodigo.Focus()
            MyBase.Editar()
            cmbMarca.Focus()
        Else
            mensajeEmergente.Problema("Seleccione registro")
        End If
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarModeloVehiculo() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, tcModeloVehiculo, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                Case Windows.Forms.DialogResult.Yes
                    If GuardarModeloVehiculo() Then
                        MostrarTabs(0, tcModeloVehiculo, 2)
                        _ingresando_datos = False
                        MyBase.Consultar(True)
                    Else
                        _ingresando_datos = True
                        MostrarTabs(1, tcModeloVehiculo, 1)
                    End If
                Case Windows.Forms.DialogResult.No
                    MostrarTabs(0, tcModeloVehiculo, 2)
                    _ingresando_datos = False
                    MyBase.Consultar(True)
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            If griLista.Selected.Rows.Count > 0 Then
                oeModeloVehiculo = New e_Modelo
                olModeloVehiculo = New l_Modelo
                With griLista
                    If ValidarGrilla(griLista, "Marca") Then
                        oeModeloVehiculo.Id = .ActiveRow.Cells("ID").Value
                        oeModeloVehiculo = olModeloVehiculo.Obtener(oeModeloVehiculo)
                        If oeModeloVehiculo.Activo Then
                            If MessageBox.Show("Esta seguro de eliminar el Modelo de Vehiculo: " & _
                                     .ActiveRow.Cells("Nombre").Value.ToString & " ?", _
                                     "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                                oeModeloVehiculo.TipoOperacion = "E"
                                olModeloVehiculo.Eliminar(oeModeloVehiculo)
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
    Private Function GuardarModeloVehiculo() As Boolean
        Try
            olModeloVehiculo = New l_Modelo
            If Not ValidarCombo(cmbMarca, "Marca") Then Exit Function
            If cmbMarca.SelectedIndex < 0 Then
                cmbMarca.Focus()
                Throw New Exception("Seleccione marca válida")
            End If
            With oeModeloVehiculo
                .Codigo = txtCodigo.Text
                .IdMarca = cmbMarca.Value
                .Nombre = txtNombre.Text
                .Abreviatura = txtAbreviatura.Text
                .Activo = True
                .IndEmpresa = IIf(verIndEmpresa.Checked, 1, 0)
                .IndSunarp = IIf(verIndSunarp.Checked, 1, 0)
            End With
            oeModeloVehiculo.PrefijoID = gs_PrefijoIdSucursal '@0001
            If Not olModeloVehiculo.Guardar(oeModeloVehiculo) Then
                Return False
            End If
            mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
            MostrarTabs(0, tcModeloVehiculo, 2)
            Consultar(True)
            griLista.Focus()
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
            Enfocar(ex.Message)
        End Try
    End Function

    Private Sub Enfocar(ByVal excepcion As String)
        If excepcion.Contains("Marca") Then
            cmbMarca.Focus()
        End If
        If excepcion.Contains("nombre") Then
            txtNombre.Focus()
        End If
    End Sub

    Private Sub Inicializar()
        txtCodigo.Text = String.Empty
        txtAbreviatura.Text = String.Empty
        txtNombre.Text = String.Empty
        verActivo.Checked = True
        cmbMarca.SelectedIndex = -1
        verIndEmpresa.Checked = 0
        verIndSunarp.Checked = 0
        AsociarMenu()
    End Sub

    Private Sub MostrarModeloVehiculo()
        Try
            olModeloVehiculo = New l_Modelo
            If griLista.ActiveRow.Cells("ID").Value.ToString.Length > 0 Then
                Inicializar()
                oeModeloVehiculo.Id = griLista.ActiveRow.Cells("Id").Value.ToString
                oeModeloVehiculo = olModeloVehiculo.Obtener(oeModeloVehiculo)
                With oeModeloVehiculo
                    txtCodigo.Text = .Codigo
                    txtNombre.Text = .Nombre
                    txtAbreviatura.Text = .Abreviatura
                    verActivo.Checked = .Activo
                    cmbMarca.Value = .IdMarca
                    verIndEmpresa.Checked = .IndEmpresa
                    verIndSunarp.Checked = .IndSunarp
                End With
                MostrarTabs(1, tcModeloVehiculo, 1)
                MyBase.Editar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            olModeloVehiculo = New l_Modelo
            oeModeloVehiculo = New e_Modelo
            oeModeloVehiculo.TipoOperacion = "1"
            With griLista
                .DataSource = olModeloVehiculo.Listar(oeModeloVehiculo)
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

    Public Sub LlenaCombos()
        olMarca = New l_Marca
        oeMarca = New e_Marca
        oeMarca.Activo = True
        oeMarca.TipoMarca = 0
        LlenarComboMaestro(cmbMarca, olMarca.Listar(oeMarca), -1)
    End Sub
#End Region

#Region "Eventos"

    Private Sub frm_Marca_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        MostrarTabs(0, tcModeloVehiculo)
        Tiempo1.Enabled = False
        InicializaTiempo()
        LlenaCombos()
    End Sub

    Private Sub griLista_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griLista.InitializeLayout
        agrTotalModeloVehiculo.Text = "Total Registros: " & e.Layout.Rows.Count
    End Sub

    Private Sub frm_ModeloVehiculo_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_ModeloVehiculo_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Select Case _Operacion
            Case "Nuevo"
                Me.Activate()
                Me.Cancelar()
            Case "Editar"
                Me.Activate()
                Me.Cancelar()
        End Select
        e.Cancel = _ingresando_datos
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub griLista_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griLista.DoubleClick
        If griLista.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub griLista_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griLista.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

#End Region

#Region "Control de tiempo de respuesta y actualización"

    Private Sub frm_ModeloVehiculo_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        InicializaTiempo()
    End Sub

    Private Sub grid_ListaModeloVehiculo_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles griLista.MouseMove
        If _tiempo <= 0 Then
            Listar(_Activo)
        End If
        InicializaTiempo()
    End Sub

#End Region

#Region "Menú contextual del maestro de Modelo de Vehículo"

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

    Private Sub griLista_ClickCellButton(sender As Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griLista.ClickCellButton
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Select Case e.Cell.Column.Key
                Case "Codigo"
                    olModeloVehiculo = New l_Modelo
                    oeModeloVehiculo = New e_Modelo
                    With oeModeloVehiculo
                        .TipoOperacion = "1"
                        .Id = RTrim(griLista.ActiveRow.Cells("Id").Value)
                        .IndEmpresa = griLista.ActiveRow.Cells("IndEmpresa").Value
                        .IndSunarp = griLista.ActiveRow.Cells("IndSunarp").Value
                    End With
                    oeModeloVehiculo.PrefijoID = gs_PrefijoIdSucursal '@0001
                    If olModeloVehiculo.Guardar(oeModeloVehiculo) Then
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

    Private Sub griLista_CellChange(sender As Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griLista.CellChange
        griLista.UpdateData()
    End Sub

    Private Sub frm_ModeloVehiculo_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case tcModeloVehiculo.SelectedTab.Index
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
