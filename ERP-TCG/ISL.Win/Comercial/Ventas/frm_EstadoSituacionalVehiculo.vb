'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.LogicaWCF
Imports ERP.EntidadesWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Microsoft.Office.Interop
Imports Infragistics.Win.UltraWinGrid.ExcelExport

Public Class frm_EstadoSituacionalVehiculo
    Inherits frm_MenuPadre

#Region "Instancia"

    Private Shared instancia As frm_EstadoSituacionalVehiculo = Nothing
    Private Shared Operacion As String

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_EstadoSituacionalVehiculo()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaración de variables"

    Private oeDemanda As e_Demanda
    Private olDemanda As l_Demanda

    Private oeVehiculo As e_Vehiculo
    Private olVehiculo As New l_Vehiculo

    Private oeTipoVehiculo As e_TipoVehiculo
    Private olTipoVehiculo As l_TipoVehiculo

    Private oeViaje As e_Viaje
    Private oeOperacionDetalle As e_OperacionDetalle

    Private oeOperacion As e_Operacion
    Private olOperacion As New l_Operacion

    Private oeUsuario As e_Usuario
    Private olUsuario As l_Usuario

    Private oeZona As e_Flota
    Private olZona As l_Flota

    Private ListaViaje As List(Of e_Viaje)
    Private ListaOperacionDetalle As List(Of e_OperacionDetalle)

    Private _ingresando_datos As Boolean = False

    Private Opcion As Boolean

    Private OrdenEscala As Integer = 0
    Private OrigenEscala As String
    Private OrigenAgrega As String
    Private OperacionEscala As Integer = 1
    Private FechaViaje As Date

    Private oeCombo As e_Combo, olCombo As l_Combo
    Private FechaServidor As Date

    Private oeDespacho As e_Despacho, loDespacho As List(Of e_Despacho), olDespacho As l_Despacho
    Private oeDespachoOperacion As e_DespachoOperaciones, loDespachoOperaciones As List(Of e_DespachoOperaciones), olDespachoOperaciones As l_DespachoOperaciones
    Private loEstados As List(Of e_Estado)
    Private Const IdEstadoGenerado As String = "1CH00014"
    Private Const IdEstadoTerminada As String = "1CH00019"
    Private Const IdZonaNorte As String = "1CH006"
    Private ListEstadoViajeDespacho As List(Of e_Combo)
    Private lstPiloto As List(Of e_Combo)
    Private _acl As String = ""

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Select Case TabDisponibilidad.SelectedTab.Index
                Case 0, 1
                    ListarDisponibilidad()
                    ListarVehiculoSituacional()
                Case 2
                    'Listado Despacho
                    mt_ListarDespacho()
            End Select
            mt_ControlBotoneria()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            ugb_Espera.Visible = False
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            _acl = gAccionSistema.LECTURA.ToString
            If Not ValidarAcl(_acl, pIdActividadNegocio) Then
                Operacion = "Nuevo"
                mt_InicializarControles()
                oeDespacho.Dispose()
                MostrarTabs(1, utcDespacho, 1)
                mt_ControlBotoneria()
                dtpFecha.Focus()
            Else
                Throw New Exception("Usted Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            _acl = gAccionSistema.LECTURA.ToString
            If Not ValidarAcl(_acl, pIdActividadNegocio) Then
                Select Case utcDespachosDinamicos.SelectedTab.Index
                    Case 0
                        If lf_ValidarGrillaVacia(griTab01) Then
                            mt_EditarDespacho(griTab01)
                        End If
                    Case 1
                        If lf_ValidarGrillaVacia(griTab02) Then
                            mt_EditarDespacho(griTab02)
                        End If
                    Case 2
                        If lf_ValidarGrillaVacia(griTab03) Then
                            mt_EditarDespacho(griTab03)
                        End If
                    Case 3
                        If lf_ValidarGrillaVacia(griTab04) Then
                            mt_EditarDespacho(griTab04)
                        End If
                    Case 4
                        If lf_ValidarGrillaVacia(griTab05) Then
                            mt_EditarDespacho(griTab05)
                        End If
                    Case 5
                        If lf_ValidarGrillaVacia(griTab06) Then
                            mt_EditarDespacho(griTab06)
                        End If
                    Case 6
                        If lf_ValidarGrillaVacia(griTab07) Then
                            mt_EditarDespacho(griTab07)
                        End If
                    Case 7
                        If lf_ValidarGrillaVacia(griTab08) Then
                            mt_EditarDespacho(griTab08)
                        End If
                    Case 8
                        If lf_ValidarGrillaVacia(griTab09) Then
                            mt_EditarDespacho(griTab09)
                        End If
                    Case 9
                        If lf_ValidarGrillaVacia(griTab10) Then
                            mt_EditarDespacho(griTab10)
                        End If
                    Case 10
                        If lf_ValidarGrillaVacia(griTab11) Then
                            mt_EditarDespacho(griTab11)
                        End If
                    Case 11
                        If lf_ValidarGrillaVacia(griTab12) Then
                            mt_EditarDespacho(griTab12)
                        End If

                    Case 12
                        If lf_ValidarGrillaVacia(griTab13) Then
                            mt_EditarDespacho(griTab13)
                        End If
                    Case 13
                        If lf_ValidarGrillaVacia(griTab14) Then
                            mt_EditarDespacho(griTab14)
                        End If
                    Case 14
                        If lf_ValidarGrillaVacia(griTab15) Then
                            mt_EditarDespacho(griTab15)
                        End If
                End Select
            Else
                Throw New Exception("Usted Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            _acl = gAccionSistema.LECTURA.ToString
            If Not ValidarAcl(_acl, pIdActividadNegocio) Then
                Operacion = "Eliminar"
                Select Case utcDespachosDinamicos.SelectedTab.Index
                    Case 0
                        If lf_ValidarGrillaVacia(griTab01) Then
                            mt_EliminarDespacho(griTab01)
                        End If
                    Case 1
                        If lf_ValidarGrillaVacia(griTab02) Then
                            mt_EliminarDespacho(griTab02)
                        End If
                    Case 2
                        If lf_ValidarGrillaVacia(griTab03) Then
                            mt_EliminarDespacho(griTab03)
                        End If
                    Case 3
                        If lf_ValidarGrillaVacia(griTab04) Then
                            mt_EliminarDespacho(griTab04)
                        End If
                    Case 4
                        If lf_ValidarGrillaVacia(griTab05) Then
                            mt_EliminarDespacho(griTab05)
                        End If
                    Case 5
                        If lf_ValidarGrillaVacia(griTab06) Then
                            mt_EliminarDespacho(griTab06)
                        End If
                    Case 6
                        If lf_ValidarGrillaVacia(griTab07) Then
                            mt_EliminarDespacho(griTab07)
                        End If
                    Case 7
                        If lf_ValidarGrillaVacia(griTab08) Then
                            mt_EliminarDespacho(griTab08)
                        End If
                    Case 8
                        If lf_ValidarGrillaVacia(griTab09) Then
                            mt_EliminarDespacho(griTab09)
                        End If
                    Case 9
                        If lf_ValidarGrillaVacia(griTab10) Then
                            mt_EliminarDespacho(griTab10)
                        End If
                    Case 10
                        If lf_ValidarGrillaVacia(griTab11) Then
                            mt_EliminarDespacho(griTab11)
                        End If
                    Case 11
                        If lf_ValidarGrillaVacia(griTab12) Then
                            mt_EliminarDespacho(griTab12)
                        End If

                    Case 12
                        If lf_ValidarGrillaVacia(griTab13) Then
                            mt_EliminarDespacho(griTab13)
                        End If
                    Case 13
                        If lf_ValidarGrillaVacia(griTab14) Then
                            mt_EliminarDespacho(griTab14)
                        End If
                    Case 14
                        If lf_ValidarGrillaVacia(griTab15) Then
                            mt_EliminarDespacho(griTab15)
                        End If
                End Select
            Else
                Throw New Exception("Usted Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            _acl = gAccionSistema.LECTURA.ToString
            If Not ValidarAcl(_acl, pIdActividadNegocio) Then
                mt_GuardarDespacho()
            Else
                Throw New Exception("Usted Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If MessageBox.Show("¿Desea cancelar el registro de información?", "Despacho", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                MostrarTabs(0, utcDespacho, 0)
                'mt_ActualizaRegistroEditado()
                mt_ControlBotoneria()
                Operacion = "Inicializa"
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
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

    Public Overrides Sub Exportar()
        Try
            Select Case TabDisponibilidad.SelectedTab.Index
                Case 0 'Disponibilidad Vehiculos
                    ExportarGrillaAExcel(griDisponibleVehiculo)
                Case 1 'Vehiculo Estado Situacional
                    ExportarGrillaAExcel(griVehiculoEstadoSituacional)
                Case 2 'Despacho Transporte
                    Select Case utcDespacho.SelectedTab.Index
                        Case 0 'Listado
                            Dim ListaGrillas As New List(Of UltraWinGrid.UltraGrid)
                            For Each uTab As UltraWinTabControl.UltraTab In utcDespachosDinamicos.Tabs
                                If uTab.Visible Then
                                    Select Case uTab.Index
                                        Case 0
                                            ListaGrillas.Add(griTab01)
                                        Case 1
                                            ListaGrillas.Add(griTab02)
                                        Case 2
                                            ListaGrillas.Add(griTab03)
                                        Case 3
                                            ListaGrillas.Add(griTab04)
                                        Case 4
                                            ListaGrillas.Add(griTab05)
                                        Case 5
                                            ListaGrillas.Add(griTab06)
                                        Case 6
                                            ListaGrillas.Add(griTab07)
                                        Case 7
                                            ListaGrillas.Add(griTab08)
                                        Case 8
                                            ListaGrillas.Add(griTab09)
                                        Case 9
                                            ListaGrillas.Add(griTab10)
                                        Case 10
                                            ListaGrillas.Add(griTab11)
                                        Case 11
                                            ListaGrillas.Add(griTab12)
                                        Case 12
                                            ListaGrillas.Add(griTab13)
                                        Case 13
                                            ListaGrillas.Add(griTab14)
                                        Case 14
                                            ListaGrillas.Add(griTab15)
                                    End Select
                                End If
                            Next
                            ExportarVariasGrillas(ListaGrillas)
                    End Select
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_EstadoSituacionalVehiculo_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            Select Case Operacion
                Case "Nuevo"
                    Me.Activate()
                    'Me.Cancelar()
                Case "Editar"
                    Me.Activate()
                    Me.Cancelar()
            End Select
            e.Cancel = _ingresando_datos
            If Not e.Cancel Then
                ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
            End If
            'mt_ActualizaRegistroEditado()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_EstadoSituacionalVehiculo_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Try
            mt_ControlBotoneria()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub mt_VerificarElementosGrilla(Grid As UltraGrid)
        Try
            If Grid.Rows.Count > 0 Then
                ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
            Else
                ControlBoton(1, 0)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_VerificarElementosGrilla1(Grid As UltraGrid)
        Try
            If Grid.Rows.Count > 0 Then
                ControlBoton(1, 0, 0, 1, 0, 0, 0, 1, 1)
            Else
                ControlBoton(1, 0)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_VerificarElementosGrilla2(Grid As UltraGrid)
        'COMENTADO DESPACHO
        'Try
        '    verCerrarDespacho.Checked = False
        '    oeDespacho = New e_Despacho
        '    olDespacho = New l_Despacho

        '    oeDespacho.FechaDesde = FechaServidor.Date.ToString
        '    oeDespacho = olDespacho.Obtener(oeDespacho)
        '    EditarDespacho()

        '    If Grid.Rows.Count > 0 Then
        '        ControlBoton(1, 0, 0, 1, 0, 0, 0, 1, 1)
        '    Else
        '        ControlBoton(1, 0)
        '    End If
        'Catch ex As Exception
        '    Throw ex
        'End Try
    End Sub

    Private Sub mt_ControlBotoneria()
        Try
            If TabDisponibilidad.SelectedTab IsNot Nothing Then
                Select Case TabDisponibilidad.SelectedTab.Index
                    Case 0
                        mt_VerificarElementosGrilla(griDisponibleVehiculo)
                    Case 1
                        mt_VerificarElementosGrilla(griVehiculoEstadoSituacional)
                    Case 2
                        Select Case utcDespacho.SelectedTab.Index
                            Case 0 'Listado Despacho
                                MostrarTabs(0, utcDespacho, 0)
                                ControlBoton(1, 1, 1, 0, 0, 0, 0, 1, 1)
                            Case 1 'Mantenimiento Despacho
                                ControlBoton(0, 0, 0, 1, 1)
                        End Select
                End Select
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub frm_EstadoSituacionalVehiculo_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            'mt_ActualizaRegistroEditado()
            instancia = Nothing
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_EstadoSituacionalVehiculo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gf_AsignarEventoSeleccionarTexto(Me)
            TabDisponibilidad.Tabs(2).Selected = True
            LlenaCombos()
            ComboGrilla()
            ColorControles()
            FechaServidor = ObtenerFechaServidor()
            mt_InicializarDespacho()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnConsultarDisponibles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultarDisponibles.Click
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            ListarDisponibilidad()
            ugb_Espera.Visible = False
        Catch ex As Exception
            ugb_Espera.Visible = False
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub btnConsultarVehiculo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultarVehiculo.Click
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            ListarVehiculoSituacional()
            ugb_Espera.Visible = False
        Catch ex As Exception
            ugb_Espera.Visible = False
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub griTab01_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griTab01.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub griVehiculoEstadoSituacional_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griVehiculoEstadoSituacional.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub griDisponibleVehiculo_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griDisponibleVehiculo.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub griDemanda_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs)
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub griDisponibleVehiculo_ClickCellButton(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griDisponibleVehiculo.ClickCellButton
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Select Case e.Cell.Column.Key
                Case "Piloto"
                    Dim formulario As frm_FichaPersonal
                    formulario = frm_FichaPersonal
                    formulario.IndCambioPestaña = False
                    If formulario.MostrarTrabajador(griDisponibleVehiculo.ActiveRow.Cells("IdPiloto").Value) Then formulario.ShowDialog()
                    mt_ControlBotoneria()
                Case "Tracto"
                    Dim FRM As New frm_Vehiculo
                    With FRM
                        .IdUnidad = griDisponibleVehiculo.ActiveRow.Cells("IdTracto").Value
                        .IndConsultaGuardar = False
                        .LlenaCombos()
                        .Editar()
                        .StartPosition = FormStartPosition.CenterParent
                        .Size = New Size(800, 650)
                        .ShowDialog()
                        mt_ControlBotoneria()
                    End With
                Case "GlosaEscala"
                    _acl = gAccionSistema.LECTURA.ToString
                    If Not ValidarAcl(_acl, pIdActividadNegocio) Then
                        oeViaje = New e_Viaje
                        oeViaje.TipoOperacion = "C"
                        oeViaje.Id = griDisponibleVehiculo.ActiveRow.Cells("Id").Value
                        oeViaje.UsuarioCreacion = gUsuarioSGI.Id
                        oeViaje.Fecha = Date.Now
                        oeViaje.GlosaEscala = griDisponibleVehiculo.ActiveRow.Cells("GlosaEscala").Value
                        oeViaje.PrefijoID = gs_PrefijoIdSucursal '@0001
                        If olOperacion.GuardarViaje(oeViaje) Then mensajeEmergente.Confirmacion(Me.Text & ": La Informacion ha sido grabada Satisfactoriamente; " & griDisponibleVehiculo.ActiveRow.Cells("GlosaEscala").Value, True)
                    Else
                        Throw New Exception("Usted Tiene Permiso de: " & _acl & " en " & Me.Text)
                    End If
                    
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

    Private Sub griDisponibleVehiculo_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griDisponibleVehiculo.CellChange
        griDisponibleVehiculo.UpdateData()
    End Sub

    Private Sub griDisponibleVehiculo_BeforeCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeCellUpdateEventArgs) Handles griDisponibleVehiculo.BeforeCellUpdate
        With griDisponibleVehiculo
            Select Case e.Cell.Column.Key
                Case "GlosaEscala"
                    If e.Cell.Column.Key = "GlosaEscala" Then If IsDBNull(e.NewValue) Then e.Cancel = True
            End Select
        End With
    End Sub

    Private Sub Programar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Programar.Click
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Dim Operacion As New frm_Operacion
            Operacion = Operacion.getInstancia()
            Operacion.MdiParent = frm_Menu
            Operacion.Show()
            Operacion.ProgramarViajeDisponibilidad(griDisponibleVehiculo.ActiveRow.Cells("Id").Value, griDisponibleVehiculo.ActiveRow.Cells("IdTracto").Value)
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub frm_EstadoSituacionalVehiculo_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub

    Private Sub MenuOperacion_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuOperacion.Opening
        If griDisponibleVehiculo.Selected.Rows.Count > 0 Then
            MenuOperacion.Items("Programar").Visible = True
        Else
            MenuOperacion.Items("Programar").Visible = False
        End If
    End Sub

    Private Sub griDisponibleVehiculo_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles griDisponibleVehiculo.InitializeLayout
        lblListoRegistro.Text = "Lista Registros: " & e.Layout.Rows.Count
    End Sub

    Private Sub griDespachoOperaciones_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs)
        e.DisplayPromptMsg = False
        If MessageBox.Show(Me.Text & ": ¿Desea Eliminar el Registro?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub TabDespacho_Click(sender As Object, e As EventArgs)
        'COMENTADO DESPACHO
        'Try
        '    If TabDespacho.Tabs(0).Selected Then

        '    Else
        '        verCerrarDespacho.Checked = False
        '        oeDespacho = New e_Despacho
        '        olDespacho = New l_Despacho
        '        If TabDespacho.Tabs(1).Selected Then
        '            oeDespacho.FechaDesde = FechaServidor.Date.ToString
        '            oeDespacho = olDespacho.Obtener(oeDespacho)
        '            EditarDespacho()
        '        Else
        '            If TabDespacho.Tabs(2).Selected Then
        '                oeDespacho.FechaDesde = FechaServidor.AddDays(-1).Date.ToString
        '                oeDespacho = olDespacho.Obtener(oeDespacho)
        '                EditarDespacho()
        '            End If
        '        End If
        '    End If
        'Catch ex As Exception
        '    mensajeEmergente.Confirmacion(ex.Message, True)
        'End Try
    End Sub

    Private Sub TabDisponibilidad_SelectedTabChanged(sender As Object, e As UltraWinTabControl.SelectedTabChangedEventArgs) Handles TabDisponibilidad.SelectedTabChanged
        Try
            mt_ControlBotoneria()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub TabDespacho_SelectedTabChanged(sender As Object, e As UltraWinTabControl.SelectedTabChangedEventArgs)
        Try
            mt_ControlBotoneria()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griDetalles_ControlAdded(sender As Object, e As ControlEventArgs) Handles griDetalles.ControlAdded
        Dim textBox As Infragistics.Win.EmbeddableTextBox
        Try
            textBox = TryCast(e.Control, EmbeddableTextBox)
            If textBox IsNot Nothing Then
                AddHandler textBox.MouseWheel, AddressOf textBox_MouseWheel
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            textBox = Nothing
        End Try
    End Sub

    Private Sub textBox_MouseWheel(ByVal sender As Object, ByVal e As MouseEventArgs)
        Try
            Dim args As HandledMouseEventArgs = DirectCast(e, HandledMouseEventArgs)
            If Not args Is Nothing Then
                args.Handled = True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Métodos"

    Public Sub LlenaCombos()
        LlenarComboMaestro(cboRutaOrigen, LugaresPublic, -1)
        LlenarComboMaestro(cboZonaDisponibles, ZonaPublic, 0)
        LlenarComboMaestro(cboZonaVehiculo, ZonaPublic, 0)

        'COMENTADO DESPACHO
        'LlenarComboMaestro(cboZona, ZonaPublic, 0)
        'LlenarComboMaestro(cboCentro, CentroPublic, 0)
    End Sub

    Private Sub ComboGrilla()
        Dim Lugar As New DataTable
        Dim Cliente As New DataTable

        olCombo = New l_Combo
        Cliente = olCombo.ComboGrilla(ClientesPublic)
        'COMENTADO DESPACHO
        'CrearComboGrid("Cliente", "Nombre", griDespachoOperaciones, Cliente, False)

        Lugar = olCombo.ComboGrilla(LugaresPublic)

        'CrearComboGrid("Origen", "Nombre", griDespachoOperaciones, Lugar, False)

        'CrearComboGrid("Destino", "Nombre", griDespachoOperaciones, Lugar, False)

        'CrearComboGrid("Piloto", "Nombre", griDespachoOperaciones, olCombo.ComboGrilla(PilotoPublic.Where(Function(Item) Item.Descripcion = True).ToList), False)

        'CrearComboGrid("Copiloto", "Nombre", griDespachoOperaciones, olCombo.ComboGrilla(CopilotoPublic.Where(Function(Item) Item.Descripcion = True).ToList), False)

        'CrearComboGrid("Tracto", "Nombre", griDespachoOperaciones, olCombo.ComboGrilla(TractoPublic), False)

        'CrearComboGrid("Carreta", "Nombre", griDespachoOperaciones, olCombo.ComboGrilla(CarretaPublic), False)

    End Sub

    Public Sub ListarOperacionesUltimas()
        'COMENTADO DESPACHO
        'Try
        '    ugb_Espera.Visible = True
        '    Application.DoEvents()
        '    Cursor.Current = Cursors.WaitCursor
        '    Cursor.Show()
        '    olDespacho = New l_Despacho
        '    oeDespacho = New e_Despacho
        '    oeDespachoOperacion = New e_DespachoOperaciones
        '    Dim griLista As UltraWinGrid.UltraGrid
        '    With oeDespachoOperacion
        '        If TabDespacho.Tabs(0).Selected Then
        '            If opcDespacho.CheckedIndex = 0 Then
        '                .TipoOperacion = "0"
        '            Else
        '                .TipoOperacion = "1"
        '            End If
        '            oeDespacho.FechaDesde = fecDespacho.Value
        '            oeDespacho = olDespacho.Obtener(oeDespacho)
        '            If oeDespacho.Id = "" Then
        '                LimpiaGrid(griDespachoOperaciones, ogdDespachoOperaciones)
        '                griLista = griDespachoOperaciones
        '                ListarGrilla(griLista)
        '            Else
        '                fecDespacho.Focus()
        '                TabDespacho.Tabs(1).Selected = True
        '                Throw New Exception("Ya se genero Despacho para esta fecha verificar")
        '            End If
        '        Else
        '            If TabDespacho.Tabs(1).Selected Then
        '                LimpiaGrid(griDespachoOperaciones, ogdDespachoOperaciones)
        '                LimpiaGrid(griDespacho01, ogdDespachoOperaciones)
        '                LimpiaGrid(griDespacho02, ogdDespachoOperaciones)
        '                LimpiaGrid(griDespacho03, ogdDespachoOperaciones)
        '                LimpiaGrid(griDespacho04, ogdDespachoOperaciones)
        '                LimpiaGrid(griDespacho05, ogdDespachoOperaciones)
        '                LimpiaGrid(griDespacho06, ogdDespachoOperaciones)
        '                LimpiaGrid(griDespacho07, ogdDespachoOperaciones)
        '                LimpiaGrid(griDespacho08, ogdDespachoOperaciones)
        '                LimpiaGrid(griDespacho09, ogdDespachoOperaciones)
        '                LimpiaGrid(griDespacho10, ogdDespachoOperaciones)
        '                LimpiaGrid(griDespacho11, ogdDespachoOperaciones)
        '                LimpiaGrid(griDespacho12, ogdDespachoOperaciones)
        '                LimpiaGrid(griDespacho13, ogdDespachoOperaciones)
        '                LimpiaGrid(griDespacho14, ogdDespachoOperaciones)
        '                oeDespacho.FechaDesde = FechaServidor.Date.ToString
        '                oeDespacho = olDespacho.Obtener(oeDespacho)
        '                EditarDespacho()
        '                .TipoOperacion = "2"
        '                .IdDespacho = oeDespacho.Id
        '                griLista = griDespacho01
        '                griDespacho01.Text = "DESPACHO : " & FechaServidor.Date.ToString
        '                ListarGrilla(griLista)
        '                For I As Integer = 1 To 14 Step 1
        '                    oeDespacho = New e_Despacho
        '                    oeDespacho.FechaDesde = FechaServidor.Date.AddDays(-I)
        '                    oeDespacho = olDespacho.Obtener(oeDespacho)
        '                    If oeDespacho.Id <> "" Then
        '                        Select Case I
        '                            Case 1
        '                                griDespacho02.Text = "DESPACHO : " & FechaServidor.Date.AddDays(-I).ToString
        '                                ListarGrilla(griDespacho02)
        '                            Case 2
        '                                griDespacho03.Text = "DESPACHO : " & FechaServidor.Date.AddDays(-I).ToString
        '                                ListarGrilla(griDespacho03)
        '                            Case 3
        '                                griDespacho04.Text = "DESPACHO : " & FechaServidor.Date.AddDays(-I).ToString
        '                                ListarGrilla(griDespacho04)
        '                            Case 4
        '                                griDespacho05.Text = "DESPACHO : " & FechaServidor.Date.AddDays(-I).ToString
        '                                ListarGrilla(griDespacho05)
        '                            Case 5
        '                                griDespacho06.Text = "DESPACHO : " & FechaServidor.Date.AddDays(-I).ToString
        '                                ListarGrilla(griDespacho06)
        '                            Case 6
        '                                griDespacho07.Text = "DESPACHO : " & FechaServidor.Date.AddDays(-I).ToString
        '                                ListarGrilla(griDespacho07)
        '                            Case 7
        '                                griDespacho08.Text = "DESPACHO : " & FechaServidor.Date.AddDays(-I).ToString
        '                                ListarGrilla(griDespacho08)
        '                            Case 8
        '                                griDespacho09.Text = "DESPACHO : " & FechaServidor.Date.AddDays(-I).ToString
        '                                ListarGrilla(griDespacho09)
        '                            Case 9
        '                                griDespacho10.Text = "DESPACHO : " & FechaServidor.Date.AddDays(-I).ToString
        '                                ListarGrilla(griDespacho10)
        '                            Case 10
        '                                griDespacho11.Text = "DESPACHO : " & FechaServidor.Date.AddDays(-I).ToString
        '                                ListarGrilla(griDespacho11)
        '                            Case 11
        '                                griDespacho12.Text = "DESPACHO : " & FechaServidor.Date.AddDays(-I).ToString
        '                                ListarGrilla(griDespacho12)
        '                            Case 12
        '                                griDespacho13.Text = "DESPACHO : " & FechaServidor.Date.AddDays(-I).ToString
        '                                ListarGrilla(griDespacho13)
        '                            Case 13
        '                                griDespacho14.Text = "DESPACHO : " & FechaServidor.Date.AddDays(-I).ToString
        '                                ListarGrilla(griDespacho14)
        '                        End Select
        '                    End If
        '                Next
        '            End If
        '        End If
        '    End With
        'Catch ex As Exception
        '    Throw ex
        'Finally
        '    Windows.Forms.Cursor.Current = Cursors.Default
        '    Cursor.Show()
        '    ugb_Espera.Visible = False
        'End Try
    End Sub

    Public Sub ListarGrilla(ByVal griLista As UltraWinGrid.UltraGrid)
        'COMENTADO DESPACHO
        'griLista.DataSource = olDespacho.ListarOperaciones(oeDespachoOperacion)
        'For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griLista.Rows
        '    Select Case fila.Cells("Estado").Value
        '        Case "PROGRAMADO"
        '            fila.CellAppearance.BackColor = Me.ColorProgramado.Color
        '        Case "CARGA"
        '            fila.CellAppearance.BackColor = Me.ColorCarga.Color
        '        Case "TRANSITO"
        '            fila.CellAppearance.BackColor = Me.ColorTransito.Color
        '        Case "DESCARGA"
        '            fila.CellAppearance.BackColor = Me.ColorDescarga.Color
        '        Case "FIN"
        '            fila.CellAppearance.BackColor = Me.ColorFin.Color
        '    End Select
        '    Select Case fila.Cells("TipoVehiculo").Value
        '        Case "PLATAFORMA"
        '            fila.Cells("Carreta").Appearance.BackColor = Me.ColorPlataforma.Color
        '        Case "FURGON"
        '            fila.Cells("Carreta").Appearance.BackColor = Me.ColorFurgon.Color
        '        Case "GRANELERO"
        '            fila.Cells("Carreta").Appearance.BackColor = Me.ColorGranelero.Color
        '        Case "FURGON LARGO"
        '            fila.Cells("Carreta").Appearance.BackColor = Me.ColorFurgonLargo.Color
        '        Case "CONTENEDOR"
        '            fila.Cells("Carreta").Appearance.BackColor = Me.ColorContenedor.Color
        '        Case "CAMION 20 M3"
        '            fila.Cells("Carreta").Appearance.BackColor = Me.ColorCamion20M3.Color
        '        Case "CAMION 40 M3"
        '            fila.Cells("Carreta").Appearance.BackColor = Me.ColorCamion40M3.Color
        '        Case "VOLQUETE"
        '            fila.Cells("Carreta").Appearance.BackColor = Me.ColorVolquete.Color
        '        Case "CALICERA"
        '            fila.Cells("Carreta").Appearance.BackColor = Me.ColorCalicera.Color
        '        Case "TOLVA DE VOLTEO"
        '            fila.Cells("Carreta").Appearance.BackColor = Me.ColorTolvaVolteo.Color
        '        Case "MEDIA BARANDA"
        '            fila.Cells("Carreta").Appearance.BackColor = Me.ColorMediaBaranda.Color
        '        Case "CAMIONETA"
        '            fila.Cells("Carreta").Appearance.BackColor = Me.ColorCamioneta.Color
        '        Case "CAMION 30 M3"
        '            fila.Cells("Carreta").Appearance.BackColor = Me.ColorCamion30M3.Color
        '        Case "CAMION 50 M3"
        '            fila.Cells("Carreta").Appearance.BackColor = Me.ColorCamion65M3.Color
        '        Case "CAMION 65 M3"
        '            fila.Cells("Carreta").Appearance.BackColor = Me.ColorCamion65M3.Color
        '    End Select
        'Next
        'CalcularTotales(griLista, "Tonelada", "Monto", "TotalFlete")
    End Sub

    Public Sub ListarDisponibilidad()
        Try
            LimpiaGrid(griDisponibleVehiculo, ogdDisponibleVehiculos)
            oeViaje = New e_Viaje
            With oeViaje
                .ViajeVacio = 2
                .IndMotriz = 1
                .Zona = cboZonaDisponibles.Value
                .IdDestino = cboRutaOrigen.Value
            End With
            griDisponibleVehiculo.DataSource = olOperacion.ListarViaje(oeViaje)
            For I As Integer = 0 To griDisponibleVehiculo.Rows.Count - 1
                With griDisponibleVehiculo.Rows(I)
                    Select Case .Cells("TipoVehiculo").Value
                        Case "PLATAFORMA"
                            .Cells("Carreta").Appearance.BackColor = Me.ColorPlataformaD.Color
                        Case "FURGON"
                            .Cells("Carreta").Appearance.BackColor = Me.ColorFurgonD.Color
                        Case "GRANELERO"
                            .Cells("Carreta").Appearance.BackColor = Me.ColorGraneleroD.Color
                        Case "FURGON LARGO"
                            .Cells("Carreta").Appearance.BackColor = Me.ColorFurgonLargoD.Color
                        Case "CONTENEDOR"
                            .Cells("Carreta").Appearance.BackColor = Me.ColorContenedorD.Color
                        Case "CAMION 20 M3"
                            .Cells("Carreta").Appearance.BackColor = Me.ColorCamion20M3D.Color
                        Case "CAMION 40 M3"
                            .Cells("Carreta").Appearance.BackColor = Me.ColorCamion40M3D.Color
                        Case "VOLQUETE"
                            .Cells("Carreta").Appearance.BackColor = Me.ColorVolqueteD.Color
                        Case "CALICERA"
                            .Cells("Carreta").Appearance.BackColor = Me.ColorCaliceraD.Color
                        Case "TOLVA DE VOLTEO"
                            .Cells("Carreta").Appearance.BackColor = Me.ColorTolvaVolteoD.Color
                        Case "MEDIA BARANDA"
                            .Cells("Carreta").Appearance.BackColor = Me.ColorMediaBarandaD.Color
                        Case "CAMIONETA"
                            .Cells("Carreta").Appearance.BackColor = Me.ColorCamionetaD.Color
                        Case "CAMION 30 M3"
                            .Cells("Carreta").Appearance.BackColor = Me.ColorCamion30M3D.Color
                        Case "CAMION 65 M3"
                            .Cells("Carreta").Appearance.BackColor = Me.ColorCamion65M3D.Color
                    End Select
                    If .Cells("DisponibleP").Value = False Then
                        .Appearance.BackColor = Me.ColorAdvertencia.Color
                        .Cells("Piloto").Appearance.BackColor = Me.ColorPiloto.Color
                    End If
                    If .Cells("DisponibleC").Value = False Then
                        .Appearance.BackColor = Me.ColorAdvertencia.Color
                        .Cells("CoPiloto").Appearance.BackColor = Me.ColorCopiloto.Color
                    End If
                    'If .Cells("DisponibleA").Value = False Then
                    '    .Appearance.BackColor = Me.ColorAdvertencia.Color
                    '    .Cells("Ayudante").Appearance.BackColor = Me.ColorAyudante.Color
                    'End If
                    If Not olVehiculo.ValidarTractoMantenimiento(.Cells("IdTracto").Value) Then
                        .Appearance.BackColor = Me.ColorAdvertencia.Color
                        .Cells("Tracto").Appearance.BackColor = Me.ColorTracto.Color
                    End If
                    If .Cells("IdCarreta").Value <> "" Then
                        If Not olVehiculo.ValidarCarretaMantenimiento(.Cells("IdCarreta").Value) Then
                            .Appearance.BackColor = Me.ColorAdvertencia.Color
                            .Cells("Carreta").Appearance.BackColor = Me.ColorCarreta.Color
                        End If
                    End If
                End With

            Next
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Sub ListarVehiculoSituacional()
        Try
            LimpiaGrid(griVehiculoEstadoSituacional, ogdVehiculoEstadoSituacional)
            griVehiculoEstadoSituacional.DataSource = olOperacion.ListarVehiculoEstadoSituacional()
            For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griVehiculoEstadoSituacional.Rows
                Select Case fila.Cells("EstadoOperacion").Value
                    Case "DISPONIBLE"
                        fila.CellAppearance.BackColor = Me.ColorDisponible.Color
                    Case "EN RUTA"
                        fila.CellAppearance.BackColor = Me.ColorRuta.Color
                End Select

                Select Case fila.Cells("EstadoMantenimiento").Value
                    Case "EN MANTENIMIENTO"
                        fila.CellAppearance.BackColor = Me.ColorMantenimiento.Color
                End Select
            Next
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub ColorControles()
        '----------------------------------------------
        '------Tipo de Vehiculo------------------------
        ColorPlataformaD.Color = Color.Coral
        ColorFurgonLargoD.Color = Color.PeachPuff
        ColorMediaBarandaD.Color = Color.Orange
        ColorFurgonD.Color = Color.Gold
        ColorCaliceraD.Color = Color.DarkKhaki
        ColorContenedorD.Color = Color.OliveDrab
        ColorGraneleroD.Color = Color.YellowGreen
        ColorParihueleroD.Color = Color.PaleGreen
        ColorTolvaVolteoD.Color = Color.RosyBrown
        ColorVolqueteD.Color = Color.Peru
        ColorCamionetaD.Color = Color.LightGreen
        ColorCamion65M3D.Color = Color.MediumSpringGreen
        ColorCamion20M3D.Color = Color.PaleTurquoise
        ColorCamion30M3D.Color = Color.DeepSkyBlue
        ColorCamion40M3D.Color = Color.Violet
        'Colores de Tipo de Vehiculo Carreta
        ColorPlataforma.Color = Color.Yellow
        ColorFurgonLargo.Color = Color.Coral
        ColorMediaBaranda.Color = Color.Orange
        ColorFurgon.Color = Color.DarkKhaki
        ColorCalicera.Color = Color.Gold
        ColorGranelero.Color = Color.YellowGreen
        ColorParihuelero.Color = Color.PeachPuff
        ColorTolvaVolteo.Color = Color.RosyBrown
        ColorCisterna.Color = Color.Peru
        ColorFurgonAmericano.Color = Color.LightGreen
        ColorBaranda.Color = Color.PaleTurquoise
        ColorBomboma.Color = Color.DeepSkyBlue
        'Colores Detalles
        PlataformaM.Color = Color.Yellow
        FurgonLargoM.Color = Color.Coral
        MediaBarandaM.Color = Color.Orange
        FurgonM.Color = Color.DarkKhaki
        CaliceraM.Color = Color.Gold
        GraneleroM.Color = Color.YellowGreen
        ParihueleroM.Color = Color.PeachPuff
        TolvaVolteoM.Color = Color.RosyBrown
        CisternaM.Color = Color.Peru
        FurgonAmericanoM.Color = Color.LightGreen
        BarandaM.Color = Color.PaleTurquoise
        BombomaM.Color = Color.DeepSkyBlue

        '----------------------------------------------
        '------Dispinibilidad-----------------------
        ColorAdvertencia.Color = Color.Red
        ColorPiloto.Color = Color.Orange
        ColorCopiloto.Color = Color.Yellow
        ColorAyudante.Color = Color.Lime
        ColorTracto.Color = Color.DarkCyan
        ColorCarreta.Color = Color.Blue
        'Leyenda grilla Detalles
        colorCamposNoEncontrados.Color = Color.LightBlue
        colorMant.Color = Color.MediumAquamarine
        colorMantUrgente.Color = Color.OrangeRed
        colorCeldaResaltada.Color = Color.DarkKhaki
        colorColumnaEstado.Color = Color.PaleGreen
    End Sub

    Private Function GuardarOperacion() As Boolean
        'COMENTADO DESPACHO
        'Try
        '    ugb_Espera.Visible = True
        '    Application.DoEvents()
        '    Cursor.Current = Cursors.WaitCursor
        '    Cursor.Show()
        '    olDespacho = New l_Despacho
        '    oeDespacho = New e_Despacho
        '    ValidarComboValue(cboCentro, "Centro/Sucursal Despacho")
        '    With oeDespacho
        '        .TipoOperacion = "I"
        '        .Codigo = ""
        '        If TabDespacho.Tabs(0).Selected Then
        '            .Id = ""
        '            .Fecha = Date.Parse(fecDespacho.Value.ToShortDateString & " " & hDespacho.Value.ToShortTimeString)
        '            .IdEstado = "1CH00014"
        '            .ListDespachoOperacion = griDespachoOperaciones.DataSource
        '        Else
        '            .Id = txtIdDespacho.Text
        '            If verCerrarDespacho.Checked Then
        '                .IdEstado = "1CH00019"
        '            Else
        '                If txtEstadoDespacho.Text = "GENERADA" Then
        '                    .IdEstado = "1CH00014"
        '                Else
        '                    .IdEstado = "1CH00019"
        '                End If
        '            End If
        '            If TabDespacho.Tabs(1).Selected Then
        '                .ListDespachoOperacion = griDespacho01.DataSource
        '            Else
        '                If TabDespacho.Tabs(2).Selected Then
        '                    .ListDespachoOperacion = griDespacho02.DataSource
        '                End If
        '            End If
        '        End If
        '        .IdCentro = cboCentro.Value
        '        .ProdReal = txtProdReal.Value
        '        .ProdProgramado = txtProdProgramado.Value
        '        .ProdTotal = txtProdTotal.Value
        '        .Glosa = txtGlosa.Text.Trim()
        '        .Observacion = txtObservacion.Text.Trim()
        '        .UsuarioCrea = gUsuarioSGI.Id
        '    End With
        '    If oeDespacho.ListDespachoOperacion.Where(Function(Item) Item.Seleccion = True).Count > 0 Then
        '        If olDespacho.Guardar(oeDespacho) Then
        '            mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente.", True)
        '            If TabDespacho.Tabs(0).Selected Then
        '                verCerrarDespacho.Checked = False
        '                LimpiaGrid(griDespachoOperaciones, ogdDespachoOperaciones)
        '                TabDespacho.Tabs(1).Selected = True
        '            End If
        '        End If
        '    Else
        '        Throw New Exception("No hay registros para guardar verificar su informacion")
        '    End If
        'Catch ex As Exception
        '    mensajeEmergente.Problema(ex.Message, True)
        'Finally
        '    Windows.Forms.Cursor.Current = Cursors.Default
        '    Cursor.Show()
        '    ugb_Espera.Visible = False
        'End Try
    End Function

    Public Function EditarDespacho() As Boolean
        'COMENTADO DESPACHO
        'Try
        '    With oeDespacho
        '        If .Id <> "" Then
        '            txtIdDespacho.Text = .Id
        '            cboCentro.Value = .IdCentro
        '            fecDespacho.Value = .Fecha.Date
        '            hDespacho.Value = .Fecha.ToShortTimeString
        '            txtProdReal.Value = .ProdReal
        '            txtProdProgramado.Value = .ProdProgramado
        '            txtProdTotal.Value = .ProdTotal
        '            txtEstadoDespacho.Text = .IdEstado
        '            txtGlosa.Text = .Glosa
        '            txtObservacion.Text = .Observacion
        '        Else
        '            TabDespacho.Tabs(0).Selected = True
        '            Throw New Exception("Aun no se a generado/consultado Despacho para el Dia Actual")
        '        End If
        '    End With
        'Catch ex As Exception
        '    Throw ex
        'End Try
    End Function

#End Region

#Region "Despacho"

#Region "Metodos"

    Private Sub mt_InicializarDespacho()
        Try
            mt_LlenarEstadoViajeDespacho()
            ugbTotalesMantenimiento.Visible = False
            olDespacho = New l_Despacho
            olDespachoOperaciones = New l_DespachoOperaciones
            oeDespacho = New e_Despacho
            loDespacho = New List(Of e_Despacho)
            'Llenar Combo Centro Filtro
            LlenarComboMaestro(cboCentroFiltro, CentroPublic, 0)
            cboCentroFiltro.Value = ObtenerCentro(gs_PrefijoIdSucursal).Id
            'Llenar Combo Estado
            Dim olEstado As New l_Estado
            loEstados = New List(Of e_Estado)
            loEstados.AddRange(olEstado.Listar(New e_Estado With {.Nombre = "CONFIGURACION"}).OrderBy(Function(x) x.Nombre).ToList())
            loEstados.Insert(0, New e_Estado With {.Id = String.Empty, .Nombre = "TODOS"})
            LlenarComboMaestro(cboEstadoFiltro, loEstados, 0)
            LlenarComboMaestro(cboEstado, loEstados.Where(Function(x) x.Id <> String.Empty).ToList(), 0)
            'Llenar Combo Zonas
            LlenarComboMaestro(cboZonaListado, ZonaPublic, 0)
            If CType(cboZonaListado.DataSource, List(Of e_Combo)).Where(Function(x) x.Id = IdZonaNorte).Count > 0 Then
                cboZonaListado.Value = IdZonaNorte
            End If
            'Enlazar Lista Detalles con Grilla
            loDespachoOperaciones = New List(Of e_DespachoOperaciones)
            griDetalles.DataSource = loDespachoOperaciones
            'Otras Coonfiguraciones
            dtpHastaFiltro.Value = FechaServidor.Date
            dtpDesdeFiltro.Value = FechaServidor.AddDays(-3).Date
            For Each uTab As UltraWinTabControl.UltraTab In utcDespachosDinamicos.Tabs
                uTab.Visible = False
            Next
            utcDespachosDinamicos.Tabs(0).Visible = True
            utcDespachosDinamicos.Tabs(1).Visible = True
            utcDespachosDinamicos.Tabs(1).Text = "..."
            utcDespachosDinamicos.Tabs(1).Enabled = False
            'Llenar Lista Pilotos con NINGUNO
            lstPiloto = New List(Of e_Combo)
            lstPiloto.AddRange(PilotoPublic)
            oeCombo = New e_Combo
            oeCombo.Id = 0 : oeCombo.Nombre = "NINGUNO" : oeCombo.Descripcion = True
            lstPiloto.Insert(0, oeCombo)
            'Combo Grilla para Detalles
            mt_ConfigurarGrilla(griDetalles, True)
            'Combo Grilla para Listado
            mt_ConfigurarGrilla(griTab01, False)
            mt_ConfigurarGrilla(griTab02, False)
            mt_ConfigurarGrilla(griTab03, False)
            mt_ConfigurarGrilla(griTab04, False)
            mt_ConfigurarGrilla(griTab05, False)
            mt_ConfigurarGrilla(griTab06, False)
            mt_ConfigurarGrilla(griTab07, False)
            mt_ConfigurarGrilla(griTab08, False)
            mt_ConfigurarGrilla(griTab09, False)
            mt_ConfigurarGrilla(griTab10, False)
            mt_ConfigurarGrilla(griTab11, False)
            mt_ConfigurarGrilla(griTab12, False)
            mt_ConfigurarGrilla(griTab13, False)
            mt_ConfigurarGrilla(griTab14, False)
            mt_ConfigurarGrilla(griTab15, False)
            'Configurar Grilla para Exportar a Excel
            OcultarColumna2(griFormatoClientes, False, "Hora", "TipoVehiculoCarreta", "Piloto", "Copiloto", "NroCelular", "IdTracto", _
                            "Carreta", "NroMTC", "NroMTCCarreta", "Tonelada", "Brevete", "Cliente", "Origen", "Destino", "Disponible", "Zona", _
                            "Estado")
            With griFormatoClientes.DisplayLayout.Bands(0)
                'Columns("Hora").Header.VisiblePosition = 1
                .Columns("Hora").Header.Caption = "Fecha"
                '.Columns("TipoVehiculoCarreta").Header.VisiblePosition = 2
                .Columns("TipoVehiculoCarreta").Header.Caption = "Tipo Unidad"
                '.Columns("Piloto").Header.VisiblePosition = 3
                '.Columns("Copiloto").Header.VisiblePosition = 4
                '.Columns("NroCelular").Header.VisiblePosition = 5
                '.Columns("IdTracto").Header.VisiblePosition = 6
                .Columns("IdTracto").Header.Caption = "Tracto"
                '.Columns("Carreta").Header.VisiblePosition = 7
                '.Columns("NroMTC").Header.VisiblePosition = 8
                .Columns("NroMTC").Header.Caption = "MTC Tracto"
                .Columns("NroMTCCarreta").Hidden = False
                '.Columns("NroMTCCarreta").Header.VisiblePosition = 9
                .Columns("NroMTCCarreta").Header.Caption = "MTC Carreta"
                '.Columns("Tonelada").Header.VisiblePosition = 10
                .Columns("Tonelada").Header.Caption = "Peso (TN)"
                '.Columns("Brevete").Header.VisiblePosition = 11
                '.Columns("Cliente").Header.VisiblePosition = 12
                '.Columns("Origen").Header.VisiblePosition = 13
                '.Columns("Destino").Header.VisiblePosition = 14
                '.Columns("Disponible").Header.VisiblePosition = 15
                .Columns("Disponible").Header.Caption = "Hora Aprox."
                '.Columns("Zona").Header.VisiblePosition = 16
                '.Columns("Estado").Header.VisiblePosition = 17
                FormatoColumna(griFormatoClientes, "dd/MM/yyyy", ColumnStyle.Date, HAlign.Left, "Hora")
                FormatoColumna(griFormatoClientes, "#,##0.00", ColumnStyle.Double, HAlign.Right, "Tonelada", "Monto")
                griDetalles.DisplayLayout.Bands(0).Columns("EstadoAceptar").CellActivation = Activation.AllowEdit
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_LlenarEstadoViajeDespacho()
        Try
            ListEstadoViajeDespacho = New List(Of e_Combo)() From {
                                                New e_Combo With {.Id = "CARGA", .Nombre = "CARGA"}, _
                                                New e_Combo With {.Id = "R.VACIO", .Nombre = "R.VACIO"}, _
                                                New e_Combo With {.Id = "SIN CARGA", .Nombre = "SIN CARGA"}, _
                                                New e_Combo With {.Id = "TALLER", .Nombre = "TALLER"}, _
                                                New e_Combo With {.Id = "TRANSITO", .Nombre = "TRANSITO"}, _
                                                New e_Combo With {.Id = "X DESCARGAR", .Nombre = "X DESCARGAR"}, _
                                                New e_Combo With {.Id = "SINIESTRO", .Nombre = "SINIESTRO"}, _
                                                New e_Combo With {.Id = "SIN CONDUCTOR", .Nombre = "SIN CONDUCTOR"}, _
                                                New e_Combo With {.Id = "INCIDENTE", .Nombre = "INCIDENTE"}
                                             }.ToList()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_ConfigurarGrilla(Grid As UltraWinGrid.UltraGrid, bolGrillaDetalle As Boolean)
        Try
            Grid.Font = New System.Drawing.Font("Tahoma", 6.75!)
            'Diseño
            If bolGrillaDetalle Then
                OcultarColumna2(Grid, False, "Seleccion", "Piloto", "Copiloto", "NroCelular", "IdMarcaVehiculo", "IdTracto", "GlosaN", "Carreta", "Zona", "Origen", "Destino", "IdEscala", _
                           "Estado", "EstadoAceptar", "Glosa", "ClienteProg", "Tonelada", "MNTO", "TotalFleteProg", "ClienteGlosa", "Hora", "EstadoGlosa", "Disponible", "CodigoViajeProg")
            Else
                OcultarColumna2(Grid, False, "Seleccion", "Piloto", "Copiloto", "NroCelular", "IdMarcaVehiculo", "IdTracto", "GlosaN", "Carreta", "Zona", "Origen", "Destino", "IdEscala", _
                           "Estado", "Glosa", "ClienteProg", "Tonelada", "MNTO", "TotalFleteProg", "ClienteGlosa", "Hora", "EstadoGlosa", "Disponible", "CodigoViajeProg")
            End If
            With Grid.DisplayLayout.Bands(0)
                Grid.DisplayLayout.UseFixedHeaders = True
                'Posicion
                .Columns("Seleccion").Header.Fixed = True
                .Columns("Seleccion").Header.Caption = ""
                .Columns("Seleccion").Width = 25
                .Columns("Seleccion").Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Always
                .Columns("Piloto").Header.Fixed = True
                .Columns("Piloto").CharacterCasing = CharacterCasing.Upper
                .Columns("Piloto").Width = 180
                .Columns("Copiloto").Header.Fixed = True
                .Columns("Copiloto").CharacterCasing = CharacterCasing.Upper
                .Columns("Copiloto").Width = 150
                .Columns("NroCelular").Header.Fixed = True
                .Columns("NroCelular").CharacterCasing = CharacterCasing.Upper
                .Columns("NroCelular").Width = 70
                .Columns("IdMarcaVehiculo").Header.Caption = "MarcaVehiculo"
                .Columns("IdMarcaVehiculo").Header.Fixed = True
                .Columns("IdMarcaVehiculo").CharacterCasing = CharacterCasing.Upper
                .Columns("IdMarcaVehiculo").Width = 79
                .Columns("IdTracto").Header.Caption = "Tracto"
                .Columns("IdTracto").Header.Fixed = True
                .Columns("IdTracto").Width = 60
                .Columns("IdTracto").CharacterCasing = CharacterCasing.Upper
                .Columns("GlosaN").Header.Fixed = True
                .Columns("GlosaN").Hidden = True
                .Columns("Carreta").Header.Fixed = True
                .Columns("Carreta").Width = 60
                .Columns("Carreta").CharacterCasing = CharacterCasing.Upper
                .Columns("Zona").CharacterCasing = CharacterCasing.Upper
                .Columns("Zona").Width = 65
                .Columns("Origen").CharacterCasing = CharacterCasing.Upper
                .Columns("Origen").Width = 115
                .Columns("IdEscala").Header.Caption = "Escala"
                .Columns("IdEscala").Width = 90
                .Columns("IdEscala").CharacterCasing = CharacterCasing.Upper
                .Columns("Destino").CharacterCasing = CharacterCasing.Upper
                .Columns("Destino").Width = 115
                .Columns("Estado").CharacterCasing = CharacterCasing.Upper
                .Columns("Estado").Width = 80
                .Columns("Glosa").CharacterCasing = CharacterCasing.Upper
                .Columns("Glosa").Width = 150
                .Columns("ClienteProg").CharacterCasing = CharacterCasing.Upper
                .Columns("ClienteProg").Width = 150
                .Columns("Tonelada").Header.Caption = "Peso (TN)"
                .Columns("Tonelada").Width = 50
                .Columns("MNTO").Header.Caption = "Mant."
                .Columns("MNTO").CharacterCasing = CharacterCasing.Upper
                .Columns("MNTO").Width = 50
                .Columns("TotalFleteProg").Header.Caption = "Producción (S/)"
                .Columns("TotalFleteProg").Width = 70
                .Columns("ClienteGlosa").CharacterCasing = CharacterCasing.Upper
                .Columns("ClienteGlosa").Header.Caption = "Cliente Anterior"
                .Columns("ClienteGlosa").Width = 200
                .Columns("Hora").CharacterCasing = CharacterCasing.Upper
                .Columns("Hora").Width = 40
                .Columns("EstadoGlosa").CharacterCasing = CharacterCasing.Upper
                .Columns("Disponible").CharacterCasing = CharacterCasing.Upper
                FormatoColumna(Grid, "HH:mm", ColumnStyle.Time, HAlign.Left, "Hora")
                FormatoColumna(Grid, "#,##0.00", ColumnStyle.Double, HAlign.Right, "Tonelada", "Monto", "TotalFleteProg")
                .Columns("Hora").MaskInput = "hh:mm"
                .Columns("IdViaje").Header.Caption = "IdViaje"
                .Columns("IdViaje").Width = 100
                .Columns("CodigoViajeProg").Header.Caption = "ViajeProg"
                .Columns("CodigoViajeProg").Width = 100
                .Columns("IdTractoProg").Header.Caption = "TractoProg"
                .Columns("IdTractoProg").Width = 60
                .Columns("IdCarretaProg").Header.Caption = "CarretaProg"
                .Columns("IdCarretaProg").Width = 60
                .Columns("IdPilotoProg").Header.Caption = "PilotoProg"
                .Columns("IdPilotoProg").Width = 200
                .Columns("IdCopilotoProg").Header.Caption = "CopilotoProg"
                .Columns("IdCopilotoProg").Width = 200
                .Columns("IdOrigenProg").Header.Caption = "OrigenProg"
                .Columns("IdOrigenProg").Width = 150
                .Columns("IdDestinoProg").Header.Caption = "DestinoProg"
                .Columns("IdDestinoProg").Width = 150
            End With
            'Combos Grilla
            Dim Lugar As New DataTable
            Dim Cliente As New DataTable
            olCombo = New l_Combo
            Cliente = olCombo.ComboGrilla(ClientesPublic)
            Lugar = olCombo.ComboGrilla(LugaresPublic)
            CrearComboGrid("Cliente", "Nombre", Grid, Cliente, False)
            CrearComboGrid("Origen", "Nombre", Grid, Lugar, False)
            CrearComboGrid("IdOrigenProg", "Nombre", Grid, Lugar, False)
            CrearComboGrid("Destino", "Nombre", Grid, Lugar, False)
            CrearComboGrid("IdDestinoProg", "Nombre", Grid, Lugar, False)
            CrearComboGrid("IdEscala", "Nombre", Grid, Lugar, False)
            CrearComboGrid("Piloto", "Nombre", Grid, olCombo.ComboGrilla(lstPiloto), False)
            CrearComboGrid("IdPilotoProg", "Nombre", Grid, olCombo.ComboGrilla(lstPiloto), False)
            CrearComboGrid("Copiloto", "Nombre", Grid, olCombo.ComboGrilla(CopilotoPublic), False)
            CrearComboGrid("IdCopilotoProg", "Nombre", Grid, olCombo.ComboGrilla(CopilotoPublic), False)
            CrearComboGrid("IdTracto", "Nombre", Grid, olCombo.ComboGrilla(TractoPublic), False)
            CrearComboGrid("IdTractoProg", "Nombre", Grid, olCombo.ComboGrilla(TractoPublic), False)
            CrearComboGrid("Carreta", "Nombre", Grid, olCombo.ComboGrilla(CarretaPublic), False)
            CrearComboGrid("IdCarretaProg", "Nombre", Grid, olCombo.ComboGrilla(CarretaPublic), False)
            CrearComboGrid("Zona", "Nombre", Grid, olCombo.ComboGrilla(ZonaPublic.Where(Function(x) x.Id <> String.Empty).ToList()), False)
            CrearComboGrid("Estado", "Nombre", Grid, olCombo.ComboGrilla(ListEstadoViajeDespacho), False)
            'Marca Vehiculo
            oeCombo = New e_Combo
            oeCombo.Nombre = "MarcaVehiculo"
            CrearComboGrid("IdMarcaVehiculo", "Nombre", Grid, olCombo.ComboGrilla(olCombo.Listar(oeCombo)), False)

            'Opciones diferentes para Detalle y Listado
            If bolGrillaDetalle Then
                'Formato para Buscar Contains
                With Grid.DisplayLayout.Bands(0)
                    .Columns("EstadoAceptar").Width = 30
                    .Columns("EstadoAceptar").Header.Caption = String.Empty
                    .Columns("EstadoAceptar").CellActivation = Activation.Disabled
                    .Columns("Cliente").AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
                    .Columns("Cliente").AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
                    .Columns("Origen").AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
                    .Columns("Origen").AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.StartsWith
                    .Columns("IdEscala").AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
                    .Columns("IdEscala").AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.StartsWith
                    .Columns("Destino").AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
                    .Columns("Destino").AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.StartsWith
                    .Columns("Piloto").AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
                    .Columns("Piloto").AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
                    .Columns("Copiloto").AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
                    .Columns("Copiloto").AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
                End With
                Grid.ContextMenuStrip = cmsMenuMantenimiento
            Else
                Grid.ContextMenuStrip = cmsMenuListado
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_ListarDespacho()
        Try
            If lf_ValidarListar() Then
                oeDespacho.Dispose()
                With oeDespacho
                    .Fecha = dtpDesdeFiltro.Value.Date
                    .FechaHasta = dtpHastaFiltro.Value.Date
                    .IdCentro = cboCentroFiltro.Value.ToString().Trim()
                    .IdEstado = cboEstadoFiltro.Value.ToString().Trim()
                End With
                loDespacho.Clear()
                loDespacho.AddRange(olDespacho.Listar(oeDespacho, True).OrderByDescending(Function(x) x.Fecha).ToList())
                If loDespacho.Count > 0 Then
                    mt_LlenarGrillasTabs()
                    utcDespachosDinamicos_SelectedTabChanged(Nothing, Nothing)
                Else
                    mt_LimpiarGrid()
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_LimpiarGrid()
        Try
            For Each uTab As UltraWinTabControl.UltraTab In utcDespachosDinamicos.Tabs
                uTab.Visible = False
            Next
            griTab01.Text = String.Empty
            griTab01.DataSource = New List(Of e_DespachoOperaciones)
            griTab01.DataBind()
            griTab02.Text = String.Empty
            griTab02.DataSource = New List(Of e_DespachoOperaciones)
            griTab02.DataBind()
            griTab03.Text = String.Empty
            griTab03.DataSource = New List(Of e_DespachoOperaciones)
            griTab03.DataBind()
            griTab04.Text = String.Empty
            griTab04.DataSource = New List(Of e_DespachoOperaciones)
            griTab04.DataBind()
            griTab05.Text = String.Empty
            griTab05.DataSource = New List(Of e_DespachoOperaciones)
            griTab05.DataBind()
            griTab06.Text = String.Empty
            griTab06.DataSource = New List(Of e_DespachoOperaciones)
            griTab06.DataBind()
            griTab07.Text = String.Empty
            griTab07.DataSource = New List(Of e_DespachoOperaciones)
            griTab07.DataBind()
            griTab08.Text = String.Empty
            griTab08.DataSource = New List(Of e_DespachoOperaciones)
            griTab08.DataBind()
            griTab09.Text = String.Empty
            griTab09.DataSource = New List(Of e_DespachoOperaciones)
            griTab09.DataBind()
            griTab10.Text = String.Empty
            griTab10.DataSource = New List(Of e_DespachoOperaciones)
            griTab10.DataBind()
            griTab11.Text = String.Empty
            griTab11.DataSource = New List(Of e_DespachoOperaciones)
            griTab11.DataBind()
            griTab12.Text = String.Empty
            griTab12.DataSource = New List(Of e_DespachoOperaciones)
            griTab12.DataBind()
            griTab13.Text = String.Empty
            griTab13.DataSource = New List(Of e_DespachoOperaciones)
            griTab13.DataBind()
            griTab14.Text = String.Empty
            griTab14.DataSource = New List(Of e_DespachoOperaciones)
            griTab14.DataBind()
            griTab15.Text = String.Empty
            griTab15.DataSource = New List(Of e_DespachoOperaciones)
            griTab15.DataBind()
            utcDespachosDinamicos.Tabs(0).Visible = True
            utcDespachosDinamicos.Tabs(0).Text = "Fechas"
            utcDespachosDinamicos.Tabs(1).Visible = True
            utcDespachosDinamicos.Tabs(1).Text = "..."
            utcDespachosDinamicos.Tabs(1).Enabled = False
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_LlenarGrillasTabs()
        Try
            For index = 0 To loDespacho.Count - 1
                utcDespachosDinamicos.Tabs(index).Enabled = True
                utcDespachosDinamicos.Tabs(index).Visible = True
                utcDespachosDinamicos.Tabs(index).Text = loDespacho(index).Fecha.ToString("dd/MM/yy")
                Select Case index
                    Case 0
                        mt_LlenarGrillaxFecha(griTab01, loDespacho(index).Fecha)
                        mt_CalcularTotalesFiltro(griTab01)
                    Case 1
                        mt_LlenarGrillaxFecha(griTab02, loDespacho(index).Fecha)
                        mt_CalcularTotalesFiltro(griTab02)
                    Case 2
                        mt_LlenarGrillaxFecha(griTab03, loDespacho(index).Fecha)
                        mt_CalcularTotalesFiltro(griTab03)
                    Case 3
                        mt_LlenarGrillaxFecha(griTab04, loDespacho(index).Fecha)
                        mt_CalcularTotalesFiltro(griTab04)
                    Case 4
                        mt_LlenarGrillaxFecha(griTab05, loDespacho(index).Fecha)
                        mt_CalcularTotalesFiltro(griTab05)
                    Case 5
                        mt_LlenarGrillaxFecha(griTab06, loDespacho(index).Fecha)
                        mt_CalcularTotalesFiltro(griTab06)
                    Case 6
                        mt_LlenarGrillaxFecha(griTab07, loDespacho(index).Fecha)
                        mt_CalcularTotalesFiltro(griTab07)
                    Case 7
                        mt_LlenarGrillaxFecha(griTab08, loDespacho(index).Fecha)
                        mt_CalcularTotalesFiltro(griTab08)
                    Case 8
                        mt_LlenarGrillaxFecha(griTab09, loDespacho(index).Fecha)
                        mt_CalcularTotalesFiltro(griTab09)
                    Case 9
                        mt_LlenarGrillaxFecha(griTab10, loDespacho(index).Fecha)
                        mt_CalcularTotalesFiltro(griTab10)
                    Case 10
                        mt_LlenarGrillaxFecha(griTab11, loDespacho(index).Fecha)
                        mt_CalcularTotalesFiltro(griTab11)
                    Case 11
                        mt_LlenarGrillaxFecha(griTab12, loDespacho(index).Fecha)
                        mt_CalcularTotalesFiltro(griTab12)
                    Case 12
                        mt_LlenarGrillaxFecha(griTab13, loDespacho(index).Fecha)
                        mt_CalcularTotalesFiltro(griTab13)
                    Case 13
                        mt_LlenarGrillaxFecha(griTab14, loDespacho(index).Fecha)
                        mt_CalcularTotalesFiltro(griTab14)
                    Case 14
                        mt_LlenarGrillaxFecha(griTab15, loDespacho(index).Fecha)
                        mt_CalcularTotalesFiltro(griTab15)
                End Select
            Next
            For index = loDespacho.Count To utcDespachosDinamicos.Tabs.Count - 1
                utcDespachosDinamicos.Tabs(index).Visible = False
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_LlenarGrillaxFecha(Grilla As UltraWinGrid.UltraGrid, Fecha As Date)
        Try
            If loDespacho.Where(Function(x) x.Fecha = Fecha).Count > 0 Then
                Dim Codigo As String = String.Empty
                Dim Estado As String = String.Empty
                Codigo = loDespacho.Where(Function(x) x.Fecha = Fecha).ToList(0).Codigo
                If loEstados.Where(Function(x) x.Id = loDespacho.Where(Function(i) i.Fecha = Fecha).ToList(0).IdEstado).Count > 0 Then
                    Estado = loEstados.Where(Function(x) x.Id = loDespacho.Where(Function(i) i.Fecha = Fecha).ToList(0).IdEstado)(0).Nombre
                    Grilla.DisplayLayout.CaptionVisible = DefaultableBoolean.True
                    Grilla.Text = "Codigo: " & Codigo & "  -  Estado: " & Estado
                    'If loDespacho.Where(Function(x) x.Fecha = Fecha).ToList(0).IdEstado = IdEstadoGenerado Then
                    '    Grilla.DisplayLayout.CaptionAppearance.BackColor = Color.White
                    'Else
                    '    Grilla.DisplayLayout.CaptionAppearance.BackColor = Color.LightGreen
                    'End If
                End If
                Grilla.DataSource = loDespacho.Where(Function(x) x.Fecha = Fecha).ToList(0).ListDespachoOperaciones
                mt_ConfigurarGrilla(Grilla, False)
                Grilla.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.True
                For Each Col In Grilla.DisplayLayout.Bands(0).Columns
                    Col.CellActivation = Activation.NoEdit
                    Col.CellClickAction = CellClickAction.RowSelect
                Next
                Grilla.DisplayLayout.Bands(0).Columns("Seleccion").CellActivation = Activation.AllowEdit
                Grilla.DisplayLayout.Bands(0).Columns("Seleccion").CellClickAction = CellClickAction.Edit
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_CalcularTotalesFiltro(Grilla As UltraGrid)
        Try
            'Total Viajes
            uneTotalViajes.Value = Grilla.Rows.Where(Function(x) x.Cells("Zona").Value = cboZonaListado.Value).Count
            'Total por Unidad
            uneProdUnidadFiltro.Value = 1600
            'Total al que se quiere llegar
            uneProdTotalFiltro.Value = Math.Round(uneProdUnidadFiltro.Value * uneTotalViajes.Value, 2, MidpointRounding.AwayFromZero)
            'Total Programado
            uneProdRealFiltro.Value = Math.Round(Grilla.Rows.Where(Function(x) x.Cells("Zona").Value = cboZonaListado.Value).Sum(Function(x) x.Cells("TotalFleteProg").Value), 2, MidpointRounding.AwayFromZero)
            'Porcentaje (%)
            unePorcentajeMeta.Value = If(uneProdRealFiltro.Value = 0, 0.0, Math.Round((uneProdRealFiltro.Value / uneProdTotalFiltro.Value) * 100, 2, MidpointRounding.AwayFromZero))
            'Calcula el total de viajes sin piloto de acuerdo a la zona a editar
            uneTotalSinPiloto.Value = Grilla.Rows.Where(Function(x) x.Cells("Zona").Value = cboZonaListado.Value And x.Cells("Piloto").Value = "0").Count
            'Calcula el total de viajes sin copiloto de acuerdo a la zona a editar
            uneTotalSinCopiloto.Value = Grilla.Rows.Where(Function(x) x.Cells("Zona").Value = cboZonaListado.Value And x.Cells("Copiloto").Value = "0").Count
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_InicializarControles()
        Try
            txtZonaEditar.Tag = String.Empty
            txtZonaEditar.Text = String.Empty
            rbtNinguno.Checked = True
            txtCodigo.Text = String.Empty
            cboEstado.SelectedIndex = 0
            dtpFecha.Value = FechaServidor.Date
            txtGlosa.Text = String.Empty
            uneProdProg.Value = 0.0
            uneProdReal.Value = 0.0
            uneProdTotal.Value = 0.0
            loDespachoOperaciones.Clear() : griDetalles.DataBind()
            If Operacion = "Editar" OrElse Operacion = "Ejecutar" Then
                expGenerarDesde.Expanded = False
            Else
                expGenerarDesde.Expanded = True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_AgregarDespacho()
        Try
            oeDespachoOperacion = New e_DespachoOperaciones With {.Piloto = "0", .Copiloto = "0"}
            loDespachoOperaciones.Add(oeDespachoOperacion)
            With griDetalles
                .DataBind()
                mt_ActivaDesactivaCeldas()
                .Rows(loDespachoOperaciones.Count - 1).Cells("Piloto").Activate()
                .Focus()
                .PerformAction(UltraGridAction.EnterEditMode, False, False)
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_QuitarDespacho()
        Try
            Cursor.Current = Cursors.WaitCursor
            Dim index As Integer = 0
            For index = loDespachoOperaciones.Count - 1 To 0 Step -1
                If loDespachoOperaciones(index).TipoOperacion <> "E" AndAlso loDespachoOperaciones(index).Seleccion Then
                    If String.IsNullOrWhiteSpace(loDespachoOperaciones(index).Id) Then
                        loDespachoOperaciones.Remove(loDespachoOperaciones(index))
                        griDetalles.DataBind()
                    Else
                        loDespachoOperaciones.Item(index).TipoOperacion = "E"
                        loDespachoOperaciones.Item(index).UsuarioCrea = gUsuarioSGI.Id
                        If griDetalles.Rows.Where(Function(x) x.Hidden = False And x.Cells("Id").Value = loDespachoOperaciones(index).Id).Count > 0 Then
                            griDetalles.Rows.Where(Function(x) x.Hidden = False And x.Cells("Id").Value = loDespachoOperaciones(index).Id)(0).Hidden = True
                        End If
                    End If
                End If
            Next
            mt_CalcularTotales()
        Catch ex As Exception
            Throw ex
        Finally
            Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub mt_CalcularTotales()
        Try

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_ObtenerUltimosViajes()
        Try
            oeDespachoOperacion = New e_DespachoOperaciones
            With oeDespachoOperacion
                .TipoOperacion = "UVI"
            End With
            If loDespachoOperaciones.Where(Function(x) x.TipoOperacion <> "E").Count > 0 AndAlso _
                MessageBox.Show("Desea sobreescribir los datos existentes en la grilla?", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                mt_EliminarElementosGrilla()
            End If
            loDespachoOperaciones.AddRange(olDespachoOperaciones.Listar(oeDespachoOperacion))
            griDetalles.DataBind()
            mt_ActivaDesactivaCeldas()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_ObtenerUltimoDespacho()
        Try
            If Operacion = "IniciarDespacho" Then
                oeDespachoOperacion = New e_DespachoOperaciones
                With oeDespachoOperacion
                    .TipoOperacion = "UDE"
                End With
                If loDespachoOperaciones.Where(Function(x) x.TipoOperacion <> "E").Count > 0 AndAlso _
                    MessageBox.Show("Desea sobreescribir los datos existentes en la grilla?", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    mt_EliminarElementosGrilla()
                End If
                loDespachoOperaciones.AddRange(olDespachoOperaciones.Listar(oeDespachoOperacion))
                griDetalles.DataBind()
                mt_ColorCeldaMantenimiento(griDetalles)
                mt_ActivaDesactivaCeldas()
            Else
                MessageBox.Show("Debe elegir la opción iniciar despacho para poder realizar esta acción", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_EliminarElementosGrilla()
        Try
            Dim index As Integer = 0
            For index = loDespachoOperaciones.Count - 1 To 0 Step -1
                If loDespachoOperaciones(index).TipoOperacion <> "E" Then
                    If String.IsNullOrWhiteSpace(loDespachoOperaciones(index).Id) Then
                        loDespachoOperaciones.Remove(loDespachoOperaciones(index))
                        griDetalles.DataBind()
                    Else
                        loDespachoOperaciones.Item(index).TipoOperacion = "E"
                        loDespachoOperaciones.Item(index).UsuarioCrea = gUsuarioSGI.Id
                        If griDetalles.Rows.Where(Function(x) x.Hidden = False And x.Cells("Id").Value = loDespachoOperaciones(index).Id).Count > 0 Then
                            griDetalles.Rows.Where(Function(x) x.Hidden = False And x.Cells("Id").Value = loDespachoOperaciones(index).Id)(0).Hidden = True
                        End If
                    End If
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_ImportarDesdeExcel()
        Try
            Dim RutaArchivo As String = String.Empty
            OpenFileDialog1 = CargaDatosOpenFileDialog()
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                Cursor.Current = Cursors.WaitCursor
                RutaArchivo = OpenFileDialog1.FileName
                Dim objXls As Excel.Application
                Dim objWorkbook As Excel.Workbook
                Dim objWorkSheet As Excel.Worksheet
                objXls = CreateObject("Excel.Application")
                objWorkbook = objXls.Workbooks.Open(RutaArchivo)
                objXls.Visible = False
                objWorkSheet = objXls.Worksheets(2)
                'Llenar Lista Marca
                Dim oeMarca As New e_Combo, loMarca As List(Of e_Combo)
                oeMarca.Nombre = "MarcaVehiculo"
                loMarca = olCombo.Listar(oeMarca)
                Dim FilaGrilla As Integer = 0
                If loDespachoOperaciones.Where(Function(x) x.TipoOperacion <> "E").Count > 0 AndAlso _
                    MessageBox.Show("Desea sobreescribir los datos existentes en la grilla?", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    mt_EliminarElementosGrilla()
                Else
                    FilaGrilla = loDespachoOperaciones.Where(Function(x) x.TipoOperacion <> "E").Count
                End If
                Dim ListaNoEncontrados As New List(Of List(Of String))
                Dim ListaDatos As List(Of String)
                Dim ln_Fila As Integer = 0, datoCadena As String
                For ln_Fila = 2255 To 2558
                    If objWorkSheet.Cells(ln_Fila + 1, 1).Value IsNot Nothing Then
                        ListaDatos = New List(Of String)
                        ListaDatos.Add(FilaGrilla.ToString())
                        oeDespachoOperacion = New e_DespachoOperaciones
                        With oeDespachoOperacion
                            'Piloto(1)
                            datoCadena = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 1).Value)
                            If lstPiloto.Where(Function(x) x.Nombre = datoCadena).Count > 0 Then
                                .Piloto = lstPiloto.Where(Function(x) x.Nombre = datoCadena)(0).Id
                            Else
                                If Not String.IsNullOrWhiteSpace(datoCadena) Then
                                    ListaDatos.Add("Piloto")
                                End If
                            End If
                            'Copiloto(2)
                            datoCadena = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 2).Value)
                            If CopilotoPublic.Where(Function(x) x.Nombre = datoCadena).Count > 0 Then
                                .Copiloto = CopilotoPublic.Where(Function(x) x.Nombre = datoCadena)(0).Id
                            Else
                                If Not String.IsNullOrWhiteSpace(datoCadena) Then
                                    ListaDatos.Add("Copiloto")
                                End If
                            End If
                            'Celular (3)
                            'Tipo Unidad (4)
                            'Tracto (5) 
                            datoCadena = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 5).Value)
                            If TractoPublic.Where(Function(x) x.Nombre = datoCadena).Count > 0 Then
                                .IdTracto = TractoPublic.Where(Function(x) x.Nombre = datoCadena)(0).Id
                            Else
                                ListaDatos.Add("IdTracto")
                            End If
                            'Glosa N (6) 
                            .GlosaN = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 6).Value)
                            'Carreta (7) 
                            datoCadena = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 7).Value)
                            If CarretaPublic.Where(Function(x) x.Nombre = datoCadena).Count > 0 Then
                                .Carreta = CarretaPublic.Where(Function(x) x.Nombre = datoCadena)(0).Id
                            Else
                                If Not String.IsNullOrWhiteSpace(datoCadena) Then
                                    ListaDatos.Add("Carreta")
                                End If
                            End If
                            'Zona (8) 
                            datoCadena = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 8).Value)
                            If ZonaPublic.Where(Function(x) x.Nombre = datoCadena).Count > 0 Then
                                .Zona = ZonaPublic.Where(Function(x) x.Nombre = datoCadena)(0).Id
                            Else
                                If Not String.IsNullOrWhiteSpace(datoCadena) Then
                                    ListaDatos.Add("Zona")
                                End If
                            End If
                            'Origen (9) 
                            datoCadena = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 9).Value)
                            If Not String.IsNullOrWhiteSpace(datoCadena) AndAlso LugaresPublic.Where(Function(x) x.Nombre.StartsWith(datoCadena)).Count > 0 Then
                                .Origen = LugaresPublic.Where(Function(x) x.Nombre.StartsWith(datoCadena))(0).Id
                            Else
                                If Not String.IsNullOrWhiteSpace(datoCadena) Then
                                    ListaDatos.Add("Origen")
                                End If
                            End If
                            'Escala (10) 
                            datoCadena = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 10).Value)
                            If LugaresPublic.Where(Function(x) x.Nombre = datoCadena).Count > 0 Then
                                .IdEscala = LugaresPublic.Where(Function(x) x.Nombre = datoCadena)(0).Id
                            Else
                                If Not String.IsNullOrWhiteSpace(datoCadena) Then
                                    ListaDatos.Add("IdEscala")
                                End If
                            End If
                            'Destino (11) 
                            datoCadena = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 11).Value)
                            If Not String.IsNullOrWhiteSpace(datoCadena) AndAlso LugaresPublic.Where(Function(x) x.Nombre.StartsWith(datoCadena)).Count > 0 Then
                                .Destino = LugaresPublic.Where(Function(x) x.Nombre.StartsWith(datoCadena))(0).Id
                            Else
                                If Not String.IsNullOrWhiteSpace(datoCadena) Then
                                    ListaDatos.Add("Destino")
                                End If
                            End If
                            'Estado (12) 
                            datoCadena = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 12).Value)
                            If ListEstadoViajeDespacho.Where(Function(x) x.Nombre = datoCadena).Count > 0 Then
                                .Estado = ListEstadoViajeDespacho.Where(Function(x) x.Nombre = datoCadena)(0).Id
                            Else
                                If Not String.IsNullOrWhiteSpace(datoCadena) Then
                                    ListaDatos.Add("Estado")
                                End If
                            End If
                            'Cliente (13) 
                            datoCadena = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 13).Value)
                            If ClientesPublic.Where(Function(x) x.Nombre = datoCadena).Count > 0 Then
                                .Cliente = ClientesPublic.Where(Function(x) x.Nombre = datoCadena)(0).Id
                            Else
                                If Not String.IsNullOrWhiteSpace(datoCadena) Then
                                    ListaDatos.Add("Cliente")
                                End If
                            End If
                            'Toneladas (14) 
                            Try
                                .Tonelada = CType(objWorkSheet.Cells(ln_Fila + 1, 14).Value, Double)
                            Catch ex As InvalidCastException
                                .Tonelada = 0
                            End Try
                            'MNTO (15) 
                            .MNTO = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 15).Value)
                            If Not String.IsNullOrWhiteSpace(.MNTO) Then
                                .Ocurrencia = "1"
                            End If
                            'Monto (16) 
                            Try
                                .Monto = CType(objWorkSheet.Cells(ln_Fila + 1, 16).Value, Double)
                            Catch ex As InvalidCastException
                                .Monto = 0
                            End Try
                            'Cliente Glosa (17) 
                            .ClienteGlosa = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 17).Value)
                            'Hora (18) 
                            Try
                                .Hora = CType(objWorkSheet.Cells(ln_Fila + 1, 18).Text, DateTime)
                            Catch ex As InvalidCastException
                                .Hora = #1/1/1901#
                            End Try
                            'EstadoGlosa (19) 
                            .EstadoGlosa = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 19).Value)
                            'Disponible (20) 
                            .Disponible = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 20).Value)
                            'IdViaje (21) 
                            .IdViaje = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 21).Value)
                            loDespachoOperaciones.Add(oeDespachoOperacion)
                            ListaNoEncontrados.Add(ListaDatos)
                            FilaGrilla += 1
                        End With
                    Else
                        Exit For
                    End If
                Next
                griDetalles.DataBind()
                mt_ColorCeldaNoEncontrada(ListaNoEncontrados)
                mt_ColorCeldaMantenimiento(griDetalles)
                mt_ObtenerMarcaCelular()
                mt_ActivaDesactivaCeldas()
                If Not objXls Is Nothing Then
                    objWorkbook.Saved = True
                    objWorkbook.Close()
                    objXls.Quit()
                End If
                objWorkSheet = Nothing : objWorkbook = Nothing : objXls = Nothing
                Dim proceso() As Process
                proceso = Process.GetProcessesByName("EXCEL")
                If proceso.Length > 0 Then
                    proceso(proceso.Length - 1).Kill()
                End If
            End If
        Catch ex As Exception
            Throw ex
        Finally
            OpenFileDialog1.Dispose()
            Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub mt_ColorCeldaNoEncontrada(Lista As List(Of List(Of String)))
        Try
            For Each ListaDatos In Lista
                If ListaDatos.Count > 1 Then
                    For index = 0 To ListaDatos.Count - 1
                        If index <> 0 Then
                            griDetalles.Rows(ListaDatos(0)).Cells(ListaDatos(index)).Appearance.BackColor = colorCamposNoEncontrados.Color
                        End If
                    Next
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_GuardarDespacho()
        Try
            _acl = gAccionSistema.LECTURA.ToString
            If Not ValidarAcl(_acl, pIdActividadNegocio) Then
                If lf_ValidarGuardarDespacho() Then
                    griDetalles.UpdateData()
                    With oeDespacho
                        .TipoOperacion = "I"
                        .Codigo = txtCodigo.Text.Trim()
                        .IdCentro = ObtenerCentro(gs_PrefijoIdSucursal).Id
                        .IdEstado = cboEstado.Value.ToString().Trim()
                        .Fecha = dtpFecha.Value.Date
                        .Glosa = txtGlosa.Text.Trim()
                        .ProdProgramado = Convert.ToDouble(uneProdProg.Value)
                        .ProdReal = Convert.ToDouble(uneProdReal.Value)
                        .ProdTotal = Convert.ToDouble(uneProdTotal.Value)
                        .ListDespachoOperaciones.Clear()
                        For Each DespachoOp As e_DespachoOperaciones In loDespachoOperaciones
                            With DespachoOp
                                If String.IsNullOrWhiteSpace(.Piloto) Then
                                    .Piloto = "0"
                                End If
                                If String.IsNullOrWhiteSpace(.Copiloto) Then
                                    .Copiloto = "0"
                                End If
                                .Hora = Convert.ToDateTime(dtpFecha.Value.Date.ToShortDateString & " " & .Hora.ToShortTimeString)
                            End With
                        Next
                        .ListDespachoOperaciones.AddRange(loDespachoOperaciones)
                        'If Operacion = "Inicializa" AndAlso Not String.IsNullOrWhiteSpace(txtZonaEditar.Tag) Then
                        '    .ListDespachoOperaciones.AddRange(loDespachoOperaciones.Where(Function(x) x.Zona = txtZonaEditar.Tag).ToList())
                        'Else
                        '    .ListDespachoOperaciones.AddRange(loDespachoOperaciones)
                        'End If
                        .UsuarioCrea = gUsuarioSGI.Id
                    End With
                    oeDespacho.PrefijoID = gs_PrefijoIdSucursal '@0001
                    If olDespacho.Guardar(oeDespacho) Then
                        MessageBox.Show("Operación realiza con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        MostrarTabs(0, utcDespacho, 0)
                        'mt_ActualizaRegistroEditado()
                        dtpDesdeFiltro.Value = dtpFecha.Value.Date
                        dtpHastaFiltro.Value = dtpFecha.Value.Date
                        Consultar(True)
                    End If
                End If
            Else
                Throw New Exception("Usted Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_EditarDespacho(Grilla As UltraWinGrid.UltraGrid)
        Try
            'If lf_VerificarRegistroEditado(Grilla.Rows(0).Cells("IdDespacho").Value.ToString().Trim()) Then
            Dim IdDespachoOperaciones As String = String.Empty
            If Grilla.Selected.Rows.Count > 0 AndAlso Grilla.ActiveRow.Index >= 0 Then
                IdDespachoOperaciones = Grilla.ActiveRow.Cells("Id").Value.ToString().Trim()
            End If
            mt_InicializarControles()
            oeDespacho.Dispose()
            With oeDespacho
                .Id = Grilla.Rows(0).Cells("IdDespacho").Value.ToString().Trim()
            End With
            loDespacho.Clear()
            loDespacho.AddRange(olDespacho.Listar(oeDespacho, True))
            If loDespacho.Count > 0 Then
                loDespacho(0).IdZonaEditar = cboZonaListado.Value
                With loDespacho(0)
                    txtZonaEditar.Tag = .IdZonaEditar
                    If Operacion <> "Ejecutar" AndAlso ZonaPublic.Where(Function(x) x.Id = .IdZonaEditar).Count > 0 Then
                        txtZonaEditar.Text = ZonaPublic.Where(Function(x) x.Id = .IdZonaEditar)(0).Nombre
                    End If
                    txtCodigo.Text = .Codigo
                    cboEstado.Value = .IdEstado
                    dtpFecha.Value = .Fecha
                    txtGlosa.Text = .Glosa
                    uneProdProg.Value = .ProdProgramado
                    uneProdReal.Value = .ProdReal
                    uneProdTotal.Value = .ProdTotal
                    If Operacion = "Ejecutar" Then
                        loDespachoOperaciones.AddRange(.ListDespachoOperaciones)
                    Else
                        If Not String.IsNullOrWhiteSpace(loDespacho(0).IdZonaEditar) Then
                            loDespachoOperaciones.AddRange(.ListDespachoOperaciones.Where(Function(x) x.Zona = loDespacho(0).IdZonaEditar).ToList())
                        Else
                            loDespachoOperaciones.AddRange(.ListDespachoOperaciones)
                        End If
                    End If
                    griDetalles.DataBind()
                    For Each Fila In griDetalles.Rows
                        If Not String.IsNullOrWhiteSpace(Fila.Cells("Carreta").Value.ToString()) AndAlso _
                              CarretaPublic.Where(Function(x) x.Id = Fila.Cells("Carreta").Value.ToString()).Count > 0 Then
                            mt_CambiarColorCeldaM(Fila.Cells("Carreta"), CarretaPublic.Where(Function(x) x.Id = Fila.Cells("Carreta").Value.ToString())(0).Extras(5))
                        Else
                            Fila.Cells("Carreta").Appearance.BackColor = Color.White
                        End If
                    Next
                    mt_ColorCeldaMantenimiento(griDetalles)
                    mt_ActivaDesactivaCeldas()
                End With
                If Operacion = "Ejecutar" AndAlso CType(cboEstado.DataSource, List(Of e_Estado)).Where(Function(x) x.Id = IdEstadoTerminada).Count > 0 Then
                    cboEstado.Value = IdEstadoTerminada
                End If
                MostrarTabs(1, utcDespacho, 1)
                mt_ControlBotoneria()
                'mt_GuardarRegistroEditado(loDespacho(0).Id)
                txtGlosa.Focus()
                If Not String.IsNullOrWhiteSpace(IdDespachoOperaciones) AndAlso Operacion <> "Ejecutar" AndAlso loDespacho(0).ListDespachoOperaciones.Where(Function(x) x.Zona = loDespacho(0).IdZonaEditar).Where(Function(x) x.Id = IdDespachoOperaciones).Count > 0 Then
                    griDetalles.Rows.Where(Function(x) x.Cells("Id").Value = IdDespachoOperaciones)(0).Activate()
                    griDetalles.Rows.Where(Function(x) x.Cells("Id").Value = IdDespachoOperaciones)(0).Selected = True
                End If
            End If
            'End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_ColorCeldaMantenimiento(Grilla As UltraGrid)
        Try
            For Each Op As UltraWinGrid.UltraGridRow In Grilla.Rows
                Select Case Op.Cells("Ocurrencia").Value
                    Case "1"
                        Op.Cells("IdTracto").Appearance.BackColor = colorMant.Color
                    Case "2"
                        Op.Cells("IdTracto").Appearance.BackColor = colorMantUrgente.Color
                    Case Else
                        Op.Cells("IdTracto").Appearance.BackColor = Color.White
                End Select
                Select Case Op.Cells("Observacion").Value
                    Case "1"
                        Op.Cells("Origen").Appearance.BackColor = colorCeldaResaltada.Color
                        Op.Cells("Destino").Appearance.BackColor = colorCeldaResaltada.Color
                    Case Else
                        Op.Cells("Origen").Appearance.BackColor = Color.White
                        Op.Cells("Destino").Appearance.BackColor = Color.White
                End Select
                If Convert.ToBoolean(Op.Cells("IndMantenimiento").Value) Then
                    Op.Cells("Estado").Appearance.BackColor = colorColumnaEstado.Color
                Else
                    Op.Cells("Estado").Appearance.BackColor = Color.White
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Const strEliminarDespacho As String = "ELIMINAR DESPACHO OPERACIONES"
    Private Sub mt_EliminarDespacho(Grilla As UltraWinGrid.UltraGrid)
        Try
            Dim olTrabajadorSeg As New l_TrabajadorSeguridad
            If olTrabajadorSeg.Permisos(gUsuarioSGI.IdTrabajador, strEliminarDespacho) Then
                If MessageBox.Show("Esta seguro de eliminar el despacho de la fecha " & utcDespachosDinamicos.SelectedTab.Text, "Despacho", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    oeDespacho.Dispose()
                    oeDespacho.Id = Grilla.Rows(0).Cells("IdDespacho").Value.ToString().Trim()
                    oeDespacho = olDespacho.Obtener(oeDespacho)
                    If Not String.IsNullOrWhiteSpace(oeDespacho.Id) Then
                        If olDespacho.Eliminar(oeDespacho) Then
                            MessageBox.Show("Operación realizada con éxito", "Despacho", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Consultar(True)
                        End If
                    End If
                End If
            Else
                MessageBox.Show("Usted no tiene permiso para eliminar un despacho", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ExportarVariasGrillas(ListGrilla As List(Of UltraWinGrid.UltraGrid))
        Try
            If ListGrilla.Count > 0 AndAlso ListGrilla(0).Rows.Count > 0 Then
                Dim sfd_Dialogo As New System.Windows.Forms.SaveFileDialog
                sfd_Dialogo.Filter = "Libros de Excel (*.xlsx)|*.xlsx|Todos Los Archivos (*.*)|*.*"
                sfd_Dialogo.DefaultExt = "xlsx"
                sfd_Dialogo.FilterIndex = 1
                sfd_Dialogo.Title = "Exportar a ..."
                sfd_Dialogo.FileName = "Libro"
                If sfd_Dialogo.ShowDialog() = Windows.Forms.DialogResult.Cancel Then Return
                Dim stNombreArchivo As String = sfd_Dialogo.FileName
                Dim WorkBook As New Infragistics.Documents.Excel.Workbook(Infragistics.Documents.Excel.WorkbookFormat.Excel2007)
                Dim i As Integer = 0
                For Each Grilla As UltraGrid In ListGrilla
                    Dim WorkSheet As Infragistics.Documents.Excel.Worksheet = WorkBook.Worksheets.Add(utcDespachosDinamicos.Tabs(i).Text.Replace("/", "-"))
                    UltraGridExcelExporter1.Export(Grilla, WorkSheet)
                    i += 1
                Next
                WorkBook.Save(stNombreArchivo)
                If MessageBox.Show("Se ha exportado satisfactoriamente el archivo, desea poder visualizarlo?", _
                "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Process.Start(stNombreArchivo)
                End If
            Else
                MessageBox.Show("No hay informacion para exportar al Excel", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_ExportarFormatoClientes()
        Try
            Select Case utcDespachosDinamicos.SelectedTab.Index
                Case 0
                    ExportarGrilla(griTab01)
                Case 1
                    ExportarGrilla(griTab02)
                Case 2
                    ExportarGrilla(griTab03)
                Case 3
                    ExportarGrilla(griTab04)
                Case 4
                    ExportarGrilla(griTab05)
                Case 5
                    ExportarGrilla(griTab06)
                Case 6
                    ExportarGrilla(griTab07)
                Case 7
                    ExportarGrilla(griTab08)
                Case 8
                    ExportarGrilla(griTab09)
                Case 9
                    ExportarGrilla(griTab10)
                Case 10
                    ExportarGrilla(griTab11)
                Case 11
                    ExportarGrilla(griTab12)
                Case 12
                    ExportarGrilla(griTab13)
                Case 13
                    ExportarGrilla(griTab14)
                Case 14
                    ExportarGrilla(griTab15)
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ExportarGrilla(Grilla As UltraWinGrid.UltraGrid)
        Try
            If Grilla.Rows.Count > 0 Then
                If Grilla.Rows.Where(Function(x) x.Cells("Seleccion").Value = True).Count > 0 Then
                    Dim IdsDO As String = String.Empty
                    Dim CantFilas As Integer = Grilla.Rows.Where(Function(x) x.Cells("Seleccion").Value = True).Count
                    If CantFilas = 1 Then
                        IdsDO = Grilla.Rows.Where(Function(x) x.Cells("Seleccion").Value = True)(0).Cells("Id").Value
                    Else
                        For index = 0 To CantFilas - 1
                            If index = CantFilas - 1 Then
                                IdsDO = IdsDO & Grilla.Rows.Where(Function(x) x.Cells("Seleccion").Value = True)(index).Cells("Id").Value
                            Else
                                IdsDO = IdsDO & Grilla.Rows.Where(Function(x) x.Cells("Seleccion").Value = True)(index).Cells("Id").Value & "','"
                            End If
                        Next
                    End If
                    oeDespachoOperacion = New e_DespachoOperaciones
                    oeDespachoOperacion.TipoOperacion = "EFC"
                    oeDespachoOperacion.Ocurrencia = IdsDO
                    griFormatoClientes.DataSource = olDespachoOperaciones.Listar(oeDespachoOperacion)
                    Dim sfd_Dialogo As New System.Windows.Forms.SaveFileDialog
                    sfd_Dialogo.Filter = "Libros de Excel (*.xlsx)|*.xlsx|Todos Los Archivos (*.*)|*.*"
                    sfd_Dialogo.DefaultExt = "xlsx"
                    sfd_Dialogo.FilterIndex = 1
                    sfd_Dialogo.Title = "Exportar a ..."
                    sfd_Dialogo.FileName = "Libro"
                    If sfd_Dialogo.ShowDialog() = DialogResult.Cancel Then Return
                    Dim stNombreArchivo As String = sfd_Dialogo.FileName
                    UltraGridExcelExporter1.Export(griFormatoClientes, stNombreArchivo)
                    If MessageBox.Show("Se ha exportado satisfactoriamente el archivo, desea poder visualizarlo?", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        Process.Start(stNombreArchivo)
                    End If
                Else
                    MessageBox.Show("Seleccione los viajes que desea exportar al cliente", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("No hay informacion para exportar al Excel", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_GenerarProgramacion()
        Try
            Select Case utcDespachosDinamicos.SelectedTab.Index
                Case 0
                    mt_GenerarProgramacion(griTab01)
                Case 1
                    mt_GenerarProgramacion(griTab02)
                Case 2
                    mt_GenerarProgramacion(griTab03)
                Case 3
                    mt_GenerarProgramacion(griTab04)
                Case 4
                    mt_GenerarProgramacion(griTab05)
                Case 5
                    mt_GenerarProgramacion(griTab06)
                Case 6
                    mt_GenerarProgramacion(griTab07)
                Case 7
                    mt_GenerarProgramacion(griTab08)
                Case 8
                    mt_GenerarProgramacion(griTab09)
                Case 9
                    mt_GenerarProgramacion(griTab10)
                Case 10
                    mt_GenerarProgramacion(griTab11)
                Case 11
                    mt_GenerarProgramacion(griTab12)
                Case 12
                    mt_GenerarProgramacion(griTab13)
                Case 13
                    mt_GenerarProgramacion(griTab14)
                Case 14
                    mt_GenerarProgramacion(griTab15)
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_GenerarProgramacion(Grilla As UltraWinGrid.UltraGrid)
        Try
            If Grilla.Rows.Count > 0 AndAlso Grilla.ActiveRow IsNot Nothing AndAlso Grilla.ActiveRow.Index >= 0 Then
                If Not String.IsNullOrWhiteSpace(Grilla.ActiveRow.Cells("IdViaje").Value.ToString()) AndAlso _
                    MessageBox.Show("El registro ya está enlazado con una programación." & Environment.NewLine & _
                                    "¿Desea programar de todas maneras?", "Mensaje del sistema", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
                    Exit Sub
                End If
                Dim oeViaje As New e_Viaje
                With oeViaje
                    .IdOrigen = Grilla.ActiveRow.Cells("Origen").Value.ToString().Trim
                    .IdDestino = Grilla.ActiveRow.Cells("Destino").Value.ToString().Trim
                    .IdPiloto = Grilla.ActiveRow.Cells("Piloto").Value.ToString().Trim
                    .IdCopiloto = Grilla.ActiveRow.Cells("Copiloto").Value.ToString().Trim
                    .IdTracto = Grilla.ActiveRow.Cells("IdTracto").Value.ToString().Trim
                    .IdCarreta = Grilla.ActiveRow.Cells("Carreta").Value.ToString().Trim
                    .IdDespachoOperaciones = Grilla.ActiveRow.Cells("Id").Value.ToString().Trim
                    .IdEscala = Grilla.ActiveRow.Cells("IdEscala").Value.ToString().Trim
                    If String.IsNullOrWhiteSpace(Grilla.ActiveRow.Cells("Carreta").Value.ToString()) Then
                        Dim oeVehiculo As New e_Vehiculo
                        oeVehiculo.Id = .IdTracto
                        oeVehiculo = olVehiculo.Obtener(oeVehiculo)
                        If Not String.IsNullOrWhiteSpace(oeVehiculo.Id) Then
                            If TipoVehiculoPublic.Where(Function(x) x.Id = oeVehiculo.IdModeloFuncional).Count > 0 Then
                                .IdTipoVehiculo = TipoVehiculoPublic.Where(Function(x) x.Id = oeVehiculo.IdModeloFuncional)(0).Id
                            End If
                        End If
                    Else
                        .IdTipoVehiculo = Grilla.ActiveRow.Cells("TipoVehiculoCarreta").Value.ToString().Trim
                    End If
                End With
                Dim Operacion As frm_Operacion = frm_Operacion.getInstancia
                Operacion.MdiParent = frm_Menu
                Operacion.Show()
                Operacion.ProgramarViajeDespacho(oeViaje)
            Else
                MessageBox.Show("Seleccione registro a generar su viaje", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_ColorCeldaCarreta(Grilla As UltraWinGrid.UltraGrid)
        Try
            For Each F As UltraWinGrid.UltraGridRow In Grilla.Rows
                Select Case F.Cells("TipoVehiculoCarreta").Value
                    Case "1CH000000014"
                        F.Cells("Carreta").Appearance.BackColor = Me.ColorPlataforma.Color
                    Case "1CH000000007"
                        F.Cells("Carreta").Appearance.BackColor = Me.ColorFurgon.Color
                    Case "1CH000000018"
                        F.Cells("Carreta").Appearance.BackColor = Me.ColorGranelero.Color
                    Case "1CH000000008"
                        F.Cells("Carreta").Appearance.BackColor = Me.ColorFurgonLargo.Color
                    Case "1CH000000030"
                        F.Cells("Carreta").Appearance.BackColor = Me.ColorBaranda.Color
                    Case "1CH000000013"
                        F.Cells("Carreta").Appearance.BackColor = Me.ColorCisterna.Color
                    Case "1CH000000016"
                        F.Cells("Carreta").Appearance.BackColor = Me.ColorCalicera.Color
                    Case "1CH000000011"
                        F.Cells("Carreta").Appearance.BackColor = Me.ColorTolvaVolteo.Color
                    Case "1CH000000019"
                        F.Cells("Carreta").Appearance.BackColor = Me.ColorMediaBaranda.Color
                    Case "1CH000000017"
                        F.Cells("Carreta").Appearance.BackColor = Me.ColorFurgonAmericano.Color
                    Case "1CH000000031"
                        F.Cells("Carreta").Appearance.BackColor = Me.ColorBomboma.Color
                    Case "1CH000000020"
                        F.Cells("Carreta").Appearance.BackColor = Me.ColorParihuelero.Color
                End Select
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_ResumenDiario()
        Try
            Select Case utcDespachosDinamicos.SelectedTab.Index
                Case 0
                    mt_CargarDatos(griTab01)
                Case 1
                    mt_CargarDatos(griTab02)
                Case 2
                    mt_CargarDatos(griTab03)
                Case 3
                    mt_CargarDatos(griTab04)
                Case 4
                    mt_CargarDatos(griTab05)
                Case 5
                    mt_CargarDatos(griTab06)
                Case 6
                    mt_CargarDatos(griTab07)
                Case 7
                    mt_CargarDatos(griTab08)
                Case 8
                    mt_CargarDatos(griTab09)
                Case 9
                    mt_CargarDatos(griTab10)
                Case 10
                    mt_CargarDatos(griTab11)
                Case 11
                    mt_CargarDatos(griTab12)
                Case 12
                    mt_CargarDatos(griTab13)
                Case 13
                    mt_CargarDatos(griTab14)
                Case 14
                    mt_CargarDatos(griTab15)
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_CargarDatos(Grilla As UltraWinGrid.UltraGrid)
        Try
            If Grilla.Rows.Count > 0 Then
                Dim formulario As New frm_ImprimirResumenDiarioDespacho
                formulario.Fecha = CType(Grilla.DataSource, List(Of e_DespachoOperaciones))(0).Hora.Date
                formulario.StartPosition = FormStartPosition.CenterParent
                formulario.ShowDialog()
                mt_ControlBotoneria()
            Else
                MessageBox.Show("No existen datos en la lista activa", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Funciones"

    Private Function lf_ValidarListar() As Boolean
        Try
            If DateTime.Compare(dtpDesdeFiltro.Value.Date, dtpHastaFiltro.Value.Date) > 0 Then
                MessageBox.Show("La fecha inicial debe ser menor que la fecha final. Verifique fechas", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                dtpDesdeFiltro.Focus()
                Return False
            End If

            If DateDiff(DateInterval.Day, dtpDesdeFiltro.Value.Date, dtpHastaFiltro.Value.Date) >= 15 Then
                MessageBox.Show("El máximo rango permitido es 15 días. Verifique fechas", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                dtpDesdeFiltro.Focus()
                Return False
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function lf_ValidarGuardarDespacho() As Boolean
        Dim oeDespachoValida As New e_Despacho
        Dim lstDespacho As List(Of e_Despacho) = Nothing
        Try
            'Validar si han ingresado datos
            If loDespachoOperaciones.Where(Function(x) x.TipoOperacion <> "E").Count <= 0 Then
                MessageBox.Show("No ha ingresado ningun registro", "Despacho", MessageBoxButtons.OK, MessageBoxIcon.Information)
                griDetalles.Focus()
                Return False
            End If
            'Validar si ya se ha creado en esa fecha seleccionada un despacho
            With oeDespachoValida
                oeDespachoValida.FechaValida = dtpFecha.Value.Date
            End With
            lstDespacho = olDespacho.Listar(oeDespachoValida, False)
            If lstDespacho IsNot Nothing AndAlso lstDespacho.Count > 0 AndAlso lstDespacho(0).Id <> oeDespacho.Id Then
                MessageBox.Show("Ya se generó un despacho en la fecha " & dtpFecha.Value.Date.ToShortDateString(), "Despacho", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dtpFecha.Focus()
                Return False
            End If
            'Validar Datos Ingresados
            Dim ListaDatosNoValidos As New List(Of List(Of String))
            For Each Fila As UltraGridRow In griDetalles.Rows.Where(Function(x) x.Hidden = False)
                Fila.Cells.All.ToList.ForEach(Sub(Celda As UltraWinGrid.UltraGridCell) Celda.Appearance.BackColor = Color.White)
                'Validar Pilotos 
                oeCombo = New e_Combo
                oeCombo.Tipo = 0
                oeCombo.Id = Fila.Cells("Piloto").Value
                If Not String.IsNullOrWhiteSpace(oeCombo.Id) AndAlso Not lstPiloto.Contains(oeCombo) Then
                    ListaDatosNoValidos.Add(New List(Of String)() From {"Piloto", Fila.Index}.ToList)
                End If
                'Validar Copilotos 
                oeCombo = New e_Combo
                oeCombo.Tipo = 0
                oeCombo.Id = Fila.Cells("Copiloto").Value
                If Not String.IsNullOrWhiteSpace(oeCombo.Id) AndAlso Not CopilotoPublic.Contains(oeCombo) Then
                    ListaDatosNoValidos.Add(New List(Of String)() From {"Copiloto", Fila.Index}.ToList)
                End If
                'Validar Tracto 
                oeCombo = New e_Combo
                oeCombo.Tipo = 0
                oeCombo.Id = Fila.Cells("IdTracto").Value
                If Not String.IsNullOrWhiteSpace(oeCombo.Id) AndAlso Not TractoPublic.Contains(oeCombo) Then
                    ListaDatosNoValidos.Add(New List(Of String)() From {"IdTracto", Fila.Index}.ToList)
                End If
                'Validar Carreta
                oeCombo = New e_Combo
                oeCombo.Tipo = 0
                oeCombo.Id = Fila.Cells("Carreta").Value
                If Not String.IsNullOrWhiteSpace(oeCombo.Id) AndAlso Not CarretaPublic.Contains(oeCombo) Then
                    ListaDatosNoValidos.Add(New List(Of String)() From {"Carreta", Fila.Index}.ToList)
                End If
                'Validar Zona
                oeCombo = New e_Combo
                oeCombo.Tipo = 0
                oeCombo.Id = Fila.Cells("Zona").Value
                If Not ZonaPublic.Where(Function(x) x.Id <> "").Contains(oeCombo) Then
                    ListaDatosNoValidos.Add(New List(Of String)() From {"Zona", Fila.Index}.ToList)
                End If
                'Origen
                oeCombo = New e_Combo
                oeCombo.Tipo = 0
                oeCombo.Id = Fila.Cells("Origen").Value
                If Not String.IsNullOrWhiteSpace(oeCombo.Id) AndAlso Not LugaresPublic.Contains(oeCombo) Then
                    ListaDatosNoValidos.Add(New List(Of String)() From {"Origen", Fila.Index}.ToList)
                End If
                'Escala
                oeCombo = New e_Combo
                oeCombo.Tipo = 0
                oeCombo.Id = Fila.Cells("IdEscala").Value
                If Not String.IsNullOrWhiteSpace(oeCombo.Id) AndAlso Not LugaresPublic.Contains(oeCombo) Then
                    ListaDatosNoValidos.Add(New List(Of String)() From {"IdEscala", Fila.Index}.ToList)
                End If
                'Destino
                oeCombo = New e_Combo
                oeCombo.Tipo = 0
                oeCombo.Id = Fila.Cells("Destino").Value
                If Not String.IsNullOrWhiteSpace(oeCombo.Id) AndAlso Not LugaresPublic.Contains(oeCombo) Then
                    ListaDatosNoValidos.Add(New List(Of String)() From {"Destino", Fila.Index}.ToList)
                End If
                'Estado
                oeCombo = New e_Combo
                oeCombo.Tipo = 0
                oeCombo.Id = Fila.Cells("Estado").Value
                If Not ListEstadoViajeDespacho.Contains(oeCombo) Then
                    ListaDatosNoValidos.Add(New List(Of String)() From {"Estado", Fila.Index}.ToList)
                End If
                'Cliente
                oeCombo = New e_Combo
                oeCombo.Tipo = 0
                oeCombo.Id = Fila.Cells("Cliente").Value
                If Not String.IsNullOrWhiteSpace(oeCombo.Id) AndAlso Not ClientesPublic.Contains(oeCombo) Then
                    ListaDatosNoValidos.Add(New List(Of String)() From {"Cliente", Fila.Index}.ToList)
                End If
            Next
            'Para que vuelva a pintar celdas en mantenimiento
            mt_ColorCeldaMantenimiento(griDetalles)
            For Each Lista In ListaDatosNoValidos
                If Lista.Count > 1 Then
                    griDetalles.Rows(Lista(1)).Cells(Lista(0)).Appearance.BackColor = Color.OrangeRed
                End If
            Next
            If ListaDatosNoValidos.Count > 0 Then
                MessageBox.Show("Ingrese datos válidos en las celdas resaltadas", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If
            Return True
        Catch ex As Exception
            Throw ex
        Finally
            oeDespachoValida = Nothing
            lstDespacho = Nothing
        End Try
    End Function

    Private Function lf_ValidarGrillaVacia(Grilla As UltraWinGrid.UltraGrid) As Boolean
        Dim oe As New e_Despacho
        Try
            If Grilla.Rows.Count <= 0 Then
                MessageBox.Show("No existe despacho seleccionado, listar para mostrar despachos", "Despacho", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If
            If Operacion = "Ejecutar" Then
                oe.Id = Grilla.Rows(0).Cells("IdDespacho").Value.ToString().Trim()
                oe = olDespacho.Obtener(oe)
                If Not String.IsNullOrWhiteSpace(oe.Id) Then
                    If oe.IdEstado <> IdEstadoGenerado Then
                        MessageBox.Show("Solo se pueden ejecutar despachos en estado Generado", "Despacho", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Operacion = "Inicializa"
                        Return False
                    End If
                End If
            Else 'Editar
                oe.Id = Grilla.Rows(0).Cells("IdDespacho").Value.ToString().Trim()
                oe = olDespacho.Obtener(oe)
                If Not String.IsNullOrWhiteSpace(oe.Id) Then
                    If oe.IdEstado = IdEstadoTerminada Then
                        If Operacion = "Eliminar" Then
                            MessageBox.Show("No se pueden eliminar despachos Terminados", "Despacho", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Operacion = "Inicializa"
                            Return False
                        Else
                            MessageBox.Show("No se pueden editar despachos Terminados", "Despacho", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Operacion = "Inicializa"
                            Return False
                        End If
                    End If
                End If
            End If
            Return True
        Catch ex As Exception
            Throw ex
        Finally
            oe = Nothing
        End Try
    End Function

#End Region

#Region "Eventos"

    Private Sub tspDespacho_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tspDespacho.ItemClicked
        Try
            Select Case e.ClickedItem.Name
                Case tsbAgregarDespacho.Name
                    mt_AgregarDespacho()
                Case tsbQuitarDespacho.Name
                    mt_QuitarDespacho()
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnGenerarDesde_Click(sender As Object, e As EventArgs) Handles btnGenerarDesde.Click
        Try
            If rbtUltimosViajes.Checked Then
                mt_ObtenerUltimosViajes()
            ElseIf rbtUltimoDespacho.Checked Then
                mt_ObtenerUltimoDespacho()
            ElseIf rbtImportarExcel.Checked Then
                mt_ImportarDesdeExcel()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griDetalles_BeforeCellUpdate(sender As Object, e As BeforeCellUpdateEventArgs) Handles griDetalles.BeforeCellUpdate
        Try
            If griDetalles.Rows.Count > 0 Then
                Select Case e.Cell.Column.Key
                    Case "Hora"
                        If IsDBNull(e.NewValue) OrElse e.NewValue Is Nothing Then
                            e.Cancel = True
                        End If
                        If IsDBNull(e.Cell.Value) Then e.Cell.Value = Date.Parse("01/01/1901")
                    Case "Tonelada", "Monto"
                        If IsDBNull(e.NewValue) Then
                            e.Cancel = True
                        End If
                        If IsDBNull(e.Cell.Value) Then e.Cell.Value = 0
                    Case "Seleccion"
                        If e.Cell.Row.IsFilteredOut Then
                            e.Cancel = True
                        End If
                End Select
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griDetalles_CellChange(sender As Object, e As CellEventArgs) Handles griDetalles.CellChange
        Try
            With griDetalles
                If .ActiveCell.EditorResolved IsNot Nothing AndAlso .ActiveCell.EditorResolved.IsValid = True Then
                    If Not .ActiveCell.Column.Key = "Hora" Then
                        .UpdateData()
                    End If
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griDetalles_CellDataError(sender As Object, e As CellDataErrorEventArgs) Handles griDetalles.CellDataError
        Try
            e.RaiseErrorEvent = False
            e.RestoreOriginalValue = True
            e.StayInEditMode = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cmsMenuListado_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles cmsMenuListado.ItemClicked
        Try
            Select Case e.ClickedItem.Name
                Case itemNuevo.Name
                    _acl = gAccionSistema.LECTURA.ToString
                    If Not ValidarAcl(_acl, pIdActividadNegocio) Then
                        Nuevo()
                    Else
                        Throw New Exception("Usted Tiene Permiso de: " & _acl & " en " & Me.Text)
                    End If
                Case itemEditar.Name
                    _acl = gAccionSistema.LECTURA.ToString
                    If Not ValidarAcl(_acl, pIdActividadNegocio) Then
                        Operacion = "Editar"
                        Editar()
                    Else
                        Throw New Exception("Usted Tiene Permiso de: " & _acl & " en " & Me.Text)
                    End If
                Case itemEliminar.Name
                    _acl = gAccionSistema.LECTURA.ToString
                    If Not ValidarAcl(_acl, pIdActividadNegocio) Then
                        Eliminar()
                    Else
                        Throw New Exception("Usted Tiene Permiso de: " & _acl & " en " & Me.Text)
                    End If
                Case itemEjecutar.Name
                    _acl = gAccionSistema.LECTURA.ToString
                    If Not ValidarAcl(_acl, pIdActividadNegocio) Then
                        Operacion = "Ejecutar"
                        Editar()
                    Else
                        Throw New Exception("Usted Tiene Permiso de: " & _acl & " en " & Me.Text)
                    End If
                Case itemGenerarProg.Name
                    _acl = gAccionSistema.LECTURA.ToString
                    If Not ValidarAcl(_acl, pIdActividadNegocio) Then
                        mt_GenerarProgramacion()
                    Else
                        Throw New Exception("Usted Tiene Permiso de: " & _acl & " en " & Me.Text)
                    End If
                Case itemFormatoClientes.Name
                    mt_ExportarFormatoClientes()
                Case itemResumenDiario.Name
                    mt_ResumenDiario()
                Case itemIniciarDespacho.Name
                    mt_IniciarDespacho()
                Case itemEditarViaje.Name
                    _acl = gAccionSistema.LECTURA.ToString
                    If Not ValidarAcl(_acl, pIdActividadNegocio) Then
                        mt_EditarViaje()
                    Else
                        Throw New Exception("Usted Tiene Permiso de: " & _acl & " en " & Me.Text)
                    End If
                    'Case itemProgramarEscala.Name
                    '    mt_ProgramarEscala()
                Case itemDesenlazarViaje.Name
                    _acl = gAccionSistema.LECTURA.ToString
                    If Not ValidarAcl(_acl, pIdActividadNegocio) Then
                        mt_DesenlazarViaje()
                    Else
                        Throw New Exception("Usted Tiene Permiso de: " & _acl & " en " & Me.Text)
                    End If
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub mt_DesenlazarViaje()
        Try
            Select Case utcDespachosDinamicos.SelectedTab.Index
                Case 0
                    If lf_ValidarGrillaVacia(griTab01) Then
                        mt_DesenlazarViaje(griTab01)
                    End If
                Case 1
                    If lf_ValidarGrillaVacia(griTab02) Then
                        mt_DesenlazarViaje(griTab02)
                    End If
                Case 2
                    If lf_ValidarGrillaVacia(griTab03) Then
                        mt_DesenlazarViaje(griTab03)
                    End If
                Case 3
                    If lf_ValidarGrillaVacia(griTab04) Then
                        mt_DesenlazarViaje(griTab04)
                    End If
                Case 4
                    If lf_ValidarGrillaVacia(griTab05) Then
                        mt_DesenlazarViaje(griTab05)
                    End If
                Case 5
                    If lf_ValidarGrillaVacia(griTab06) Then
                        mt_DesenlazarViaje(griTab06)
                    End If
                Case 6
                    If lf_ValidarGrillaVacia(griTab07) Then
                        mt_DesenlazarViaje(griTab07)
                    End If
                Case 7
                    If lf_ValidarGrillaVacia(griTab08) Then
                        mt_DesenlazarViaje(griTab08)
                    End If
                Case 8
                    If lf_ValidarGrillaVacia(griTab09) Then
                        mt_DesenlazarViaje(griTab09)
                    End If
                Case 9
                    If lf_ValidarGrillaVacia(griTab10) Then
                        mt_DesenlazarViaje(griTab10)
                    End If
                Case 10
                    If lf_ValidarGrillaVacia(griTab11) Then
                        mt_DesenlazarViaje(griTab11)
                    End If
                Case 11
                    If lf_ValidarGrillaVacia(griTab12) Then
                        mt_DesenlazarViaje(griTab12)
                    End If
                Case 12
                    If lf_ValidarGrillaVacia(griTab13) Then
                        mt_DesenlazarViaje(griTab13)
                    End If
                Case 13
                    If lf_ValidarGrillaVacia(griTab14) Then
                        mt_DesenlazarViaje(griTab14)
                    End If
                Case 14
                    If lf_ValidarGrillaVacia(griTab15) Then
                        mt_DesenlazarViaje(griTab15)
                    End If
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_DesenlazarViaje(Grilla As UltraGrid)
        Try
            If gf_ValidarFilaSeleccionada(Grilla) Then
                If Not String.IsNullOrWhiteSpace(Grilla.ActiveRow.Cells("IdViaje").Value) Then
                    If MessageBox.Show("Esta seguro de desenlazar el viaje del despacho seleccionado?", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        Dim oeDespOp As New e_DespachoOperaciones
                        oeDespOp.TipoOperacion = "A"
                        oeDespOp.Id = Grilla.ActiveRow.Cells("Id").Value
                        oeDespOp.UsuarioCrea = gUsuarioSGI.Id
                        oeDespOp.PrefijoID = gs_PrefijoIdSucursal '@0001
                        If olDespachoOperaciones.Guardar(oeDespOp) Then
                            MessageBox.Show("Operación realizada con éxito", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Consultar(True)
                        End If
                    End If
                Else
                    MessageBox.Show("El registro de despacho seleccionado aún no se a programado", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_EditarViaje()
        Try
            Select Case utcDespachosDinamicos.SelectedTab.Index
                Case 0
                    If lf_ValidarGrillaVacia(griTab01) Then
                        mt_EditarViaje(griTab01)
                    End If
                Case 1
                    If lf_ValidarGrillaVacia(griTab02) Then
                        mt_EditarViaje(griTab02)
                    End If
                Case 2
                    If lf_ValidarGrillaVacia(griTab03) Then
                        mt_EditarViaje(griTab03)
                    End If
                Case 3
                    If lf_ValidarGrillaVacia(griTab04) Then
                        mt_EditarViaje(griTab04)
                    End If
                Case 4
                    If lf_ValidarGrillaVacia(griTab05) Then
                        mt_EditarViaje(griTab05)
                    End If
                Case 5
                    If lf_ValidarGrillaVacia(griTab06) Then
                        mt_EditarViaje(griTab06)
                    End If
                Case 6
                    If lf_ValidarGrillaVacia(griTab07) Then
                        mt_EditarViaje(griTab07)
                    End If
                Case 7
                    If lf_ValidarGrillaVacia(griTab08) Then
                        mt_EditarViaje(griTab08)
                    End If
                Case 8
                    If lf_ValidarGrillaVacia(griTab09) Then
                        mt_EditarViaje(griTab09)
                    End If
                Case 9
                    If lf_ValidarGrillaVacia(griTab10) Then
                        mt_EditarViaje(griTab10)
                    End If
                Case 10
                    If lf_ValidarGrillaVacia(griTab11) Then
                        mt_EditarViaje(griTab11)
                    End If
                Case 11
                    If lf_ValidarGrillaVacia(griTab12) Then
                        mt_EditarViaje(griTab12)
                    End If
                Case 12
                    If lf_ValidarGrillaVacia(griTab13) Then
                        mt_EditarViaje(griTab13)
                    End If
                Case 13
                    If lf_ValidarGrillaVacia(griTab14) Then
                        mt_EditarViaje(griTab14)
                    End If
                Case 14
                    If lf_ValidarGrillaVacia(griTab15) Then
                        mt_EditarViaje(griTab15)
                    End If
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_EditarViaje(Grilla As UltraGrid)
        Try
            If gf_ValidarFilaSeleccionada(Grilla) Then
                If Not String.IsNullOrWhiteSpace(Grilla.ActiveRow.Cells("IdViaje").Value) Then
                    Dim oeViaje As New e_Viaje, olViaje As New l_Operacion
                    oeViaje.Id = Grilla.ActiveRow.Cells("IdViaje").Value.ToString().Trim()
                    Dim lstViaje As New List(Of e_Viaje)
                    lstViaje.AddRange(olOperacion.ListarViaje(New e_Viaje With {.TipoOperacion = "0", _
                                                                                    .Id = oeViaje.Id}))
                    If lstViaje.Count > 0 Then
                        oeViaje.IdOperacion = lstViaje(0).IdOperacion
                    End If
                    Dim Operacion As frm_Operacion = frm_Operacion.getInstancia
                    Operacion.MdiParent = frm_Menu
                    Operacion.Show()
                    Operacion.EditarFormExterno(oeViaje)
                Else
                    MessageBox.Show("El registro de despacho seleccionado aún no se a programado", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    'Private Sub mt_ProgramarEscala()
    '    Try
    '        Select Case utcDespachosDinamicos.SelectedTab.Index
    '            Case 0
    '                If lf_ValidarGrillaVacia(griTab01) Then
    '                    mt_ProgramarEscala(griTab01)
    '                End If
    '            Case 1
    '                If lf_ValidarGrillaVacia(griTab02) Then
    '                    mt_ProgramarEscala(griTab02)
    '                End If
    '            Case 2
    '                If lf_ValidarGrillaVacia(griTab03) Then
    '                    mt_ProgramarEscala(griTab03)
    '                End If
    '            Case 3
    '                If lf_ValidarGrillaVacia(griTab04) Then
    '                    mt_ProgramarEscala(griTab04)
    '                End If
    '            Case 4
    '                If lf_ValidarGrillaVacia(griTab05) Then
    '                    mt_ProgramarEscala(griTab05)
    '                End If
    '            Case 5
    '                If lf_ValidarGrillaVacia(griTab06) Then
    '                    mt_ProgramarEscala(griTab06)
    '                End If
    '            Case 6
    '                If lf_ValidarGrillaVacia(griTab07) Then
    '                    mt_ProgramarEscala(griTab07)
    '                End If
    '            Case 7
    '                If lf_ValidarGrillaVacia(griTab08) Then
    '                    mt_ProgramarEscala(griTab08)
    '                End If
    '            Case 8
    '                If lf_ValidarGrillaVacia(griTab09) Then
    '                    mt_ProgramarEscala(griTab09)
    '                End If
    '            Case 9
    '                If lf_ValidarGrillaVacia(griTab10) Then
    '                    mt_ProgramarEscala(griTab10)
    '                End If
    '            Case 10
    '                If lf_ValidarGrillaVacia(griTab11) Then
    '                    mt_ProgramarEscala(griTab11)
    '                End If
    '            Case 11
    '                If lf_ValidarGrillaVacia(griTab12) Then
    '                    mt_ProgramarEscala(griTab12)
    '                End If
    '            Case 12
    '                If lf_ValidarGrillaVacia(griTab13) Then
    '                    mt_ProgramarEscala(griTab13)
    '                End If
    '            Case 13
    '                If lf_ValidarGrillaVacia(griTab14) Then
    '                    mt_ProgramarEscala(griTab14)
    '                End If
    '            Case 14
    '                If lf_ValidarGrillaVacia(griTab15) Then
    '                    mt_ProgramarEscala(griTab15)
    '                End If
    '        End Select
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub

    'Private Sub mt_ProgramarEscala(Grilla As UltraGrid)
    '    Try
    '        If gf_ValidarFilaSeleccionada(Grilla) Then
    '            If Not String.IsNullOrWhiteSpace(Grilla.ActiveRow.Cells("IdEscala").Value) Then
    '                If Not String.IsNullOrWhiteSpace(Grilla.ActiveRow.Cells("IdViaje").Value) Then
    '                    Dim oeViaje As New e_Viaje, olViaje As New l_Operacion
    '                    oeViaje.Id = Grilla.ActiveRow.Cells("IdViaje").Value.ToString().Trim()
    '                    Dim lstViaje As New List(Of e_Viaje)
    '                    lstViaje.AddRange(olOperacion.ListarViaje(New e_Viaje With {.TipoOperacion = "0", _
    '                                                                                .Id = oeViaje.Id}))
    '                    If lstViaje.Count > 0 Then
    '                        oeViaje.IdOperacion = lstViaje(0).IdOperacion
    '                    End If
    '                    oeViaje.IdEscala = Grilla.ActiveRow.Cells("IdEscala").Value.ToString().Trim()
    '                    oeViaje.IdDespachoOperaciones = Grilla.ActiveRow.Cells("Id").Value.ToString().Trim()
    '                    Dim Operacion As frm_Operacion = frm_Operacion.getInstancia
    '                    Operacion.MdiParent = frm_Menu
    '                    Operacion.Show()
    '                    Operacion.ProgramarEscalaDespacho(oeViaje)
    '                Else
    '                    MessageBox.Show("No se puede generar una escala porque aun no se generado el viaje", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                End If
    '            Else
    '                MessageBox.Show("Verificar el registro seleccionado no tiene escala", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            End If
    '        End If
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub

    Private Sub mt_IniciarDespacho()
        Try
            Nuevo()
            Operacion = "IniciarDespacho"
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub frm_EstadoSituacionalVehiculo_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case TabDisponibilidad.SelectedTab.Index
                Case 2 'Despacho
                    Select Case utcDespacho.SelectedTab.Index
                        Case 1 'Mantenimiento
                            Select Case e.KeyCode
                                Case Keys.Enter
                                    SendKeys.Send("{TAB}")
                                Case Keys.Insert
                                    tsbAgregarDespacho.PerformClick()
                                Case Keys.Delete
                                    tsbQuitarDespacho.PerformClick()
                            End Select
                    End Select
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub UltraGridExcelExporter1_InitializeColumn(sender As Object, e As InitializeColumnEventArgs) Handles UltraGridExcelExporter1.InitializeColumn
        Try
            Select Case e.FrameworkFormatStr
                Case "HH:mm"
                    e.ExcelFormatStr = "hh:mm"
                Case Else
                    e.ExcelFormatStr = e.FrameworkFormatStr
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griDetalles_AfterCellUpdate(sender As Object, e As CellEventArgs) Handles griDetalles.AfterCellUpdate
        Try
            If e.Cell.Row.Index >= 0 Then
                Select Case e.Cell.Column.Key
                    Case "IdTracto"
                        If Not String.IsNullOrWhiteSpace(e.Cell.Value.ToString()) AndAlso _
                            TractoPublic.Where(Function(x) x.Id = e.Cell.Value.ToString()).Count > 0 Then
                            e.Cell.Row.Cells("IdMarcaVehiculo").Value = TractoPublic.Where(Function(x) x.Id = e.Cell.Value.ToString()).ToList(0).Extras(3)
                            e.Cell.Row.Cells("NroCelular").Value = TractoPublic.Where(Function(x) x.Id = e.Cell.Value.ToString()).ToList(0).Extras(4)
                        Else
                            e.Cell.Row.Cells("IdMarcaVehiculo").Value = String.Empty
                            e.Cell.Row.Cells("NroCelular").Value = String.Empty
                        End If
                    Case "Estado"
                        If Not String.IsNullOrWhiteSpace(e.Cell.Value.ToString()) AndAlso _
                            ListEstadoViajeDespacho.Where(Function(x) x.Nombre = "TALLER" And x.Id = e.Cell.Value.ToString()).Count > 0 Then
                            'griDetalles.DisplayLayout.Bands(0).Columns("EstadoAceptar").CellActivation = Activation.AllowEdit
                            e.Cell.Row.Cells("EstadoAceptar").Activation = Activation.AllowEdit
                        Else
                            e.Cell.Row.Cells("EstadoAceptar").Activation = Activation.Disabled
                        End If
                    Case "Seleccion"
                        griDetalles.UpdateData()
                    Case "Carreta"
                        If Not String.IsNullOrWhiteSpace(e.Cell.Value.ToString()) AndAlso _
                            CarretaPublic.Where(Function(x) x.Id = e.Cell.Value.ToString()).Count > 0 Then
                            mt_CambiarColorCeldaM(e.Cell, CarretaPublic.Where(Function(x) x.Id = e.Cell.Value.ToString())(0).Extras(5))
                        Else
                            e.Cell.Appearance.BackColor = Color.White
                        End If
                End Select
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub mt_CambiarColorCeldaM(ByRef Celda As UltraGridCell, IdModeloFuncional As String)
        Try
            Select Case IdModeloFuncional
                Case "1CH000000014"
                    Celda.Appearance.BackColor = Me.PlataformaM.Color
                Case "1CH000000007"
                    Celda.Appearance.BackColor = Me.FurgonM.Color
                Case "1CH000000018"
                    Celda.Appearance.BackColor = Me.GraneleroM.Color
                Case "1CH000000008"
                    Celda.Appearance.BackColor = Me.FurgonLargoM.Color
                Case "1CH000000030"
                    Celda.Appearance.BackColor = Me.BarandaM.Color
                Case "1CH000000013"
                    Celda.Appearance.BackColor = Me.CisternaM.Color
                Case "1CH000000016"
                    Celda.Appearance.BackColor = Me.CaliceraM.Color
                Case "1CH000000011"
                    Celda.Appearance.BackColor = Me.TolvaVolteoM.Color
                Case "1CH000000019"
                    Celda.Appearance.BackColor = Me.MediaBarandaM.Color
                Case "1CH000000017"
                    Celda.Appearance.BackColor = Me.FurgonAmericanoM.Color
                Case "1CH000000031"
                    Celda.Appearance.BackColor = Me.BombomaM.Color
                Case "1CH000000020"
                    Celda.Appearance.BackColor = Me.ParihueleroM.Color
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_ActivaDesactivaCeldas()
        Try
            For Each F In griDetalles.Rows
                'Activa Desactiva Celda 
                If F.Cells("Estado").Value = "TALLER" Then
                    F.Cells("EstadoAceptar").Activation = Activation.AllowEdit
                Else
                    F.Cells("EstadoAceptar").Activation = Activation.Disabled
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_ObtenerMarcaCelular()
        Try
            For Each F In griDetalles.Rows
                'Obtiene Marca y NroCelular
                If Not String.IsNullOrWhiteSpace(F.Cells("IdTracto").Value.ToString()) AndAlso _
                             TractoPublic.Where(Function(x) x.Id = F.Cells("IdTracto").Value.ToString()).Count > 0 Then
                    F.Cells("IdMarcaVehiculo").Value = TractoPublic.Where(Function(x) x.Id = F.Cells("IdTracto").Value.ToString()).ToList(0).Extras(3)
                    F.Cells("NroCelular").Value = TractoPublic.Where(Function(x) x.Id = F.Cells("IdTracto").Value.ToString()).ToList(0).Extras(4)
                Else
                    F.Cells("IdMarcaVehiculo").Value = String.Empty
                    F.Cells("NroCelular").Value = String.Empty
                End If
            Next
            griDetalles.UpdateData()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub utcDespachosDinamicos_SelectedTabChanged(sender As Object, e As UltraWinTabControl.SelectedTabChangedEventArgs) Handles utcDespachosDinamicos.SelectedTabChanged
        Try
            If utcDespachosDinamicos.SelectedTab IsNot Nothing Then
                Select Case utcDespachosDinamicos.SelectedTab.Index
                    Case 0
                        mt_ColorCeldaCarreta(griTab01)
                        mt_CalcularTotalesFiltro(griTab01)
                        mt_ColorCeldaMantenimiento(griTab01)
                    Case 1
                        mt_ColorCeldaCarreta(griTab02)
                        mt_CalcularTotalesFiltro(griTab02)
                        mt_ColorCeldaMantenimiento(griTab02)
                    Case 2
                        mt_ColorCeldaCarreta(griTab03)
                        mt_CalcularTotalesFiltro(griTab03)
                        mt_ColorCeldaMantenimiento(griTab03)
                    Case 3
                        mt_ColorCeldaCarreta(griTab04)
                        mt_CalcularTotalesFiltro(griTab04)
                        mt_ColorCeldaMantenimiento(griTab04)
                    Case 4
                        mt_ColorCeldaCarreta(griTab05)
                        mt_CalcularTotalesFiltro(griTab05)
                        mt_ColorCeldaMantenimiento(griTab05)
                    Case 5
                        mt_ColorCeldaCarreta(griTab06)
                        mt_CalcularTotalesFiltro(griTab06)
                        mt_ColorCeldaMantenimiento(griTab06)
                    Case 6
                        mt_ColorCeldaCarreta(griTab07)
                        mt_CalcularTotalesFiltro(griTab07)
                        mt_ColorCeldaMantenimiento(griTab07)
                    Case 7
                        mt_ColorCeldaCarreta(griTab08)
                        mt_CalcularTotalesFiltro(griTab08)
                        mt_ColorCeldaMantenimiento(griTab08)
                    Case 8
                        mt_ColorCeldaCarreta(griTab09)
                        mt_CalcularTotalesFiltro(griTab09)
                        mt_ColorCeldaMantenimiento(griTab09)
                    Case 9
                        mt_ColorCeldaCarreta(griTab10)
                        mt_CalcularTotalesFiltro(griTab10)
                        mt_ColorCeldaMantenimiento(griTab10)
                    Case 10
                        mt_ColorCeldaCarreta(griTab11)
                        mt_CalcularTotalesFiltro(griTab11)
                        mt_ColorCeldaMantenimiento(griTab11)
                    Case 11
                        mt_ColorCeldaCarreta(griTab12)
                        mt_CalcularTotalesFiltro(griTab12)
                        mt_ColorCeldaMantenimiento(griTab12)
                    Case 12
                        mt_ColorCeldaCarreta(griTab13)
                        mt_CalcularTotalesFiltro(griTab13)
                        mt_ColorCeldaMantenimiento(griTab13)
                    Case 13
                        mt_ColorCeldaCarreta(griTab14)
                        mt_CalcularTotalesFiltro(griTab14)
                        mt_ColorCeldaMantenimiento(griTab14)
                    Case 14
                        mt_ColorCeldaCarreta(griTab15)
                        mt_CalcularTotalesFiltro(griTab15)
                        mt_ColorCeldaMantenimiento(griTab15)
                End Select
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            'Dim Operacion As frm_Operacion = frm_Operacion.getInstancia
            'Operacion.MdiParent = frm_Menu
            'Operacion.Show()
            'Operacion.ProgramarViajeDespacho(oeViaje)
            Dim FRM As frm_UltimaUbicacionUnidades = frm_UltimaUbicacionUnidades.getInstancia
            FRM.MdiParent = frm_Menu
            FRM.Show()
            mt_ControlBotoneria()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cmsMenuMantenimiento_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles cmsMenuMantenimiento.ItemClicked
        Try
            Select Case e.ClickedItem.Name
                Case itemMantenimiento.Name
                    If griDetalles.Rows.Count > 0 AndAlso griDetalles.ActiveRow IsNot Nothing AndAlso griDetalles.ActiveRow.Index >= 0 Then
                        With griDetalles
                            If .ActiveRow.Cells("Ocurrencia").Value = "1" Then
                                .ActiveRow.Cells("Ocurrencia").Value = "0"
                                .ActiveRow.Cells("IdTracto").Appearance.BackColor = Color.White
                                .ActiveRow.Cells("MNTO").Value = String.Empty
                            Else
                                .ActiveRow.Cells("Ocurrencia").Value = "1"
                                .ActiveRow.Cells("IdTracto").Appearance.BackColor = colorMant.Color
                                .ActiveRow.Cells("MNTO").Activate()
                                .Focus()
                                .PerformAction(UltraGridAction.EnterEditMode, False, False)
                            End If
                        End With
                    Else
                        MessageBox.Show("No ha seleccionado ningun registro", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Case itemMantUrgente.Name
                    If griDetalles.Rows.Count > 0 AndAlso griDetalles.ActiveRow IsNot Nothing AndAlso griDetalles.ActiveRow.Index >= 0 Then
                        With griDetalles
                            If .ActiveRow.Cells("Ocurrencia").Value = "2" Then
                                .ActiveRow.Cells("Ocurrencia").Value = "0"
                                .ActiveRow.Cells("IdTracto").Appearance.BackColor = Color.White
                                .ActiveRow.Cells("MNTO").Value = String.Empty
                            Else
                                .ActiveRow.Cells("Ocurrencia").Value = "2"
                                .ActiveRow.Cells("IdTracto").Appearance.BackColor = colorMantUrgente.Color
                                .ActiveRow.Cells("MNTO").Activate()
                                .Focus()
                                .PerformAction(UltraGridAction.EnterEditMode, False, False)
                            End If
                        End With
                    Else
                        MessageBox.Show("No ha seleccionado ningun registro", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Case itemResaltarCeldas.Name
                    If griDetalles.Rows.Count > 0 AndAlso griDetalles.ActiveRow IsNot Nothing AndAlso griDetalles.ActiveRow.Index >= 0 Then
                        With griDetalles
                            If .ActiveRow.Cells("Observacion").Value = "1" Then
                                .ActiveRow.Cells("Observacion").Value = "0"
                                .ActiveRow.Cells("Origen").Appearance.BackColor = Color.White
                                .ActiveRow.Cells("Destino").Appearance.BackColor = Color.White
                            Else
                                .ActiveRow.Cells("Observacion").Value = "1"
                                .ActiveRow.Cells("Origen").Appearance.BackColor = colorCeldaResaltada.Color
                                .ActiveRow.Cells("Destino").Appearance.BackColor = colorCeldaResaltada.Color
                            End If
                        End With
                    Else
                        MessageBox.Show("No ha seleccionado ningun registro", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Case itemResaltarEstado.Name
                    If griDetalles.Rows.Count > 0 AndAlso griDetalles.ActiveRow IsNot Nothing AndAlso griDetalles.ActiveRow.Index >= 0 Then
                        With griDetalles
                            If Convert.ToBoolean(.ActiveRow.Cells("IndMantenimiento").Value) Then
                                .ActiveRow.Cells("IndMantenimiento").Value = False
                                .ActiveRow.Cells("Estado").Appearance.BackColor = Color.White
                            Else
                                .ActiveRow.Cells("IndMantenimiento").Value = True
                                .ActiveRow.Cells("Estado").Appearance.BackColor = colorColumnaEstado.Color
                            End If
                        End With
                    Else
                        MessageBox.Show("No ha seleccionado ningun registro", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griDetalles_ClickCellButton(sender As Object, e As CellEventArgs) Handles griDetalles.ClickCellButton
        Try
            Select Case e.Cell.Column.Key
                Case "EstadoAceptar"
                    e.Cell.Row.Cells("Copiloto").Value = e.Cell.Row.Cells("Piloto").Value
                    e.Cell.Row.Cells("Piloto").Value = "0"
                    e.Cell.Row.Cells("Cliente").Value = String.Empty
                    e.Cell.Row.Cells("EstadoGlosa").Value = "TALLER"
                    e.Cell.Row.Cells("Disponible").Value = "TALLER"
                    griDetalles.UpdateData()
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griTab01_BeforeCellUpdate(sender As Object, e As BeforeCellUpdateEventArgs) Handles griTab01.BeforeCellUpdate, griTab02.BeforeCellUpdate, griTab03.BeforeCellUpdate, griTab04.BeforeCellUpdate, griTab05.BeforeCellUpdate, griTab06.BeforeCellUpdate, _
                                                                                                    griTab07.BeforeCellUpdate, griTab08.BeforeCellUpdate, griTab09.BeforeCellUpdate, griTab10.BeforeCellUpdate, griTab11.BeforeCellUpdate, griTab12.BeforeCellUpdate, _
                                                                                                    griTab13.BeforeCellUpdate, griTab14.BeforeCellUpdate, griTab15.BeforeCellUpdate
        Try
            If CType(sender, UltraGrid).Rows.Where(Function(x) x.IsFilteredOut = False).Count > 0 Then
                Select Case e.Cell.Column.Key
                    Case "Seleccion"
                        If e.Cell.Row.IsFilteredOut Then
                            e.Cancel = True
                        End If
                End Select
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboZonaListado_ValueChanged(sender As Object, e As EventArgs) Handles cboZonaListado.ValueChanged
        Try
            If cboZonaListado.DataSource IsNot Nothing AndAlso cboZonaListado.SelectedIndex >= 0 Then
                ugbTotalesLista.Text = "Totales ( Zona: " & cboZonaListado.Text & " )"
                utcDespachosDinamicos_SelectedTabChanged(Nothing, Nothing)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub


#End Region

#Region "Bloqueo de Registros Editados"

    'Private RegistroEditado As Integer = 0
    'Private oeRegistroEditado As e_RegistrosEditados, olRegistroEditado As New l_RegistrosEditados

    'Private Function lf_VerificarRegistroEditado(IdDespacho As String) As Boolean
    '    Try
    '        oeDespacho.Dispose()
    '        oeDespacho.TipoOperacion = "BRE"
    '        oeDespacho.Id = IdDespacho
    '        Dim lstDespacho As List(Of e_Despacho) = olDespacho.Listar(oeDespacho, False)
    '        If lstDespacho.Count > 0 Then
    '            If Not String.IsNullOrWhiteSpace(lstDespacho(0).Codigo) Then
    '                If lstDespacho(0).UsuarioCrea.Trim() <> gUsuarioSGI.oePersona.NombreCompleto.Trim() Then
    '                    mensajeEmergente.Confirmacion( _
    '                                    "La información del Despacho no es accesible porque está siendo editado por: " & Environment.NewLine & _
    '                                    "Usuario: " & lstDespacho(0).UsuarioCrea & Environment.NewLine & _
    '                                    "Desde: " & lstDespacho(0).FechaCrea.ToShortDateString & Environment.NewLine & _
    '                                    "En la sucursal: " & lstDespacho(0).IdCentro, True)
    '                    Return False
    '                Else
    '                    oeRegistroEditado = New e_RegistrosEditados
    '                    With oeRegistroEditado
    '                        .TipoOperacion = "A"
    '                        .Id = lstDespacho(0).Codigo
    '                        .FechaModificado = DateAdd(DateInterval.Minute, 5, ObtenerFechaServidor())
    '                    End With
    '                    olRegistroEditado.Guardar(oeRegistroEditado)
    '                    RegistroEditado = 1
    '                End If
    '            Else
    '                RegistroEditado = 1
    '            End If
    '        End If
    '        Return True
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Function

    'Private IdRegistroEditado As String = String.Empty

    'Public Sub mt_GuardarRegistroEditado(IdDespacho As String)
    '    Try
    '        If RegistroEditado = 1 Then
    '            oeRegistroEditado = New e_RegistrosEditados
    '            With oeRegistroEditado
    '                .IdRegistro = IdDespacho
    '                .Referencia = "Despacho"
    '                .UsuarioEdita = gUsuarioSGI.Id
    '            End With
    '            IdRegistroEditado = olRegistroEditado.Guardar(oeRegistroEditado)
    '        End If
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub

    'Private Function mt_ActualizaRegistroEditado() As Boolean
    '    Try
    '        If RegistroEditado = 1 Then
    '            oeRegistroEditado = New e_RegistrosEditados
    '            With oeRegistroEditado
    '                .Id = IdRegistroEditado
    '            End With
    '            olRegistroEditado.Guardar(oeRegistroEditado)
    '            RegistroEditado = 0
    '        End If
    '        Return True
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Function

#End Region

#End Region

    
End Class