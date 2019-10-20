'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ERP.EntidadesWCF
Imports Infragistics.Win
Imports Infragistics.Shared
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinEditors
Imports System.Configuration
Imports Infragistics.Win.CalcEngine
Imports Infragistics.Win.UltraWinDataSource
Imports System.Threading
Imports System.Data.OleDb

Public Class frm_ConfiguracionMTC
    Inherits ISL.Win.frm_MenuPadre

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_ConfiguracionMTC = Nothing
    Private Shared Operacion As String
    Private Estado As String
    ''' <summary>
    ''' Instancia unica de Formulario: frm_DemandaRapida
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function getInstancia() As frm_MenuPadre

        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_ConfiguracionMTC()
        End If
        instancia.Activate()
        Return instancia
    End Function

#Region "Declaración de variables"

    Dim oeConfiguracionMTC As New e_ConfiguracionMTC
    Dim olConfiguracionMTC As New l_ConfiguracionMTC
    
    Dim _ingresando_datos As Boolean = False

#End Region

#Region "BOTONES"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Tiempo1.Enabled = True
        Operacion = "Inicializa"
        If Activo Then
            Estado = " Activo"
        Else
            Estado = " Inactivo"
        End If
        Try
            Listar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Operacion = "Nuevo"
            Inicializar()
            MostrarTabs(1, ficDemanda, 1)
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            ugb_Espera.Visible = False
            txtNombre.Focus()
        Catch ex As Exception
            ugb_Espera.Visible = False
            mensajeEmergente.Problema(ex.Message)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try

    End Sub

    Public Overrides Sub Editar()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Inicializar()
            If EditarConfiguracionMTC() Then
                Operacion = "Editar"
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            End If
            ugb_Espera.Visible = False
            txtNombre.Focus()
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarConfiguracionMTC() Then
                MostrarTabs(0, ficDemanda, 2)
                MyBase.Guardar()
            Else
                MostrarTabs(1, ficDemanda, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                Case Windows.Forms.DialogResult.Yes
                    If GuardarConfiguracionMTC() Then
                        MostrarTabs(0, ficDemanda, 2)
                        _ingresando_datos = False
                        Operacion = "Inicializa"
                        ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
                    Else
                        _ingresando_datos = True
                    End If
                Case Windows.Forms.DialogResult.No
                    MostrarTabs(0, ficDemanda, 2)
                    _ingresando_datos = False
                    Operacion = "Inicializa"
                    ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
                Case Windows.Forms.DialogResult.Cancel
                    _ingresando_datos = True
            End Select
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            If griLista.Selected.Rows.Count > 0 Then
                If ValidarGrilla(griLista, "Configuracion MTC") Then
                    oeConfiguracionMTC.Id = griLista.ActiveRow.Cells("Id").Value
                    oeConfiguracionMTC = olConfiguracionMTC.Obtener(oeConfiguracionMTC)
                    If oeConfiguracionMTC.Activo Then
                        If MessageBox.Show("Esta seguro de eliminar la Demanda: " & _
                                                 oeConfiguracionMTC.Nombre & " ?", _
                                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            oeConfiguracionMTC.TipoOperacion = "E"
                            olConfiguracionMTC.Eliminar(oeConfiguracionMTC)
                            Consultar(True)
                        End If
                    Else
                        Throw New Exception("La informacion  se encuentra eliminada en " & Me.Text)
                    End If
                End If
                ugb_Espera.Visible = False
            Else
                mensajeEmergente.Problema("Seleccione registro")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            MyBase.Imprimir()
            ugb_Espera.Visible = False
        Catch ex As Exception
            ugb_Espera.Visible = False
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Overrides Sub Salir()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            MyBase.Salir()
            ugb_Espera.Visible = False
        Catch ex As Exception
            ugb_Espera.Visible = False
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
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
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_ConfiguracionMTC_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
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
    End Sub

    Private Sub frm_ConfiguracionMTC_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Select Case Operacion
            Case "Nuevo"
                MyBase.Nuevo()
            Case "Editar"
                MyBase.Editar()
            Case "Inicializa"
                MostrarTabs(0, ficDemanda)
                If _Activo Then
                    ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
                Else
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                End If
                'Consultar(True)
        End Select
    End Sub

    Private Sub frm_ConfiguracionMTC_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        instancia = Nothing
    End Sub

#End Region

#Region "Métodos"

    Public Function EditarConfiguracionMTC() As Boolean
        Try
            If griLista.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                oeConfiguracionMTC = New e_ConfiguracionMTC
                oeConfiguracionMTC.Id = griLista.ActiveRow.Cells("Id").Value
                oeConfiguracionMTC = olConfiguracionMTC.Obtener(oeConfiguracionMTC)
                If oeConfiguracionMTC.Activo Then
                    TxtId.Text = oeConfiguracionMTC.Id
                    txtCodigo.Text = oeConfiguracionMTC.Codigo
                    txtNombre.Text = oeConfiguracionMTC.Nombre
                    txtCapacidad.Text = oeConfiguracionMTC.Capacidad
                    txtLongMaxima.Text = oeConfiguracionMTC.LongitudMax
                    txtNroEjes.Text = oeConfiguracionMTC.NumeroEjes
                    txtPesoEje1.Text = oeConfiguracionMTC.CantPesoMaxEje1
                    txtPesoEje2.Text = oeConfiguracionMTC.CantPesoMaxEje2
                    txtPesoEje3.Text = oeConfiguracionMTC.CantPesoMaxEje3
                    txtPesoEje4.Text = oeConfiguracionMTC.CantPesoMaxEje4
                    txtPesoEje5.Text = oeConfiguracionMTC.CantPesoMaxEje5
                    txtPesoEje6.Text = oeConfiguracionMTC.CantPesoMaxEje6
                    txtPesoEje7.Text = oeConfiguracionMTC.CantPesoMaxEje7
                    txtPesoEje8.Text = oeConfiguracionMTC.CantPesoMaxEje8
                    txtPesoEje9.Text = oeConfiguracionMTC.CantPesoMaxEje9
                    txtPesoBruto.Text = oeConfiguracionMTC.CantPesoMaxBruto
                    MostrarTabs(1, ficDemanda, 1)
                    Return True
                Else
                    Throw New Exception("El Registro se encuentra eliminada no se puede editar")
                    Return False
                End If
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        End Try
    End Function

    Private Function GuardarConfiguracionMTC() As Boolean
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            If ValidaCamposCabecera() Then
                With oeConfiguracionMTC
                    oeConfiguracionMTC.TipoOperacion = "I"
                    oeConfiguracionMTC.Id = TxtId.Text
                    oeConfiguracionMTC.Codigo = txtCodigo.Text
                    oeConfiguracionMTC.Nombre = txtNombre.Text
                    oeConfiguracionMTC.Capacidad = txtCapacidad.Text
                    oeConfiguracionMTC.LongitudMax = txtLongMaxima.Text
                    oeConfiguracionMTC.NumeroEjes = txtNroEjes.Text
                    oeConfiguracionMTC.CantPesoMaxEje1 = txtPesoEje1.Text
                    oeConfiguracionMTC.CantPesoMaxEje2 = txtPesoEje2.Text
                    oeConfiguracionMTC.CantPesoMaxEje3 = txtPesoEje3.Text
                    oeConfiguracionMTC.CantPesoMaxEje4 = txtPesoEje4.Text
                    oeConfiguracionMTC.CantPesoMaxEje5 = txtPesoEje5.Text
                    oeConfiguracionMTC.CantPesoMaxEje6 = txtPesoEje6.Text
                    oeConfiguracionMTC.CantPesoMaxEje7 = txtPesoEje7.Text
                    oeConfiguracionMTC.CantPesoMaxEje8 = txtPesoEje8.Text
                    oeConfiguracionMTC.CantPesoMaxEje9 = txtPesoEje9.Text
                    oeConfiguracionMTC.CantPesoMaxBruto = txtPesoBruto.Text
                    oeConfiguracionMTC.UsuarioCreacion = gUsuarioSGI.Id
                    oeConfiguracionMTC.Activo = True
                End With
                oeConfiguracionMTC.PrefijoID = gs_PrefijoIdSucursal '@0001
                If olConfiguracionMTC.Guardar(oeConfiguracionMTC) Then mensajeEmergente.Confirmacion(Me.Text & ": La informacion ha sido grabada satisfactoriamente", True)
                Consultar(True)
                Return True
                ugb_Espera.Visible = False
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
            Enfocar(ex.Message)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Function

    Private Function ValidaCamposCabecera() As Boolean
        Try
            l_FuncionesGenerales.ValidarCampoNoNulo(txtNombre.Text, "Nombre")
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function

    Private Sub Enfocar(ByVal excepcion As String)
        If excepcion.Contains("Nombre") Then txtNombre.Focus()
    End Sub

    Private Sub Inicializar()
        TxtId.Text = ""
        txtCodigo.Text = ""
        txtNombre.Text = ""
        txtCapacidad.Text = 0
        txtLongMaxima.Text = 0
        txtNroEjes.Text = 0
        txtPesoEje1.Text = 0
        txtPesoEje2.Text = 0
        txtPesoEje3.Text = 0
        txtPesoEje4.Text = 0
        txtPesoEje5.Text = 0
        txtPesoEje6.Text = 0
        txtPesoEje7.Text = 0
        txtPesoEje8.Text = 0
        txtPesoEje9.Text = 0
        txtPesoBruto.Text = 0
    End Sub

    Public Sub Listar()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oeConfiguracionMTC = New e_ConfiguracionMTC
            griLista.DataSource = olConfiguracionMTC.Listar(oeConfiguracionMTC)
            'Ubica el cursor el el primer registro de la grilla
            If griLista.Rows.Count > 0 Then
                griLista.Focus()
                griLista.Rows.Item(0).Selected = True
                ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
            Else
                ControlBoton(1, 1, 0, 0, 0, 0, 1, 0, 1)
            End If
            griLista.Focus()
            'InicializaTiempo()
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

#End Region

#Region "Control de tiempo de respuesta y actualización"

    Private Sub griLista_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griLista.InitializeLayout
        agrListaRegistro.Text = "Lista Registros: " & griLista.Rows.Count & Estado
    End Sub

    Private Sub griLista_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles griLista.MouseMove
        If _tiempo <= 0 Then
            Consultar(True)
        End If
        InicializaTiempo()
    End Sub

    Private Sub frm_ConfiguracionMTC_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        InicializaTiempo()
    End Sub

    Public Overloads Function InicializaTiempo() As Integer
        _tiempo = 120
    End Function

#End Region

#Region "Menú contextual del maestro de Demandas rápidas"
    Private Sub AsociarMenu()
        griLista.ContextMenuStrip = Menu
    End Sub

    Private Sub InsertarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Insert.Click
        Nuevo()
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Update.Click
        Editar()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete.Click
        Eliminar()
    End Sub


#End Region

    Private Sub Menu_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Menu.Opening
        Menu.Items("Insert").Visible = True
        If griLista.Selected.Rows.Count > 0 Then
            Menu.Items("Update").Visible = True
            Menu.Items("Delete").Visible = True
        Else
            Menu.Items("Update").Visible = False
            Menu.Items("Delete").Visible = False
        End If
    End Sub
   
    Private Sub frm_ConfiguracionMTC_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub

    Private Sub griLista_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griLista.DoubleClick
        If griLista.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub frm_ConfiguracionMTC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gf_AsignarEventoSeleccionarTexto(Me)
            Tiempo1.Enabled = False
            InicializaTiempo()
            'Configurar Grilla
            griLista.DisplayLayout.Bands(0).Columns("Capacidad").Header.Caption = "Capacidad" & Environment.NewLine & "(tm)"
            griLista.DisplayLayout.Bands(0).Columns("LongitudMax").Header.Caption = "Long.Max" & Environment.NewLine & "(m)"
            griLista.DisplayLayout.Bands(0).Columns("CantPesoMaxEje1").Header.Caption = "Peso Eje1" & Environment.NewLine & "(tm)"
            griLista.DisplayLayout.Bands(0).Columns("CantPesoMaxEje2").Header.Caption = "Peso Eje2" & Environment.NewLine & "(tm)"
            griLista.DisplayLayout.Bands(0).Columns("CantPesoMaxEje3").Header.Caption = "Peso Eje3" & Environment.NewLine & "(tm)"
            griLista.DisplayLayout.Bands(0).Columns("CantPesoMaxEje4").Header.Caption = "Peso Eje4" & Environment.NewLine & "(tm)"
            griLista.DisplayLayout.Bands(0).Columns("CantPesoMaxEje5").Header.Caption = "Peso Eje5" & Environment.NewLine & "(tm)"
            griLista.DisplayLayout.Bands(0).Columns("CantPesoMaxEje6").Header.Caption = "Peso Eje6" & Environment.NewLine & "(tm)"
            griLista.DisplayLayout.Bands(0).Columns("CantPesoMaxEje7").Header.Caption = "Peso Eje7" & Environment.NewLine & "(tm)"
            griLista.DisplayLayout.Bands(0).Columns("CantPesoMaxEje8").Header.Caption = "Peso Eje8" & Environment.NewLine & "(tm)"
            griLista.DisplayLayout.Bands(0).Columns("CantPesoMaxEje9").Header.Caption = "Peso Eje9" & Environment.NewLine & "(tm)"
            griLista.DisplayLayout.Bands(0).Columns("CantPesoMaxBruto").Header.Caption = "Peso Bruto" & Environment.NewLine & "(tm)"
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        End Try
    End Sub

    Private Sub frm_ConfiguracionMTC_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case ficDemanda.SelectedTab.Index
                Case 0
                Case 1
                    Select Case e.KeyCode
                        Case Keys.Enter
                            SendKeys.Send("{TAB}")
                    End Select
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        End Try
    End Sub

End Class