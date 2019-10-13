'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF
Imports Infragistics.Win
Imports Infragistics.Shared
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinEditors
Imports System.Configuration
Imports Infragistics.Win.CalcEngine
Imports Infragistics.Win.UltraWinDataSource
Imports System.Threading
Imports System.Data.OleDb
Imports Microsoft.Office.Interop
Imports System.Text

Public Class frm_RegistroSeguimiento
    Inherits ISL.Win.frm_MenuPadre

#Region "Inicializar el formulario"

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_RegistroSeguimiento = Nothing
    Private Shared Operacion As String

    ''' <summary>
    ''' Instancia unica de Formulario: frm_DemandaRapida
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function getInstancia() As frm_MenuPadre

        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_RegistroSeguimiento()
        End If
        instancia.Activate()
        Return instancia
    End Function

    Public Sub CargarNuevoSeguimiento(ByVal IdViaje As String)
        Try
            If IdViaje <> "" Then
                Operacion = "Nuevo"
                ugb_Espera.Visible = True
                Application.DoEvents()
                Cursor.Current = Cursors.WaitCursor
                Cursor.Show()

                Inicializar()
                btnBuscar.Enabled = False
                MostrarTabs(1, tcPrincipal, 1)
                MyBase.Nuevo()

                oeViaje = New e_Viaje
                oeViaje.Id = IdViaje
                oeViaje.TipoOperacion = "G"
                oeViaje = olOperacion.ObtenerViaje(oeViaje)
                LlenarDatosViaje(oeViaje)
                cboLugar.Value = oeViaje.IdOrigen.Trim

                oeSeguimiento = New e_Seguimiento
                oeSeguimiento.IdViaje = oeViaje.Id.Trim
                oeSeguimiento.TipoOperacion = ""
                Dim listaSeguimiento As List(Of e_Seguimiento)
                listaSeguimiento = olSeguimiento.Listar(oeSeguimiento)
                oeSeguimiento = listaSeguimiento(0)
                LlenarDatosSeguimiento(oeSeguimiento)

                CargarGrillasDetalle(oeViaje.Id, oeViaje.IdPiloto, oeViaje.IdTracto)
                ObtenerRuta()
                CalcularFechaLlegada()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

#End Region

#Region "Definicion de Variables"
    Dim _ingresando_datos As Boolean = False

    Dim TiempoMaximoViaje As Long = 0
    Public IdViaje As String = String.Empty

    Dim olOperacion As New l_Operacion
    Dim oeViaje As New e_Viaje

    Dim olRuta As New l_Ruta
    Dim oeRuta As New e_Ruta

    Dim olSeguimiento As New l_Seguimiento
    Dim oeSeguimiento As New e_Seguimiento

    Dim olVehiculo As New l_Vehiculo
    Dim oeVehiculo As New e_Vehiculo

    Dim loConcepto As New l_Concepto
    Dim oeConcepto As New e_Concepto
    Dim ListaConcepto As New List(Of e_Concepto)

    Dim olIncidenciaMaestro As New l_IncidenciaMaestro
    Dim oeIncidenciaMaestro As New e_IncidenciaMaestro

    Dim olSeguimientoMonitoreo As New l_SeguimientoMonitoreo
    Dim oeSeguimientoMonitoreo As New e_SeguimientoMonitoreo
    Dim listaSeguimientoMonitoreo As New List(Of e_SeguimientoMonitoreo)
    

    Dim olAccidente As New l_AccidenteIncidencia
    Dim oeAccidente As New e_AccidenteIncidencia
    Dim listaAccidente As New List(Of e_AccidenteIncidencia)
    Dim listaAreaAccidente As New List(Of e_AreaResponsableEvento)
    Dim NuevoAccidente As Boolean = True

    Dim olIncidente As New l_Incidente
    Dim oeIncidente As New e_Incidente
    Dim listaIncidente As New List(Of e_Incidente)
    Dim listaAreaIncidente As New List(Of e_AreaResponsableEvento)
    Dim NuevoIncidente As Boolean = True

    Dim olRobo As New l_Robo
    Dim oeRobo As New e_Robo
    Dim listaRobo As New List(Of e_Robo)
    Dim listaAreaRobo As New List(Of e_AreaResponsableEvento)
    Dim NuevoRobo As Boolean = True

    Dim olAreaTipoEvento As New l_AreaTipoEvento
    Dim oeAreaTipoEvento As New e_AreaTipoEvento
    Dim listaAreaTipoEvento As New List(Of e_AreaTipoEvento)
    Dim olAreaResponsableEvento As New l_AreaResponsableEvento

#End Region

