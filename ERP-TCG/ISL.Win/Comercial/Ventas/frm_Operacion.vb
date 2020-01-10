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
Imports Infragistics.Shared
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinEditors
Imports System.Configuration
Imports Infragistics.Win.CalcEngine
Imports Infragistics.Win.UltraWinDataSource
Imports System.Threading
Imports System.Data.OleDb

Public Class frm_Operacion
    Inherits frm_MenuPadre

#Region "Instancia"

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    ''' <summary>
    ''' Instancia unica de Formulario: frm_Operacion
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_Operacion()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaración de variables"

    Dim oeDemanda As New e_Demanda
    Dim olDemanda As New l_Demanda

    Dim oeDemandaDetalle As New e_DemandaDetalle

    Dim oeRuta As New e_Ruta
    Dim oeRutaDemanda As New e_Ruta
    Dim olRuta As New l_Ruta
    Dim oeRutaVacio As New e_Ruta

    Dim olCombo As New l_Combo
    Dim oeCombo As New e_Combo

    Dim olTrabajador As New l_Trabajador

    Dim oeLugar As New e_Lugar
    Dim olLugar As New l_Lugar

    Dim ListaEscala As New List(Of e_Combo)

    Dim oeVehiculo As New e_Vehiculo

    Dim olVehiculo As New l_Vehiculo

    Dim oeViaje As New e_Viaje
    Dim oeOperacionDetalle As New e_OperacionDetalle

    Dim oeOperacion As New e_Operacion
    Dim olOperacion As New l_Operacion

    Dim oeUsuario As New e_Usuario

    Dim oeFlete As New e_Flete
    Dim olFlete As New l_Flete

    Dim oeTarifa As New e_TarifasCliente
    Dim olTarifa As New l_TarifasCliente

    Dim ListaViajeControl As New List(Of e_Viaje)
    Dim ListaViaje As New List(Of e_Viaje)


    Dim _ingresando_datos As Boolean = False

    Dim Opcion As Boolean

    Dim OrdenEscala As Integer = 0
    Dim OrigenEscala As String
    Dim OrigenAgrega As String
    Dim OperacionEscala As Integer = 1
    Dim FechaViaje As Date

    Dim oeUsuarioPerfil As New e_UsuarioPerfil
    Dim olUsuarioPerfil As New l_UsuarioPerfil

    Dim oePerfil As New e_Perfil
    Dim olPerfil As New l_Perfil

    Dim oeRegistroEditado As New e_RegistrosEditados
    Dim olRegistroEditado As New l_RegistrosEditados

    Dim oeDistanciaZona As New e_DistanciaZona
    Dim olDistanciaZona As New l_DistanciaZona

    Dim olPrefijo As New l_Configuracion

    Dim RutaOperacion As String = ""
    Dim RutaIdOrigen As String = ""
    Dim RutaIdDestino As String = ""
    Dim RutaOrigen As String = ""
    Dim RutaDestino As String = ""
    Dim RutaIndVacio As Boolean = False
    Dim Tipo As String = "E"

    Dim RegistroEditado As Integer = 0
    Dim IdRegistroEditado As String = ""
    Dim IndCopiloto As Boolean = False

    Dim oeBonificacion As New e_Bonificacion
    Dim olBonificacion As New l_Bonificacion
    Dim ListaBonificacion As New List(Of e_Bonificacion)

    Dim TextoMensaje As String = ""

    Dim HoraNoche As Date = "23:00:00 PM"

    Dim ViajeTanqueado As String = ""
    Dim TractoTanqueado As String = ""
    Dim CarretaTanqueada As String = ""
    Dim Tanqueo As String = ""
    Dim EstadoViaje As String = "1CH00017"
    Dim TractoViaje As String = ""
    Dim CarretaViaje As String = ""

    Dim FlotaTracto As String = ""
    Dim FlotaOperacion As String = ""
    Dim CargaVacia As Integer = 1

    Dim IdDestinoViaje As String = ""

    Private _acl As String = "", _estado As String = ""

    Dim olViajeTercero As New l_ViajesTerceros
    Dim oeContratoTercero As New e_ViajesTerceros
    Dim oeIgv As New e_Impuesto

    Dim PrefijoId As String = ""

    Dim FechaServidor As Date = ObtenerFechaServidor()

    Dim ValorIgv As Double = 0

    Dim olFuncionesGenerales As New l_FuncionesGenerales

    Dim ListTercero As New List(Of e_Combo)

    Dim ProcesoNegocio As String = "OPERACION"

    Dim IndPropiedadTracto As Integer = -1

    Dim IndPropiedadCarreta As Integer = -1
    Dim IndPropiedadTractoTemp As Integer = 1
    Dim IndPropiedadCarretaTemp As Integer = 1

    Public codigoCliente As String = ""
    Dim olCliente As New l_Cliente
    Dim oeCliente As New e_Cliente
    Dim codigoComisionista As String = ""
    Public Shared codigoNuevoComisionista As String = ""
    Public Shared codigoNuevoCLiente As String = ""
    Public codigoTercero As String = ""
    Dim olIgv As New l_Impuesto
    Dim listaPagoEfectivo As New List(Of e_Combo)

    'bitacora
    Dim columnas As New List(Of String)
    Dim rowGeneral(14, 1) As Integer
    Dim glosasGeneral(14, 2) As String
    Dim idDetalleGeneral As String
    Dim count As Integer

    Dim ListaBitacora As New List(Of e_Bitacora)
    Dim GlosaDetalleDemanda As String = ""
    Dim ValoresAnterioresDetalleDemanda As String = ""
    Dim ValoresActualesDetalleDemanda As String = ""
    Dim objEliminarTercero As New e_Bitacora
    Dim objEliminarDetalle As New e_Bitacora

    Dim cadenaDemandas As String = ""
    Dim cadenaDevuelta As Array
    Public Shared motivoCancelacion As String = ""
    Public Shared IdConceptoCancEliminacion As String = ""

    Private codigoDemanda As String = ""
    Private TipoVehiculo As String = ""
    Private IdEscala As String = ""

    Private Shared instancia As frm_Operacion = Nothing
    Private Shared Operacion As String
    Private Estado As String
    Private EliminarViajeSinMje As String = ""

    Private NombrePropTracto As String = ""
    Private bandTractoFicticio As String = ""

    Private idDespachoOperaciones As String = String.Empty
    Private bolIndFormExterno As Boolean = False
    Private oeViajeExterno As e_Viaje

    Private loNroViajesReport As New List(Of e_Concepto)
    Private oeConcepto As New e_Concepto
    Private olConcepto As New l_Concepto
    Private loConcepto As New List(Of e_Concepto)

    Private lisDiasSupervisor As New List(Of e_Concepto)
    Private lisDiasJefe As New List(Of e_Concepto)

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Operacion = "Inicializa"
            Estado = IIf(Activo, " Activo", " Inactivo")
            mt_HabilitarSumatoria(False)
            decProduccionIGV.Value = 0 : decProduccionSinIGV.Value = 0
            If ValidarFechaInicioFin(fecDesde, fecHasta) Then
                oeViaje = New e_Viaje
                If tabViajesLista.Tabs(0).Selected = True Then 'Tab Viaje
                    mt_HabilitarSumatoria(True)
                    LimpiaGrid(griLista, ogdListaOperacion)
                    Listar("0", griLista)
                Else
                    If tabViajesLista.Tabs(1).Selected = True Then 'Viaje Terceros
                        LimpiaGrid(griListaTerceros, ogdListaOperacion)
                        Listar("T", griListaTerceros)
                    Else
                        If tabViajesLista.Tabs(2).Selected Then 'Desenganches
                            LimpiaGrid(griViajesProceso, ogdListaOperacion)
                            Listar("A", griViajesProceso)
                        Else 'Trazabilidad
                            If tabViajesLista.Tabs(3).Selected Then
                                LimpiaGrid(griTransabilida, ogdListaOperacion)
                                Listar("N", griTransabilida)
                            Else
                                GraficoProduccion(fecDesde.Value.Date, fecHasta.Value.Date)
                            End If

                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Sub GraficoProduccion(ByVal FechaI As Date, ByVal FechaF As Date)
        Dim ProduccionViaje = New List(Of e_Combo)
        oeCombo = New e_Combo
        oeCombo.Nombre = "ProduccionViaje"
        oeCombo.Descripcion = FechaF
        oeCombo.Fecha = FechaI
        ProduccionViaje.AddRange(olCombo.Listar(oeCombo))
        Dim dtPie As New DataTable
        dtPie.Columns.Add("Monto", System.Type.GetType("System.Double"))
        dtPie.Columns.Add("Nombre", System.Type.GetType("System.String"))

        For Each oe As e_Combo In ProduccionViaje
            dtPie.Rows.Add(oe.Id, oe.Nombre)
        Next
        UltraChart1.DataSource = dtPie
        UltraChart1.DataBind()
    End Sub

    Public Overrides Sub Nuevo()
        Try
            Operacion = "Nuevo"
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oeOperacion = New e_Operacion
            oeViaje = New e_Viaje
            ListaViaje = New List(Of e_Viaje)
            oeOperacionDetalle = New e_OperacionDetalle
            oeContratoTercero = New e_ViajesTerceros
            griViaje.DisplayLayout.Bands(0).Columns("Codigo").Hidden = True
            Inicializar()
            cboDestino.Enabled = False
            griViaje.DataSource = ListaViaje
            griViajeDetalle.DataSource = New List(Of e_OperacionDetalle)
            griDetalleTercero.DataSource = New List(Of e_ViajesTerceros)
            MostrarTabs(1, ficOperacion, 1)
            fecViaje.Value = FechaServidor.Date
            cboCarreta.Text = ""
            OrdenEscala = 0
            OperacionEscala = 1
            opcNocheDia.CheckedIndex = 1
            LimpiaGrid(griEscala, ogdEscala)
            ficViaje.Tabs(0).Selected = True
            cboRutaOrigen.Enabled = True
            cboRutaDestino.Enabled = True
            cboTipoVehiculo.Enabled = True
            cboRutaOrigen.Focus()
            cboRutaOrigen.SelectedIndex = -1
            cboRutaDestino.SelectedIndex = -1
            ugb_Espera.Visible = False
            TipoCliente = 0
            LimpiaGrid(griDisponibleVehiculo, ogdDisponibleVehiculos)
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            RutaIdDestino = ""
            verValidaciones.Checked = True
            '@0001 Ini
            'If PrefijoId = "1LU" Then
            '    cboRutaOrigen.Text = "CD LURIN (LIMA)"
            '    cboRutaDestino.Focus()
            '    cboRutaDestino.Text = "CD LURIN (LIMA)"
            'End If
            '@0001 Fin
            cboPiloto.Enabled = True
            griViaje.DisplayLayout.Bands(0).Columns("Piloto").CellActivation = Activation.AllowEdit
            'If PrefijoId <> "1PY" Then '@0001
            CalcularTotales(griViaje, "PorcentajeFlete", "FleteUnitario")
            'End If '@0001
            CalcularTotales(griViajeDetalle, "Flete", "Comision", "FleteUnitario", "Subtotal", "Consolidado")
            IncidenciasPublic = New e_IncidenciasAutentificadas
            tabAdicional.Tabs(3).Selected = True
            verValidaFU.Checked = True
            CalFleteUnitario.Enabled = False
            cboTracto.Text = ""
            cboCarreta.Text = ""
            'listar piloto copiloto activos a la fecha
            'CrearComboGrid("Piloto", "Nombre", griViaje, olCombo.ComboGrilla(PilotoPublic.ToList.Where(Function(x) FormatDateTime(x.Extras.Item(0), DateFormat.ShortDate) = "01/01/1901" Or Date.Parse(x.Extras.Item(0)) >= Now).ToList), True)
            'CrearComboGrid("Copiloto", "Nombre", griViaje, olCombo.ComboGrilla(CopilotoPublic.ToList.Where(Function(y) FormatDateTime(y.Extras.Item(0), DateFormat.ShortDate) = "01/01/1901" Or Date.Parse(y.Extras.Item(0)) >= Now).ToList), True)

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
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            '  ficViaje.SelectedTab = ficViaje.Tabs(1)           
            ficViaje.SelectedTab = ficViaje.Tabs(0)
            olFuncionesGenerales = New l_FuncionesGenerales
            griViaje.DisplayLayout.Bands(0).Columns("Codigo").Hidden = False
            'listar piloto copiloto activos a la fecha            
            'CrearComboGrid("Piloto", "Nombre", griViaje, olCombo.ComboGrilla(PilotoPublic.ToList.Where(Function(x) FormatDateTime(x.Extras.Item(0), DateFormat.ShortDate) = "01/01/1901" Or Date.Parse(x.Extras.Item(0)) >= Date.Parse(griLista.ActiveRow.Cells("Fecha").Value)).ToList), True)
            'CrearComboGrid("Copiloto", "Nombre", griViaje, olCombo.ComboGrilla(CopilotoPublic.ToList.Where(Function(y) FormatDateTime(y.Extras.Item(0), DateFormat.ShortDate) = "01/01/1901" Or Date.Parse(y.Extras.Item(0)) >= Date.Parse(griLista.ActiveRow.Cells("Fecha").Value)).ToList), True)
            ''''
            If gUsuarioSGI.Controlado <> 0 Then
                'Valida Fecha Cierre Ventas
                olFuncionesGenerales.ValidarFechaCierre("Editar", griLista.ActiveRow.Cells("Fecha").Value, FechaServidor.Date)
            End If
            olOperacion = New l_Operacion
            oeOperacion = New e_Operacion
            oeContratoTercero = New e_ViajesTerceros
            olRegistroEditado = New l_RegistrosEditados
            oeViaje = New e_Viaje
            If bolIndFormExterno Then
                oeViaje.Id = oeViajeExterno.Id
            Else
                oeViaje.Id = griLista.ActiveRow.Cells("Id").Value
            End If
            oeViaje.TipoOperacion = "P"
            oeViaje = olOperacion.ObtenerViaje(oeViaje)
            ViajeTanqueado = oeViaje.Id
            TractoTanqueado = oeViaje.IdTracto
            CarretaTanqueada = If(oeViaje.IdCarreta IsNot Nothing, oeViaje.IdCarreta.ToString().Trim(), String.Empty)
            cboTipoVehiculo.Enabled = True
            Tanqueo = oeViaje.Escala
            If oeViaje.IdCopiloto.Trim <> "" Then
                If oeViaje.UsuarioModifica <> gUsuarioSGI.oePersona.NombreCompleto Then
                    ''Await MensajePC("El viaje lo está modificando " & oeViaje.UsuarioModifica)
                    bolIndFormExterno = False
                    Throw New Exception("La información del Viaje no es accesible pues esta siendo editado por" & Environment.NewLine & Environment.NewLine & _
                                        "el Usuario: " & oeViaje.UsuarioModifica & Environment.NewLine & _
                                        "desde: " & oeViaje.LlegadaOrigen & Environment.NewLine & _
                                        "en la Sucursal: " & oeViaje.Piloto)
                Else
                    oeRegistroEditado = New e_RegistrosEditados
                    With oeRegistroEditado
                        .TipoOperacion = "A"
                        .Id = oeViaje.IdCopiloto
                        .FechaModificado = DateAdd(DateInterval.Minute, 5, oeViaje.LlegadaOrigen)
                    End With
                    oeRegistroEditado.PrefijoID = gs_PrefijoIdSucursal '@0001
                    olRegistroEditado.Guardar(oeRegistroEditado)
                    RegistroEditado = 1
                End If
            Else
                RegistroEditado = 1
            End If
            If oeViaje.Estado <> "FIN" Then
                Inicializar()
                If oeViaje.IndPlanilla <> 0 Then
                    cboDestino.Enabled = False
                    cboPiloto.Enabled = False
                    cboCopiloto.Enabled = False
                    griViaje.DisplayLayout.Bands(0).Columns("Destino").CellActivation = Activation.NoEdit
                    griViaje.DisplayLayout.Bands(0).Columns("Piloto").CellActivation = Activation.NoEdit
                    griViaje.DisplayLayout.Bands(0).Columns("CoPiloto").CellActivation = Activation.NoEdit
                Else
                    cboDestino.Enabled = True
                    cboPiloto.Enabled = True
                    cboCopiloto.Enabled = True
                    griViaje.DisplayLayout.Bands(0).Columns("Destino").CellActivation = Activation.AllowEdit
                    griViaje.DisplayLayout.Bands(0).Columns("Piloto").CellActivation = Activation.AllowEdit
                    griViaje.DisplayLayout.Bands(0).Columns("CoPiloto").CellActivation = Activation.AllowEdit
                End If

                If oeViaje.PesoToneladas > 0 Then
                    cboPiloto.Enabled = False
                    griViaje.DisplayLayout.Bands(0).Columns("Piloto").CellActivation = Activation.NoEdit
                Else
                    If oeViaje.IndPlanilla = 0 Then
                        cboPiloto.Enabled = True
                        griViaje.DisplayLayout.Bands(0).Columns("Piloto").CellActivation = Activation.AllowEdit
                    End If
                End If
                Operacion = "Editar"
                'ruta.Enabled = False
                cboRutaOrigen.Enabled = False
                cboRutaDestino.Enabled = False
                If EditarOperacion() Then
                    OrdenEscala = 0
                    OperacionEscala = 1
                    ficViaje.Tabs(0).Selected = True
                    LimpiaGrid(griEscala, ogdEscala)
                    ' LimpiaGrid(griDemanda, ogdDemanda)                
                    LimpiaGrid(griDisponibleVehiculo, ogdDisponibleVehiculos)
                    ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
                    fecViaje.Focus()
                    If RegistroEditado = 1 Then
                        oeRegistroEditado = New e_RegistrosEditados
                        With oeRegistroEditado
                            If bolIndFormExterno Then
                                .IdRegistro = oeViajeExterno.Id
                            Else
                                .IdRegistro = griLista.ActiveRow.Cells("Id").Value
                            End If
                            .Referencia = "Viaje"
                            .UsuarioEdita = gUsuarioSGI.Id
                        End With
                        oeRegistroEditado.PrefijoID = gs_PrefijoIdSucursal '@0001
                        IdRegistroEditado = olRegistroEditado.Guardar(oeRegistroEditado)
                    End If

                Else
                    Operacion = "Inicializa"
                End If
            Else
                ''Await MensajePC("Viaje finalizado")
                bolIndFormExterno = False
                Throw New Exception(Me.Text & ": El Viaje no se puede editar se encuentra FIN")
            End If
            tabAdicional.Tabs(3).Selected = True

            'If PrefijoId <> "1PY" Then '@0001
            CalcularTotales(griViaje, "PorcentajeFlete", "FleteUnitario")
            'End If '@0001

            CalcularTotales(griViajeDetalle, "Flete", "Comision", "Subtotal", "Consolidado")
            IncidenciasPublic = New e_IncidenciasAutentificadas
            ugb_Espera.Visible = False
            verValidaFU.Checked = True
            CalFleteUnitario.Enabled = False
            If bolIndFormExterno Then
                verEscala.Checked = True
                cboEscala.Value = oeViajeExterno.IdEscala
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
            If GuardarOperacion() Then
                IncidenciasPublic = New e_IncidenciasAutentificadas
                MostrarTabs(0, ficOperacion, 2)
                MyBase.Guardar()
                ''Await MensajePC("Viaje Guardado")
            Else
                MostrarTabs(1, ficOperacion, 1)
            End If
            bolIndFormExterno = False
            idDespachoOperaciones = String.Empty
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
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
                    If GuardarOperacion() Then
                        MostrarTabs(0, ficOperacion, 2)
                        _ingresando_datos = False
                        Operacion = "Inicializa"
                        MyBase.Consultar(True)
                    Else
                        _ingresando_datos = True
                    End If
                Case Windows.Forms.DialogResult.No
                    MostrarTabs(0, ficOperacion, 2)
                    _ingresando_datos = False
                    Operacion = "Inicializa"
                    IncidenciasPublic = New e_IncidenciasAutentificadas
                    ActualizaRegistroEditado(RegistroEditado, IdRegistroEditado)
                    MyBase.Consultar(True)
                Case Windows.Forms.DialogResult.Cancel
                    _ingresando_datos = True
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

    Public Overrides Sub Eliminar()
        Try
            Tipo = "E"
            griLista.ActiveRow.Delete()
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

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Select Case ficOperacion.SelectedTab.Index
                Case 0 'Listado
                    Select Case tabViajesLista.SelectedTab.Index
                        Case 0 'Viajes
                            ExportarGrillaAExcel(griLista)
                        Case 1 'Viajes x Terceros
                            ExportarGrillaAExcel(griListaTerceros)
                        Case 2 'Desenganches
                            ExportarGrillaAExcel(griViajesProceso)
                        Case 3 'Trazabilidad
                            ExportarGrillaAExcel(griTransabilida)
                    End Select
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_Operacion_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
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

    Private Sub frm_Operacion_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Try
            Select Case Operacion
                Case "Nuevo"
                    AyudaMaestros(TipoCliente)
                    TipoCliente = 0
                    ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
                Case "Editar"
                    ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
                Case "Inicializa"
                    MostrarTabs(0, ficOperacion)
                    mt_ControlBotoneria()
                Case "Ayuda"
            End Select

            If codigoComisionista.Trim <> "" Then
                ComisionistasPublic = New List(Of e_Combo)
                oeCombo = New e_Combo
                oeCombo.Nombre = "Comisionistas"
                ComisionistasPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)
                LlenarComboMaestro(Me.cboComisionista, ComisionistasPublic, 0)
                Me.cboComisionista.Value = codigoComisionista
                'Me.cboComisionista.Value = codigoNuevoCom
                codigoComisionista = ""
            End If

            If codigoCliente <> "" Then
                ClientesPublic = New List(Of e_Combo)
                oeCombo = New e_Combo
                oeCombo.Nombre = "Clientes"
                ClientesPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)
                LlenarComboMaestro(Me.cboCliente, ClientesPublic, 0)
                LlenarComboMaestro(Me.cboClienteFinal, ClientesPublic, 0)
                Me.cboCliente.Value = codigoCliente
                Me.cboClienteFinal.Value = codigoCliente
                'Me.cboComisionista.Value = codigoNuevoCom
                codigoCliente = ""
            End If

            If codigoNuevoCLiente <> "" Then
                ClientesPublic = New List(Of e_Combo)
                oeCombo = New e_Combo
                oeCombo.Nombre = "Clientes"
                ClientesPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)
                LlenarComboMaestro(Me.cboCliente, ClientesPublic, 1)
                LlenarComboMaestro(Me.cboClienteFinal, ClientesPublic, 0)
                Me.cboCliente.Value = codigoNuevoCLiente
                Me.cboClienteFinal.Value = codigoNuevoCLiente
                codigoNuevoCLiente = ""
                'Me.cboComisionista.Value = codigoNuevoCom
                ' codigoCliente = ""
            End If
            If codigoNuevoComisionista <> "" Then
                ComisionistasPublic = New List(Of e_Combo)
                oeCombo = New e_Combo
                oeCombo.Nombre = "Comisionistas"
                ComisionistasPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)
                LlenarComboMaestro(Me.cboComisionista, ComisionistasPublic, 1)
                Me.cboComisionista.Value = codigoNuevoComisionista
                codigoNuevoComisionista = ""
                'Me.cboComisionista.Value = codigoNuevoCom
                ' codigoCliente = ""
            End If
            If codigoTercero <> "" Then
                If cboTercero.SelectedIndex > -1 Then
                    Dim lista As New List(Of e_Combo)
                    Dim olContacto As New e_Combo
                    olContacto.Nombre = "Contacto"
                    olContacto.Id = Me.cboTercero.Value
                    lista.AddRange(olCombo.Listar(olContacto))
                    LlenarComboMaestro(cboContacto, lista, 0)
                    Me.cboContacto.SelectedIndex = 0
                End If
                codigoTercero = ""
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_Operacion_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        instancia = Nothing
    End Sub

    Private Sub griDemanda_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griDemanda.AfterCellUpdate
        Try
            Select Case e.Cell.Column.Key.ToUpper
                Case "SELECCION"
                    With griDemanda.Rows(e.Cell.Row.Index)
                        If .Cells("Seleccion").Value Then
                            .Appearance.BackColor = Color.Aqua
                            .Fixed = True
                            AgregarDemanda()
                            If Not lblCodigoDemandaAProgramar.Visible Then
                                cboRutaOrigen.Focus()
                                cboRutaDestino.Focus()
                            End If
                        Else
                            .Appearance.BackColor = Color.White
                            .Fixed = False
                            EliminarDemanda()
                        End If
                    End With
            End Select
            CalcularTotalesDetalle()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griDemanda_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griDemanda.CellChange
        Try
            griDemanda.UpdateData()
            griViajeDetalle.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnAgregarViaje_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarViaje.Click
        Try
            LlenaViaje()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub verEscala_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verEscala.CheckedChanged
        If Operacion = "Nuevo" Or Operacion = "Editar" Then
            If verEscala.Checked Then
                cboEscala.Enabled = verEscala.Checked
                txtGlosaEscala.Enabled = verEscala.Checked
                txtGlosaEscala.Text = ""
                cboEscala.Focus()
            Else
                cboEscala.Enabled = verEscala.Checked
                txtGlosaEscala.Enabled = verEscala.Checked
                cboEscala.Text = ""
                txtGlosaEscala.Text = ""
            End If
            OperacionEscala = 1
        End If

    End Sub

    Private Sub cboDestino_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDestino.Leave
        If Operacion = "Nuevo" Or Operacion = "Editar" Then
            oeRuta = New e_Ruta
            olRuta = New l_Ruta
            Try
                oeRuta.Id = ""
                oeRuta.IdOrigen = cboOrigen.Value
                oeRuta.IdDestino = cboDestino.Value
                olRuta.ValidarRutaNueva(oeRuta)
            Catch ex As Exception
                EnviarEmail("consultores.tecnologicos.2010@gmail.com", "consultores.tecnologicos.2010@gmail.com;consultores.tecnologicos.2010@gmail.com", "", "", "Operaciones informa crear ruta", cboOrigen.Text & " - " & cboDestino.Text, "", True)
                cboDestino.Focus()
                cboDestino.Value = IdDestinoViaje
                mensajeEmergente.Problema("Origen - Destino  : " & ex.Message, True)
            End Try
        End If

    End Sub

    Private Function ValidaEscala(ByVal Mensaje As String, ByVal Origen As String, ByVal Destino As String) As Boolean
        Try
            olRuta = New l_Ruta
            Mensaje = "El Usuario: " & gUsuarioSGI.oePersona.NombreCompleto & ", Solicita se crea la Ruta: " & Mensaje
            oeRuta = New e_Ruta
            oeRuta.IdOrigen = Origen
            oeRuta.IdDestino = Destino
            olRuta.ValidarRutaNueva(oeRuta)
            Return True
        Catch ex As Exception
            EnviarEmail("consultores.tecnologicos.2010@gmail.com", "consultores.tecnologicos.2010@gmail.com;consultores.tecnologicos.2010@gmail.com", "", "", "Operaciones informa crear ruta", Mensaje, "", True)
            Throw New Exception(Mensaje & " " & ex.Message)
        End Try
    End Function

    Private Sub cboEscala_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEscala.Leave
        If Operacion = "Nuevo" Or Operacion = "Editar" Then
            Try
                If Me.cboEscala.Value <> "" Then
                    ValidarCombo(cboEscala, "Escala")
                    ValidaEscala(cboOrigen.Text & " - " & cboEscala.Text, cboOrigen.Value, cboEscala.Value)
                    ValidaEscala(cboEscala.Text & " - " & cboDestino.Text, cboEscala.Value, cboDestino.Value)
                End If
            Catch ex As Exception
                mensajeEmergente.Problema(ex.Message, True)
            End Try
        End If
    End Sub

    Private Sub frm_Operacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gf_AsignarEventoSeleccionarTexto(Me)
            'olPrefijo = New l_Configuracion '@0001
            'PrefijoId = olPrefijo.PrefijoID '@0001
            PrefijoId = gs_PrefijoIdSucursal '@0001
            FechaServidor = ObtenerFechaServidor()
            ColorControles()
            fecViaje.Value = FechaServidor.Date
            hViaje.Value = FechaServidor
            oeUsuario = New e_Usuario
            Dim ListaUsuario As New List(Of e_Usuario)
            oeUsuario.Id = gUsuarioSGI.Id
            oeUsuario.Login = gUsuarioSGI.Login
            ListaUsuario.Add(oeUsuario)
            oeUsuario = New e_Usuario
            oeUsuario.Id = ""
            oeUsuario.Login = "TODOS"
            ListaUsuario.Add(oeUsuario)
            LlenarComboMaestro(cboUsuario, ListaUsuario, 1)

            olLugar = New l_Lugar
            oeLugar = New e_Lugar
            oeLugar.TipoOperacion = "O"
            LlenarComboMaestro(cboRutaOrigen, olLugar.Listar(oeLugar), -1)
            LlenaCombos()
            ComboGrilla()
            ControlRangoFechaInicializa()
            '     CargarActividadesRestringidas()
            cboCentro.Value = PrefijoId
            With griViajeDetalle.DisplayLayout.Bands(0)
                If PerfilAsignado(gNombrePerfilAutorizaTarifas) Then
                    .Columns("Carga").Header.Enabled = True
                    .Columns("FleteUnitario").Header.Enabled = True
                Else
                    .Columns("FleteUnitario").EditorComponent = Nothing
                    .Columns("Origen").CellClickAction = CellClickAction.RowSelect
                    .Columns("Destino").CellClickAction = CellClickAction.RowSelect
                    .Columns("Cliente").CellClickAction = CellClickAction.RowSelect
                    .Columns("Origen").EditorComponent = Nothing
                    .Columns("Destino").EditorComponent = Nothing
                    .Columns("Cliente").EditorComponent = Nothing
                    .Columns("FleteUnitario").CellClickAction = CellClickAction.CellSelect
                End If
            End With
            If (gUsuarioSGI.leARUsuario.Where(Function(item) item.IdActividadNegocio = gActividadNegocio.Consolidado.ToString And
                                                 item.AccionSistema = gAccionSistema.ACTUALIZAR.ToString And item.IdProcesoNegocio = pProcesoNegocio)).ToList.Count > 0 Then
                griViajeDetalle.DisplayLayout.Bands(0).Columns("Consolidado").CellClickAction = CellClickAction.EditAndSelectText
            End If
            CargarActividadesRestringidas()
            ValorIgv = ObtenerIGV()

            'cargar tractos y carretas
            TractoPublic = New List(Of e_Combo)
            oeCombo = New e_Combo
            oeCombo.Nombre = "Tracto"
            TractoPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)

            CarretaPublic = New List(Of e_Combo)
            oeCombo = New e_Combo
            oeCombo.Nombre = "Carreta"
            CarretaPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)
            GraficoProduccion(fecDesde.Value.Date, fecHasta.Value.Date)
        Catch ex As Exception
            mensajeEmergente.Confirmacion(ex.Message, True)
        End Try
    End Sub
    Dim bandRpta As String = ""
    Private Sub griDisponible_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griDisponibleVehiculo.AfterCellUpdate
        Try
            Dim IdViaje As String
            Dim Disponible As Integer = 1
            Dim Total_Selec As Integer
            bandRpta = ""
            olOperacion = New l_Operacion
            For I As Integer = 0 To griDisponibleVehiculo.Rows.Count - 1
                If verProgramarViajeBloque.Checked = False Then
                    If griDisponibleVehiculo.Rows.Count > 0 Then
                        If griDisponibleVehiculo.Rows(I).Cells("Seleccion").Value Then
                            Total_Selec += 1
                            If Me.TipoVehiculo <> "" Then
                                If griDisponibleVehiculo.Rows(I).Cells("TipoVehiculo").Value <> Me.TipoVehiculo And griDisponibleVehiculo.Rows(I).Cells("Seleccion").IsActiveCell Then
                                    If MessageBox.Show("El TIPO DE VEHICULO escogido " & griDisponibleVehiculo.Rows(I).Cells("TipoVehiculo").Value &
                                                       " no coincide con el de la DEMANDA " & Me.TipoVehiculo & ". ¿Desea continuar?", "Mensaje de Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) =
                                                   Windows.Forms.DialogResult.No Then
                                        bandRpta = "N"
                                        griDisponibleVehiculo.Rows(I).Cells("Seleccion").Value = False
                                    Else
                                        bandRpta = "S"
                                    End If
                                End If
                            End If
                            If bandRpta = "S" Or bandRpta = "" Then
                                If verProgramarViajeBloque.Checked = False Then

                                    IdViaje = griDisponibleVehiculo.Rows(I).Cells("Id").Value
                                    oeViaje = New e_Viaje
                                    oeViaje.Id = griDisponibleVehiculo.Rows(I).Cells("IdTracto").Value.ToString
                                    oeViaje.TipoOperacion = "4"
                                    'ViajeVacio  = 1 Para Validar Programacion Viaje Correlatividad
                                    oeViaje.ViajeVacio = 1
                                    oeViaje = olOperacion.ObtenerViaje(oeViaje)
                                    If IdViaje = oeViaje.Id Then
                                        Disponible = 1
                                    Else
                                        If MessageBox.Show("No se puede Programar Viaje desde aqui, porque el último es: " & Environment.NewLine & _
                                                           "Viaje: " & oeViaje.Codigo & Environment.NewLine & _
                                                           "Estado Viaje: " & oeViaje.Estado & Environment.NewLine & _
                                                           "Fecha Viaje: " & oeViaje.Fecha.ToString & Environment.NewLine & _
                                                           "Ruta: " & oeViaje.Origen & " - " & oeViaje.Destino & Environment.NewLine & _
                                                           "Desea Programar Viaje desde este Ultimo ?", _
                                         "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                                            ProgramarViajeProgramado(oeViaje.Id)
                                            Disponible = 0
                                        Else
                                            griDisponibleVehiculo.Rows(I).Cells("Seleccion").Value = False
                                            griDisponibleVehiculo.Rows(I).Fixed = False
                                            Disponible = 0
                                        End If
                                    End If
                                End If
                            End If
                        End If
                        If Total_Selec > 1 Then
                            griDisponibleVehiculo.Rows(I).Cells("Seleccion").Value = False
                            'griDisponibleVehiculo.Rows(I).Appearance.BackColor = Color.White
                            griDisponibleVehiculo.Rows(I).Fixed = False
                            ' MessageBox.Show("Ya ha seleccionado otro registro, quite la SELECCION, para volver a ELEGIR OTRO VEHICULO DISPONIBLE", "Mensaje del Sistema")
                        End If
                    End If
                End If
            Next

            If Disponible = 1 And (bandRpta = "S" Or bandRpta = "") Then
                Select Case e.Cell.Column.Key.ToUpper
                    Case "SELECCION"
                        If verProgramarViajeBloque.Checked = False Then
                            If Total_Selec <= 1 Then
                                With griDisponibleVehiculo.Rows(e.Cell.Row.Index)
                                    If .Cells("Seleccion").Value Then
                                        If .Cells("DisponibleP").Value = False Or .Cells("DisponibleC").Value = False Then
                                            If .Cells("DisponibleP").Value = False Then
                                                Throw New Exception(Me.Text & ": Piloto no Disponible")
                                            End If
                                            If .Cells("DisponibleC").Value = False Then
                                                Throw New Exception(Me.Text & ": Copiloto no Disponible")
                                            End If
                                            'If .Cells("DisponibleA").Value = False Then
                                            '    Throw New Exception(Me.Text & ": Ayudante no Disponible")
                                            'End If
                                            .Fixed = True
                                            AgregarVehiculo()
                                            'cboRutaOperacion.Focus()
                                        Else
                                            .Appearance.BackColor = Color.PowderBlue
                                            .Fixed = True
                                            AgregarVehiculo()
                                            'cboRutaOperacion.Focus()
                                        End If
                                    Else
                                        If .Cells("DisponibleP").Value And .Cells("DisponibleC").Value Then
                                            .Appearance.BackColor = Color.White
                                            .Fixed = False
                                        Else
                                            .Appearance.BackColor = Color.White
                                            .Fixed = False
                                        End If

                                        EliminarVehiculo(griDisponibleVehiculo.Rows(e.Cell.Row.Index).Cells("Tracto").Value)
                                    End If
                                End With
                            End If
                        Else
                            With griDisponibleVehiculo.Rows(e.Cell.Row.Index)
                                If .Cells("Seleccion").Value Then
                                    If .Cells("DisponibleP").Value = False Or .Cells("DisponibleC").Value = False Then
                                        If .Cells("DisponibleP").Value = False Then
                                            Throw New Exception(Me.Text & ": Piloto no Disponible")
                                        End If

                                        If .Cells("DisponibleC").Value = False Then
                                            Throw New Exception(Me.Text & ": Copiloto no Disponible")
                                        End If

                                        'If .Cells("DisponibleA").Value = False Then
                                        '    Throw New Exception(Me.Text & ": Ayudante no Disponible")
                                        'End If
                                        .Fixed = True
                                        AgregarVehiculo()
                                        'cboRutaOperacion.Focus()
                                        LlenaViaje()
                                    Else
                                        .Appearance.BackColor = Color.PowderBlue
                                        .Fixed = True
                                        AgregarVehiculo()
                                        'cboRutaOperacion.Focus()
                                        LlenaViaje()
                                    End If
                                Else
                                    If .Cells("DisponibleP").Value And .Cells("DisponibleC").Value Then
                                        .Appearance.BackColor = Color.White
                                        .Fixed = False
                                    Else
                                        .Appearance.BackColor = Color.White
                                        .Fixed = False
                                    End If
                                    EliminarVehiculo(griDisponibleVehiculo.Rows(e.Cell.Row.Index).Cells("Tracto").Value)
                                End If
                            End With
                        End If
                End Select
            End If
            CalcularTotalesDetalle()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griViaje_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griViaje.CellChange
        If Operacion = "Nuevo" Or Operacion = "Editar" Then
            Try
                griViaje.UpdateData()
                Select Case e.Cell.Column.Key
                    Case "FleteUnitario"
                        'oeDemandaDetalle = New e_DemandaDetalle
                        'With griViaje.ActiveRow
                        '    .Cells("TotalFlete").Value = oeViaje.CalcularTotalFlete(CDbl(.Cells("FleteUnitario").Value), ValorIgv)
                        'End With
                        'ListaViaje = New List(Of e_Viaje)
                        'ListaViaje = griViaje.DataSource                      
                        'For Each Fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griViajeDetalle.Rows.Where(Function(item) item.Cells("Cliente").Text = "SUPERMERCADOS PERUANOS S.A." Or item.Cells("Cliente").Text = "ALICORP SAA" Or item.Cells("Cliente").Text = "HIPERMERCADOS TOTTUS S.A.")
                        '    Fila.Cells("FleteUnitario").Value = ListaViaje.Sum(Function(Item) Item.FleteUnitario)
                        '    With oeDemandaDetalle
                        '        With Fila
                        '            If Not .Cells("Cantidad").Value.ToString.Trim = "" Or Not IsNumeric(.Cells("Cantidad").Value.ToString) Then
                        '                oeDemandaDetalle.Cantidad = CDbl(.Cells("Cantidad").Value)
                        '            Else
                        '                .Cells("Cantidad").Value = 1
                        '            End If
                        '            If Not .Cells("FleteUnitario").Value.ToString.Trim = "" Or Not IsNumeric(.Cells("FleteUnitario").Value.ToString) Then
                        '                oeDemandaDetalle.FleteUnitario = CDbl(.Cells("FleteUnitario").Value)
                        '            Else
                        '                .Cells("FleteUnitario").Value = 0
                        '            End If
                        '            oeDemandaDetalle.IGV = ValorIgv
                        '            If .Cells("IncluyeIgv").Value = False Then
                        '                .Cells("Flete").Value = oeDemandaDetalle.FleteCalcularSinIgv
                        '            Else
                        '                .Cells("Flete").Value = oeDemandaDetalle.FleteCalcularIgv
                        '            End If
                        '        End With
                        '    End With

                        'Next
                        'griViajeDetalle.UpdateData()
                        'CalcularTotalesDetalle()
                    Case "ViajeVacio"
                        If griViaje.Rows(e.Cell.Row.Index).Cells("ViajeVacio").Value Then
                            CargaVacia = 1
                        End If
                End Select
            Catch ex As Exception
                mensajeEmergente.Problema(ex.Message, True)
            End Try
        End If
    End Sub

    Private Sub griViajeDetalle_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griViajeDetalle.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        If txtIdViaje.Text.Trim <> "" Then
            olOperacion = New l_Operacion
            oeViaje = New e_Viaje
            oeViaje.Id = txtIdViaje.Text
            oeViaje.TipoOperacion = "P"
            oeViaje = olOperacion.ObtenerViaje(oeViaje)
            If CInt(oeViaje.Cantidad) = 0 And CInt(oeViaje.FleteUnitario) = 0 And CInt(oeViaje.IncluyeIgv) = 0 Then
                If MessageBox.Show(Me.Text & ": ¿Desea Eliminar el Registro?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
                    e.Cancel = True
                    Exit Sub
                End If
            Else
                mensajeEmergente.Confirmacion("Carga no se puede eliminar se encuentra en asignada a en otros movimientos", True)
                e.Cancel = True
                Exit Sub
            End If
            'CalcularTotalesDetalle()
        End If
    End Sub

    Private Sub mnuDuplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDuplicar.Click
        DuplicarRegistroDetalleDemanda()
    End Sub

    Private Sub mnuEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEliminar.Click
        If griViajeDetalle.Rows.Count > 0 Then
            griViajeDetalle.ActiveRow.Delete()
        End If
    End Sub

    Private Sub griViaje_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griViaje.BeforeRowsDeleted
        If Operacion = "Nuevo" Or Operacion = "Editar" Then
            e.DisplayPromptMsg = False
            If EliminarViajeSinMje = "" Then
                If MessageBox.Show(Me.Text & ": ¿Desea Eliminar el Registro?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
                    e.Cancel = True
                End If
            End If
            EliminarViajeSinMje = ""
        End If
    End Sub

    Private Sub griDemanda_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griDemanda.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub cboPiloto_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles cboPiloto.EditorButtonClick
        Try
            If cboPiloto.Value <> "0" Then
                MostrarFichaP()
            Else
                Throw New Exception(Me.Text & ": El Piloto no existe")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Private Sub cboCopiloto_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles cboCopiloto.EditorButtonClick
        Try
            If cboCopiloto.Value <> "0" Then
                MostrarFichaC()
            Else
                Throw New Exception(Me.Text & ": El CoPiloto no existe")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboAyudante_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles cboAyudante.EditorButtonClick
        Try
            If cboAyudante.Value <> "0" Then
                MostrarFichaA()
            Else
                Throw New Exception(Me.Text & ": El Ayudante no existe")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        End Try
    End Sub

    Private Sub mt_MostrarVehiculoModal(IdVehiculo As String)
        Try
            Dim FRM As New frm_Vehiculo
            With FRM
                .IdUnidad = IdVehiculo
                .IndConsultaGuardar = False
                .LlenaCombos()
                .pIdActividadNegocio = "1CH000000008" '@0001
                .Editar()
                .StartPosition = FormStartPosition.CenterParent
                .Size = New Size(900, 600)
                .ShowDialog()
                mt_ControlBotoneria()
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub griLista_ClickCellButton(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griLista.ClickCellButton
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Dim Mensaje As String
            olOperacion = New l_Operacion
            olUsuarioPerfil = New l_UsuarioPerfil
            olPerfil = New l_Perfil
            Select Case e.Cell.Column.Key
                Case "Piloto"
                    Dim formulario As frm_FichaPersonal
                    formulario = frm_FichaPersonal
                    formulario.IndCambioPestaña = False
                    If formulario.MostrarTrabajador(griLista.ActiveRow.Cells("IdPiloto").Value) Then formulario.ShowDialog()
                    mt_ControlBotoneria()
                Case "Tracto"
                    mt_MostrarVehiculoModal(griLista.ActiveRow.Cells("IdTracto").Value)
                Case "Carreta"
                    If Not String.IsNullOrWhiteSpace(griLista.ActiveRow.Cells("IdCarreta").Value) Then
                        mt_MostrarVehiculoModal(griLista.ActiveRow.Cells("IdCarreta").Value)
                    End If
                Case "IncidenciaOperaciones"
                    oeViaje = New e_Viaje
                    oeViaje.TipoOperacion = "R"
                    oeViaje.Id = griLista.ActiveRow.Cells("Id").Value
                    Mensaje = griLista.ActiveRow.Cells("IncidenciaOperaciones").Value
                    oeViaje.UsuarioCreacion = gUsuarioSGI.Id
                    oeViaje.Fecha = Date.Now
                    oeViaje.IncidenciaOperaciones = Mensaje
                    oeViaje.PrefijoID = gs_PrefijoIdSucursal '@0001
                    If olOperacion.GuardarViaje(oeViaje) Then mensajeEmergente.Confirmacion(Me.Text & ": La Informacion ha sido grabada Satisfactoriamente; " & Mensaje, True)
                    oeUsuarioPerfil = New e_UsuarioPerfil
                    oeUsuarioPerfil.oeUsuario.Id = gUsuarioSGI.Id
                    oeUsuarioPerfil.Principal = 1
                    oeUsuarioPerfil = olUsuarioPerfil.Obtener(oeUsuarioPerfil)
                    oePerfil = New e_Perfil
                    oePerfil.TipoOperacion = "M"
                    oePerfil.Id = oeUsuarioPerfil.oePerfil.Id
                    oePerfil.Codigo = Mensaje
                    oePerfil.Nombre = "Area: Operaciones Informa, " & "Viaje: " & griLista.ActiveRow.Cells("Codigo").Value & ", Usuario: " & gUsuarioSGI.oePersona.NombreCompleto & ", Dice: " & Mensaje
                    oePerfil.Activo = True
                    oePerfil.PrefijoID = gs_PrefijoIdSucursal '@0001
                    olPerfil.Guardar(oePerfil)
                    ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
                Case "IdEscala"
                    If PerfilAsignado(gNombrePerfilAutorizaOperaciones) Then
                        oeViaje = New e_Viaje
                        oeViaje.TipoOperacion = "V"
                        oeViaje.Id = griLista.ActiveRow.Cells("Id").Value
                        oeViaje.ViajeRetorno = griLista.ActiveRow.Cells("ViajeRetorno").Value
                        oeViaje.PrefijoID = gs_PrefijoIdSucursal '@0001
                        olOperacion.GuardarViaje(oeViaje)
                        mensajeEmergente.Confirmacion("La Informacion ha sido grabada Satisfactoriamente", True)
                        griLista.ActiveRow.CellAppearance.BackColor = Me.colorCambio.Color
                    Else
                        Throw New Exception("Usted no tienes permisos, para ejecutar Jefe Operaciones")
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

    Private Sub griLista_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griLista.InitializeLayout
        e.Layout.Grid.CalcManager = Nothing
        agrListaRegistro.Text = "Lista Registros: " & e.Layout.Rows.Count & Estado
    End Sub

    Private Sub griDemanda_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griDemanda.InitializeLayout
        e.Layout.Grid.CalcManager = Nothing
    End Sub

    Private Sub griViajeDetalle_AfterRowsDeleted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griViajeDetalle.AfterRowsDeleted
        Try
            If Operacion = "Editar" Then
                ListaBitacora.Add(objEliminarDetalle)
            End If
        Catch ex As Exception
            Throw ex
        End Try

        CalcularTotalesDetalle()
    End Sub

    Private Sub verCarreta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verCarreta.CheckedChanged
        If Operacion = "Nuevo" Or Operacion = "Editar" Then
            If verCarreta.Checked Then
                cboCarreta.Enabled = verCarreta.Checked
                '   cboCarreta.Focus()
            Else
                cboCarreta.Enabled = verCarreta.Checked
                cboCarreta.Text = ""
            End If
        End If
    End Sub

    'Private Sub fecAtencionOperacion_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecAtencionOperacion.valuechanged
    '    If Operacion = "Nuevo" Or Operacion = "Editar" Then
    '        oeOperacion.Fecha = fecOperacion.Value
    '    End If

    'End Sub

    Private Sub ficViaje_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ficViaje.Click
        If Operacion = "Editar" Then
            If ficViaje.Tabs(1).Selected = True Then
                txtCarga.Text = griViajeDetalle.Rows.Count
                CalcularTotalesDetalle()
            End If

        End If

    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Try
            If griViaje.Rows.Count > 0 Then
                griViaje.ActiveRow.Delete()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griLista_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griLista.BeforeRowsDeleted
        If gUsuarioSGI.oeArea.Nombre = gNombreAreaCoordinacionSupervisionOperacion Or
            gUsuarioSGI.oeArea.Nombre = gNombreAreaOperaciones Or
            gUsuarioSGI.oeArea.Nombre = gNombreAreaVentas Or
            gUsuarioSGI.oeArea.Nombre = gNombreAreaInformaticaSistemas Or
            gUsuarioSGI.oeArea.Nombre = gNombreAreaSeguridadMedioAmbiente Then
            Try
                e.DisplayPromptMsg = False
                If griLista.ActiveRow.Cells("Estado").Value.ToString.Trim = "PROGRAMADO" Then
                    If EliminarOperaciones(Tipo) Then
                        e.Cancel = False
                    Else
                        e.Cancel = True
                    End If
                Else
                    e.Cancel = True
                    Throw New Exception(griLista.ActiveRow.Cells("Codigo").Value.ToString.Trim & " Se encuentra en Seguimiento")
                End If
            Catch ex As Exception
                e.Cancel = True
                mensajeEmergente.Problema(ex.Message, True)
            End Try
        Else
            e.DisplayPromptMsg = False
            e.Cancel = True
        End If
    End Sub

    Private Sub NroVueltas_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NroVueltas.ValueChanged
        If Not String.IsNullOrEmpty(NroVueltas.Value.ToString) AndAlso IsNumeric(NroVueltas.Value.ToString) Then
            If CInt(NroVueltas.Value) = 0 Then NroVueltas.Value = 1
        Else
            NroVueltas.Value = 1
        End If
    End Sub

    Private Sub griLista_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griLista.CellChange
        griLista.UpdateData()
    End Sub

    Private Sub griLista_BeforeCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeCellUpdateEventArgs) Handles griLista.BeforeCellUpdate
        With griLista
            Select Case e.Cell.Column.Key
                Case "IncidenciaOperaciones"
                    If e.Cell.Column.Key = "IncidenciaOperaciones" Then If IsDBNull(e.NewValue) Then e.Cancel = True
            End Select
        End With
    End Sub

    Private Sub NroTurno_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NroTurno.ValueChanged
        If Not String.IsNullOrEmpty(NroTurno.Value.ToString) AndAlso IsNumeric(NroTurno.Value.ToString) Then
            If CInt(NroTurno.Value) = 0 Then NroTurno.Value = 0
        Else
            NroTurno.Value = 0
        End If
    End Sub

    Private Sub frm_Operacion_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub

    Private Sub btnAgregaEscala_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregaEscala.Click
        Try
            ValidarCombo(cboEscalaBloque, "Escala")
            If OrdenEscala = 0 Then
                OrigenEscala = cboOrigen.Value
                OrdenEscala = 1
            Else
                OrigenEscala = OrigenEscala
            End If

            If ValidaEscala(OrigenEscala) Then
                griEscala.DisplayLayout.Bands(0).AddNew()
                Dim Fila As Integer = griEscala.Rows.Count - 1

                With griEscala.Rows(Fila)
                    .Cells("Orden").Value = OrdenEscala
                    .Cells("Escala").Value = cboEscalaBloque.Value
                    .Cells("GlosaEscala").Value = txtGlosaEscalaBloque.Text
                End With
                OrdenEscala = griEscala.Rows.Count + 1
                OrigenEscala = cboEscalaBloque.Value
                cboEscalaBloque.Focus()
                cboEscalaBloque.Text = ""
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griEscala_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griEscala.CellChange
        griEscala.UpdateData()
    End Sub

    Private Sub verEscalaBloque_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verEscalaBloque.CheckedChanged
        If verEscala.Checked Then
            cboEscalaBloque.Enabled = verEscalaBloque.Checked
            txtGlosaEscalaBloque.Enabled = verEscalaBloque.Checked
            btnAgregaEscala.Enabled = False
        Else
            cboEscalaBloque.Enabled = verEscalaBloque.Checked
            txtGlosaEscalaBloque.Enabled = verEscalaBloque.Checked
            cboEscalaBloque.Text = ""
            txtGlosaEscalaBloque.Text = "Escala: "
            btnAgregaEscala.Enabled = True
        End If
        OperacionEscala = 2
    End Sub

    Private Sub griEscala_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griEscala.BeforeRowsDeleted, griDemanda.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        If MessageBox.Show(Me.Text & ": ¿Desea Eliminar el Registro?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
            Exit Sub
        End If
        OrdenEscala = griEscala.Rows.Count - 1
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        If griEscala.Rows.Count > 0 Then
            griEscala.ActiveRow.Delete()
        End If
    End Sub

    Private Sub txtCantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidad.TextChanged
        If Operacion = "Nuevo" Or Operacion = "Editar" Then
            FleteDetalle()
        End If
    End Sub

    Private Sub CalFleteUnitario_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalFleteUnitario.ValueChanged
        'If Operacion = "Nuevo" Or Operacion = "Editar" Then
        '    CalFleteUnitario.Text = CalFleteUnitario.Text
        'End If

        If Not String.IsNullOrEmpty(CalFleteUnitario.Value) AndAlso IsNumeric(CalFleteUnitario.Value) AndAlso CalFleteUnitario.Value >= 0.0 Then
            If Not CalFleteUnitarioIGV.Focused Then
                CalFleteUnitarioIGV.Value = (CDbl(CalFleteUnitario.Value) + CDbl(CalFleteUnitario.Value) * ValorIgv).ToString("###,##0.000")
                FleteDetalle()
                txtAdelantoFlete.Value = 0
            End If

        Else
            CalFleteUnitario.Value = 0.0
            CalFleteUnitarioIGV.Value = 0.0
            txtFleteTotalDetalle.Value = 0
            txtSubtotal.Text = 0
        End If
    End Sub
    Private Sub CalFleteUnitario_KeyDown(sender As Object, e As KeyEventArgs) Handles CalFleteUnitario.KeyDown
        If Not String.IsNullOrEmpty(CalFleteUnitario.Value) AndAlso IsNumeric(CalFleteUnitario.Value) AndAlso CalFleteUnitario.Value >= 0.0 Then
            CalFleteUnitarioIGV.Value = (CDbl(CalFleteUnitario.Value) + CDbl(CalFleteUnitario.Value) * ValorIgv).ToString("###,##0.000")
            FleteDetalle()
        Else
            CalFleteUnitario.Text = 0.0
        End If
    End Sub

    Private Sub CalFleteUnitario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CalFleteUnitario.KeyPress
        If Not String.IsNullOrEmpty(CalFleteUnitario.Value) AndAlso IsNumeric(CalFleteUnitario.Value) AndAlso CalFleteUnitario.Value >= 0.0 Then
            CalFleteUnitarioIGV.Value = (CDbl(CalFleteUnitario.Value) + CDbl(CalFleteUnitario.Value) * ValorIgv).ToString("###,##0.000")
            FleteDetalle()
        Else
            CalFleteUnitario.Text = 0.0
        End If
    End Sub

    'Private Sub txtFleteUnitario_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtfl
    '    If Operacion = "Nuevo" Or Operacion = "Editar" Then
    '        FleteDetalle()
    '    End If
    'End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Try
            Llena_Detalle_Demanda()
            cboComisionista.Text = "NINGUNO  ,"
            cboTipoCarga.SelectedIndex = -1
            cboMaterial.SelectedIndex = -1
            cboCliente.Focus()
            cboClienteFinal.SelectedIndex = -1
            CalFleteUnitario.Value = 0
            CalFleteUnitarioIGV.Value = 0
            txtCantidad.Text = "1"
            txtFleteTotalDetalle.Text = "0"
            Me.txtComision.Text = "0"
            txtComision.Text = "0"
            Me.txtConsolidado.Text = "0"
            Me.chkConsolidado.Checked = False
            Me.chkCostoEstiva.Checked = False
            Me.txtCostoEstiba.Enabled = False
            Me.txtCostoEstiba.Value = "0"
            Me.chkCostoEstivaDescarga.Checked = False
            Me.txtCostoEstibaDescarga.Enabled = False
            Me.txtCostoEstibaDescarga.Value = "0"
            Me.verCargar.Checked = False
            Me.verDescarga.Checked = False
            Me.verPagoContraEntrega.Checked = False
            Me.verFacturado.Checked = False
            Me.cboCliente.SelectedIndex = -1
            cboMaterial.Value = "1CH000001393"
            Me.cboTipoCarga.Value = "1CH000000001"
            txtSubtotal.Value = 0
            txtFleteTotalDetalle.Value = 0
            '  FleteDetalleGrilla()
            txtRucCLiente.Text = ""
            txtRucComisionista.Text = ""
            CalFleteUnitario.Value = 0
            CalFleteUnitarioIGV.Value = 0
            txtCantidad.Value = 1
            txtSubtotal.Value = 0
            txtFleteTotalDetalle.Value = 0
            txtAdelantoFlete.Value = 0
            verValidaFU.Checked = True
            Me.chkIndFalsoFlete.Checked = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
            EnfocarDetalle(ex.Message)
        End Try
    End Sub

    Private Sub verIncluyeIgv_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verIncluyeIgv.CheckedChanged
        Try
            FleteDetalle()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnConsultarDemanda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultarDemanda.Click
        codigoDemanda = ""
        ListarDemanda()
    End Sub

    Private Sub btnConsultarDisponibles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultarDisponibles.Click
        ListarDisponibilidad(cboVehiculoDisponible.Value)
    End Sub

    Private Sub cboRutaOperacion_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles cboRutaOperacion.EditorButtonClick
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Dim Ruta As New frm_Ruta
            Ruta = Ruta.getInstancia()
            Ruta.MdiParent = frm_Menu
            TipoCliente = 3
            Ruta.Show()
            Ruta.Nuevo()
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub cboCliente_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles cboCliente.EditorButtonClick
        'Try
        '    ugb_Espera.Visible = True
        '    Application.DoEvents()
        '    Cursor.Current = Cursors.WaitCursor
        '    Cursor.Show()
        '    Dim Cliente As New frm_Cliente
        '    TipoCliente = 2
        '    Cliente = Cliente.getInstancia()
        '    Cliente.MdiParent = frm_Menu
        '    Cliente.Show()
        '    Cliente.Nuevo()
        '    ugb_Espera.Visible = False
        'Catch ex As Exception
        '    mensajeEmergente.Problema(ex.Message, True)
        'Finally
        '    Windows.Forms.Cursor.Current = Cursors.Default
        '    Cursor.Show()
        '    ugb_Espera.Visible = False
        'End Try
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            If e.Button.Key = "btnEditarCliente" Then
                If ClientesPublic.Where(Function(Item) Item.Id = cboCliente.Value).Count() > 0 Then
                    codigoCliente = cboCliente.Value
                    Dim IdEmpresa As String
                    TipoCliente = 2
                    oeCliente = New e_Cliente
                    oeCliente.Id = cboCliente.Value
                    oeCliente = olCliente.Obtener(oeCliente)
                    IdEmpresa = oeCliente.IdEmpresa
                    Dim Empresa As New frm_Empresa
                    Empresa = Empresa.getInstancia()
                    Empresa.MdiParent = frm_Menu
                    Empresa.Show()
                    Empresa.AgregarDireccion(IdEmpresa)
                Else
                    TipoCliente = 2
                    Dim Empresa As New frm_Empresa
                    Empresa = Empresa.getInstancia()
                    Empresa.MdiParent = frm_Menu
                    Empresa.Show()
                    ' Empresa.NuevoCliente()

                End If
            Else

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

    Private Sub cboComisionista_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles cboComisionista.EditorButtonClick
        'Try
        '    ugb_Espera.Visible = True
        '    Application.DoEvents()
        '    Cursor.Current = Cursors.WaitCursor
        '    Cursor.Show()
        '    Dim Cliente As New frm_Cliente
        '    TipoCliente = 1
        '    Cliente = Cliente.getInstancia()
        '    Cliente.MdiParent = frm_Menu
        '    Cliente.Show()
        '    Cliente.Nuevo()
        '    ugb_Espera.Visible = False
        'Catch ex As Exception
        '    mensajeEmergente.Problema(ex.Message, True)
        'Finally
        '    Windows.Forms.Cursor.Current = Cursors.Default
        '    Cursor.Show()
        '    ugb_Espera.Visible = False
        'End Try

        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            If e.Button.Key = "btnEditarComisionista" Then
                If ComisionistasPublic.Where(Function(Item) Item.Id = cboComisionista.Value).Count() > 0 Then
                    codigoComisionista = cboComisionista.Value
                    Dim extras = ComisionistasPublic.Item(cboComisionista.SelectedIndex).Extras
                    Dim frmPersona As New frm_Persona
                    frmPersona = frmPersona.getInstancia()
                    frmPersona.MdiParent = frm_Menu
                    frmPersona.Show()
                    frmPersona.AgregarDireccion(extras.Item(4).ToString)
                    'If extras.Count > 0 Then                        
                    '    codigoComisionista = extras.Item(4).ToString
                    'End If
                    'cammm
                Else
                    Dim frmPersona As New frm_Persona
                    frmPersona = frmPersona.getInstancia()
                    frmPersona.MdiParent = frm_Menu
                    frmPersona.Show()
                    frmPersona.NuevaPersona()
                End If
            Else

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

    Private Sub Insert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Insert.Click
        Nuevo()
    End Sub

    Private Sub Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Update.Click
        Editar()
    End Sub

    Private Sub Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete.Click
        Tipo = "E"
        Eliminar()
    End Sub

    Private Sub ProgramarViajeDesdeAquiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Programar.Click
        Try
            Dim IdViaje As String
            olOperacion = New l_Operacion
            IdViaje = griLista.ActiveRow.Cells("Id").Value.ToString().Trim()
            oeViaje = New e_Viaje
            oeViaje.Id = griLista.ActiveRow.Cells("IdTracto").Value.ToString().Trim()
            oeViaje.TipoOperacion = "4"
            'ViajeVacio  = 1 Para Validar Programacion Viaje Correlatividad
            oeViaje.ViajeVacio = 1
            'Agregar para que liste el ultimo viaje asi sea de otra empresa
            oeViaje.Serie = "TODO"
            oeViaje = olOperacion.ObtenerViaje(oeViaje)
            If IdViaje = oeViaje.Id Then
                ProgramarViajeProgramado(IdViaje)
            Else
                If MessageBox.Show("No se puede Programar Viaje desde aqui, porque el último es: " & Environment.NewLine & _
                                   "Viaje: " & oeViaje.Codigo & Environment.NewLine & _
                                   "Fecha Viaje: " & oeViaje.Fecha & Environment.NewLine & _
                                   "Estado: " & oeViaje.Estado & Environment.NewLine & _
                                   "Ruta: " & oeViaje.Origen & " - " & oeViaje.Destino & Environment.NewLine & _
                                   "Desea Programar Viaje desde este Ultimo ?", _
                         "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    ProgramarViajeProgramado(oeViaje.Id)
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub Menu_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Menu.Opening
        If gUsuarioSGI.oeArea.Nombre = gNombreAreaCoordinacionSupervisionOperacion OrElse
            gUsuarioSGI.oeArea.Nombre = gNombreAreaOperaciones OrElse
            gUsuarioSGI.oeArea.Nombre = gNombreAreaInformaticaSistemas OrElse
            gUsuarioSGI.oeArea.Nombre = gNombreAreaSeguridadMedioAmbiente OrElse
            gUsuarioSGI.oeArea.Nombre = gNombreAreaVentas Then
            Menu.Items("Insert").Visible = True
            If griLista.Selected.Rows.Count > 0 Then
                Menu.Items("Update").Visible = True
                Menu.Items("Delete").Visible = True
                Menu.Items("Programar").Visible = True
                Menu.Items("Cancelada").Visible = True
            Else
                Menu.Items("Update").Visible = False
                Menu.Items("Delete").Visible = False
                Menu.Items("Programar").Visible = False
                Menu.Items("Cancelada").Visible = False
            End If
        Else
            Menu.Items("Insert").Visible = False
            Menu.Items("Update").Visible = False
            Menu.Items("Delete").Visible = False
            Menu.Items("Programar").Visible = False
            Menu.Items("Cancelada").Visible = False
        End If
    End Sub

    Private Sub cboRutaOrigen_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRutaOrigen.Validated
        If Operacion = "Nuevo" Then
            RutaIdOrigen = cboRutaOrigen.Value
            cboRutaDestino.Items.Clear()
            olRuta = New l_Ruta
            oeRuta = New e_Ruta
            oeRuta.IdOrigen = RutaIdOrigen
            LlenarComboMaestro(cboRutaDestino, olRuta.Listar(oeRuta), -1)
            cboOrigen.Value = RutaIdOrigen
            cboRutaDestino.Value = RutaIdDestino
            cboDestino.Value = RutaIdDestino
            Try
                If Operacion = "Nuevo" Then
                    oeRuta = New e_Ruta
                    oeRuta.TipoOperacion = "O"
                    oeRuta.IdOrigen = RutaIdOrigen
                    oeRuta = olRuta.Obtener(oeRuta)
                    If oeRuta.Id.Trim <> "" And RutaIdDestino.Trim = "" Then
                        cboTipoVehiculo.Value = oeRuta.Id
                        cboCliente.Value = oeRuta.Codigo
                        cboTipoCarga.Value = oeRuta.IdCentro
                        cboMaterial.Value = oeRuta.IdFlota
                        RutaIdDestino = oeRuta.IdDestino
                        cboRutaDestino.Value = RutaIdDestino
                        cboDestino.Value = RutaIdDestino
                    End If
                End If

            Catch ex As Exception
                mensajeEmergente.Problema(ex.Message, True)
            End Try
            RutaIdDestino = ""
        End If
    End Sub

    Private Sub cboRutaDestino_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRutaDestino.Validated
        If Operacion = "Nuevo" Then
            Try
                RutaIdOrigen = cboRutaOrigen.Value
                RutaIdDestino = cboRutaDestino.Value
                olRuta = New l_Ruta
                oeRuta = New e_Ruta
                oeRuta.IdOrigen = RutaIdOrigen
                oeRuta.IdDestino = RutaIdDestino
                oeRuta = olRuta.Obtener(oeRuta)
                RutaOperacion = oeRuta.Id

                oeRuta = New e_Ruta
                oeRuta.TipoOperacion = "O"
                oeRuta.IdOrigen = RutaIdOrigen
                oeRuta = olRuta.Obtener(oeRuta)
                If oeRuta.Id.Trim <> "" And oeRuta.IdDestino = RutaIdDestino Then
                    cboTipoVehiculo.Value = oeRuta.Id
                    cboCliente.Value = oeRuta.Codigo
                    cboTipoCarga.Value = oeRuta.IdCentro
                    cboMaterial.Value = oeRuta.IdFlota
                    RutaIdDestino = oeRuta.IdDestino
                    cboRutaDestino.Value = RutaIdDestino
                    cboDestino.Value = RutaIdDestino
                End If
                ObtenerFleteUnitario()
            Catch ex As Exception
                mensajeEmergente.Problema(ex.Message, True)
            End Try
            cboDestino.Value = RutaIdDestino
            RutaIdDestino = ""
        End If
    End Sub

    Private Sub cboZonaDisponibles_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboZonaDisponibles.ValueChanged
        cache.ForzarActualizacion = True
    End Sub

    Private Sub cboCliente_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCliente.Validated
        Try
            If Operacion = "Nuevo" Or Operacion = "Editar" Then
            olLugar = New l_Lugar
            ObtenerFleteUnitario()
            If cboCliente.Text = "OTROS" Then
                verPagoContraEntrega.Checked = True
            Else
                verPagoContraEntrega.Checked = False
            End If
            olFlete = New l_Flete
            oeFlete = New e_Flete
            If cboCliente.Text = "SUPERMERCADOS PERUANOS S.A." Then
                If cboRutaOrigen.Text = "CD LURIN (LIMA)" Then
                    oeFlete.TipoOperacion = "L"
                    With griTarifas.DisplayLayout.Bands(0)
                        .Columns("20M3").Header.Caption = "20M3"
                        .Columns("30M3").Header.Caption = "30M3"
                        .Columns("40M3").Header.Caption = "40M3"
                        .Columns("50M3").Header.Caption = "50M3"
                        .Columns("65M3").Header.Caption = "65M3"
                    End With
                    oeFlete.Id = cboCliente.Value
                    griTarifas.DataSource = olFlete.ListarTarifas(oeFlete)

                Else
                    oeFlete.TipoOperacion = "N"
                    With griTarifas.DisplayLayout.Bands(0)
                        .Columns("20M3").Header.Caption = "Furgon"
                        .Columns("30M3").Header.Caption = "Parihuelero"
                        .Columns("40M3").Header.Caption = "Consolidado"
                        .Columns("50M3").Header.Caption = ""
                        .Columns("65M3").Header.Caption = ""
                        .Columns("50M3").Hidden = True
                        .Columns("65M3").Hidden = True
                    End With
                    oeFlete.Id = cboCliente.Value
                    oeLugar = New e_Lugar
                    oeLugar.Id = cboRutaDestino.Value
                    oeLugar = olLugar.Obtener(oeLugar)
                    If oeLugar.IdReferencia.Trim <> "" Then
                        oeFlete.IdRuta = oeLugar.IdReferencia
                    Else
                        oeFlete.IdRuta = cboRutaDestino.Value
                    End If

                    griTarifas.DataSource = olFlete.ListarTarifas(oeFlete)

                End If
            Else
                If cboCliente.Text = "HIPERMERCADOS TOTTUS S.A." Then
                    If cboRutaOrigen.Text = "LIMA (LIMA)" Then
                        oeFlete.TipoOperacion = "H"
                        With griTarifas.DisplayLayout.Bands(0)
                            .Columns("20M3").Header.Caption = "Furgon"
                            .Columns("30M3").Header.Caption = "Furgon Largo"
                            .Columns("40M3").Header.Caption = ""
                            .Columns("50M3").Header.Caption = ""
                            .Columns("65M3").Header.Caption = ""
                        End With
                        oeFlete.Id = cboCliente.Value
                        oeFlete.IdRuta = cboRutaDestino.Value
                        griTarifas.DataSource = olFlete.ListarTarifas(oeFlete)

                    Else
                        oeFlete.TipoOperacion = "T"
                        With griTarifas.DisplayLayout.Bands(0)
                            .Columns("20M3").Header.Caption = "Furgon"
                            .Columns("30M3").Header.Caption = "Parihuelero"
                            .Columns("40M3").Header.Caption = "Devoluciones"
                            .Columns("50M3").Header.Caption = ""
                            .Columns("65M3").Header.Caption = ""
                        End With
                        oeFlete.Id = cboCliente.Value
                        griTarifas.DataSource = olFlete.ListarTarifas(oeFlete)

                    End If
                Else
                    If cboCliente.Text = "MAESTRO PERU S.A." Then
                        If cboRutaOrigen.Text = "LIMA (LIMA)" Then
                            oeFlete.TipoOperacion = "P"
                            With griTarifas.DisplayLayout.Bands(0)
                                .Columns("20M3").Header.Caption = "Furgon"
                                .Columns("30M3").Header.Caption = "Plataformas"
                                .Columns("40M3").Header.Caption = ""
                                .Columns("50M3").Header.Caption = ""
                                .Columns("65M3").Header.Caption = ""
                            End With
                            oeFlete.Id = cboCliente.Value
                            griTarifas.DataSource = olFlete.ListarTarifas(oeFlete)
                        End If

                    End If
                End If
            End If
        End If
            If Me.cboCliente.Value <> "" Then
                Me.txtRucCLiente.Text = ClientesPublic.Item(cboCliente.SelectedIndex).Descripcion
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboTipoCarga_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoCarga.Validated
        If Operacion = "Nuevo" Or Operacion = "Editar" Then
            ObtenerFleteUnitario()
        End If
    End Sub

    Dim listAModFx As New List(Of e_Combo)
    Private Sub cboTipoVehiculo_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoVehiculo.Validated
        'If Operacion = "Nuevo" Or Operacion = "Editar" Then
        '    ObtenerFleteUnitario()
        '    If cboTipoVehiculo.Text = "PARIHUELERO" Then cboTipoCarga.Text = "VIAJE"
        'End If
        'Try
        '    LlenarCboTipoVehiculo()

        '    If Me.chkMotriz.Checked Then
        '        verCarreta.Checked = False
        '        ' verCarreta.Enabled = False
        '        listAModFx = TractoPublic.Where(Function(Item) Item.Descripcion = 1 Or Item.Descripcion = 3 And Item.Extras.Item(0).ToString = Me.cboTipoVehiculo.Value).ToList
        '        cboTracto.DataSource = listAModFx
        '        cboTracto.SelectedIndex = 0
        '        'cargar combo tracto          
        '    Else
        '        verCarreta.Checked = True
        '        ' verCarreta.Enabled = True
        '        listAModFx = New List(Of e_Combo)
        '        listAModFx = CarretaPublic.Where(Function(item) item.Extras.Item(0).ToString = Me.cboTipoVehiculo.Value).ToList
        '        cboCarreta.DataSource = listAModFx
        '        cboCarreta.Text = ""

        '        If listAModFx.Count > 0 Then
        '            cboCarreta.SelectedIndex = 0
        '            cboCarreta.Value = listAModFx.Item(0).Id
        '        End If
        '        'list = TractoPublic.Where(Function(Item) Item.Descripcion = 1 Or Item.Descripcion = 3 And Item.Extras.Item(0).ToString = "1CH000000001").ToList
        '        '  list = TractoPublic.Where(Function(Item) Item.Descripcion = 1 Or Item.Descripcion = 3).ToList
        '        '  cboTracto.DataSource = list
        '        '  cboTracto.SelectedIndex = 0
        '        ' pedir tracto
        '    End If
        '    'If list.Count > 0 Then
        '    '    cboTracto.SelectedIndex = 0
        '    'End If
        'Catch ex As Exception
        '    Throw ex
        'End Try
    End Sub

    Private Sub cboTracto_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboTracto.Validating
        'If Operacion = "Nuevo" Or Operacion = "Editar" Then
        '    olVehiculo = New l_Vehiculo
        '    oeVehiculo = New e_Vehiculo
        '    oeVehiculo.TipoOperacion = "A"
        '    If verCarreta.Checked Then
        '        oeVehiculo.Id = cboCarreta.Value
        '    Else
        '        oeVehiculo.Id = cboTracto.Value
        '    End If
        '    oeVehiculo = olVehiculo.Obtener(oeVehiculo)
        '    '  cboTipoVehiculo.Value = oeVehiculo.IdModeloFuncional
        '    '   FlotaTracto = cboTipoVehiculo.Text.Trim
        '    cboTractoPeso.Value = cboTracto.Value
        '    txtTaraTracto.Text = oeVehiculo.Tara

        '    olBonificacion = New l_Bonificacion
        '    oeBonificacion = New e_Bonificacion
        '    oeBonificacion.IdVehiculo = cboTractoPeso.Value
        '    If cboTracto.Value <> "" Then
        '        griBonificacionTracto.DataSource = olBonificacion.Listar(oeBonificacion)
        '    End If


        '    'Actualizar el flete unitario si se actualiza la placa del vehículo
        '    If griViajeDetalle.Rows.Count = 0 Then
        '        ObtenerFleteUnitario()
        '        txtFlete.Text = txtFleteTotalDetalle.Text
        '    End If
        '    'lblFlota.Text = "FLOTA: " & FlotaTracto
        'End If
    End Sub

    Private Sub griViaje_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griViaje.InitializeLayout
        e.Layout.Grid.CalcManager = Nothing
    End Sub

    Private Sub griEscala_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griEscala.InitializeLayout
        e.Layout.Grid.CalcManager = Nothing
    End Sub

    Private Sub verTracto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verTracto.CheckedChanged
        If Operacion = "Inicializa" Then
            If verTracto.Checked Then
                cboTractoLista.Enabled = verTracto.Checked
                verCarretaLista.Checked = False
                cboTractoLista.Focus()
            Else
                cboTractoLista.Enabled = verTracto.Checked
                cboTractoLista.Text = ""
            End If
        End If
    End Sub

    Private Sub Cancelada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelada.Click
        Try
            Tipo = "D"
            griLista.ActiveRow.Delete()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub verViajeVacio_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verViajeVacio.Validated
        Try
            olOperacion = New l_Operacion
            If (Operacion = "Nuevo" Or Operacion = "Editar") AndAlso verViajeVacio.Checked AndAlso griViajeDetalle.Rows.Count = 0 Then
                'If verViajeVacio.Checked Then
                'If griViajeDetalle.Rows.Count = 0 Then
                oeOperacionDetalle = New e_OperacionDetalle
                oeOperacionDetalle.TipoOperacion = "2"
                oeOperacionDetalle.Cliente = gs_IdClienteProveedorSistema.Trim '@0001
                griViajeDetalle.DataSource = olOperacion.ListarOperacionDetalle(oeOperacionDetalle)
                For Each Fila As UltraGridRow In griViajeDetalle.Rows
                    Fila.Cells("Origen").Value = cboRutaOrigen.Value
                    Fila.Cells("Destino").Value = cboRutaDestino.Value
                Next
                'End If
                'End If
                'Else
                'If Operacion = "Editar" Then
                '    If verViajeVacio.Checked = True Then
                '        If griViajeDetalle.Rows.Count = 0 Then
                '            oeOperacionDetalle = New e_OperacionDetalle
                '            oeOperacionDetalle.TipoOperacion = "2"
                '            oeOperacionDetalle.Cliente = ISL_IdClienteProveedor
                '            griViajeDetalle.DataSource = olOperacion.ListarOperacionDetalle(oeOperacionDetalle)
                '            For Each Fila As UltraGridRow In griViajeDetalle.Rows
                '                Fila.Cells("Origen").Value = cboRutaOrigen.Value
                '                Fila.Cells("Destino").Value = cboRutaDestino.Value
                '            Next
                '        End If
                '    End If
                'End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboEscalaBloque_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles cboEscalaBloque.InitializeLayout
        With cboEscalaBloque.DisplayLayout.Bands(0)
            .Columns("Id").Hidden = True
            '.Columns("IdUbigeo").Hidden = True
            .Columns("Nombre").Hidden = False
            .Columns("Descripcion").Hidden = True
            '.Columns("Abreviatura").Hidden = True
            '.Columns("Activo").Hidden = True
            '.Columns("Codigo").Hidden = True
            '.Columns("TipoRuta").Hidden = True
            .Columns("Nombre").Width = 300
        End With
    End Sub

    Private Sub cboEscalaBloque_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboEscalaBloque.KeyDown
        With CType(sender, Infragistics.Win.UltraWinGrid.UltraCombo)
            If e.KeyData = Keys.Delete Then
                .Text = ""
            End If
        End With

        If e.KeyCode = Keys.Enter Then
            If cboEscalaBloque.Text.Trim = "" Then
                cboEscalaBloque.DataSource = Nothing
                cboEscalaBloque.DataSource = LugaresPublic
            Else
                cboEscalaBloque.DataSource = Nothing
                ListaEscala = New List(Of e_Combo)
                ListaEscala = LugaresPublic
                cboEscalaBloque.DataSource = ListaEscala.Where(Function(Item) Item.Nombre.Contains(cboEscalaBloque.Text.Trim)).ToList
            End If
        End If
    End Sub

    Private Sub cboEscalaBloque_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboEscalaBloque.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            cboEscalaBloque.PerformAction(UltraComboAction.Dropdown)
        End If
    End Sub

    Private Sub griBonificacionTracto_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griBonificacionTracto.InitializeLayout
        e.Layout.Grid.CalcManager = Nothing
    End Sub

    Private Sub griBonificacionCarreta_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griBonificacionCarreta.InitializeLayout
        e.Layout.Grid.CalcManager = Nothing
    End Sub

    Private Sub griBonificacionTracto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griBonificacionTracto.Click
        If griBonificacionTracto.Rows.Count > 0 Then
            txtCapacidadUtil.Text = oeVehiculo.CapacidadUtil(CDbl(txtTaraTracto.Value), CDbl(txtTaraCarreta.Value), CDbl(griBonificacionTracto.ActiveRow.Cells("Numero").Value))
            txtViajeCapacidadUtil.Text = txtCapacidadUtil.Text
            txtBonificacionTracto.Text = griBonificacionTracto.ActiveRow.Cells("Numero").Value
        End If
    End Sub

    Private Sub cboTractoPeso_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboTractoPeso.Validating
        olBonificacion = New l_Bonificacion
        oeBonificacion = New e_Bonificacion
        oeBonificacion.IdVehiculo = cboTractoPeso.Value
        If cboTracto.Value <> "" Then
            griBonificacionTracto.DataSource = olBonificacion.Listar(oeBonificacion)
        End If


        olVehiculo = New l_Vehiculo
        oeVehiculo = New e_Vehiculo
        oeVehiculo.TipoOperacion = "A"
        oeVehiculo.Id = cboTractoPeso.Value
        oeVehiculo = olVehiculo.Obtener(oeVehiculo)
        txtTaraTracto.Text = oeVehiculo.Tara
    End Sub

    Private Sub cboCarretaPeso_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboCarretaPeso.Validating
        olBonificacion = New l_Bonificacion
        oeBonificacion = New e_Bonificacion
        oeBonificacion.IdVehiculo = cboCarretaPeso.Value
        If cboCarretaPeso.Value <> "" Then
            griBonificacionCarreta.DataSource = olBonificacion.Listar(oeBonificacion)
        End If


        olVehiculo = New l_Vehiculo
        oeVehiculo = New e_Vehiculo
        oeVehiculo.TipoOperacion = "A"
        oeVehiculo.Id = cboCarretaPeso.Value
        oeVehiculo = olVehiculo.Obtener(oeVehiculo)
        txtTaraCarreta.Text = oeVehiculo.Tara
    End Sub

    Private Sub btnCapacidadUtil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCapacidadUtil.Click
        If griBonificacionTracto.Rows.Count > 0 Then
            txtBonificacionTracto.Text = griBonificacionTracto.ActiveRow.Cells("Numero").Value
            txtCapacidadUtil.Text = oeVehiculo.CapacidadUtil(CDbl(txtTaraTracto.Value), CDbl(txtTaraCarreta.Value), CDbl(txtBonificacionTracto.Text))
        End If
    End Sub

    Private Sub cboCarreta_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCarreta.Leave
        tabAdicional.Tabs(0).Selected = True
    End Sub

    Private Sub verValidaciones_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verValidaciones.Validated
        If verValidaciones.Checked = False Then
            If Not PerfilAsignado(gNombrePerfilAutorizaOperaciones) Then
                If MessageBox.Show("No esta autorizado para quitar las validaciones" & Environment.NewLine & _
                                    "viajes sin validaciones comuniquese con el " & gNombrePerfilJefeOperaciones & Environment.NewLine & _
                                    "Desea Seguir Programando Viajes:  ?", _
                                    "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    IncidenciasPublic = New e_IncidenciasAutentificadas
                    Dim formulario As frm_Autorizacion
                    formulario = frm_Autorizacion
                    If formulario.ObtenerJefes(gNombrePerfilAutorizaOperaciones, "frm_Operacion1", pIdActividadNegocio) Then formulario.ShowDialog()
                    If IncidenciasPublic.IdResponsableAutoriza.Trim = "" Then
                        verValidaciones.Checked = True
                    End If
                Else
                    verValidaciones.Checked = True
                End If
            End If
        End If
    End Sub

    'Private Sub verValidaFU_Validated(sender As System.Object, e As System.EventArgs) Handles verValidaFU.Validated
    '    If verValidaFU.Checked = False Then
    '        If Not PerfilAsignado(gNombrePerfilAutorizaTarifas) Then
    '            If MessageBox.Show("No esta autorizado para quitar las validaciones" & Environment.NewLine & _
    '                                "viajes sin validaciones comuniquese con el " & gNombrePerfilJefeOperaciones & Environment.NewLine & _
    '                                "Desea Seguir Programando Viajes:  ?", _
    '                                "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
    '                IncidenciasPublic = New e_IncidenciasAutentificadas
    '                Dim formulario As frm_Autorizacion
    '                formulario = frm_Autorizacion
    '                If formulario.ObtenerJefes(gNombrePerfilAutorizaTarifas, "frm_Operacion1", pIdActividadNegocio) Then formulario.ShowDialog()
    '                If IncidenciasPublic.IdResponsableAutoriza.Trim = "" Then
    '                    verValidaFU.Checked = True
    '                    CalFleteUnitario.Enabled = False
    '                Else
    '                    verValidaFU.Checked = False
    '                    CalFleteUnitario.Enabled = True
    '                End If
    '            Else
    '                verValidaFU.Checked = True
    '            End If
    '        End If
    '    Else
    '        CalFleteUnitario.Enabled = False
    '    End If
    'End Sub

    Private Sub verViajeRetorno_Validated(sender As Object, e As EventArgs) Handles verViajeRetorno.Validated
        Try
            olOperacion = New l_Operacion
            If Operacion = "Nuevo" Then
                If verViajeRetorno.Checked Then
                    If griViajeDetalle.Rows.Count = 0 Then
                        oeOperacionDetalle = New e_OperacionDetalle
                        oeOperacionDetalle.TipoOperacion = "2"
                        If cboActividadNegocio.Text.Trim = "" Then
                            mensajeEmergente.Confirmacion("Seleccione la actividad para el viaje de retorno", True)
                            verViajeRetorno.Checked = False
                            cboActividadNegocio.Focus()
                            Exit Sub
                        End If
                        oeOperacionDetalle.IdOperacion = cboActividadNegocio.Value
                        griViajeDetalle.DataSource = olOperacion.ListarOperacionDetalle(oeOperacionDetalle)
                        For Each Fila As UltraGridRow In griViajeDetalle.Rows
                            Fila.Cells("Origen").Value = cboRutaOrigen.Value
                            Fila.Cells("Destino").Value = cboRutaDestino.Value
                        Next
                    End If
                End If
            Else
                If Operacion = "Editar" Then
                    If verViajeRetorno.Checked = True Then
                        If griViajeDetalle.Rows.Count = 0 Then
                            oeOperacionDetalle = New e_OperacionDetalle
                            oeOperacionDetalle.TipoOperacion = "2"
                            If cboActividadNegocio.Text.Trim = "" Then
                                mensajeEmergente.Confirmacion("Seleccione la actividad para el viaje de retorno", True)
                                verViajeRetorno.Checked = False
                                cboActividadNegocio.Focus()
                                Exit Sub
                            End If
                            oeOperacionDetalle.IdOperacion = cboActividadNegocio.Value
                            griViajeDetalle.DataSource = olOperacion.ListarOperacionDetalle(oeOperacionDetalle)
                            For Each Fila As UltraGridRow In griViajeDetalle.Rows
                                Fila.Cells("Origen").Value = cboRutaOrigen.Value
                                Fila.Cells("Destino").Value = cboRutaDestino.Value
                            Next
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboActividadNegocio_Validated(sender As Object, e As EventArgs) Handles cboActividadNegocio.Validated
        If cboActividadNegocio.Text.Trim <> "" Then
            olRuta = New l_Ruta
            oeRuta = New e_Ruta
            oeRuta.TipoOperacion = "O"
            oeRuta.IdOrigen = cboActividadNegocio.Value
            oeRuta = olRuta.Obtener(oeRuta)
            If oeRuta.Id.Trim <> "" Then
                cboTipoVehiculo.Value = oeRuta.Id
                cboCliente.Value = oeRuta.Codigo
                cboTipoCarga.Value = oeRuta.IdCentro
                cboMaterial.Value = oeRuta.IdFlota
            End If
            ObtenerFleteUnitario()
        End If
    End Sub

    Private Sub btnAgregarTerc_Click(sender As Object, e As EventArgs) Handles btnAgregarTerc.Click
        Try
            ValidarCombo(cboTercero, "Tercero")
            If numFleteTotalTerc.Value > 0 Then
                If numFleteTotalTerc.Value < txtFTotalOperacion.Value Then
                    'oeOperacion.oeContratoTercero = griDetalleTercero.DataSource
                    'oeContratoTercero = New e_ViajesTerceros
                    'With oeContratoTercero
                    '    .IdTercero = cboTercero.Value
                    '    .IdContacto = cboContacto.Value
                    '    .IdMoneda = cboMonedaT.Value
                    '    .FleteUnitario = numFleteUnitarioTerc.Value
                    '    .Igv = numIgvTerc.Value
                    '    .TotalFlete = numFleteTotalTerc.Value
                    '    .SubTotal = numSubTotalTercero.Value
                    '    .SaldoFlete = 0
                    '    .AdelantoFlete = 0
                    '    .Comision = numComisionTerc.Value
                    '    .SaldoComision = 0
                    '    .IndFacturado = 0
                    '    .IndOperacion = 0
                    '    .IdMovimientoDocumento = ""
                    '    .Glosa = txtReferenciaTercero.Text.Trim
                    '    .Observacion = txtObservacionTercero.Text.Trim
                    '    .Cantidad = numCantidadTercero.Value
                    'End With
                    'oeOperacion.oeContratoTercero.Add(oeContratoTercero)
                    'griDetalleTercero.DataBind()
                    'cboTercero.Focus()
                    'cboTercero.SelectedIndex = -1
                    'numFleteUnitarioTerc.Value = 0
                    'numIgvTerc.Value = 0
                    'numSubTotalTercero.Value = 0
                    'numFleteTotalTerc.Value = 0
                    'numCantidadTercero.Value = 1
                    'cboContacto.SelectedIndex = -1
                    'txtNombreContacto.Text = ""
                    'txtApellidoPaternoContacto.Text = ""
                    'txtApellidoMaternoContacto.Text = ""
                    'txtRucContacto.Text = ""
                    'txtTelefonoContacto.Text = ""
                    oeOperacion.oeContratoTercero = griDetalleTercero.DataSource
                    With oeContratoTercero
                        .IdTercero = cboTercero.Value
                        .IdContacto = cboContacto.Value
                        .IdMoneda = cboMonedaT.Value
                        .FleteUnitario = numFleteUnitarioTerc.Text
                        .Igv = numIgvTerc.Text
                        .TotalFlete = numFleteTotalTerc.Text
                        .SaldoFlete = 0
                        .AdelantoFlete = 0
                        .Comision = numComisionTerc.Text
                        .SaldoComision = 0
                        .IndFacturado = 0
                        .IndOperacion = 0
                        .IdMovimientoDocumento = ""
                        .Glosa = txtReferenciaTercero.Text.Trim
                        .Observacion = txtObservacionTercero.Text.Trim
                        .Cantidad = numCantidadTercero.Value
                        .SubTotal = numSubTotalTercero.Value
                        .PrefijoID = gs_PrefijoIdSucursal '@0001
                    End With
                    oeOperacion.oeContratoTercero.Add(oeContratoTercero)
                    griDetalleTercero.DataBind()
                    oeContratoTercero = New e_ViajesTerceros
                    '    cboContacto.Text = "NINGUNO  ,"
                    cboTercero.Focus()
                    numFleteUnitarioTerc.Value = 0
                    numIgvTerc.Value = 0
                    numSubTotalTercero.Value = 0
                    numFleteTotalTerc.Value = 0
                    numCantidadTercero.Value = 1
                    cboTercero.SelectedIndex = -1
                    cboContacto.SelectedIndex = -1
                    txtNombreContacto.Text = ""
                    txtApellidoPaternoContacto.Text = ""
                    txtApellidoMaternoContacto.Text = ""
                    txtRucContacto.Text = ""
                    txtTelefonoContacto.Text = ""
                Else
                    numFleteUnitarioTerc.Focus()
                    Throw New Exception("Flete ingresado de tercero es mayor al Flete por Cobrar a Cliente")
                End If
            Else
                numFleteUnitarioTerc.Focus()
                Throw New Exception("Ingrese Flete Unitario segun Contrato")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub numFleteUnitarioTerc_TextChanged(sender As Object, e As EventArgs) Handles numFleteUnitarioTerc.TextChanged
        Try
            If Operacion = "Nuevo" Or Operacion = "Editar" Then
                If IsNumeric(numFleteUnitarioTerc.Text) = False Then
                    numFleteUnitarioTerc.Text = 0
                End If
                FleteTotalTercero()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griDetalleTercero_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griDetalleTercero.BeforeRowsDeleted
        Try
            e.DisplayPromptMsg = False
            If griDetalleTercero.ActiveRow.Cells("IndOperacion").Value <> 0 Then
                e.Cancel = True
                Throw New Exception("No puede eliminar detalle tiene relacion en otras areas")
            Else
                If MessageBox.Show("¿Desea Eliminar el Registro?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
                    e.Cancel = True
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griDetalleTercero_CellChange(sender As Object, e As CellEventArgs) Handles griDetalleTercero.CellChange
        Try
            griDetalleTercero.UpdateData()
            FleteDetalleGrillaTercero()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub DetalleContratoTercero_Click(sender As Object, e As EventArgs) Handles DetalleContratoTercero.Click
        griDetalleTercero.ActiveRow.Delete()
    End Sub

    Private Sub griListaTerceros_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles griListaTerceros.InitializeLayout
        e.Layout.Grid.CalcManager = Nothing
    End Sub

    Private Sub griViajesProceso_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles griViajesProceso.InitializeLayout
        e.Layout.Grid.CalcManager = Nothing
    End Sub

    Private Sub verCarretaLista_CheckedChanged(sender As Object, e As EventArgs) Handles verCarretaLista.CheckedChanged
        If Operacion = "Inicializa" Then
            If verCarretaLista.Checked Then
                cboCarretaLista.Enabled = verCarretaLista.Checked
                verTracto.Checked = False
                cboCarretaLista.Focus()
            Else
                cboCarretaLista.Enabled = verCarretaLista.Checked
                cboCarretaLista.Text = ""
            End If
        End If
    End Sub

    Private Sub verPilotoLista_CheckedChanged(sender As Object, e As EventArgs) Handles verPilotoLista.CheckedChanged
        If Operacion = "Inicializa" Then
            If verPilotoLista.Checked Then
                cboPilotoLista.Enabled = verPilotoLista.Checked
                cboPilotoLista.Focus()
            Else
                cboPilotoLista.Enabled = verPilotoLista.Checked
                cboPilotoLista.Text = ""
            End If
        End If
    End Sub

    Private Sub griListaTerceros_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griListaTerceros.BeforeRowsDeleted
        e.Cancel = True
        e.DisplayPromptMsg = False
    End Sub

    Private Sub numCantidadTercero_TextChanged(sender As Object, e As EventArgs) Handles numCantidadTercero.TextChanged
        Try
            If Operacion = "Nuevo" Or Operacion = "Editar" Then
                FleteTotalTercero()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub expGeneral_ExpandedStateChanged(sender As Object, e As EventArgs) Handles expGeneral.ExpandedStateChanged
        Try
            If Me.expGeneral.Expanded Then
                Me.expVehiculo.Expanded = False
            Else
                Me.expVehiculo.Expanded = True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub expVehiculo_ExpandedStateChanged(sender As Object, e As EventArgs) Handles expVehiculo.ExpandedStateChanged
        'Try
        '    If Me.expVehiculo.Expanded Then
        '        Me.expGeneral.Expanded = False
        '    Else
        '        Me.expGeneral.Expanded = True
        '    End If
        'Catch ex As Exception
        '    Throw ex
        'End Try
    End Sub

    Private Sub griDisponibleVehiculo_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griDisponibleVehiculo.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub griDisponibleVehiculo_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles griDisponibleVehiculo.InitializeLayout
        ' e.DisplayPromptMsg = False        
        e.Layout.Grid.CalcManager = Nothing
    End Sub

    Private Sub griDisponibleVehiculo_ClickCellButton(sender As Object, e As CellEventArgs) Handles griDisponibleVehiculo.ClickCellButton
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            olOperacion = New l_Operacion
            Select Case e.Cell.Column.Key
                Case "Piloto"
                    Dim formulario As frm_FichaPersonal
                    formulario = frm_FichaPersonal
                    If formulario.MostrarTrabajador(griDisponibleVehiculo.ActiveRow.Cells("IdPiloto").Value) Then formulario.ShowDialog()
                    ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
                Case "GlosaEscala"
                    oeViaje = New e_Viaje
                    oeViaje.TipoOperacion = "C"
                    oeViaje.Id = griDisponibleVehiculo.ActiveRow.Cells("Id").Value
                    oeViaje.UsuarioCreacion = gUsuarioSGI.Id
                    oeViaje.Fecha = Date.Now
                    oeViaje.GlosaEscala = griDisponibleVehiculo.ActiveRow.Cells("GlosaEscala").Value
                    oeViaje.PrefijoID = gs_PrefijoIdSucursal '@0001
                    If olOperacion.GuardarViaje(oeViaje) Then mensajeEmergente.Confirmacion(Me.Text & ": La Informacion ha sido grabada Satisfactoriamente; " & griDisponibleVehiculo.ActiveRow.Cells("GlosaEscala").Value, True)
                    ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
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

    Private Sub griDisponibleVehiculo_BeforeCellUpdate(sender As Object, e As BeforeCellUpdateEventArgs) Handles griDisponibleVehiculo.BeforeCellUpdate
        With griDisponibleVehiculo
            Select Case e.Cell.Column.Key
                Case "GlosaEscala"
                    If e.Cell.Column.Key = "GlosaEscala" Then If IsDBNull(e.NewValue) Then e.Cancel = True
            End Select
        End With
    End Sub

    Private Sub griDisponibleVehiculo_CellChange(sender As Object, e As CellEventArgs) Handles griDisponibleVehiculo.CellChange
        Try
            griDisponibleVehiculo.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griViajeDetalle_CellChange(sender As Object, e As CellEventArgs) Handles griViajeDetalle.CellChange
        If Operacion = "Nuevo" Or Operacion = "Editar" Then
            Try
                griViajeDetalle.UpdateData()
                Select Case e.Cell.Column.Key
                    Case "Cantidad"
                        FleteDetalleGrilla()
                        CalcularTotalesDetalle()
                    Case "FleteUnitario"
                        FleteDetalleGrilla()
                        CalcularTotalesDetalle()
                    Case "IncluyeIgv"
                        FleteDetalleGrilla()
                        CalcularTotalesDetalle()
                    Case "Consolidado"
                        CalcularTotalesDetalle()
                End Select
                FleteDetalleGrilla()
                CalcularTotalesDetalle()
                Dim indice = griViajeDetalle.ActiveRow.Cells("Cantidad").Value.ToString.LastIndexOf(".")
                Dim num
                With griViajeDetalle.ActiveRow
                    num = Math.Truncate(CDbl(.Cells("Cantidad").Value.ToString))
                    If .Cells("TipoCarga").Value = "VIAJE" And num <> CDbl(.Cells("cantidad").Value.ToString) Then
                        .Cells("Cantidad").Value = 1
                        Throw New Exception("Tipo de carga VIAJE, debe ingresar valores enteros")
                    End If
                    If .Cells("Comisionista").Value.ToString.Contains("NINGUNO") Then
                        .Cells("Comision").Value = 0
                    End If
                End With
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub griViajeDetalle_KeyDown(sender As Object, e As KeyEventArgs) Handles griViajeDetalle.KeyDown
        If Operacion = "Nuevo" Or Operacion = "Editar" Then
            Try
                If e.KeyValue = 13 Then
                    With griViajeDetalle
                        Select Case .ActiveRow.Cells(.ActiveCell.Column.Index).Column.Key
                            Case "Cliente"
                                .PerformAction(UltraGridAction.NextCellByTab)
                            Case "Carga"
                                .PerformAction(UltraGridAction.NextCellByTab)
                            Case "Cantidad"
                                FleteDetalleGrilla()
                                With .Rows(.ActiveRow.Index)
                                    If .Cells("Cantidad").Value.ToString.Length = 0 Or Not IsNumeric(.Cells("Cantidad").Value.ToString) Then
                                        .Cells("Cantidad").Value = 1.0
                                        Throw New Exception("Ingrese Cantidad")
                                    End If
                                    If .Cells("Cantidad").Value = 0 Or Not IsNumeric(.Cells("Cantidad").Value.ToString) Then
                                        .Cells("Cantidad").Value = 1.0
                                        Throw New Exception("Cantidad no Puede ser 0")
                                    End If

                                End With
                                .PerformAction(UltraGridAction.NextCellByTab)
                            Case "IncluyeIgv"
                                With .Rows(.ActiveRow.Index)
                                    'If .Cells("IncluyeIgv").Value = False Then
                                    '    .Cells("Facturado").Value = True
                                    'Else
                                    '    .Cells("Facturado").Value = False
                                    'End If
                                    FleteDetalleGrilla()
                                End With
                                '.PerformAction(UltraGridAction.NextCellByTab)
                            Case "FleteUnitario"
                                FleteDetalleGrilla()
                                With .Rows(.ActiveRow.Index)
                                    If .Cells("FleteUnitario").Value.ToString.Length = 0 Then Throw New Exception("Ingrese Flete Unitario")
                                End With
                                .PerformAction(UltraGridAction.NextCellByTab)
                            Case "Consolidado"
                                With .Rows(.ActiveRow.Index)
                                    If .Cells("Consolidado").Value.ToString.Length = 0 Then Throw New Exception("Ingrese Consolidado")
                                End With
                                .PerformAction(UltraGridAction.NextCellByTab)
                            Case "Facturado"
                                With .Rows(.ActiveRow.Index)
                                    If .Cells("Facturado").Value = False Then
                                        .Cells("Facturado").Value = True
                                    Else
                                        .Cells("Facturado").Value = False
                                    End If
                                End With
                                '.PerformAction(UltraGridAction.NextCellByTab)
                            Case "PagoContraEntrega"
                                With .Rows(.ActiveRow.Index)
                                    If .Cells("PagoContraEntrega").Value = False Then
                                        .Cells("PagoContraEntrega").Value = True
                                    Else
                                        .Cells("PagoContraEntrega").Value = False
                                    End If
                                End With
                                '.PerformAction(UltraGridAction.NextCellByTab)
                            Case "Material"
                                .PerformAction(UltraGridAction.NextCellByTab)
                            Case "Moneda"
                                .PerformAction(UltraGridAction.NextCellByTab)
                                .PerformAction(UltraGridAction.NextCellByTab)
                            Case "Comisionista"
                                .PerformAction(UltraGridAction.NextCellByTab)
                            Case "Comision"
                                With .Rows(.ActiveRow.Index)
                                    If .Cells("Comision").Value.ToString.Length = 0 Then Throw New Exception("Ingrese Comision")
                                End With
                                .PerformAction(UltraGridAction.NextCellByTab)
                        End Select
                    End With
                End If
            Catch ex As Exception
                mensajeEmergente.Confirmacion(ex.Message, True)
            End Try
        End If
    End Sub

    Private Sub expListaDemandas_ExpandedStateChanged(sender As Object, e As EventArgs) Handles expListaDemandas.ExpandedStateChanged
        Try
            If expListaDemandas.Expanded Then
                Me.expNuevaCarga.Expanded = False
            Else
                Me.expNuevaCarga.Expanded = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub expNuevaCarga_ExpandedStateChanged(sender As Object, e As EventArgs) Handles expNuevaCarga.ExpandedStateChanged
        If Me.expNuevaCarga.Expanded Then
            Me.expListaDemandas.Expanded = False
        Else
            Me.expListaDemandas.Expanded = True
        End If
    End Sub

    Private Sub cboCliente_ValueChanged(sender As Object, e As EventArgs) Handles cboCliente.ValueChanged
        If Me.cboCliente.Value <> "" Then
            Me.cboClienteFinal.Value = Me.cboCliente.Value
        End If
    End Sub

    Private Sub chkConsolidado_CheckedChanged(sender As Object, e As EventArgs) Handles chkConsolidado.CheckedChanged
        Try
            If Me.chkConsolidado.Checked = True Then
                Me.txtConsolidado.Enabled = True
                Me.txtConsolidado.Text = "0"
                Me.txtMotivoConsolidado.Enabled = True
            Else
                Me.txtConsolidado.Enabled = False
                Me.chkIGVConsolidado.Checked = False
                Me.txtMotivoConsolidado.Enabled = False
                Me.txtMotivoConsolidado.Text = ""
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub chkCostoEstiva_CheckedChanged(sender As Object, e As EventArgs) Handles chkCostoEstiva.CheckedChanged
        Try
            If Me.chkCostoEstiva.Checked Then
                Me.txtCostoEstiba.Enabled = True
            Else
                Me.txtCostoEstiba.Enabled = False
                Me.txtCostoEstiba.Value = 0
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub chkCostoEstivaDescarga_CheckedChanged(sender As Object, e As EventArgs) Handles chkCostoEstivaDescarga.CheckedChanged
        If Me.chkCostoEstivaDescarga.Checked Then
            Me.txtCostoEstibaDescarga.Enabled = True
        Else
            Me.txtCostoEstibaDescarga.Enabled = False
            Me.txtCostoEstibaDescarga.Value = 0
        End If
    End Sub

    Private Sub CalFleteUnitarioIGV_Enter_1(sender As Object, e As EventArgs) Handles CalFleteUnitarioIGV.Enter
        If Not String.IsNullOrEmpty(CalFleteUnitarioIGV.Value) AndAlso IsNumeric(CalFleteUnitarioIGV.Value) AndAlso CalFleteUnitarioIGV.Value >= 0.0 Then
            CalFleteUnitario.Value = (CDbl(CalFleteUnitarioIGV.Value.Trim) / (1 + ValorIgv)).ToString("###,##0.000")
            FleteDetalle()
        Else
            CalFleteUnitarioIGV.Text = 0.0
        End If
    End Sub

    Private Sub CalFleteUnitarioIGV_ValueChanged(sender As Object, e As EventArgs) Handles CalFleteUnitarioIGV.ValueChanged
        If Not String.IsNullOrEmpty(CalFleteUnitarioIGV.Value) AndAlso IsNumeric(CalFleteUnitarioIGV.Value) AndAlso CalFleteUnitarioIGV.Value >= 0.0 Then
            If CalFleteUnitarioIGV.Focused Then
                CalFleteUnitario.Value = (CDbl(CalFleteUnitarioIGV.Value.Trim) / (1 + ValorIgv)).ToString("###,##0.000")
                FleteDetalle()
            End If
        Else
            CalFleteUnitarioIGV.Text = 0.0
        End If
    End Sub

    Private Sub verValidaFU_CheckedChanged(sender As Object, e As EventArgs) Handles verValidaFU.CheckedChanged
        If verValidaFU.Checked = False Then
            If CalFleteUnitario.Enabled = True Then
                MessageBox.Show("No es necesario quitar las validaciones")
                verValidaFU.Checked = True
            Else
                If Not PerfilAsignado(gNombrePerfilAutorizaTarifas) Then
                    If MessageBox.Show("No esta autorizado para quitar las validaciones" & Environment.NewLine & _
                                        "Demanda sin validaciones comuniquese con el " & gNombrePerfilJefeOperaciones & Environment.NewLine & _
                                        "Desea seguir registrando la Demanda:  ?", _
                                        "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                        IncidenciasPublic = New e_IncidenciasAutentificadas
                        Dim formulario As frm_Autorizacion
                        formulario = frm_Autorizacion
                        If formulario.ObtenerJefes(gNombrePerfilAutorizaTarifas, "frm_Operacion1", pIdActividadNegocio) Then formulario.ShowDialog()
                        If IncidenciasPublic.IdResponsableAutoriza.Trim = "" Then
                            verValidaFU.Checked = True
                            CalFleteUnitario.Enabled = False
                            CalFleteUnitarioIGV.Enabled = False
                        Else
                            verValidaFU.Checked = False
                            CalFleteUnitario.Enabled = True
                            CalFleteUnitarioIGV.Enabled = True
                        End If
                    Else
                        verValidaFU.Checked = True
                    End If
                Else
                    CalFleteUnitario.Enabled = True
                    CalFleteUnitarioIGV.Enabled = True
                End If
            End If

        Else
            CalFleteUnitario.Enabled = False
            CalFleteUnitarioIGV.Enabled = False
        End If
    End Sub

    Private Sub cboContacto_EditorButtonClick(sender As Object, e As EditorButtonEventArgs) Handles cboContacto.EditorButtonClick
        ugb_Espera.Visible = True
        Application.DoEvents()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        ' If e.Button.Key = "btnEditarCliente" Then
        If Me.cboTercero.Value <> "" Then
            codigoCliente = cboCliente.Value
            Dim IdEmpresa As String
            TipoCliente = 2
            oeCliente = New e_Cliente
            oeCliente.Id = cboTercero.Value
            oeCliente = olCliente.Obtener(oeCliente)
            IdEmpresa = oeCliente.IdEmpresa
            Dim Empresa As New frm_Empresa
            Empresa = Empresa.getInstancia()
            Empresa.MdiParent = frm_Menu
            Empresa.ficDetalle.SelectedTab = Empresa.ficDetalle.Tabs(5)
            Empresa.Show()
            Empresa.AgregarDireccion(IdEmpresa)
            codigoTercero = "0"
        End If
        ugb_Espera.Visible = False
    End Sub

    Private Sub cboComisionista_ValueChanged(sender As Object, e As EventArgs) Handles cboComisionista.ValueChanged
        Dim extras As ArrayList
        If cboComisionista.SelectedIndex >= 0 Then
            '    indiceCom = Me.cboComisionista.SelectedIndex
            Me.txtRucComisionista.Text = ComisionistasPublic.Item(cboComisionista.SelectedIndex).Descripcion
            extras = ComisionistasPublic.Item(cboComisionista.SelectedIndex).Extras

            If Me.cboComisionista.Text.Contains("NINGUNO") Then
                Me.txtComision.Enabled = False
                Me.txtRucComisionista.Text = ""
                If Me.cboCliente.Text.Contains("NINGUNO") AndAlso Me.cboClienteFinal.Text.Contains("NINGUNO") Then
                    Me.cboComisionista.SelectedIndex = 0
                    Me.cboComisionista.Focus()
                    mensajeEmergente.Confirmacion("Si Cliente es 'Otros', Debe elegir un comisionista", True)
                End If
            Else
                Me.txtComision.Enabled = True
            End If
        Else
            'If codigoComisionista.Trim <> "" Then
            'LlenarComboMaestro(Me.cboComisionista, ComisionistasPublic, indiceCom)
            '   Me.cboComisionista.Value = codigoNuevoCom
            ' End If
        End If
    End Sub

    Private Sub cboTracto_ValueChanged(sender As Object, e As EventArgs) Handles cboTracto.ValueChanged
        If cboTracto.Value <> "" Then
            If Operacion = "Nuevo" Or Operacion = "Editar" Then
                olVehiculo = New l_Vehiculo
                oeVehiculo = New e_Vehiculo
                oeVehiculo.TipoOperacion = "A"
                oeVehiculo.Id = cboTracto.Value
                oeVehiculo = olVehiculo.Obtener(oeVehiculo)
                '      cboTipoVehiculo.Value = oeVehiculo.IdModeloFuncional
                FlotaOperacion = IIf(Me.cboCarreta.Value = "", FlotaPublic.Where(Function(item) item.Id = oeVehiculo.IdFlota).ToList.Item(0).Nombre.ToString, FlotaOperacion)
                '  FlotaTracto = cboTipoVehiculo.Text.Trim
                cboTractoPeso.Value = cboTracto.Value
                txtTaraTracto.Text = oeVehiculo.Tara

                olBonificacion = New l_Bonificacion
                oeBonificacion = New e_Bonificacion
                oeBonificacion.IdVehiculo = cboTractoPeso.Value
                If cboTracto.Value <> "" Then
                    griBonificacionTracto.DataSource = olBonificacion.Listar(oeBonificacion)
                    If griBonificacionTracto.Rows.Count > 0 Then
                        griBonificacionTracto.Rows(0).Selected = True
                    End If

                End If


                'Actualizar el flete unitario si se actualiza la placa del vehículo
                ' ahora es por modelo funcinal, no toma cbotracto
                'If griViajeDetalle.Rows.Count = 0 Then
                '    ObtenerFleteUnitario()
                '    txtFlete.Text = txtFleteTotalDetalle.Text
                'End If
                lblFlota.Text = "FLOTA: " & FlotaOperacion
            End If

            If griBonificacionTracto.Rows.Count > 0 Then
                txtCapacidadUtil.Text = oeVehiculo.CapacidadUtil(CDbl(txtTaraTracto.Value), CDbl(txtTaraCarreta.Value), CDbl(griBonificacionTracto.Rows(0).Cells("Numero").Value))
                txtViajeCapacidadUtil.Text = txtCapacidadUtil.Text
                txtBonificacionTracto.Text = griBonificacionTracto.Rows(0).Cells("Numero").Value
            Else
                txtCapacidadUtil.Value = 0
                txtViajeCapacidadUtil.Value = 0
                txtBonificacionTracto.Value = 0
            End If
            If txtViajeCapacidadUtil.Value <= 0 Then
                txtViajeCapacidadUtil.Value = 35000
            End If
            'Modelo Funcional
            olCombo = New l_Combo
            oeCombo = New e_Combo
            With oeCombo
                .Id = 1 'Tracto
                .Nombre = "UNIDADTIPOVEHICULO"
                .Descripcion = "TIPOFUNCIONAL"
            End With
            olCombo.Listar(oeCombo)
            '@0001 Inicio
            FotoTracto(cboTracto.Value)
        End If

    End Sub

    Private Sub cboCarreta_ValueChanged(sender As Object, e As EventArgs) Handles cboCarreta.ValueChanged
        If cboCarreta.Value <> "" Then
            olVehiculo = New l_Vehiculo
            oeVehiculo = New e_Vehiculo
            oeVehiculo.TipoOperacion = "A"
            oeVehiculo.Id = cboCarreta.Value
            oeVehiculo = olVehiculo.Obtener(oeVehiculo)
            cboCarreta.Enabled = True
            Me.verCarreta.Checked = True
            ' cboTipoVehiculo.Value = oeVehiculo.IdModeloFuncional
            FlotaOperacion = FlotaPublic.Where(Function(item) item.Id = oeVehiculo.IdFlota).ToList.Item(0).Nombre.ToString
            cboCarretaPeso.Value = cboCarreta.Value
            txtTaraCarreta.Text = oeVehiculo.Tara
            olBonificacion = New l_Bonificacion
            oeBonificacion = New e_Bonificacion
            oeBonificacion.IdVehiculo = cboCarretaPeso.Value
            If cboCarretaPeso.Value <> "" Then
                griBonificacionCarreta.DataSource = olBonificacion.Listar(oeBonificacion)
                If griBonificacionCarreta.Rows.Count > 0 Then
                    griBonificacionCarreta.Rows(0).Selected = True
                End If
                '   cboTracto_ValueChanged(Nothing, Nothing)
            End If
            FotoCarreta(cboCarreta.Value) '@0001
        Else
            cboCarreta.Enabled = False
            Me.verCarreta.Checked = False
            oeVehiculo = New e_Vehiculo
            oeVehiculo.TipoOperacion = "A"
            oeVehiculo.Id = cboTracto.Value
            oeVehiculo = olVehiculo.Obtener(oeVehiculo)
            FlotaOperacion = FlotaPublic.Where(Function(item) item.Id = oeVehiculo.IdFlota).ToList.Item(0).Nombre.ToString
        End If
        lblFlota.Text = "FLOTA: " & FlotaOperacion
    End Sub

    Private Sub verPagoContraEntrega_CheckedChanged(sender As Object, e As EventArgs) Handles verPagoContraEntrega.CheckedChanged
        Try
            If verPagoContraEntrega.Checked Then
                opPagoCont.Enabled = True
            Else
                opPagoCont.Enabled = False
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griViajeDetalle_AfterRowUpdate(sender As Object, e As RowEventArgs) Handles griViajeDetalle.AfterRowUpdate
        If e.Row.Cells("PagoContraEntrega").Value = False And e.Row.Cells("PagoContraEntrega").IsActiveCell Then
            e.Row.Cells("PagoEfectivoDeposito").Value = ""
        Else
            If e.Row.Cells("PagoContraEntrega").IsActiveCell Then
                griViajeDetalle.ActiveRow.Cells("PagoEfectivoDeposito").Value = "E"
            End If
        End If
        If e.Row.Cells("PagoEfectivoDeposito").IsActiveCell And e.Row.Cells("PagoContraEntrega").Value = False Then
            e.Row.Cells("PagoEfectivoDeposito").Value = ""
        End If
    End Sub

    Private Sub griViajeDetalle_ClickCell(sender As Object, e As ClickCellEventArgs) Handles griViajeDetalle.ClickCell
        columnas.Clear()
        For i As Integer = 0 To griViajeDetalle.Rows(e.Cell.Row.Index).Cells.Count - 1
            columnas.Add(griViajeDetalle.Rows(e.Cell.Row.Index).Cells(i).Text)
        Next
        count = getIdArrayBidimensional()
        rowGeneral(count, 0) = e.Cell.Row.Index
        rowGeneral(count, 1) = -1
    End Sub

    Private Sub griViajeDetalle_AfterCellUpdate(sender As Object, e As CellEventArgs) Handles griViajeDetalle.AfterCellUpdate
        If Operacion = "Editar" And griViajeDetalle.Rows(e.Cell.Row.Index).Cells("Id").Value <> "" And columnas.Count > 0 Then

            Dim lista1 As New List(Of String)
            Dim lista2 As New List(Of String)
            Dim lista3 As New List(Of String)
            lista1.Add(e.Cell.Column.Key)
            lista2.Add(columnas(e.Cell.Column.Index).ToString)
            lista3.Add(e.Cell.Text.ToString)

            Dim indLista = getIndiceLista(e.Cell.Row.Index)
            Dim indArrayGlosas As Integer = getIdArrayGlosas(e.Cell.Column.Key, indLista)
            If indLista = -1 Then
                glosasGeneral(indArrayGlosas, 0) = e.Cell.Column.Key
                glosasGeneral(indArrayGlosas, 1) = ListaBitacora.Count
                glosasGeneral(indArrayGlosas, 2) = 0
                rowGeneral(count, 1) = ListaBitacora.Count ' ind de la lista general
                ListaBitacora.Add(New e_Bitacora(griViajeDetalle.Rows(e.Cell.Row.Index).Cells("IdOperacion").Value,
                                                 griViajeDetalle.Rows(e.Cell.Row.Index).Cells("Id").Value, "OPE.Operacion", "OPE.OperacionDetalle",
                                                 Me.Text, lista1, gUsuarioSGI.Id, "I",
                                                 lista2, lista3, "", "I", True))
            Else
                Dim indicolm = existeColumna(e.Cell.Column.Key, indLista)
                If indicolm <> -1 Then
                    '  ListaBitacora.Item(indLista).ColumnasAfectadas.Item(indicolm) = e.Cell.Column.Key ' glosasGeneral(indArrayGlosas, 0)
                    '  ListaBitacora.Item(indLista).ValoresAnteriores.Item(indicolm) = columnas(e.Cell.Column.Index).ToString ' glosasGeneral(indArrayGlosas, 1)
                    ListaBitacora.Item(indLista).ValoresActuales.Item(indicolm) = e.Cell.Text.ToString ' glosasGeneral(indArrayGlosas, 2)
                Else
                    glosasGeneral(indArrayGlosas, 0) = e.Cell.Column.Key
                    glosasGeneral(indArrayGlosas, 1) = indLista
                    glosasGeneral(indArrayGlosas, 2) = ListaBitacora.Item(indLista).ColumnasAfectadas.Count
                    ListaBitacora.Item(indLista).ColumnasAfectadas.Add(e.Cell.Column.Key)
                    ListaBitacora.Item(indLista).ValoresAnteriores.Add(columnas(e.Cell.Column.Index).ToString)
                    ListaBitacora.Item(indLista).ValoresActuales.Add(e.Cell.Text.ToString)
                End If
            End If
        End If
    End Sub

    Private Sub griDetalle_Click(sender As Object, e As EventArgs) Handles griViajeDetalle.Click
        If griViajeDetalle.ActiveRow IsNot Nothing Then
            If griViajeDetalle.ActiveRow.Cells("IdOPeracion").Value <> "" Then
                objEliminarDetalle = New e_Bitacora(griViajeDetalle.ActiveRow.Cells("IdOperacion").Value.ToString,
                                   griViajeDetalle.ActiveRow.Cells("Id").Value.ToString, "OPE.Operacion", "OPE.OperacionDetalle",
                                   Me.Text, New List(Of String), gUsuarioSGI.Id, "I", New List(Of String), New List(Of String), "E", "D", False)
            End If
        End If
    End Sub

    Private Sub cboContacto_Validated(sender As Object, e As EventArgs) Handles cboContacto.Validated
        If Operacion = "Nuevo" Or Operacion = "Editar" Then
            If cboContacto.SelectedIndex > -1 Then
                Dim lista As New List(Of e_Combo)
                lista = Me.cboContacto.DataSource
                txtRucContacto.Text = lista.Item(cboContacto.SelectedIndex).Descripcion
            Else
                txtRucContacto.Text = ""
                txtApellidoPaternoContacto.Text = ""
                txtApellidoMaternoContacto.Text = ""
                txtNombreContacto.Text = ""
                txtTelefonoContacto.Text = ""
            End If
        End If
    End Sub

    Private Sub cboContacto_ValueChanged(sender As Object, e As EventArgs) Handles cboContacto.ValueChanged
        Dim extras As ArrayList
        If cboContacto.SelectedIndex >= 0 Then
            Dim lista = Me.cboContacto.DataSource
            txtRucContacto.Text = lista.Item(cboContacto.SelectedIndex).Descripcion
            extras = lista.Item(cboContacto.SelectedIndex).Extras
            If extras.Count > 0 Then
                Me.txtApellidoPaternoContacto.Text = extras.Item(0).ToString
                Me.txtApellidoMaternoContacto.Text = extras.Item(1).ToString
                Me.txtNombreContacto.Text = extras.Item(2).ToString
                Me.txtTelefonoContacto.Text = extras.Item(3).ToString
                '   codigoComisionista = extras.Item(4).ToString
            End If
        Else
            Me.txtApellidoPaternoContacto.Text = ""
            Me.txtApellidoMaternoContacto.Text = ""
            Me.txtNombreContacto.Text = ""
            Me.txtTelefonoContacto.Text = ""
        End If
    End Sub

    Private Sub cboTercero_Validated(sender As Object, e As EventArgs) Handles cboTercero.Validated
        If Operacion = "Nuevo" Or Operacion = "Editar" Then
            If cboTercero.SelectedIndex > -1 Then
                Dim lista As New List(Of e_Combo)
                Dim olContacto As New e_Combo
                olContacto.Nombre = "Contacto"
                olContacto.Id = Me.cboTercero.Value
                lista.AddRange(olCombo.Listar(olContacto))
                LlenarComboMaestro(cboContacto, lista, 0)
                Me.cboContacto.SelectedIndex = 0
                txtRucEmpresaTransportista.Text = ListTercero.Item(cboTercero.SelectedIndex).Descripcion
            End If
        End If
    End Sub

    Private Sub btnEnviarCorreo_Click(sender As Object, e As EventArgs) Handles btnEnviarCorreo.Click
        Try
            If griTransabilida.Rows.Count > 0 Then
                Dim formulario As frm_EnvioEmail
                formulario = New frm_EnvioEmail
                formulario.Modulo = "Trazabilidad"
                formulario.asunto = "Errores de Trazabilidad " & IIf(Me.opTractoCarreta.CheckedIndex = 0, "Tracto", "Carreta")
                formulario.cadenaMensajeHtml = llenarTabla()
                formulario.ShowDialog()
            Else
                mensajeEmergente.Confirmacion("No existen registros en la lista", True)
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtComision_ValueChanged(sender As Object, e As EventArgs) Handles txtComision.ValueChanged
        Try
            If String.IsNullOrEmpty(txtComision.Text) Or Not IsNumeric(txtComision.Text) Then txtComision.Text = 0.0
            If oeTarifa IsNot Nothing And txtComision.Value > 0 Then
                If oeTarifa.Id <> "" Then
                    If oeTarifa.AceptaComision = False Then
                        If MessageBox.Show("El tipo de flete elegido NO ACEPTA COMISION.Consulte tarifario. ¿Desea agregar comision?", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
                            txtComision.Value = 0
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub chkMotriz_CheckedChanged(sender As Object, e As EventArgs) Handles chkMotriz.CheckedChanged
        Try
            cboTipoVehiculo_ValueChanged(Nothing, Nothing)
            'cboTipoVehiculo_Validated(Nothing, Nothing)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub chkIndTercero_CheckedChanged(sender As Object, e As EventArgs) Handles chkIndTercero.CheckedChanged
        Try
            If chkIndTercero.Checked Then
                ficViaje.Tabs(2).Enabled = True
                ficViaje.SelectedTab = ficViaje.Tabs(2)
            Else
                ficViaje.Tabs(2).Enabled = False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub verFechaViaje_CheckedChanged(sender As Object, e As EventArgs) Handles verFechaViaje.CheckedChanged
        If verFechaViaje.Checked = True Then
            fecViaje.Value = FechaServidor
        End If
    End Sub

    Private bolMarcarTodos As Boolean = False
    Private Sub cboFlota_ValueChanged(sender As Object, e As EventArgs) Handles cboFlota.ValueChanged
        Try
            Dim values As List(Of Object) = Nothing
            values = Me.cboFlota.Value
            If Not values Is Nothing Then
                If bolMarcarTodos AndAlso values.Where(Function(x) x = "").Count = 0 Then
                    bolMarcarTodos = False
                    cboFlota.SetCheckState(CheckState.Unchecked)
                End If
                If Not bolMarcarTodos AndAlso values.Where(Function(x) x = "").Count > 0 Then
                    bolMarcarTodos = True
                    cboFlota.SetCheckState(CheckState.Checked)
                End If
            Else
                bolMarcarTodos = False
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboTracto_EditorButtonClick(sender As Object, e As EditorButtonEventArgs) Handles cboTracto.EditorButtonClick
        Try
            If cboTracto.SelectedIndex >= 0 Then
                mt_MostrarVehiculoModal(cboTracto.Value.ToString().Trim())
            Else
                MessageBox.Show("Seleccione Tracto", "Tracto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboCarreta_EditorButtonClick(sender As Object, e As EditorButtonEventArgs) Handles cboCarreta.EditorButtonClick
        Try
            If cboCarreta.SelectedIndex >= 0 Then
                mt_MostrarVehiculoModal(cboCarreta.Value.ToString().Trim())
            Else
                MessageBox.Show("Seleccione Carreta", "Carreta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tabViajesLista_SelectedTabChanged(sender As Object, e As UltraWinTabControl.SelectedTabChangedEventArgs) Handles tabViajesLista.SelectedTabChanged
        Try
            mt_ControlBotoneria()
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

    Private Sub frm_Operacion_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case ficOperacion.SelectedTab.Index
                Case 0 'Listado

                Case 1 'Mantenimiento
                    Select Case e.KeyCode
                        Case Keys.Enter
                            SendKeys.Send("{TAB}")
                    End Select
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub fecViaje_Validated(sender As Object, e As EventArgs) Handles fecViaje.Validated
        Try
            If Operacion = "Nuevo" Or Operacion = "Editar" Then
                If verFechaViaje.Checked = True And Operacion = "Nuevo" And fecViaje.Value < (FechaServidor.AddDays(lisDiasSupervisor(0).Valor1)).Date Then
                    fecViaje.Focus()
                    fecViaje.Value = FechaServidor.Date
                    Throw New Exception("La fecha de atención no puede ser menor a la fecha actual")
                End If
                If verFechaViaje.Checked = True And Operacion = "Editar" And fecViaje.Value < oeViaje.Fecha Then
                    fecViaje.Focus()
                    fecViaje.Value = oeViaje.Fecha
                    Throw New Exception("La fecha de atención no puede ser menor a la fecha programada")
                End If
                If verFechaViaje.Checked = True And Operacion = "Nuevo" And fecViaje.Value > FechaServidor.AddMonths(1).Date Then
                    fecViaje.Value = FechaServidor.Date
                    Throw New Exception("La fecha de atención excede a la fecha actual")
                End If
                'If verFechaViaje.Checked = False Then
                '    If Not PerfilAsignado(gNombrePerfilAutorizaOperaciones) Then
                '        If fecViaje.Value < ObtenerFechaServidor.Date.AddDays(lisDiasSupervisor(0).Valor1).Date Then
                '            If MessageBox.Show("No esta autorizado para ingresar/modificar" & Environment.NewLine & _
                '                "viajes en fechas anteriores comuniquese con el " & gNombrePerfilJefeOperaciones & Environment.NewLine & _
                '                "Desea Seguir Programando Viajes:  ?", _
                '                "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                '                IncidenciasPublic = New e_IncidenciasAutentificadas
                '                Dim formulario As frm_Autorizacion
                '                formulario = frm_Autorizacion
                '                If formulario.ObtenerJefes(gNombrePerfilAutorizaOperaciones, "frm_Operacion", pIdActividadNegocio) Then formulario.ShowDialog()

                '                If IncidenciasPublic.IdResponsableAutoriza.Trim = "" Then
                '                    verFechaViaje.Checked = True
                '                    Return False
                '                Else
                '                    Dim oeTrabajador As New e_Trabajador
                '                    Dim olTrabajador As New l_Trabajador
                '                    oeTrabajador.TipoOperacion = "F"
                '                    oeTrabajador.oePersona.Id = IncidenciasPublic.IdResponsableAutoriza.Trim
                '                    oeTrabajador.Activo = True
                '                    oeTrabajador = olTrabajador.Obtener(oeTrabajador)
                '                    For Each concep In lisDiasSupervisor
                '                        If concep.Valor2 = oeTrabajador.oeOcupacion.Id Then
                '                            If CDate(fecViaje.Value) < (FechaServidor.AddDays(concep.Valor1)).Date Then
                '                                MessageBox.Show("La ocupación " & oeTrabajador.oeOcupacion.Nombre & " solo tiene " & (concep.Valor1 * -1) & "dias de retraso.", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                '                                verFechaViaje.Checked = True

                '                            Else
                '                                Exit For
                '                            End If
                '                        End If
                '                        MessageBox.Show("No se ha podido validar ocupación del autorizador y dias permitidos", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                '                        verFechaViaje.Checked = True

                '                    Next

                '                End If



                '                If IncidenciasPublic.IdResponsableAutoriza.Trim = "" Then
                '                    verFechaViaje.Checked = True
                '                End If
                '            Else
                '                fecViaje.Value = ObtenerFechaServidor.Date
                '                verFechaViaje.Checked = True
                '            End If
                '        End If
                '    End If
                'End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub hOperacion_Click(sender As Object, e As EventArgs) Handles hOperacion.Click
        Try
            hOperacion.SelectAll()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Private Sub hViaje_Click(sender As Object, e As EventArgs) Handles hViaje.Click
        Try
            hViaje.SelectAll()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboTipoVehiculo_ValueChanged(sender As Object, e As EventArgs) Handles cboTipoVehiculo.ValueChanged
        If Operacion = "Nuevo" Or Operacion = "Editar" Then
            ObtenerFleteUnitario()
            If cboTipoVehiculo.Text = "PARIHUELERO" Then cboTipoCarga.Text = "VIAJE"
        End If
        Try
            LlenarCboTipoVehiculo()
            If Me.chkMotriz.Checked Then
                verCarreta.Checked = False
                listAModFx = TractoPublic.Where(Function(Item) Item.Descripcion = 1 Or Item.Descripcion = 3 And Item.Extras.Item(0).ToString = Me.cboTipoVehiculo.Value).ToList
                cboTracto.DataSource = listAModFx
                cboTracto.SelectedIndex = 0

            Else
                'Cargar Carretas
                verCarreta.Checked = True
                listAModFx = New List(Of e_Combo)
                listAModFx = CarretaPublic.Where(Function(item) item.Extras.Item(0).ToString = Me.cboTipoVehiculo.Value).ToList
                cboCarreta.DataSource = listAModFx
                'cboCarreta.Text = ""

                If listAModFx.Count > 0 Then
                    cboCarreta.SelectedIndex = 0
                    cboCarreta.Value = listAModFx.Item(0).Id
                End If
                ''Carga todos los tractos
                listAModFx = New List(Of e_Combo)
                listAModFx = TractoPublic.Where(Function(Item) Item.Descripcion = 1 Or Item.Descripcion = 3).ToList
                cboTracto.DataSource = listAModFx
                'cboTracto.SelectedIndex = 0
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub griLista_AfterRowFilterChanged(sender As Object, e As AfterRowFilterChangedEventArgs) Handles griLista.AfterRowFilterChanged
        Try
            If griLista.Rows.Where(Function(it) it.IsFilteredOut = False).Count > 0 Then
                decProduccionIGV.Value = griLista.Rows.Where(Function(it) it.IsFilteredOut = False).Sum(Function(it) CDbl(it.Cells("Produccion").Value))
                decProduccionSinIGV.Value = griLista.Rows.Where(Function(it) it.IsFilteredOut = False).Sum(Function(it) CDbl(it.Cells("Tesoreria").Value))
            Else
                decProduccionIGV.Value = griLista.Rows.Sum(Function(it) CDbl(it.Cells("Produccion").Value))
                decProduccionSinIGV.Value = griLista.Rows.Sum(Function(it) CDbl(it.Cells("Tesoreria").Value))
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Métodos"

    Public Sub seleccionarComboVehiculo()
        For Each obj As e_Combo In Me.cboTipoVehiculo.DataSource
            If obj.Nombre = TipoVehiculo Then
                Me.cboTipoVehiculo.Value = obj.Id
                Return
            End If
        Next
    End Sub

    Public Sub seleccionarEscala()
        ' For Each obj As e_Combo In Me.cboEscala.DataSource
        If IdEscala <> "" Then
            Me.cboEscala.Value = IdEscala
        End If
        '  Next
    End Sub

    Public Sub ProgramarViajeDespacho(oeViaje As e_Viaje)
        Try
            Nuevo()
            cboPiloto.Focus()
            cboRutaOrigen.Value = oeViaje.IdOrigen
            cboRutaDestino.Value = oeViaje.IdDestino
            cboRutaDestino_Validated(Nothing, Nothing)
            cboOrigen.Value = oeViaje.IdOrigen
            cboDestino.Value = oeViaje.IdDestino
            If String.IsNullOrWhiteSpace(oeViaje.IdPiloto) Then
                cboPiloto.Value = 0
            Else
                cboPiloto.Value = oeViaje.IdPiloto
            End If
            If String.IsNullOrWhiteSpace(oeViaje.IdCopiloto) Then
                cboCopiloto.Value = 0
            Else
                cboCopiloto.Value = oeViaje.IdCopiloto
            End If
            cboTipoVehiculo.Value = oeViaje.IdTipoVehiculo
            cboTracto.Value = oeViaje.IdTracto
            cboCarreta.Value = oeViaje.IdCarreta
            idDespachoOperaciones = oeViaje.IdDespachoOperaciones
            If Not String.IsNullOrWhiteSpace(oeViaje.IdEscala) Then
                verEscala.Checked = True
                cboEscala.Value = oeViaje.IdEscala
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub EditarFormExterno(oeViaje As e_Viaje)
        Try
            bolIndFormExterno = True
            oeViajeExterno = New e_Viaje
            oeViajeExterno.Id = oeViaje.Id
            oeViajeExterno.IdOperacion = oeViaje.IdOperacion
            Editar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    'Public Sub ProgramarEscalaDespacho(oeViaje As e_Viaje)
    '    Try
    '        bolIndFormExterno = True
    '        oeViajeExterno = New e_Viaje
    '        oeViajeExterno.Id = oeViaje.Id
    '        oeViajeExterno.IdEscala = oeViaje.IdEscala
    '        oeViajeExterno.IdOperacion = oeViaje.IdOperacion
    '        idDespachoOperaciones = oeViaje.IdDespachoOperaciones
    '        Editar()
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub

    Public Sub ProgramarViaje(ByVal IdDemanda As String, ByVal tipoVehiculo As String, ByVal idEscala As String, ByVal MotivoEscala As String,
                              ByVal fechaAtencion As Date, ByVal codigo As String)
        Operacion = "Nuevo"
        Try
            Nuevo()
            lblDemandaProgramar.Visible = True
            lblCodigoDemandaAProgramar.Visible = True
            codigoDemanda = IdDemanda
            Me.lblCodigoDemandaAProgramar.Text = codigo
            Me.TipoVehiculo = tipoVehiculo
            Me.IdEscala = idEscala
            verEscala.Checked = IIf(idEscala.Trim <> "", True, False)
            Me.txtGlosaEscala.Text = MotivoEscala
            'Me.cboTipoVehiculo.Enabled = False
            Me.cboRutaOrigen.Enabled = False
            Me.cboRutaDestino.Enabled = False
            seleccionarComboVehiculo()
            seleccionarEscala()
            LlenarCboTipoVehiculo()
            Me.fecViaje.Value = fechaAtencion
            Me.hViaje.Value = fechaAtencion
            ListarDemanda()
            Me.expNuevaCarga.Expanded = False
            Me.expListaDemandas.Expanded = True
            For Each fila As UltraGridRow In griDemanda.Rows
                If fila.Cells("Id").Value = IdDemanda Then
                    griDemanda.Rows.Item(fila.Index).Activated = True
                    fila.Cells("Seleccion").Value = True
                End If
            Next
            cboPiloto.Enabled = True
            griViaje.DisplayLayout.Bands(0).Columns("Piloto").CellActivation = Activation.AllowEdit
            Operacion = "Nuevo"
            Me.cboTracto.Focus()
            pIdActividadNegocio = "1CH000000203"
            Dim lista As List(Of e_Viaje) = olOperacion.ListarViaje(oeViaje)
            If Me.TipoVehiculo <> "" Then
                lista = lista.Where(Function(item) item.TipoVehiculo = tipoVehiculo).ToList.Where(Function(item) item.IdDestino = cboRutaOrigen.Value).ToList
            End If
            griDisponibleVehiculo.DataSource = lista
            expCargaOperacion.Expanded = False
            expContratoTercero.Expanded = False
            If (gUsuarioSGI.leARUsuario.Where(Function(item) item.IdActividadNegocio = gActividadNegocio.Consolidado.ToString And
                                                 item.AccionSistema = gAccionSistema.ACTUALIZAR.ToString And item.IdProcesoNegocio = pProcesoNegocio)).ToList.Count > 0 Then
                griViajeDetalle.DisplayLayout.Bands(0).Columns("Consolidado").CellClickAction = CellClickAction.EditAndSelectText
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub ColorControles()
        '----------------------------------------------
        '------Tipo de Vehiculo------------------------
        ColorPlataforma.Color = Color.Coral
        ColorPlataformaD.Color = Color.Coral
        ColorFurgonLargo.Color = Color.PeachPuff
        ColorFurgonLargoD.Color = Color.PeachPuff
        ColorMediaBaranda.Color = Color.Orange
        ColorMediaBarandaD.Color = Color.Orange
        ColorFurgon.Color = Color.Gold
        ColorFurgonD.Color = Color.Gold
        ColorCalicera.Color = Color.DarkKhaki
        ColorCaliceraD.Color = Color.DarkKhaki
        ColorContenedor.Color = Color.OliveDrab
        ColorContenedorD.Color = Color.OliveDrab
        ColorGranelero.Color = Color.YellowGreen
        ColorGraneleroD.Color = Color.YellowGreen
        ColorParihuelero.Color = Color.PaleGreen
        ColorParihueleroD.Color = Color.PaleGreen
        ColorTolvaVolteo.Color = Color.RosyBrown
        ColorTolvaVolteoD.Color = Color.RosyBrown
        ColorVolquete.Color = Color.Peru
        ColorVolqueteD.Color = Color.Peru
        ColorCamioneta.Color = Color.LightGreen
        ColorCamionetaD.Color = Color.LightGreen
        ColorCamion65M3.Color = Color.MediumSpringGreen
        ColorCamion65M3D.Color = Color.MediumSpringGreen
        ColorCamion20M3.Color = Color.PaleTurquoise
        ColorCamion20M3D.Color = Color.PaleTurquoise
        ColorCamion30M3.Color = Color.DeepSkyBlue
        ColorCamion30M3D.Color = Color.DeepSkyBlue
        ColorCamion40M3.Color = Color.Violet
        ColorCamion40M3D.Color = Color.Violet
        '----------------------------------------------
        '------Estados de Viaje------------------------
        ColorProgramado.Color = Color.White
        ColorCarga.Color = Color.Yellow
        ColorTransito.Color = Color.DarkOrange
        ColorDescarga.Color = Color.Silver
        ColorFin.Color = Color.LimeGreen
        '----------------------------------------------
        '------Cambio de Registro------------------------
        colorCambio.Color = Color.Cyan
        '----------------------------------------------
        '------Carga Consolidada-----------------------
        colorCargaConsolidada.Color = Color.SaddleBrown
        '----------------------------------------------
        '------Dispinibilidad-----------------------
        ColorAdvertencia.Color = Color.Red
        ColorPiloto.Color = Color.Orange
        ColorCopiloto.Color = Color.Yellow
        ColorAyudante.Color = Color.Lime
        ColorTracto.Color = Color.DarkCyan
        ColorCarreta.Color = Color.Blue
    End Sub

    Private Sub ControlRangoFechaInicializa()
        fecDesde.Value = FechaServidor.AddDays(-5)
        fecHasta.Value = FechaServidor.AddDays(+1)
    End Sub

    Private Sub AyudaMaestros(ByVal Tipo As Integer)
        olCombo = New l_Combo
        oeCombo = New e_Combo
        Select Case Tipo
            Case 1
                oeCombo.Nombre = "Comisionistas"
                ComisionistasPublic = New List(Of e_Combo)
                ComisionistasPublic.AddRange(olCombo.Listar(oeCombo))
                LlenarComboMaestro(cboComisionista, ComisionistasPublic.OrderBy(Function(iten) iten.Nombre).ToList, -1)
            Case 2
                oeCombo.Nombre = "Clientes"
                ClientesPublic = New List(Of e_Combo)
                ClientesPublic.AddRange(olCombo.Listar(oeCombo))
                LlenarComboMaestro(cboCliente, ClientesPublic.OrderBy(Function(iten) iten.Nombre).ToList, -1)
            Case 3
                olLugar = New l_Lugar
                oeLugar = New e_Lugar
                oeLugar.TipoOperacion = "O"
                LlenarComboMaestro(cboRutaOrigen, olLugar.Listar(oeLugar), 0)
        End Select
    End Sub

    Dim tarifaInicial As Decimal = 0
    Private Sub ObtenerFleteUnitario()
        'Try
        '    tarifaInicial = 0
        '    olLugar = New l_Lugar
        '    olTarifa = New l_TarifasCliente
        '    oeTarifa = New e_TarifasCliente
        '    'Dim IndCampaña As Integer = 0
        '    'If cboCliente.Text = "SUPERMERCADOS PERUANOS S.A." Or cboCliente.Text = "ALICORP SAA" Or cboCliente.Text = "HIPERMERCADOS TOTTUS S.A." Then
        '    '    oeLugar = New e_Lugar
        '    '    oeLugar.Id = cboRutaOrigen.Value
        '    '    oeLugar = olLugar.Obtener(oeLugar)
        '    '    If oeLugar.IdReferencia.Trim <> "" Then
        '    '        oeTarifa.IdOrigen = oeLugar.IdReferencia
        '    '    Else
        '    '        oeTarifa.IdOrigen = cboRutaOrigen.Value
        '    '    End If
        '    '    '--------------------------------
        '    '    oeLugar = New e_Lugar
        '    '    oeLugar.Id = cboRutaDestino.Value
        '    '    oeLugar = olLugar.Obtener(oeLugar)
        '    '    If oeLugar.IdReferencia.Trim <> "" Then
        '    '        oeTarifa.IdDestino = oeLugar.IdReferencia
        '    '    Else
        '    '        oeTarifa.IdDestino = cboRutaDestino.Value
        '    '    End If
        '    '    IndCampaña = 1
        '    'Else
        '    '    oeTarifa.IdOrigen = cboRutaOrigen.Value
        '    '    oeTarifa.IdDestino = cboRutaDestino.Value
        '    '    IndCampaña = 0
        '    'End If
        '    'With oeTarifa
        '    '    .TipoOperacion = "P"
        '    '    .IdTipoVehiculo = cboTipoVehiculo.Value
        '    '    .IdCliente = cboCliente.Value
        '    '    .IdTipoCarga = cboTipoCarga.Value
        '    '    .IndActual = 1
        '    '    .IndHistorial = -1
        '    'End With
        '    'oeTarifa = olTarifa.Obtener(oeTarifa)
        '    'If IndCampaña = 0 Then
        '    '    CalFleteUnitario.Text = oeTarifa.Tarifa
        '    'Else
        '    '    If CDate(fecOperacion.Value) >= CDate(oeTarifa.FInicioCampaña) Then
        '    '        If CDate(fecOperacion.Value) <= CDate(oeTarifa.FFinCampaña) Then
        '    '            CalFleteUnitario.Text = oeTarifa.Tarifa * oeTarifa.Porcentaje
        '    '        Else
        '    '            CalFleteUnitario.Text = oeTarifa.Tarifa
        '    '        End If
        '    '    Else
        '    '        CalFleteUnitario.Text = oeTarifa.Tarifa
        '    '    End If
        '    'End If

        '    oeTarifa = New e_TarifasCliente
        '    With oeTarifa
        '        .TipoOperacion = "P"
        '        .IdCliente = cboCliente.Value
        '        .IndActual = 1
        '        .IndHistorial = -1
        '    End With
        '    oeTarifa = olTarifa.Obtener(oeTarifa)
        '    If oeTarifa.IdCliente IsNot Nothing Then
        '        CalFleteUnitario.Enabled = False
        '        CalFleteUnitarioIGV.Enabled = False
        '        Me.verValidaFU.Checked = True
        '    Else
        '        CalFleteUnitario.Enabled = True
        '        CalFleteUnitarioIGV.Enabled = True
        '    End If
        '    Dim IndCampaña As Integer = 0
        '    If cboCliente.Text = "SUPERMERCADOS PERUANOS S.A." Or cboCliente.Text = "ALICORP SAA" Or cboCliente.Text = "HIPERMERCADOS TOTTUS S.A." Then
        '        oeLugar = New e_Lugar
        '        oeLugar.Id = cboRutaOrigen.Value
        '        oeLugar = olLugar.Obtener(oeLugar)
        '        If oeLugar.IdReferencia.Trim <> "" Then
        '            oeTarifa.IdOrigen = oeLugar.IdReferencia
        '        Else
        '            oeTarifa.IdOrigen = cboRutaOrigen.Value
        '        End If
        '        '--------------------------------
        '        oeLugar = New e_Lugar
        '        oeLugar.Id = cboRutaDestino.Value
        '        oeLugar = olLugar.Obtener(oeLugar)
        '        If oeLugar.IdReferencia.Trim <> "" Then
        '            oeTarifa.IdDestino = oeLugar.IdReferencia
        '        Else
        '            oeTarifa.IdDestino = cboRutaDestino.Value
        '        End If
        '        IndCampaña = 1
        '    Else
        '        oeTarifa.IdOrigen = cboRutaOrigen.Value
        '        oeTarifa.IdDestino = cboRutaDestino.Value
        '        IndCampaña = 0
        '    End If

        '    With oeTarifa
        '        .TipoOperacion = "P"
        '        .IdTipoVehiculo = cboTipoVehiculo.Value
        '        .IdCliente = cboCliente.Value
        '        .IdTipoCarga = cboTipoCarga.Value
        '        .IndActual = 1
        '        .IndHistorial = -1
        '        .Id = ""
        '        .IdMaterial = Me.cboMaterial.Value
        '    End With
        '    oeTarifa = olTarifa.Obtener(oeTarifa)
        '    If oeTarifa IsNot Nothing Then
        '        Me.verCargar.Checked = oeTarifa.IndCarga
        '        Me.verDescarga.Checked = oeTarifa.IndDescarga
        '        Me.verPagoContraEntrega.Checked = oeTarifa.IndContraEntrega
        '        Me.chkConsolidado.Checked = oeTarifa.IndConsolidado
        '        If oeTarifa.IndVariable = 1 Then
        '            Me.CalFleteUnitario.Enabled = True
        '            Me.CalFleteUnitarioIGV.Enabled = True
        '        Else
        '            Me.CalFleteUnitario.Enabled = False
        '            Me.CalFleteUnitarioIGV.Enabled = False
        '        End If
        '    End If
        '    If IndCampaña = 0 Then
        '        CalFleteUnitario.Value = oeTarifa.Tarifa
        '        CalFleteUnitarioIGV.Value = CDbl(CalFleteUnitario.Value * (1 + ValorIgv)).ToString("###,##0.0000")
        '        txtSubtotal.Value = CalFleteUnitario.Value * txtCantidad.Value
        '        txtFleteTotalDetalle.Value = CDbl((CalFleteUnitario.Value * txtCantidad.Value) * (1 + ValorIgv)).ToString("###,##0.0000")
        '        txtAdelantoFlete.Value = 0
        '    Else
        '        If CDate(fecOperacion.Value) >= CDate(oeTarifa.FInicioCampaña) Then
        '            If CDate(fecOperacion.Value) <= CDate(oeTarifa.FFinCampaña) Then
        '                CalFleteUnitario.Value = oeTarifa.Tarifa * oeTarifa.Porcentaje
        '            Else
        '                CalFleteUnitario.Value = oeTarifa.Tarifa
        '            End If
        '        Else
        '            CalFleteUnitario.Value = oeTarifa.Tarifa
        '        End If
        '    End If
        '    txtCantidad.Text = 1

        '    If cboActividadNegocio.Text.Trim <> "" Then
        '        olDistanciaZona = New l_DistanciaZona
        '        oeDistanciaZona = New e_DistanciaZona
        '        oeDistanciaZona.IdActividadNegocio = cboActividadNegocio.Value
        '        oeDistanciaZona.IdCliente = cboCliente.Value
        '        oeDistanciaZona.IdRuta = RutaOperacion
        '        oeDistanciaZona = olDistanciaZona.Obtener(oeDistanciaZona)
        '        txtCantidad.Text = oeDistanciaZona.Distancia
        '    End If
        '    'If CalFleteUnitario.Value > 0 Then
        '    '    CalFleteUnitario.Enabled = False
        '    'Else
        '    '    CalFleteUnitario.Enabled = True
        '    'End If
        'Catch ex As Exception
        '    Throw ex
        'End Try
        Try
            tarifaInicial = 0
            oeTarifa = New e_TarifasCliente
            tarifaInicial = 0
            olLugar = New l_Lugar
            olTarifa = New l_TarifasCliente
            oeTarifa = New e_TarifasCliente
            With oeTarifa
                .TipoOperacion = "P"
                .IdCliente = cboCliente.Value
                .IndActual = 1
                .IndHistorial = -1
            End With
            oeTarifa = olTarifa.Obtener(oeTarifa)
            If oeTarifa.IdCliente IsNot Nothing Then
                CalFleteUnitario.Enabled = False
                CalFleteUnitarioIGV.Enabled = False
                Me.verValidaFU.Checked = True
            Else
                CalFleteUnitario.Enabled = True
                CalFleteUnitarioIGV.Enabled = True
            End If
            Dim IndCampaña As Integer = 0
            If cboCliente.Text = "SUPERMERCADOS PERUANOS S.A." Or cboCliente.Text = "ALICORP SAA" Or cboCliente.Text = "HIPERMERCADOS TOTTUS S.A." Then
                oeLugar = New e_Lugar
                oeLugar.Id = cboRutaOrigen.Value
                oeLugar = olLugar.Obtener(oeLugar)
                If oeLugar.IdReferencia.Trim <> "" Then
                    oeTarifa.IdOrigen = oeLugar.IdReferencia
                Else
                    oeTarifa.IdOrigen = cboRutaOrigen.Value
                End If
                '--------------------------------
                oeLugar = New e_Lugar
                oeLugar.Id = cboRutaDestino.Value
                oeLugar = olLugar.Obtener(oeLugar)
                If oeLugar.IdReferencia.Trim <> "" Then
                    oeTarifa.IdDestino = oeLugar.IdReferencia
                Else
                    oeTarifa.IdDestino = cboRutaDestino.Value
                End If
                IndCampaña = 1
            Else
                oeTarifa.IdOrigen = cboRutaOrigen.Value
                oeTarifa.IdDestino = cboRutaDestino.Value
                IndCampaña = 0
            End If

            With oeTarifa
                .TipoOperacion = "P"
                .IdTipoVehiculo = cboTipoVehiculo.Value
                .IdCliente = cboCliente.Value
                .IdTipoCarga = cboTipoCarga.Value
                .IndActual = 1
                .IndHistorial = -1
                .Id = ""
                .IdMaterial = Me.cboMaterial.Value
            End With
            oeTarifa = olTarifa.Obtener(oeTarifa)
            If oeTarifa.Id <> "" Then
                Me.verCargar.Checked = oeTarifa.IndCarga
                Me.verDescarga.Checked = oeTarifa.IndDescarga
                Me.verPagoContraEntrega.Checked = oeTarifa.IndContraEntrega
                Me.chkConsolidado.Checked = oeTarifa.IndConsolidado
                If oeTarifa.IndVariable = 1 Then
                    Me.CalFleteUnitario.Enabled = True
                    Me.CalFleteUnitarioIGV.Enabled = True
                    tarifaInicial = oeTarifa.Tarifa
                Else
                    Me.CalFleteUnitario.Enabled = False
                    Me.CalFleteUnitarioIGV.Enabled = False
                End If
            End If
            If IndCampaña = 0 Then
                CalFleteUnitario.Value = oeTarifa.Tarifa
                CalFleteUnitarioIGV.Value = CDbl(CalFleteUnitario.Value * (1 + ValorIgv)).ToString("###,##0.0000")
                txtSubtotal.Value = CalFleteUnitario.Value * txtCantidad.Value
                txtFleteTotalDetalle.Value = CDbl((CalFleteUnitario.Value * txtCantidad.Value) * (1 + ValorIgv)).ToString("###,##0.0000")
                txtAdelantoFlete.Value = 0
            Else
                If CDate(fecOperacion.Value) >= CDate(oeTarifa.FInicioCampaña) Then
                    If CDate(fecOperacion.Value) <= CDate(oeTarifa.FFinCampaña) Then
                        CalFleteUnitario.Value = oeTarifa.Tarifa * oeTarifa.Porcentaje
                    Else
                        CalFleteUnitario.Value = oeTarifa.Tarifa
                    End If
                Else
                    CalFleteUnitario.Value = oeTarifa.Tarifa
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CalcularTotalesDetalle()
        Try
            Dim cantidad As Double = 0
            Dim fleteunitario As Double = 0
            Dim flete As Double = 0

            If griViajeDetalle.Rows.Count > 0 Then
                oeOperacion.oeOperacionDetalle = griViajeDetalle.DataSource
                cantidad = oeOperacion.oeOperacionDetalle.Sum(Function(item) item.Cantidad)
                fleteunitario = oeOperacion.oeOperacionDetalle.Sum(Function(item) item.FleteUnitario)
                flete = oeOperacion.oeOperacionDetalle.Sum(Function(item) item.Flete + item.Consolidado)
            End If
            txtCantidadOperacion.Text = cantidad
            txtFUnitarioOperacion.Text = fleteunitario
            '  CalFleteUnitario.Text = fleteunitario
            txtFleteUnitarioViaje.Text = fleteunitario
            txtFlete.Text = flete
            txtFTotalOperacion.Text = flete
        Catch ex As Exception
            mensajeEmergente.Confirmacion("Verifique Flete de Carga Operacion", True)
        End Try
    End Sub

    Private Sub FleteDetalleGrilla()
        Try
            oeDemandaDetalle = New e_DemandaDetalle
            With griViajeDetalle.ActiveRow
                If Not .Cells("Cantidad").Value.ToString.Trim = "" Or Not IsNumeric(.Cells("Cantidad").Value.ToString) Then
                    oeDemandaDetalle.Cantidad = CDbl(.Cells("Cantidad").Value)
                Else
                    .Cells("Cantidad").Value = 1
                End If
                If Not .Cells("FleteUnitario").Value.ToString.Trim = "" Or Not IsNumeric(.Cells("FleteUnitario").Value.ToString) Then
                    oeDemandaDetalle.FleteUnitario = CDbl(.Cells("FleteUnitario").Value)
                Else
                    .Cells("FleteUnitario").Value = 0
                End If
                oeDemandaDetalle.IGV = ValorIgv
                If .Cells("IncluyeIgv").Value = False Then
                    .Cells("Flete").Value = oeDemandaDetalle.FleteCalcularSinIgv
                Else
                    .Cells("Flete").Value = oeDemandaDetalle.FleteCalcularIgv
                End If
                .Cells("Subtotal").Value = oeDemandaDetalle.FleteCalcularSinIgv
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub DuplicarRegistroDetalleDemanda()
        If griViajeDetalle.Rows.Count > 0 Then
            oeOperacion.oeOperacionDetalle = griViajeDetalle.DataSource
            With griViajeDetalle.ActiveRow
                oeOperacionDetalle = New e_OperacionDetalle
                oeOperacionDetalle.Id = ""
                oeOperacionDetalle.IdOperacion = .Cells("IdOperacion").Value
                oeOperacionDetalle.IdDemanda = .Cells("IdDemanda").Value
                oeOperacionDetalle.IdDemandaDetalle = ""
                oeOperacionDetalle.Cliente = .Cells("Cliente").Value
                oeOperacionDetalle.Comisionista = .Cells("Comisionista").Value
                oeOperacionDetalle.Carga = .Cells("Carga").Value
                oeOperacionDetalle.Material = .Cells("Material").Value
                oeOperacionDetalle.Moneda = .Cells("Moneda").Value
                oeOperacionDetalle.Cantidad = .Cells("Cantidad").Value
                oeOperacionDetalle.FleteUnitario = .Cells("FleteUnitario").Value
                oeOperacionDetalle.Flete = .Cells("Flete").Value
                oeOperacionDetalle.Comision = .Cells("Comision").Value
                oeOperacionDetalle.Facturado = .Cells("Facturado").Value
                oeOperacionDetalle.IncluyeIgv = .Cells("IncluyeIgv").Value
                oeOperacionDetalle.PagoContraEntrega = .Cells("PagoContraEntrega").Value
                oeOperacionDetalle.Origen = .Cells("Origen").Value
                oeOperacionDetalle.Destino = .Cells("Destino").Value
                oeOperacionDetalle.PesoToneladas = 0
                oeOperacionDetalle.ClienteFinal = .Cells("ClienteFinal").Value
                oeOperacion.oeOperacionDetalle.Add(oeOperacionDetalle)
                griViajeDetalle.DataBind()
                oeOperacionDetalle = New e_OperacionDetalle
            End With
        End If
    End Sub

    Public Sub AgregarVehiculo()
        Try
            olOperacion = New l_Operacion
            olVehiculo = New l_Vehiculo
            Dim Total_Selec As Integer
            Total_Selec = 0
            If griDisponibleVehiculo.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then

                If Not olVehiculo.ValidarTractoMantenimiento(griDisponibleVehiculo.ActiveRow.Cells("IdTracto").Value) Then
                    If MessageBox.Show("Tracto se encuentra en Mantenimiento continuara con la Programacion de Viaje: " & _
                        griDisponibleVehiculo.ActiveRow.Cells("Tracto").Value & " ?", _
                        "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
                        griDisponibleVehiculo.ActiveRow.Cells("Seleccion").Value = 0
                        Exit Sub
                    End If
                End If

                If griDisponibleVehiculo.ActiveRow.Cells("IdCarreta").Value.ToString.Trim <> "" Then
                    If Not olVehiculo.ValidarCarretaMantenimiento(griDisponibleVehiculo.ActiveRow.Cells("IdCarreta").Value) Then
                        If MessageBox.Show("Carreta se encuentra en Mantenimiento continuara con la Programacion de Viaje: " & _
                            griDisponibleVehiculo.ActiveRow.Cells("Carreta").Value & " ?", _
                            "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
                            griDisponibleVehiculo.ActiveRow.Cells("Seleccion").Value = 0
                            Exit Sub
                        End If
                    End If
                Else
                    Me.verCarreta.Checked = False
                    Me.cboCarreta.Enabled = False
                End If

                oeViaje = New e_Viaje
                oeViaje.TipoOperacion = "2"
                oeViaje.Id = griDisponibleVehiculo.ActiveRow.Cells("Id").Value.ToString
                oeViaje = olOperacion.ObtenerViaje(oeViaje)
                'cambios
                'olVehiculo = New l_Vehiculo
                'oeVehiculo = New e_Vehiculo
                'oeVehiculo.TipoOperacion = "A"
                'oeVehiculo.Id = oeViaje.IdCarreta
                'oeVehiculo = olVehiculo.Obtener(oeVehiculo)IdTipoVehiculo
                If codigoDemanda = "" Then
                    cboTipoVehiculo.Value = griDisponibleVehiculo.ActiveRow.Cells("IdTipoVehiculo").Value
                    cboTipoVehiculo_Validated(Nothing, Nothing)
                End If

                cboPiloto.Value = oeViaje.IdPiloto
                cboCopiloto.Value = oeViaje.IdCopiloto
                cboAyudante.Value = oeViaje.IdAyudante
                '  cboTipoVehiculo.Value = oeViaje.IdTipoVehiculo

                '     Me.chkMotriz.Checked = IIf(TipoVehiculoPublic.Where(Function(item) item.Id = cboTipoVehiculo.Value).ToList.Item(0).Descripcion.ToString, True, False)
                Me.cboTracto.Focus()
                cboTipoVehiculo.Value = griDisponibleVehiculo.ActiveRow.Cells("IdTipoVehiculo").Value
                cboTracto.Value = oeViaje.IdTracto
                cboCarreta.Value = oeViaje.IdCarreta
                If bandRpta = "S" Then
                    If oeViaje.IdCarreta = "" Then
                        'cboTracto.Text = ""
                    Else
                        'cboTracto.Text = ""
                        'cboCarreta.Text = ""
                    End If

                End If

                For I As Integer = 0 To griDemanda.Rows.Count - 1
                    If griDemanda.Rows(I).Cells("Seleccion").Value Then
                        Total_Selec += 1
                    End If
                Next

                If Total_Selec = 0 Then
                    If griDisponibleVehiculo.ActiveRow.Cells("Seleccion").Value Then

                        oeOperacion = New e_Operacion
                        oeOperacion.Id = oeViaje.IdOperacion
                        oeOperacion = olOperacion.Obtener(oeOperacion)
                        RutaOperacion = oeOperacion.IdRuta
                        RutaIdDestino = oeViaje.IdDestino
                        cboRutaOrigen.Value = RutaIdDestino
                        cboOrigen.Value = RutaIdDestino
                        RutaIdDestino = ""
                        'cboRutaDestino.SelectedIndex = -1 @0001
                        cboRutaDestino.Focus()
                    Else
                        griViajeDetalle.DataSource = New List(Of e_OperacionDetalle)
                        '  LimpiaGrid(griViajeDetalle, ogdOperacionDetalle)
                    End If
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Sub EliminarVehiculo(ByVal tracto As String)
        Try
            Dim Total_Selec As Integer
            Dim Total_Disponible As Integer
            Total_Selec = 0
            Total_Disponible = 0

            For I As Integer = 0 To griDemanda.Rows.Count - 1
                If griDemanda.Rows(I).Cells("Seleccion").Value Then
                    Total_Selec += 1
                End If
            Next

            If Total_Selec = 0 Then
                For I As Integer = 0 To griDisponibleVehiculo.Rows.Count - 1
                    If griDisponibleVehiculo.Rows(I).Cells("Seleccion").Value Then
                        Total_Disponible += 1
                    End If
                Next
                If Total_Disponible = 0 Then
                    'LimpiaGrid(griViajeDetalle, ogdOperacionDetalle)
                    'Dim ViajeDetalle As New List(Of e_OperacionDetalle) '@0001
                    'griViajeDetalle.DataSource = ViajeDetalle '@0001
                End If
            End If

            'For Each row As UltraGridRow In griViaje.Rows

            For I As Integer = 0 To griViaje.Rows.Count - 1
                If griViaje.Rows(I).Cells("Tracto").Text.Trim = tracto.Trim Then
                    EliminarViajeSinMje = "S"
                    griViaje.Rows.Item(I).Delete()
                    For J As Integer = 0 To griViaje.Rows.Count - 1 '@0001 Ini
                        If griViaje.Rows(J).Cells("Tracto").Text.Trim = tracto.Trim Then
                            EliminarViajeSinMje = "S"
                            griViaje.Rows.Item(J).Delete()
                            Exit For
                        End If
                    Next
                    Exit For '@0001 Fin
                End If
            Next
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Private Sub MostrarFichaP()
        Try
            If ValidaCamposPilotos() Then
                Dim formulario As frm_FichaPersonal
                formulario = frm_FichaPersonal
                If formulario.MostrarTrabajador(cboPiloto.Value) Then
                    formulario.ShowDialog()
                    MyBase.Nuevo()
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub MostrarFichaC()
        Try
            If ValidaCamposPilotos() Then

                Dim formulario As frm_FichaPersonal
                formulario = frm_FichaPersonal
                If formulario.MostrarTrabajador(cboCopiloto.Value) Then
                    formulario.ShowDialog()
                    MyBase.Nuevo()
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub MostrarFichaA()
        Try
            If ValidaCamposPilotos() Then

                Dim formulario As frm_FichaPersonal
                formulario = frm_FichaPersonal
                If formulario.MostrarTrabajador(cboAyudante.Value) Then
                    formulario.ShowDialog()
                    MyBase.Nuevo()
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub EscalaRegistroViaje()
        If griViaje.Rows.Count > 0 Then
            oeOperacion.oeViaje = griViaje.DataSource
            With griViaje.ActiveRow
                oeViaje = New e_Viaje
                oeViaje.Id = ""
                oeViaje.Codigo = ""
                oeViaje.IdOperacion = ""
                oeViaje.Origen = .Cells("Origen").Value
                oeViaje.Destino = .Cells("Destino").Value
                oeViaje.IdEscala = .Cells("Origen").Value
                oeViaje.IndEscala = "1"
                oeViaje.ViajeVacio = .Cells("ViajeVacio").Value
                oeViaje.Piloto = .Cells("Piloto").Value
                oeViaje.Copiloto = .Cells("Copiloto").Value
                oeViaje.IdAyudante = .Cells("IdAyudante").Value
                oeViaje.Tracto = .Cells("Tracto").Value
                oeViaje.Carreta = .Cells("Carreta").Value
                oeViaje.IdEstado = ""
                oeViaje.Fecha = .Cells("Fecha").Value
                oeViaje.Activo = True
                oeOperacion.oeViaje.Add(oeViaje)
                griViaje.DataBind()
                oeViaje = New e_Viaje
            End With
        End If
    End Sub

    Private Function ValidaEscala(ByVal Origen As String) As Boolean
        Try
            olRuta = New l_Ruta
            Try
                oeRuta = New e_Ruta
                oeRuta.Id = ""
                oeRuta.IdOrigen = Origen
                oeRuta.IdDestino = cboEscalaBloque.Value
                olRuta.ValidarRutaNueva(oeRuta)
            Catch ex As Exception
                Throw New Exception("Origen y Escala " & ex.Message)
            End Try
            Try
                oeRuta = New e_Ruta
                oeRuta.Id = ""
                oeRuta.IdOrigen = cboEscalaBloque.Value
                oeRuta.IdDestino = cboDestino.Value
                olRuta.ValidarRutaNueva(oeRuta)
            Catch ex As Exception
                Throw New Exception("Escala y Destino " & ex.Message)
            End Try
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Private Function Llena_Detalle_Demanda() As Boolean
        Try
            If ValidaCargaOperacionDetalle() Then
                oeOperacion.oeOperacionDetalle = griViajeDetalle.DataSource
                With oeOperacionDetalle
                    .Id = ""
                    .IdDemanda = ""
                    .Cliente = cboCliente.Value
                    .Comisionista = cboComisionista.Value
                    .Carga = cboTipoCarga.Value
                    .Material = cboMaterial.Value
                    .Moneda = cboMoneda.Value
                    .Cantidad = txtCantidad.Text
                    .IncluyeIgv = verIncluyeIgv.Checked
                    .FleteUnitario = CalFleteUnitario.Text
                    .Flete = txtFleteTotalDetalle.Text
                    .Comision = txtComision.Text
                    .Facturado = verFacturado.Checked
                    .PagoContraEntrega = verPagoContraEntrega.Checked
                    .Cargar = verCargar.Checked
                    .Descarga = verDescarga.Checked
                    .ClienteFinal = cboCliente.Value
                    .Origen = cboRutaOrigen.Value
                    .Destino = cboRutaDestino.Value
                    .ClienteFinal = cboCliente.Value
                    .CostoEstiba = txtCostoEstiba.Value
                    .CostoEstibaDescarga = txtCostoEstibaDescarga.Value
                    .AdelantoFlete = txtAdelantoFlete.Value
                    .Consolidado = txtConsolidado.Value
                    .IncluyeIgvConsolidado = chkIGVConsolidado.Checked
                    .Subtotal = txtSubtotal.Value
                    .MotivoConsolidado = txtMotivoConsolidado.Text
                    .FalsoFlete = Me.chkIndFalsoFlete.Checked
                    .PrefijoID = gs_PrefijoIdSucursal '@0001
                End With
                If verPagoContraEntrega.Checked Then
                    oeOperacionDetalle.PagoEfectivoDeposito = "D"
                    If opPagoCont.CheckedIndex = 0 Then
                        oeOperacionDetalle.PagoEfectivoDeposito = "E"
                    End If
                End If
                If tarifaInicial <> 0 And tarifaInicial <> oeOperacionDetalle.FleteUnitario Then
                    Dim incidencia As New e_IncidenciasAutentificadas
                    With incidencia
                        .IdArea = gUsuarioSGI.oeArea.Id
                        .IdActividadNegocio = pIdActividadNegocio
                        .IdResponsableAutoriza = gUsuarioSGI.Id
                        .IdUsuarioIncidente = gUsuarioSGI.Id
                        .Glosa = "Cambio de tarifa variable"
                        .Indicador = "V"
                        .PrefijoID = gs_PrefijoIdSucursal '@0001
                    End With
                    oeOperacionDetalle.oeIncidenciaAutentificadas = incidencia
                End If
                oeOperacion.oeOperacionDetalle.Add(oeOperacionDetalle)
                griViajeDetalle.DataBind()
                oeOperacionDetalle = New e_OperacionDetalle
                CalcularTotalesDetalle()
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ValidaCargaOperacionDetalle() As Boolean
        Try
            olDemanda = New l_Demanda
            ''ValidarCombo(cboRutaOperacion, "Ruta")
            ValidarCombo(cboRutaOrigen, "Ruta Operacion Origen")
            ValidarCombo(cboRutaDestino, "Ruta Operacion Destino")
            ValidarCombo(cboCliente, "Cliente")
            ValidarCombo(cboComisionista, "Comisionista")
            ValidarCombo(cboTipoCarga, "Tipo Carga")
            ValidarCombo(cboMaterial, "Material")
            ValidaCheckBox()
            With oeDemandaDetalle
                .Cliente = cboCliente.Value
                .Comisionista = cboComisionista.Value
                .IdTipoCarga = cboTipoCarga.Value
                .Material = cboMaterial.Value
            End With
            olDemanda.ValidarDetalle(oeDemandaDetalle)
            If Me.cboCliente.Text.Contains("OTROS") AndAlso Me.cboClienteFinal.Text.Contains("OTROS") AndAlso Me.cboComisionista.Text.Contains("NINGUNO") Then
                Throw New Exception("Si el cliente es 'OTROS' debe seleccionar comisionista")
            End If

            If CalFleteUnitario.Value = 0 Then
                If MessageBox.Show("No esta autorizado para registrar FleteUnitario 0.00" & Environment.NewLine & _
                    "Viaje sin validaciones comuniquese con el " & gNombrePerfilJefeOperaciones & Environment.NewLine & _
                    "Desea seguir registrando la carga del viaje:  ?", _
                    "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    IncidenciasPublic = New e_IncidenciasAutentificadas
                    Dim formulario As frm_Autorizacion
                    formulario = frm_Autorizacion
                    If formulario.ObtenerJefes(gNombrePerfilJefeOperaciones, "frm_Operacion1", pIdActividadNegocio) Then formulario.ShowDialog()
                    If IncidenciasPublic.IdResponsableAutoriza.Trim = "" Then
                        Throw New Exception("No tiene permisos para seguir resgistrando la carga del viaje")
                    End If
                Else
                    Throw New Exception("No tiene permisos para seguir resgistrando la carga del viaje")
                End If
            End If
            If txtComision.Value > (txtFleteTotalDetalle.Value * 0.1) Then
                Throw New Exception("Comision excede el 10 % del Flete Unitario a cobrar")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub ValidaCheckBox()
        If chkConsolidado.Checked AndAlso txtConsolidado.Value <= 0 Then
            Throw New Exception("Ingrese monto de consolidado")
        End If
        If chkCostoEstiva.Checked AndAlso txtCostoEstiba.Value <= 0 Then
            Throw New Exception("Ingrese costo de estiba")
        End If
        If chkCostoEstivaDescarga.Checked AndAlso txtCostoEstibaDescarga.Value <= 0 Then
            Throw New Exception("Ingrese costo de estiba de descarga")
        End If
    End Sub

    Private Sub FleteDetalle()
        'Try
        '    oeDemandaDetalle = New e_DemandaDetalle
        '    With oeDemandaDetalle
        '        If Not String.IsNullOrEmpty(CalFleteUnitario.Text) AndAlso IsNumeric(CalFleteUnitario.Text.Trim.ToString) AndAlso CalFleteUnitario.Text > 0.0 Then
        '            oeDemandaDetalle.FleteUnitario = CDbl(CalFleteUnitario.Text.Trim)
        '            'btnAgregar.Visible = True
        '        Else
        '            CalFleteUnitario.Text = 0.0
        '            oeDemandaDetalle.FleteUnitario = CDbl(CalFleteUnitario.Text.Trim)
        '            'btnAgregar.Visible = False
        '        End If
        '        If Not String.IsNullOrEmpty(txtCantidad.Text) AndAlso IsNumeric(txtCantidad.Text.Trim.ToString) Then
        '            If CDbl(txtCantidad.Text.Trim) = 0.0 Then txtCantidad.Text = 1
        '            oeDemandaDetalle.Cantidad = CDbl(txtCantidad.Text.Trim)
        '        Else
        '            txtCantidad.Text = 1
        '            oeDemandaDetalle.Cantidad = CDbl(txtCantidad.Text.Trim)
        '        End If

        '        oeDemandaDetalle.IGV = ValorIgv
        '    End With
        '    If verIncluyeIgv.Checked = False Then
        '        txtFleteTotalDetalle.Text = oeDemandaDetalle.FleteCalcularSinIgv
        '    Else
        '        txtFleteTotalDetalle.Text = oeDemandaDetalle.FleteCalcularIgv
        '    End If
        'Catch ex As Exception

        'End Try
        Try
            oeDemandaDetalle = New e_DemandaDetalle
            With oeDemandaDetalle
                If Not String.IsNullOrEmpty(CalFleteUnitario.Text) AndAlso IsNumeric(CalFleteUnitario.Text) AndAlso CalFleteUnitario.Text > 0.0 Then
                    oeDemandaDetalle.FleteUnitario = CDbl(CalFleteUnitario.Text.Trim)
                    '  Me.CalFleteUnitarioIGV.Text = CDbl(CalFleteUnitario.Text.Trim) * ValorIgv
                    'btnAgregar.Visible = True   
                Else
                    CalFleteUnitario.Text = 0.0
                    CalFleteUnitarioIGV.Text = 0.0
                    txtFleteTotalDetalle.Text = 0
                    txtSubtotal.Text = 0
                End If
                If Not String.IsNullOrEmpty(txtCantidad.Text) AndAlso IsNumeric(txtCantidad.Text) Then
                    If CDbl(txtCantidad.Text.Trim) = 0.0 Then txtCantidad.Text = 1
                    oeDemandaDetalle.Cantidad = CDbl(txtCantidad.Text.Trim)
                Else
                    txtCantidad.Text = 1
                    oeDemandaDetalle.Cantidad = CDbl(txtCantidad.Text.Trim)
                End If
                oeIgv = olIgv.IGV(Date.Now)
                oeDemandaDetalle.IGV = oeIgv.Porcentaje
            End With
            If CalFleteUnitario.Value > 0 Then
                If verIncluyeIgv.Checked = False Then
                    txtFleteTotalDetalle.Text = oeDemandaDetalle.FleteCalcularSinIgv
                Else
                    txtFleteTotalDetalle.Text = oeDemandaDetalle.FleteCalcularIgv
                End If
                txtSubtotal.Text = oeDemandaDetalle.FleteCalcularSinIgv
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub EnfocarDetalle(ByVal excepcion As String)
        '  If excepcion.Contains("Ruta") Then ruta.Focus()
        If excepcion.Contains("Cliente") Then cboCliente.Focus()
        If excepcion.Contains("Comisionista") Then cboComisionista.Focus()
        If excepcion.Contains("Tipo Carga") Then cboTipoCarga.Focus()
        If excepcion.Contains("Material") Then cboMaterial.Focus()
    End Sub

    Private Sub Inicializar()
        txtIdOperacion.Text = String.Empty
        txtCodigoOperacion.Text = String.Empty
        txtIdEstadoOperacion.Text = String.Empty
        txtCodigoViaje.Text = String.Empty
        txtIdViaje.Text = String.Empty
        verViajeVacio.Checked = False
        verViajeRetorno.Checked = False
        verEscala.Checked = False
        cboCarreta.Text = ""
        cboTracto.Text = ""
        verEscalaBloque.Checked = False
        verCarreta.Checked = False
        cboCarreta.Enabled = False
        verFacturado.Checked = True
        verPagoContraEntrega.Checked = False
        verIncluyeIgv.Checked = True
        verCargar.Checked = False
        verDescarga.Checked = False
        fecOperacion.Value = Date.Now
        txtObservacionOperacion.Text = "Glosa: "
        txtGlosaEscala.Text = ""
        cboOrigen.SelectedIndex = -1
        cboOrigen.Enabled = False
        cboRutaOperacion.SelectedIndex = -1
        cboDestino.SelectedIndex = -1
        'cboDestino.Enabled = False
        cboPiloto.SelectedIndex = -1
        cboCopiloto.SelectedIndex = 0
        cboAyudante.SelectedIndex = 0
        cboTracto.SelectedIndex = -1
        cboCarreta.SelectedIndex = -1
        cboCliente.SelectedIndex = -1
        cboComisionista.SelectedIndex = -1
        cboComisionista.Text = "NINGUNO  ,"
        cboTipoCarga.SelectedIndex = -1
        cboMaterial.SelectedIndex = -1
        cboEscala.SelectedIndex = -1
        cboEscalaBloque.Text = ""
        verProgramarViajeBloque.Checked = False
        verFechaViaje.Checked = True
        CalFleteUnitario.Value = 0.0
        txtComision.Value = 0.0
        txtCantidad.Value = 1.0
        txtFleteTotalDetalle.Value = 0.0
        txtFUnitarioOperacion.Value = 0.0
        txtCantidadOperacion.Value = 0.0
        txtFlete.Value = 0.0
        txtFTotalOperacion.Value = 0.0
        NroVueltas.Value = 1
        NroTurno.Value = 0
        griDemanda.DataSource = New List(Of e_Demanda)
        'If PrefijoId = "1PY" Then '@0001
        '    hOperacion.Value = Date.Now.Date '@0001
        'Else
        hOperacion.Value = Date.Now
        '    If PrefijoId = "1LI" Then '@0001
        '        hViaje.Value = Date.Now '@0001
        '    End If '@0001
        'End If '@0001

        hViaje.Value = Date.Now.Date
        cboMoneda.SelectedIndex = 0
        LimpiaGrid(griViaje, ogdViaje)
        'LimpiaGrid(griViajeDetalle, ogdOperacionDetalle)
        griViajeDetalle.DataSource = New List(Of e_OperacionDetalle)
        txtFletePorcentaje.Text = 100
        TractoViaje = ""
        CarretaViaje = ""
        If gUsuarioSGI.Controlado <> 0 Then
            griViaje.DisplayLayout.Bands(0).Columns("Destino").CellActivation = Activation.NoEdit
        Else
            griViaje.DisplayLayout.Bands(0).Columns("Destino").CellActivation = Activation.AllowEdit
        End If
        'cambios
        Me.expVehiculo.Expanded = False
        Me.expGeneral.Expanded = True
        Me.expGeneral.Width = Me.Width - 30
        Me.txtConsolidado.Enabled = False
        Me.expNuevaCarga.Expanded = True
        Me.expListaDemandas.Expanded = False

        'Glosas
        GlosaDetalleDemanda = ""
        ValoresAnterioresDetalleDemanda = ""
        ValoresActualesDetalleDemanda = ""
        ListaBitacora.Clear()

        'llenar bidimensional
        For i As Integer = 0 To 14
            rowGeneral(i, 0) = -1
            rowGeneral(i, 1) = -1
        Next

        For i As Integer = 0 To 14
            glosasGeneral(i, 0) = ""
            glosasGeneral(i, 1) = -1
            glosasGeneral(i, 2) = -1
        Next
        Me.TipoVehiculo = ""
        tarifaInicial = 0
        codigoDemanda = ""
        lblDemandaProgramar.Visible = False
        lblCodigoDemandaAProgramar.Visible = False

        IndPropiedadTracto = -1
        IndPropiedadCarreta = -1
        cboDestino.Enabled = True
        '  verCarreta.Enabled = True
        cboTracto.Enabled = True
        ' cboCarreta.Enabled = True

        EliminarViajeSinMje = ""
        CargaVacia = 1
        NombrePropTracto = ""
        'PARA IND TERCERO
        ficViaje.Tabs(2).Enabled = False
        bandTractoFicticio = ""
        bandRpta = ""
        Me.chkIndTercero.Checked = False
        ficViaje.SelectedTab = ficViaje.Tabs(1)

        mt_HabilitarSumatoria(False)
        upbFoto.Image = Nothing
        upbFotoTracto.Image = Nothing
        upbFotoCarreta.Image = Nothing
        cboTipoVehiculo.Value = "1CH000000014" '@0001 Tipo Vehiculo Defecto
    End Sub

    Public Sub Listar(Tipo As String, ByVal griLista As UltraWinGrid.UltraGrid)
        Try
            Dim cont As Integer = 0
            ugb_Espera.Visible = True
            ' Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            olOperacion = New l_Operacion
            With oeViaje
                .TipoOperacion = Tipo
                .ViajeVacio = 2
                .FechaDesde = fecDesde.Value.ToString
                .FechaHasta = fecHasta.Value.ToString
                .UsuarioCreacion = cboUsuario.Value
                .Zona = cboZona.Value
                .Centro = cboCentro.Value
                .IdPiloto = Me.cboPilotoLista.Value
                If verTracto.Checked = True Then
                    .IndMotriz = 1
                    .IdTracto = cboTractoLista.Value
                Else
                    If verCarretaLista.Checked = True Then
                        .IndMotriz = 0
                        .IdTracto = cboCarretaLista.Value
                    End If
                End If
                If Tipo = "A" Then
                    If opcDesenganches.CheckedIndex = 0 Then
                        .FechaDesde = ""
                        .FechaHasta = ""
                        .ViajeVacio = 3
                    End If
                End If
                If Tipo = "N" Then
                    If cboFlota.Value IsNot Nothing Then
                        Dim Flotas As String = ""
                        Dim CantidadItems As Integer = CType(cboFlota.Value, List(Of Object)).Count
                        If CantidadItems = 1 Then
                            Flotas = Flotas & CType(cboFlota.Value, List(Of Object))(0).ToString()
                        Else
                            For index = 0 To CantidadItems - 1
                                If index = CantidadItems - 1 Then
                                    Flotas = Flotas & CType(cboFlota.Value, List(Of Object))(index).ToString()
                                Else
                                    Flotas = Flotas & CType(cboFlota.Value, List(Of Object))(index).ToString() & "','"
                                End If
                            Next
                        End If
                        .IdOrigen = Flotas
                    End If
                End If
                'If Tipo = "V" Then
                '    If Me.opTractoCarreta.CheckedIndex = 0 Then
                '        .IndMotriz = 1                    
                '    Else
                '        .IndMotriz = 0
                '    End If
                '    '  .IdTracto = cboTractoCarreta.Value                  
                'End If
            End With
            Dim codDestino As String = ""
            Dim codigoTractoC As String = ""
            Dim i As Integer = 0
            '.OrderBy(Function(Item) Item.Fecha)
            Dim listaNueva As New List(Of e_Viaje)
            '    griLista.DataSource = olOperacion.ListarViaje(oeViaje)
            Dim indiceTC As String = "T"
            If tabViajesLista.Tabs(3).Selected = True Then
                Dim lista As New List(Of e_Viaje)
                If opTractoCarreta.CheckedIndex = 0 Then
                    oeViaje.Turno = 0
                    lista = olOperacion.ListarViaje(oeViaje).OrderBy(Function(item) item.Fecha).OrderBy(Function(item) item.IdTracto).ToList
                Else
                    indiceTC = "C"
                    oeViaje.Turno = 1
                    lista = olOperacion.ListarViaje(oeViaje).OrderBy(Function(item) item.CargaMaterial).OrderBy(Function(item) item.Fecha).OrderBy(Function(item) item.IdCarreta).ToList
                End If
                For Each obj As e_Viaje In lista
                    If codigoTractoC = "" Or codigoTractoC <> IIf(indiceTC = "T", obj.IdTracto, obj.IdCarreta) Then
                        codDestino = ""
                    End If
                    If codDestino = obj.IdOrigen Or codDestino = "" Then
                        codDestino = obj.IdDestino
                    Else
                        codDestino = obj.IdDestino
                        If listaNueva.Count > 0 Then
                            If listaNueva.Item(IIf(listaNueva.Count = 0, 0, listaNueva.Count - 1)).Id <> lista.Item(i - 1).Id Then
                                cont += 1
                                lista.Item(i - 1).IndFecha = cont
                                listaNueva.Add(lista.Item(i - 1))
                            End If
                        Else
                            cont += 1
                            lista.Item(i - 1).IndFecha = cont
                            listaNueva.Add(lista.Item(i - 1))
                        End If
                        obj.IndFecha = cont
                        listaNueva.Add(obj)
                    End If
                    codigoTractoC = IIf(indiceTC = "T", obj.IdTracto, obj.IdCarreta)
                    i += 1
                Next
                griLista.DataSource = listaNueva.OrderBy(Function(item) item.IndFecha).ToList
            Else
                griLista.DataSource = olOperacion.ListarViaje(oeViaje)
            End If

            For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griLista.Rows

                Select Case fila.Cells("Estado").Value
                    Case "PROGRAMADO"
                        fila.CellAppearance.BackColor = Me.ColorProgramado.Color
                    Case "CARGA"
                        fila.CellAppearance.BackColor = Me.ColorCarga.Color
                    Case "TRANSITO"
                        fila.CellAppearance.BackColor = Me.ColorTransito.Color
                    Case "DESCARGA"
                        fila.CellAppearance.BackColor = Me.ColorDescarga.Color
                    Case "FIN"
                        fila.CellAppearance.BackColor = Me.ColorFin.Color
                End Select

                Select Case fila.Cells("TipoVehiculo").Value
                    Case "PLATAFORMA"
                        fila.Cells("Carreta").Appearance.BackColor = Me.ColorPlataforma.Color
                    Case "FURGON"
                        fila.Cells("Carreta").Appearance.BackColor = Me.ColorFurgon.Color
                    Case "GRANELERO"
                        fila.Cells("Carreta").Appearance.BackColor = Me.ColorGranelero.Color
                    Case "FURGON LARGO"
                        fila.Cells("Carreta").Appearance.BackColor = Me.ColorFurgonLargo.Color
                    Case "CONTENEDOR"
                        fila.Cells("Carreta").Appearance.BackColor = Me.ColorContenedor.Color
                    Case "CAMION 20 M3"
                        fila.Cells("Carreta").Appearance.BackColor = Me.ColorCamion20M3.Color
                    Case "CAMION 40 M3"
                        fila.Cells("Carreta").Appearance.BackColor = Me.ColorCamion40M3.Color
                    Case "VOLQUETE"
                        fila.Cells("Carreta").Appearance.BackColor = Me.ColorVolquete.Color
                    Case "CALICERA"
                        fila.Cells("Carreta").Appearance.BackColor = Me.ColorCalicera.Color
                    Case "TOLVA DE VOLTEO"
                        fila.Cells("Carreta").Appearance.BackColor = Me.ColorTolvaVolteo.Color
                    Case "MEDIA BARANDA"
                        fila.Cells("Carreta").Appearance.BackColor = Me.ColorMediaBaranda.Color
                    Case "CAMIONETA"
                        fila.Cells("Carreta").Appearance.BackColor = Me.ColorCamioneta.Color
                    Case "CAMION 30 M3"
                        fila.Cells("Carreta").Appearance.BackColor = Me.ColorCamion30M3.Color
                    Case "CAMION 50 M3"
                        fila.Cells("Carreta").Appearance.BackColor = Me.ColorCamion65M3.Color
                    Case "CAMION 65 M3"
                        fila.Cells("Carreta").Appearance.BackColor = Me.ColorCamion65M3.Color
                    Case "PARIHUELERO"
                        fila.Cells("Carreta").Appearance.BackColor = Me.ColorParihuelero.Color
                End Select
                If fila.Cells("Carga").Value > 1 Then
                    fila.Cells("Carga").Appearance.BackColor = Me.colorCargaConsolidada.Color
                End If

            Next
            'Ubica el cursor el el primer registro de la grilla
            If griLista.Rows.Count > 0 Then
                griLista.Focus()
                griLista.Rows.Item(0).Activated = True
            End If
            If tabViajesLista.Tabs(3).Selected And cont > 0 Then
                mensajeEmergente.Problema("Se encontraron " & cont & " ERRORES de TRAZABILIDAD", True)
            End If
            If gUsuarioSGI.oeArea.Nombre = gNombreAreaCoordinacionSupervisionOperacion OrElse
                gUsuarioSGI.oeArea.Nombre = gNombreAreaOperaciones OrElse
                gUsuarioSGI.oeArea.Nombre = gNombreAreaVentas OrElse
                gUsuarioSGI.oeArea.Nombre = gNombreAreaInformaticaSistemas OrElse
                gUsuarioSGI.oeArea.Nombre = gNombreAreaSeguridadMedioAmbiente Then
                If griLista.Rows.Count > 0 Then
                    If Tipo = "0" Or Tipo = "A" Then
                        CalcularTotales(griLista, "TotalFlete", "Produccion")
                        If Tipo = "0" Then
                            decProduccionIGV.Value = griLista.Rows.Sum(Function(it) CDbl(it.Cells("Produccion").Value))
                            decProduccionSinIGV.Value = griLista.Rows.Sum(Function(it) CDbl(it.Cells("Tesoreria").Value))
                        End If
                    ElseIf Tipo = "T" Then
                        CalcularTotales(griLista, "FleteUnitario", "TotalFlete", "KmTractoOrigen", "KmTractoDestino", "KmCarretaOrigen", "KmCarretaDestino", "PorcentajeFlete", "Produccion")
                    End If
                End If
            Else
                If Tipo = "0" Or Tipo = "A" Then
                    CalcularTotales(griLista, "TotalFlete", "Produccion")
                    If Tipo = "0" Then
                        decProduccionIGV.Value = griLista.Rows.Sum(Function(it) CDbl(it.Cells("Produccion").Value))
                        decProduccionSinIGV.Value = griLista.Rows.Sum(Function(it) CDbl(it.Cells("Tesoreria").Value))
                    End If
                ElseIf Tipo = "T" Then
                    CalcularTotales(griLista, "FleteUnitario", "TotalFlete", "KmTractoOrigen", "KmTractoDestino", "KmCarretaOrigen", "KmCarretaDestino", "PorcentajeFlete", "Produccion")
                End If
            End If
            mt_ControlBotoneria()
        Catch ex As Exception
            Throw ex
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Sub ViajesControl(ByVal Tracto As String, ByVal Carreta As String)
        olOperacion = New l_Operacion
        ListaViajeControl = New List(Of e_Viaje)
        oeViaje.TipoOperacion = "C"
        oeViaje.Id = Tracto
        oeViaje.IdTracto = Carreta
        ListaViajeControl = olOperacion.ListarViaje(oeViaje)
    End Sub

    Public Sub ListarDemanda()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            'cambio
            ' LimpiaGrid(griDemanda, ogdDemanda)
            olDemanda = New l_Demanda
            oeDemanda = New e_Demanda

            oeDemanda.TipoOperacion = "5"
            oeDemanda.Zona = cboZonaDemanda.Value
            If codigoDemanda <> "" Then
                oeDemanda.Id = codigoDemanda
            End If
            griDemanda.DataSource = olDemanda.Listar(oeDemanda).Where(Function(item) item.TotalFlete > 0).ToList
            ugb_Espera.Visible = False
        Catch ex As Exception
            Throw ex
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Sub ListarDisponibilidad(ByVal IdTracto As String)
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            olOperacion = New l_Operacion
            olVehiculo = New l_Vehiculo
            LimpiaGrid(griDisponibleVehiculo, ogdDisponibleVehiculos)
            oeViaje = New e_Viaje
            With oeViaje
                .ViajeVacio = 2
                .IndMotriz = 1
                .IdTracto = IdTracto
                .Zona = cboZonaDisponibles.Value
                'se cambio de cboRutaOrigen a cboOrigen
                .IdDestino = cboOrigen.Value
                .Turno = IIf(opcNocheDia.CheckedIndex = 0, 5, 6)
            End With
            griDisponibleVehiculo.DataSource = olOperacion.ListarViaje(oeViaje)
            For I As Integer = 0 To griDisponibleVehiculo.Rows.Count - 1
                With griDisponibleVehiculo.Rows(I)
                    Select Case .Cells("TipoVehiculo").Value
                        Case "PARIHUELERO"
                            .Cells("Carreta").Appearance.BackColor = Me.ColorParihueleroD.Color
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

                    If .Cells("IdCarreta").Value.ToString.Trim <> "" Then
                        If Not olVehiculo.ValidarCarretaMantenimiento(.Cells("IdCarreta").Value) Then
                            .Appearance.BackColor = Me.ColorAdvertencia.Color
                            .Cells("Carreta").Appearance.BackColor = Me.ColorCarreta.Color
                        End If
                    End If
                End With

            Next
            ugb_Espera.Visible = False
        Catch ex As Exception
            Throw ex
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Function ValidaCamposCabecera() As Boolean
        Try
            olPerfil = New l_Perfil
            Dim Cantidad As Double = 0
            Dim Carga As String = "VIAJE"
            Dim Porcentaje As Integer = 0
            Dim FleteUnitarioCarga As Double = 0
            Dim FleteUnitarioViaje As Double = 0
            Dim ClienteCarga As String = ""
            'ValidarCombo(cboRutaOperacion, "Ruta")
            ValidarGrilla(griViajeDetalle, "Carga Operacion")
            ValidarGrilla(griViaje, "Viaje")
            ValidarCombo(cboRutaOrigen, "Ruta Operacion Origen")
            ValidarCombo(cboRutaDestino, "Ruta Operacion Destino")

            'If cboRutaOperacion.Value <> "" Then
            '    oeRuta.Id = cboRutaOperacion.Value
            '    oeRuta.IdOrigen = ""
            '    oeRuta.IdDestino = ""
            '    olRuta.ValidarRutaNueva(oeRuta)
            'Else
            '    'cboRutaOperacion.Focus()
            '    Throw New Exception("Ruta Operacion Seleccionado no existe")
            'End If

            'Dim cont As Integer = 0
            'Dim lista As List(Of e_Viaje) = griViaje.DataSource
            'Dim lista2 As List(Of e_Viaje) = lista.GroupBy(Function(item) item.Tracto)        
            'lista2.Where(Function(item) item.Tracto > 2)
            'cont = lista2.Count
            'If cont > 2 Then
            '    Throw New Exception("No se puede registrar dos viajes con el mismo tracto")
            'End If

            If Operacion = "Editar" Then
                For I As Integer = 0 To griViaje.Rows.Count - 1
                    With griViaje.Rows(I)
                        Dim oeViajeAux As New e_Viaje
                        oeViajeAux.Id = .Cells("Id").Value
                        If oeViajeAux.Id.Trim = "" Then
                            If EstadoViaje <> "1CH00017" And .Cells("Tracto").Value <> TractoTanqueado Then
                                Throw New Exception("No puede modificar Viaje por Motivos que ya fue Reportado por CALL CENTER el Tracto: " & TractoViaje)
                            End If

                            If EstadoViaje <> "1CH00017" And .Cells("Carreta").Text <> CarretaViaje And CarretaViaje <> "" Then
                                Throw New Exception("No puede modificar Viaje por Motivos que ya fue Reportado por CALL CENTER la Carreta: " & CarretaViaje)
                            End If

                            If .Cells("Id").Value = ViajeTanqueado And .Cells("Tracto").Value <> TractoTanqueado And Tanqueo <> "" Then
                                Throw New Exception("No se puede cambiar de Tracto en Viaje asignado a un Tanqueo, Comunicarse con Combustible")
                            End If
                        Else
                            oeViajeAux.TipoOperacion = "P"
                            oeViajeAux = olOperacion.ObtenerViaje(oeViajeAux)
                            If EstadoViaje <> "1CH00017" And .Cells("Tracto").Value <> TractoTanqueado And oeViajeAux.Tracto <> "TFNORTE" And oeViajeAux.Tracto <> "TFSUR" And oeViajeAux.Tracto <> "TFPAMYO" Then
                                Throw New Exception("No puede modificar Viaje por Motivos que ya fue Reportado por CALL CENTER el Tracto: " & TractoViaje)
                            End If

                            If EstadoViaje <> "1CH00017" And .Cells("Carreta").Text <> CarretaViaje And CarretaViaje <> "" Then
                                Throw New Exception("No puede modificar Viaje por Motivos que ya fue Reportado por CALL CENTER la Carreta: " & CarretaViaje)
                            End If

                            If .Cells("Id").Value = ViajeTanqueado And .Cells("Tracto").Value <> TractoTanqueado And Tanqueo <> "" Then
                                Throw New Exception("No se puede cambiar de Tracto en Viaje asignado a un Tanqueo, Comunicarse con Combustible")
                            End If
                        End If
                    End With
                Next
            End If
            Dim contador As Integer = 1
            Dim bandTracto As String = ""
            Dim TractoDuplicado As String = ""
            If verProgramarViajeBloque.Checked = True Then
                For I As Integer = 0 To griViaje.Rows.Count - 1
                    With griViaje.Rows(I)
                        If .Cells("Tracto").Value = bandTracto And bandTracto <> "" Then
                            contador = contador + 1
                            TractoDuplicado = .Cells("Tracto").Text.Trim
                            If contador > 2 Then
                                Exit For
                            End If
                        Else
                            contador = 1
                        End If
                        bandTracto = .Cells("Tracto").Value
                    End With
                Next
                If contador > 2 Then
                    Throw New Exception("No se puede programar el TRACTO: " & TractoDuplicado & " Tiene mas de 2 Viajes. Verifique ?")
                End If
            End If


            For I As Integer = 0 To griViajeDetalle.Rows.Count - 1
                With griViajeDetalle.Rows(I)
                    If .Cells("Carga").Text = "VIAJE" Then
                        Cantidad = .Cells("Cantidad").Value
                    Else
                        Cantidad = .Cells("Cantidad").Value
                    End If

                    If .Cells("Material").Text = "VACIO" And .Cells("Cliente").Text = gs_TxtEmpresaSistema.Trim Then
                        For Each Fila As UltraGridRow In griViaje.Rows.Where(Function(Item) Item.Cells("ViajeVacio").Value = False)
                            Throw New Exception("Cuando la CargaMaterial se igual a - VACIO -, considerar el indicador Vacio para todos sus VIAJES")
                        Next
                    End If
                    Carga = .Cells("Carga").Text
                    ClienteCarga = .Cells("Cliente").Text
                    If Carga = "VIAJE" Then
                        If Cantidad > 1 Then
                            ficViaje.Tabs(1).Selected = True
                            Throw New Exception("Cantidad no puede Superar el Maximo (1) con su Tipo Carga --> " & Carga)
                        End If
                        FleteUnitarioCarga += .Cells("FleteUnitario").Value
                    Else
                        If Carga = "TONELADA" Then
                            If chkIndTercero.Checked Then
                                If Cantidad > 45 Then
                                    ficViaje.Tabs(1).Selected = True
                                    Throw New Exception("Cantidad no puede Superar el Maximo (45) con su Tipo Carga --> " & Carga)
                                End If
                            ElseIf Cantidad > 50 Then
                                ficViaje.Tabs(1).Selected = True
                                Throw New Exception("Cantidad no puede Superar el Maximo (50) con su Tipo Carga --> " & Carga)
                            End If
                            'If Cantidad > 40 Then
                            '    ficViaje.Tabs(1).Selected = True
                            '    Throw New Exception("Cantidad no puede Superar el Maximo (40) con su Tipo Carga --> " & Carga)
                            'End If
                        Else
                            If Carga = "METRO CUBICO" Then
                                If Cantidad > 150 Then
                                    ficViaje.Tabs(1).Selected = True
                                    Throw New Exception("Cantidad no puede Superar el Maximo (150) con su Tipo Carga --> " & Carga)
                                End If
                            End If
                        End If
                    End If
                End With
            Next

            'If PrefijoId <> "1PY" Then '@0001
            For I As Integer = 0 To griViaje.Rows.Count - 1
                    With griViaje.Rows(I)
                        'If PerfilAsignado(gNombrePerfilJefeOperaciones) And PrefijoId = "1CH" And Operacion = "Nuevo" Then
                        '    ''Valida Tracto Viajes sin reportar
                        '    ViajesControl(.Cells("Tracto").Value, "")
                        '    If ListaViajeControl.Count > 4 Then
                        '        TextoMensaje = "Reportar Viajes a la Brevedad"
                        '        oePerfil = New e_Perfil
                        '        oePerfil.TipoOperacion = "M"
                        '        oePerfil.Id = ObtenerPerfilPrincipal.Id
                        '        oePerfil.Codigo = ""
                        '        oePerfil.Nombre = "Area: Operaciones Informa, " & "Tracto: " & .Cells("Tracto").Text & ", Usuario: " & gUsuarioSGI.oePersona.NombreCompleto & ", Dice: " & TextoMensaje
                        '        oePerfil.Activo = True
                        '        olPerfil.Guardar(oePerfil)
                        '        Throw New Exception("No se puede Programar Tracto: " & .Cells("Tracto").Text & Environment.NewLine & _
                        '                        "A superado el limite de viajes no reportados: 3")
                        '    End If
                        '    ''Valida Carreta Viajes sin reportar
                        '    If .Cells("Carreta").Text.Trim <> "" Then
                        '        ViajesControl("", .Cells("Carreta").Value)
                        '        If ListaViajeControl.Count > 4 Then
                        '            TextoMensaje = "Reportar Viajes a la Brevedad"
                        '            oePerfil = New e_Perfil
                        '            oePerfil.TipoOperacion = "M"
                        '            oePerfil.Id = ObtenerPerfilPrincipal.Id
                        '            oePerfil.Codigo = ""
                        '            oePerfil.Nombre = "Area: Operaciones Informa, " & "Carreta: " & .Cells("Carreta").Text & ", Usuario: " & gUsuarioSGI.oePersona.NombreCompleto & ", Dice: " & TextoMensaje
                        '            oePerfil.Activo = True
                        '            olPerfil.Guardar(oePerfil)
                        '            Throw New Exception("No se puede Programar Carreta: " & .Cells("Carreta").Text & Environment.NewLine & _
                        '                            "A superado el limite de viajes no reportados: 3")
                        '        End If
                        '    End If
                        'End If
                        Porcentaje += .Cells("PorcentajeFlete").Value
                        FleteUnitarioViaje += .Cells("FleteUnitario").Value
                    End With
                Next
                If Porcentaje > CInt(txtFletePorcentaje.Text) And verProgramarViajeBloque.Checked = False Then
                    ficViaje.Tabs(0).Selected = True
                    Throw New Exception("La suma de porcentaje en Viajes no puede superar --> " & txtFletePorcentaje.Text)
                'Else '@001
                '    If Porcentaje < CInt(txtFletePorcentaje.Text) Then
                '        ficViaje.Tabs(0).Selected = True
                '        Throw New Exception("La suma de porcentaje en Viajes tiene que proratearse hasta --> " & txtFletePorcentaje.Text)
                '    End If '@001
            End If
            '@001 Ini
            'If Operacion = "Nuevo" Then
            '    If ClienteCarga = "SUPERMERCADOS PERUANOS S.A." Or ClienteCarga = "MAESTRO PERU S.A." Or ClienteCarga = "HIPERMERCADOS TOTTUS S.A." Then
            '        If FleteUnitarioCarga > FleteUnitarioViaje Then
            '            Throw New Exception("El FleteUnitario de la carga es mayor al FleteUnitario Ingresado en Viajes")
            '        End If
            '        If FleteUnitarioViaje > FleteUnitarioCarga Then
            '            Throw New Exception("El FleteUnitario de la carga es menor al FleteUnitario Ingresado en Viajes")
            '        End If
            '    End If
            'End If

            'If Operacion = "Editar" Then
            '    If ClienteCarga = "SUPERMERCADOS PERUANOS S.A." Or ClienteCarga = "MAESTRO PERU S.A." Or ClienteCarga = "HIPERMERCADOS TOTTUS S.A." Then
            '        If FleteUnitarioViaje > FleteUnitarioCarga Then
            '            Throw New Exception("El FleteUnitario de la carga es menor al FleteUnitario Ingresado en Viajes")
            '        End If
            '    End If
            'End If
            '@0001 Fin
            'End If '@0001
            'validacion contrato tercero
            ValidarIngresoContrato()
            'ValidarCorrelatividadConEscala
            lf_ValidarCorrelatividadEscala()
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Function

    Private Function lf_ValidarCorrelatividadEscala()
        Try
            If Operacion = "Nuevo" Then

            ElseIf Operacion = "Editar" Then

            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function EliminarOperaciones(ByVal HACER As String) As Boolean
        Dim testDialog As New frm_justificacion_cancelacion()
        testDialog.tipo = "V"
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()

            'Valida si la Operacion tiene + de un viaje
            oeViaje = New e_Viaje
            ListaViajesOperacion = New List(Of e_Viaje)
            oeViaje.IdOperacion = griLista.ActiveRow.Cells("IdOperacion").Value
            oeViaje.TipoOperacion = "P"
            ListaViajesOperacion.AddRange(olOperacion.ListarViaje(oeViaje))
            If ListaViajesOperacion.Count < 2 Then
                oeViaje = New e_Viaje
                Dim oeViajeAnt = New e_Viaje
                Dim oeViajePost = New e_Viaje
                Dim oeViajeOrig = New e_Viaje
                With oeViaje
                    .Id = griLista.ActiveRow.Cells("Id").Value.ToString
                    .TipoOperacion = "Q"
                    .FechaDesde = ""
                    .FechaHasta = ""
                    .IdEstado = griLista.ActiveRow.Cells("IdOperacion").Value.ToString
                End With
                oeViajeOrig = olOperacion.ObtenerViaje(oeViaje)
                'cambioss
                oeViaje = New e_Viaje
                oeViaje.TipoOperacion = "K"
                oeViaje.Id = griLista.ActiveRow.Cells("IdOperacion").Value.ToString
                oeViaje.IdTracto = griLista.ActiveRow.Cells("IdTracto").Value.ToString
                oeViaje.IdCarreta = griLista.ActiveRow.Cells("IdCarreta").Value.ToString
                oeViaje.FechaDesde = oeViajeOrig.Fecha.ToShortDateString & " " & oeViajeOrig.Fecha.TimeOfDay.ToString.Substring(0, 8)

                If griLista.ActiveRow.Cells("Flota").Value.ToString <> "TERCERIZADOS" Then
                    If oeViajeOrig.Id.Trim <> oeViajeOrig.Estado.Trim Then
                        oeViajeAnt = olOperacion.ObtenerViaje(oeViaje)
                        If oeViajeAnt.IdDestino <> oeViajeOrig.IdOrigen Then
                            mensajeEmergente.Confirmacion("No se puede ELIMINAR el viaje " & oeViaje.Codigo & ", porque PERJUDICA TRAZABILIDAD DE Tracto o Carreta", True)
                            Return False
                        Else
                            oeViaje.TipoOperacion = "L"
                            oeViajePost = olOperacion.ObtenerViaje(oeViaje)
                            If oeViajePost.IdOrigen <> oeViajeOrig.IdDestino Then
                                mensajeEmergente.Confirmacion("No se puede ELIMINAR el viaje " & oeViaje.Codigo & ", porque existen VIAJES POSTERIORES con Tracto o Carreta", True)
                                Return False
                            End If
                        End If
                    End If
                End If
            End If

            Dim ids As String = ""
            Dim codigos As String = ""
            Dim Mensaje As String
            Dim SaldoViajeTesoreria As Decimal = 0
            olOperacion = New l_Operacion
            olFuncionesGenerales = New l_FuncionesGenerales
            With griLista.ActiveRow
                If ValidarGrilla(griLista, "Operacion") Then
                    If gUsuarioSGI.Controlado <> 0 Then
                        olFuncionesGenerales.ValidarFechaCierre("Eliminar", .Cells("Fecha").Value, FechaServidor.Date)
                    End If

                    ''------------------------------
                    ''Valida si la Operacion tiene + de un viaje
                    'oeViaje = New e_Viaje
                    'ListaViajesOperacion = New List(Of e_Viaje)
                    'oeViaje.IdOperacion = .Cells("IdOperacion").Value
                    'oeViaje.TipoOperacion = "P"
                    'ListaViajesOperacion.AddRange(olOperacion.ListarViaje(oeViaje))
                    If ListaViajesOperacion.Count > 1 Then
                        If MessageBox.Show("No se puede eliminar Viaje seleccionado." & Environment.NewLine & _
                                    "La Operaciones tiene " & ListaViajesOperacion.Count & " Viajes asociados." & Environment.NewLine & _
                                    "Desea ver detalle de viajes ? ", _
                                   "Mensaje del Sistema", MessageBoxButtons.YesNo, _
                                   MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            EliminaViajes = False
                            Dim formulario As frm_ViajesOperacion
                            formulario = frm_ViajesOperacion
                            If formulario.ObtenerViajeOperacion(ListaViajesOperacion) Then formulario.ShowDialog()
                            If EliminaViajes = True Then
                                Consultar(True)
                                Return False
                                Exit Function
                            Else
                                Return False
                                Exit Function
                            End If
                        Else
                            Return False
                            Exit Function
                        End If
                    End If

                    oeViaje = New e_Viaje
                    oeViaje.Id = .Cells("Id").Value
                    oeViaje.TipoOperacion = "P"
                    oeViaje = olOperacion.ObtenerViaje(oeViaje)
                    SaldoViajeTesoreria = oeViaje.PesoToneladas
                    If oeViaje.IdCopiloto.Trim = "" Then
                        If oeViaje.Estado = "PROGRAMADO" Then
                            If CInt(oeViaje.Cantidad) = 0 And CInt(oeViaje.FleteUnitario) = 0 And CInt(oeViaje.IncluyeIgv) = 0 Then
                                If oeViaje.Escala.Trim = "" Then
                                    If oeViaje.Tesoreria = "PENDIENTE" Then
                                        Mensaje = "Eliminar"

                                        testDialog.Text = "Motivo de Eliminación"
                                        Dim listaCancelacion = New List(Of e_Combo)
                                        oeCombo = New e_Combo
                                        oeCombo.Nombre = "ConceptoEliminacion"
                                        oeCombo.Descripcion = "Descripcion;NombreTabla;Viaje"
                                        listaCancelacion = olCombo.Listar(oeCombo)
                                        LlenarComboMaestro(testDialog.cboConcepto, listaCancelacion, 0)
                                        If testDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
                                            oeViaje.TipoOperacion = HACER
                                            oeViaje.UsuarioCreacion = gUsuarioSGI.Id
                                            oeViaje.GlosaEscala = motivoCancelacion
                                            oeViaje.Flota = IdConceptoCancEliminacion
                                            'cambios                                           
                                            Cursor.Current = Cursors.WaitCursor
                                            Cursor.Show()
                                            cadenaDemandas = olOperacion.EliminarViajes(oeViaje)

                                            If cadenaDemandas <> "" Then
                                                cadenaDemandas = cadenaDemandas.Substring(0, cadenaDemandas.Length - 1)
                                                cadenaDevuelta = cadenaDemandas.Split(";")
                                                For i As Integer = 0 To cadenaDevuelta.Length - 1
                                                    ids = ids + cadenaDevuelta(i).ToString.Split("-")(0) + "-"
                                                    codigos = codigos + cadenaDevuelta(i).ToString.Split("-")(1) + "-"
                                                Next
                                                codigos = codigos.Substring(0, codigos.Length - 1)
                                                ids = ids.Substring(0, ids.Length - 1)
                                            End If
                                            If cadenaDemandas <> "" Then
                                                If MessageBox.Show("El estado de las DEMANDA(S) " & codigos & " fueron afectadas al ELIMINAR el Viaje: " & _
                                                                     oeViaje.Codigo & " ¿Desea enviar las DEMANDAS a SU CORREO?", _
                                                                     "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                                                    For i As Integer = 0 To ids.Trim.Split("-").Length - 1
                                                        EnviarCorreo(ids.Trim.Split("-")(i))
                                                        'llenarTablaDemanda(ids.Trim.Split("-")(i))
                                                    Next
                                                End If
                                                ids = ""
                                                codigos = ""
                                            End If
                                        Else
                                            Return False
                                            Exit Function
                                        End If
                                    Else
                                        If Tipo = "E" Then
                                            Throw New Exception(oeViaje.Codigo & " Ya fue Habilitado por Tesoreria")
                                        Else
                                            'If MessageBox.Show("Esta seguro de Cancelar el Viaje: " & _
                                            '                    oeViaje.Codigo & " ? Ya fue Habilitado por Tesoreria", _
                                            '                    "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                                            '
                                            'oeViaje = New e_Viaje
                                            'ListaViajesOperacion = New List(Of e_Viaje)
                                            'oeViaje.IdOperacion = .Cells("IdOperacion").Value
                                            'oeViaje.TipoOperacion = "P"
                                            'ListaViajesOperacion.AddRange(olOperacion.ListarViaje(oeViaje))
                                            If CInt(SaldoViajeTesoreria) = 0 Then                                               '

                                                Mensaje = "Cancelar"

                                                testDialog.Text = "Motivo de Cancelación"
                                                Dim listaCancelacion = New List(Of e_Combo)
                                                oeCombo = New e_Combo
                                                oeCombo.Nombre = "ConceptoCancelacion"
                                                oeCombo.Descripcion = "Descripcion;NombreTabla;Viaje"
                                                listaCancelacion = olCombo.Listar(oeCombo)
                                                LlenarComboMaestro(testDialog.cboConcepto, listaCancelacion, 0)

                                                If testDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
                                                    oeViaje.TipoOperacion = HACER
                                                    oeViaje.UsuarioCreacion = gUsuarioSGI.Id
                                                    oeViaje.GlosaEscala = motivoCancelacion
                                                    oeViaje.Flota = IdConceptoCancEliminacion
                                                    cadenaDemandas = olOperacion.EliminarViajes(oeViaje)
                                                    If cadenaDemandas <> "" Then
                                                        cadenaDemandas = cadenaDemandas.Substring(0, cadenaDemandas.Length - 1)
                                                        cadenaDevuelta = cadenaDemandas.Split(";")

                                                        For i As Integer = 0 To cadenaDevuelta.Length - 1
                                                            ids = ids + cadenaDevuelta(i).ToString.Split("-")(0) + "-"
                                                            codigos = codigos + cadenaDevuelta(i).ToString.Split("-")(1) + "-"
                                                        Next
                                                        codigos = codigos.Substring(0, codigos.Length - 1)
                                                        ids = ids.Substring(0, ids.Length - 1)
                                                    End If

                                                    If cadenaDemandas <> "" Then
                                                        If MessageBox.Show("El estado de las DEMANDA(S) " & codigos & " fueron afectadas al ELIMINAR el Viaje: " & _
                                                                             oeViaje.Codigo & " ¿Desea enviar las DEMANDAS a SU CORREO?", _
                                                                             "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                                                            For i As Integer = 0 To ids.Trim.Split("-").Length - 1
                                                                EnviarCorreo(ids.Trim.Split("-")(i))
                                                            Next
                                                        End If
                                                        ids = ""
                                                        codigos = ""
                                                    End If
                                                Else
                                                    Return False
                                                    Exit Function
                                                End If

                                            Else

                                                'Consultar(True)
                                                'Else
                                                '    Return False
                                                '    Exit Function
                                                'End If
                                                Throw New Exception(oeViaje.Codigo & " Ya fue Habilitado por Tesoreria, Consulte su saldo")
                                            End If
                                        End If
                                    End If
                                Else
                                    Throw New Exception(oeViaje.Codigo & " Este viaje tiene tanqueos asociados, Comunicarse con el Area de Combustible")
                                End If
                            Else
                                Throw New Exception(oeViaje.Codigo & " ya se an ingresaron documentos en guias")
                            End If
                        Else
                            Throw New Exception(oeViaje.Codigo & " Se encuentra en Seguimiento")
                        End If
                    Else
                        Throw New Exception("El Viaje no se puede Eliminar/Cancelar pues esta siendo ediatado por" & Environment.NewLine & Environment.NewLine & _
                                    "el Usuario: " & oeViaje.UsuarioModifica & Environment.NewLine & _
                                    "desde: " & oeViaje.LlegadaOrigen & Environment.NewLine & _
                                    "en la Sucursal: " & oeViaje.Piloto)
                    End If



                End If
            End With
            MyBase.Eliminar()
            cadenaDemandas = ""
            ugb_Espera.Visible = False
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Tipo = "E"
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Function

    Private Sub EnviarCorreo(ByVal idDemanda As String)
        Try
            Dim formulario As frm_EnvioEmail
            formulario = New frm_EnvioEmail
            formulario.Modulo = "DemandaRapida"
            formulario.bandFrmExterno = "OP"
            formulario.cadenaMensajeHtml = getFormatoDemanda(idDemanda)
            formulario.ShowDialog()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Function GuardarOperacion() As Boolean
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            'cambioss
            If ValidaCamposCabecera() Then
                If Operacion = "Nuevo" Then
                    oeOperacion.Tipooperacion = "I"
                Else
                    oeOperacion.Tipooperacion = "A"
                    olRuta = New l_Ruta
                    oeRuta = New e_Ruta
                    oeRuta.IdOrigen = cboRutaOrigen.Value
                    oeRuta.IdDestino = cboRutaDestino.Value
                    oeRuta = olRuta.Obtener(oeRuta)
                    RutaOperacion = oeRuta.Id
                End If
                With oeOperacion
                    .Id = txtIdOperacion.Text
                    .Codigo = txtCodigoOperacion.Text
                    .IdRuta = RutaOperacion
                    .IdEstado = txtIdEstadoOperacion.Text
                    .Cantidad = txtCantidadOperacion.Text
                    .FleteUnitario = txtFUnitarioOperacion.Text
                    .TotalFlete = txtFTotalOperacion.Text
                    .Observacion = txtObservacionOperacion.Text
                    .Fecha = Date.Parse(fecOperacion.Value.ToShortDateString & " " & hOperacion.Value.ToShortTimeString)
                    .UsuarioCreacion = gUsuarioSGI.Id
                    .NroOperacionVueltas = NroVueltas.Value
                    .ProgramarBloque = verProgramarViajeBloque.Checked
                    .IndFormato = 0
                    .ActidadNegocio = cboActividadNegocio.Value
                    .oeViaje = griViaje.DataSource
                    For Each Viaje As e_Viaje In .oeViaje
                        Viaje.IdDespachoOperaciones = idDespachoOperaciones
                    Next
                    .oeOperacionDetalle = griViajeDetalle.DataSource
                    .oeIncidenciaAutentificadas = IncidenciasPublic
                    .oeContratoTercero = griDetalleTercero.DataSource
                    .IdTipoVehiculo = Me.cboTipoVehiculo.Value
                    .IndGuiaTercero = Me.chkIndTercero.Checked
                End With
                olOperacion = New l_Operacion
                FiltrarLista()
                oeOperacion.oeListaBitacora = ListaBitacora
                oeOperacion.oeContratoTercero = griDetalleTercero.DataSource
                oeOperacion.PrefijoID = gs_PrefijoIdSucursal '@0001
                If olOperacion.Guardar(oeOperacion) Then
                    EstadoViaje = "1CH00017"
                    ActualizaRegistroEditado(RegistroEditado, IdRegistroEditado)
                    mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                    If MessageBox.Show("Desea Seguir Programando Viajes:  ?", _
                                                         "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                        Nuevo()
                        Return False
                    Else
                        ControlRangoFechaInicializa()
                        'Consultar(True)
                        Operacion = "Inicializa"
                        If griLista.Rows.Count > 0 Then
                            MyBase.Consultar(True)
                            griLista.ActiveRow.CellAppearance.BackColor = Me.colorCambio.Color
                        Else
                            MyBase.Consultar()
                        End If
                        Return True
                    End If
                End If
                ViajeTanqueado = ""
                TractoTanqueado = ""
                Tanqueo = ""
                ugb_Espera.Visible = False
                IncidenciasPublic = New e_IncidenciasAutentificadas
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Function

    Dim fechaReferencia As Date
    Dim fechaReferenciaString As String
    Public Function EditarOperacion() As Boolean
        Try
            Dim RutaLugarDestino As New List(Of e_Ruta)
            If Not bolIndFormExterno AndAlso griLista.ActiveRow.Cells("Id").Value.ToString.Length <= 0 Then
                Throw New Exception("Seleccione viaje a editar")
            End If
            If bolIndFormExterno Then
                oeOperacion.Id = oeViajeExterno.IdOperacion
            Else
                oeOperacion.Id = griLista.ActiveRow.Cells("IdOperacion").Value.ToString
            End If
            olOperacion = New l_Operacion
            oeOperacion = olOperacion.Obtener(oeOperacion)
            If oeOperacion.Id.Trim <> "" Then
                txtIdOperacion.Text = oeOperacion.Id
                txtCodigoOperacion.Text = oeOperacion.Codigo
                RutaOperacion = oeOperacion.IdRuta
                olRuta = New l_Ruta
                oeRuta = New e_Ruta
                oeRuta.Id = RutaOperacion
                oeRuta = olRuta.Obtener(oeRuta)
                RutaIdOrigen = oeRuta.IdOrigen
                RutaIdDestino = oeRuta.IdDestino
                RutaDestino = oeRuta.Destino
                cboRutaOrigen.Value = RutaIdOrigen
                oeRuta = New e_Ruta
                oeRuta.IdDestino = RutaIdDestino
                oeRuta.Destino = RutaDestino
                RutaLugarDestino.Add(oeRuta)
                LlenarComboMaestro(cboRutaDestino, RutaLugarDestino, 0)
                cboRutaDestino.Value = RutaIdDestino

                With oeOperacion
                    txtIdEstadoOperacion.Text = .IdEstado
                    fecOperacion.Value = .Fecha
                    hOperacion.Value = .Fecha
                    txtObservacionOperacion.Text = .Observacion
                    txtCantidadOperacion.Text = .Cantidad
                    txtFUnitarioOperacion.Text = .FleteUnitario
                    txtFTotalOperacion.Value = .TotalFlete
                    cboActividadNegocio.Value = .IdActividadNegocio
                    Me.chkIndTercero.Checked = .IndGuiaTercero
                End With

                oeViaje = New e_Viaje
                If bolIndFormExterno Then
                    oeViaje.Id = oeViajeExterno.Id
                Else
                    oeViaje.Id = griLista.ActiveRow.Cells("Id").Value.ToString
                End If
                With oeViaje
                    .TipoOperacion = "2"
                    .FechaDesde = ""
                    .FechaHasta = ""
                End With
                griViaje.DataSource = olOperacion.ListarViaje(oeViaje)

                oeViaje = olOperacion.ObtenerViaje(oeViaje)
                fechaReferencia = Date.Parse(oeViaje.Fecha.ToShortDateString & " " & oeViaje.Fecha.ToShortTimeString)
                fechaReferenciaString = oeViaje.Fecha.ToShortDateString + " " + oeViaje.Fecha.TimeOfDay.ToString.Substring(0, 8)
                With oeViaje
                    EstadoViaje = .IdEstado
                    fecViaje.Value = .Fecha
                    hViaje.Value = .Fecha
                    verViajeVacio.Checked = .ViajeVacio
                    cboOrigen.Value = .IdOrigen
                    cboDestino.Value = .IdDestino
                    IdDestinoViaje = .IdDestino
                    opcNocheDia.CheckedIndex = .DiaNoche
                    txtFlete.Text = .TotalFlete
                    txtFleteUnitarioViaje.Text = .FleteUnitario
                    If oeViaje.IndEscala = 1 Then
                        verEscala.Checked = True
                        cboEscala.Value = .IdEscala
                    Else
                        verEscala.Checked = False
                        cboEscala.Enabled = False
                    End If
                    cboPiloto.Value = .IdPiloto
                    cboCopiloto.Value = .IdCopiloto
                    cboAyudante.Value = .IdAyudante
                    Me.cboTipoVehiculo.Value = .IdTipoVehiculo
                    Me.cboTipoVehiculo_Validated(Nothing, Nothing)
                    'cargar todos
                    LlenarCombo(cboTracto, "Nombre", TractoPublic.Where(Function(Item) Item.Descripcion = 1 Or Item.Descripcion = 3).ToList, -1)
                    LlenarCombo(cboCarreta, "Nombre", CarretaPublic, -1)
                    'Me.cboTipoVehiculo.Value = .IdTipoVehiculo
                    'Me.cboTipoVehiculo_Validated(Nothing, Nothing)
                    cboTracto.Value = .IdTracto
                    TractoViaje = cboTracto.Text
                    bandTractoFicticio = cboTracto.Text
                    cboCarreta.Text = ""
                    If oeViaje.IdCarreta.Trim <> "" Then
                        verCarreta.Checked = True
                        cboCarreta.Value = .IdCarreta
                        CarretaViaje = cboCarreta.Text
                    End If
                    txtIdViaje.Value = .Id
                    txtCodigoViaje.Value = .Codigo
                    txtGlosaEscala.Text = .GlosaEscala
                    txtCarga.Text = .Carga
                    txtViajeCapacidadUtil.Text = .Capacidad
                    NroTurno.Value = .Turno
                    txtFletePorcentaje.Text = .PorcentajeFlete

                End With

                If oeViaje.IndPlanilla = 0 And oeViaje.Activo = True And oeViaje.Flota.Trim <> "PATIO" Then
                    If oeViaje.Id.Trim = oeViaje.Estado.Trim Then
                        cboDestino.Enabled = True
                        griViaje.DisplayLayout.Bands(0).Columns("Destino").CellActivation = Activation.AllowEdit
                    Else
                        If gUsuarioSGI.Controlado <> 0 Then
                            cboDestino.Enabled = False
                            cboTracto.Enabled = False
                            ' verCarreta.Enabled = False
                            '    verCarreta.Checked = False
                            '      cboCarreta.Enabled = False
                            griViaje.DisplayLayout.Bands(0).Columns("Destino").CellActivation = Activation.NoEdit
                        End If
                    End If
                End If

                oeOperacionDetalle = New e_OperacionDetalle
                oeOperacionDetalle.IdOperacion = oeOperacion.Id
                oeOperacionDetalle.TipoOperacion = ""
                'cambios
                griViajeDetalle.DataSource = olOperacion.ListarOperacionDetalle(oeOperacionDetalle)

                olViajeTercero = New l_ViajesTerceros
                oeContratoTercero = New e_ViajesTerceros
                oeContratoTercero.IdOperacion = oeOperacion.Id
                griDetalleTercero.DataSource = olViajeTercero.Listar(oeContratoTercero)
                If griDetalleTercero.Rows.Count > 0 Then
                    Me.chkIndTercero.Checked = True
                End If
                MostrarTabs(1, ficOperacion, 1)
                Return True
            Else
                Throw New Exception("El Registro se encuentra eliminado y no se puede editar")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Function

    Private Sub ComboGrilla()
        Dim Lugar As New DataTable
        Dim Cliente As New DataTable
        Dim Comisionista As New DataTable
        olCombo = New l_Combo
        Cliente = olCombo.ComboGrilla(ClientesPublic)
        Comisionista = olCombo.ComboGrilla(ComisionistasPublic)

        CrearComboGrid("Cliente", "Nombre", griViajeDetalle, Cliente, True)
        CrearComboGrid("ClienteFinal", "Nombre", griViajeDetalle, Cliente, True)

        CrearComboGrid("Carga", "Nombre", griViajeDetalle, olCombo.ComboGrilla(TipoCargaPublic), True)

        CrearComboGrid("Material", "Nombre", griViajeDetalle, olCombo.ComboGrilla(MaterialesPublic), True)

        CrearComboGrid("Moneda", "Nombre", griViajeDetalle, olCombo.ComboGrilla(MonedaPublic), True)

        CrearComboGrid("IdMoneda", "Nombre", griDetalleTercero, olCombo.ComboGrilla(MonedaPublic), True)
        CrearComboGrid("Comisionista", "Nombre", griViajeDetalle, Comisionista, True)
        CrearComboGrid("IdTercero", "Nombre", griDetalleTercero, olCombo.ComboGrilla(ListTercero), True)
        Dim personacontacto = olCombo.ComboGrilla(PersonasPublic)
        CrearComboGrid("IdContacto", "Nombre", griDetalleTercero, personacontacto, True)

        Lugar = olCombo.ComboGrilla(LugaresPublic)
        CrearComboGrid("Origen", "Nombre", griViaje, Lugar, True)
        CrearComboGrid("Destino", "Nombre", griViaje, Lugar, True)
        CrearComboGrid("Origen", "Nombre", griViajeDetalle, Lugar, True)
        CrearComboGrid("Destino", "Nombre", griViajeDetalle, Lugar, True)
        CrearComboGrid("Escala", "Nombre", griEscala, Lugar, True)

        CrearComboGrid("Piloto", "Nombre", griViaje, olCombo.ComboGrilla(PilotoPublic.ToList), True)

        CrearComboGrid("Copiloto", "Nombre", griViaje, olCombo.ComboGrilla(CopilotoPublic.ToList), True)

        CrearComboGrid("Ayudante", "Nombre", griViaje, olCombo.ComboGrilla(AyudantePublic.ToList), True)

        CrearComboGrid("Tracto", "Nombre", griViaje, olCombo.ComboGrilla(TractoPublic), True)

        CrearComboGrid("Carreta", "Nombre", griViaje, olCombo.ComboGrilla(CarretaPublic), True)

        listaPagoEfectivo = New List(Of e_Combo)
        listaPagoEfectivo.Add(New e_Combo("E", "Efectivo", ""))
        listaPagoEfectivo.Add(New e_Combo("D", "Deposito", ""))
        '
        CrearComboGrid("PagoEfectivoDeposito", "Nombre", griViajeDetalle, olCombo.ComboGrilla(listaPagoEfectivo), True)

    End Sub

    Public Sub LlenaCombos()
        olCombo = New l_Combo
        oeCombo = New e_Combo

        Dim IdOrigen As String = ""
        LlenarComboMaestro(cboTipoVehiculo, ModeloFuncionalPublic, -1)

        LlenarComboMaestro(cboOrigen, LugaresPublic, 0)
        LlenarComboMaestro(cboDestino, LugaresPublic, 0)
        LlenarComboMaestro(cboEscala, LugaresPublic, -1)
        LlenarComboMaestro(cboEscalaBloque, LugaresPublic, -1)

        LlenarComboMaestro(cboPiloto, PilotoPublic.Where(Function(Item) Item.Descripcion = True).ToList, -1)
        LlenarComboMaestro(cboPilotoLista, PilotoPublic, -1)

        LlenarComboMaestro(cboCopiloto, CopilotoPublic.Where(Function(Item) Item.Descripcion = True).ToList, 0)

        LlenarComboMaestro(cboAyudante, AyudantePublic.Where(Function(Item) Item.Descripcion = True).ToList, 0)

        LlenarCombo(cboTractoLista, "Nombre", TractoPublic, -1)
        LlenarCombo(cboTracto, "Nombre", TractoPublic.Where(Function(Item) Item.Descripcion = 1 Or Item.Descripcion = 3).ToList, -1)
        LlenarCombo(cboVehiculoDisponible, "Nombre", TractoPublic, -1)
        LlenarCombo(cboTractoPeso, "Nombre", TractoPublic, -1)

        LlenarCombo(cboCarreta, "Nombre", CarretaPublic, -1)
        LlenarCombo(cboCarretaPeso, "Nombre", CarretaPublic, -1)
        LlenarCombo(cboCarretaLista, "Nombre", CarretaPublic, -1)

        LlenarComboMaestro(cboCliente, ClientesPublic, -1)
        LlenarComboMaestro(cboClienteFinal, ClientesPublic, -1)


        LlenarComboMaestro(cboComisionista, ComisionistasPublic, -1)

        LlenarComboMaestro(cboTipoCarga, TipoCargaPublic, -1)

        'LlenarComboMaestro(cboMaterial, MaterialesPublic.Where(Function(item) item.Descripcion = "OPERACIONESC").ToList, -1)
        LlenarComboMaestro(cboMaterial, MaterialesPublic.ToList, -1)
        LlenarCombo(cboMoneda, "Nombre", MonedaPublic, 0)

        LlenarComboMaestro(cboZona, ZonaPublic, 0)
        LlenarComboMaestro(cboZonaDemanda, ZonaPublic, 0)
        LlenarComboMaestro(cboZonaDisponibles, ZonaPublic, 0)
        LlenarComboMaestro(cboCentro, CentroPublic, 0)

        OperacionesPublic = New List(Of e_Combo)
        oeCombo.Id = ""
        oeCombo.Nombre = ""
        OperacionesPublic.Add(oeCombo)
        oeCombo = New e_Combo
        oeCombo.Nombre = "VENTAS"
        OperacionesPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)
        LlenarComboMaestro(cboActividadNegocio, OperacionesPublic, 0)


        ListTercero = New List(Of e_Combo)
        oeCombo = New e_Combo
        oeCombo.Nombre = "Transportista"
        ListTercero.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)
        LlenarComboMaestro(cboTercero, ListTercero, 1)

        LlenarComboMaestro(cboContacto, ComisionistasPublic, -1)
        '  cboContacto.Text = "NINGUNO  ,"
        LlenarCombo(cboMonedaT, "Nombre", MonedaPublic, 0)
        'Carga Flota
        LlenarComboMaestro(cboFlota, FlotaPublic, 0)
        bolMarcarTodos = True
        cboFlota.SetCheckState(CheckState.Checked)

        'Cargar RUTAS para no validar limite viajes reportados
        loConcepto = New List(Of e_Concepto)
        oeConcepto = New e_Concepto
        oeConcepto.Activo = True
        oeConcepto.Prefijo = "28"
        loConcepto = olConcepto.Listar(oeConcepto)

        'Cargar limite de viajes sin reportar por call center
        loNroViajesReport = New List(Of e_Concepto)
        oeConcepto = New e_Concepto
        oeConcepto.Activo = True
        oeConcepto.Prefijo = "33"
        loNroViajesReport = olConcepto.Listar(oeConcepto)

        'Cargar limite de viajes sin reportar por call center
        lisDiasSupervisor = New List(Of e_Concepto)
        oeConcepto = New e_Concepto
        oeConcepto.Activo = True
        oeConcepto.Prefijo = "42"
        lisDiasSupervisor = olConcepto.Listar(oeConcepto)

        'Cargar limite de viajes sin reportar por call center
        lisDiasJefe = New List(Of e_Concepto)
        oeConcepto = New e_Concepto
        oeConcepto.Activo = True
        oeConcepto.Prefijo = "43"
        lisDiasJefe = olConcepto.Listar(oeConcepto)

    End Sub

    Private Function ValidaCamposDetalle() As Boolean
        Try
            olOperacion = New l_Operacion
            olVehiculo = New l_Vehiculo
            olTrabajador = New l_Trabajador
            olPerfil = New l_Perfil
            IndPropiedadTractoTemp = 1
            IndPropiedadCarretaTemp = 1
            Dim FechaActual As Date
            FechaActual = FechaServidor.AddDays(-1).Date
            TextoMensaje = ""
            olVehiculo = New l_Vehiculo
            oeVehiculo = New e_Vehiculo
            oeVehiculo.TipoOperacion = "A"
            oeVehiculo.Id = cboTracto.Value
            'Recupera informacion de Tracto
            oeVehiculo = olVehiculo.Obtener(oeVehiculo)
            'Nombre Flota
            If FlotaPublic.Where(Function(item) item.Id = oeVehiculo.IdFlota).Count > 0 Then
                FlotaTracto = FlotaPublic.Where(Function(item) item.Id = oeVehiculo.IdFlota).ToList(0).Nombre
            End If
            If Not String.IsNullOrWhiteSpace(oeVehiculo.Id) Then
                NombrePropTracto = oeVehiculo.EmpresaPropietaria
            End If
            If verEscala.Checked AndAlso txtGlosaEscala.Text.Trim().Length = 0 Then
                txtGlosaEscala.Focus()
                Throw New Exception("Ingrese Motivo de la creacion de escala para la operacion")
            End If
            ValidarGrilla(griViajeDetalle, "Operacion Detalle")
            ValidarCombo(cboOrigen, "Origen")
            ValidarCombo(cboDestino, "Destino")
            ValidarCombo(cboPiloto, "Piloto")
            ValidarCombo(cboCopiloto, "Copiloto")
            ValidarCombo(cboAyudante, "Ayudante")
            ValidarCombo(cboTracto, "Tracto")
            If Operacion = "Nuevo" OrElse Operacion = "Editar" Then
                '@0001 Ini
                'If PrefijoId = "1PY" And HoraNoche <= hViaje.Value.ToShortTimeString Then
                '    If verFechaViaje.Checked = True And Operacion = "Nuevo" And CDate(fecViaje.Value) < (FechaServidor.AddDays(lisDiasSupervisor(0).Valor1)).Date Then
                '        fecViaje.Focus()
                '        fecViaje.Value = FechaServidor.Date
                '        Throw New Exception("La fecha de atención no puede ser menor a la fecha actual")
                '    End If
                '    If verFechaViaje.Checked = True And Operacion = "Editar" And CDate(fecViaje.Value) < oeViaje.Fecha Then
                '        fecViaje.Focus()
                '        fecViaje.Value = oeViaje.Fecha
                '        Throw New Exception("La fecha de atención no puede ser menor a la fecha programada")
                '    End If
                'Else 
                '@0001 Fin
                If verFechaViaje.Checked = True And Operacion = "Nuevo" And CDate(fecViaje.Value) < (FechaServidor.AddDays(lisDiasSupervisor(0).Valor1)).Date Then
                    fecViaje.Focus()
                    fecViaje.Value = FechaServidor.Date
                    Throw New Exception("La fecha de atención no puede ser menor a la fecha actual")
                End If
                If verFechaViaje.Checked = True And Operacion = "Editar" And CDate(fecViaje.Value) < oeViaje.Fecha.Date Then
                    fecViaje.Focus()
                    fecViaje.Value = oeViaje.Fecha
                    Throw New Exception("La fecha de atención no puede ser menor a la fecha programada")
                End If
                'End If  '@0001
                Try
                    'fecha no coincide con la del viaje
                    If verFechaViaje.Checked = False Then
                        If CDate(fecViaje.Value) < (FechaServidor.AddDays(lisDiasSupervisor(0).Valor1)).Date Then
                            If MessageBox.Show("No esta autorizado para ingresar/modificar" & Environment.NewLine & _
                                                                            "viajes en fechas anteriores comuniquese con el " & gNombrePerfilJefeOperaciones & Environment.NewLine & _
                                                                            "Desea Seguir Programando Viajes:  ?", _
                                                                         "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                                IncidenciasPublic = New e_IncidenciasAutentificadas
                                Dim formulario As frm_Autorizacion
                                formulario = frm_Autorizacion
                                If formulario.ObtenerJefes(gNombrePerfilAutorizaOperaciones, "frm_Operacion", pIdActividadNegocio) Then formulario.ShowDialog()
                                If IncidenciasPublic.IdResponsableAutoriza.Trim = "" Then
                                    verFechaViaje.Checked = True
                                    Return False
                                Else
                                    Dim oeTrabajador As New e_Trabajador
                                    Dim olTrabajador As New l_Trabajador
                                    Dim dias As Integer = 0
                                    oeTrabajador.TipoOperacion = "F"
                                    oeTrabajador.oePersona.Id = IncidenciasPublic.IdResponsableAutoriza.Trim
                                    oeTrabajador.Activo = True
                                    oeTrabajador = olTrabajador.Obtener(oeTrabajador)
                                    For Each concep In lisDiasJefe
                                        If concep.Valor2 = oeTrabajador.oeOcupacion.Id Then
                                            dias = concep.Valor1
                                            Exit For
                                        End If
                                    Next

                                    If CDate(fecViaje.Value) < (FechaServidor.AddDays(dias)).Date Then
                                        MessageBox.Show("La ocupación " & oeTrabajador.oeOcupacion.Nombre & " solo tiene " & (dias * -1) & "dias de retraso.", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        verFechaViaje.Checked = True
                                        Return False
                                    End If
                                End If
                            Else
                                fecViaje.Value = FechaServidor.Date
                                verFechaViaje.Checked = True
                                Return False
                            End If
                        End If

                        'If Not PerfilAsignado(gNombrePerfilAutorizaOperaciones) Then
                        '    If CDate(fecViaje.Value) < FechaServidor.Date Then
                        '        If MessageBox.Show("No esta autorizado para ingresar/modificar" & Environment.NewLine & _
                        '                                                        "viajes en fechas anteriores comuniquese con el " & gNombrePerfilJefeOperaciones & Environment.NewLine & _
                        '                                                        "Desea Seguir Programando Viajes:  ?", _
                        '                                                     "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                        '            IncidenciasPublic = New e_IncidenciasAutentificadas
                        '            Dim formulario As frm_Autorizacion
                        '            formulario = frm_Autorizacion
                        '            If formulario.ObtenerJefes(gNombrePerfilAutorizaOperaciones, "frm_Operacion", pIdActividadNegocio) Then formulario.ShowDialog()
                        '            If IncidenciasPublic.IdResponsableAutoriza.Trim = "" Then
                        '                verFechaViaje.Checked = True
                        '                Return False
                        '            End If
                        '        Else
                        '            fecViaje.Value = FechaServidor.Date
                        '            verFechaViaje.Checked = True
                        '            Return False
                        '        End If
                        '    End If
                        'End If
                        ''cambios
                        ''Else
                        ''    Dim OrigenViaje As String
                        ''    OrigenViaje = cboOrigen.Value
                        ''    oeViaje = New e_Viaje
                        ''    oeViaje.Id = cboTracto.Value
                        ''    oeViaje.TipoOperacion = "4"
                        ''    'ViajeVacio  = 1 Para Validar Programacion Viaje Correlatividad
                        ''    oeViaje.ViajeVacio = 1
                        ''    'se obtiene el ultimo viaje del tracto
                        ''    oeViaje = olOperacion.ObtenerViaje(oeViaje)
                        ''    'Si se agrega viaje nuevo al ultimo, verifica traz y fecha
                        ''    If Operacion = "Nuevo" Then
                        ''        If (oeViaje IsNot Nothing And OrigenViaje = oeViaje.IdDestino And oeViaje.Flota <> "CAMIONETAS" And oeViaje.Id <> "" And
                        ''        IndPropiedadTractoTemp = 1 And oeViaje.Fecha >= Date.Parse(fecViaje.Value.ToShortDateString & " " & hViaje.Value.ToShortTimeString)) Then
                        ''            Throw New Exception("Fecha debe ser mayor al ultimo viaje. Verifique")
                        ''        End If
                        ''    End If                        
                    End If
                Catch ex As Exception
                    Throw ex
                End Try
            End If
            If cboCarreta.Text.Trim <> "" Then
                If CDbl(txtViajeCapacidadUtil.Value) = 0 Then
                    tabAdicional.Tabs(0).Selected = True
                    Throw New Exception("Ingrese Capacidad Util en kilogramos, Apoyarse con el simulador de peso")
                Else
                    If CDec(txtViajeCapacidadUtil.Value) < 10000 Then
                        tabAdicional.Tabs(0).Selected = True
                        Throw New Exception("La Capacidad Util ingresada es inferiror a su capacidad unido, Carreta y Tracto")
                    End If
                End If
            End If
            If Not olTrabajador.ValidarTrabajador(cboPiloto.Value) Then
                cboPiloto.Focus()
                Throw New Exception("Piloto Seleccionado no Existe")
            End If
            If cboPiloto.Value = cboCopiloto.Value Then
                Throw New Exception("Piloto y Copiloto son los Mismo")
            End If
            If cboPiloto.Value = cboAyudante.Value Then
                Throw New Exception("Piloto y Ayudante son los Mismo")
            End If
            If cboCopiloto.Value <> "0" Then
                If cboCopiloto.Value = cboAyudante.Value Then
                    Throw New Exception("Copiloto y Ayudante son los Mismo")
                End If
            End If
            If cboCopiloto.Value <> "0" Then
                If Not olTrabajador.ValidarTrabajador(cboCopiloto.Value) Then
                    cboCopiloto.Focus()
                    Throw New Exception("CoPiloto Seleccionado no Existe")
                End If
            End If
            If cboAyudante.Value <> "0" Then
                If Not olTrabajador.ValidarTrabajador(cboAyudante.Value) Then
                    cboAyudante.Focus()
                    Throw New Exception("Ayudante Seleccionado no Existe")
                End If
            End If
            oeVehiculo = New e_Vehiculo
            oeVehiculo.Id = cboTracto.Value
            oeVehiculo = olVehiculo.ValidarVehiculo(oeVehiculo)
            IndPropiedadTractoTemp = oeVehiculo.IndPropiedad
            If verEscala.Checked Then
                ValidarCombo(cboEscala, "Escala")
                ValidaEscala("Origen y Escala ", cboOrigen.Value, cboEscala.Value)
                ValidaEscala("Escala y Destino ", cboEscala.Value, cboDestino.Value)
                If IndPropiedadTractoTemp = 1 Then
                    lf_ValidaMontoRuta(cboOrigen.Text & " - " & cboEscala.Text, cboOrigen.Value, cboEscala.Value)
                    lf_ValidaMontoRuta(cboEscala.Text & " - " & cboDestino.Text, cboEscala.Value, cboDestino.Value)
                End If
            Else
                'Agregado para validar monto Ruta
                If IndPropiedadTractoTemp = 1 Then
                    lf_ValidaMontoRuta(cboOrigen.Text & " - " & cboDestino.Text, cboOrigen.Value, cboDestino.Value)
                End If
            End If
            Dim IdMaterialAux As String = String.Empty
            If oeOperacion.oeOperacionDetalle.Count > 0 Then IdMaterialAux = oeOperacion.oeOperacionDetalle(0).Material
            'If Not PerfilAsignado(gNombrePerfilJefeOperaciones) And PrefijoId = "1CH" And FlotaTracto <> "CAMIONETA" And oeVehiculo.IndPropiedad = 1 And (IdMaterialAux <> "1CH000001513" And IdMaterialAux <> "1CH000000001" And IdMaterialAux <> "") Then '@0001
            If Not PerfilAsignado(gNombrePerfilJefeOperaciones) And FlotaTracto <> "CAMIONETA" And oeVehiculo.IndPropiedad = 1 And (IdMaterialAux <> "1CH000000001" And IdMaterialAux <> "") Then
                Dim listaRutasNoValidar = loConcepto.Where(Function(item) item.Valor1.Trim = RutaOperacion).ToList
                If listaRutasNoValidar.Count = 0 Then
                    ViajesControl(cboTracto.Value, "")
                    If ListaViajeControl.GroupBy(Function(item) item.IdOperacion).Count > Integer.Parse(loNroViajesReport(0).Valor1) Then
                        If MessageBox.Show("No se puede Programar Tracto: " & cboTracto.Text & Environment.NewLine &
                                         "A superado el limite de viajes no reportados: " & loNroViajesReport(0).Valor1 & Environment.NewLine &
                                         "Desea ver detalle de viajes ? ",
                                        "Mensaje del Sistema", MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            Dim TextoTotal As String = ""
                            For Each Viaje As e_Viaje In ListaViajeControl
                                TextoTotal += "Viaje: " & Viaje.Codigo & ", Fecha: " & Viaje.Fecha.Date & Environment.NewLine &
                                                "Ruta: " & Viaje.Origen & "-" & Viaje.Destino & " Estado: " & Viaje.Estado & Environment.NewLine & Environment.NewLine
                            Next
                            MessageBox.Show(TextoTotal, "Mensaje del Sistema    Tracto: " & cboTracto.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                        TextoMensaje = "Reportar Viajes a la Brevedad"
                        oePerfil = New e_Perfil
                        oePerfil.TipoOperacion = "M"
                        oePerfil.Id = ObtenerPerfilPrincipal.Id
                        oePerfil.Nombre = "Area: Operaciones Informa, " & "Tracto: " & cboTracto.Text & ", Usuario: " & gUsuarioSGI.oePersona.NombreCompleto & ", Dice: " & TextoMensaje
                        oePerfil.PrefijoID = gs_PrefijoIdSucursal '@0001
                        olPerfil.Guardar(oePerfil)
                        Return False
                    End If
                End If
            End If
            If Operacion = "Nuevo" AndAlso verValidaciones.Checked Then
                oeVehiculo = New e_Vehiculo
                oeVehiculo.Id = cboTracto.Value
                oeVehiculo.TipoOperacion = "O"
                oeVehiculo = olVehiculo.Obtener(oeVehiculo)
                If oeVehiculo.Id.Trim <> "" AndAlso fecViaje.Value.Date > oeVehiculo.Fecha.Date Then
                    oePerfil = New e_Perfil
                    oePerfil.TipoOperacion = "M"
                    oePerfil.Id = "1CH000000005"
                    oePerfil.Nombre = "Area: Operaciones Informa, " & "Usuario: " & gUsuarioSGI.oePersona.NombreCompleto & ", Tracto: " & cboTracto.Text & ", Se encuentra en Mantenimiento sin Liberar"
                    oePerfil.PrefijoID = gs_PrefijoIdSucursal '@0001
                    olPerfil.Guardar(oePerfil)
                    cboTracto.Focus()
                    Throw New Exception("Tracto Seleccionado se encuentra en Mantenimiento. Fecha Tentativa Salida: " & oeVehiculo.Fecha.ToString)
                End If
            End If
            If verCarreta.Checked = True Then
                ValidarCombo(cboCarreta, "Carreta")
                oeVehiculo = New e_Vehiculo
                oeVehiculo.Id = cboCarreta.Value
                oeVehiculo = olVehiculo.ValidarVehiculo(oeVehiculo)
                IndPropiedadCarretaTemp = oeVehiculo.IndPropiedad
                'If Not PerfilAsignado(gNombrePerfilJefeOperaciones) And PrefijoId = "1CH" And oeVehiculo.IndPropiedad = 1 And (IdMaterialAux <> "1CH000001513" And IdMaterialAux <> "1CH000000001" And IdMaterialAux <> "") Then
                If Not PerfilAsignado(gNombrePerfilJefeOperaciones) And oeVehiculo.IndPropiedad = 1 And (IdMaterialAux <> "1CH000000001" And IdMaterialAux <> "") Then
                    Dim listaRutasNoValidar = loConcepto.Where(Function(item) item.Valor1.Trim = RutaOperacion).ToList
                    If listaRutasNoValidar.Count = 0 Then
                        ViajesControl("", cboCarreta.Value)
                        If ListaViajeControl.GroupBy(Function(item) item.IdOperacion).Count > Integer.Parse(loNroViajesReport(0).Valor1) Then
                            If MessageBox.Show("No se puede Programar Carreta: " & cboCarreta.Text & Environment.NewLine &
                                                "A superado el limite de viajes no reportados: " & loNroViajesReport(0).Valor1 & Environment.NewLine &
                                                "Desea ver detalle de viajes ? ",
                                                "Mensaje del Sistema", MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

                                Dim TextoTotal As String = ""
                                For Each Viaje As e_Viaje In ListaViajeControl
                                    TextoTotal += "Viaje: " & Viaje.Codigo & ", Fecha:" & Viaje.Fecha.Date & Environment.NewLine &
                                                  "Ruta: " & Viaje.Origen & "-" & Viaje.Destino & ", Estado: " & Viaje.Estado & Environment.NewLine & Environment.NewLine
                                Next
                                MessageBox.Show(TextoTotal, "Mensaje del Sistema    Carreta: " & cboCarreta.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                            TextoMensaje = "Reportar Viajes a la Brevedad"
                            oePerfil = New e_Perfil
                            oePerfil.TipoOperacion = "M"
                            oePerfil.Id = ObtenerPerfilPrincipal.Id
                            oePerfil.Nombre = "Area: Operaciones Informa, " & "Carreta: " & cboCarreta.Text & ", Usuario: " & gUsuarioSGI.oePersona.NombreCompleto & ", Dice: " & TextoMensaje
                            oePerfil.PrefijoID = gs_PrefijoIdSucursal '@0001
                            olPerfil.Guardar(oePerfil)
                            Return False
                        End If
                    End If
                End If
                oeVehiculo = New e_Vehiculo
                oeVehiculo.Id = cboCarreta.Value
                oeVehiculo.TipoOperacion = "O"
                oeVehiculo = olVehiculo.Obtener(oeVehiculo)
                If oeVehiculo.Id.Trim <> "" Then
                    oePerfil = New e_Perfil
                    oePerfil.TipoOperacion = "M"
                    oePerfil.Id = "1CH000000005"
                    oePerfil.Nombre = "Area: Operaciones Informa, " & "Usuario: " & gUsuarioSGI.oePersona.NombreCompleto & ", Carreta: " & cboCarreta.Text & ", Se encuentra en Mantenimiento sin Liberar"
                    oePerfil.PrefijoID = gs_PrefijoIdSucursal '@0001
                    olPerfil.Guardar(oePerfil)
                    cboCarreta.Focus()
                    Throw New Exception("Carreta Seleccionada se encuentra en Mantenimiento. Fecha Tentativa Salida: " & oeVehiculo.Fecha)
                End If
            End If

            If Operacion = "Nuevo" And verValidaciones.Checked Then
                'TRACTO
                Dim OrigenViaje As String
                OrigenViaje = cboOrigen.Value
                oeViaje = New e_Viaje
                oeViaje.Id = cboTracto.Value
                oeViaje.IndMotriz = 1
                oeViaje.TipoOperacion = "4"
                'ViajeVacio  = 1 Para Validar Programacion Viaje Correlatividad
                oeViaje.ViajeVacio = 1
                'se obtiene el ultimo viaje del tracto
                oeViaje = olOperacion.ObtenerViaje(oeViaje)
                'Si se agrega viaje nuevo al ultimo, verifica trazabilidad y fecha
                Dim fechaC = Date.Parse(fecViaje.Value.ToShortDateString & " " & hViaje.Value.ToShortTimeString)
                If oeViaje.Id <> String.Empty AndAlso DateTime.Compare(oeViaje.Fecha, fechaC) = 0 Then
                    Throw New Exception("Fecha debe ser mayor al ultimo viaje " & oeViaje.Codigo & " " & oeViaje.Fecha)
                End If
                If (oeViaje IsNot Nothing And OrigenViaje <> oeViaje.IdDestino And oeViaje.Flota <> "CAMIONETAS" And oeViaje.Id <> "" And
                    IndPropiedadTractoTemp = 1 And oeViaje.Fecha <= fechaC) Then
                    If MessageBox.Show("No se puede Programar Tracto, Con Origen: " & cboOrigen.Text & Environment.NewLine & _
                                        "Ultimo Viaje: " & oeViaje.Codigo & Environment.NewLine & _
                                        "Fecha Viaje: " & oeViaje.Fecha.ToString & Environment.NewLine & _
                                        "Estado Viaje: " & oeViaje.Estado & Environment.NewLine & _
                                        "Ruta Viaje: " & oeViaje.Origen & " - " & oeViaje.Destino & Environment.NewLine & _
                                        "Desea programar viaje con ultimo DESTINO: " & oeViaje.Destino, _
                                        "Mensaje del Sistema", MessageBoxButtons.YesNo, _
                                        MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                        cboRutaOrigen.Value = oeViaje.IdDestino
                        cboRutaOrigen.Focus()
                        cboRutaDestino.Value = OrigenViaje
                        Return False
                    Else
                        Return False
                    End If
                Else
                    If IndPropiedadTractoTemp = 1 Then
                        'si no se agrega al ultimo(en medio), se verifica al viaje anterior y el posterior
                        'Verificar trazabilidad de TRACTO
                        oeViaje = New e_Viaje
                        Dim oeViajeAnt = New e_Viaje
                        Dim oeViajePost = New e_Viaje
                        Dim oeViajeOrig = New e_Viaje
                        With oeViaje
                            .FechaDesde = fecViaje.Value.ToShortDateString & " " & hViaje.Value.ToShortTimeString
                            .FechaHasta = fecViaje.Value.ToShortDateString & " " & hViaje.Value.ToShortTimeString
                            .IdOrigen = cboOrigen.Value
                            .IdDestino = cboDestino.Value
                            .Fecha = Date.Parse(fecViaje.Value.ToShortDateString & " " & hViaje.Value.ToShortTimeString)
                        End With
                        oeViajeOrig = oeViaje
                        oeViaje = New e_Viaje
                        oeViaje.TipoOperacion = "K"
                        oeViaje.Id = ""
                        oeViaje.IdTracto = cboTracto.Value
                        oeViaje.IdCarreta = ""
                        oeViaje.FechaDesde = oeViajeOrig.Fecha.ToShortDateString & " " & oeViajeOrig.Fecha.TimeOfDay.ToString.Substring(0, 8)
                        oeViajeAnt = olOperacion.ObtenerViaje(oeViaje)
                        Dim bandIngresa As String = "N"
                        If oeViajeAnt.Id <> String.Empty AndAlso oeViajeAnt.IdDestino <> oeViajeOrig.IdOrigen Then
                            bandIngresa = ""
                        Else
                            oeViaje.TipoOperacion = "L"
                            oeViaje.FechaDesde = oeViajeOrig.Fecha.ToShortDateString & " " & oeViajeOrig.Fecha.TimeOfDay.ToString.Substring(0, 8)
                            oeViajePost = olOperacion.ObtenerViaje(oeViaje)
                            If oeViajePost.Id <> String.Empty AndAlso oeViajePost.IdOrigen <> oeViajeOrig.IdDestino Then
                                bandIngresa = ""
                            End If
                        End If
                        If bandIngresa = "" AndAlso FlotaTracto <> "TERCERIZADOS" Then
                            Throw New Exception("EL viaje que desea ingresar PERJUDICA TRAZABILIDAD del tracto " + cboTracto.Text + ". Verifique FECHAS")
                        End If
                    End If
                End If
                'CARRETA
                If verCarreta.Checked Then
                    oeViaje = New e_Viaje
                    oeViaje.Id = cboCarreta.Value
                    oeViaje.IndMotriz = 0
                    oeViaje.TipoOperacion = "4"
                    'ViajeVacio  = 1 Para Validar Programacion Viaje Correlatividad
                    oeViaje.ViajeVacio = 1
                    oeViaje = olOperacion.ObtenerViaje(oeViaje)
                    fechaC = Date.Parse(fecViaje.Value.ToShortDateString & " " & hViaje.Value.ToShortTimeString)
                    'verifica traz del ultimo viaje
                    If oeViaje IsNot Nothing And OrigenViaje <> oeViaje.IdDestino And oeViaje.Id.Trim <> "" And IndPropiedadCarretaTemp = 1 And oeViaje.Fecha <= fechaC Then
                        If MessageBox.Show("No se puede Programar Carreta, Con Origen: " & cboOrigen.Text & Environment.NewLine & _
                                  "Ultimo Viaje: " & oeViaje.Codigo & Environment.NewLine & _
                                  "Fecha Viaje: " & oeViaje.Fecha.ToString & Environment.NewLine & _
                                  "Estado Viaje: " & oeViaje.Estado & Environment.NewLine & _
                                  "Ruta Viaje: " & oeViaje.Origen & " - " & oeViaje.Destino & Environment.NewLine & _
                                  "Desea programar viaje con ultimo DESTINO: " & oeViaje.Destino, _
                                  "Mensaje del Sistema", MessageBoxButtons.YesNo, _
                                  MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            cboRutaOrigen.Value = oeViaje.IdDestino
                            cboRutaOrigen.Focus()
                            cboRutaDestino.Value = OrigenViaje
                            Return False
                        Else
                            Return False
                        End If
                    Else
                        If IndPropiedadCarretaTemp = 1 Then
                            'Verificar trazabilidad de CARRETA
                            oeViaje = New e_Viaje
                            Dim oeViajeAnt = New e_Viaje
                            Dim oeViajePost = New e_Viaje
                            Dim oeViajeOrig = New e_Viaje
                            With oeViaje
                                .FechaDesde = fecViaje.Value.ToShortDateString & " " & hViaje.Value.ToShortTimeString
                                .FechaHasta = fecViaje.Value.ToShortDateString & " " & hViaje.Value.ToShortTimeString
                                .IdOrigen = cboOrigen.Value
                                .IdDestino = cboDestino.Value
                                .Fecha = Date.Parse(fecViaje.Value.ToShortDateString & " " & hViaje.Value.ToShortTimeString)
                            End With
                            oeViajeOrig = oeViaje
                            oeViaje = New e_Viaje
                            oeViaje.TipoOperacion = "K"
                            oeViaje.Id = ""
                            oeViaje.IdTracto = ""
                            oeViaje.IdCarreta = cboCarreta.Value
                            oeViaje.FechaDesde = oeViajeOrig.Fecha.ToShortDateString & " " & oeViajeOrig.Fecha.TimeOfDay.ToString.Substring(0, 8)
                            oeViajeAnt = olOperacion.ObtenerViaje(oeViaje)
                            Dim bandIngresa As String = "N"
                            If oeViajeAnt.Id <> String.Empty AndAlso oeViajeAnt.IdDestino <> oeViajeOrig.IdOrigen Then
                                bandIngresa = ""
                            Else
                                oeViaje.TipoOperacion = "L"
                                oeViaje.FechaDesde = oeViajeOrig.Fecha.ToShortDateString & " " & oeViajeOrig.Fecha.TimeOfDay.ToString.Substring(0, 8)
                                oeViajePost = olOperacion.ObtenerViaje(oeViaje)
                                If oeViajePost.Id <> "" AndAlso oeViajePost.IdOrigen <> oeViajeOrig.IdDestino Then
                                    bandIngresa = ""
                                End If
                            End If
                            If bandIngresa = "" AndAlso IndPropiedadCarretaTemp = 1 Then
                                Throw New Exception("EL viaje que desea ingresar PERJUDICA TRAZABILIDAD de la carreta " + cboCarreta.Text + ". Verifique FECHAS")
                            End If
                        End If
                    End If
                End If
                'Valida a Piloto Trazabilidad
                oeViaje = New e_Viaje
                oeViaje.IdEstado = cboPiloto.Value
                oeViaje.TipoOperacion = "4"
                'ViajeVacio  = 1 Para Validar Programacion Viaje Correlatividad
                oeViaje.ViajeVacio = 1
                oeViaje = olOperacion.ObtenerViaje(oeViaje)
                'Transabilidad Destino Ultimo
                If OrigenViaje <> oeViaje.IdDestino And oeViaje.Flota <> "CAMIONETAS" And oeViaje.Id <> "" Then
                    If MessageBox.Show("No se puede Programar Piloto, Con Origen: " & cboOrigen.Text & Environment.NewLine & _
                                        "Ultimo Viaje: " & oeViaje.Codigo & Environment.NewLine & _
                                        "Fecha Viaje: " & oeViaje.Fecha.ToString & Environment.NewLine & _
                                        "Estado Viaje: " & oeViaje.Estado & Environment.NewLine & _
                                        "Ruta Viaje: " & oeViaje.Origen & " - " & oeViaje.Destino & Environment.NewLine & _
                                        "Desea seguir programando a Piloto con diferente Ubicacion ? ", _
                                        "Mensaje del Sistema", MessageBoxButtons.YesNo, _
                                        MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) <> Windows.Forms.DialogResult.Yes Then
                        Return False
                    End If
                End If
                'Transabilidad Misma Fecha diferentes Unidades
                If fecViaje.Value.Date.ToString = oeViaje.Fecha.Date.ToString And cboTracto.Value <> oeViaje.IdTracto And oeViaje.Flota <> "CAMIONETAS" And oeViaje.Id <> "" Then
                    If MessageBox.Show("No se puede Programar Piloto, Con la UNIDAD: " & cboTracto.Text & Environment.NewLine & _
                                       "Con Fecha: " & fecViaje.Value.Date.ToString & " Tiene Programacion sus Datos:" & Environment.NewLine & _
                                        "Ultimo Viaje: " & oeViaje.Codigo & Environment.NewLine & _
                                        "Fecha Viaje: " & oeViaje.Fecha.ToString & Environment.NewLine & _
                                        "Tracto: " & oeViaje.Tracto & " , Carreta: " & oeViaje.Carreta.Trim & Environment.NewLine & _
                                        "Estado Viaje: " & oeViaje.Estado & Environment.NewLine & _
                                        "Ruta Viaje: " & oeViaje.Origen & " - " & oeViaje.Destino & Environment.NewLine & _
                                        "Desea seguir programando a Piloto con UNIDAD en la misma FECHA ?", _
                                        "Mensaje del Sistema", MessageBoxButtons.YesNo, _
                                        MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) <> Windows.Forms.DialogResult.Yes Then
                        Return False
                    End If
                End If
            Else 'ENTRA EN CASO DE EDITAR REGISTRO
                If Operacion = "Editar" And verValidaciones.Checked And gUsuarioSGI.Controlado <> 0 Then
                    Dim DestinoViaje As String
                    Dim FechaViaje As Date
                    DestinoViaje = cboDestino.Value
                    FechaViaje = Date.Parse(fecViaje.Value.ToShortDateString & " " & hViaje.Value.ToShortTimeString)
                    oeViaje = New e_Viaje
                    oeViaje.Id = cboTracto.Value
                    oeViaje.TipoOperacion = "4"
                    oeViaje.IndMotriz = 1
                    'ViajeVacio  = 1 Para Validar Programacion Viaje Correlatividad
                    oeViaje.ViajeVacio = 1
                    oeViaje = olOperacion.ObtenerViaje(oeViaje)
                    'Verfica si es el ultmio viaje
                    'If oeViaje.Id <> txtIdViaje.Text.Trim() And oeViaje.Id.Trim <> "" And IndPropiedadCarretaTemp = 1 Then
                    oeViaje = New e_Viaje
                    Dim oeViajeAnt = New e_Viaje
                    Dim oeViajePost = New e_Viaje
                    Dim oeViajeOrig = New e_Viaje
                    Dim bandIngresa As String = "N"
                    'Validacion trazabilidad TRACTO
                    With oeViaje
                        .FechaDesde = fecViaje.Value.ToShortDateString & " " & hViaje.Value.ToShortTimeString
                        .FechaHasta = fecViaje.Value.ToShortDateString & " " & hViaje.Value.ToShortTimeString
                        .IdOrigen = cboOrigen.Value
                        .IdDestino = cboDestino.Value
                        .Fecha = Date.Parse(fecViaje.Value.ToShortDateString & " " & hViaje.Value.ToShortTimeString)
                    End With
                    oeViajeOrig = oeViaje
                    oeViaje = New e_Viaje
                    oeViaje.TipoOperacion = "K"
                    oeViaje.Id = ""
                    oeViaje.IdTracto = cboTracto.Value
                    oeViaje.IdCarreta = ""
                    oeViaje.FechaDesde = oeViajeOrig.Fecha.ToShortDateString & " " & oeViajeOrig.Fecha.TimeOfDay.ToString.Substring(0, 8)
                    'Viaje anterior a la fecha colocada con el nuevo tracto
                    oeViajeAnt = olOperacion.ObtenerViaje(oeViaje)
                    If oeViajeAnt.Id <> String.Empty AndAlso oeViajeAnt.Id <> txtIdViaje.Text.Trim() AndAlso oeViajeAnt.IdDestino <> oeViajeOrig.IdOrigen Then
                        bandIngresa = ""
                    Else
                        oeViaje.TipoOperacion = "L"
                        oeViaje.FechaDesde = oeViajeOrig.Fecha.ToShortDateString & " " & oeViajeOrig.Fecha.TimeOfDay.ToString.Substring(0, 8)
                        oeViajePost = olOperacion.ObtenerViaje(oeViaje)
                        If oeViajePost.Id <> "" AndAlso oeViajePost.Id <> txtIdViaje.Text.Trim() AndAlso oeViajePost.IdOrigen <> oeViajeOrig.IdDestino Then
                            bandIngresa = ""
                        End If
                    End If
                    If bandIngresa = "" Then
                        Throw New Exception("No se puede Modificar Viaje,Con Destino: " & cboDestino.Text & Environment.NewLine &
                                            "Perjudica Trazabilidad del tracto. Verifique fechas")
                        cboDestino.Value = IdDestinoViaje
                        Return False
                    End If
                    'Validacion trazabilidad CARRETA
                    If cboCarreta.Value IsNot Nothing AndAlso cboCarreta.SelectedIndex >= 0 Then
                        oeViaje = New e_Viaje
                        oeViajeAnt = New e_Viaje
                        oeViajePost = New e_Viaje
                        oeViajeOrig = New e_Viaje
                        With oeViaje
                            .FechaDesde = fecViaje.Value.ToShortDateString & " " & hViaje.Value.ToShortTimeString
                            .FechaHasta = fecViaje.Value.ToShortDateString & " " & (hViaje.Value).ToShortTimeString
                            .IdOrigen = cboOrigen.Value
                            .IdDestino = cboDestino.Value
                            .Fecha = Date.Parse(fecViaje.Value.ToShortDateString & " " & hViaje.Value.ToShortTimeString)
                        End With
                        oeViajeOrig = oeViaje
                        oeViaje = New e_Viaje
                        oeViaje.TipoOperacion = "K"
                        oeViaje.Id = ""
                        oeViaje.IdTracto = ""
                        oeViaje.IdCarreta = cboCarreta.Value
                        oeViaje.FechaDesde = oeViajeOrig.Fecha.ToShortDateString & " " & oeViajeOrig.Fecha.TimeOfDay.ToString.Substring(0, 8)
                        oeViajeAnt = olOperacion.ObtenerViaje(oeViaje)
                        bandIngresa = "N"
                        If oeViajeAnt.Id <> String.Empty AndAlso oeViajeAnt.Id <> txtIdViaje.Text.Trim AndAlso oeViajeAnt.IdDestino <> oeViajeOrig.IdOrigen Then
                            bandIngresa = ""
                        Else
                            oeViaje.TipoOperacion = "L"
                            oeViaje.FechaDesde = oeViajeOrig.Fecha.ToShortDateString & " " & oeViajeOrig.Fecha.TimeOfDay.ToString.Substring(0, 8)
                            oeViajePost = olOperacion.ObtenerViaje(oeViaje)
                            If oeViajePost.Id <> "" AndAlso oeViajePost.IdOrigen <> oeViajeOrig.IdDestino AndAlso oeViajePost.Id <> txtIdViaje.Text.Trim() Then
                                bandIngresa = ""
                            End If
                        End If
                        If bandIngresa = "" Then
                            Throw New Exception("No se puede Modificar Viaje,Con Destino: " & cboDestino.Text & Environment.NewLine &
                                                "Perjudica Trazabilidad de la carreta. Verifique fechas")
                            cboDestino.Value = IdDestinoViaje
                            Return False
                        End If
                    End If
                    'Si han Cambiado el valor del Tracto Verificar la trazabilidad Tracto Antiguo
                    If TractoTanqueado <> cboTracto.Value.ToString().Trim() Then
                        oeViaje = New e_Viaje
                        oeViajeAnt = New e_Viaje
                        oeViajePost = New e_Viaje
                        oeViajeOrig = New e_Viaje
                        With oeViaje
                            .FechaDesde = fecViaje.Value.ToShortDateString & " " & hViaje.Value.ToShortTimeString
                            .FechaHasta = fecViaje.Value.ToShortDateString & " " & hViaje.Value.ToShortTimeString
                            .IdOrigen = cboOrigen.Value
                            .IdDestino = cboDestino.Value
                            .Fecha = Date.Parse(fecViaje.Value.ToShortDateString & " " & hViaje.Value.ToShortTimeString)
                        End With
                        oeViajeOrig = oeViaje
                        oeViaje = New e_Viaje
                        oeViaje.TipoOperacion = "K"
                        oeViaje.Id = txtIdViaje.Text.Trim()
                        oeViaje.IdTracto = ""
                        oeViaje.IdCarreta = TractoTanqueado
                        oeViaje.FechaDesde = oeViajeOrig.Fecha.ToShortDateString & " " & oeViajeOrig.Fecha.TimeOfDay.ToString.Substring(0, 8)
                        oeViaje.ViajeVacio = 14
                        oeViajeAnt = olOperacion.ObtenerViaje(oeViaje)
                        oeViaje.TipoOperacion = "L"
                        oeViaje.FechaDesde = oeViajeOrig.Fecha.ToShortDateString & " " & oeViajeOrig.Fecha.TimeOfDay.ToString.Substring(0, 8)
                        oeViajePost = olOperacion.ObtenerViaje(oeViaje)
                        bandIngresa = "N"
                        If oeViajeAnt.Id <> String.Empty AndAlso oeViajePost.Id <> String.Empty _
                            AndAlso oeViajeAnt.IdDestino <> oeViajePost.IdOrigen Then
                            bandIngresa = ""
                        End If
                        If bandIngresa = "" Then
                            Throw New Exception("No se puede Modificar Viaje " & Environment.NewLine &
                                                "Perjudica Trazabilidad del Tracto Anterior " & TractoViaje & ". Verifique fechas")
                        End If
                    End If
                    'Si han Cambiado el valor de la Carreta Verificar la trazabilidad Carreta Antigua
                    If Not String.IsNullOrWhiteSpace(CarretaTanqueada) AndAlso CarretaTanqueada.ToString().Trim() <> If(cboCarreta.Value Is Nothing, String.Empty, cboCarreta.Value.ToString().Trim()) Then
                        oeViaje = New e_Viaje
                        oeViajeAnt = New e_Viaje
                        oeViajePost = New e_Viaje
                        oeViajeOrig = New e_Viaje
                        With oeViaje
                            .FechaDesde = fecViaje.Value.ToShortDateString & " " & hViaje.Value.ToShortTimeString
                            .FechaHasta = fecViaje.Value.ToShortDateString & " " & hViaje.Value.ToShortTimeString
                            .IdOrigen = cboOrigen.Value
                            .IdDestino = cboDestino.Value
                            .Fecha = Date.Parse(fecViaje.Value.ToShortDateString & " " & hViaje.Value.ToShortTimeString)
                        End With
                        oeViajeOrig = oeViaje
                        oeViaje = New e_Viaje
                        oeViaje.TipoOperacion = "K"
                        oeViaje.Id = txtIdViaje.Text.Trim()
                        oeViaje.IdTracto = ""
                        oeViaje.IdCarreta = CarretaTanqueada
                        oeViaje.FechaDesde = oeViajeOrig.Fecha.ToShortDateString & " " & oeViajeOrig.Fecha.TimeOfDay.ToString.Substring(0, 8)
                        oeViaje.ViajeVacio = 14
                        oeViajeAnt = olOperacion.ObtenerViaje(oeViaje)
                        oeViaje.TipoOperacion = "L"
                        oeViaje.FechaDesde = oeViajeOrig.Fecha.ToShortDateString & " " & oeViajeOrig.Fecha.TimeOfDay.ToString.Substring(0, 8)
                        oeViajePost = olOperacion.ObtenerViaje(oeViaje)
                        bandIngresa = "N"
                        If oeViajeAnt.Id <> String.Empty AndAlso oeViajePost.Id <> String.Empty _
                            AndAlso oeViajeAnt.IdDestino <> oeViajePost.IdOrigen Then
                            bandIngresa = ""
                        End If
                        If bandIngresa = "" Then
                            Throw New Exception("No se puede Modificar Viaje " & Environment.NewLine &
                                                "Perjudica Trazabilidad de la Carreta Anterior " & CarretaViaje & ". Verifique fechas")
                        End If
                    End If
                    'End If
                End If
            End If
            If FlotaTracto = "PATIO" AndAlso cboCarreta.Text.Trim = "" Then
                Throw New Exception("LA UNIDAD: " & cboTracto.Text & " , no puede programarse sin carreta enganchada pertenece a la FLOTA de PATIO")
            End If
            If IndPropiedadTractoTemp = 1 AndAlso VerificarDocVencidos("Tracto", Me.cboTracto.Value, Me.cboTracto.Text) = False Then
                Return False
            End If
            If IndPropiedadCarretaTemp = 1 AndAlso Me.verCarreta.Checked AndAlso VerificarDocVencidos("Carreta", Me.cboCarreta.Value, Me.cboCarreta.Text) = False Then
                Return False
            End If
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Function

    Private Function lf_ValidaMontoRuta(Mensaje As String, Origen As String, Destino As String)
        Try
            olCombo = New l_Combo
            oeCombo = New e_Combo
            oeCombo.Id = cboPiloto.Value
            oeCombo.Nombre = "ValidaRutaConductor"
            If olCombo.Listar(oeCombo).Count > 0 Then
                Dim loVehiculo As New List(Of e_Vehiculo)
                olVehiculo = New l_Vehiculo
                Dim oeVehiculo As New e_Vehiculo With {.Id = cboTracto.Value}
                oeVehiculo = olVehiculo.Obtener(oeVehiculo)
                Dim IdTipoVehiculo As String = ""
                If Not String.IsNullOrWhiteSpace(oeVehiculo.Id) Then
                    IdTipoVehiculo = oeVehiculo.IdModeloFuncional
                End If
                olRuta = New l_Ruta
                oeRuta = New e_Ruta
                With oeRuta
                    .TipoOperacion = "Z"
                    .IdOrigen = Origen
                    .IdDestino = Destino
                    .IdCentro = IdTipoVehiculo 'Tipo Vehiculo
                    .IdFlota = If(verViajeVacio.Checked, "0", "1") 'Cargado o no 
                End With
                Dim loRuta As New List(Of e_Ruta)
                loRuta.AddRange(olRuta.Listar(oeRuta))
                If loRuta.Count = 0 Then
                    Throw New Exception("Falta ingresar Monto Ruta para la ruta: " & Environment.NewLine & Mensaje & Environment.NewLine & "Comunicarse con el jefe del área de operaciones")
                End If
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function VerificarDocVencidos(ByVal tipo As String, ByVal codigo As String, ByVal nombre As String) As Boolean
        Dim VehiculoDocumentosXVencer As New List(Of e_Combo)
        olCombo = New l_Combo
        oeCombo = New e_Combo
        oeCombo.Id = codigo ' cboTracto.Value
        oeCombo.Nombre = "DOCUMENTOSXVENCER"
        oeCombo.Fecha = fecViaje.Value
        VehiculoDocumentosXVencer = olCombo.Listar(oeCombo)
        If VehiculoDocumentosXVencer.Count > 0 Then
            If MessageBox.Show("No se puede Programar " & tipo & ": " & nombre & Environment.NewLine &
                                "Tiene Documentos Vehiculares Vencidos ..." & Environment.NewLine &
                                "Desea ver detalle de Documentos ? ",
                                    "Mensaje del Sistema", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Dim TextoTotal As String = ""
                For Each Documento As e_Combo In VehiculoDocumentosXVencer
                    TextoTotal += "Tipo Documento: " & Documento.Id & Environment.NewLine &
                                  "Fecha: " & CDate(Documento.Nombre).Date & Environment.NewLine &
                                  "Descripcion: " & Documento.Descripcion & Environment.NewLine & Environment.NewLine
                Next
                MessageBox.Show(TextoTotal, "Mensaje del Sistema " & tipo & ": " & nombre, MessageBoxButtons.OK, MessageBoxIcon.Information)
                'gNombrePerfilDocumentosVehiculares As String = "DOCUMENTOS VEHICULARES"
                oePerfil = New e_Perfil
                oePerfil.TipoOperacion = "P"
                oePerfil.Id = "1CH000000023"
                oePerfil.Nombre = "Area: Operaciones Documentos Vencidos, " & "Usuario: " & gUsuarioSGI.oePersona.NombreCompleto & ", " & tipo & ": " & nombre & " " & TextoTotal
                oePerfil.PrefijoID = gs_PrefijoIdSucursal '@0001
                olPerfil.Guardar(oePerfil)
            End If
            Return False
        Else '@0001 Ini
            VehiculoDocumentosXVencer = New List(Of e_Combo)
            olCombo = New l_Combo
            oeCombo = New e_Combo
            oeCombo.Id = codigo ' cboTracto.Value
            oeCombo.Nombre = "DOCUMENTOSXVENCER"
            oeCombo.Fecha = DateAdd(DateInterval.Day, 15, fecViaje.Value)
            VehiculoDocumentosXVencer = olCombo.Listar(oeCombo)
            If VehiculoDocumentosXVencer.Count > 0 Then
                If MessageBox.Show("ALERTA 15 Dias " & tipo & ": " & nombre & Environment.NewLine &
                                    "Tiene Documentos Vehiculares x Vencidos ..." & Environment.NewLine &
                                    "Desea ver detalle de Documentos ? ",
                                        "Mensaje del Sistema", MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    Dim TextoTotal As String = ""
                    For Each Documento As e_Combo In VehiculoDocumentosXVencer
                        TextoTotal += "Tipo Documento: " & Documento.Id & Environment.NewLine &
                                      "Fecha: " & CDate(Documento.Nombre).Date & Environment.NewLine &
                                      "Descripcion: " & Documento.Descripcion & Environment.NewLine & Environment.NewLine
                    Next
                    MessageBox.Show(TextoTotal, "Mensaje del Sistema " & tipo & ": " & nombre, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'gNombrePerfilDocumentosVehiculares As String = "DOCUMENTOS VEHICULARES"
                    oePerfil = New e_Perfil
                    oePerfil.TipoOperacion = "P"
                    oePerfil.Id = "1CH000000023"
                    oePerfil.Nombre = "Area: Operaciones Documentos Vencidos, " & "Usuario: " & gUsuarioSGI.oePersona.NombreCompleto & ", " & tipo & ": " & nombre & " " & TextoTotal
                    oePerfil.PrefijoID = gs_PrefijoIdSucursal '@0001
                    olPerfil.Guardar(oePerfil)
                End If
            End If '@0001 Fin
        End If
        Return True
    End Function

    Private Function ValidaCamposPilotos() As Boolean
        Try
            ValidarCombo(cboPiloto, "Piloto")
            ValidarCombo(cboCopiloto, "Copiloto")
            ValidarCombo(cboAyudante, "Ayudante")
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub AgregarDemanda()
        Try
            Dim oeAgregaLista As New List(Of e_OperacionDetalle)
            Dim oeAgregaLista1 As New List(Of e_OperacionDetalle)
            Dim oeAgregaContratoLista As New List(Of e_ViajesTerceros)
            Dim oeAgregaContratoLista1 As New List(Of e_ViajesTerceros)
            olOperacion = New l_Operacion
            oeOperacionDetalle = New e_OperacionDetalle
            olViajeTercero = New l_ViajesTerceros
            oeContratoTercero = New e_ViajesTerceros
            If griViajeDetalle.Rows.Count < 1 Then
                If griDemanda.ActiveRow.Cells("Seleccion").Value Then
                    oeOperacionDetalle.IdDemanda = griDemanda.ActiveRow.Cells("Id").Value
                    oeOperacionDetalle.TipoOperacion = "1"
                    griViajeDetalle.DataSource = olOperacion.ListarOperacionDetalle(oeOperacionDetalle)
                    ''Agregar Contrato Tercero
                    oeContratoTercero.IdDemanda = oeOperacionDetalle.IdDemanda
                    '  Dim lista = olViajeTercero.Listar(oeContratoTercero).Where(Function(item) item.IdOperacion.Trim <> "").ToList
                    Dim listaTerc As List(Of e_ViajesTerceros)
                    listaTerc = olViajeTercero.Listar(oeContratoTercero).Where(Function(item) item.IdOperacion.Trim = "").ToList
                    If listaTerc.Count > 0 Then
                        Dim objTerc As e_ViajesTerceros = listaTerc.Item(0)
                        If objTerc.IndOperacion = 5 Then
                            objTerc.IdDemanda = ""
                            objTerc.Id = ""
                        End If
                        listaTerc.Item(0) = objTerc
                    End If
                    griDetalleTercero.DataSource = listaTerc
                    If griDetalleTercero.Rows.Count > 0 Then
                        Me.chkIndTercero.Checked = True
                    Else
                        Me.chkIndTercero.Checked = False
                    End If
                    ''------------------------
                    RutaOperacion = griDemanda.ActiveRow.Cells("IdRuta").Value
                    olRuta = New l_Ruta
                    oeRutaDemanda = New e_Ruta
                    oeRutaDemanda.Id = RutaOperacion
                    oeRutaDemanda = olRuta.Obtener(oeRutaDemanda)
                    RutaIdOrigen = oeRutaDemanda.IdOrigen
                    RutaIdDestino = oeRutaDemanda.IdDestino
                    cboRutaOrigen.Value = RutaIdOrigen
                    cboOrigen.Value = RutaIdOrigen
                    cboRutaDestino.Value = RutaIdDestino
                    cboDestino.Value = RutaIdDestino
                    txtFlete.Text = griDemanda.ActiveRow.Cells("TotalFlete").Value
                    'deshabilitar campos
                    lblDemandaProgramar.Visible = True
                    lblCodigoDemandaAProgramar.Visible = True
                    codigoDemanda = griDemanda.ActiveRow.Cells("Id").Value
                    Me.lblCodigoDemandaAProgramar.Text = griDemanda.ActiveRow.Cells("Codigo").Value
                    Me.TipoVehiculo = griDemanda.ActiveRow.Cells("TipoVehiculo").Value
                    Me.IdEscala = griDemanda.ActiveRow.Cells("idEscala").Value
                    verEscala.Checked = IIf(IdEscala.Trim <> "", True, False)
                    Me.txtGlosaEscala.Text = griDemanda.ActiveRow.Cells("MotivoEscala").Value
                    '  Me.cboTipoVehiculo.Enabled = False
                    Me.cboRutaOrigen.Enabled = False
                    Me.cboRutaDestino.Enabled = False

                    seleccionarComboVehiculo()
                    seleccionarEscala()
                    LlenarCboTipoVehiculo()
                    Me.fecViaje.Value = Convert.ToDateTime(griDemanda.ActiveRow.Cells("FechaAtendida").Value)
                    Me.hViaje.Value = Convert.ToDateTime(griDemanda.ActiveRow.Cells("FechaAtendida").Value)

                End If
            Else
                If RutaOperacion = griDemanda.ActiveRow.Cells("IdRuta").Value Then
                    If griDemanda.ActiveRow.Cells("Seleccion").Value Then

                        oeAgregaLista1 = griViajeDetalle.DataSource
                        oeOperacionDetalle.IdDemanda = griDemanda.ActiveRow.Cells("Id").Value
                        oeOperacionDetalle.TipoOperacion = "1"
                        oeAgregaLista = olOperacion.ListarOperacionDetalle(oeOperacionDetalle)
                        oeAgregaLista1.AddRange(oeAgregaLista)
                        griViajeDetalle.DataBind()
                        txtFlete.Text += griDemanda.ActiveRow.Cells("TotalFlete").Value
                        ''Agregar Contrato Tercero
                        oeAgregaContratoLista1 = griDetalleTercero.DataSource
                        oeContratoTercero.IdDemanda = oeOperacionDetalle.IdDemanda
                        oeAgregaContratoLista = olViajeTercero.Listar(oeContratoTercero)
                        oeAgregaContratoLista1.AddRange(oeAgregaContratoLista)
                        griDetalleTercero.DataBind()
                    End If
                Else
                    If MessageBox.Show("La Demanda Seleccionada Tiene Otra Ruta Desea Seguir Agregando al Viaje: " & _
                             griDemanda.ActiveRow.Cells("Ruta").Value & " ?", _
                             "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                        If griDemanda.ActiveRow.Cells("Seleccion").Value Then
                            oeAgregaLista1 = griViajeDetalle.DataSource
                            oeOperacionDetalle.IdDemanda = griDemanda.ActiveRow.Cells("Id").Value
                            oeOperacionDetalle.TipoOperacion = "1"
                            oeAgregaLista = olOperacion.ListarOperacionDetalle(oeOperacionDetalle)
                            oeAgregaLista1.AddRange(oeAgregaLista)
                            griViajeDetalle.DataBind()
                            txtFlete.Text += griDemanda.ActiveRow.Cells("TotalFlete").Value
                            ''Agregar Contrato Tercero
                            oeAgregaContratoLista1 = griDetalleTercero.DataSource
                            oeContratoTercero.IdDemanda = oeOperacionDetalle.IdDemanda
                            oeAgregaContratoLista = olViajeTercero.Listar(oeContratoTercero)
                            oeAgregaContratoLista1.AddRange(oeAgregaContratoLista)
                            griDetalleTercero.DataBind()
                        End If
                    Else
                        txtFlete.Text += griDemanda.ActiveRow.Cells("TotalFlete").Value
                        griDemanda.ActiveRow.Cells("Seleccion").Value = False
                        griDemanda.ActiveRow.Appearance.BackColor = Color.White
                        griDemanda.ActiveRow.Fixed = False
                    End If
                End If
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EliminarDemanda()
        '  LimpiaGrid(griViajeDetalle, ogdOperacionDetalle)
        griViajeDetalle.DataSource = New List(Of e_OperacionDetalle)
        LimpiaGrid(griDetalleTercero, ogdDetalleTercero)
        Dim oeAgregaLista1 As New List(Of e_OperacionDetalle)
        olOperacion = New l_Operacion
        oeOperacionDetalle = New e_OperacionDetalle
        '---
        Dim oeAgregaContratoLista1 As New List(Of e_ViajesTerceros)
        olViajeTercero = New l_ViajesTerceros
        oeContratoTercero = New e_ViajesTerceros
        '---
        For Each fila As UltraGridRow In griDemanda.Rows.Where(Function(Item) Item.Cells("Seleccion").Value = True)
            Dim oeAgregaLista As New List(Of e_OperacionDetalle)
            '---
            Dim oeAgregaContratoLista As New List(Of e_ViajesTerceros)
            '---
            oeOperacionDetalle.IdDemanda = fila.Cells("Id").Value
            oeOperacionDetalle.TipoOperacion = "1"
            oeAgregaLista = olOperacion.ListarOperacionDetalle(oeOperacionDetalle)
            oeAgregaLista1.AddRange(oeAgregaLista)
            txtFlete.Text -= griDemanda.ActiveRow.Cells("TotalFlete").Value
            '-------
            oeContratoTercero.IdDemanda = oeOperacionDetalle.IdDemanda
            oeAgregaContratoLista = olViajeTercero.Listar(oeContratoTercero)
            oeAgregaContratoLista1.AddRange(oeAgregaContratoLista)
        Next
        griViajeDetalle.DataBind()
        griViajeDetalle.DataSource = oeAgregaLista1
        '----
        griDetalleTercero.DataBind()
        griDetalleTercero.DataSource = oeAgregaContratoLista1
        If VerificarDemandas() = 0 Then
            lblDemandaProgramar.Visible = False
            lblCodigoDemandaAProgramar.Visible = False
            codigoDemanda = ""
            Me.lblCodigoDemandaAProgramar.Text = ""
            Me.cboTipoVehiculo.Enabled = True
            Me.cboRutaOrigen.Enabled = True
            Me.cboRutaDestino.Enabled = True
        End If
    End Sub

    Public Function VerificarDemandas() As Integer
        Dim cont As Integer = 0
        Try
            For Each fila As UltraGridRow In griViajeDetalle.Rows
                If fila.Cells("IdDemanda").Value <> "" Then
                    cont = cont + 1
                End If
            Next
            Return cont
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub AgregaViaje()
        Try
            oeOperacion.oeViaje = griViaje.DataSource
            With oeViaje
                .Id = txtIdViaje.Text
                .Codigo = txtCodigoViaje.Text
                .IdOperacion = ""
                .ViajeVacio = IIf(RutaIndVacio = True, oeViaje.ViajeVacio, verViajeVacio.Checked)
                .ViajeRetorno = verViajeRetorno.Checked
                .Piloto = cboPiloto.Value
                .Copiloto = cboCopiloto.Value
                If .Copiloto <> "0" Then IndCopiloto = True
                .IdAyudante = cboAyudante.Value
                .Tracto = cboTracto.Value
                .Carreta = cboCarreta.Value
                .IdEstado = ""
                .Activo = True
                .GlosaEscala = txtGlosaEscala.Value
                .Turno = NroTurno.Value
            End With
            IndPropiedadCarreta = IndPropiedadCarretaTemp
            IndPropiedadTracto = IndPropiedadTractoTemp
            CargaVacia = oeViaje.ViajeVacio
            oeOperacion.oeViaje.Add(oeViaje)
            griViaje.DataBind()
            oeViaje = New e_Viaje
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function RutaVacia() As Boolean
        Try
            oeRutaVacio = New e_Ruta
            oeRutaVacio.TipoOperacion = "O"
            oeRutaVacio.IdOrigen = cboEscala.Value
            oeRutaVacio.IdDestino = cboDestino.Value
            oeRutaVacio = olRuta.Obtener(oeRutaVacio)
            If oeRutaVacio.Id.Trim <> "" Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Function

    Private Sub LlenaViaje()
        Try
            Dim Hora As Double = 0
            Dim HoraEscala As Double = 0
            oeViaje.Fecha = Date.Parse(fecViaje.Value.ToShortDateString() & " " & hViaje.Value.ToShortTimeString)
            If ValidaCamposDetalle() Then
                olRuta = New l_Ruta
                If OperacionEscala = 1 Then
                    If verProgramarViajeBloque.Checked = False Then
                        LimpiaGrid(griViaje, ogdViaje)
                        ListaViaje = New List(Of e_Viaje)
                        griViaje.DataSource = ListaViaje
                    End If
                    oeViaje = New e_Viaje
                    If verEscala.Checked = False Then
                        oeViaje.Origen = cboOrigen.Value
                        oeViaje.Destino = cboDestino.Value
                        oeViaje.PorcentajeFlete = txtFletePorcentaje.Value
                        For Each Lugar As e_Combo In LugaresPublic.Where(Function(Item) Item.Id = oeViaje.Destino)
                            oeViaje.Tesoreria = Lugar.Descripcion
                        Next
                    Else
                        oeViaje.Origen = cboOrigen.Value
                        oeViaje.Destino = cboEscala.Value
                        oeViaje.PorcentajeFlete = txtFletePorcentaje.Value / 2
                        If RutaVacia() Then
                            RutaIndVacio = True
                            oeViaje.ViajeVacio = True
                            oeViaje.PorcentajeFlete = 0
                        End If
                        For Each Lugar As e_Combo In LugaresPublic.Where(Function(Item) Item.Id = oeViaje.Destino)
                            oeViaje.Tesoreria = Lugar.Descripcion
                        Next
                    End If
                    oeViaje.IndEscala = verEscala.Checked
                    oeViaje.IdEscala = cboEscala.Value
                    oeViaje.Fecha = Date.Parse(fecViaje.Value.ToShortDateString & " " & hViaje.Value.ToShortTimeString)
                    oeViaje.DiaNoche = opcNocheDia.CheckedIndex
                    oeViaje.IndFecha = verFechaViaje.Checked
                    oeViaje.Capacidad = CDec(txtViajeCapacidadUtil.Text)
                    oeViaje.IndCarga = 1
                    oeViaje.FleteUnitario = Convert.ToDecimal(txtFleteUnitarioViaje.Value)
                    oeViaje.PrefijoID = gs_PrefijoIdSucursal '@0001
                    IndCopiloto = False
                    AgregaViaje()
                    If verEscala.Checked = True Then
                        oeRuta = New e_Ruta
                        oeRuta.IdOrigen = cboOrigen.Value
                        oeRuta.IdDestino = cboEscala.Value
                        oeRuta = olRuta.Obtener(oeRuta)
                        If IndCopiloto = False Then
                            If oeRuta.HorasSolo < 1 Then
                                Hora = 1
                            Else
                                Hora = oeRuta.HorasSolo
                            End If
                        Else
                            If oeRuta.HorasAcompañado <> 0 Then
                                If oeRuta.HorasAcompañado < 1 Then
                                    Hora = 1
                                Else
                                    Hora = oeRuta.HorasAcompañado
                                End If
                            Else
                                If oeRuta.HorasSolo < 1 Then
                                    Hora = 1
                                Else
                                    Hora = oeRuta.HorasSolo
                                End If
                            End If
                        End If
                        oeViaje.Fecha = DateAdd(DateInterval.Hour, Hora, Date.Parse(fecViaje.Value.ToShortDateString & " " & hViaje.Value.ToShortTimeString))
                        oeViaje.DiaNoche = opcNocheDia.CheckedIndex
                        txtIdViaje.Text = ""
                        txtCodigoViaje.Text = ""
                        oeRuta = New e_Ruta
                        oeViaje.Origen = cboEscala.Value
                        oeViaje.Destino = cboDestino.Value
                        oeViaje.IdEscala = cboEscala.Value
                        oeViaje.IndEscala = verEscala.Checked
                        oeViaje.IndFecha = verFechaViaje.Checked
                        oeViaje.PorcentajeFlete = txtFletePorcentaje.Value / 2
                        oeViaje.Capacidad = txtViajeCapacidadUtil.Value
                        oeViaje.IndCarga = 1
                        If RutaIndVacio = True Then
                            RutaIndVacio = False
                            oeViaje.ViajeVacio = False
                            oeViaje.PorcentajeFlete = 100
                        End If
                        oeViaje.PrefijoID = gs_PrefijoIdSucursal '@0001
                        AgregaViaje()
                    End If
                    CalcularTotalesDetalle()
                Else
                    'verProgramarViajeBloque.Checked = True
                    If verProgramarViajeBloque.Checked = False Then
                        LimpiaGrid(griViaje, ogdViaje)
                        ListaViaje = New List(Of e_Viaje)
                        griViaje.DataSource = ListaViaje
                    End If
                    OrigenAgrega = cboOrigen.Value
                    FechaViaje = Date.Parse(fecViaje.Value.ToShortDateString & " " & hViaje.Value.ToShortTimeString)
                    oeViaje = New e_Viaje
                    Dim CuentaEscala As Integer
                    CuentaEscala = griEscala.Rows.Count
                    For I As Integer = 0 To griEscala.Rows.Count - 1
                        oeViaje.Origen = OrigenAgrega
                        oeViaje.Destino = griEscala.Rows(I).Cells("Escala").Value
                        For Each Lugar As e_Combo In LugaresPublic.Where(Function(Item) Item.Id = oeViaje.Destino)
                            oeViaje.Tesoreria = Lugar.Descripcion
                        Next
                        oeViaje.IndEscala = verEscalaBloque.Checked
                        oeViaje.IdEscala = griEscala.Rows(I).Cells("Escala").Value
                        oeViaje.Fecha = FechaViaje
                        oeViaje.DiaNoche = opcNocheDia.CheckedIndex
                        oeViaje.Capacidad = txtViajeCapacidadUtil.Value
                        oeViaje.IndCarga = 1
                        oeViaje.PrefijoID = gs_PrefijoIdSucursal '@0001
                        IndCopiloto = False
                        AgregaViaje()
                        oeRuta = New e_Ruta
                        oeRuta.IdOrigen = OrigenAgrega
                        oeRuta.IdDestino = griEscala.Rows(I).Cells("Escala").Value
                        For Each Lugar As e_Combo In LugaresPublic.Where(Function(Item) Item.Id = oeViaje.Destino)
                            oeViaje.Tesoreria = Lugar.Descripcion
                        Next
                        oeRuta = olRuta.Obtener(oeRuta)
                        If IndCopiloto = False Then
                            If oeRuta.HorasSolo < 1 Then
                                Hora = 1
                            Else
                                Hora = oeRuta.HorasSolo
                            End If
                        Else
                            If oeRuta.HorasAcompañado <> 0 Then
                                If oeRuta.HorasAcompañado < 1 Then
                                    Hora = 1
                                Else
                                    Hora = oeRuta.HorasAcompañado
                                End If
                            Else
                                If oeRuta.HorasSolo < 1 Then
                                    Hora = 1
                                Else
                                    Hora = oeRuta.HorasSolo
                                End If
                            End If
                        End If

                        OrigenAgrega = griEscala.Rows(I).Cells("Escala").Value
                        oeViaje.Fecha = DateAdd(DateInterval.Hour, Hora, Date.Parse(FechaViaje.ToShortDateString & " " & FechaViaje.ToShortTimeString))
                        FechaViaje = oeViaje.Fecha
                        txtIdViaje.Text = ""
                        txtCodigoViaje.Text = ""
                    Next
                    oeViaje.DiaNoche = opcNocheDia.CheckedIndex
                    txtIdViaje.Text = ""
                    txtCodigoViaje.Text = ""
                    oeRuta = New e_Ruta
                    oeViaje.Origen = OrigenAgrega
                    oeViaje.Destino = cboDestino.Value
                    For Each Lugar As e_Combo In LugaresPublic.Where(Function(Item) Item.Id = oeViaje.Destino)
                        oeViaje.Tesoreria = Lugar.Descripcion
                    Next
                    oeViaje.IdEscala = OrigenAgrega
                    oeViaje.IndEscala = verEscalaBloque.Checked
                    oeViaje.Capacidad = txtViajeCapacidadUtil.Value
                    oeViaje.IndCarga = 1
                    oeViaje.PrefijoID = gs_PrefijoIdSucursal '@0001
                    AgregaViaje()
                End If

                cboPiloto.Focus()
                cboPiloto.SelectedIndex = -1
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub FleteTotalTercero()
        olIgv = New l_Impuesto
        oeIgv = New e_Impuesto
        With oeContratoTercero
            .FleteUnitario = numFleteUnitarioTerc.Text
            oeIgv = olIgv.IGV(Date.Now)
            If numCantidadTercero.Value <> 1 Then
                .SubTotal = .FleteUnitario * numCantidadTercero.Value
            Else
                .SubTotal = .FleteUnitario
            End If
            numSubTotalTercero.Value = .SubTotal
            .Igv = .SubTotal * oeIgv.Porcentaje
            numIgvTerc.Text = .Igv
            numFleteTotalTerc.Text = .FleteCalcula
        End With
    End Sub

    Private Sub FleteDetalleGrillaTercero()
        Try
            With oeContratoTercero
                With griDetalleTercero.ActiveRow
                    If Not String.IsNullOrEmpty(.Cells("Cantidad").Value) Or Not IsNumeric(.Cells("Cantidad").Value.ToString) Then
                        oeContratoTercero.Cantidad = CDbl(.Cells("Cantidad").Value)
                    Else
                        .Cells("Cantidad").Value = 1
                        oeContratoTercero.Cantidad = CDbl(.Cells("Cantidad").Value)
                    End If
                    If Not String.IsNullOrEmpty(.Cells("FleteUnitario").Value) Or Not IsNumeric(.Cells("FleteUnitario").Value.ToString) Then
                        oeContratoTercero.FleteUnitario = CDbl(.Cells("FleteUnitario").Value)
                    Else
                        .Cells("FleteUnitario").Value = 0
                        oeContratoTercero.FleteUnitario = CDbl(.Cells("FleteUnitario").Value)
                    End If
                    oeIgv = olIgv.IGV(Date.Now)
                    oeContratoTercero.Igv = oeIgv.Porcentaje
                    .Cells("Igv").Value = (oeContratoTercero.FleteUnitario * oeContratoTercero.Cantidad) * oeContratoTercero.Igv

                    .Cells("TotalFlete").Value = ((oeContratoTercero.FleteUnitario * oeContratoTercero.Cantidad) +
                                            ((oeContratoTercero.FleteUnitario * oeContratoTercero.Cantidad) * oeContratoTercero.Igv)).ToString("###,##0.0000")
                    .Cells("Subtotal").Value = (oeContratoTercero.FleteUnitario * oeContratoTercero.Cantidad).ToString("###,##0.0000")
                End With
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub LlenarCboTipoVehiculo()
        If Me.cboTipoVehiculo.Value <> "" Then
            Dim obj As e_Combo = ModeloFuncionalPublic.Item(Me.cboTipoVehiculo.SelectedIndex)
            If obj.Extras.Item(0) = 1 Then
                Me.chkMotriz.Checked = True
            Else
                Me.chkMotriz.Checked = False
            End If
        End If
    End Sub

    Public Sub FiltrarLista()
        Dim listaAuxiliar As New List(Of e_Bitacora)
        For Each obj As e_Bitacora In ListaBitacora
            Dim objAuxiliar As New e_Bitacora
            objAuxiliar.ValoresActuales = New List(Of String)
            objAuxiliar.ValoresAnteriores = New List(Of String)
            objAuxiliar.ColumnasAfectadas = New List(Of String)
            For j As Integer = 0 To obj.ValoresAnteriores.Count - 1
                If obj.ValoresAnteriores(j) <> obj.ValoresActuales(j) Then
                    objAuxiliar.ValoresAnteriores.Add(obj.ValoresAnteriores(j))
                    objAuxiliar.ValoresActuales.Add(obj.ValoresActuales(j))
                    objAuxiliar.ColumnasAfectadas.Add(obj.ColumnasAfectadas(j))
                    objAuxiliar.Activo = obj.Activo
                    objAuxiliar.IdTablaCabecera = obj.IdTablaCabecera
                    objAuxiliar.IdTablaDetalle = obj.IdTablaDetalle
                    objAuxiliar.Indicador = obj.Indicador
                    objAuxiliar.NombreFormulario = obj.NombreFormulario
                    objAuxiliar.NombreTablaCabecera = obj.NombreTablaCabecera
                    objAuxiliar.NombreTablaDetalle = obj.NombreTablaDetalle
                    objAuxiliar.Tipo = obj.Tipo
                    objAuxiliar.TipoOPeracion = obj.TipoOPeracion
                    objAuxiliar.UsuarioRegistro = obj.UsuarioRegistro
                    objAuxiliar.PrefijoID = gs_PrefijoIdSucursal '@0001
                End If
            Next
            If objAuxiliar.ValoresAnteriores.Count > 0 Then
                listaAuxiliar.Add(objAuxiliar)
            End If
        Next
        ListaBitacora = listaAuxiliar
    End Sub

    Private Sub mt_ControlBotoneria()
        Try
            If ficOperacion.SelectedTab IsNot Nothing Then
                Select Case ficOperacion.SelectedTab.Index
                    Case 0 'Listado
                        Select Case tabViajesLista.SelectedTab.Index
                            Case 0 'Viajes
                                If gUsuarioSGI.oeArea.Nombre = gNombreAreaCoordinacionSupervisionOperacion OrElse
                                    gUsuarioSGI.oeArea.Nombre = gNombreAreaOperaciones OrElse '@0001
                                    gUsuarioSGI.oeArea.Nombre = gNombreAreaInformaticaSistemas OrElse
                                    gUsuarioSGI.oeArea.Nombre = gNombreAreaSeguridadMedioAmbiente OrElse
                                    gUsuarioSGI.oeArea.Nombre = gNombreAreaVentas Then
                                    If griLista.Rows.Count > 0 Then
                                        ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
                                    Else
                                        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                                    End If
                                Else
                                    If griLista.Rows.Count > 0 Then
                                        ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
                                    Else
                                        ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                                    End If
                                End If
                            Case 1 'Viajes x Terceros
                                If griListaTerceros.Rows.Count > 0 Then
                                    ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
                                Else
                                    ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                                End If
                            Case 2 'Desenganches
                                If griViajesProceso.Rows.Count > 0 Then
                                    ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
                                Else
                                    ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                                End If
                            Case 3 'Trazabilidad
                                If griTransabilida.Rows.Count > 0 Then
                                    ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
                                Else
                                    ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                                End If
                        End Select
                    Case 1 'Mantenimiento
                        ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
                End Select
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_HabilitarSumatoria(lb_Indicador As Boolean)
        lblProduccionIGV.Visible = lb_Indicador
        lblProduccionSinIGV.Visible = lb_Indicador
        decProduccionIGV.Visible = lb_Indicador
        decProduccionSinIGV.Visible = lb_Indicador
    End Sub

#End Region

#Region "Control de tiempo de respuesta y actualización"

    'Private Sub frm_Operacion_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
    '    InicializaTiempo()
    'End Sub

    'Private Sub griLista_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griLista.MouseLeave
    '    If _tiempo <= 0 Then
    '        Consultar(True)
    '    End If
    '    InicializaTiempo()
    'End Sub

#End Region

#Region "Funciones"

    Public Function ProgramarViajeDisponibilidad(ByVal IdViaje As String, ByVal IdTracto As String) As Boolean
        Operacion = "Nuevo"
        Try
            Nuevo()
            ListarDisponibilidad(IdTracto)
            For Each fila As UltraGridRow In griDisponibleVehiculo.Rows
                If fila.Cells("Id").Value = IdViaje Then
                    griDisponibleVehiculo.Rows.Item(fila.Index).Activated = True
                    fila.Cells("Seleccion").Value = True
                End If
            Next
            cboPiloto.Enabled = True
            griViaje.DisplayLayout.Bands(0).Columns("Piloto").CellActivation = Activation.AllowEdit
            Operacion = "Nuevo"
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Function

    Public Function ProgramarViajeProgramado(ByVal IdViaje As String) As Boolean
        Operacion = "Nuevo"
        Try
            Nuevo()
            LlenarCombo(cboCarreta, "Nombre", CarretaPublic, -1)
            olOperacion = New l_Operacion
            oeViaje = New e_Viaje
            oeViaje.TipoOperacion = "2"
            oeViaje.Id = IdViaje
            oeViaje = olOperacion.ObtenerViaje(oeViaje)
            RutaIdDestino = oeViaje.IdDestino
            LlenarCombo(cboTracto, "Nombre", TractoPublic.Where(Function(Item) Item.Descripcion = 1 Or Item.Descripcion = 3).ToList, -1)
            cboRutaOrigen.Value = RutaIdDestino
            cboOrigen.Value = RutaIdDestino
            RutaIdDestino = ""
            cboRutaDestino.SelectedIndex = -1
            If Not String.IsNullOrWhiteSpace(oeViaje.IdCarreta) Then
                cboTipoVehiculo.Value = CarretaPublic.Where(Function(item) item.Id = oeViaje.IdCarreta).ToList.Item(0).Extras(0).ToString
                'cboTipoVehiculo_Validated(Nothing, Nothing)
            Else
                cboTipoVehiculo.Value = TractoPublic.Where(Function(item) item.Id = oeViaje.IdTracto).ToList.Item(0).Extras(0).ToString
                'cboTipoVehiculo_Validated(Nothing, Nothing)
                Me.verCarreta.Checked = False
                Me.cboCarreta.Enabled = False
            End If
            With oeViaje
                cboPiloto.Value = .IdPiloto
                cboCopiloto.Value = .IdCopiloto
                cboAyudante.Value = .IdAyudante
                cboTracto.Value = .IdTracto
                cboCarreta.Value = .IdCarreta
                cboTractoPeso.Value = cboTracto.Value
                cboCarretaPeso.Value = cboCarreta.Value
                fecViaje.Value = DateAdd(DateInterval.Hour, 24, Date.Parse(.Fecha.ToShortDateString & " " & .Fecha.ToShortTimeString))
                cboTracto_Validating(Nothing, Nothing)
                txtViajeCapacidadUtil.Text = .Capacidad
            End With
            cboPiloto.Enabled = True
            griViaje.DisplayLayout.Bands(0).Columns("Piloto").CellActivation = Activation.AllowEdit
            Operacion = "Nuevo"
            cboRutaDestino.Focus()
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Function

    Public Function ValidarIngresoContrato() As Boolean
        Try
            If griDetalleTercero.Rows.Count > 0 And griViaje.Rows.Count > 1 And griViaje.Rows(0).Cells("IndEscala").Value = 0 Then
                Throw New Exception("SI existe CONTRATO TERCERO, solo debe ingresar UN VIAJE. Verifique")
            Else
                If griViaje.Rows.Count > 0 Then
                    If IndPropiedadTracto = 1 And
                       IndPropiedadCarreta = 1 Then
                        If griDetalleTercero.Rows.Count > 0 Then
                            Throw New Exception("El tracto y carreta son PROPIETARIOS, NO es necesario AGREGAR CONTRATO. Verifique")
                        End If

                    Else
                        If (IndPropiedadTracto = 0) And griDetalleTercero.Rows.Count = 0 And
                            NombrePropTracto <> gs_TxtEmpresaSistema And CargaVacia = 0 Then
                            Throw New Exception("El tracto  NO ES PROPIETARIO, es necesario AGREGAR CONTRATO. Verifique")
                        Else
                            If (IndPropiedadCarreta = 0 And Me.cboCarreta.Value <> "") And griDetalleTercero.Rows.Count = 0 And CargaVacia = 0 Then
                                Throw New Exception("La carreta  NO ES PROPIETARIO, es necesario AGREGAR CONTRATO. Verifique")
                            Else
                                If griDetalleTercero.Rows.Count > 2 Then
                                    Throw New Exception("No puede ingresar MAS DE 2 CONTRATOS. Verifique")
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function getIdArrayBidimensional() As Integer
        For i As Integer = 0 To 14
            If rowGeneral(i, 0) = -1 Then
                Return i
            End If
        Next
    End Function

    Private Function getIdArrayGlosas(ByVal nombreCol As String, ByVal indLista As Integer) As String
        For i As Integer = 0 To 14
            If glosasGeneral(i, 0) = nombreCol And glosasGeneral(i, 1) = indLista Then
                Return i
            End If
        Next
        For i As Integer = 0 To 14
            If glosasGeneral(i, 0) = "" Then
                Return i
            End If
        Next
        Return 0
    End Function

    Public Function getIndiceLista(ByVal indiceGrilla As Integer) As Integer
        For i As Integer = 0 To rowGeneral.Length
            If rowGeneral(i, 0) = indiceGrilla Then
                Return rowGeneral(i, 1)
            End If
        Next
        Return -1
    End Function

    Public Function existeColumna(ByVal nombreCol As String, ByVal indLista As Integer) As Integer
        For i As Integer = 0 To 14
            If glosasGeneral(i, 0) = nombreCol And glosasGeneral(i, 1) = indLista Then
                Return glosasGeneral(i, 2)
            End If
        Next
        Return -1
    End Function
    '@0001 Inicio
    Private Sub cboPiloto_ValueChanged(sender As Object, e As EventArgs) Handles cboPiloto.ValueChanged
        If cboPiloto.Value <> "" Then
            FotoPiloto(cboPiloto.Value)
        End If
    End Sub
    Private Sub FotoPiloto(ByVal IdTrabajador As String)
        Try
            upbFoto.Image = Nothing
            Dim oeTrabajadorFoto As New e_Trabajador
            oeTrabajadorFoto.CargaCompleto = False
            oeTrabajadorFoto.Id = IdTrabajador
            oeTrabajadorFoto = olTrabajador.Obtener(oeTrabajadorFoto)
            If String.IsNullOrEmpty(oeTrabajadorFoto.Id) Then
                oeTrabajadorFoto.Foto = BitConverter.GetBytes(0)
            End If
            If oeTrabajadorFoto.Foto.Length <> 4 Then
                upbFoto.Image = oeTrabajadorFoto.Foto
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub
    Private Sub FotoTracto(ByVal IdTracto As String)
        Try
            upbFotoTracto.Image = Nothing
            Dim oeVehiculoFoto As New e_Vehiculo
            oeVehiculoFoto.Id = IdTracto
            oeVehiculoFoto = olVehiculo.Obtener(oeVehiculoFoto)
            If String.IsNullOrEmpty(oeVehiculoFoto.Id) Then
                oeVehiculoFoto.Foto = BitConverter.GetBytes(0)
            End If
            If oeVehiculoFoto.Foto.Length <> 4 Then
                upbFotoTracto.Image = oeVehiculoFoto.Foto
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub
    Private Sub FotoCarreta(ByVal IdTracto As String)
        Try
            upbFotoCarreta.Image = Nothing
            Dim oeVehiculoFoto As New e_Vehiculo
            oeVehiculoFoto.Id = IdTracto
            oeVehiculoFoto = olVehiculo.Obtener(oeVehiculoFoto)
            If String.IsNullOrEmpty(oeVehiculoFoto.Id) Then
                oeVehiculoFoto.Foto = BitConverter.GetBytes(0)
            End If
            If oeVehiculoFoto.Foto.Length <> 4 Then
                upbFotoCarreta.Image = oeVehiculoFoto.Foto
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub
    '@0001 Fin
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
            cadena += "<CAPTION padding: 0.3em;color: #fff;background: #000;><EM>Errores de Trazabilidad " & IIf(Me.opTractoCarreta.CheckedIndex = 0, "Tracto", "Carreta") & "</EM></CAPTION>"
            cadena += "<tr style='white-space: nowrap' align='left' valign='top'>"
            cadena += estiloLetraDetalle & "# Error</font></th>" & estiloLetraDetalle & "Fecha</font></th>" &
                estiloLetraDetalle & "Viaje</font></th>" & estiloLetraDetalle & "Origen</font></th>" &
            estiloLetraDetalle & "Destino</font></th>" & estiloLetraDetalle & "Tracto</font></th>" & estiloLetraDetalle & "Carreta</font></th>" & estiloLetraDetalle & "Cliente</font></th>" &
            estiloLetraDetalle & "Piloto</font></th>" & estiloLetraDetalle & "Copiloto</font></th>" & estiloLetraDetalle & "Flete U.</th>" & estiloLetraDetalle & "Cantidad</th>" & estiloLetraDetalle & "Subtotal</th>" &
        estiloLetraDetalle & "Flota</font></th>" & estiloLetraDetalle & "TipoVeh</font></th>"
            cadena += "</tr>"

            Dim listaViaje As List(Of e_Viaje) = griTransabilida.DataSource
            For Each obj As e_Viaje In listaViaje

                cadena += "<tr style='width: auto;' align='left' valign='top'>"
                cadena += estiloLetraDetalleSCCenter & CStr(obj.IndFecha) & "</font></td>" & estiloLetraDetalleSC & CStr(obj.Fecha) & "</font></td>" & estiloLetraDetalleSC & CStr(obj.Codigo) & "</font></td>" & estiloLetraDetalleSC & obj.Origen & "</font></td>" &
                    estiloLetraDetalleSC & obj.Destino & "</font></td>" & estiloLetraDetalleSC & obj.Tracto & "</font></td>" & estiloLetraDetalleSC & obj.Carreta & "</font></td>" & estiloLetraDetalleSC & obj.Cliente & "</font></td>" &
              estiloLetraDetalleSC & obj.Piloto & "</font></td>" & estiloLetraDetalleSC & obj.Copiloto & "</font></td>" & estiloLetraDetalleSCRight & obj.FleteUnitario.ToString("###,##0.000") & "</font></td>" & estiloLetraDetalleSCRight & obj.Cantidad.ToString("###,##0.000") & "</font></td>" & estiloLetraDetalleSCRight & obj.Subtotal.ToString("###,##0.000") & "</font></td>" &
              estiloLetraDetalleSC & obj.Flota & estiloLetraDetalleSC & obj.TipoVehiculo
                cadena += "</tr>"
            Next
            cadena += "</table>"

        Catch ex As Exception
            Throw ex
        End Try
        Return cadena
    End Function


#End Region

End Class
