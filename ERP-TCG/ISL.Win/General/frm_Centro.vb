'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ISL.LogicaWCF

Public Class frm_Centro
    Inherits ISL.Win.frm_MenuPadre

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_Centro = Nothing
    Private Shared Operacion As String
    ''' Instancia unica de Formulario: frm_Centro

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_Centro
            Operacion = "Inicializa"
        End If
        instancia.Activate()
        Return instancia
    End Function

#Region "Declaración de Variables"
    Dim olCentro As New l_Centro
    Dim oeCentro As New e_Centro
    Dim olLugar As New l_Lugar
    Dim oeLugar As New e_Lugar
    Dim _ingresando_datos As Boolean = False
    Dim estado As String
#End Region

#Region "Eventos"

    Private Sub frm_Centro_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            MostrarTabs(0, ficCentro)
            griCentro.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
            griCentro.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True
            llenarCombo()
            Tiempo1.Enabled = False
            InicializaTiempo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub frm_Centro_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Try
            instancia = Nothing
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub frm_Centro_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            Select Case Operacion
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
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub txtCodigo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.GotFocus
        Try
            txtCodigo.SelectAll()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub txtNombre_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre.GotFocus
        Try
            txtNombre.SelectAll()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub txtAbreviatura_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAbreviatura.GotFocus
        Try
            txtAbreviatura.SelectAll()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        Try
            'TeclaPulsada(e)
            oeCentro.Modificado = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub txtNombre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNombre.KeyDown
        Try
            'TeclaPulsada(e)
            oeCentro.Modificado = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub txtAbreviatura_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAbreviatura.KeyDown
        Try
            'TeclaPulsada(e)
            oeCentro.Modificado = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub verActivo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            TeclaPulsada(e)
            oeCentro.Modificado = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        Try
            oeCentro.Modificado = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        Try
            oeCentro.Modificado = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub txtAbreviatura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAbreviatura.KeyPress
        Try
            oeCentro.Modificado = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub verActivo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try
            oeCentro.Modificado = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub verActivo_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            oeCentro.Modificado = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub cboLugar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboLugar.Click
        Try
            oeCentro.Modificado = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub cboLugar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboLugar.KeyPress
        Try
            oeCentro.Modificado = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub griCentro_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griCentro.InitializeLayout
        Try
            agrLista.Text = "Total de Centros: " & e.Layout.Rows.Count & estado
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub griCentro_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles griCentro.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub griCentro_BeforeRowsDeleted(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griCentro.BeforeRowsDeleted
        Try
            e.DisplayPromptMsg = False
            e.Cancel = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub griCentro_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles griCentro.DoubleClick
        Try
            If griCentro.Selected.Rows.Count > 0 Then Editar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub cboLugar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboLugar.KeyDown
        Try
            'TeclaPulsada(e)
            oeCentro.Modificado = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub cboLugar_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLugar.ValueChanged
        Try
            oeCentro.Modificado = True
            oeCentro.IdLugar = cboLugar.Value
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If griCentro.Rows.Count > 0 Then
                MyBase.Consultar(Activo)
            Else
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        oeCentro.TipoOperacion = "I"
        MostrarTabs(1, ficCentro, 1)
        Inicializar()
        Operacion = "Nuevo"
        MyBase.Nuevo()
        txtNombre.Focus()
    End Sub

    Public Overrides Sub Editar()
        Try
            If griCentro.Selected.Rows.Count > 0 Then
                Mostrar()
                oeCentro.TipoOperacion = "A"
                Operacion = "Editar"
                MyBase.Editar()
                txtNombre.Focus()
            Else
                mensajeEmergente.Problema("Seleccione registro")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarRegistro() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, ficCentro, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeCentro.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarRegistro() Then
                            MostrarTabs(0, ficCentro, 2)
                            _ingresando_datos = False
                            MyBase.Consultar(True)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficCentro, 1)
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficCentro, 2)
                        _ingresando_datos = False
                        MyBase.Consultar(True)
                End Select
            Else
                MostrarTabs(0, ficCentro, 2)
                _ingresando_datos = False
                MyBase.Consultar(True)
            End If
            '_ingresando_datos = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            If ValidarGrilla(griCentro, "Centro") Then
                If griCentro.Selected.Rows.Count > 0 Then
                    oeCentro.Id = griCentro.ActiveRow.Cells("ID").Value
                    oeCentro = olCentro.Obtener(oeCentro)
                    If oeCentro.Activo Then
                        If MessageBox.Show("Desea eliminar el Centro: " & _
                                 griCentro.ActiveRow.Cells("Nombre").Value.ToString & " ?", _
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            oeCentro.TipoOperacion = "E"
                            olCentro.Eliminar(oeCentro)
                            Consultar(True)
                        End If
                    Else
                        Throw New Exception("La informacion  se encuentra eliminada en " & Me.Text)
                    End If
                Else
                    mensajeEmergente.Problema("Seleccione registro")
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    ''' 
    Public Overrides Sub Exportar()
        Try
            If griCentro.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griCentro)
            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        MyBase.Imprimir()
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Metodos"

    Private Sub Inicializar()
        Try
            txtId.Text = String.Empty
            txtCodigo.Text = String.Empty
            txtNombre.Text = String.Empty
            txtAbreviatura.Text = String.Empty
            entTiempoActualizacionDatos.Value = 10
            cboLugar.SelectedIndex = -1
            AsociarMenu()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub llenarCombo()
        Try
            oeLugar.TipoOperacion = String.Empty
            oeLugar.Activo = True
            LimpiaCombos(cboLugar)
            LlenarComboMaestro(cboLugar, olLugar.Listar(oeLugar), -1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub Enfocar(ByVal excepcion As String)
        Try
            If excepcion.Contains("codigo") Then
                txtCodigo.Focus()
            End If
            If excepcion.Contains("nombre") Then
                txtNombre.Focus()
            End If
            If excepcion.Contains("abreviatura") Then
                txtAbreviatura.Focus()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Mostrar()
        Try
            If griCentro.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                Inicializar()
                oeCentro.Id = griCentro.ActiveRow.Cells("Id").Value.ToString
                oeCentro = olCentro.Obtener(oeCentro)
                txtId.Text = oeCentro.Id
                txtCodigo.Text = oeCentro.Codigo
                txtNombre.Text = oeCentro.Nombre
                txtAbreviatura.Text = oeCentro.Abreviatura
                cboLugar.Value = oeCentro.IdLugar
                MostrarTabs(1, ficCentro, 1)
                MyBase.Editar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)

        End Try
    End Sub

    Private Function GuardarRegistro() As Boolean
        Try
            oeCentro.IdEmpresa = ISL_IdEmpresa
            oeCentro.Codigo = txtCodigo.Text.Trim
            oeCentro.Nombre = txtNombre.Text.Trim
            oeCentro.Abreviatura = txtAbreviatura.Text.Trim
            oeCentro.IdLugar = cboLugar.Value
            If cboLugar.Value IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(cboLugar.Value.ToString.Trim) Then
                Dim lst_Lugar As New List(Of e_Lugar)
                Dim wr_Lugar As New l_Lugar
                lst_Lugar = wr_Lugar.Listar(New e_Lugar With {.Id = cboLugar.Value.ToString.Trim,
                                              .Activo = True})
                If lst_Lugar.Count <= 0 Then
                    Throw New Exception("Ingrese lugar válido")
                End If
            End If
            oeCentro.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olCentro.Guardar(oeCentro) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
                MostrarTabs(0, ficCentro, 2)
                Consultar(True)
                griCentro.Focus()
                Return True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
            Enfocar(ex.Message)
        End Try
    End Function

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            If Activo Then
                estado = " Activo"
            Else
                estado = " Inactivo"
            End If
            Me.Cursor = Cursors.WaitCursor
            oeCentro = New e_Centro
            With griCentro
                oeCentro.Activo = Activo
                .DataSource = olCentro.Listar(oeCentro)
                agrLista.Text = "Total de Centros: " & griCentro.Rows.Count.ToString
                'Ubica el cursor el el primer registro de la grilla
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Activate()
                    .Rows.Item(0).Selected = True
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

#End Region

#Region "Control de tiempo de respuesta y actualización"

    Private Sub frm_Centro_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        InicializaTiempo()
    End Sub

    Private Sub griCentro_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles griCentro.MouseMove
        If _tiempo <= 0 Then
            Listar(_Activo)
        End If
        InicializaTiempo()
    End Sub

#End Region

#Region "Menú contextual del maestro de centros"

    Private Sub AsociarMenu()
        griCentro.ContextMenuStrip = MenuContextual1
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
        If griCentro.Selected.Rows.Count > 0 Then
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = True
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = True
        Else
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = False
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = False
        End If
    End Sub

#End Region

    Private Sub frm_Centro_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case ficCentro.SelectedTab.Index
                Case 0
                Case 1
                    Select Case e.KeyCode
                        Case Keys.Enter
                            SendKeys.Send("{TAB}")
                    End Select
                Case 2
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

End Class