#Region "Botonera"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Operacion = "Inicializa"
            If ValidarFechaInicioFin(fecDesde, fecHasta) Then
                Listar(Activo)
                Tiempo1.Enabled = True
                If griLista.Rows.Count > 0 Then
                    MyBase.Consultar(Activo)
                Else
                    MyBase.Consultar()
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            Operacion = "Nuevo"
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()

            Inicializar()
            btnBuscar.Enabled = True
            MostrarTabs(1, tcPrincipal, 1)
            MyBase.Nuevo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            If tabListado.Tabs(0).Selected = True Then ' tab Listado General
                ugb_Espera.Visible = True
                Application.DoEvents()
                Cursor.Current = Cursors.WaitCursor
                Cursor.Show()
                MostrarTabs(1, tcPrincipal)
                Inicializar()
                Operacion = "Editar"
                CargarEditar()
                btnBuscar.Enabled = False
                MyBase.Editar()
            ElseIf tabListado.Tabs(1).Selected = True Then ' tab Listado enviar email
                mensajeEmergente.Problema("Seleccionar registro del Listado General.", True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If tcPrincipal.SelectedTab.Key = "ImportarDatos" Then
                GuardarImportar()
            Else
                If GuardarSeguimiento() Then
                    MyBase.Guardar()
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If IdViaje = "" Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados?", "Mensaje del sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        Guardar()
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, tcPrincipal)
                        MyBase.Cancelar()
                        Consultar(True)
                    Case Windows.Forms.DialogResult.Cancel
                End Select
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            If tabListado.Tabs(0).Selected = True Then ' tab Listado General
                If ValidarGrilla(griLista, "Seguimiento Monitoreo") Then
                    Dim Codigo As String = griLista.ActiveRow.Cells("Codigo").Value.ToString.Trim
                    If MessageBox.Show("Esta seguro de eliminar seguimiento Monitoreo: " & _
                                 Codigo & " ?", _
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                        oeSeguimientoMonitoreo = New e_SeguimientoMonitoreo
                        oeSeguimientoMonitoreo.TipoOperacion = "E"
                        oeSeguimientoMonitoreo.Id = griLista.ActiveRow.Cells("Id").Value.ToString.Trim
                        oeSeguimientoMonitoreo.UsuarioCreacion = gUsuarioSGI.Id.Trim
                        olSeguimientoMonitoreo.Eliminar(oeSeguimientoMonitoreo)
                        Consultar(True)
                    End If
                End If
            ElseIf tabListado.Tabs(1).Selected = True Then ' tab Listado enviar email
                mensajeEmergente.Problema("Debe Seleccionar Registro del Listado General", True)
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

    Public Overrides Sub Exportar()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            If tabListado.Tabs(0).Selected = True Then ' tab Listado General
                ExportarGrillaAExcel(griLista)
            ElseIf tabListado.Tabs(1).Selected = True Then ' tab Listado enviar email
                ExportarGrillaAExcel(griListaEnviarEmail)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
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

#End Region

#Region "Eventos"
    Private Sub frm_RegistroSeguimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            gmt_ConfigurarEventoKeyEnter_Tab(Me)
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            Tiempo1.Enabled = False
            MostrarTabs(0, tcPrincipal)
            InicializaTiempo()
            LlenaCombos()
            fecDesde.Value = Now.Date.AddDays(-5)
            fecHasta.Value = Now.Date.AddDays(+1)

            If IdViaje <> "" Then
                btnGuardarRapido.Visible = True
                SeguimientoRapido()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim Formulario As New frm_BuscarViajes
            Formulario.CodigoViaje = String.Empty
            Formulario.ShowDialog()
            If Formulario.DialogResult = Windows.Forms.DialogResult.OK Then
                oeViaje = New e_Viaje
                oeViaje.Id = Formulario.CodigoViaje.Trim
                oeViaje.TipoOperacion = "G"
                oeViaje = olOperacion.ObtenerViaje(oeViaje)
                LlenarDatosViaje(oeViaje)
                cboLugar.Value = oeViaje.IdOrigen.Trim

                oeSeguimiento = New e_Seguimiento
                oeSeguimiento.IdViaje = oeViaje.Id.Trim
                oeSeguimiento.TipoOperacion = ""
                Dim listaSeguimiento As List(Of e_Seguimiento)
                listaSeguimiento = olSeguimiento.Listar(oeSeguimiento)
                oeSeguimiento = listaSeguimiento(0)
                LlenarDatosSeguimiento(oeSeguimiento)
                CargarGrillasDetalle(oeViaje.Id, oeViaje.IdPiloto, oeViaje.IdTracto)
                ObtenerRuta()
                CalcularFechaLlegada()
            End If
            Formulario.Dispose()
            Formulario.Close()
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griLista_DoubleClickRow(sender As Object, e As DoubleClickRowEventArgs) Handles griLista.DoubleClickRow
        Try
            If griLista.Selected.Rows.Count > 0 Then Editar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub
    Private Sub griLista_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griLista.BeforeRowsDeleted
        Try
            e.DisplayPromptMsg = False
            e.Cancel = True
            Eliminar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboLugar_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboLugar.SelectionChangeCommitted
        Try
            ObtenerRuta()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    'Private Sub txtViajeDestino_ValueChanged(sender As Object, e As EventArgs) Handles txtViajeDestino.ValueChanged
    '    Try
    '        ObtenerRuta()
    '    Catch ex As Exception
    '        mensajeEmergente.Problema(ex.Message, True)
    '    End Try
    'End Sub

    Private Sub fecSeguimiento_ValueChanged(sender As Object, e As EventArgs) Handles fecSeguimiento.ValueChanged
        Try
            CalcularFechaLlegada()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub horSeguimiento_ValueChanged(sender As Object, e As EventArgs) Handles horSeguimiento.ValueChanged
        Try
            CalcularFechaLlegada()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub fecAproxLlegada_ValueChanged(sender As Object, e As EventArgs) Handles fecAproxLlegada.ValueChanged
        Try
            CalcularEstado()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub horAproxLlegada_ValueChanged(sender As Object, e As EventArgs) Handles horAproxLlegada.ValueChanged
        Try
            CalcularEstado()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub fecEntrega_ValueChanged(sender As Object, e As EventArgs) Handles fecEntrega.ValueChanged
        Try
            CalcularEstado()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub horEntrega_ValueChanged(sender As Object, e As EventArgs) Handles horEntrega.ValueChanged
        Try
            CalcularEstado()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub EnviarCorreoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnviarCorreoToolStripMenuItem.Click
        Try
            If griLista.Selected.Rows.Count = 1 Then
                Dim formulario As frm_EnvioEmail
                formulario = New frm_EnvioEmail
                formulario.Modulo = "SeguimientoMonitoreo"
                formulario.asunto = "Seguimiento Monitoreo: " & griLista.ActiveRow.Cells("Codigo").Value.ToString.Trim
                formulario.cadenaMensajeHtml = getBodyEmail()
                formulario.ShowDialog()
            Else
                mensajeEmergente.Confirmacion("Debe seleccionar un registro.", True)
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griListaSeguimientoViaje_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griListaSeguimientoViaje.BeforeRowsDeleted
        Try
            e.Cancel = True
            e.DisplayPromptMsg = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griListaSeguimientoConductor_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griListaSeguimientoConductor.BeforeRowsDeleted
        Try
            e.Cancel = True
            e.DisplayPromptMsg = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griListaSeguimientoVehiculo_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griListaSeguimientoVehiculo.BeforeRowsDeleted
        Try
            e.Cancel = True
            e.DisplayPromptMsg = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub


    Private Sub frm_RegistroSeguimiento_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub
    Private Sub frm_RegistroSeguimiento_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
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

#End Region

#Region "Metodos"
    Private Sub Inicializar()
        oeSeguimientoMonitoreo = New e_SeguimientoMonitoreo
        oeSeguimientoMonitoreo.TipoOperacion = "I"
        oeSeguimientoMonitoreo.UsuarioCreacion = gUsuarioSGI.Id.Trim
        oeSeguimientoMonitoreo.IdViaje = ""
        Limpiar()
    End Sub

    Private Sub Limpiar()
        LimpiarSeguimientoMonitoreo()
        LimpiarViaje()
        LimpiarSeguimiento()
    End Sub

    Private Sub LimpiarSeguimientoMonitoreo()
        cboLugar.SelectedIndex = 0
        txtReferencia.Text = String.Empty
        cboOperador.SelectedIndex = 0
        fecSeguimiento.Value = Date.Now
        horSeguimiento.Value = Date.Now
        fecAproxLlegada.Value = Date.Now
        horAproxLlegada.Value = Date.Now
        fecEntrega.Value = Date.Now
        horEntrega.Value = Date.Now
        txtGlosa.Text = String.Empty
        cboEstado.SelectedIndex = 0

        listaSeguimientoMonitoreo = New List(Of e_SeguimientoMonitoreo)

        Dim listaViaje = From lvi In listaSeguimientoMonitoreo _
                     Select Id = lvi.Id, Codigo = lvi.Codigo, IdViaje = lvi.IdViaje, Fecha = lvi.Fecha, FechaAproxLlegada = lvi.FechaAproxLlegada, FechaEntrega = lvi.FechaEntrega _
                     , IdUbicacion = lvi.IdUbicacion, Ubicacion = lvi.Ubicacion, ReferenciaLugar = lvi.ReferenciaLugar, IdOperador = lvi.IdOperador, Operador = lvi.Operador, Glosa = lvi.Glosa _
                     , Estado = lvi.Estado, NombreEstado = lvi.NombreEstado, FechaCreacion = lvi.FechaCreacion, FechaModifica = lvi.FechaModifica, UsuarioCreacion = lvi.UsuarioCreacion _
                     , lvi.UsuarioModifica, CodigoViaje = lvi.oeViaje.Codigo, FechaViaje = lvi.oeViaje.Fecha, lvi.oeViaje.IdOrigen _
                    , Origen = lvi.oeViaje.Origen, IdDestino = lvi.oeViaje.IdDestino, Destino = lvi.oeViaje.Destino, IdPiloto = lvi.oeViaje.IdPiloto _
                    , Piloto = lvi.oeViaje.Piloto, IdCopiloto = lvi.oeViaje.IdCopiloto, Copiloto = lvi.oeViaje.Copiloto, CargaMaterial = lvi.oeViaje.CargaMaterial _
                    , PesoToneladas = lvi.oeViaje.PesoToneladas, IdTracto = lvi.oeViaje.IdTracto, Tracto = lvi.oeViaje.Tracto, IdEscala = lvi.oeViaje.IdEscala _
                    , Escala = lvi.oeViaje.Escala, Cliente = lvi.oeViaje.Cliente, Carreta = lvi.oeViaje.Carreta, TipoVehiculo = lvi.oeViaje.TipoVehiculo _
                    , SalidaOrigen = lvi.oeSeguimiento.SalidaOrigen

        griListaSeguimientoViaje.DataSource = listaViaje.ToList
        griListaSeguimientoViaje.DataBind()

        griListaSeguimientoConductor.DataSource = listaViaje.ToList
        griListaSeguimientoConductor.DataBind()

        griListaSeguimientoVehiculo.DataSource = listaViaje.ToList
        griListaSeguimientoVehiculo.DataBind()
    End Sub

    Private Sub LimpiarViaje()
        txtIdViaje.Text = String.Empty
        txtIdSeguimiento.Text = String.Empty
        txtCodigoOperacion.Text = String.Empty
        txtCodigoViaje.Text = String.Empty
        txtViajeTracto.Text = String.Empty
        txtViajeCarreta.Text = String.Empty
        fecViaje.Value = Date.Now
        txtViajeOrigen.Text = String.Empty
        txtViajeDestino.Text = String.Empty
        txtViajePiloto.Text = String.Empty
        txtViajeCopiloto.Text = String.Empty
        txtViajeEscala.Text = String.Empty
        cboActividadNegocio.Value = 0
        txtMovil.Text = String.Empty
    End Sub

    Private Sub LimpiarSeguimiento()
        fecLlegadaOrigen.Value = Date.Now
        horLlegadaOrigen.Value = Date.Now
        fecCargaOrigen.Value = Date.Now
        horCargaOrigen.Value = Date.Now
        fecTerminoCargaOrigen.Value = Date.Now
        horTerminoCargaOrigen.Value = Date.Now
        fecSalidaOrigen.Value = Date.Now
        horSalidaOrigen.Value = Date.Now
        fecLlegadaDestino.Value = Date.Now
        horLlegadaDestino.Value = Date.Now
        fecInicioDescargaDestino.Value = Date.Now
        horInicioDescargaDestino.Value = Date.Now
        fecTerminoDescargaDestino.Value = Date.Now
        horTerminoDescargaDestino.Value = Date.Now
        fecSalidaDestino.Value = Date.Now
        horSalidaDestino.Value = Date.Now
    End Sub

    Private Sub LlenarDatosViaje(ByVal objViaje As e_Viaje)
        Try
            LimpiarViaje()
            If objViaje Is Nothing Then Return
            With objViaje
                txtIdViaje.Text = .Id.Trim
                txtIdSeguimiento.Text = .Id
                txtCodigoOperacion.Text = .Operacion
                txtCodigoViaje.Text = .Codigo
                txtViajeTracto.Text = .Tracto
                txtViajeCarreta.Text = .Carreta
                fecViaje.Value = .Fecha
                txtViajeOrigen.Text = .Origen
                txtViajeDestino.Text = .Destino
                txtViajePiloto.Text = .Piloto
                txtViajeCopiloto.Text = .Copiloto
                txtViajeEscala.Text = .Escala
                cboActividadNegocio.Value = .Tesoreria

                oeVehiculo = New e_Vehiculo
                oeVehiculo.Id = objViaje.IdTracto
                oeVehiculo = olVehiculo.Obtener(oeVehiculo)
                txtMovil.Text = oeVehiculo.NroEquipoMovil
                cboOperador.Value = oeVehiculo.IdEmpresaGPS.Trim

                Dim oeOperacionDetalle As New e_OperacionDetalle
                oeOperacionDetalle.IdOperacion = objViaje.IdOperacion
                oeOperacionDetalle = olOperacion.ListarOperacionDetalle(oeOperacionDetalle)(0)

                Dim olDemanda As New l_Demanda
                Dim oeDemanda As New e_Demanda
                oeDemanda.Id = oeOperacionDetalle.IdDemanda
                If oeOperacionDetalle.IdDemanda = "" Then
                    mensajeEmergente.Problema("Viaje no tiene asociado una demanda.", True)
                    fecEntrega.Value = Date.Now
                    horEntrega.Value = Date.Now
                    fecEntregaVenta.Value = Date.Now
                    horEntregaVenta.Value = Date.Now
                    Return
                End If
                oeDemanda.TipoOperacion = "6"
                oeDemanda = olDemanda.Obtener(oeDemanda)
                fecEntrega.Value = oeDemanda.FechaRecepcion
                horEntrega.Value = oeDemanda.FechaRecepcion
                fecEntregaVenta.Value = oeDemanda.FechaRecepcion
                horEntregaVenta.Value = oeDemanda.FechaRecepcion
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub LlenarDatosSeguimiento(ByVal objSeguimiento As e_Seguimiento)
        Try
            LimpiarSeguimiento()
            If objSeguimiento Is Nothing Then Return
            fecLlegadaOrigen.Value = objSeguimiento.LlegadaOrigen
            horLlegadaOrigen.Value = objSeguimiento.LlegadaOrigen
            fecCargaOrigen.Value = objSeguimiento.CargaOrigen
            horCargaOrigen.Value = objSeguimiento.CargaOrigen
            fecTerminoCargaOrigen.Value = objSeguimiento.TerminoCargaOrigen
            horTerminoCargaOrigen.Value = objSeguimiento.TerminoCargaOrigen
            fecSalidaOrigen.Value = objSeguimiento.SalidaOrigen
            horSalidaOrigen.Value = objSeguimiento.SalidaOrigen
            fecLlegadaDestino.Value = objSeguimiento.LlegadaDestino
            horLlegadaDestino.Value = objSeguimiento.LlegadaDestino
            fecInicioDescargaDestino.Value = objSeguimiento.DescargaDestino
            horInicioDescargaDestino.Value = objSeguimiento.DescargaDestino
            fecTerminoDescargaDestino.Value = objSeguimiento.TerminoDescargaDestino
            horTerminoDescargaDestino.Value = objSeguimiento.TerminoDescargaDestino
            fecSalidaDestino.Value = objSeguimiento.SalidaDestino
            horSalidaDestino.Value = objSeguimiento.SalidaDestino
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub LlenaCombos()
        ComboNormal(cboLugar, LugaresPublic, 0)
        'llenamos combo de estados de alarmas
        oeConcepto.Activo = True
        oeConcepto.Prefijo = "8"
        ListaConcepto = loConcepto.Listar(oeConcepto)
        cboEstado.DataSource = ListaConcepto
        cboEstado.DisplayMember = "Nombre"
        cboEstado.ValueMember = "Valor1"
        cboEstado.SelectedIndex = 0
        'llenamos combo de estados de alarmas de busqueda
        oeConcepto.Valor1 = ""
        oeConcepto.Nombre = "TODOS"
        ListaConcepto = New List(Of e_Concepto)
        ListaConcepto.Add(oeConcepto)
        oeConcepto = New e_Concepto
        oeConcepto.Activo = True
        oeConcepto.Prefijo = "8"
        ListaConcepto.AddRange(loConcepto.Listar(oeConcepto))
        cboEstadoBusqueda.DataSource = ListaConcepto
        cboEstadoBusqueda.DisplayMember = "Nombre"
        cboEstadoBusqueda.ValueMember = "Valor1"
        cboEstadoBusqueda.SelectedIndex = 0


        'definir tiempo maximo de viaje
        oeConcepto = New e_Concepto
        oeConcepto.Activo = True
        oeConcepto.Prefijo = "9"
        ListaConcepto = loConcepto.Listar(oeConcepto)
        TiempoMaximoViaje = Long.Parse(ListaConcepto(0).Valor1.Trim)

        Dim oeCombo As e_Combo = New e_Combo
        Dim olCombo As l_Combo = New l_Combo

        oeCombo = New e_Combo
        olCombo = New l_Combo
        Dim ListCombo As List(Of e_Combo) = New List(Of e_Combo)
        oeCombo.Nombre = "EMPRESAINDICADOR"
        oeCombo.Descripcion = "GPS"
        ListCombo.AddRange(olCombo.Listar(oeCombo))
        ComboNormal(cboOperador, ListCombo, 0)

        OperacionesPublic = New List(Of e_Combo)
        oeCombo = New e_Combo
        oeCombo.Id = ""
        oeCombo.Nombre = ""
        OperacionesPublic.Add(oeCombo)
        oeCombo = New e_Combo
        oeCombo.Nombre = "VENTAS"
        OperacionesPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)
        LlenarComboMaestro(cboActividadNegocio, OperacionesPublic, 0)
        LlenarComboMaestro(cboActividadNegocio, OperacionesPublic, 0)
        ''''''''''''''
        Dim Clientes As New List(Of e_Combo)
        oeCombo = New e_Combo
        oeCombo.Id = ""
        oeCombo.Nombre = "TODOS"
        Clientes.Add(oeCombo)
        oeCombo = New e_Combo
        oeCombo.Nombre = "Clientes"
        Clientes.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)
        ComboNormal(cboClientes, Clientes, 0)
        ''''''''''''''
        ColorATiempo.Color = Color.GreenYellow
        ColorRetrasado.Color = Color.LightBlue
        ''''''''''''''

    End Sub

    Private Function GuardarSeguimiento() As Boolean
        Try
            Dim textoValidar As String = Validar()
            If textoValidar = "" Then
                If Operacion = "Nuevo" Then
                    oeSeguimientoMonitoreo.TipoOperacion = "I"
                    oeSeguimientoMonitoreo.Id = ""
                    oeSeguimientoMonitoreo.Codigo = ""
                    oeSeguimientoMonitoreo.IdViaje = txtIdViaje.Text.Trim
                    'oeSeguimientoMonitoreo.IdOperador = cboOperador.Value.ToString.Trim
                    oeSeguimientoMonitoreo.IdOperador = IIf(cboOperador.Value = Nothing, "", cboOperador.Value)
                    oeSeguimientoMonitoreo.IdUbicacion = cboLugar.Value.ToString.Trim
                    oeSeguimientoMonitoreo.ReferenciaLugar = txtReferencia.Text.Trim
                    oeSeguimientoMonitoreo.Fecha = Date.Parse(Me.fecSeguimiento.Value.ToShortDateString & " " & Me.horSeguimiento.Value.ToShortTimeString)
                    oeSeguimientoMonitoreo.FechaAproxLlegada = Date.Parse(Me.fecAproxLlegada.Value.ToShortDateString & " " & Me.horAproxLlegada.Value.ToShortTimeString)
                    oeSeguimientoMonitoreo.FechaEntrega = Date.Parse(Me.fecEntrega.Value.ToShortDateString & " " & Me.horEntrega.Value.ToShortTimeString)
                    oeSeguimientoMonitoreo.Estado = cboEstado.Value.ToString.Trim
                    oeSeguimientoMonitoreo.Glosa = txtGlosa.Text.Trim
                    oeSeguimientoMonitoreo.UsuarioCreacion = gUsuarioSGI.Id
                ElseIf Operacion = "Editar" Then
                    oeSeguimientoMonitoreo.TipoOperacion = "I"
                    'oeSeguimientoMonitoreo.IdOperador = cboOperador.Value.ToString.Trim
                    oeSeguimientoMonitoreo.IdOperador = IIf(cboOperador.Value = Nothing, "", cboOperador.Value)
                    oeSeguimientoMonitoreo.IdUbicacion = cboLugar.Value.ToString.Trim
                    oeSeguimientoMonitoreo.ReferenciaLugar = txtReferencia.Text.Trim
                    oeSeguimientoMonitoreo.Fecha = Date.Parse(Me.fecSeguimiento.Value.ToShortDateString & " " & Me.horSeguimiento.Value.ToShortTimeString)
                    oeSeguimientoMonitoreo.FechaAproxLlegada = Date.Parse(Me.fecAproxLlegada.Value.ToShortDateString & " " & Me.horAproxLlegada.Value.ToShortTimeString)
                    oeSeguimientoMonitoreo.FechaEntrega = Date.Parse(Me.fecEntrega.Value.ToShortDateString & " " & Me.horEntrega.Value.ToShortTimeString)
                    oeSeguimientoMonitoreo.Estado = cboEstado.Value.ToString.Trim
                    oeSeguimientoMonitoreo.Glosa = txtGlosa.Text.Trim
                    oeSeguimientoMonitoreo.UsuarioCreacion = gUsuarioSGI.Id
                End If
                oeSeguimientoMonitoreo.PrefijoID = gs_PrefijoIdSucursal '@0001
                If olSeguimientoMonitoreo.Guardar(oeSeguimientoMonitoreo) Then
                    mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                    MostrarTabs(0, tcPrincipal)
                    Consultar(True)
                    griLista.Focus()
                    Return True
                Else
                    mensajeEmergente.Problema("Ocurrio un error al registrar la información", True)
                End If
            Else
                mensajeEmergente.Problema(textoValidar, True)
                Return False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            listaSeguimientoMonitoreo = New List(Of e_SeguimientoMonitoreo)
            oeSeguimientoMonitoreo = New e_SeguimientoMonitoreo
            oeSeguimientoMonitoreo.Estado = cboEstadoBusqueda.Value
            oeSeguimientoMonitoreo.FechaDesde = fecDesde.DateTime.ToString("dd/MM/yyyy")
            oeSeguimientoMonitoreo.FechaHasta = fecHasta.DateTime.ToString("dd/MM/yyyy")
            If tabListado.Tabs(0).Selected = True Then ' tab Listado General
                oeSeguimientoMonitoreo.TipoOperacion = "L"
                listaSeguimientoMonitoreo = olSeguimientoMonitoreo.Listar(oeSeguimientoMonitoreo)
                If cboClientes.Value = "" Then
                    Dim lista = From l In listaSeguimientoMonitoreo Select l.Id, l.Codigo, l.IdViaje _
                    , l.Fecha, l.FechaAproxLlegada, l.FechaEntrega, l.IdUbicacion, l.Ubicacion _
                    , l.ReferenciaLugar, l.IdOperador, l.Operador, l.Glosa, l.Estado, l.NombreEstado _
                    , l.FechaCreacion, l.FechaModifica, l.UsuarioCreacion, l.UsuarioModifica _
                    , CodigoViaje = l.oeViaje.Codigo, FechaViaje = l.oeViaje.Fecha, l.oeViaje.IdOrigen _
                    , l.oeViaje.Origen, l.oeViaje.IdDestino, l.oeViaje.Destino, l.oeViaje.IdPiloto _
                    , l.oeViaje.Piloto, l.oeViaje.IdCopiloto, l.oeViaje.Copiloto, l.oeViaje.CargaMaterial _
                    , l.oeViaje.PesoToneladas, l.oeViaje.IdTracto, l.oeViaje.Tracto, l.oeViaje.IdEscala _
                    , l.oeViaje.Escala, l.oeViaje.Cliente, l.oeViaje.Carreta, l.oeViaje.TipoVehiculo _
                    , l.oeSeguimiento.SalidaOrigen, l.Seleccion
                    griLista.DataSource = lista.ToList
                Else
                    Dim lista = From l In listaSeguimientoMonitoreo Where l.oeViaje.Cliente.Trim = cboClientes.Text.Trim _
                     Select l.Id, l.Codigo, l.IdViaje _
                    , l.Fecha, l.FechaAproxLlegada, l.FechaEntrega, l.IdUbicacion, l.Ubicacion _
                    , l.ReferenciaLugar, l.IdOperador, l.Operador, l.Glosa, l.Estado, l.NombreEstado _
                    , l.FechaCreacion, l.FechaModifica, l.UsuarioCreacion, l.UsuarioModifica _
                    , CodigoViaje = l.oeViaje.Codigo, FechaViaje = l.oeViaje.Fecha, l.oeViaje.IdOrigen _
                    , l.oeViaje.Origen, l.oeViaje.IdDestino, l.oeViaje.Destino, l.oeViaje.IdPiloto _
                    , l.oeViaje.Piloto, l.oeViaje.IdCopiloto, l.oeViaje.Copiloto, l.oeViaje.CargaMaterial _
                    , l.oeViaje.PesoToneladas, l.oeViaje.IdTracto, l.oeViaje.Tracto, l.oeViaje.IdEscala _
                    , l.oeViaje.Escala, l.oeViaje.Cliente, l.oeViaje.Carreta, l.oeViaje.TipoVehiculo _
                    , l.oeSeguimiento.SalidaOrigen, l.Seleccion
                    griLista.DataSource = lista.ToList
                End If
                For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griLista.Rows
                    Select Case fila.Cells("Estado").Value
                        Case "1"
                            fila.CellAppearance.BackColor = Me.ColorATiempo.Color
                        Case "2"
                            fila.CellAppearance.BackColor = Me.ColorRetrasado.Color
                    End Select
                Next
                griLista.DataBind()
            End If
            If tabListado.Tabs(1).Selected = True Then ' tab Listado Envio Email
                oeSeguimientoMonitoreo.TipoOperacion = "1"
                listaSeguimientoMonitoreo = olSeguimientoMonitoreo.Listar(oeSeguimientoMonitoreo)
                If cboClientes.Value = "" Then
                    Dim lista = From l In listaSeguimientoMonitoreo Order By l.Fecha Descending _
                     Select l.Id, l.Codigo, l.IdViaje _
                    , l.Fecha, l.FechaAproxLlegada, l.FechaEntrega, l.IdUbicacion, l.Ubicacion _
                    , l.ReferenciaLugar, l.IdOperador, l.Operador, l.Glosa, l.Estado, l.NombreEstado _
                    , l.FechaCreacion, l.FechaModifica, l.UsuarioCreacion, l.UsuarioModifica _
                    , CodigoViaje = l.oeViaje.Codigo, FechaViaje = l.oeViaje.Fecha, l.oeViaje.IdOrigen _
                    , l.oeViaje.Origen, l.oeViaje.IdDestino, l.oeViaje.Destino, l.oeViaje.IdPiloto _
                    , l.oeViaje.Piloto, l.oeViaje.IdCopiloto, l.oeViaje.Copiloto, l.oeViaje.CargaMaterial _
                    , l.oeViaje.PesoToneladas, l.oeViaje.IdTracto, l.oeViaje.Tracto, l.oeViaje.IdEscala _
                    , l.oeViaje.Escala, l.oeViaje.Cliente, l.oeViaje.Carreta, l.oeViaje.TipoVehiculo _
                    , l.oeSeguimiento.SalidaOrigen, l.Seleccion
                    griListaEnviarEmail.DataSource = lista.ToList
                Else
                    Dim lista = From l In listaSeguimientoMonitoreo Where l.oeViaje.Cliente.Trim = cboClientes.Text.Trim _
                                Order By l.Fecha Descending _
                     Select l.Id, l.Codigo, l.IdViaje _
                    , l.Fecha, l.FechaAproxLlegada, l.FechaEntrega, l.IdUbicacion, l.Ubicacion _
                    , l.ReferenciaLugar, l.IdOperador, l.Operador, l.Glosa, l.Estado, l.NombreEstado _
                    , l.FechaCreacion, l.FechaModifica, l.UsuarioCreacion, l.UsuarioModifica _
                    , CodigoViaje = l.oeViaje.Codigo, FechaViaje = l.oeViaje.Fecha, l.oeViaje.IdOrigen _
                    , l.oeViaje.Origen, l.oeViaje.IdDestino, l.oeViaje.Destino, l.oeViaje.IdPiloto _
                    , l.oeViaje.Piloto, l.oeViaje.IdCopiloto, l.oeViaje.Copiloto, l.oeViaje.CargaMaterial _
                    , l.oeViaje.PesoToneladas, l.oeViaje.IdTracto, l.oeViaje.Tracto, l.oeViaje.IdEscala _
                    , l.oeViaje.Escala, l.oeViaje.Cliente, l.oeViaje.Carreta, l.oeViaje.TipoVehiculo _
                    , l.oeSeguimiento.SalidaOrigen, l.Seleccion
                    griListaEnviarEmail.DataSource = lista.ToList
                End If
                For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griListaEnviarEmail.Rows
                    Select Case fila.Cells("Estado").Value
                        Case "1"
                            fila.CellAppearance.BackColor = Me.ColorATiempo.Color
                        Case "2"
                            fila.CellAppearance.BackColor = Me.ColorRetrasado.Color
                    End Select
                Next
                griListaEnviarEmail.DataBind()
            End If

        Catch ex As Exception
            Throw ex
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub CargarEditar()
        Try
            Dim Id As String = griLista.ActiveRow.Cells("Id").Value.ToString.Trim
            Dim IdViaje As String = griLista.ActiveRow.Cells("IdViaje").Value.ToString.Trim
            CargarDetalle(Id, IdViaje)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub CargarDetalle(ByVal Id As String, ByVal IdViaje As String)
        Try
            oeSeguimientoMonitoreo = New e_SeguimientoMonitoreo
            oeSeguimientoMonitoreo.TipoOperacion = "O"
            oeSeguimientoMonitoreo.Id = Id
            oeSeguimientoMonitoreo = olSeguimientoMonitoreo.Obtener(oeSeguimientoMonitoreo)

            LlenarDatosViaje(oeSeguimientoMonitoreo.oeViaje)
            LlenarDatosSeguimiento(oeSeguimientoMonitoreo.oeSeguimiento)

            oeSeguimientoMonitoreo.TipoOperacion = "I"
            cboOperador.Value = oeSeguimientoMonitoreo.IdOperador
            cboLugar.Value = oeSeguimientoMonitoreo.IdUbicacion
            txtReferencia.Text = oeSeguimientoMonitoreo.ReferenciaLugar
            fecSeguimiento.Value = oeSeguimientoMonitoreo.Fecha
            horSeguimiento.Value = oeSeguimientoMonitoreo.Fecha
            fecAproxLlegada.Value = oeSeguimientoMonitoreo.FechaAproxLlegada
            horAproxLlegada.Value = oeSeguimientoMonitoreo.FechaAproxLlegada
            fecEntrega.Value = oeSeguimientoMonitoreo.FechaEntrega
            horEntrega.Value = oeSeguimientoMonitoreo.FechaEntrega
            cboEstado.Value = oeSeguimientoMonitoreo.Estado
            txtGlosa.Text = oeSeguimientoMonitoreo.Glosa

            CargarGrillasDetalle(IdViaje, oeSeguimientoMonitoreo.oeViaje.IdPiloto, oeSeguimientoMonitoreo.oeViaje.IdTracto)

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub CargarGrillasDetalle(ByVal IdViajeAux As String, ByVal IdPilotoAux As String, ByVal IdTractoAux As String)
        Try
            listaSeguimientoMonitoreo = New List(Of e_SeguimientoMonitoreo)
            Dim oeSeguimientoMonitoreoAux As New e_SeguimientoMonitoreo
            oeSeguimientoMonitoreoAux.TipoOperacion = "L"
            oeSeguimientoMonitoreoAux.Activo = True
            listaSeguimientoMonitoreo = olSeguimientoMonitoreo.Listar(oeSeguimientoMonitoreoAux)

            Dim listaViaje = From lvi In listaSeguimientoMonitoreo Where lvi.IdViaje.Trim = IdViajeAux.Trim _
                     Order By lvi.FechaCreacion Ascending _
                     Select Id = lvi.Id, Codigo = lvi.Codigo, IdViaje = lvi.IdViaje, Fecha = lvi.Fecha, FechaAproxLlegada = lvi.FechaAproxLlegada, FechaEntrega = lvi.FechaEntrega _
                     , IdUbicacion = lvi.IdUbicacion, Ubicacion = lvi.Ubicacion, ReferenciaLugar = lvi.ReferenciaLugar, IdOperador = lvi.IdOperador, Operador = lvi.Operador, Glosa = lvi.Glosa _
                     , Estado = lvi.Estado, NombreEstado = lvi.NombreEstado, FechaCreacion = lvi.FechaCreacion, FechaModifica = lvi.FechaModifica, UsuarioCreacion = lvi.UsuarioCreacion _
                     , lvi.UsuarioModifica, CodigoViaje = lvi.oeViaje.Codigo, FechaViaje = lvi.oeViaje.Fecha, lvi.oeViaje.IdOrigen _
                    , Origen = lvi.oeViaje.Origen, IdDestino = lvi.oeViaje.IdDestino, Destino = lvi.oeViaje.Destino, IdPiloto = lvi.oeViaje.IdPiloto _
                    , Piloto = lvi.oeViaje.Piloto, IdCopiloto = lvi.oeViaje.IdCopiloto, Copiloto = lvi.oeViaje.Copiloto, CargaMaterial = lvi.oeViaje.CargaMaterial _
                    , PesoToneladas = lvi.oeViaje.PesoToneladas, IdTracto = lvi.oeViaje.IdTracto, Tracto = lvi.oeViaje.Tracto, IdEscala = lvi.oeViaje.IdEscala _
                    , Escala = lvi.oeViaje.Escala, Cliente = lvi.oeViaje.Cliente, Carreta = lvi.oeViaje.Carreta, TipoVehiculo = lvi.oeViaje.TipoVehiculo _
                    , SalidaOrigen = lvi.oeSeguimiento.SalidaOrigen
            Dim listaConductor = (From lco In listaSeguimientoMonitoreo Where lco.oeViaje.IdPiloto.Trim = IdPilotoAux.Trim _
                     Order By lco.FechaCreacion Ascending _
                     Select lco.Id, lco.Codigo, lco.IdViaje, lco.Fecha, lco.FechaAproxLlegada, lco.FechaEntrega _
                     , lco.IdUbicacion, lco.Ubicacion, lco.ReferenciaLugar, lco.IdOperador, lco.Operador, lco.Glosa _
                     , lco.Estado, lco.NombreEstado, lco.FechaCreacion, lco.FechaModifica, lco.UsuarioCreacion _
                     , lco.UsuarioModifica, CodigoViaje = lco.oeViaje.Codigo, FechaViaje = lco.oeViaje.Fecha, lco.oeViaje.IdOrigen _
                    , lco.oeViaje.Origen, lco.oeViaje.IdDestino, lco.oeViaje.Destino, lco.oeViaje.IdPiloto _
                    , lco.oeViaje.Piloto, lco.oeViaje.IdCopiloto, lco.oeViaje.Copiloto, lco.oeViaje.CargaMaterial _
                    , lco.oeViaje.PesoToneladas, lco.oeViaje.IdTracto, lco.oeViaje.Tracto, lco.oeViaje.IdEscala _
                    , lco.oeViaje.Escala, lco.oeViaje.Cliente, lco.oeViaje.Carreta, lco.oeViaje.TipoVehiculo _
                    , lco.oeSeguimiento.SalidaOrigen).Take(10)
            Dim listaVehiculo = (From lve In listaSeguimientoMonitoreo Where lve.oeViaje.IdTracto.Trim = IdTractoAux.Trim _
                     Order By lve.FechaCreacion Ascending _
                     Select lve.Id, lve.Codigo, lve.IdViaje, lve.Fecha, lve.FechaAproxLlegada, lve.FechaEntrega _
                     , lve.IdUbicacion, lve.Ubicacion, lve.ReferenciaLugar, lve.IdOperador, lve.Operador, lve.Glosa _
                     , lve.Estado, lve.NombreEstado, lve.FechaCreacion, lve.FechaModifica, lve.UsuarioCreacion _
                     , lve.UsuarioModifica, CodigoViaje = lve.oeViaje.Codigo, FechaViaje = lve.oeViaje.Fecha, lve.oeViaje.IdOrigen _
                    , lve.oeViaje.Origen, lve.oeViaje.IdDestino, lve.oeViaje.Destino, lve.oeViaje.IdPiloto _
                    , lve.oeViaje.Piloto, lve.oeViaje.IdCopiloto, lve.oeViaje.Copiloto, lve.oeViaje.CargaMaterial _
                    , lve.oeViaje.PesoToneladas, lve.oeViaje.IdTracto, lve.oeViaje.Tracto, lve.oeViaje.IdEscala _
                    , lve.oeViaje.Escala, lve.oeViaje.Cliente, lve.oeViaje.Carreta, lve.oeViaje.TipoVehiculo _
                    , lve.oeSeguimiento.SalidaOrigen).Take(10)

            griListaSeguimientoViaje.DataSource = listaViaje.ToList
            griListaSeguimientoViaje.DataBind()
            griListaSeguimientoConductor.DataSource = listaConductor.ToList
            griListaSeguimientoConductor.DataBind()
            griListaSeguimientoVehiculo.DataSource = listaVehiculo.ToList
            griListaSeguimientoVehiculo.DataBind()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Function getBodyEmail() As String
        Try

            Dim estiloTh As String = "<th style='white-space: nowrap' text-align: left;vertical-align: top;border: 1px solid #000;border-collapse: collapse;padding: 0.3em;caption-side: bottom;>"
            Dim estiloTd As String = "<td style='white-space: nowrap' align='left' valign='top'>"
            Dim estiloLetra As String = "<tr valign='top'><td style='border-right-color:#000099; border-right-style:solid; border-right-width:1.5px;' align='right'><font size='1.8' style='font-style: oblique; font-family:arial; color:#000000'>"
            Dim estiloLetraB As String = "<tr><td style='border-right-color:#000099; border-right-style:solid; border-right-width:1px;" +
                " border-top-color:#000099; border-top-style:solid; border-top-width:1px;' align='right'><font size='1.8' style='font-style: oblique; font-family:arial; color:#000000'>"
            Dim estiloLetraDetalle As String = "<th style='white-space: nowrap' bgcolor='#045FB4'><FONT FACE='raro, arial' SIZE=1.3 COLOR='#ffffff'>"
            Dim estiloLetraSC As String = "<td align='left'><FONT FACE='raro, arial' SIZE=1.5>"
            Dim estiloLetraSCB As String = "<td align='left' size='1.8' style='border-bottom-color:#000099; border-bottom-style:solid; border-bottom-width:1.5px;'><font size='2' style='font-style: oblique; font-family:arial; color:#045FB4'>"
            Dim estiloLetraSCBD As String = "<td align='right' size='1.8' style='border-bottom-color:#000099; border-bottom-style:solid; border-bottom-width:1.5px;'><font size='2' style='font-style: oblique; font-family:arial; color:#045FB4'>"
            Dim estiloLetraDetalleSC As String = "<td style='white-space: nowrap'><FONT FACE='raro, arial' SIZE=1>"
            Dim cadena As String = ""

            cadena += "<table cellpadding='0' cellspacing='0'>" & estiloLetraSCBD & "DATOS DE SEGUIMIENTO MONITOREO </font></td></tr>"
            cadena += estiloLetra + "CODIGO:</font></td>" & estiloLetraSC & griLista.ActiveRow.Cells("Codigo").Value.ToString.Trim & "</font></td></tr>"
            cadena += estiloLetra + "FECHA:</font></td>" & estiloLetraSC & griLista.ActiveRow.Cells("Fecha").Value.ToString.Trim & "</font></td></tr>"
            cadena += estiloLetra + "FECHA APROXIMADA LLEGADA:</font></td>" & estiloLetraSC & griLista.ActiveRow.Cells("FechaAproxLlegada").Value.ToString.Trim & "</font></td></tr>"
            cadena += estiloLetra + "FECHA ENTREGA:</font></td>" & estiloLetraSC & griLista.ActiveRow.Cells("FechaEntrega").Value.ToString.Trim & "</font></td></tr>"
            cadena += estiloLetra + "UBICACIÓN:</font></td>" & estiloLetraSC & griLista.ActiveRow.Cells("Ubicacion").Value.ToString.Trim & "</font></td></tr>"
            cadena += estiloLetra + "REFERENCIA:</font></td>" & estiloLetraSC & griLista.ActiveRow.Cells("ReferenciaLugar").Value.ToString.Trim & "</font></td></tr>"
            cadena += estiloLetra + "ESTADO:</font></td>" & estiloLetraSC & griLista.ActiveRow.Cells("NombreEstado").Value.ToString.Trim & "</font></td></tr>"
            cadena += estiloLetra + "GLOSA:</font></td>" & estiloLetraSC & griLista.ActiveRow.Cells("Glosa").Value.ToString.Trim & "</font></td></tr>"
            cadena += "</table>"

            cadena += "<br><br>"

            cadena += "<table cellpadding='0' cellspacing='0'>" & estiloLetraSCBD & "DATOS DE VIAJE </font></td></tr>"
            cadena += estiloLetra + "CODIGO:</font></td>" & estiloLetraSC & griLista.ActiveRow.Cells("CodigoViaje").Value.ToString.Trim & "</font></td></tr>"
            cadena += estiloLetra + "FECHA:</font></td>" & estiloLetraSC & griLista.ActiveRow.Cells("FechaViaje").Value.ToString.Trim & "</font></td></tr>"
            cadena += estiloLetra + "CLIENTE:</font></td>" & estiloLetraSC & griLista.ActiveRow.Cells("Cliente").Value.ToString.Trim & "</font></td></tr>"
            cadena += estiloLetra + "ORIGEN:</font></td>" & estiloLetraSC & griLista.ActiveRow.Cells("Origen").Value.ToString.Trim & "</font></td></tr>"
            cadena += estiloLetra + "DESTINO:</font></td>" & estiloLetraSC & griLista.ActiveRow.Cells("Destino").Value.ToString.Trim & "</font></td></tr>"
            cadena += estiloLetra + "ESCALA:</font></td>" & estiloLetraSC & griLista.ActiveRow.Cells("Escala").Value.ToString.Trim & "</font></td></tr>"
            cadena += estiloLetra + "PILOTO:</font></td>" & estiloLetraSC & griLista.ActiveRow.Cells("Piloto").Value.ToString.Trim & "</font></td></tr>"
            cadena += estiloLetra + "COPILOTO:</font></td>" & estiloLetraSC & griLista.ActiveRow.Cells("Copiloto").Value.ToString.Trim & "</font></td></tr>"
            cadena += estiloLetra + "TRATO:</font></td>" & estiloLetraSC & griLista.ActiveRow.Cells("Tracto").Value.ToString.Trim & "</font></td></tr>"
            cadena += estiloLetra + "TIPO VEHÍCULO:</font></td>" & estiloLetraSC & griLista.ActiveRow.Cells("TipoVehiculo").Value.ToString.Trim & "</font></td></tr>"
            cadena += estiloLetra + "CARRETA:</font></td>" & estiloLetraSC & griLista.ActiveRow.Cells("Carreta").Value.ToString.Trim & "</font></td></tr>"
            cadena += estiloLetra + "CARGA MATERIAL:</font></td>" & estiloLetraSC & griLista.ActiveRow.Cells("CargaMaterial").Value.ToString.Trim & "</font></td></tr>"
            cadena += estiloLetra + "PESO TONELADAS:</font></td>" & estiloLetraSC & griLista.ActiveRow.Cells("PesoToneladas").Value.ToString.Trim & "</font></td></tr>"
            cadena += "</table>"
            Return cadena
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub ObtenerRuta()
        Try
            If cboLugar.Value <> "0" And cboLugar.Value <> "" And txtViajeDestino.Text.Trim <> "" Then
                oeRuta = New e_Ruta
                oeRuta.IdOrigen = cboLugar.Value
                oeRuta.IdDestino = oeViaje.IdDestino
                oeRuta = olRuta.Obtener(oeRuta)
                If oeRuta.Id <> "" Then
                    CalcularFechaLlegada()
                Else
                    mensajeEmergente.Problema("No existe Ruta Con ubicacion y destino seleccionada para calcular fecha aproximada de llegada, ingresar fecha aproximada manualmente.", True)
                End If

            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub CalcularFechaLlegada()
        Try
            If fecSeguimiento.Value <> Nothing Then
                If oeViaje.IdCopiloto <> "0" And oeViaje.IdCopiloto <> "" Then
                    Dim fechaAproxLLegada As DateTime = DateAdd(DateInterval.Hour, oeRuta.HorasAcompañado, Me.fecSeguimiento.Value.ToShortDateString & " " & Me.horSeguimiento.Value.ToShortTimeString)
                    fecAproxLlegada.Value = fechaAproxLLegada
                    horAproxLlegada.Value = fechaAproxLLegada
                Else
                    Dim fechaAproxLLegada As DateTime = DateAdd(DateInterval.Hour, oeRuta.HorasSolo, Me.fecSeguimiento.Value.ToShortDateString & " " & Me.horSeguimiento.Value.ToShortTimeString)
                    horAproxLlegada.Value = fechaAproxLLegada
                    fecAproxLlegada.Value = fechaAproxLLegada
                End If
                CalcularEstado()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub CalcularEstado()
        Try
            If Date.Parse(Me.fecAproxLlegada.Value.ToShortDateString & " " & Me.horAproxLlegada.Value.ToShortTimeString) _
                    > Date.Parse(Me.fecEntrega.Value.ToShortDateString & " " & Me.horEntrega.Value.ToShortTimeString) Then
                cboEstado.Value = "2"
            Else
                cboEstado.Value = "1"
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub SeguimientoRapido()
        Try
            If IdViaje <> "" Then
                Operacion = "Nuevo"
                ugb_Espera.Visible = True
                Application.DoEvents()
                Cursor.Current = Cursors.WaitCursor
                Cursor.Show()

                Inicializar()
                btnBuscar.Enabled = False
                MostrarTabs(1, tcPrincipal, 1)
                MyBase.Nuevo()

                oeViaje = New e_Viaje
                oeViaje.Id = IdViaje
                oeViaje.TipoOperacion = "G"
                oeViaje = olOperacion.ObtenerViaje(oeViaje)
                LlenarDatosViaje(oeViaje)

                oeSeguimiento = New e_Seguimiento
                oeSeguimiento.IdViaje = oeViaje.Id.Trim
                oeSeguimiento.TipoOperacion = ""
                Dim listaSeguimiento As List(Of e_Seguimiento)
                listaSeguimiento = olSeguimiento.Listar(oeSeguimiento)
                oeSeguimiento = listaSeguimiento(0)
                LlenarDatosSeguimiento(oeSeguimiento)

                CargarGrillasDetalle(oeViaje.Id, oeViaje.IdPiloto, oeViaje.IdTracto)
                CalcularFechaLlegada()

                exgruViaje.Expanded = False

                Me.ClientSize = New System.Drawing.Size(780, 350)
            End If


        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Function Validar() As String
        Try
            If txtIdViaje.Text.Trim = "" Then Return "Debe Seleccionar Viaje."

            Dim TiempoDiferencia As Long
            Dim DiasLimiteViaje As Integer = TiempoMaximoViaje / 1440
            Dim fechaSalidaOrigen As Date = Date.Parse(Me.fecSalidaOrigen.Value.ToShortDateString & " " & Me.horSalidaOrigen.Value.ToShortTimeString)
            Dim fechaSeguimiento As Date = Date.Parse(Me.fecSeguimiento.Value.ToShortDateString & " " & Me.horSeguimiento.Value.ToShortTimeString)
            Dim fechaAproxLlegada As Date = Date.Parse(Me.fecAproxLlegada.Value.ToShortDateString & " " & Me.horAproxLlegada.Value.ToShortTimeString)
            Dim fechaEntrega As Date = Date.Parse(Me.fecEntrega.Value.ToShortDateString & " " & Me.horEntrega.Value.ToShortTimeString)

            TiempoDiferencia = DateDiff(DateInterval.Minute, fechaSalidaOrigen, fechaSeguimiento)
            If TiempoDiferencia > TiempoMaximoViaje Or TiempoDiferencia < 0 Then
                Me.fecSeguimiento.Focus()
                Return "Fecha Seguimiento debe estar entre los primeros " & DiasLimiteViaje & " días del viaje."
            End If
            TiempoDiferencia = DateDiff(DateInterval.Minute, fechaSalidaOrigen, fechaAproxLlegada)
            If TiempoDiferencia > TiempoMaximoViaje Or TiempoDiferencia < 0 Then
                Me.fecSeguimiento.Focus()
                Return "Fecha Aproximada de Llegada debe estar entre los primeros " & DiasLimiteViaje & " días del viaje."
            End If
            TiempoDiferencia = DateDiff(DateInterval.Minute, fechaSalidaOrigen, fechaEntrega)
            If TiempoDiferencia > TiempoMaximoViaje Or TiempoDiferencia < 0 Then
                Me.fecSeguimiento.Focus()
                Return "Fecha Entrega debe estar entre los primeros " & DiasLimiteViaje & " días del viaje."
            End If

            Return ""
        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

    Private Sub btnGuardarRapido_Click(sender As Object, e As EventArgs) Handles btnGuardarRapido.Click
        Try
            Dim textoValidar As String = Validar()
            If textoValidar = "" Then
                If Operacion = "Nuevo" Then
                    oeSeguimientoMonitoreo.TipoOperacion = "I"
                    oeSeguimientoMonitoreo.Id = ""
                    oeSeguimientoMonitoreo.Codigo = ""
                    oeSeguimientoMonitoreo.IdViaje = txtIdViaje.Text.Trim
                    'oeSeguimientoMonitoreo.IdOperador = cboOperador.Value.ToString.Trim
                    oeSeguimientoMonitoreo.IdOperador = IIf(cboOperador.Value = Nothing, "", cboOperador.Value)
                    oeSeguimientoMonitoreo.IdUbicacion = cboLugar.Value.ToString.Trim
                    oeSeguimientoMonitoreo.ReferenciaLugar = txtReferencia.Text.Trim
                    oeSeguimientoMonitoreo.Fecha = Date.Parse(Me.fecSeguimiento.Value.ToShortDateString & " " & Me.horSeguimiento.Value.ToShortTimeString)
                    oeSeguimientoMonitoreo.FechaAproxLlegada = Date.Parse(Me.fecAproxLlegada.Value.ToShortDateString & " " & Me.horAproxLlegada.Value.ToShortTimeString)
                    oeSeguimientoMonitoreo.FechaEntrega = Date.Parse(Me.fecEntrega.Value.ToShortDateString & " " & Me.horEntrega.Value.ToShortTimeString)
                    oeSeguimientoMonitoreo.Estado = cboEstado.Value.ToString.Trim
                    oeSeguimientoMonitoreo.Glosa = txtGlosa.Text.Trim
                    oeSeguimientoMonitoreo.UsuarioCreacion = gUsuarioSGI.Id
                ElseIf Operacion = "Editar" Then
                    oeSeguimientoMonitoreo.TipoOperacion = "I"
                    'oeSeguimientoMonitoreo.IdOperador = cboOperador.Value.ToString.Trim
                    oeSeguimientoMonitoreo.IdOperador = IIf(cboOperador.Value = Nothing, "", cboOperador.Value)
                    oeSeguimientoMonitoreo.IdUbicacion = cboLugar.Value.ToString.Trim
                    oeSeguimientoMonitoreo.ReferenciaLugar = txtReferencia.Text.Trim
                    oeSeguimientoMonitoreo.Fecha = Date.Parse(Me.fecSeguimiento.Value.ToShortDateString & " " & Me.horSeguimiento.Value.ToShortTimeString)
                    oeSeguimientoMonitoreo.FechaAproxLlegada = Date.Parse(Me.fecAproxLlegada.Value.ToShortDateString & " " & Me.horAproxLlegada.Value.ToShortTimeString)
                    oeSeguimientoMonitoreo.FechaEntrega = Date.Parse(Me.fecEntrega.Value.ToShortDateString & " " & Me.horEntrega.Value.ToShortTimeString)
                    oeSeguimientoMonitoreo.Estado = cboEstado.Value.ToString.Trim
                    oeSeguimientoMonitoreo.Glosa = txtGlosa.Text.Trim
                    oeSeguimientoMonitoreo.UsuarioCreacion = gUsuarioSGI.Id
                End If
                oeSeguimientoMonitoreo.PrefijoID = gs_PrefijoIdSucursal '@0001
                If olSeguimientoMonitoreo.Guardar(oeSeguimientoMonitoreo) Then
                    mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                    Me.Close()
                Else
                    mensajeEmergente.Problema("Ocurrio un error al registrar la información", True)
                End If

            Else
                mensajeEmergente.Problema(textoValidar, True)
            End If
            
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cbInd_CheckedChanged(sender As Object, e As EventArgs) Handles cbInd.CheckedChanged
        Try
            If cbInd.Checked Then
                For Each obj In griListaEnviarEmail.Rows.Where(Function(item) item.IsFilteredOut = False)
                    obj.Cells("Select").Value = True
                Next
            Else
                For Each obj In griListaEnviarEmail.Rows.Where(Function(item) item.IsFilteredOut = False)
                    obj.Cells("Select").Value = False
                Next
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnEnviarCorreo_Click(sender As Object, e As EventArgs) Handles btnEnviarCorreo.Click
        Try
            If griListaEnviarEmail.Rows.Count > 0 Then
                Dim formulario As frm_EnvioEmail
                formulario = New frm_EnvioEmail
                formulario.Modulo = "SeguimientoMonitoreo"
                formulario.asunto = "Seguimiento de Viaje"
                formulario.cadenaMensajeHtml = llenarTabla()
                formulario.ShowDialog()
            Else
                mensajeEmergente.Confirmacion("No existen registros en la lista", True)
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Function llenarTabla() As String
        Dim estiloTh As String = "<th style='white-space: nowrap' text-align: left;vertical-align: top;border: 1px solid #000;border-collapse: collapse;padding: 0.3em;caption-side: bottom;>"
        Dim estiloTd As String = "<td style='white-space: nowrap' align='left' valign='top'>"
        Dim estiloLetra As String = "<tr align='left' valign='top'><td bgcolor='#08298A'><FONT FACE='raro, arial' SIZE=2 COLOR='#ffffff'>"
        Dim estiloLetraDetalle As String = "<th style='white-space: nowrap' bgcolor='#08298A'><FONT FACE='raro, arial' SIZE=1.3 COLOR='#ffffff'>"
        Dim estiloLetraSC As String = "<FONT FACE='raro, arial' SIZE=1.5>"
        Dim estiloLetraDetalleSC As String = "<td style='white-space: nowrap'><FONT FACE='raro, arial' SIZE=1>"
        Dim estiloLetraDetalleSCRight As String = "<td align='right' style='white-space: nowrap'><FONT FACE='raro, arial' SIZE=1>"
        Dim estiloLetraDetalleSCCenter As String = "<td align='center' style='white-space: nowrap'><FONT FACE='raro, arial' SIZE=1>"

        Dim cadena As String = ""
        Try
            cadena += "<table border='1' cellpadding='0' cellspacing='0' width='100%' >" ' & vbCrLf
            cadena += "<CAPTION padding: 0.3em;color: #fff;background: #000;><EM>Seguimiento de Viaje</EM></CAPTION>"
            cadena += "<tr style='white-space: nowrap' align='left' valign='top'>"
            cadena += estiloLetraDetalle & "FechaViaje</font></th>" &
                      estiloLetraDetalle & "Estado</font></th>" &
                      estiloLetraDetalle & "Origen</font></th>" &
                      estiloLetraDetalle & "Destino</font></th>" &
                      estiloLetraDetalle & "UbicacionActual</font></th>" &
                      estiloLetraDetalle & "Cliente</font></th>" &
                      estiloLetraDetalle & "Tracto</font></th>" &
                      estiloLetraDetalle & "Carreta</font></th>" &
                      estiloLetraDetalle & "TipoVehiculo</font></th>" &
                      estiloLetraDetalle & "Piloto</font></th>" &
                      estiloLetraDetalle & "Copiloto</font></th>" &
                      estiloLetraDetalle & "CargaMaterial</font></th>" &
                      estiloLetraDetalle & "FechaSalida</font></th>" &
                      estiloLetraDetalle & "FechaSeguimiento</font></th>" &
                      estiloLetraDetalle & "FechaAproximadaLlegada</font></th>" &
                      estiloLetraDetalle & "FechaEntrega</font></th>" &
                      estiloLetraDetalle & "Glosa</font></th>"
            'estiloLetraDetalle & "Seguimiento</font></th>" &
            'estiloLetraDetalle & "Viaje</font></th>" &
            'estiloLetraDetalle & "PesoToneladas</font></th>" &
            cadena += "</tr>"

            For Each fila In griListaEnviarEmail.Rows
                If fila.Cells("Select").Value Then
                    cadena += "<tr style='width: auto;' align='left' valign='top'>"
                    cadena += estiloLetraDetalleSC & fila.Cells("FechaViaje").Value.ToString() & "</font></td>" &
                              estiloLetraDetalleSC & fila.Cells("NombreEstado").Value.ToString() & "</font></td>" &
                              estiloLetraDetalleSC & fila.Cells("Origen").Value.ToString() & "</font></td>" &
                              estiloLetraDetalleSC & fila.Cells("Destino").Value.ToString() & "</font></td>" &
                              estiloLetraDetalleSC & fila.Cells("Ubicacion").Value.ToString() & "</font></td>" &
                              estiloLetraDetalleSC & fila.Cells("Cliente").Value.ToString() & "</font></td>" &
                              estiloLetraDetalleSC & fila.Cells("Tracto").Value.ToString() & "</font></td>" &
                              estiloLetraDetalleSC & fila.Cells("Carreta").Value.ToString() & "</font></td>" &
                              estiloLetraDetalleSC & fila.Cells("TipoVehiculo").Value.ToString() & "</font></td>" &
                              estiloLetraDetalleSC & fila.Cells("Piloto").Value.ToString() & "</font></td>" &
                              estiloLetraDetalleSC & fila.Cells("Copiloto").Value.ToString() & "</font></td>" &
                              estiloLetraDetalleSC & fila.Cells("CargaMaterial").Value.ToString() & "</font></td>" &
                              estiloLetraDetalleSC & fila.Cells("SalidaOrigen").Value.ToString() & "</font></td>" &
                              estiloLetraDetalleSC & fila.Cells("Fecha").Value.ToString() & "</font></td>" &
                              estiloLetraDetalleSC & fila.Cells("FechaAproxLlegada").Value.ToString() & "</font></td>" &
                              estiloLetraDetalleSC & fila.Cells("FechaEntrega").Value.ToString() & "</font></td>" &
                              estiloLetraDetalleSC & fila.Cells("Glosa").Value.ToString() & "</font></td>"
                    'estiloLetraDetalleSCCenter & fila.Cells("Codigo").Value.ToString() & "</font></td>" &
                    '          estiloLetraDetalleSC & fila.Cells("CodigoViaje").Value.ToString() & "</font></td>" &                            
                    '          estiloLetraDetalleSCRight & fila.Cells("PesoToneladas").Value.ToString() & "</font></td>" &
                    cadena += "</tr>"
                End If
            Next
            cadena += "</table>"
        Catch ex As Exception
            Throw ex
        End Try
        Return cadena
    End Function

    Private Sub griListaEnviarEmail_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griListaEnviarEmail.BeforeRowsDeleted
        Try
            e.DisplayPromptMsg = False
            e.Cancel = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub ImportarDatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportarDatosToolStripMenuItem.Click
        Try
            Operacion = "Nuevo"
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            listaSeguimientoMonitoreo.Clear()

            Dim listaViaje = From lvi In listaSeguimientoMonitoreo _
                     Order By lvi.Fecha Ascending _
                     Select Id = lvi.Id, Codigo = lvi.Codigo, IdViaje = lvi.IdViaje, Fecha = lvi.Fecha, FechaAproxLlegada = lvi.FechaAproxLlegada, FechaEntrega = lvi.FechaEntrega _
                     , IdUbicacion = lvi.IdUbicacion, Ubicacion = lvi.Ubicacion, ReferenciaLugar = lvi.ReferenciaLugar, IdOperador = lvi.IdOperador, Operador = lvi.Operador, Glosa = lvi.Glosa _
                     , Estado = lvi.Estado, NombreEstado = lvi.NombreEstado, FechaCreacion = lvi.FechaCreacion, FechaModifica = lvi.FechaModifica, UsuarioCreacion = lvi.UsuarioCreacion _
                     , lvi.UsuarioModifica, CodigoViaje = lvi.oeViaje.Codigo, FechaViaje = lvi.oeViaje.Fecha, lvi.oeViaje.IdOrigen _
                    , Origen = lvi.oeViaje.Origen, IdDestino = lvi.oeViaje.IdDestino, Destino = lvi.oeViaje.Destino, IdPiloto = lvi.oeViaje.IdPiloto _
                    , Piloto = lvi.oeViaje.Piloto, IdCopiloto = lvi.oeViaje.IdCopiloto, Copiloto = lvi.oeViaje.Copiloto, CargaMaterial = lvi.oeViaje.CargaMaterial _
                    , PesoToneladas = lvi.oeViaje.PesoToneladas, IdTracto = lvi.oeViaje.IdTracto, Tracto = lvi.oeViaje.Tracto, IdEscala = lvi.oeViaje.IdEscala _
                    , Escala = lvi.oeViaje.Escala, Cliente = lvi.oeViaje.Cliente, Carreta = lvi.oeViaje.Carreta, TipoVehiculo = lvi.oeViaje.TipoVehiculo _
                    , SalidaOrigen = lvi.oeSeguimiento.SalidaOrigen

            gridImportar.DataSource = listaViaje.ToList
            gridImportar.DataBind()

            MostrarTabs(2, tcPrincipal, 2)
            MyBase.Nuevo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click
        Try
            Dim PathFilePTRA As String = ""
            OpenFileDialog1 = CargaDatosOpenFileDialog()

            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

                PathFilePTRA = OpenFileDialog1.FileName
                Dim objXls As Excel.Application
                Dim objWorkbook As Excel.Workbook
                Dim objWorkSheet As Excel.Worksheet
                Dim ObjExcel() As Object = Nothing
                Dim men As String = ""
                objXls = CreateObject("Excel.Application")
                objWorkbook = objXls.Workbooks.Open(PathFilePTRA)

                objXls.Visible = False
                objWorkSheet = objXls.Worksheets(1)

                listaSeguimientoMonitoreo.Clear()

                Dim FechaActual As Date = ObtenerFechaServidor()
                For ln_Fila As Integer = 1 To 100000
                    If (Not objWorkSheet.Cells(ln_Fila + 1, 1).Value Is Nothing) And _
                        (Not objWorkSheet.Cells(ln_Fila + 1, 2).Value Is Nothing) Then
                        oeSeguimientoMonitoreo = New e_SeguimientoMonitoreo
                        oeViaje = New e_Viaje
                        oeSeguimientoMonitoreo.TipoOperacion = "I"
                        oeSeguimientoMonitoreo.Id = ""
                        oeSeguimientoMonitoreo.Codigo = ""
                        oeSeguimientoMonitoreo.IdViaje = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 2).Value).Trim
                        oeSeguimientoMonitoreo.IdUbicacion = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 4).Value).Trim
                        oeSeguimientoMonitoreo.Ubicacion = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 5).Value).Trim
                        oeSeguimientoMonitoreo.ReferenciaLugar = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 17).Value).Trim
                        oeSeguimientoMonitoreo.Glosa = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 18).Value).Trim
                        oeSeguimientoMonitoreo.IdOperador = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 20).Value).Trim
                        oeSeguimientoMonitoreo.Operador = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 21).Value).Trim
                        Dim fechaAux As String
                        fechaAux = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 3).Value).Trim
                        oeSeguimientoMonitoreo.Fecha = IIf(fechaAux.Trim = "", "01/01/1901", fechaAux.Trim)
                        fechaAux = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 6).Value).Trim
                        oeSeguimientoMonitoreo.FechaAproxLlegada = IIf(fechaAux.Trim = "", "01/01/1901", fechaAux.Trim)
                        fechaAux = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 7).Value).Trim
                        oeSeguimientoMonitoreo.FechaEntrega = IIf(fechaAux.Trim = "", "01/01/1901", fechaAux.Trim)
                        oeSeguimientoMonitoreo.Estado = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 8).Value).Trim
                        oeSeguimientoMonitoreo.NombreEstado = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 9).Value).Trim

                        oeSeguimientoMonitoreo.UsuarioCreacion = gUsuarioSGI.Id
                        oeViaje.Id = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 2).Value).Trim
                        oeViaje.Codigo = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 1).Value).Trim
                        oeViaje.Origen = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 12).Value).Trim
                        oeViaje.Destino = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 13).Value).Trim
                        oeViaje.Cliente = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 14).Value).Trim
                        oeViaje.Piloto = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 15).Value).Trim
                        oeViaje.Copiloto = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 16).Value).Trim
                        oeViaje.TipoVehiculo = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 10).Value).Trim
                        oeViaje.Tracto = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 11).Value).Trim
                        oeSeguimientoMonitoreo.oeViaje = oeViaje
                        oeSeguimiento = New e_Seguimiento
                        fechaAux = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 19).Value).Trim
                        oeSeguimiento.SalidaOrigen = IIf(fechaAux.Trim = "", "01/01/1901", fechaAux.Trim)
                        oeSeguimientoMonitoreo.oeSeguimiento = oeSeguimiento
                        listaSeguimientoMonitoreo.Add(oeSeguimientoMonitoreo)
                    Else
                        Exit For
                    End If
                Next

                Dim listaViaje = From lvi In listaSeguimientoMonitoreo _
                     Order By lvi.Fecha Ascending _
                     Select Id = lvi.Id, Codigo = lvi.Codigo, IdViaje = lvi.IdViaje, Fecha = lvi.Fecha, FechaAproxLlegada = lvi.FechaAproxLlegada, FechaEntrega = lvi.FechaEntrega _
                     , IdUbicacion = lvi.IdUbicacion, Ubicacion = lvi.Ubicacion, ReferenciaLugar = lvi.ReferenciaLugar, IdOperador = lvi.IdOperador, Operador = lvi.Operador, Glosa = lvi.Glosa _
                     , Estado = lvi.Estado, NombreEstado = lvi.NombreEstado, FechaCreacion = lvi.FechaCreacion, FechaModifica = lvi.FechaModifica, UsuarioCreacion = lvi.UsuarioCreacion _
                     , lvi.UsuarioModifica, CodigoViaje = lvi.oeViaje.Codigo, FechaViaje = lvi.oeViaje.Fecha, lvi.oeViaje.IdOrigen _
                    , Origen = lvi.oeViaje.Origen, IdDestino = lvi.oeViaje.IdDestino, Destino = lvi.oeViaje.Destino, IdPiloto = lvi.oeViaje.IdPiloto _
                    , Piloto = lvi.oeViaje.Piloto, IdCopiloto = lvi.oeViaje.IdCopiloto, Copiloto = lvi.oeViaje.Copiloto, CargaMaterial = lvi.oeViaje.CargaMaterial _
                    , PesoToneladas = lvi.oeViaje.PesoToneladas, IdTracto = lvi.oeViaje.IdTracto, Tracto = lvi.oeViaje.Tracto, IdEscala = lvi.oeViaje.IdEscala _
                    , Escala = lvi.oeViaje.Escala, Cliente = lvi.oeViaje.Cliente, Carreta = lvi.oeViaje.Carreta, TipoVehiculo = lvi.oeViaje.TipoVehiculo _
                    , SalidaOrigen = lvi.oeSeguimiento.SalidaOrigen

                gridImportar.DataSource = listaViaje.ToList
                gridImportar.DataBind()

                oeSeguimientoMonitoreo = New e_SeguimientoMonitoreo

                If Not objXls Is Nothing Then
                    objWorkbook.Saved = True
                    objWorkbook.Close()
                    objXls.Quit()
                End If
                OpenFileDialog1.Dispose()
                ObjExcel = Nothing
                objWorkSheet = Nothing
                objWorkbook = Nothing
                objXls = Nothing
                Dim proceso() As Process
                proceso = Process.GetProcessesByName("EXCEL")
                If proceso.Length > 0 Then
                    proceso(proceso.Length - 1).Kill()
                End If

            Else
                OpenFileDialog1.Dispose()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub GuardarImportar()
        Try
            Dim listaAux As New List(Of e_SeguimientoMonitoreo)

            For Each fila In gridImportar.Rows
                oeSeguimientoMonitoreo = New e_SeguimientoMonitoreo
                oeSeguimientoMonitoreo.TipoOperacion = "I"
                oeSeguimientoMonitoreo.Id = ""
                oeSeguimientoMonitoreo.Codigo = ""
                oeSeguimientoMonitoreo.IdViaje = fila.Cells("IdViaje").Text.ToString.Trim()
                oeSeguimientoMonitoreo.IdOperador = fila.Cells("IdOperador").Text.ToString.Trim()
                oeSeguimientoMonitoreo.Operador = fila.Cells("Operador").Text.ToString.Trim()
                oeSeguimientoMonitoreo.IdUbicacion = fila.Cells("IdUbicacion").Text.ToString.Trim()
                oeSeguimientoMonitoreo.Ubicacion = fila.Cells("Ubicacion").Text.ToString.Trim()
                oeSeguimientoMonitoreo.ReferenciaLugar = fila.Cells("ReferenciaLugar").Text.ToString.Trim()
                oeSeguimientoMonitoreo.Fecha = fila.Cells("Fecha").Text.ToString.Trim()
                oeSeguimientoMonitoreo.FechaAproxLlegada = fila.Cells("FechaAproxLlegada").Text.ToString.Trim()
                oeSeguimientoMonitoreo.FechaEntrega = fila.Cells("FechaEntrega").Text.ToString.Trim()
                oeSeguimientoMonitoreo.Estado = fila.Cells("Estado").Text.ToString.Trim()
                oeSeguimientoMonitoreo.NombreEstado = fila.Cells("NombreEstado").Text.ToString.Trim()
                oeSeguimientoMonitoreo.Glosa = fila.Cells("Glosa").Text.ToString.Trim()
                oeSeguimientoMonitoreo.UsuarioCreacion = gUsuarioSGI.Id

                oeViaje = New e_Viaje
                oeViaje.Id = fila.Cells("IdViaje").Text.ToString.Trim()
                oeViaje.Codigo = fila.Cells("IdViaje").Text.ToString.Trim()
                oeViaje.Origen = fila.Cells("Origen").Text.ToString.Trim()
                oeViaje.Destino = fila.Cells("Destino").Text.ToString.Trim()
                oeViaje.Cliente = fila.Cells("Cliente").Text.ToString.Trim()
                oeViaje.Piloto = fila.Cells("Piloto").Text.ToString.Trim()
                oeViaje.Copiloto = fila.Cells("Copiloto").Text.ToString.Trim()
                oeViaje.TipoVehiculo = fila.Cells("TipoVehiculo").Text.ToString.Trim()
                oeViaje.Tracto = fila.Cells("Tracto").Text.ToString.Trim()
                oeSeguimientoMonitoreo.oeViaje = oeViaje

                oeSeguimiento = New e_Seguimiento
                oeSeguimiento.SalidaOrigen = fila.Cells("SalidaOrigen").Text.ToString.Trim()
                oeSeguimientoMonitoreo.oeSeguimiento = oeSeguimiento

                Dim listaCombo As New List(Of e_Combo)
                Dim tooltip As New StringBuilder
                listaCombo = ValidarImportar(oeSeguimientoMonitoreo)
                oeSeguimientoMonitoreo.PrefijoID = gs_PrefijoIdSucursal '@0001
                If listaCombo.Count = 0 Then
                    If olSeguimientoMonitoreo.Guardar(oeSeguimientoMonitoreo) Then
                        Continue For
                    End If
                End If
                listaAux.Add(oeSeguimientoMonitoreo)
            Next

            If listaAux.Count = 0 Then
                mensajeEmergente.Confirmacion("La Informacion ha Sido Guardada Correctamente", True)
            Else
                mensajeEmergente.Confirmacion("La Informacion ha Sido Guardada Correctamente", True)
                Select Case MessageBox.Show("Existen Registros No Guardados, Desea Visualizarlos?", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        listaSeguimientoMonitoreo = listaAux
                        Dim listaViaje = From lvi In listaSeguimientoMonitoreo _
                         Order By lvi.Fecha Ascending _
                         Select Id = lvi.Id, Codigo = lvi.Codigo, IdViaje = lvi.IdViaje, Fecha = lvi.Fecha, FechaAproxLlegada = lvi.FechaAproxLlegada, FechaEntrega = lvi.FechaEntrega _
                         , IdUbicacion = lvi.IdUbicacion, Ubicacion = lvi.Ubicacion, ReferenciaLugar = lvi.ReferenciaLugar, IdOperador = lvi.IdOperador, Operador = lvi.Operador, Glosa = lvi.Glosa _
                         , Estado = lvi.Estado, NombreEstado = lvi.NombreEstado, FechaCreacion = lvi.FechaCreacion, FechaModifica = lvi.FechaModifica, UsuarioCreacion = lvi.UsuarioCreacion _
                         , lvi.UsuarioModifica, CodigoViaje = lvi.oeViaje.Codigo, FechaViaje = lvi.oeViaje.Fecha, lvi.oeViaje.IdOrigen _
                        , Origen = lvi.oeViaje.Origen, IdDestino = lvi.oeViaje.IdDestino, Destino = lvi.oeViaje.Destino, IdPiloto = lvi.oeViaje.IdPiloto _
                        , Piloto = lvi.oeViaje.Piloto, IdCopiloto = lvi.oeViaje.IdCopiloto, Copiloto = lvi.oeViaje.Copiloto, CargaMaterial = lvi.oeViaje.CargaMaterial _
                        , PesoToneladas = lvi.oeViaje.PesoToneladas, IdTracto = lvi.oeViaje.IdTracto, Tracto = lvi.oeViaje.Tracto, IdEscala = lvi.oeViaje.IdEscala _
                        , Escala = lvi.oeViaje.Escala, Cliente = lvi.oeViaje.Cliente, Carreta = lvi.oeViaje.Carreta, TipoVehiculo = lvi.oeViaje.TipoVehiculo _
                        , SalidaOrigen = lvi.oeSeguimiento.SalidaOrigen

                        gridImportar.DataSource = listaViaje.ToList
                        gridImportar.DataBind()
                        '                        GrigDocumentoMasivoMarcar()
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, tcPrincipal)
                        Consultar(True)
                        griLista.Focus()
                End Select
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function ValidarImportar(ByVal obj As e_SeguimientoMonitoreo) As List(Of e_Combo)
        Try
            Dim listaCombo As New List(Of e_Combo)
            Dim oeCombo As e_Combo

            If obj.IdViaje = "" Then
                oeCombo = New e_Combo
                oeCombo.Id = "IdViaje"
                oeCombo.Nombre = "Debe Seleccionar Viaje."
                listaCombo.Add(oeCombo)
            End If

            If obj.IdUbicacion = "" Then
                oeCombo = New e_Combo
                oeCombo.Id = "IdUbicacion"
                oeCombo.Nombre = "Debe Ingresar Ubicación."
                listaCombo.Add(oeCombo)
            End If

            Dim TiempoDiferencia As Long
            Dim DiasLimiteViaje As Integer = TiempoMaximoViaje / 1440
            Dim fechaSalidaOrigen As Date = obj.oeSeguimiento.SalidaOrigen
            Dim fechaSeguimiento As Date = obj.Fecha
            Dim fechaAproxLlegada As Date = obj.FechaAproxLlegada
            Dim fechaEntrega As Date = obj.FechaEntrega

            TiempoDiferencia = DateDiff(DateInterval.Minute, fechaSalidaOrigen, fechaSeguimiento)
            If TiempoDiferencia > TiempoMaximoViaje Or TiempoDiferencia < 0 Then
                oeCombo = New e_Combo
                oeCombo.Id = "Fecha"
                oeCombo.Nombre = "Fecha Seguimiento debe estar entre los primeros " & DiasLimiteViaje & " días del viaje."
                listaCombo.Add(oeCombo)
            End If
            TiempoDiferencia = DateDiff(DateInterval.Minute, fechaSalidaOrigen, fechaAproxLlegada)
            If TiempoDiferencia > TiempoMaximoViaje Or TiempoDiferencia < 0 Then
                oeCombo = New e_Combo
                oeCombo.Id = "FechaAproxLlegada"
                oeCombo.Nombre = "Fecha Aproximada de Llegada debe estar entre los primeros " & DiasLimiteViaje & " días del viaje."
                listaCombo.Add(oeCombo)
            End If
            TiempoDiferencia = DateDiff(DateInterval.Minute, fechaSalidaOrigen, fechaEntrega)
            If TiempoDiferencia > TiempoMaximoViaje Or TiempoDiferencia < 0 Then
                oeCombo = New e_Combo
                oeCombo.Id = "FechaEntrega"
                oeCombo.Nombre = "Fecha Entrega debe estar entre los primeros " & DiasLimiteViaje & " días del viaje."
            End If
            Return listaCombo
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub btnValidar_Click(sender As Object, e As EventArgs) Handles btnValidar.Click
        Try
            Dim listaAux As New List(Of e_SeguimientoMonitoreo)

            For Each fila In gridImportar.Rows
                oeSeguimientoMonitoreo = New e_SeguimientoMonitoreo
                oeSeguimientoMonitoreo.TipoOperacion = "I"
                oeSeguimientoMonitoreo.Id = ""
                oeSeguimientoMonitoreo.Codigo = ""
                oeSeguimientoMonitoreo.IdViaje = fila.Cells("IdViaje").Text.ToString.Trim()
                'oeSeguimientoMonitoreo.IdOperador = cboOperador.Value.ToString.Trim
                'oeSeguimientoMonitoreo.IdOperador = IIf(cboOperador.Value = Nothing, "", cboOperador.Value)
                oeSeguimientoMonitoreo.IdUbicacion = fila.Cells("IdUbicacion").Text.ToString.Trim()
                oeSeguimientoMonitoreo.ReferenciaLugar = fila.Cells("ReferenciaLugar").Text.ToString.Trim()
                oeSeguimientoMonitoreo.Fecha = fila.Cells("Fecha").Text.ToString.Trim()
                oeSeguimientoMonitoreo.FechaAproxLlegada = fila.Cells("FechaAproxLlegada").Text.ToString.Trim()
                oeSeguimientoMonitoreo.FechaEntrega = fila.Cells("FechaEntrega").Text.ToString.Trim()
                oeSeguimientoMonitoreo.Estado = fila.Cells("Estado").Text.ToString.Trim()
                oeSeguimientoMonitoreo.Glosa = fila.Cells("Glosa").Text.ToString.Trim()
                oeSeguimientoMonitoreo.UsuarioCreacion = gUsuarioSGI.Id

                oeSeguimiento = New e_Seguimiento
                oeSeguimiento.SalidaOrigen = fila.Cells("SalidaOrigen").Text.ToString.Trim()
                oeSeguimientoMonitoreo.oeSeguimiento = oeSeguimiento

                fila.CellAppearance.BackColor = Color.White
                Dim listaCombo As New List(Of e_Combo)
                Dim tooltip As New StringBuilder
                listaCombo = ValidarImportar(oeSeguimientoMonitoreo)
                If listaCombo.count = 0 Then Continue For
                For Each Combo In listaCombo
                    tooltip.AppendLine(Combo.Nombre)
                Next
                fila.CellAppearance.BackColor = Color.Red
                fila.ToolTipText = tooltip.ToString

            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class