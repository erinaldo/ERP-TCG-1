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

Public Class frm_Demanda
    Inherits frm_MenuPadre

#Region "Declaración de variables"
    Private Shared instancia As frm_Demanda = Nothing
    Private Shared Operacion As String
    Private Estado As String
    Dim oeContratoTercero As New e_ViajesTerceros
    Dim olIgv As New l_Impuesto
    Dim olFlete As New l_Flete
    Dim oeFlete As New e_Flete
    Dim oeLugar As New e_Lugar
    Dim olLugar As New l_Lugar
    Private leCargas As New List(Of e_Viaje)
    Dim ListaLugar As New List(Of e_Lugar)
    Dim bandload As Boolean
    Dim olOperacion As New l_Operacion
    Dim oeTarifa As New e_TarifasCliente
    Dim olTarifa As New l_TarifasCliente
    Dim oeViaje As New e_Viaje
    Dim Prefijo As New l_Configuracion

    Dim oeVehiculo As New e_Vehiculo
    Dim olVehiculo As New l_Vehiculo
    Dim ListaDetalle As New List(Of e_DemandaDetalle)
    Dim ListaDetalleTercero As New List(Of e_ViajesTerceros)

    Dim oeIgv As New e_Impuesto
    Private FechaServidor As Date = ObtenerFechaServidor()
    Dim ListTercero As List(Of e_Combo)
    Dim totalFlete As Double = 0
    Dim totalComision As Double

    Dim olEstado As New l_Estado
    Dim olCliente As New l_Cliente
    Dim olRuta As New l_Ruta
    Dim olDemandaRapida As New l_DemandaRapida
    Dim oeDemandaRapida As New e_DemandaRapida
    Dim oeEstado As New e_Estado
    Dim oeRuta As New e_Ruta
    Dim oeCliente As New e_Cliente
    Dim olDemanda As New l_Demanda
    Dim _ingresando_datos As Boolean = False
    Dim olCombo As New l_Combo
    Dim oeCombo As New e_Combo

    Dim codigo As String = ""
    Dim RutaOrigen As String = ""
    Dim RutaDestino As String = ""
    Dim RutaDemanda As String = ""
    Dim estadoDP As String = "1CH00014"
    Dim RutaIdOrigen As String = ""
    Dim RutaIdDestino As String = ""
    Dim RutaIdOrigenDetalle As String = ""
    Dim RutaIdDestinoDetalle As String = ""
    Dim olDireccionEmpresa As New l_Combo
    Dim IdPuntoPartida As String = ""
    Public Shared motivoCancelacion As String = ""
    Public Shared IdConceptoCancEliminacion As String = ""
    Private WithEvents oeDemanda As New e_Demanda
    Dim oeDemandaDetalle As New e_DemandaDetalle

    Dim indiceCom = -1
    Public Shared codigoNuevoCom = ""
    Dim indiceClienteFinal = 0

    Dim olFuncionesGenerales As New l_FuncionesGenerales
    Dim olViajeTercero As New l_ViajesTerceros

    Dim tipo As String = ""
    Dim ValorIgv As Double = 0
    Public codigoCliente As String = ""
    Dim codigoComisionista As String = ""

    Dim oeUsuario As New e_Usuario
    'cambios
    Public Shared codigoNuevoComisionista As String = ""
    Public Shared codigoNuevoCLiente As String = ""
    Public Shared nombreNuevoCLiente As String = ""
    Dim codigoTercero As String = ""
    Dim bandGD As String = ""
    Public Shared instancia2 As frm_Cliente = Nothing
    Dim listaPagoEfectivo As List(Of e_Combo)
    Public Shared codigoTerceroNuevo As String = ""
    Dim codigoTerceroBand As String = ""

    Dim olTarifasProveedor As New l_TarifasProveedor
    Dim oeTarifaProveedor As New e_TarifasProveedor
    Dim indicadorTercero As Boolean = False

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
    Dim objEliminarTercero As e_Bitacora
    Dim objEliminarDetalle As e_Bitacora
    Dim indIngresaComsion As String = ""
    Dim lARUsuario As New l_ActividadRestringido_Usuario
    Dim idActividadNegocio As String = ""
    Dim AccionSistema As String = ""
    Dim TipoVehiculoEditado As String = ""
    Dim idDemandaDetalle As String = ""

    Dim codigoContactoCarga As String = ""
    Dim codigoContactoDescarga As String = ""
    Dim bandCarga As String = ""

#End Region

#Region "botones"

    Public Overrides Sub Nuevo()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            MostrarTabs(1, ficDemanda, 1)
            Operacion = "Nuevo"
            oeContratoTercero = New e_ViajesTerceros
            ListaDetalle = New List(Of e_DemandaDetalle)
            ListaDetalleTercero = New List(Of e_ViajesTerceros)
            IncidenciasPublic = New e_IncidenciasAutentificadas
            Inicializar()
            oeDemanda = New e_Demanda
            '  MostrarTabs(1, ficDemanda, 1)
            oeDemanda.UsuarioCreacion = gUsuarioSGI.Id
            griDetalle.DataSource = ListaDetalle
            griDetalleTercero.DataSource = ListaDetalleTercero
            griDetalle.DisplayLayout.Bands(0).Columns("Programado").Hidden = True
            griDetalle.DisplayLayout.Bands(0).Columns("PorProgramar").Hidden = True
            exgruDetalle.Expanded = True
            Me.cboDestino.Text = ""
            '  exgruConsultas.Expanded = False
            MyBase.Nuevo()
            ugb_Espera.Visible = False

            RutaIdDestino = ""
            Me.cboDestino.DisplayMember = "Destino"
            Me.cboDestino.ValueMember = "IdDestino"
            Me.cboDestinoDetalle.DisplayMember = "Destino"
            Me.cboDestinoDetalle.ValueMember = "IdDestino"
            'Tania

            verValidaFU.Checked = True
            CalFleteUnitario.Enabled = False
            Me.lblNumeroDemanda.Visible = True
            Me.NroDemanda.Visible = True

            '    verDemanda.Enabled = False
            '     verCancelar.Enabled = False

            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            Operacion = "Nuevo"
            cboOrigen.Focus()
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
                If GuardarDemandaPredemanda() Then
                    MostrarTabs(0, ficDemanda, 2)
                    MyBase.Guardar()
                Else
                    MostrarTabs(1, ficDemanda, 1)
                End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            InicializarEntidad()
            If Operacion <> "Ayuda" Then Operacion = "Inicializa"
            Estado = " Activo"
            oeDemanda.Activo = True
            '  If VerAsignada.Checked Then
            'oeDemanda.TipoOperacion = "0"
            '    Else
            oeDemanda.TipoOperacion = "1"
            '    End If
            If ValidarFechaInicioFin(fecDesde, fecHasta) Then
                listarNuevo()
                CalcularTotales(griLista, "TotalFlete", "TotalComision", "Subtotal")
                If griLista.Rows.Count > 0 Then
                    MyBase.Consultar(True)
                Else
                    MyBase.Consultar()
                End If
                griLista.Focus()
            End If
            ControlBotoneraPorActividad("Consultar")
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            If (gUsuarioSGI.leARUsuario.Where(Function(item) item.IdActividadNegocio = gActividadNegocio.Demanda.ToString And
                                                 item.AccionSistema = gAccionSistema.EDITAR.ToString And item.IdProcesoNegocio = pProcesoNegocio)).ToList.Count = 0 Then
                mensajeEmergente.Confirmacion("Usted no esta autorizado para ACTUALIZAR - Pedido Carga", True)
            Else
                ugb_Espera.Visible = True
                Application.DoEvents()
                Cursor.Current = Cursors.WaitCursor
                Cursor.Show()
                Inicializar()
                If griLista.Selected.Rows.Count > 0 Then
                    If griLista.ActiveRow.Cells("Estado").Value.ToString.Trim = "APROBADA" Then
                        estadoDP = "1CH00031"
                    End If
                    If griLista.ActiveRow.Cells("Estado").Value.ToString.Trim = "GENERADA" Then
                        If EditarDemanda() Then
                            Operacion = "Editar"
                            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
                        End If
                    Else
                        mensajeEmergente.Confirmacion("Solo se pueden EDITAR - Pedido Carga - GENERADAS", True)
                    End If
                End If

                ugb_Espera.Visible = False
            End If
            
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        griLista.ActiveRow.Delete()
    End Sub

    Public Overrides Sub Cancelar()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            If Me.tipo = "" Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarDemandaPredemanda() Then
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
            Else
                ugb_Espera.Visible = False
                Me.tipo = ""
                Me.Close()
            End If
            
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            If tabDemandaCargas.SelectedTab.Index = 0 Then
                If griLista.Rows.Count = 0 Then Throw New Exception("No hay ninguna - Pedido Carga - para exportar al Excel")
                Exportar_Excel(griLista)
            Else
                If griFactura.Rows.Count = 0 Then Throw New Exception("No hay ninguna - Pedido Carga - para exportar al Excel")
                Exportar_Excel(griFactura)
            End If

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub
#End Region

#Region "Metodos"
    Public Sub LlenaCombos()

        LlenarComboMaestro(cboOrigen, LugaresPublic, 0)
        LlenarComboMaestro(cboEscala, LugaresPublic, 0)
        LlenarComboMaestro(cboTipoVehiculo, ModeloFuncionalPublic, -1)
        LlenarComboMaestro(cboCliente, ClientesPublic, 0)
        LlenarComboMaestro(cboClienteFinal, ClientesPublic, 0)
        LlenarComboMaestro(cboComisionista, ComisionistasPublic, -1)
        LlenarComboMaestro(cboTipoCarga, TipoCargaPublic, -1)
        'LlenarComboMaestro(cboMaterial, MaterialesPublic.Where(Function(item) item.Descripcion = "OPERACIONESC").ToList, -1)
        LlenarComboMaestro(cboMaterial, MaterialesPublic.ToList, -1)
        LlenarComboMaestro(cboOrigenDetalle, LugaresPublic, -1)
        '  LlenarComboMaestro(cboDestinoDetalle, LugaresPublic, -1)
        LlenarComboMaestro(cboContacto, ComisionistasPublic, -1)

        LlenarCombo(cboMoneda, "Nombre", MonedaPublic, 0)
        LlenarCombo(cboMonedaT, "Nombre", MonedaPublic, 0)

        cboComisionista.Text = "NINGUNO  ,"
        '    cboContacto.Text = "NINGUNO  ,"
        Me.txtApellidoPaternoComisionista.Text = ""
        Me.txtApellidoMaterno.Text = ""
        Me.txtNombreComisonista.Text = ""
        Me.txtTelefonoComisionista.Text = ""
        ListTercero = New List(Of e_Combo)
        oeCombo = New e_Combo
        oeCombo.Nombre = "Transportista"
        ListTercero.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)
        LlenarComboMaestro(cboTercero, ListTercero, 0)

        Me.cboEscala.SelectedIndex = -1
        Me.cboDireccionLlegada.Value = ""
        Me.cboOrigen.SelectedIndex = -1

        'cambios
        Dim ListaPuntoPartida = New List(Of e_Combo)
        Dim olDireccionEmpresa As New l_Combo
        Dim oeDireccionEmpresa = New e_Combo
        oeDireccionEmpresa.Nombre = "DireccionEmpresa"
        oeDireccionEmpresa.Id = ""
        ListaPuntoPartida.AddRange(olDireccionEmpresa.Listar(oeDireccionEmpresa))
        LlenarComboMaestro(cboDireccionLlegada, ListaPuntoPartida, 0)
        LlenarComboMaestro(cboDireccionPartida, ListaPuntoPartida, 0)
        cboDireccionLlegada.Value = IdPuntoPartida

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
    End Sub

    Private Sub Inicializar()
        exgruConsultas.Visible = False
        'General
        Me.NroDemanda.Value = 1
        dtFechaRecepcion.Value = FechaServidor.AddDays(1)
        dtFechaAtencion.Value = FechaServidor
        dtSolicita.Value = FechaServidor
        cboOrigen.SelectedIndex = -1
        cboDestino.SelectedIndex = -1
        txtObservacion.Text = String.Empty
        Me.numNroUnidades.Value = 1
        Me.cboTipoVehiculo.SelectedIndex = -1
        Me.cboEscala.SelectedIndex = -1
        Me.chkEscala.Checked = False
        Me.txtMotivoEscala.Text = String.Empty
        Me.cboOrigen.Enabled = True
        Me.cboDestino.Enabled = True
        cboEscala.Enabled = False
        'detalle demanda
        codigo = String.Empty
        txtNumero.Text = String.Empty
        cboOrigenDetalle.SelectedIndex = -1
        cboDestinoDetalle.SelectedIndex = -1
        cboCliente.SelectedIndex = -1
        cboClienteFinal.SelectedIndex = -1
        cboDireccionLlegada.Value = ""
        cboDireccionPartida.Value = ""
        cboComisionista.SelectedIndex = -1
        cboEscala.Enabled = False
        Me.txtRucCLiente.Text = String.Empty
        Me.txtRucCLienteFinal.Text = String.Empty
        Me.txtNombreComisonista.Text = String.Empty
        Me.txtApellidoPaternoComisionista.Text = String.Empty
        Me.txtTelefonoComisionista.Text = String.Empty
        Me.txtApellidoMaterno.Text = String.Empty
        Me.txtRucComisionista.Text = String.Empty
        Me.txtCantidad.Value = 1
        Me.cboTipoCarga.SelectedIndex = -1
        Me.CalFleteUnitario.Value = 0
        Me.CalFleteUnitarioIGV.Value = 0
        Me.txtFleteTotalDetalle.Value = 0
        Me.txtSubtotal.Value = 0

        Me.cboEscala.Enabled = False
        cboComisionista.Text = "NINGUNO  ,"
        cboMaterial.Value = "1CH000001393"
        Me.cboTipoCarga.Value = "1CH000000001"
        Me.cboTipoVehiculo.Value = "1CH000000007"
        txtObservacion.Text = String.Empty

        Me.txtObservacion.Text = String.Empty
        Me.txtComision.Value = 0
        Me.chkCostoEstiva.Checked = False
        Me.chkConsolidado.Checked = False
        Me.chkIGVConsolidado.Checked = False
        Me.verCargar.Checked = False
        Me.verDescarga.Checked = False        
        Me.verPagoContraEntrega.Checked = False
        Me.txtConsolidado.Enabled = False


        'Terceros
        numFleteUnitarioTerc.Value = 0
        Me.numSubTotalTercero.Value = 0
        Me.numIgvTerc.Value = 0
        Me.numFleteTotalTerc.Value = 0
        Me.numCantidadTercero.Value = 1
        Me.numComisionTerc.Value = 0
        Me.cboTercero.SelectedIndex = -1
        Me.cboContacto.SelectedIndex = -1
        Me.txtReferenciaTercero.Text = String.Empty
        Me.txtObservacionTercero.Text = String.Empty

        Me.verIncluyeIgv.Checked = True

        habilitarControles(True)
        'lista       
        ValorIgv = ObtenerIGV()
        'Tabs
        Me.udtHoraAtencion.Value = FechaServidor.ToShortTimeString
        Me.udtHoraRecepcion.Value = FechaServidor.ToShortTimeString
        Me.udtHoraSolicita.Value = FechaServidor.ToShortTimeString


        'Glosas
        GlosaDetalleDemanda = ""
        ValoresAnterioresDetalleDemanda = ""
        ValoresActualesDetalleDemanda = ""
        ListaBitacora.Clear()
        Me.chkCostoEstiva.Checked = False
        Me.chkCostoEstivaDescarga.Checked = False
        'deshabilitar
        tabs.Tabs(1).Enabled = False
        indicadorTercero = False
        Me.chkTercerizacion.Checked = False
        griTarifasProveedor.Visible = False

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
        tarifaInicial = 0
        indIngresaComsion = ""
        Me.idDemandaDetalle = ""
        Me.cboContactoCarga.Value = ""
        Me.cboContactoDescarga.Value = ""
        Me.txtTelfCarga.Text = ""
        Me.txtTelfDescarga.Text = ""
    End Sub

    Private Sub Llena_Detalle_Demanda()
        Try
            Dim idDireccionLLegada = Nothing
            If ValidaCamposDetalle() Then
                oeDemanda.oeDetalleDemanda = griDetalle.DataSource
                If Me.cboDireccionLlegada.Value <> "" Then
                    idDireccionLLegada = Me.cboDireccionLlegada.Value
                End If
                With oeDemandaDetalle
                    .Id = Me.idDemandaDetalle
                    .IdDemanda = ""
                    .IdCliente = cboCliente.Value
                    .Cliente = cboCliente.Text
                    .Comisionista = cboComisionista.Value
                    .IdTipoCarga = cboTipoCarga.Value
                    .TipoCarga = cboTipoCarga.Text
                    .Material = Me.cboMaterial.Text
                    .IdMaterial = Me.cboMaterial.Value
                    .Moneda = cboMoneda.Value
                    .Cantidad = txtCantidad.Text
                    .IncluyeIgv = verIncluyeIgv.Checked
                    .FleteUnitario = CalFleteUnitario.Value
                    .Flete = txtFleteTotalDetalle.Text
                    .Comision = txtComision.Text
                    .Facturado = verFacturado.Checked
                    .PagoContraEntrega = verPagoContraEntrega.Checked
                    .Activo = True
                    .Cargar = verCargar.Checked
                    .Descarga = verDescarga.Checked
                    .IdOrigen = cboOrigenDetalle.Value
                    .IdDestino = cboDestinoDetalle.Value
                    .DireccionOrigen = cboOrigenDetalle.Text
                    .DireccionDestino = cboDestinoDetalle.Text
                    .ClienteFinal = cboClienteFinal.Text
                    .IdClienteFinal = cboClienteFinal.Value
                    .Indicador = 0
                    .IdDireccionLugarPartida = Me.cboDireccionPartida.Value
                    .DireccionLugarLlegada = Me.cboDireccionLlegada.Text
                    .DireccionLugarPartida = Me.cboDireccionPartida.Text
                    .IdDireccionLugarLlegada = idDireccionLLegada
                    .Consolidado = Me.txtConsolidado.Text
                    .MotivoConsolidado = Me.txtMotivoConsolidado.Text
                    .CostoEstiba = Me.txtCostoEstiba.Value
                    .IncluyeIGVConsolidado = Me.chkIGVConsolidado.Checked
                    .Subtotal = Me.CalFleteUnitario.Value * Me.txtCantidad.Value
                    .IGV = Me.CalFleteUnitario.Value * ValorIgv
                    .AdelantoFlete = Me.txtAdelantoFlete.Value
                    .CostoEstibaDescarga = Me.txtCostoEstibaDescarga.Value
                    .GlosaCostoEstiba = Me.txtGlosaCostoEstibaDesc.Text
                    .Usuario = gUsuarioSGI.Id
                    .FalsoFlete = Me.chkIndFalsoFlete.Checked
                    .Usuario = (CalFleteUnitario.Value * (1 + ObtenerIGV()))
                    .IdContactoCarga = Me.cboContactoCarga.Value
                    .IdContactoDescarga = Me.cboContactoDescarga.Value
                End With


                If verPagoContraEntrega.Checked Then
                    oeDemandaDetalle.PagoEfectivoDeposito = "O"
                    If opPagoCont.CheckedIndex = 0 Then
                        oeDemandaDetalle.PagoEfectivoDeposito = "E"
                    Else
                        opPagoCont.CheckedIndex = 1
                        oeDemandaDetalle.PagoEfectivoDeposito = "D"
                    End If
                End If
                If tarifaInicial <> 0 And tarifaInicial <> oeDemandaDetalle.FleteUnitario Then
                    Dim incidencia As New e_IncidenciasAutentificadas
                    With incidencia
                        .IdArea = gUsuarioSGI.oeArea.Id
                        .IdActividadNegocio = pIdActividadNegocio
                        .IdResponsableAutoriza = gUsuarioSGI.Id
                        .IdUsuarioIncidente = gUsuarioSGI.Id
                        .Glosa = "Cambio de tarifa variable"
                        .Indicador = "V"
                    End With
                    oeDemandaDetalle.oeIncidenciaAutentificadas = incidencia
                End If
                If Me.idDemandaDetalle <> "" Then
                    oeDemanda.oeDetalleDemanda.Item(getIndiceDemandaDetalle(Me.idDemandaDetalle)) = oeDemandaDetalle
                Else
                    oeDemanda.oeDetalleDemanda.Add(oeDemandaDetalle)
                End If
                griDetalle.DataBind()
                CombosContactoDetalle()
                CalcularTotalesDetalle()
                numCantidadTercero.Value = IIf(oeDemanda.oeDetalleDemanda.Sum(Function(item) item.Cantidad) = 0, 1, oeDemanda.oeDetalleDemanda.Sum(Function(item) item.Cantidad))
                oeDemandaDetalle = New e_DemandaDetalle                
                ' totalFlete = totalFlete + txtFleteTotalDetalle.Text.Trim
                ' totalComision = totalComision + txtComision.Text.Trim
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Function getIndiceDemandaDetalle(ByVal idDemandaDetalle As String) As Integer
        Dim i As Integer = 0
        Try
            For Each obj As e_DemandaDetalle In oeDemanda.oeDetalleDemanda
                If obj.Id = idDemandaDetalle Then
                    Return i
                End If
                i = i + 1
            Next
        Catch ex As Exception

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

    Private Function ValidaCamposDetalle() As Boolean
        Try
            ValidarCombo(cboOrigen, "Ruta Origen")
            ValidarCombo(cboDestino, "Ruta Destino")
            ValidarComboValue(cboOrigenDetalle, "Ruta Origen")
            ValidarComboValue(cboDestinoDetalle, "Ruta Destino")
            ValidarCombo(cboTipoVehiculo, "Tipo Vehiculo")
            ValidarCombo(cboCliente, "Cliente")
            ValidarCombo(cboTipoCarga, "Tipo Carga")
            ValidarCombo(cboMaterial, "Material")
            ValidaCheckBox()
            If Me.cboCliente.Text.Contains("OTROS") AndAlso Me.cboClienteFinal.Text.Contains("OTROS") AndAlso Me.cboComisionista.Text.Contains("NINGUNO") Then
                Throw New Exception("Si el cliente es 'Otros' debe seleccionar comisionista")
            End If
            With oeDemandaDetalle
                .Cliente = cboCliente.Value
                .Comisionista = cboComisionista.Value
                .IdTipoCarga = cboTipoCarga.Value
                .Material = cboMaterial.Value
            End With
            olDemanda.ValidarDetalle(oeDemandaDetalle)
            If CalFleteUnitario.Value = 0 Then
                If MessageBox.Show("No esta autorizado para registrar FleteUnitario 0.00" & Environment.NewLine &
                    "Pedido Carga sin validaciones comuniquese con el " & gNombrePerfilJefeOperaciones & Environment.NewLine &
                    "Desea seguir registrando - Pedido Carga :  ?",
                    "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    IncidenciasPublic = New e_IncidenciasAutentificadas
                    Dim formulario As frm_Autorizacion
                    formulario = frm_Autorizacion
                    If formulario.ObtenerJefes(gNombrePerfilJefeOperaciones, "frm_Operacion1", pIdActividadNegocio) Then formulario.ShowDialog()
                    If IncidenciasPublic.IdResponsableAutoriza.Trim = "" Then
                        Throw New Exception("No tiene permisos para seguir resgistrando - Pedido Carga")
                    End If
                Else
                    Throw New Exception("No tiene permisos para seguir resgistrando - Pedido Carga")
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
    Private Sub FleteDetalle()
        Try
            With oeDemandaDetalle
                If Not String.IsNullOrEmpty(CalFleteUnitario.Text) AndAlso IsNumeric(CalFleteUnitario.Text.Trim.ToString) AndAlso CalFleteUnitario.Text > 0.0 Then
                    oeDemandaDetalle.FleteUnitario = CDbl(CalFleteUnitario.Text.Trim)
                    '  Me.CalFleteUnitarioIGV.Text = CDbl(CalFleteUnitario.Text.Trim) * ValorIgv
                    'btnAgregar.Visible = True   
                Else
                    CalFleteUnitario.Text = 0.0
                    CalFleteUnitarioIGV.Text = 0.0
                    txtFleteTotalDetalle.Text = 0
                    txtSubtotal.Text = 0
                End If
                If Not String.IsNullOrEmpty(txtCantidad.Text) AndAlso IsNumeric(txtCantidad.Text.Trim.ToString) Then
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

    Public Function EditarDemanda() As Boolean
        Try
            LlenarComboMaestro(cboDestino, LugaresPublic, 0)
            Me.cboDestino.DisplayMember = "Nombre"
            Me.cboDestino.ValueMember = "Id"
            LlenarComboMaestro(cboDestinoDetalle, LugaresPublic, 0)
            Me.cboDestinoDetalle.DisplayMember = "Nombre"
            Me.cboDestinoDetalle.ValueMember = "Id"
            With griLista.ActiveRow
                If .Cells("IdDemanda").Value.ToString.Length > 0 Then
                    exgruDetalle.Expanded = False
                    exgruFlete.Expanded = False
                    tabs.Tabs(0).Selected = True
                    Me.lblNumeroDemanda.Visible = False
                    Me.NroDemanda.Visible = False
                    If gUsuarioSGI.Controlado <> 0 Then
                        olFuncionesGenerales.ValidarFechaCierre(Operacion, .Cells("FechaAtendida").Value, FechaServidor.Date)
                    End If
                    Dim RutaLugarDestino As New List(Of e_Ruta)
                    oeDemanda = New e_Demanda
                    oeDemandaDetalle = New e_DemandaDetalle
                    oeContratoTercero = New e_ViajesTerceros
                    oeDemanda.Id = .Cells("IdDemanda").Value.ToString
                    oeDemanda.TipoOperacion = "6"
                    oeDemanda = olDemanda.Obtener(oeDemanda)
                    If oeDemanda Is Nothing Then
                        mensajeEmergente.Confirmacion(Me.Text & ": No se puede editar, ya fue generada - Pedido Carga - y/o fue cancelada", True)
                    Else
                        With oeDemanda
                            MostrarTabs(1, ficDemanda, 1)
                            If .Activo Then
                                codigo = .Id
                                txtNumero.Text = .Codigo
                                '     txtIdDemandaRapida.Text = .IdPreDemanda
                                '     txtCodigoDemandaRapida.Text = .CodigoPreDemanda
                                RutaDemanda = .IdRuta
                                oeRuta = New e_Ruta
                                oeRuta.Id = RutaDemanda
                                oeRuta = olRuta.Obtener(oeRuta)
                                With oeRuta
                                    RutaOrigen = .Origen
                                    RutaDestino = .Destino
                                    RutaIdOrigen = .IdOrigen
                                    RutaIdDestino = .IdDestino
                                End With
                                cboOrigen.Value = RutaIdOrigen
                                cboDestino.Value = RutaIdDestino
                                Me.cboOrigenDetalle.Value = RutaIdOrigen
                                Me.cboDestinoDetalle.Value = RutaIdDestino
                                'cboDestino.Text = RutaDestino
                                Me.cboOrigen.Enabled = False
                                Me.cboDestino.Enabled = False
                                cboTipoVehiculo.Value = .IdTipoVehiculo
                                TipoVehiculoEditado = cboTipoVehiculo.Text
                                Estado = .IdEstado
                                txtFleteTotal.Text = .TotalFlete
                                txtComisionTotal.Text = .TotalComision
                                Me.dtFechaAtencion.Value = .FechaAtendida
                                Me.dtSolicita.Value = .FechaSolicita
                                Me.dtFechaRecepcion.Value = .FechaRecepcion
                                Me.udtHoraSolicita.Value = .FechaSolicita.ToShortTimeString
                                Me.udtHoraAtencion.Value = .FechaAtendida.ToShortTimeString
                                Me.udtHoraRecepcion.Value = .FechaRecepcion.ToShortTimeString
                                Me.numNroUnidades.Value = .NroUnidades
                                txtObservacion.Text = .ObservacionPredemanda
                                oeDemandaDetalle.IdDemanda = .Id
                                griDetalle.DataSource = olDemanda.ListarDetalle(oeDemandaDetalle)
                                CombosContactoDetalle()
                                oeContratoTercero.IdDemanda = .Id
                                griDetalleTercero.DataSource = olViajeTercero.Listar(oeContratoTercero)
                                'MostrarTabs(1, ficDemanda, 1)
                                CalcularTotalesDetalle()
                                exgruDetalle.Expanded = False
                                If .IdEscala.Trim <> "0" Then
                                    Me.cboEscala.Value = .IdEscala
                                    Me.txtMotivoEscala.Visible = True
                                    Me.txtMotivoEscala.Text = .MotivoEscala
                                    Me.chkEscala.Checked = True
                                End If
                                Me.chkTercerizacion.Checked = .IndicadorTercero
                                Return True
                            Else
                                Throw New Exception(Me.Text & ": El Registro se encuentra eliminada no se puede editar pongase en contacto con el Administrador de Base de Datos")
                            End If
                        End With
                    End If
                End If
            End With
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Private Sub EnfocarDetalle(ByVal excepcion As String)
        If excepcion.Contains("Ruta Origen") Then cboOrigen.Focus()
        If excepcion.Contains("Ruta Destino") Then cboDestino.Focus()
        If excepcion.Contains("Tipo Vehiculo") Then cboTipoVehiculo.Focus()
        If excepcion.Contains("Cliente") Then cboCliente.Focus()
        If excepcion.Contains("Comisionista") Then cboComisionista.Focus()
        If excepcion.Contains("Tipo Carga") Then cboTipoCarga.Focus()
        If excepcion.Contains("Material") Then cboMaterial.Focus()
    End Sub

    Private Sub ComboGrilla()
        Try
            Dim Lugar As New DataTable
            Dim DireccionesO As New DataTable
            Dim Cliente As New DataTable
            Dim Comisionista As New DataTable
            Cliente = olCombo.ComboGrilla(ClientesPublic)
            Comisionista = olCombo.ComboGrilla(ComisionistasPublic)

            CrearComboGrid("IdMaterial", "Nombre", griDetalle, olCombo.ComboGrilla(MaterialesPublic), True)
            CrearComboGrid("Moneda", "Nombre", griDetalle, olCombo.ComboGrilla(MonedaPublic), True)
            CrearComboGrid("IdMoneda", "Nombre", griDetalleTercero, olCombo.ComboGrilla(MonedaPublic), True)
            CrearComboGrid("Comisionista", "Nombre", griDetalle, Comisionista, True)

            CrearComboGrid("IdTercero", "Nombre", griDetalleTercero, olCombo.ComboGrilla(ListTercero), True)
            Dim personacontacto = olCombo.ComboGrilla(PersonasPublic)
            CrearComboGrid("IdContacto", "Nombre", griDetalleTercero, personacontacto, True)
            Lugar = olCombo.ComboGrilla(LugaresPublic)

            Dim ListaPuntoPartida = New List(Of e_Combo)
            Dim oeDireccionEmpresa = New e_Combo
            oeDireccionEmpresa.Nombre = "DireccionEmpresa"
            oeDireccionEmpresa.Id = ""
            ListaPuntoPartida.AddRange(olDireccionEmpresa.Listar(oeDireccionEmpresa))
            DireccionesO = olCombo.ComboGrilla(ListaPuntoPartida)

            CrearComboGrid("idDireccionLugarPartida", "Nombre", griDetalle, DireccionesO, True)

            ListaPuntoPartida.Clear()
            oeDireccionEmpresa.Id = ""
            ListaPuntoPartida.AddRange(olDireccionEmpresa.Listar(oeDireccionEmpresa))
            DireccionesO = olCombo.ComboGrilla(ListaPuntoPartida)
            CrearComboGrid("idDireccionLugarLlegada", "Nombre", griDetalle, DireccionesO, True)
            listaPagoEfectivo = New List(Of e_Combo)
            listaPagoEfectivo.Add(New e_Combo("E", "Efectivo", ""))
            listaPagoEfectivo.Add(New e_Combo("D", "Deposito", ""))
            listaPagoEfectivo.Add(New e_Combo("O", "Otros", ""))
            '
            CrearComboGrid("PagoEfectivoDeposito", "Nombre", griDetalle, olCombo.ComboGrilla(listaPagoEfectivo), True)
            ''
            CrearComboGrid("IdClienteFinal", "Nombre", griDetalle, olCombo.ComboGrilla(ClientesPublic), True)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub InicializarEntidad()
        oeDemanda = New e_Demanda
    End Sub

    Private Sub ColorControles()
        '----------------------------------------------
        '------Estados de Viaje------------------------
        ColorGenerada.Color = Color.White
        ColorCancelada.Color = Color.Orange
        ColorAsignada.Color = Color.LimeGreen
        ' ColorAprobada.Color = Color.CadetBlue
        '----------------------------------------------
        '------Cambio de Registro------------------------
        colorCambio.Color = Color.Cyan
        '----------------------------------------------
        '------Dispinibilidad-----------------------
        ColorVencidas.Color = Color.Red
        ColorPorVencer.Color = Color.GreenYellow
    End Sub

    Public Sub habilitarControles(ByVal bolean As Boolean)
        ' Me.txtNumero.Enabled = bolean
        Me.dtSolicita.Enabled = bolean
        Me.dtFechaAtencion.Enabled = bolean
        Me.dtFechaRecepcion.Enabled = bolean
        Me.cboOrigen.Enabled = bolean
        Me.cboDestino.Enabled = bolean
        Me.numNroUnidades.Enabled = bolean
        Me.cboTipoVehiculo.Enabled = bolean
        If Me.tipo = "GD" Then
            Me.cboEscala.Enabled = bolean
            Me.chkEscala.Enabled = bolean
            Me.txtMotivoEscala.Enabled = bolean            
        End If
       
        Me.txtObservacion.Enabled = bolean
        Me.btnAgregar.Enabled = bolean
        Me.btnAgregarTerc.Enabled = bolean
        Me.NroDemanda.Visible = bolean
        Me.lblNumeroDemanda.Visible = bolean
        Me.udtHoraAtencion.Enabled = bolean
        Me.udtHoraSolicita.Enabled = bolean
        Me.udtHoraRecepcion.Enabled = bolean
        Me.chkTercerizacion.Enabled = bolean
    End Sub
    Dim frmDR As frm_DemandaRapida
    Public Function GenerarDemanda(ByVal idDemanda As String, ByVal tipo As String, ByVal frm As frm_DemandaRapida) As Boolean
        Try
            ' Operacion = "Editar"
            frmDR = frm
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            exgruConsultas.Visible = False
            codigo = idDemanda
            Me.tipo = tipo
            ' With griLista.ActiveRow
            If idDemanda.Length > 0 Then
                exgruDetalle.Expanded = False
                exgruFlete.Expanded = False
                '        Me.lblNumeroDemanda.Visible = False
                '  Me.NroDemanda.Visible = False
                '  If gUsuarioSGI.Controlado <> 0 Then
                'olFuncionesGenerales.ValidarFechaCierre(Operacion, .Cells("FechaAtendida").Value, FechaServidor.Date)
                '  End If
                Dim RutaLugarDestino As New List(Of e_Ruta)
                oeDemanda = New e_Demanda
                oeDemandaDetalle = New e_DemandaDetalle
                oeContratoTercero = New e_ViajesTerceros
                oeDemanda.Id = idDemanda
                oeDemanda.TipoOperacion = "6"
                oeDemanda = olDemanda.Obtener(oeDemanda)

                If oeDemanda Is Nothing Then
                    mensajeEmergente.Confirmacion(Me.Text & ": No se puede editar, ya fue generada - Pedido Carga - y/o fue cancelada", True)
                Else
                    With oeDemanda
                        If .Activo Then
                            codigo = .Id
                            txtNumero.Text = .Codigo
                            '     txtIdDemandaRapida.Text = .IdPreDemanda
                            '     txtCodigoDemandaRapida.Text = .CodigoPreDemanda
                            RutaDemanda = .IdRuta
                            oeRuta = New e_Ruta
                            oeRuta.Id = RutaDemanda
                            oeRuta = olRuta.Obtener(oeRuta)
                            With oeRuta
                                RutaOrigen = .Origen
                                RutaDestino = .Destino
                                RutaIdOrigen = .IdOrigen
                                RutaIdDestino = .IdDestino
                            End With
                            cboOrigen.Value = RutaIdOrigen
                            cboDestino.Value = RutaIdDestino
                            Me.cboOrigenDetalle.Value = RutaIdOrigen
                            Me.cboDestinoDetalle.Value = RutaIdDestino

                            Me.cboOrigen.Enabled = False
                            Me.cboDestino.Enabled = False
                            cboDestino.Text = RutaDestino
                            cboTipoVehiculo.Value = .IdTipoVehiculo
                            Estado = .IdEstado
                            txtFleteTotal.Text = .TotalFlete
                            txtComisionTotal.Text = .TotalComision
                            Me.dtFechaAtencion.Value = .FechaAtendida
                            Me.dtFechaRecepcion.Value = .FechaRecepcion
                            Me.dtSolicita.Value = .FechaSolicita
                            Me.udtHoraSolicita.Value = .FechaSolicita.ToShortTimeString
                            Me.udtHoraAtencion.Value = .FechaAtendida.ToShortTimeString
                            Me.udtHoraRecepcion.Value = .FechaRecepcion.ToShortTimeString
                            txtObservacion.Text = .ObservacionPredemanda
                            oeDemandaDetalle.IdDemanda = .Id
                            griDetalle.DataSource = olDemanda.ListarDetalle(oeDemandaDetalle)
                            oeContratoTercero.IdDemanda = .Id
                            griDetalleTercero.DataSource = olViajeTercero.Listar(oeContratoTercero)
                            MostrarTabs(1, ficDemanda, 1)
                            CalcularTotalesDetalle()
                            exgruDetalle.Expanded = False                            
                            If .IdEscala.Trim <> "0" Then
                                Me.cboEscala.Value = .IdEscala
                                Me.txtMotivoEscala.Visible = True
                                Me.txtMotivoEscala.Text = .MotivoEscala
                                Me.chkEscala.Checked = True
                            End If
                            Me.chkTercerizacion.Checked = .IndicadorTercero
                            '  exgruConsultas.Expanded = False                            
                        Else
                            Throw New Exception(Me.Text & ": El Registro se encuentra eliminada no se puede editar pongase en contacto con el Administrador de Base de Datos")
                        End If
                    End With
                End If

            End If
            ' End With
            habilitarControles(False)

            '  tabs.Visible = True
            '    tabs.Tabs(0).Selected = True
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Private Sub CalcularTotalesDetalle()
        totalFlete = 0.0
        totalComision = 0.0
        oeDemanda.oeDetalleDemanda = griDetalle.DataSource
        For Each totalesFlete As e_DemandaDetalle In oeDemanda.oeDetalleDemanda
            totalFlete += totalesFlete.Flete
            totalComision += totalesFlete.Comision
        Next
    End Sub

    Private Function ValidaCamposCabecera() As Boolean
        Try
            ValidarCombo(cboOrigen, "Lugar Origen")
            ValidarCombo(cboDestino, "Lugar Destino")
            'ValidarCombo(cboEscala, "Lugar de Escala")
            If dtSolicita.Value > Me.dtFechaAtencion.Value Then
                dtSolicita.Focus()
                Throw New Exception("Fecha Atencion no puede ser menor a la Fecha Solicitada")
            End If
            If dtFechaAtencion.Value > Me.dtFechaRecepcion.Value Then
                dtFechaAtencion.Focus()
                Throw New Exception("Fecha de Recepción no puede ser menor a la Fecha de Atención")
            End If
            If griDetalle.Rows.Count = 0 Then
                Throw New Exception("Debe ingresar algún detalle")
            End If
            If Me.chkTercerizacion.Checked Then
                If griDetalleTercero.Rows.Count <= 0 Then
                    Throw New Exception("Debe ingresar algún detalle de Terceros")
                End If
            End If
            Dim listaDetalle As List(Of e_DemandaDetalle) = griDetalle.DataSource
            If Operacion = "Nuevo" Then
                If MessageBox.Show("Verificar Datos" & vbCrLf & "Tipo de Vehiculo: " & cboTipoVehiculo.Text & vbCrLf & "Origen: " &
                              cboOrigen.Text & vbCrLf & "Destino: " & cboDestino.Text & vbCrLf &
                              "Flete Unit:" & listaDetalle.Sum(Function(item) item.FleteUnitario).ToString("###,##0.000") & vbCrLf &
                               "Flete Unit C/IGV:" & listaDetalle.Sum(Function(item) item.FleteUnitario + item.IGV).ToString("###,##0.000"), "Información del Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Cancel Then
                    Return False
                End If
            Else
                If TipoVehiculoEditado <> cboTipoVehiculo.Text Then
                    If MessageBox.Show("Ud. ha cambiado el tipo de vehiculo " &
                                       TipoVehiculoEditado & " por el tipo " & cboTipoVehiculo.Text & ". Desea confirmar los cambios?", "Información del Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Cancel Then
                        Return False
                    End If
                End If
            End If
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Private Function GuardarDemandaPredemanda() As Boolean
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            If Me.tipo = "GD" Then
                olDemanda.ConfirmarDemanda(oeDemanda)
                mensajeEmergente.Confirmacion("Pedido Carga confirmada", True)
                MyBase.Consultar(True)
                If frmDR IsNot Nothing Then
                    frmDR.Enabled = True
                    Me.tipo = ""
                End If
                listarNuevo()
                Return True
            Else
                If ValidaCamposCabecera() Then
                    CalcularTotalesDetalle()
                    oeRuta = New e_Ruta
                    oeRuta.IdOrigen = cboOrigen.Value
                    oeRuta.IdDestino = cboDestino.Value
                    oeRuta = olRuta.Obtener(oeRuta)
                    Dim oeDemanda As New e_Demanda
                    With oeDemanda
                        .Id = codigo
                        .FechaAtendida = Date.Parse(dtFechaAtencion.Value.ToShortDateString & " " & udtHoraAtencion.Value.ToShortTimeString)
                        .Activo = True
                        .IdEstado = estadoDP
                        .Proceso = "DEMANDA"
                        .UsuarioCreacion = gUsuarioSGI.Id
                        .IdRuta = oeRuta.Id
                        .IdTipoVehiculo = cboTipoVehiculo.Value
                        .Observacion = ""
                        .oeIncidenciaAutentificadas = IncidenciasPublic
                        .Indicador = 2
                        .FechaSolicita = Date.Parse(dtSolicita.Value.ToShortDateString & " " & udtHoraSolicita.Value.ToShortTimeString)
                        .IdOrigen = Me.cboOrigen.Value
                        .IdDestino = Me.cboDestino.Value
                        .FechaCambioADemanda = Nothing
                        .ObservacionPredemanda = Me.txtObservacion.Text
                        .EstadoPredemanda = estadoDP
                        .FechaCancelacion = Nothing
                        .Justificacion = ""
                        .NroUnidades = Me.numNroUnidades.Value
                        .IdEscala = Me.cboEscala.Value
                        .IdUsuarioCancelacion = Nothing
                        .MotivoEscala = Me.txtMotivoEscala.Text
                        .NroDemanda = Me.NroDemanda.Value
                        .TotalFlete = totalFlete
                        .TotalComision = totalComision
                        .Estado = estadoDP
                        .EstadoPredemanda = "1CH00002"
                        .FechaRecepcion = Date.Parse(dtFechaRecepcion.Value.ToShortDateString & " " & udtHoraRecepcion.Value.ToShortTimeString)
                        .IndicadorTercero = indicadorTercero
                    End With
                    '  griDetalle.DataBind()

                    oeDemanda.oeDetalleDemanda = griDetalle.DataSource
                    oeDemanda.oeContratoTercero = griDetalleTercero.DataSource
                    FiltrarLista()
                    oeDemanda.oeListaBitacora = ListaBitacora
                    oeDemanda.PrefijoID = gs_PrefijoIdSucursal '@0001
                    If olDemanda.GuardarDemandaPredemanda(oeDemanda) Then
                        mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                    End If
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

    Public Sub listarNuevo()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Select Case tabDemandaCargas.SelectedTab.Index
                Case 0
                    oeDemanda.FechaDesde = fecDesde.Value
                    oeDemanda.FechaHasta = fecHasta.Value
                    oeDemanda.UsuarioCreacion = Me.cboUsuario.Value
                    oeDemanda.Tipo = "D"
                    oeDemanda.TipoOperacion = "1"
                    oeDemanda.Estado = IIf(VerAsignada.Checked, "1CH00002", "")
                    oeDemanda.IndicadorTercero = chkTercerizadoFiltro.Checked
                    oeDemanda.Indicador = Me.chkExcluirDemandas.Checked
                    Dim dsDemada As DataSet = olDemanda.ListarDemandaRapidaDataSet(oeDemanda)
                    Dim parentCol As DataColumn = dsDemada.Tables(0).Columns("IdDemanda")
                    Dim childCol As DataColumn = dsDemada.Tables(1).Columns("IdDemanda")
                    Dim childCol1 As DataColumn = dsDemada.Tables(2).Columns("IdDemanda")
                    Dim relation As DataRelation = New DataRelation("FK_RelacionDemanda", parentCol, childCol, True)
                    Dim relation1 As DataRelation = New DataRelation("FK_RelacionDemanda1", parentCol, childCol1, True)
                    dsDemada.Relations.Add(relation)
                    dsDemada.Relations.Add(relation1)
                    dsDemada.AcceptChanges()
                    griLista.DataSource = dsDemada
                    With griLista.DisplayLayout.Bands(0)
                        .Columns("TotalFlete").CellAppearance.TextHAlign = HAlign.Right
                        .Columns("TotalComision").CellAppearance.TextHAlign = HAlign.Right
                        .Columns("Subtotal").CellAppearance.TextHAlign = HAlign.Right
                        .Columns("Indicador").Header.Caption = "Generado en"
                        .Columns("EstadoPredemanda").Hidden = True
                        .Columns("IndEnvioCorreo").Style = ColumnStyle.CheckBox
                        .Columns("FleteUnitIGV").Width = 70
                        .Columns("FleteUnitIGV").Format = "#,###,###,##0.0000"
                        .Columns("FleteUnitIGV").CellAppearance.TextHAlign = HAlign.Right
                        .Columns("Observacion").CellAppearance.Image = imagenes.Images.Item(18)
                        .Columns("Observacion").CellAppearance.ImageHAlign = HAlign.Right
                        .Columns("Observacion").CellButtonAppearance.Image = imagenes.Images.Item(16)
                        .Columns("Observacion").CellButtonAppearance.ImageHAlign = HAlign.Right
                        ' .Columns("Indicador").Text = "Se genero en "
                    End With
                    With griLista.DisplayLayout.Bands(1)
                        .Columns("CostoEstiba").CellAppearance.TextHAlign = HAlign.Right
                        .Columns("CostoEstibaDescarga").CellAppearance.TextHAlign = HAlign.Right
                        .Columns("IdDemanda").Hidden = True
                        .Columns("Flete").CellAppearance.BackColor = Color.Plum
                        .Columns("Flete").Width = 70
                        .Columns("Flete").CellAppearance.TextHAlign = HAlign.Right
                        .Columns("Flete").Format = "#,###,###,##0.000"
                        .Columns("EstadoPredemanda").Hidden = True
                        .Columns("AdelantoFlete").Width = 70
                        .Columns("AdelantoFlete").CellAppearance.TextHAlign = HAlign.Right
                        .Columns("AdelantoFlete").Format = "#,###,###,##0.000"
                        '.Columns("Flete").MaskInput = "{LOC}n,nnn,nnn,nnn.nn"
                        .Columns("Comision").CellAppearance.TextHAlign = HAlign.Right
                        .Columns("Comision").CellAppearance.BackColor = Color.Khaki
                        .Columns("Comision").MaskInput = "{LOC}n,nnn,nnn,nnn.nnn"
                        .Columns("Comision").Format = "#,###,###,##0.000"
                        .Columns("Cantidad").Width = 60
                        .Columns("Cantidad").CellAppearance.TextHAlign = HAlign.Right
                        .Columns("Cantidad").Format = "#,###,###,##0.000"
                        .Columns("Programado").Width = 70
                        .Columns("Programado").CellAppearance.TextHAlign = HAlign.Right
                        .Columns("Programado").CellAppearance.BackColor = Color.SandyBrown
                        .Columns("PorProgramar").Width = 80
                        .Columns("PorProgramar").CellAppearance.TextHAlign = HAlign.Right
                        .Columns("PorProgramar").CellAppearance.BackColor = Color.LightCoral
                        .Columns("Cliente").Width = 200

                        .Columns("TipoCarga").Width = 100
                        .Columns("Material").Width = 100
                        .Columns("Moneda").Width = 30
                        .Columns("FleteUnitario").Width = 70
                        .Columns("FleteUnitario").Format = "#,###,###,##0.0000"
                        .Columns("FleteUnitario").CellAppearance.TextHAlign = HAlign.Right
                        .Columns("FleteUnitIGV").Width = 70
                        .Columns("FleteUnitIGV").Format = "#,###,###,##0.0000"
                        .Columns("FleteUnitIGV").CellAppearance.TextHAlign = HAlign.Right
                        .Columns("Subtotal").Format = "#,###,###,##0.0000"
                        .Columns("Subtotal").CellAppearance.TextHAlign = HAlign.Right
                        .Columns("Comisionista").Width = 150
                        .Columns("Facturado").Width = 50
                        .Columns("PagoContraEntrega").Width = 50
                        .Columns("Estado").Width = 100
                        .Columns("Consolidado").Width = 60
                        .Columns("Consolidado").CellAppearance.TextHAlign = HAlign.Right
                        .Columns("Consolidado").Format = "#,###,###,##0.000"
                        .Columns("MotivoConsolidado").Width = 100
                        .Columns("DireccionOrigen").Width = 100
                        .Columns("DireccionDestino").Width = 100
                        .Columns("DireccionLugarPartida").Width = 100
                        .Columns("DireccionLugarLlegada").Width = 100
                        .Override.FilterUIType = FilterUIType.HeaderIcons
                        .Override.AllowRowFiltering = DefaultableBoolean.False
                        .Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.None
                        .Override.CellPadding = 1
                        .Columns("DireccionOrigen").Header.Caption = "Lugar Origen"
                        .Columns("DireccionDestino").Header.Caption = "Lugar Destino"
                        .Columns("ClienteFinal").Width = 200
                        .Columns("IncluyeIGVConsolidado").Header.Caption = "I.C IGV"
                        '     .Columns("Estado").Hidden = True
                        .Columns("PesoGuias").CellAppearance.TextHAlign = HAlign.Right
                        .Columns("PesoCallCenter").CellAppearance.TextHAlign = HAlign.Right
                        .Columns("PesoGuias").Header.Caption = "P.Guias"
                        .Columns("PesoCallCenter").Header.Caption = "P.CallCenter"
                        .Columns("CostoEstibaDescarga").Header.Caption = "C.E.Descarga"
                        .Columns("Id").Hidden = True
                        .Columns("CostoEstibaDescarga").Format = "#,###,###,##0.000"
                        .Columns("CostoEstiba").Format = "#,###,###,##0.000"

                    End With
                    With griLista.DisplayLayout.Bands(2)
                        .Columns("IdDemanda").Hidden = True
                        .Columns("Tercero").Width = 200
                        .Columns("Contacto").Width = 150
                        .Columns("Comision").CellAppearance.TextHAlign = HAlign.Right
                        .Columns("Comision").CellAppearance.BackColor = Color.Khaki
                        .Columns("Comision").MaskInput = "{LOC}n,nnn,nnn,nnn.nnn"
                        .Columns("FleteUnitario").Width = 80
                        .Columns("FleteUnitario").CellAppearance.BackColor = Color.Plum
                        .Columns("FleteUnitario").CellAppearance.TextHAlign = HAlign.Right
                        .Columns("FleteUnitario").Format = "#,###,###,##0.00000"
                        .Columns("Igv").Width = 50
                        .Columns("Igv").CellAppearance.TextHAlign = HAlign.Right
                        .Columns("Igv").CellAppearance.BackColor = Color.Khaki
                        .Columns("Igv").MaskInput = "{LOC}n,nnn,nnn,nnn.nnn"
                        .Columns("TotalFlete").Width = 80
                        .Columns("TotalFlete").CellAppearance.BackColor = Color.Plum
                        .Columns("TotalFlete").CellAppearance.TextHAlign = HAlign.Right
                        .Columns("TotalFlete").Format = "#,###,###,##0.0000"
                        .Columns("Moneda").Width = 50
                        .Override.FilterUIType = FilterUIType.HeaderIcons
                        .Override.AllowRowFiltering = DefaultableBoolean.False
                        .Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.None
                        .Override.CellPadding = 1
                        .Columns("Id").Hidden = True
                        .Columns("Subtotal").CellAppearance.TextHAlign = HAlign.Right
                        .Columns("Cantidad").CellAppearance.TextHAlign = HAlign.Right
                        .Columns("Subtotal").Format = "#,###,###,##0.0000"
                        .Columns("Cantidad").Format = "#,###,###,##0.000"

                    End With
                    'Tania
                    '   CalcularTotalesLista()
                    For I As Integer = 0 To griLista.Rows.Count - 1
                        If griLista.Rows(I).Cells("Seleccion").Value = 0 Then
                            If griLista.Rows(I).Cells("Estado").Value = "GENERADA" Then
                                griLista.Rows(I).CellAppearance.BackColor = Me.ColorGenerada.Color
                            End If
                            If griLista.Rows(I).Cells("Estado").Value = "PARCIAL" Then
                                griLista.Rows(I).CellAppearance.BackColor = Me.ColorParcial.Color
                            End If
                            If griLista.Rows(I).Cells("Estado").Value = "ASIGNADA" Then
                                griLista.Rows(I).CellAppearance.BackColor = Me.ColorAsignada.Color
                            End If
                            If griLista.Rows(I).Cells("Estado").Value = "CANCELADA" Then
                                griLista.Rows(I).CellAppearance.BackColor = Me.ColorCancelada.Color
                            End If
                            If griLista.Rows(I).Cells("Estado").Value = "APROBADA" Then
                                griLista.Rows(I).CellAppearance.BackColor = Me.ColorAprobada.Color
                            End If

                            'If griLista.Rows(I).Cells("FechaModificacion").Value <> griLista.Rows(I).Cells("FechaCreacion").Value Then
                            '    griLista.Rows(I).CellAppearance.BackColor = Me.colorCambio.Color
                            'End If
                        End If
                        'Me.griLista.Rows(I).ExpandAll()
                    Next
                    'Ubica el cursor el el primer registro de la grilla
                    If griLista.Rows.Count > 0 Then
                        griLista.Focus()
                        griLista.Rows.Item(0).Selected = True
                    End If
                Case 1
                    oeViaje = New e_Viaje
                    oeViaje.FechaDesde = fecDesde.Value
                    oeViaje.FechaHasta = fecHasta.Value
                    oeViaje.TipoOperacion = "7"
                    oeViaje.IdEstado = ""
                    oeViaje.Centro = ""
                    leCargas = olOperacion.ListarViaje(oeViaje)
                    CargarPorFacturar(leCargas, griFactura)
            End Select
            'InicializaTiempo()
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub


    Private Sub Enfocar(ByVal excepcion As String)
        If excepcion.Contains("Origen") Then cboOrigen.Focus()
        If excepcion.Contains("Destino") Then cboDestino.Focus()
        If excepcion.Contains("Escala") Then cboEscala.Focus()
    End Sub

    Private Sub CargarPorFacturar(ByVal leViaje As List(Of e_Viaje), ByVal Grilla As UltraGrid, Optional ByVal Band As Boolean = True)

        With Grilla
            If bandload Then
                .ResetDisplayLayout()
                .DisplayLayout.ViewStyle = ViewStyle.SingleBand
            End If
            .DataSource = leViaje
            If bandload Then
                For Each Col As UltraGridColumn In .DisplayLayout.Bands(0).Columns
                    'Or Col.Header.Caption.Contains("Salida") _
                    'Or Col.Header.Caption.Contains("Incidencia") _
                    If Col.Header.Caption.Contains("Id") _
                    Or Col.Header.Caption.Contains("Llegada") _
                    Or Col.Header.Caption.Contains("Usuario") _
                    Or Col.Header.Caption.Contains("Disponible") _
                    Then Col.Hidden = True : Col.ExcludeFromColumnChooser = ExcludeFromColumnChooser.True
                    If Col.Header.Caption = "Seleccion" Then
                        Col.CellActivation = Activation.AllowEdit
                        Col.CellClickAction = CellClickAction.Edit
                    Else
                        Col.CellActivation = Activation.NoEdit
                        Col.CellClickAction = CellClickAction.RowSelect
                    End If
                Next

                ExcluirColumna(Grilla, "Activo", "CargaOrigen", "DescargaDestino", "DiaNoche", "GlosaEscala", "ImpresionGuiaOrigen", "IndEscala", _
                               "IndFecha", "IngresoComplejoOrigen", "IngresoDestino", "KmTractoOrigen", "KmTractoDestino", "TerminoCargaOrigen", _
                               "TerminoDescargaDestino", "Tesoreria", "Turno", "ViajeVacio", "SalidaDestino")

                OcultarColumna(Grilla, True, "Tesoreria", "Activo", "ViajeVacio", "Turno", "DiaNoche", "Carga", "Flota", "Zona", "IndFecha", "PorcentajeFlete", _
                               "IndEscala", "GlosaEscala", "KmTractoOrigen", "IngresoComplejoOrigen", "CargaOrigen", "TerminoCargaOrigen", "ImpresionGuiaOrigen", _
                               "IngresoDestino", "DescargaDestino", "TerminoDescargaDestino", "Operacion", "Estado", "KmTractoDestino", "Copiloto", "Ayudante", _
                               "SalidaDestino", "Capacidad", "IndCarga", "Produccion", "Cantidad", "FleteUnitario", "IncluyeIgv", "IncidenciaOperaciones", "IncidenciaSeguimiento")

                'If Prefijo.PrefijoID = "1CH" Then '@0001
                'If gs_PrefijoIdSucursal = "1CH" Then '@0001
                .DisplayLayout.Bands(0).Columns("TipoVehiculo").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Piloto").Hidden = True
                'End If

                .DisplayLayout.Bands(0).Columns("Fecha").SortIndicator = SortOrder.Ascending

                .DisplayLayout.Bands(0).Columns("Seleccion").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("Codigo").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("Fecha").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("SalidaOrigen").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("Cliente").Header.VisiblePosition = 4
                .DisplayLayout.Bands(0).Columns("Origen").Header.VisiblePosition = 5
                .DisplayLayout.Bands(0).Columns("Destino").Header.VisiblePosition = 6
                .DisplayLayout.Bands(0).Columns("Tracto").Header.VisiblePosition = 7
                .DisplayLayout.Bands(0).Columns("Carreta").Header.VisiblePosition = 8
                .DisplayLayout.Bands(0).Columns("TipoVehiculo").Header.VisiblePosition = 9
                .DisplayLayout.Bands(0).Columns("CargaMaterial").Header.VisiblePosition = 10
                .DisplayLayout.Bands(0).Columns("KmCarretaOrigen").Header.VisiblePosition = 11
                .DisplayLayout.Bands(0).Columns("PesoToneladas").Header.VisiblePosition = 12
                .DisplayLayout.Bands(0).Columns("KmCarretaDestino").Header.VisiblePosition = 13
                .DisplayLayout.Bands(0).Columns("TotalFlete").Header.VisiblePosition = 14
                .DisplayLayout.Bands(0).Columns("Piloto").Header.VisiblePosition = 15
                .DisplayLayout.Bands(0).Columns("Escala").Header.VisiblePosition = 16

                .DisplayLayout.Bands(0).Columns("KmCarretaOrigen").Header.Caption = "Cantidad"
                .DisplayLayout.Bands(0).Columns("KmCarretaDestino").Header.Caption = "Precio"
                .DisplayLayout.Bands(0).Columns("SalidaOrigen").Header.Caption = "Fec. Salida Carga"
                .DisplayLayout.Bands(0).Columns("Operacion").Header.Caption = "Nº Operacion"
                .DisplayLayout.Bands(0).Columns("Codigo").Header.Caption = "Nº Viaje"
                .DisplayLayout.Bands(0).Columns("Fecha").Header.Caption = "Fecha Viaje"
                .DisplayLayout.Bands(0).Columns("Estado").Header.Caption = "Est. Viaje"
                .DisplayLayout.Bands(0).Columns("PesoToneladas").Header.Caption = "Peso Ton."
                .DisplayLayout.Bands(0).Columns("Escala").Header.Caption = "Documentos"
                .DisplayLayout.Bands(0).Columns("Flota").Header.Caption = "Tipo Carga"
                .DisplayLayout.Bands(0).Columns("Zona").Header.Caption = "Glosa GRT"
                .DisplayLayout.Bands(0).Columns("IncidenciaOperaciones").Header.Caption = "Codigo Semana"
                .DisplayLayout.Bands(0).Columns("IncidenciaSeguimiento").Header.Caption = "Comisionista"

                .DisplayLayout.Bands(0).Columns("Seleccion").Width = 30
                .DisplayLayout.Bands(0).Columns("Codigo").Width = 93
                .DisplayLayout.Bands(0).Columns("Fecha").Width = 100
                .DisplayLayout.Bands(0).Columns("Cliente").Width = 150
                .DisplayLayout.Bands(0).Columns("Tracto").Width = 53
                .DisplayLayout.Bands(0).Columns("Carreta").Width = 53
                .DisplayLayout.Bands(0).Columns("PesoToneladas").Width = 55
                .DisplayLayout.Bands(0).Columns("KmCarretaOrigen").Width = 55
                .DisplayLayout.Bands(0).Columns("Piloto").Width = 150
                .DisplayLayout.Bands(0).Columns("Escala").Width = 150

                .DisplayLayout.UseFixedHeaders = True
                .DisplayLayout.Override.FixedHeaderIndicator = FixedHeaderIndicator.None
                .DisplayLayout.Bands(0).Columns("Seleccion").Header.Fixed = True
                If Band Then
                    .DisplayLayout.Bands(0).Columns("Codigo").Header.Fixed = True
                    .DisplayLayout.Bands(0).Columns("Fecha").Header.Fixed = True
                    .DisplayLayout.Bands(0).Columns("Cliente").Header.Fixed = True
                End If

                .DisplayLayout.Bands(0).Columns("Fecha").Style = ColumnStyle.DateTime
                .DisplayLayout.Bands(0).Columns("SalidaOrigen").Style = ColumnStyle.DateTime

                FormatoColumna(Grilla, "#,##0.00", ColumnStyle.Double, HAlign.Right, "TotalFlete", "KmCarretaDestino", "PesoToneladas", "KmCarretaOrigen")

                .DisplayLayout.Bands(0).Columns("Operacion").CellAppearance.TextVAlign = VAlign.Middle
                .DisplayLayout.Bands(0).Columns("Codigo").CellAppearance.TextVAlign = VAlign.Middle

                .DisplayLayout.Bands(0).Columns("Codigo").MergedCellStyle = MergedCellStyle.Always

                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)

                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1
            End If
            CalcularTotales(Grilla, "PesoToneladas", "TotalFlete")
        End With
    End Sub

#End Region
#Region "Instancia"

#Region "Eventos"
    Private Sub ControlRangoFechaInicializa()
        fecDesde.Value = Date.Today.AddDays(-5)
        fecHasta.Value = Date.Today.AddDays(+1)
        dtSolicita.Value = Date.Today
    End Sub
#End Region

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    ''' <summary>
    ''' Instancia unica de Formulario: frm_Demanda
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_Demanda()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

    Private Sub frm_Demanda_Load(sender As Object, e As EventArgs) Handles MyBase.Load        
        bandload = True
        '   LlenaCombos()
        '  ComboGrilla()
        LlenaComboUsuario()
        ControlRangoFechaInicializa()
        ColorControles()
        CalcularTotales(griDetalle, "Flete", "Comision", "Consolidado", "Subtotal")
        '    Me.dtFechaRecepcion.Value = FechaServidor.AddDays(1)
        '    Me.dtFechaAtencion.Value = FechaServidor
        '   Me.dtSolicita.Value = FechaServidor
        tabDemandaCargas.Tabs(1).Visible = False        
        CargarActividadesRestringidas()
    End Sub

    Private Sub cboOrigen_Validated(sender As Object, e As EventArgs) Handles cboOrigen.Validated
        Try
            RutaIdOrigen = cboOrigen.Value
            cboDestino.Items.Clear()
            oeRuta = New e_Ruta
            oeRuta.IdOrigen = RutaIdOrigen
            LlenarComboMaestro(cboDestino, olRuta.Listar(oeRuta), -1)
            LlenarComboMaestro(cboDestinoDetalle, olRuta.Listar(oeRuta), -1)
            cboDestino.Value = RutaIdDestino
            cboDestinoDetalle.Value = RutaIdDestino
            If Operacion = "Nuevo" Then

                Me.cboOrigenDetalle.Value = cboOrigen.Value
                oeRuta = New e_Ruta
                oeRuta.TipoOperacion = "O"
                oeRuta.IdOrigen = RutaIdOrigen
                oeRuta = olRuta.Obtener(oeRuta)
                With oeRuta
                    If .Id.Trim <> "" And RutaIdDestino.Trim = "" Then
                        cboTipoVehiculo.Value = .Id
                        cboCliente.Value = .Codigo
                        cboTipoCarga.Value = .IdCentro
                        cboMaterial.Value = .IdFlota
                        RutaIdDestino = .IdDestino
                        cboDestino.Value = RutaIdDestino
                    End If
                End With
                chkEscala.Checked = False
            End If
        Catch ex As Exception
            Throw ex
        End Try
       
    End Sub

    Private Sub cboDestino_Leave(sender As Object, e As EventArgs) Handles cboDestino.Leave
        If Operacion = "Nuevo" Or Operacion = "Editar" Then
            oeRuta = New e_Ruta
            olRuta = New l_Ruta
            Try
                If Me.cboDestino.Text.Trim <> "" Then
                    oeRuta.Id = ""
                    oeRuta.IdOrigen = cboOrigen.Value
                    oeRuta.IdDestino = cboDestino.Value
                    olRuta.ValidarRutaNueva(oeRuta)
                End If
                
            Catch ex As Exception
                EnviarEmail("consultores.tecnologicos.2010@gmail.com", "consultores.tecnologicos.2010@gmail.com;consultores.tecnologicos.2010@gmail.com", "", "", "Operaciones informa crear ruta", cboOrigen.Text & " - " & cboDestino.Text, "", True)
                cboDestino.Focus()
                cboDestino.SelectedIndex = -1
                mensajeEmergente.Problema("Origen - Destino  : " & ex.Message, True)
                cboOrigen.Focus()
            End Try
        End If
    End Sub

    Private Sub cboDestino_Validated(sender As Object, e As EventArgs) Handles cboDestino.Validated
        Try
            If Operacion = "Nuevo" Then
                RutaIdOrigen = cboOrigen.Value
                RutaIdDestino = cboDestino.Value
                Me.cboDestinoDetalle.Value = cboDestino.Value
                oeRuta = New e_Ruta
                oeRuta.TipoOperacion = "O"
                oeRuta.IdOrigen = RutaIdOrigen
                oeRuta = olRuta.Obtener(oeRuta)
                With oeRuta
                    If .Id.Trim <> "" And .IdDestino = RutaIdDestino Then
                        cboTipoVehiculo.Value = .Id
                        cboCliente.Value = .Codigo
                        cboTipoCarga.Value = .IdCentro
                        cboMaterial.Value = .IdFlota
                        cboDestino.Value = .IdDestino
                    End If
                End With
                oeRuta = New e_Ruta
                oeRuta.IdOrigen = cboOrigen.Value
                oeRuta.IdDestino = cboDestino.Value
                oeRuta = olRuta.Obtener(oeRuta)
                RutaDemanda = oeRuta.Id
                ObtenerFleteUnitario()
                RutaIdDestino = ""
                'calcular horas aprox en fcha recepcion                 
                oeRuta.TipoOperacion = ""
                oeRuta = olRuta.Obtener(oeRuta)
                Dim fechas As DateTime = Date.Parse(dtFechaAtencion.Value.ToShortDateString & " " & udtHoraAtencion.Value.ToShortTimeString)
                If oeRuta.HorasSolo > 0 Then
                    dtFechaRecepcion.Value = fechas.AddHours(oeRuta.HorasSolo)
                    udtHoraRecepcion.Value = fechas.AddHours(oeRuta.HorasSolo)
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboTipoVehiculo_Validated(sender As Object, e As EventArgs) Handles cboTipoVehiculo.Validated
        Try
            If Operacion = "Nuevo" Or Operacion = "Editar" Then
                oeDemanda.IdTipoVehiculo = cboTipoVehiculo.Value
                ObtenerFleteUnitario()
                If cboTipoVehiculo.Text = "PARIHUELERO" Then cboTipoCarga.Text = "VIAJE"
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboEscala_Leave(sender As Object, e As EventArgs) Handles cboEscala.Leave
        If Operacion = "Nuevo" Or Operacion = "Editar" Then
            Try
                If cboEscala.Text <> "" Then
                    ValidarCombo(cboEscala, "Escala")
                    ValidaEscala(cboOrigen.Text & " - " & cboEscala.Text, cboOrigen.Value, cboEscala.Value)
                    ValidaEscala(cboEscala.Text & " - " & cboDestino.Text, cboEscala.Value, cboDestino.Value)
                End If

            Catch ex As Exception
                mensajeEmergente.Problema(ex.Message, True)
                cboEscala.SelectedIndex = -1
                cboEscala.Focus()
                ' chkEscala.Checked = False
            End Try
        End If
    End Sub
    Dim tarifaInicial As Decimal = 0
    Private Sub ObtenerFleteUnitario()
        Try
            tarifaInicial = 0
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
                oeLugar.Id = cboOrigenDetalle.Value
                oeLugar = olLugar.Obtener(oeLugar)
                If oeLugar.IdReferencia.Trim <> "" Then
                    oeTarifa.IdOrigen = oeLugar.IdReferencia
                Else
                    oeTarifa.IdOrigen = cboOrigenDetalle.Value
                End If
                '--------------------------------
                oeLugar = New e_Lugar
                oeLugar.Id = cboDestinoDetalle.Value
                oeLugar = olLugar.Obtener(oeLugar)
                If oeLugar.IdReferencia.Trim <> "" Then
                    oeTarifa.IdDestino = oeLugar.IdReferencia
                Else
                    oeTarifa.IdDestino = cboDestinoDetalle.Value
                End If
                IndCampaña = 1
            Else
                oeTarifa.IdOrigen = cboOrigenDetalle.Value
                oeTarifa.IdDestino = cboDestinoDetalle.Value
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
                If CDate(dtFechaAtencion.Value) >= CDate(oeTarifa.FInicioCampaña) Then
                    If CDate(dtFechaAtencion.Value) <= CDate(oeTarifa.FFinCampaña) Then
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

    Private Function ValidaEscala(ByVal Mensaje As String, ByVal Origen As String, ByVal Destino As String) As Boolean
        Try
            olRuta = New l_Ruta
            Mensaje = "El Usuario: " & gUsuarioSGI.oePersona.NombreCompleto & ",No existe la ruta: " & Mensaje
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

    Private Sub chkEscala_CheckedChanged(sender As Object, e As EventArgs) Handles chkEscala.CheckedChanged
        If Me.chkEscala.Checked = True Then
            Me.cboEscala.Enabled = True
            Me.txtMotivoEscala.Visible = True
            Me.chkConsolidado.Checked = True
            Me.txtConsolidado.Value = 500
        Else
            Me.cboEscala.Enabled = False
            Me.cboEscala.SelectedIndex = -1
            Me.txtMotivoEscala.Text = ""
            Me.txtMotivoEscala.Visible = False
            Me.chkConsolidado.Checked = False
            Me.txtConsolidado.Value = 0
        End If
    End Sub

    Private Sub cboCliente_Validated(sender As Object, e As EventArgs) Handles cboCliente.Validated
        If Operacion = "Nuevo" Or Operacion = "Editar" Then
            If cboCliente.SelectedIndex > -1 Then
                Dim ListaPuntoPartida = New List(Of e_Combo)
                Dim oeDireccionEmpresa = New e_Combo
                oeDireccionEmpresa.Nombre = "DireccionEmpresa"
                oeDireccionEmpresa.Id = cboCliente.Value
                ListaPuntoPartida.AddRange(olDireccionEmpresa.Listar(oeDireccionEmpresa))
                LlenarComboMaestro(cboDireccionPartida, ListaPuntoPartida, 0)
                cboDireccionPartida.Value = IdPuntoPartida
                Me.txtRucCLiente.Text = ClientesPublic.Item(cboCliente.SelectedIndex).Descripcion
                cboClienteFinal.Value = cboCliente.Value
                ObtenerFleteUnitario()
                FleteDetalle()
                'llenar combos contactos
                ListaPuntoPartida = New List(Of e_Combo)
                oeDireccionEmpresa = New e_Combo
                oeDireccionEmpresa.Nombre = "Contacto"
                oeDireccionEmpresa.Id = cboCliente.Value
                ListaPuntoPartida.AddRange(olDireccionEmpresa.Listar(oeDireccionEmpresa))
                LlenarComboMaestro(cboContactoCarga, ListaPuntoPartida, -1)
                LlenarComboMaestro(cboContactoDescarga, ListaPuntoPartida, -1)
            End If
        End If
    End Sub

    Private Sub cboClienteFinal_ValueChanged(sender As Object, e As EventArgs) Handles cboClienteFinal.ValueChanged
        If cboClienteFinal.SelectedIndex > -1 Then
            Me.txtRucCLienteFinal.Text = ClientesPublic.Item(cboClienteFinal.SelectedIndex).Descripcion
        Else
            Me.txtRucCLienteFinal.Text = ""
        End If
    End Sub

    Private Sub cboComisionista_ValueChanged(sender As Object, e As EventArgs) Handles cboComisionista.ValueChanged
        Dim extras As ArrayList
        If cboComisionista.SelectedIndex >= 0 Then
            indiceCom = Me.cboComisionista.SelectedIndex
            Me.txtRucComisionista.Text = ComisionistasPublic.Item(cboComisionista.SelectedIndex).Descripcion
            extras = ComisionistasPublic.Item(cboComisionista.SelectedIndex).Extras
            If extras.Count > 0 Then
                Me.txtApellidoPaternoComisionista.Text = extras.Item(0).ToString
                Me.txtApellidoMaterno.Text = extras.Item(1).ToString
                Me.txtNombreComisonista.Text = extras.Item(2).ToString
                Me.txtTelefonoComisionista.Text = extras.Item(3).ToString
                '   codigoComisionista = extras.Item(4).ToString
            End If

            If Me.cboComisionista.Text.Contains("NINGUNO") Then
                Me.txtComision.Enabled = False
                Me.txtTelefonoComisionista.Text = ""
                Me.txtRucComisionista.Text = ""
                Me.txtComision.Value = 0
                If Me.cboCliente.Text.Contains("NINGUNO") AndAlso Me.cboClienteFinal.Text.Contains("NINGUNO") Then
                    Me.cboComisionista.SelectedIndex = 0
                    Me.cboComisionista.Focus()
                    mensajeEmergente.Confirmacion("Si Cliente es 'Otros', Debe elegir un comisionista", True)
                End If
            Else
                Me.txtComision.Enabled = True
            End If
        Else
            Me.txtApellidoPaternoComisionista.Text = ""
            Me.txtApellidoMaterno.Text = ""
            Me.txtNombreComisonista.Text = ""
            Me.txtTelefonoComisionista.Text = ""
        End If
    End Sub

    Private Sub cboComisionista_EditorButtonClick(sender As Object, e As EditorButtonEventArgs) Handles cboComisionista.EditorButtonClick
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

    Private Sub cboTipoCarga_Validated(sender As Object, e As EventArgs) Handles cboTipoCarga.Validated
        Dim num = Math.Truncate(CDbl(Me.txtCantidad.Text.ToString))
        Try
            If cboTipoCarga.Text.ToString = "VIAJE" And num <> CDbl(Me.txtCantidad.Text.ToString) Then
                txtCantidad.Text = Me.numNroUnidades.Value
                Throw New Exception("Tipo de carga VIAJE, debe ingresar valores enteros")
                txtCantidad.Focus()
                Return
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.ToString, True)
        End Try

        ObtenerFleteUnitario()
    End Sub

    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged
        Dim indice = Me.txtCantidad.Text.ToString.LastIndexOf(".")
        Dim num = 1
        Try
            If IsNumeric(Me.txtCantidad.Value) Then
                num = Math.Truncate(CDbl(Me.txtCantidad.Text.ToString))
            Else
                Me.txtCantidad.Value = 1
            End If
            If cboTipoCarga.Text.ToString = "VIAJE" And num <> CDbl(Me.txtCantidad.Text.ToString) Then
                txtCantidad.Text = Me.numNroUnidades.Value
                Throw New Exception("Tipo de carga VIAJE, debe ingresar valores enteros")
                txtCantidad.Focus()
                Return
            End If
            FleteDetalle()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub CalFleteUnitario_ValueChanged(sender As Object, e As EventArgs) Handles CalFleteUnitario.ValueChanged
        If Not String.IsNullOrEmpty(CalFleteUnitario.Value) AndAlso IsNumeric(CalFleteUnitario.Value) AndAlso CalFleteUnitario.Value >= 0.0 Then
            If Not CalFleteUnitarioIGV.Focused Then
                CalFleteUnitarioIGV.Value = (CDbl(CalFleteUnitario.Value) + CDbl(CalFleteUnitario.Value) * ValorIgv).ToString("###,##0.0000")
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
        If Not String.IsNullOrEmpty(CalFleteUnitario.Value) AndAlso IsNumeric(CalFleteUnitario.Value.Trim.ToString) AndAlso CalFleteUnitario.Value >= 0.0 Then
            CalFleteUnitarioIGV.Value = (CDbl(CalFleteUnitario.Value) + CDbl(CalFleteUnitario.Value) * ValorIgv).ToString("###,##0.0000")
            FleteDetalle()
        Else
            CalFleteUnitario.Text = 0.0
        End If
    End Sub

    'Private Sub CalFleteUnitarioIGV_KeyDown(sender As Object, e As KeyEventArgs) Handles CalFleteUnitarioIGV.KeyDown
    '    CalFleteUnitario.Text = CDbl(CalFleteUnitarioIGV.Text.Trim) / 1.18
    '    FleteDetalle()
    'End Sub

    Private Sub chkConsolidado_CheckedChanged(sender As Object, e As EventArgs) Handles chkConsolidado.CheckedChanged
        If Me.chkConsolidado.Checked = True Then
            Me.txtConsolidado.Enabled = True
            Me.txtMotivoConsolidado.Visible = True
            Me.txtConsolidado.Text = "0"
            Me.txtMotivoConsolidado.Text = ""
            chkIGVConsolidado.Enabled = True
        Else
            Me.txtConsolidado.Enabled = False
            Me.txtMotivoConsolidado.Visible = False
            Me.chkIGVConsolidado.Checked = False
            Me.txtConsolidado.Text = "0"
            chkIGVConsolidado.Enabled = False
        End If
    End Sub

    Private Sub verIncluyeIgv_CheckedChanged(sender As Object, e As EventArgs) Handles verIncluyeIgv.CheckedChanged
        Try
            FleteDetalle()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub chkCostoEstiva_CheckedChanged(sender As Object, e As EventArgs) Handles chkCostoEstiva.CheckedChanged
        If Me.chkCostoEstiva.Checked Then
            Me.txtCostoEstiba.Enabled = True
            Me.txtGlosaCostoEstibaDesc.Visible = True
            If Me.griTarifasProveedor.Visible = False Then
                Me.griTarifasProveedor.Visible = True
                oeTarifaProveedor = New e_TarifasProveedor
                oeTarifaProveedor.IdLugar = Me.cboDestinoDetalle.Value
                oeTarifaProveedor.IdMaterial = Me.cboMaterial.Value
                Me.griTarifasProveedor.DataSource = olTarifasProveedor.ListarTarifasProveedor(oeTarifaProveedor)
            End If
        Else
            Me.txtCostoEstiba.Enabled = False
            Me.txtCostoEstiba.Value = 0
            If Me.chkCostoEstivaDescarga.Checked = False Then
                Me.txtGlosaCostoEstibaDesc.Text = ""
                Me.txtGlosaCostoEstibaDesc.Visible = False
                Me.griTarifasProveedor.Visible = False
            End If
        End If
    End Sub

    Private Sub btnAgregarTerc_Click(sender As Object, e As EventArgs) Handles btnAgregarTerc.Click
        Try
            ValidarCombo(cboTercero, "Tercero")
            If numFleteTotalTerc.Text > 0 Then
                If numFleteTotalTerc.Value <= totalFlete Then

                    oeDemanda.oeContratoTercero = griDetalleTercero.DataSource
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
                        .IndOperacion = IIf(Me.chkIndPlantilla.Checked = True, 5, 0)
                        .IdMovimientoDocumento = ""
                        .Glosa = txtReferenciaTercero.Text.Trim
                        .Observacion = txtObservacionTercero.Text.Trim
                        .Cantidad = numCantidadTercero.Value
                        .SubTotal = numSubTotalTercero.Value
                    End With
                    oeDemanda.oeContratoTercero.Add(oeContratoTercero)
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
                    Me.chkIndPlantilla.Checked = False
                Else
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
                If IsNumeric(numFleteTotalTerc.Text) = False Then
                    numFleteTotalTerc.Text = 0
                End If
                FleteTotalTercero()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
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

    Private Sub dtFechaAtencion_ValidatedChanged(sender As Object, e As EventArgs) Handles dtFechaAtencion.Validated
        Try
            If (Operacion = "Nuevo" Or Operacion = "Editar") And dtFechaAtencion.Value < FechaServidor.ToShortDateString And dtFechaAtencion.Focused Then
                dtFechaAtencion.Value = FechaServidor
                Throw New Exception("La fecha de atención no puede ser menor a la fecha actual y/o fecha solicitada")
            End If
            If (Operacion = "Nuevo" Or Operacion = "Editar") And Me.dtFechaAtencion.Value > Me.dtFechaRecepcion.Value And dtFechaAtencion.Focused Then
                Me.dtFechaRecepcion.Value = dtFechaAtencion.Value
                '   Throw New Exception("La fecha de atención no puede ser mayor a la fecha de recepción")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
            dtFechaAtencion.CloseUp()
        End Try
    End Sub

    Private Sub cboOrigenDetalle_Validated(sender As Object, e As EventArgs) Handles cboOrigenDetalle.Validated
        Try
            If Me.cboOrigenDetalle.Text.ToString <> Me.cboOrigen.Text.ToString AndAlso Me.cboOrigenDetalle.Text.ToString <> Me.cboEscala.Text.ToString Then
                Me.cboOrigenDetalle.Focus()
                Throw New Exception("Debe coincidir con el origen general o escala")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
        RutaIdOrigenDetalle = cboOrigenDetalle.Value
        'cboDestinoDetalle.Items.Clear()
        oeRuta = New e_Ruta
        oeRuta.IdOrigen = RutaIdOrigenDetalle
        'LlenarComboMaestro(cboDestinoDetalle, olRuta.Listar(oeRuta), -1)
        'cboDestinoDetalle.Value = RutaIdDestinoDetalle
        If Operacion = "Nuevo" Then

            oeRuta = New e_Ruta
            oeRuta.TipoOperacion = "O"
            oeRuta.IdOrigen = RutaIdOrigenDetalle
            oeRuta = olRuta.Obtener(oeRuta)
            With oeRuta
                If .Id.Trim <> "" And RutaIdDestinoDetalle.Trim = "" Then
                    cboTipoVehiculo.Value = .Id
                    cboCliente.Value = .Codigo
                    cboTipoCarga.Value = .IdCentro
                    cboMaterial.Value = .IdFlota
                    RutaIdDestinoDetalle = .IdDestino
                    cboDestinoDetalle.Value = RutaIdDestinoDetalle
                End If
            End With
        End If
    End Sub

    Private Sub cboDestinoDetalle_Validated(sender As Object, e As EventArgs) Handles cboDestinoDetalle.Validated
        Try
            If Me.cboDestinoDetalle.Text.ToString <> Me.cboDestino.Text.ToString AndAlso Me.cboDestinoDetalle.Text.ToString <> Me.cboEscala.Text.ToString Then

                If Me.cboDestino.Value <> "" Then
                    Me.cboOrigenDetalle.Focus()
                    Throw New Exception("Debe coincidir con el destino general o escala")
                Else
                    Me.cboDestino.Focus()
                    Throw New Exception("Debe elegir primero el destino general")
                End If
                ObtenerFleteUnitario()
            End If
            If Operacion = "Nuevo" Then
                RutaIdOrigenDetalle = cboOrigenDetalle.Value
                RutaIdDestinoDetalle = cboDestinoDetalle.Value
                Me.cboDestinoDetalle.Value = cboDestinoDetalle.Value
                oeRuta = New e_Ruta
                oeRuta.TipoOperacion = "O"
                oeRuta.IdOrigen = RutaIdOrigenDetalle
                oeRuta = olRuta.Obtener(oeRuta)
                With oeRuta
                    If .Id.Trim <> "" And .IdDestino = RutaIdDestinoDetalle Then
                        cboTipoVehiculo.Value = .Id
                        cboCliente.Value = .Codigo
                        cboTipoCarga.Value = .IdCentro
                        cboMaterial.Value = .IdFlota
                        cboDestinoDetalle.Value = .IdDestino
                    End If
                End With
                oeRuta = New e_Ruta
                oeRuta.IdOrigen = cboOrigenDetalle.Value
                oeRuta.IdDestino = cboDestinoDetalle.Value
                oeRuta = olRuta.Obtener(oeRuta)
                RutaDemanda = oeRuta.Id
                ObtenerFleteUnitario()
                RutaIdDestinoDetalle = ""
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            Llena_Detalle_Demanda()
            limpiarDetalleDemanda()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
            EnfocarDetalle(ex.Message)
        End Try
    End Sub

    Private Sub limpiarDetalleDemanda()
        cboComisionista.Text = "NINGUNO  ,"
        Me.txtNombreComisonista.Text = ""
        Me.txtApellidoPaternoComisionista.Text = ""
        Me.txtApellidoMaterno.Text = ""
        Me.txtTelefonoComisionista.Text = ""
        Me.txtRucComisionista.Text = ""
        cboTipoCarga.SelectedIndex = -1
        cboMaterial.SelectedIndex = -1
        cboCliente.Focus()
        cboCliente.SelectedIndex = -1
        Me.cboDireccionPartida.Value = ""
        Me.cboDireccionLlegada.Value = ""
        Me.txtRucCLiente.Text = ""
        Me.txtAdelantoFlete.Text = 0
        'Me.cboDireccionPartida.SelectedIndex = -1
        'cboDireccionLLegada.SelectedIndex = -1
        cboDireccionLlegada.Text = ""

        cboClienteFinal.SelectedIndex = -1
        CalFleteUnitario.Value = 0
        CalFleteUnitarioIGV.Value = 0
        txtCantidad.Text = "1"
        txtFleteTotal.Text = "0"
        Me.txtComisionTotal.Text = "0"
        txtComision.Text = "0"
        Me.txtConsolidado.Text = "0"
        Me.chkConsolidado.Checked = False
        Me.txtMotivoConsolidado.Text = ""
        Me.chkCostoEstiva.Checked = False
        Me.txtCostoEstiba.Enabled = False
        Me.txtCostoEstiba.Value = "0"
        Me.chkCostoEstivaDescarga.Checked = False
        Me.txtCostoEstibaDescarga.Enabled = False
        Me.txtCostoEstibaDescarga.Value = "0"
        cboMaterial.Value = "1CH000001393"
        Me.cboTipoCarga.Value = "1CH000000001"
        txtSubtotal.Value = 0
        txtFleteTotalDetalle.Value = 0
        Me.verCargar.Checked = False
        Me.verDescarga.Checked = False
        Me.verPagoContraEntrega.Checked = False
        Me.tarifaInicial = 0
        Me.chkIGVConsolidado.Checked = False
        verValidaFU.Checked = True
        Me.chkIndFalsoFlete.Checked = False
        indIngresaComsion = ""
        Me.idDemandaDetalle = ""
        Me.cboContactoCarga.SelectedIndex = -1
        Me.cboContactoDescarga.SelectedIndex = -1
        Me.txtTelfCarga.Text = ""
        Me.txtTelfDescarga.Text = ""
    End Sub

    Private Sub frm_Demanda_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Select Case Operacion
            Case "Nuevo"
                MyBase.Nuevo()
                AyudaMaestros(TipoCliente)
                TipoCliente = 0
            Case "Editar"
                MyBase.Editar()
            Case "Inicializa"
                MostrarTabs(0, ficDemanda)
                numDiasAntes.Value = 1
                TipoCliente = 0
                If _Activo Then
                    ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
                Else
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                End If
                'Consultar(True)
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
        If codigoTerceroBand.Trim <> "" Then
            ListTercero = New List(Of e_Combo)
            oeCombo = New e_Combo
            oeCombo.Nombre = "Transportista"
            ListTercero.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)
            LlenarComboMaestro(cboTercero, ListTercero, 1)
            Me.cboTercero.Value = codigoTerceroBand
            'Me.cboComisionista.Value = codigoNuevoCom
            codigoTerceroBand = ""
        End If
        'contactos carga y descarga
        If codigoContactoCarga <> "" Then
            If cboCliente.SelectedIndex > -1 Then
                Dim lista As New List(Of e_Combo)
                Dim olContacto As New e_Combo
                olContacto.Nombre = "Contacto"
                olContacto.Id = Me.cboCliente.Value
                lista.AddRange(olCombo.Listar(olContacto))
                LlenarComboMaestro(cboContactoCarga, lista, 0)
                LlenarComboMaestro(cboContactoDescarga, lista, 0)
                Me.cboContactoCarga.SelectedIndex = 0
            End If
            codigoContactoCarga = ""
        End If
        If codigoContactoDescarga <> "" Then
            If cboCliente.SelectedIndex > -1 Then
                Dim lista As New List(Of e_Combo)
                Dim olContacto As New e_Combo
                olContacto.Nombre = "Contacto"
                olContacto.Id = Me.cboCliente.Value
                lista.AddRange(olCombo.Listar(olContacto))
                LlenarComboMaestro(cboContactoDescarga, lista, 0)
                LlenarComboMaestro(cboContactoCarga, lista, 0)
                Me.cboContactoDescarga.SelectedIndex = 0
            End If
            codigoContactoDescarga = ""
        End If
        ControlBotoneraPorActividad("Activated")
    End Sub

    Private Sub AyudaMaestros(ByVal Tipo As Integer)
        oeCliente = New e_Cliente
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
                oeCombo.Nombre = "Origen"
                'RutasPublic = New List(Of e_Combo)
                'RutasPublic.AddRange(olCombo.Listar(oeCombo))
                'LlenarComboMaestro(cboRuta, RutasPublic.OrderBy(Function(iten) iten.Nombre).ToList, -1)    
                '    oeLugar = New e_Lugar
                '    oeLugar.TipoOperacion = "O"
                '   LlenarComboMaestro(cboOrigen, olLugar.Listar(oeLugar), 0)
        End Select
    End Sub

    Private Sub frm_Demanda_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        bandCarga = ""
        instancia = Nothing
    End Sub

    Private Sub frm_Demanda_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If frmDR IsNot Nothing Then
            frmDR.Enabled = True
            Me.tipo = ""
        End If
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

    Private Sub frm_Demanda_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub

    Private Sub griLista_DoubleClick(sender As Object, e As EventArgs) Handles griLista.DoubleClick
        Editar()
        
    End Sub

    Private Sub griLista_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griLista.BeforeRowsDeleted
        Try
            e.DisplayPromptMsg = False
            If griLista.ActiveRow.Cells("Estado").Value.ToString.Trim = "GENERADA" Then
                mostrarMotivoCancelacion("E")
            Else
                e.Cancel = True
                mensajeEmergente.Confirmacion("Solo se pueden ELIMINAR - Pedido Carga - GENERADAS", True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Sub mostrarMotivoCancelacion(ByVal band As String)
        Try
            'If band = "E" Then
            '    If gUsuarioSGI.Controlado <> 0 AndAlso CDate(griLista.ActiveRow.Cells("FechaAtendida").Value) <= FechaServidor.AddDays(-7).Date Then
            '        Throw New Exception("Solo se pueden ELIMINAR las demandas GENERADAS con 6 dias sin atender")
            '    End If
            'End If
            ListaBitacora.Clear()
            Dim testDialog As New frm_justificacion_cancelacion()
            testDialog.tipo = "D"
            If band = "C" Then
                AccionSistema = gAccionSistema.CANCELAR.ToString
                testDialog.Text = "Motivo de Cancelación"
                Dim listaCancelacion = New List(Of e_Combo)
                oeCombo = New e_Combo
                oeCombo.Nombre = "ConceptoCancelacion"
                oeCombo.Descripcion = "Descripcion;NombreTabla;Demanda"
                listaCancelacion = olCombo.Listar(oeCombo)
                LlenarComboMaestro(testDialog.cboConcepto, listaCancelacion, 0)
            Else
                If band = "A" Then
                    AccionSistema = gAccionSistema.ELIMINAR.ToString
                    testDialog.Text = "Motivo de Asignacion de Pedido Carga"
                    Dim listaCancelacion = New List(Of e_Combo)
                    oeCombo = New e_Combo
                    oeCombo.Nombre = "ConceptoAsignacion"
                    oeCombo.Descripcion = "Descripcion;NombreTabla;Demanda"
                    listaCancelacion = olCombo.Listar(oeCombo)
                    LlenarComboMaestro(testDialog.cboConcepto, listaCancelacion, 0)
                Else
                    AccionSistema = gAccionSistema.ELIMINAR.ToString
                    testDialog.Text = "Motivo de Eliminación"
                    Dim listaCancelacion = New List(Of e_Combo)
                    oeCombo = New e_Combo
                    oeCombo.Nombre = "ConceptoEliminacion"
                    oeCombo.Descripcion = "Descripcion;NombreTabla;Demanda"
                    listaCancelacion = olCombo.Listar(oeCombo)
                    LlenarComboMaestro(testDialog.cboConcepto, listaCancelacion, 0)
                End If
            End If
            If griLista.ActiveRow.Cells("estado").Value.ToString = "CANCELADA" Or griLista.ActiveRow.Cells("estado").Value.ToString = "ASIGNADA" Then
                Throw New Exception("Pedido Carga ha sido CANCELADA o ASIGNADA")
            End If
            If (gUsuarioSGI.leARUsuario.Where(Function(item) item.IdActividadNegocio = gActividadNegocio.Demanda.ToString And
                                                  item.AccionSistema = AccionSistema And item.IdProcesoNegocio = pProcesoNegocio)).ToList.Count > 0 Then
                If testDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
                    If band = "A" Then
                        oeDemandaRapida.Id = griLista.ActiveRow.Cells("IdDemanda").Value
                        oeDemandaRapida.Justificacion = motivoCancelacion
                        oeDemandaRapida.IdUsuario = gUsuarioSGI.Id
                        olDemandaRapida.CambioDeEstado(oeDemandaRapida)
                        listarNuevo()
                    Else
                        If band = "C" Then
                            For i As Integer = 0 To griLista.ActiveRow.ChildBands(0).Rows.Count - 1
                                ListaBitacora.Add(New e_Bitacora(griLista.ActiveRow.Cells("IdDemanda").Value,
                                                                 griLista.ActiveRow.ChildBands(0).Rows(i).Cells("Id").Value, "OPE.Demanda", "OPE.DemandaDetalle",
                                                   Me.Text, New List(Of String), gUsuarioSGI.Id, "C",
                                                   New List(Of String), New List(Of String), "C", "I", False))
                            Next
                            For i As Integer = 0 To griLista.ActiveRow.ChildBands(1).Rows.Count - 1
                                ListaBitacora.Add(New e_Bitacora(griLista.ActiveRow.Cells("IdDemanda").Value,
                                                                 griLista.ActiveRow.ChildBands(1).Rows(i).Cells("Id").Value, "OPE.Demanda", "OPE.ViajesTerceros",
                                                   Me.Text, New List(Of String), gUsuarioSGI.Id, "C",
                                                   New List(Of String), New List(Of String), "C", "I", False))
                            Next
                            CancelarDemandaRapida()
                            listarNuevo()
                        Else
                            For i As Integer = 0 To griLista.ActiveRow.ChildBands(0).Rows.Count - 1
                                ListaBitacora.Add(New e_Bitacora(griLista.ActiveRow.Cells("IdDemanda").Value,
                                                                 griLista.ActiveRow.ChildBands(0).Rows(i).Cells("Id").Value, "OPE.Demanda", "OPE.DemandaDetalle",
                                                   Me.Text, New List(Of String), gUsuarioSGI.Id, "E",
                                                   New List(Of String), New List(Of String), "E", "I", False))
                            Next
                            For i As Integer = 0 To griLista.ActiveRow.ChildBands(1).Rows.Count - 1
                                ListaBitacora.Add(New e_Bitacora(griLista.ActiveRow.Cells("IdDemanda").Value,
                                                                 griLista.ActiveRow.ChildBands(1).Rows(i).Cells("Id").Value, "OPE.Demanda", "OPE.ViajesTerceros",
                                                   Me.Text, New List(Of String), gUsuarioSGI.Id, "E",
                                                   New List(Of String), New List(Of String), "E", "I", False))
                            Next

                            If EliminarDemandaRapida() Then
                                listarNuevo()
                            End If
                        End If
                    End If
                End If
            Else
                mensajeEmergente.Confirmacion("No esta autorizado para realizar esta operación", True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Function CancelarDemandaRapida() As Boolean
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            With griLista
                If ValidarGrilla(griLista, "Demanda Rapida") Then
                    oeDemandaRapida.Id = griLista.ActiveRow.Cells("IdDemanda").Value
                    oeDemandaRapida.IdUsuario = gUsuarioSGI.Id
                    oeDemandaRapida.Justificacion = motivoCancelacion                  
                    oeDemandaRapida.IdConceptoCancelacionEliminacion = IdConceptoCancEliminacion
                    oeDemanda = New e_Demanda
                    oeDemandaDetalle = New e_DemandaDetalle
                    oeContratoTercero = New e_ViajesTerceros
                    oeDemanda.Id = oeDemandaRapida.Id
                    oeDemanda.TipoOperacion = "6"

                    oeDemanda = olDemanda.Obtener(oeDemanda)
                    oeDemandaRapida.Indicador = oeDemanda.Indicador
                    If oeDemanda Is Nothing Then
                        mensajeEmergente.Confirmacion(Me.Text & ": No se puede cancelar, ya fue generada - Pedido Carga - y/o fue cancelada", True)
                    Else
                        oeDemandaRapida.oeListaBitacora = ListaBitacora
                        olDemandaRapida.Cancelar(oeDemandaRapida)
                        'Consultar(True)
                        Operacion = "Inicializa"
                        If griLista.Rows.Count > 0 Then
                            ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
                        Else
                            ControlBoton(1, 1, 0, 0, 0, 0, 1, 0, 1)
                        End If

                    End If

                End If
            End With
            ugb_Espera.Visible = False
            Return True
        Catch ex As Exception
            Throw ex
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Function

    Private Function EliminarDemandaRapida() As Boolean
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            With griLista
                If ValidarGrilla(griLista, "Demanda Rapida") Then
                    oeDemandaRapida.Id = griLista.ActiveRow.Cells("IdDemanda").Value
                    oeDemanda = New e_Demanda
                    oeDemandaDetalle = New e_DemandaDetalle
                    oeDemandaRapida.Justificacion = motivoCancelacion
                    oeDemandaRapida.IdConceptoCancelacionEliminacion = IdConceptoCancEliminacion
                    oeContratoTercero = New e_ViajesTerceros
                    oeDemanda.Id = oeDemandaRapida.Id
                    oeDemanda.TipoOperacion = "6"
                    oeDemanda = olDemanda.Obtener(oeDemanda)
                    If oeDemanda Is Nothing Then
                        mensajeEmergente.Confirmacion(Me.Text & ": No se puede eliminar, ya fue generada - Pedido Carga - y/o fue cancelada", True)
                        Return False
                    Else
                        oeDemandaRapida.oeListaBitacora = ListaBitacora
                        oeDemandaRapida.IdUsuario = gUsuarioSGI.Id
                        olDemandaRapida.Eliminar(oeDemandaRapida)
                        'Consultar(True)
                        Operacion = "Inicializa"
                        If griLista.Rows.Count > 0 Then
                            ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
                        Else
                            ControlBoton(1, 1, 0, 0, 0, 0, 1, 0, 1)
                        End If

                    End If

                End If
            End With
            ugb_Espera.Visible = False
            Return True
        Catch ex As Exception
            Throw ex
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Function

    Private Sub cboCliente_EditorButtonClick(sender As Object, e As EditorButtonEventArgs) Handles cboCliente.EditorButtonClick
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
                    '   Empresa.NuevoCliente()

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

    Private Sub cboDireccionPartida_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles cboDireccionPartida.InitializeLayout
        With cboDireccionPartida.DisplayLayout.Bands(0)
            .Columns("Id").Hidden = True
            .Columns("Nombre").Hidden = False
            .Columns("Nombre").Width = 500
            .Columns("Descripcion").Hidden = True
        End With
    End Sub

    Private Sub cboDireccionPartida_KeyDown(sender As Object, e As KeyEventArgs) Handles cboDireccionPartida.KeyDown
        With CType(sender, Infragistics.Win.UltraWinGrid.UltraCombo)
            If e.KeyData = Keys.Delete Then
                .Text = ""
            End If
        End With
        Dim ListaPuntoPartida = New List(Of e_Combo)
        Dim oeDireccionEmpresa = New e_Combo
        oeDireccionEmpresa.Nombre = "DireccionEmpresa"
        oeDireccionEmpresa.Id = cboCliente.Value
        ListaPuntoPartida.AddRange(olDireccionEmpresa.Listar(oeDireccionEmpresa))

        'Tania
        If e.KeyCode = Keys.Enter Then
            If cboDireccionPartida.Text.Trim = "" Then
                cboDireccionPartida.DataSource = Nothing
                cboDireccionPartida.DataSource = ListaPuntoPartida
            Else
                cboDireccionPartida.DataSource = Nothing
                ListaPuntoPartida = New List(Of e_Combo)
                oeDireccionEmpresa = New e_Combo
                oeDireccionEmpresa.Nombre = "DireccionEmpresa"
                oeDireccionEmpresa.Id = cboCliente.Value
                ListaPuntoPartida.AddRange(olDireccionEmpresa.Listar(oeDireccionEmpresa))
                'LlenarComboMaestro(cboDireccionPartida, ListaPuntoPartida, 0)

                cboDireccionPartida.DataSource = ListaPuntoPartida.Where(Function(Item) Item.Nombre.Contains(cboDireccionPartida.Text.Trim)).ToList
            End If
        End If
    End Sub

    Private Sub cboDireccionPartida_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboDireccionPartida.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            cboDireccionPartida.PerformAction(UltraComboAction.Dropdown)
        End If
    End Sub

    Private Sub cboDireccionLLegada_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles cboDireccionLlegada.InitializeLayout
        With cboDireccionLlegada.DisplayLayout.Bands(0)
            .Columns("Id").Hidden = True
            .Columns("Nombre").Hidden = False
            .Columns("Nombre").Width = 500
            .Columns("Descripcion").Hidden = True
        End With
    End Sub

    Private Sub cboDireccionLLegada_KeyDown(sender As Object, e As KeyEventArgs) Handles cboDireccionLlegada.KeyDown
        With CType(sender, Infragistics.Win.UltraWinGrid.UltraCombo)
            If e.KeyData = Keys.Delete Then
                .Text = ""
            End If
        End With
        Dim ListaPuntoPartida = New List(Of e_Combo)
        Dim oeDireccionEmpresa = New e_Combo
        oeDireccionEmpresa.Nombre = "DireccionEmpresa"
        oeDireccionEmpresa.Id = cboCliente.Value
        ListaPuntoPartida.AddRange(olDireccionEmpresa.Listar(oeDireccionEmpresa))       
        If e.KeyCode = Keys.Enter Then
            If cboDireccionLlegada.Text.Trim = "" Then
                cboDireccionLlegada.DataSource = Nothing
                cboDireccionLlegada.DataSource = ListaPuntoPartida
            Else
                cboDireccionLlegada.DataSource = Nothing
                ListaPuntoPartida = New List(Of e_Combo)
                oeDireccionEmpresa = New e_Combo
                oeDireccionEmpresa.Nombre = "DireccionEmpresa"
                oeDireccionEmpresa.Id = cboCliente.Value
                ListaPuntoPartida.AddRange(olDireccionEmpresa.Listar(oeDireccionEmpresa))
                'LlenarComboMaestro(cboDireccionPartida, ListaPuntoPartida, 0)

                cboDireccionLlegada.DataSource = ListaPuntoPartida.Where(Function(Item) Item.Nombre.Contains(cboDireccionLlegada.Text.Trim)).ToList
            End If
        End If
    End Sub

    Private Sub cboDireccionLLegada_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboDireccionLlegada.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            cboDireccionLlegada.PerformAction(UltraComboAction.Dropdown)
        End If
    End Sub

    Private Sub cboTipoCarga_ValueChanged(sender As Object, e As EventArgs) Handles cboTipoCarga.ValueChanged
        If cboTipoCarga.Text.ToString = "VIAJE" Then
            txtCantidad.Text = Me.numNroUnidades.Value
        End If
    End Sub

    Private Sub CalFleteUnitario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CalFleteUnitario.KeyPress
        If Not String.IsNullOrEmpty(CalFleteUnitario.Value) AndAlso IsNumeric(CalFleteUnitario.Value.Trim.ToString) AndAlso CalFleteUnitario.Value >= 0.0 Then
            CalFleteUnitarioIGV.Value = (CDbl(CalFleteUnitario.Value) + CDbl(CalFleteUnitario.Value) * ValorIgv).ToString("###,##0.0000")
            FleteDetalle()
        Else
            CalFleteUnitario.Text = 0.0
        End If
    End Sub

    Private Sub CalFleteUnitarioIGV_Validated(sender As Object, e As EventArgs) Handles CalFleteUnitarioIGV.Validated
        If Not String.IsNullOrEmpty(CalFleteUnitarioIGV.Value) AndAlso IsNumeric(CalFleteUnitarioIGV.Value.Trim.ToString) AndAlso CalFleteUnitarioIGV.Value >= 0.0 Then
            CalFleteUnitario.Value = (CDbl(CalFleteUnitarioIGV.Value.Trim) / (1 + ValorIgv)).ToString("###,##0.0000")
            FleteDetalle()
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
                    If MessageBox.Show("No esta autorizado para quitar las validaciones" & Environment.NewLine &
                                        "Pedido Carga sin validaciones comuniquese con el " & gNombrePerfilJefeOperaciones & Environment.NewLine &
                                        "Desea seguir registrando Pedido Carga:  ?",
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
    
    Private Sub griDetalle_AfterRowsDeleted(sender As Object, e As EventArgs) Handles griDetalle.AfterRowsDeleted
        Try
            If Operacion = "Editar" Then
                ListaBitacora.Add(objEliminarDetalle)
            End If
        Catch ex As Exception
            Throw ex
        End Try

        CalcularTotalesDetalle()
    End Sub

    Private Sub griDetalle_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griDetalle.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        If MessageBox.Show(Me.Text & ": ¿Desea Eliminar el Registro?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then e.Cancel = True
        CalcularTotalesDetalle()
    End Sub

    Private Sub griDetalle_CellChange(sender As Object, e As CellEventArgs) Handles griDetalle.CellChange
        Try
            griDetalle.UpdateData()
            FleteDetalleGrilla()
            CalcularTotalesDetalle()
            Dim indice = griDetalle.ActiveRow.Cells("Cantidad").Value.ToString.LastIndexOf(".")
            Dim num
            With griDetalle.ActiveRow
                num = Math.Truncate(CDbl(.Cells("Cantidad").Value.ToString))
                If .Cells("TipoCarga").Value = "VIAJE" And num <> CDbl(.Cells("cantidad").Value.ToString) And .Cells("TipoCarga").IsActiveCell Then
                    .Cells("Cantidad").Value = 1
                    Throw New Exception("Tipo de carga VIAJE, debe ingresar valores enteros")
                End If
                If .Cells("Comisionista").Value.ToString.Contains("NINGUNO") And .Cells("Comisionista").IsActiveCell Then
                    .Cells("Comision").Value = 0
                End If
                If .Cells("PagoEfectivoDeposito") IsNot Nothing Then
                    If .Cells("PagoEfectivoDeposito").Value <> "" And .Cells("PagoContraEntrega").Value = False And .Cells("PagoEfectivoDeposito").IsActiveCell Then
                        .Cells("PagoEfectivoDeposito").Value = ""
                    End If
                End If

            End With
            ' Dim c = e.Cell.Column.Key

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub FleteDetalleGrilla()
        Try
            With oeDemandaDetalle
                With griDetalle.ActiveRow
                    If Not String.IsNullOrEmpty(.Cells("Cantidad").Value) Or Not IsNumeric(.Cells("Cantidad").Value.ToString) Then
                        oeDemandaDetalle.Cantidad = CDbl(.Cells("Cantidad").Value)
                    Else
                        .Cells("Cantidad").Value = 1
                        oeDemandaDetalle.Cantidad = CDbl(.Cells("Cantidad").Value)
                    End If
                    If Not String.IsNullOrEmpty(.Cells("FleteUnitario").Value) Or Not IsNumeric(.Cells("FleteUnitario").Value.ToString) Then
                        oeDemandaDetalle.FleteUnitario = CDbl(.Cells("FleteUnitario").Value)
                    Else
                        .Cells("FleteUnitario").Value = 0
                        oeDemandaDetalle.FleteUnitario = CDbl(.Cells("FleteUnitario").Value)
                    End If
                    oeIgv = olIgv.IGV(Date.Now)
                    oeDemandaDetalle.IGV = oeIgv.Porcentaje
                    If .Cells("IncluyeIgv").Value = False Then
                        .Cells("Flete").Value = oeDemandaDetalle.FleteCalcularSinIgv
                    Else
                        .Cells("Flete").Value = oeDemandaDetalle.FleteCalcularIgv
                    End If
                    .Cells("Subtotal").Value = oeDemandaDetalle.FleteCalcularSinIgv
                End With
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub griDetalle_KeyDown(sender As Object, e As KeyEventArgs) Handles griDetalle.KeyDown
        Try
            If e.KeyValue = 13 Then
                With griDetalle
                    Select Case .ActiveRow.Cells(.ActiveCell.Column.Index).Column.Key
                        Case "Cliente"
                            .PerformAction(UltraGridAction.NextCellByTab)
                        Case "TipoCarga"
                            .PerformAction(UltraGridAction.NextCellByTab)
                        Case "Cantidad"
                            FleteDetalleGrilla()
                            With griDetalle.Rows(.ActiveRow.Index)
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
                            With griDetalle.Rows(.ActiveRow.Index)
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
                            With griDetalle.Rows(.ActiveRow.Index)
                                If .Cells("FleteUnitario").Value.ToString.Length = 0 Then
                                    .Cells("FleteUnitario").Value = 0.0
                                    Throw New Exception("Ingrese Flete Unitario")
                                End If
                            End With
                            .PerformAction(UltraGridAction.NextCellByTab)
                        Case "Facturado"
                            With griDetalle.Rows(.ActiveRow.Index)
                                If .Cells("Facturado").Value = False Then
                                    .Cells("Facturado").Value = True
                                Else
                                    .Cells("Facturado").Value = False
                                End If
                            End With
                            '.PerformAction(UltraGridAction.NextCellByTab)
                        Case "PagoContraEntrega"
                            With griDetalle.Rows(.ActiveRow.Index)
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
                            With griDetalle.Rows(.ActiveRow.Index)
                                If .Cells("Comision").Value.ToString.Length = 0 Then Throw New Exception("Ingrese Comision")
                            End With
                            .PerformAction(UltraGridAction.NextCellByTab)
                            If griDetalle.ActiveRow.Cells("Comisionista").Text.ToString.Contains("NINGUNO") And griDetalle.ActiveRow.Cells("Comision").Value > 0 Then
                                '    .Cells("Cantidad").Value.  string(indice, .Cells("Cantidad").Value.ToString.Length).Contains("000") = False Then
                                griDetalle.ActiveRow.Cells("Comision").Value = 0
                                Throw New Exception("No ha seleccionado comisionista")
                                '    txtCantidad.Focus()
                            End If
                        Case "Comisionista"
                            With griDetalle.Rows(.ActiveRow.Index)
                                If .Cells("Comisionista").Text.ToString.Contains("NINGUNO") Then
                                    griDetalle.ActiveRow.Cells("Comision").Value = 0
                                End If
                            End With
                    End Select
                End With
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griDetalleTercero_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griDetalleTercero.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        If MessageBox.Show(Me.Text & ": ¿Desea Eliminar el Registro?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then e.Cancel = True
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

    Private Sub CalFleteUnitarioIGV_ValueChanged(sender As Object, e As EventArgs) Handles CalFleteUnitarioIGV.ValueChanged
        If Not String.IsNullOrEmpty(CalFleteUnitarioIGV.Value) AndAlso IsNumeric(CalFleteUnitarioIGV.Value.Trim.ToString) AndAlso CalFleteUnitarioIGV.Value >= 0.0 Then
            If CalFleteUnitarioIGV.Focused Then
                CalFleteUnitario.Value = (CDbl(CalFleteUnitarioIGV.Value.Trim) / (1 + ValorIgv)).ToString("###,##0.0000")
                FleteDetalle()
            End If
        Else
            CalFleteUnitarioIGV.Text = 0.0
        End If
        '   If Operacion = "Nuevo" Or Operacion = "Editar" Then CalFleteUnitarioIGV.Text = CalFleteUnitarioIGV.Text
    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Update.Click
        Editar()    
    End Sub

    Private Sub Insert_Click(sender As Object, e As EventArgs) Handles Insert.Click
        Nuevo()
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        Try
            If griLista.ActiveRow.Cells("Estado").Value.ToString.Trim = "GENERADA" Then
                mostrarMotivoCancelacion("E")
            Else
                mensajeEmergente.Confirmacion("Solo se pueden ELIMINAR Pedido Carga GENERADAS", True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    'Private Sub dtSolicita_ValueChanged(sender As Object, e As EventArgs) Handles dtSolicita.ValueChanged
    'Try
    '    If (Operacion = "Nuevo" Or Operacion = "Editar") And dtSolicita.Value <= FechaServidor.AddDays(-7) Then
    '        dtSolicita.Value = FechaServidor.Date
    '        Throw New Exception("La fecha solicitada no puede ser menor a 7 días")
    '    End If
    'Catch ex As Exception
    '    mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
    '    dtSolicita.CloseUp()
    'End Try
    ' End Sub

    Private Sub dtSolicita_ValidatedChanged(sender As Object, e As EventArgs) Handles dtSolicita.Validated
        Try
            If (Operacion = "Nuevo" Or Operacion = "Editar") And dtSolicita.Value <= FechaServidor.AddDays(-7) Then
                dtSolicita.Value = FechaServidor.Date
                Throw New Exception("La fecha solicitada no puede ser menor a 7 días")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
            dtSolicita.CloseUp()
        End Try
    End Sub

    Private Sub chkEscala_KeyDown(sender As Object, e As KeyEventArgs) Handles chkEscala.KeyDown
        chkEscala.Checked = IIf(chkEscala.Checked = False, True, False)
    End Sub

    Private Sub verCargar_KeyDown(sender As Object, e As KeyEventArgs) Handles verCargar.KeyDown
        verCargar.Checked = IIf(verCargar.Checked = False, True, False)
    End Sub

    Private Sub verDescarga_KeyDown(sender As Object, e As KeyEventArgs) Handles verDescarga.KeyDown
        verDescarga.Checked = IIf(verDescarga.Checked = False, True, False)
    End Sub

    Private Sub chkCostoEstiva_KeyDown(sender As Object, e As KeyEventArgs) Handles chkCostoEstiva.KeyDown
        chkCostoEstiva.Checked = IIf(chkCostoEstiva.Checked = False, True, False)
    End Sub

    Private Sub chkConsolidado_KeyDown(sender As Object, e As KeyEventArgs) Handles chkConsolidado.KeyDown
        chkConsolidado.Checked = IIf(chkConsolidado.Checked = False, True, False)
    End Sub

    Private Sub txtAdelantoFlete_ValueChanged(sender As Object, e As EventArgs) Handles txtAdelantoFlete.ValueChanged
        Try
            If Not String.IsNullOrEmpty(txtAdelantoFlete.Value) AndAlso IsNumeric(txtAdelantoFlete.Value) AndAlso txtAdelantoFlete.Value > 0 Then
                If txtAdelantoFlete.Value > txtFleteTotalDetalle.Value Then
                    txtAdelantoFlete.Value = 0.0
                    mensajeEmergente.Confirmacion("Adelanto de flete no puede ser mayor al flete total", True)
                End If
            Else
                txtAdelantoFlete.Value = 0.0
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CancelarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelarDemanda.Click
        If griLista.ActiveRow.Cells("Estado").Value.ToString.Trim = "GENERADA" Or griLista.ActiveRow.Cells("Estado").Value.ToString.Trim = "ASIGNADA" Then
            mostrarMotivoCancelacion("C")
        Else
            mensajeEmergente.Confirmacion("Solo se pueden CANCELAR - Pedido Carga - GENERADAS", True)
        End If
    End Sub

    Private Sub chkCostoEstivaDescarga_CheckedChanged(sender As Object, e As EventArgs) Handles chkCostoEstivaDescarga.CheckedChanged
        If Me.chkCostoEstivaDescarga.Checked Then
            Me.txtCostoEstibaDescarga.Enabled = True
            Me.txtGlosaCostoEstibaDesc.Visible = True
            If Me.griTarifasProveedor.Visible = False Then
                Me.griTarifasProveedor.Visible = True
                oeTarifaProveedor = New e_TarifasProveedor
                oeTarifaProveedor.IdLugar = Me.cboDestinoDetalle.Value
                oeTarifaProveedor.IdMaterial = Me.cboMaterial.Value
                Me.griTarifasProveedor.DataSource = olTarifasProveedor.ListarTarifasProveedor(oeTarifaProveedor)
            End If
        Else
            Me.txtCostoEstibaDescarga.Enabled = False
            Me.txtCostoEstibaDescarga.Value = 0
            If Me.chkCostoEstiva.Checked = False Then
                Me.txtGlosaCostoEstibaDesc.Text = ""
                Me.txtGlosaCostoEstibaDesc.Visible = False
                Me.griTarifasProveedor.Visible = False
            End If
        End If
    End Sub

    Private Sub chkCostoEstivaDescarga_KeyDown(sender As Object, e As KeyEventArgs) Handles chkCostoEstivaDescarga.KeyDown
        chkCostoEstivaDescarga.Checked = IIf(chkCostoEstivaDescarga.Checked = False, True, False)
    End Sub

    Private Sub EnviarCorreoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnviarCorreoToolStripMenuItem.Click
        Try
            If griLista.ActiveRow IsNot Nothing Then
                Dim formulario As frm_EnvioEmail
                formulario = New frm_EnvioEmail
                formulario.Modulo = "DemandaRapida"
                formulario.bandFrmExterno = "DE"
                oeDemanda = New e_Demanda
                If formulario.bandDemandaEnviada = "" Then
                    oeDemanda.Id = griLista.ActiveRow.Cells("IdDemanda").Value.ToString
                End If
                oeDemanda.UsuarioCreacion = gUsuarioSGI.Id
                formulario.cadenaMensajeHtml = getFormatoDemanda(griLista.ActiveRow.Cells("IdDemanda").Value.ToString)
                formulario.ShowDialog()
                If formulario.bandDemandaEnviada <> "" Then
                    GuardarDemandasEnviadas()
                End If
            Else
                mensajeEmergente.Confirmacion("Debe Seleccionar un Pedido Carga", True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Sub GuardarDemandasEnviadas()
        Try
            oeDemanda.PrefijoID = gs_PrefijoIdSucursal '@0001
            olDemanda.GuardarDemandasEnviadas(oeDemanda)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cboContacto_EditorButtonClick(sender As Object, e As EditorButtonEventArgs) Handles cboContacto.EditorButtonClick
        Try
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
        Catch ex As Exception
            Throw ex
        End Try        
    End Sub

    Private Sub cboCliente_ValueChanged(sender As Object, e As EventArgs) Handles cboCliente.ValueChanged
        If Me.cboCliente.Value <> "" Then
            Me.cboClienteFinal.Value = Me.cboCliente.Value
        End If
    End Sub

    Private Sub EstadoAsignada_Click(sender As Object, e As EventArgs) Handles EstadoAsignada.Click
        If griLista.Selected.Rows.Count > 0 Then
            If griLista.ActiveRow.Cells("Estado").Value.ToString.Trim = "PARCIAL" Then
                mostrarMotivoCancelacion("A")
            Else
                mensajeEmergente.Confirmacion("Solo se pueden cambiar a ASIGNADA, los Pedido Carga de estado PARCIAL", True)
            End If
        End If
    End Sub

    Private Sub ProgramarViaje_Click(sender As Object, e As EventArgs) Handles ProgramarViaje.Click
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            If griLista.ActiveRow.Cells("Estado").Value <> "ASIGNADA" Then
                If griLista.ActiveRow.Cells("Estado").Value = "CANCELADA" Then Throw New Exception(Me.Text & ": El Registro se encuentra CANCELADO")
                Dim Operacion As frm_Operacion = frm_Operacion.getInstancia
                '   Dim Operacion As New frm_Operacion
                ' Operacion = Operacion.getInstancia()
                Operacion.MdiParent = frm_Menu
                Operacion.Show()
                Operacion.ProgramarViaje(griLista.ActiveRow.Cells("IdDemanda").Value, griLista.ActiveRow.Cells("TipoVehiculo").Value,
                                         griLista.ActiveRow.Cells("IdEscala").Value, griLista.ActiveRow.Cells("MotivoEscala").Value,
                                         griLista.ActiveRow.Cells("FechaAtendida").Value, griLista.ActiveRow.Cells("Codigo").Value)

            Else
                Throw New Exception(Me.Text & ": Pedido Carga se encuentra ASIGNADA a una operacion")
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

    Private Sub verPagoContraEntrega_CheckedChanged(sender As Object, e As EventArgs) Handles verPagoContraEntrega.CheckedChanged
        If verPagoContraEntrega.Checked Then
            opPagoCont.Enabled = True
        Else
            opPagoCont.Enabled = False
        End If
    End Sub

    Private Sub griDetalle_AfterRowUpdate(sender As Object, e As RowEventArgs) Handles griDetalle.AfterRowUpdate
        If e.Row.Cells("PagoContraEntrega").Value = False And e.Row.Cells("PagoContraEntrega").IsActiveCell Then
            e.Row.Cells("PagoEfectivoDeposito").Value = ""
        Else
            If e.Row.Cells("PagoContraEntrega").IsActiveCell Then
                griDetalle.ActiveRow.Cells("PagoEfectivoDeposito").Value = "E"
            End If
        End If
        If e.Row.Cells("PagoEfectivoDeposito").IsActiveCell And e.Row.Cells("PagoContraEntrega").Value = False Then
            e.Row.Cells("PagoEfectivoDeposito").Value = ""
        End If
    End Sub

    Private Sub mnuEliminar_Click(sender As Object, e As EventArgs) Handles mnuEliminar.Click
        If griDetalle.Rows.Count > 0 Then griDetalle.ActiveRow.Delete()
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

    Private Sub cboTercero_EditorButtonClick(sender As Object, e As EditorButtonEventArgs) Handles cboTercero.EditorButtonClick
        ugb_Espera.Visible = True
        Application.DoEvents()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        ' If e.Button.Key = "btnEditarCliente" Then
        If Me.cboTercero.Value <> "" Then
            codigoTerceroBand = cboTercero.Value
            Dim IdEmpresa As String
            TipoCliente = 2
            oeCliente = New e_Cliente
            oeCliente.Id = cboTercero.Value
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
            '  Empresa.NuevoCliente()
        End If
        ugb_Espera.Visible = False
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

    Private Sub cboMaterial_ValueChanged(sender As Object, e As EventArgs) Handles cboMaterial.ValueChanged
        If Me.cboMaterial.Value <> "" Then
            If Me.chkCostoEstiva.Checked Or Me.chkCostoEstivaDescarga.Checked Then
                Me.griTarifasProveedor.Visible = True
                oeTarifaProveedor = New e_TarifasProveedor
                oeTarifaProveedor.IdLugar = Me.cboDestinoDetalle.Value
                oeTarifaProveedor.IdMaterial = Me.cboMaterial.Value
                Me.griTarifasProveedor.DataSource = olTarifasProveedor.ListarTarifasProveedor(oeTarifaProveedor)
            End If
        End If
    End Sub

    Private Sub cboDestinoDetalle_ValueChanged(sender As Object, e As EventArgs) Handles cboDestinoDetalle.ValueChanged
        If Me.cboDestinoDetalle.Value <> "" Then
            If Me.chkCostoEstiva.Checked Or Me.chkCostoEstivaDescarga.Checked Then
                Me.griTarifasProveedor.Visible = True
                oeTarifaProveedor = New e_TarifasProveedor
                oeTarifaProveedor.IdLugar = Me.cboDestinoDetalle.Value
                oeTarifaProveedor.IdMaterial = Me.cboMaterial.Value
                Me.griTarifasProveedor.DataSource = olTarifasProveedor.ListarTarifasProveedor(oeTarifaProveedor)
            End If
        End If
    End Sub

    Private Sub chkTercerizacion_CheckedChanged(sender As Object, e As EventArgs) Handles chkTercerizacion.CheckedChanged
        If Me.chkTercerizacion.Checked Then
            tabs.Tabs(1).Enabled = True
            tabs.SelectedTab = tabs.Tabs(1)
            indicadorTercero = True
            numCantidadTercero.Value = IIf(oeDemanda.oeDetalleDemanda.Sum(Function(item) item.Cantidad) = 0, 1, oeDemanda.oeDetalleDemanda.Sum(Function(item) item.Cantidad))
        Else
            tabs.Tabs(1).Enabled = False
            tabs.SelectedTab = tabs.Tabs(0)
            griDetalleTercero.DataSource = New List(Of e_ViajesTerceros)
            indicadorTercero = False
            LimpiarTercero()
        End If
    End Sub

    Private Sub LimpiarTercero()
        Me.cboTercero.SelectedIndex = -1
        Me.cboContacto.SelectedIndex = -1
        Me.txtApellidoPaternoContacto.Text = ""
        Me.txtApellidoMaternoContacto.Text = ""
        Me.txtNombreContacto.Text = ""
        Me.txtTelefonoContacto.Text = ""
        Me.txtRucContacto.Text = ""
        Me.txtReferenciaTercero.Text = ""
        Me.numComisionTerc.Value = 0
        Me.numCantidadTercero.Value = 1
        Me.numFleteUnitarioTerc.Value = 0
        Me.numSubTotalTercero.Value = 0
        Me.numIgvTerc.Value = 0
        Me.numFleteTotalTerc.Value = 0
        Me.txtObservacionTercero.Text = ""
        Me.txtRucEmpresaTransportista.Text = ""
    End Sub

    Private Sub griDetalleTercero_CellChange(sender As Object, e As CellEventArgs) Handles griDetalleTercero.CellChange
        griDetalleTercero.UpdateData()
        FleteDetalleGrillaTercero()
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

    Private Sub griDetalle_AfterCellUpdate(sender As Object, e As CellEventArgs) Handles griDetalle.AfterCellUpdate
        If Operacion = "Editar" And griDetalle.Rows(e.Cell.Row.Index).Cells("Id").Value <> "" Then

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
                ListaBitacora.Add(New e_Bitacora(codigo, griDetalle.Rows(e.Cell.Row.Index).Cells("Id").Value, "OPE.Demanda", "OPE.DemandaDetalle",
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

    Private Sub griDetalle_Click(sender As Object, e As EventArgs) Handles griDetalle.Click
        If griDetalle.ActiveRow IsNot Nothing Then
            If griDetalle.ActiveRow.Cells("IdDemanda").Value <> "" Then
                objEliminarDetalle = New e_Bitacora(griDetalle.ActiveRow.Cells("IdDemanda").Value.ToString,
                                                             griDetalle.ActiveRow.Cells("Id").Value, "OPE.Demanda", "OPE.DemandaDetalle",
                                               Me.Text, New List(Of String), gUsuarioSGI.Id, "I",
                                               New List(Of String), New List(Of String), "E", "D", False)
            End If
        End If
    End Sub

    Private Sub griDetalle_ClickCell(sender As Object, e As ClickCellEventArgs) Handles griDetalle.ClickCell
        columnas.Clear()
        For i As Integer = 0 To griDetalle.Rows(e.Cell.Row.Index).Cells.Count - 1
            columnas.Add(griDetalle.Rows(e.Cell.Row.Index).Cells(i).Text)
        Next
        count = getIdArrayBidimensional()
        rowGeneral(count, 0) = e.Cell.Row.Index
        rowGeneral(count, 1) = -1
    End Sub

    Private Sub griDetalleTercero_AfterRowsDeleted(sender As Object, e As EventArgs) Handles griDetalleTercero.AfterRowsDeleted
        Try
            If Operacion = "Editar" Then
                ListaBitacora.Add(objEliminarTercero)
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

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

    Public Sub FiltrarLista()
        Dim listaAuxiliar As New List(Of e_Bitacora)
        For Each obj As e_Bitacora In ListaBitacora
            Dim objAuxiliar As New e_Bitacora
            objAuxiliar.ValoresActuales = New List(Of String)
            objAuxiliar.ValoresAnteriores = New List(Of String)
            objAuxiliar.ColumnasAfectadas = New List(Of String)
            If obj IsNot Nothing Then
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
                    End If
                Next

                If objAuxiliar.ValoresAnteriores.Count > 0 Then
                    listaAuxiliar.Add(objAuxiliar)
                End If
            End If
        Next
        ListaBitacora = listaAuxiliar
    End Sub

    Private Sub dtFechaRecepcion_ValidatedChanged(sender As Object, e As EventArgs) Handles dtFechaRecepcion.Validated
        Try
            If (Operacion = "Nuevo" Or Operacion = "Editar") And dtFechaAtencion.Value > Me.dtFechaRecepcion.Value And dtFechaRecepcion.Focused Then
                dtFechaRecepcion.Focus()
                dtFechaRecepcion.Value = dtFechaAtencion.Value
                Throw New Exception("Fecha de Recepción no puede ser menor a la Fecha de Atención")
            Else
                If (Operacion = "Nuevo" Or Operacion = "Editar") And Me.dtFechaRecepcion.Value > Me.dtFechaAtencion.Value.AddMonths(1) And dtFechaRecepcion.Focused Then
                    dtFechaRecepcion.Focus()
                    dtFechaRecepcion.Value = dtFechaAtencion.Value
                    Throw New Exception("Fecha de Recepción no puede ser mayor a UN MES de la FECHA DE ATENCION")
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
            dtFechaRecepcion.CloseUp()
        End Try
    End Sub

    Private Sub cboMaterial_Validated(sender As Object, e As EventArgs) Handles cboMaterial.Validated
        If Operacion = "Nuevo" Or Operacion = "Editar" Then
            ObtenerFleteUnitario()
        End If
    End Sub

    Private Sub mnuDuplicar_Click(sender As Object, e As EventArgs) Handles mnuDuplicar.Click
        DuplicarRegistroDetalleDemanda()
    End Sub

    Private Sub DuplicarRegistroDetalleDemanda()
        If griDetalle.Rows.Count > 0 Then
            oeDemanda.oeDetalleDemanda = griDetalle.DataSource
            With griDetalle.ActiveRow
                oeDemandaDetalle = New e_DemandaDetalle
                oeDemandaDetalle.Id = ""
                oeDemandaDetalle.IdDemanda = .Cells("IdDemanda").Value
                oeDemandaDetalle.IdCliente = .Cells("IdCliente").Value
                oeDemandaDetalle.Cliente = .Cells("Cliente").Value
                oeDemandaDetalle.Comisionista = .Cells("Comisionista").Value
                oeDemandaDetalle.IdTipoCarga = .Cells("IdTipoCarga").Value
                oeDemandaDetalle.TipoCarga = .Cells("TipoCarga").Value
                oeDemandaDetalle.Material = .Cells("Material").Value
                oeDemandaDetalle.IdMaterial = .Cells("IdMaterial").Value
                oeDemandaDetalle.Moneda = .Cells("Moneda").Value
                oeDemandaDetalle.Cantidad = .Cells("Cantidad").Value
                oeDemandaDetalle.FleteUnitario = .Cells("FleteUnitario").Value
                oeDemandaDetalle.Flete = .Cells("Flete").Value
                oeDemandaDetalle.Comision = .Cells("Comision").Value
                oeDemandaDetalle.Facturado = .Cells("Facturado").Value
                oeDemandaDetalle.IncluyeIgv = .Cells("IncluyeIgv").Value
                oeDemandaDetalle.PagoContraEntrega = .Cells("PagoContraEntrega").Value
                oeDemandaDetalle.Cargar = .Cells("Cargar").Value
                oeDemandaDetalle.Descarga = .Cells("Descarga").Value
                oeDemandaDetalle.IdOrigen = .Cells("IdOrigen").Value
                oeDemandaDetalle.IdDestino = .Cells("IdDestino").Value
                oeDemandaDetalle.DireccionOrigen = .Cells("DireccionOrigen").Value
                oeDemandaDetalle.DireccionDestino = .Cells("DireccionDestino").Value
                oeDemandaDetalle.IdClienteFinal = .Cells("IdClienteFinal").Value
                oeDemandaDetalle.Indicador = .Cells("Indicador").Value
                oeDemandaDetalle.IdDireccionLugarPartida = .Cells("IdDireccionLugarPartida").Value
                oeDemandaDetalle.IdDireccionLugarLlegada = .Cells("IdDireccionLugarLlegada").Value
                oeDemandaDetalle.DireccionLugarPartida = .Cells("DireccionLugarPartida").Value
                oeDemandaDetalle.DireccionLugarLlegada = .Cells("DireccionLugarLlegada").Value
                oeDemandaDetalle.Consolidado = .Cells("Consolidado").Value
                oeDemandaDetalle.MotivoConsolidado = .Cells("MotivoConsolidado").Value
                oeDemandaDetalle.CostoEstiba = .Cells("CostoEstiba").Value
                oeDemandaDetalle.IncluyeIGVConsolidado = .Cells("IncluyeIgvConsolidado").Value
                oeDemandaDetalle.Subtotal = .Cells("Subtotal").Value
                oeDemandaDetalle.IGV = .Cells("Igv").Value
                oeDemandaDetalle.AdelantoFlete = .Cells("AdelantoFlete").Value
                oeDemandaDetalle.CostoEstibaDescarga = .Cells("CostoEstibaDescarga").Value
                oeDemandaDetalle.GlosaCostoEstiba = .Cells("GlosaCostoEstiba").Value
                oeDemandaDetalle.Usuario = gUsuarioSGI.Id
                oeDemandaDetalle.PagoEfectivoDeposito = .Cells("PagoEfectivoDeposito").Value
                'CostoEstibaDescarga

                oeDemanda.oeDetalleDemanda.Add(oeDemandaDetalle)
                griDetalle.DataBind()
                oeDemandaDetalle = New e_DemandaDetalle
            End With
        End If
    End Sub

    Private Sub txtComision_TextChanged(sender As Object, e As EventArgs) Handles txtComision.TextChanged
        Try
            If String.IsNullOrEmpty(txtComision.Text) Or Not IsNumeric(txtComision.Text.Trim.ToString) Then txtComision.Text = 0.0
            If oeTarifa.Id <> "" Then
                If oeTarifa.AceptaComision = False Then
                    If txtComision.Value > 0 And indIngresaComsion = "" Then
                        If MessageBox.Show("El tipo de flete elegido NO ACEPTA COMISION.Consulte tarifario. ¿Desea agregarlo de todas maneras?", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
                            txtComision.Value = 0
                        Else
                            indIngresaComsion = "S"
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub CalFleteUnitario_Click(sender As Object, e As EventArgs) Handles CalFleteUnitario.Click
        CalFleteUnitario.SelectAll()
    End Sub

    Private Sub Menu_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Menu.Opening
        OcultarItemsMenu()
    End Sub

    Private Sub OcultarItemsMenu()
        If (gUsuarioSGI.leARUsuario.Where(Function(item) item.IdActividadNegocio = gActividadNegocio.Demanda.ToString And
                                                 item.AccionSistema = gAccionSistema.ELIMINAR.ToString And item.IdProcesoNegocio = pProcesoNegocio)).ToList.Count = 0 Then
            Menu.Items.RemoveByKey("Delete")
        End If
        If (gUsuarioSGI.leARUsuario.Where(Function(item) item.IdActividadNegocio = gActividadNegocio.Demanda.ToString And
                                                  item.AccionSistema = gAccionSistema.CANCELAR.ToString And item.IdProcesoNegocio = pProcesoNegocio)).ToList.Count = 0 Then
            Menu.Items.RemoveByKey("CancelarDemanda")
        End If
        If (gUsuarioSGI.leARUsuario.Where(Function(item) item.IdActividadNegocio = gActividadNegocio.Demanda.ToString And
                                                  item.AccionSistema = gAccionSistema.NUEVO.ToString And item.IdProcesoNegocio = pProcesoNegocio)).ToList.Count = 0 Then
            Menu.Items.RemoveByKey("Insert")
        End If
        If (gUsuarioSGI.leARUsuario.Where(Function(item) item.IdActividadNegocio = gActividadNegocio.Demanda.ToString And
                                                  item.AccionSistema = gAccionSistema.EDITAR.ToString And item.IdProcesoNegocio = pProcesoNegocio)).ToList.Count = 0 Then
            Menu.Items.RemoveByKey("Update")
        End If
        If (gUsuarioSGI.leARUsuario.Where(Function(item) item.IdActividadNegocio = gActividadNegocio.EstadoAsignada.ToString And
                                                  item.AccionSistema = gAccionSistema.EDITAR.ToString And item.IdProcesoNegocio = pProcesoNegocio)).ToList.Count = 0 Then
            Menu.Items.RemoveByKey("EstadoAsignada")
        End If
    End Sub

    Private Sub ControlBotoneraPorActividad(ByVal tipo As String)
        Select Case tipo
            Case "Activated"
                If Operacion <> "Nuevo" And Operacion <> "Editar" Then
                    ControlBoton(1, gUsuarioSGI.leARUsuario.Where(Function(item) item.IdActividadNegocio = gActividadNegocio.Demanda.ToString And
                                                                      item.AccionSistema = gAccionSistema.NUEVO.ToString And item.IdProcesoNegocio = pProcesoNegocio).ToList.Count,
                                                                0, 0, 0, 0, 0, 1, 1)
                End If
            Case "Consultar"
                ControlBoton(1, gUsuarioSGI.leARUsuario.Where(Function(item) item.IdActividadNegocio = gActividadNegocio.Demanda.ToString And
                                                  item.AccionSistema = gAccionSistema.NUEVO.ToString And item.IdProcesoNegocio = pProcesoNegocio).ToList.Count,
                                            gUsuarioSGI.leARUsuario.Where(Function(item) item.IdActividadNegocio = gActividadNegocio.Demanda.ToString And
                                                  item.AccionSistema = gAccionSistema.EDITAR.ToString And item.IdProcesoNegocio = pProcesoNegocio).ToList.Count, 0, 0, 0, 0, 1, 1)
        End Select


    End Sub

    Private Sub cboEscala_Validated(sender As Object, e As EventArgs) Handles cboEscala.Validated
        Try
            If Me.cboEscala.Text = "TEMBLADERA (CAJAMARCA)" And Me.cboOrigen.Text = "PACASMAYO (LA LIBERTAD)" Then
                Me.cboOrigenDetalle.Value = Me.cboEscala.Value
                cboDestinoDetalle_Validated(Nothing, Nothing)
            End If
            Me.txtMotivoEscala.Value = "Carga desde escala"
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub RevertirDemandaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RevertirDemandaToolStripMenuItem.Click
        Try
            Dim eDemanda As New e_Demanda()
            If griLista.ActiveRow.Cells("Estado").Value.ToString = "APROBADA" Then
                eDemanda.Id = griLista.ActiveRow.Cells("IdDemanda").Value.ToString
                If olDemanda.RevertirDemanda(eDemanda) Then
                    mensajeEmergente.Confirmacion("Pedido Carga revertida", True)
                    listarNuevo()
                End If
            Else
                mensajeEmergente.Confirmacion("Pedido Carga no puede revertirse", True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub EditarDetalleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarDetalleToolStripMenuItem.Click
        Try
            Dim detalleDemanda As e_DemandaDetalle
            Dim lista As List(Of e_DemandaDetalle)
            If griDetalle.ActiveRow.Cells("Id").Value <> "" Then
                lista = griDetalle.DataSource
                detalleDemanda = lista.Item(griDetalle.ActiveRow.Index)
                With detalleDemanda
                    Me.cboCliente.Value = .IdCliente
                    Me.cboCliente_Validated(Nothing, Nothing)
                    Me.cboContactoCarga.Value = .IdContactoCarga.Trim
                    Me.cboContactoDescarga.Value = .IdContactoDescarga.Trim
                    Me.cboOrigenDetalle.Value = .IdOrigen
                    Me.cboDestinoDetalle.Value = .IdDestino
                    Me.txtRucCLiente.Value = ClientesPublic.Where(Function(item) item.Id = .IdCliente).ToList.Item(0).Descripcion
                    Me.cboDireccionPartida.Value = .IdDireccionLugarPartida
                    Me.cboDireccionLlegada.Value = .IdDireccionLugarLlegada
                    Me.cboClienteFinal.Value = .IdClienteFinal
                    Me.txtRucCLienteFinal.Value = ClientesPublic.Where(Function(item) item.Id = .IdClienteFinal).ToList.Item(0).Descripcion
                    Me.cboComisionista.Value = .Comisionista
                    Me.txtRucComisionista.Value = ComisionistasPublic.Where(Function(item) item.Id = .Comisionista).ToList.Item(0).Descripcion
                    Me.cboTipoCarga.Value = .IdTipoCarga
                    Me.txtCantidad.Value = .Cantidad
                    Me.cboMaterial.Value = .IdMaterial
                    Me.CalFleteUnitario.Value = .FleteUnitario
                    Me.CalFleteUnitarioIGV.Value = .FleteUnitario * (1 + ValorIgv)
                    Me.txtSubtotal.Value = .Subtotal
                    Me.txtFleteTotalDetalle.Value = .Flete
                    Me.cboMoneda.Value = .Moneda
                    Me.txtAdelantoFlete.Value = .AdelantoFlete
                    Me.txtComision.Value = .Comision
                    Me.verIncluyeIgv.Checked = .IncluyeIgv
                    Me.verFacturado.Checked = .Facturado
                    Me.chkIndFalsoFlete.Checked = .FalsoFlete
                    Me.verCargar.Checked = .Cargar
                    Me.verDescarga.Checked = .Descarga
                    Me.verPagoContraEntrega.Checked = .PagoContraEntrega
                    Me.chkConsolidado.Checked = IIf(.Consolidado > 0, True, False)
                    Me.txtComision.Value = .Consolidado
                    Me.chkIGVConsolidado.Checked = .IncluyeIGVConsolidado
                    Me.txtMotivoConsolidado.Value = .MotivoConsolidado
                    Me.chkCostoEstiva.Checked = IIf(.CostoEstiba > 0, True, False)
                    Me.txtCostoEstiba.Value = .CostoEstiba
                    Me.txtCostoEstibaDescarga.Value = .CostoEstibaDescarga
                    Me.chkCostoEstiva.Checked = IIf(.CostoEstiba > 0, True, False)
                    Me.chkCostoEstivaDescarga.Checked = IIf(.CostoEstibaDescarga > 0, True, False)
                    Me.txtGlosaCostoEstibaDesc.Value = .GlosaCostoEstiba
                    Me.idDemandaDetalle = .Id
                End With
                Dim extras = ComisionistasPublic.Where(Function(item) item.Id = detalleDemanda.Comisionista).ToList.Item(0).Extras
                If extras.Count > 0 Then
                    Me.txtApellidoPaternoComisionista.Text = extras.Item(0).ToString
                    Me.txtApellidoMaterno.Text = extras.Item(1).ToString
                    Me.txtNombreComisonista.Text = extras.Item(2).ToString
                    Me.txtTelefonoComisionista.Text = extras.Item(3).ToString
                    '   codigoComisionista = extras.Item(4).ToString
                End If

                If verPagoContraEntrega.Checked Then
                    Select Case oeDemandaDetalle.PagoEfectivoDeposito
                        Case "O"
                            opPagoCont.CheckedIndex = 2
                        Case "E"
                            opPagoCont.CheckedIndex = 0
                        Case "D"
                            opPagoCont.CheckedIndex = 1
                    End Select
                End If
                exgruDetalle.Expanded = True
                exgruFlete.Expanded = True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub NuevoDetalleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoDetalleToolStripMenuItem.Click
        Try
            limpiarDetalleDemanda()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cboContactoCarga_ValueChanged(sender As Object, e As EventArgs) Handles cboContactoCarga.ValueChanged
        Try

            If Me.cboContactoCarga.Value <> "" Then
                Dim lista As List(Of e_Combo) = Me.cboContactoCarga.DataSource
                If lista IsNot Nothing Then
                    If cboContactoCarga.SelectedIndex >= 0 Then
                        Dim extras = lista.Item(cboContactoCarga.SelectedIndex).Extras
                        If extras.Count > 0 Then
                            Me.txtTelfCarga.Text = extras.Item(3).ToString
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cboContactoDescarga_ValueChanged(sender As Object, e As EventArgs) Handles cboContactoDescarga.ValueChanged
        Try
            If Me.cboContactoDescarga.Value <> "" Then
                Dim lista As List(Of e_Combo) = Me.cboContactoDescarga.DataSource
                If lista IsNot Nothing Then
                    If cboContactoDescarga.SelectedIndex >= 0 Then
                        Dim extras = lista.Item(cboContactoDescarga.SelectedIndex).Extras
                        If extras.Count > 0 Then
                            Me.txtTelfDescarga.Text = extras.Item(3).ToString
                        End If
                    End If
                End If
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cboContactoCarga_EditorButtonClick(sender As Object, e As EditorButtonEventArgs) Handles cboContactoCarga.EditorButtonClick
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            ' If e.Button.Key = "btnEditarCliente" Then
            If Me.cboCliente.Value <> "" Then
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
                Empresa.ficDetalle.SelectedTab = Empresa.ficDetalle.Tabs(5)
                Empresa.Show()
                Empresa.AgregarDireccion(IdEmpresa)
                codigoContactoCarga = "0"
            End If
            ugb_Espera.Visible = False
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cboContactoDescarga_EditorButtonClick(sender As Object, e As EditorButtonEventArgs) Handles cboContactoDescarga.EditorButtonClick
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            ' If e.Button.Key = "btnEditarCliente" Then
            If Me.cboCliente.Value <> "" Then
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
                Empresa.ficDetalle.SelectedTab = Empresa.ficDetalle.Tabs(5)
                Empresa.Show()
                Empresa.AgregarDireccion(IdEmpresa)
                codigoContactoDescarga = "0"
            End If
            ugb_Espera.Visible = False
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CombosContactoDetalle()
        Try
            Dim j As Integer = 0
            For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griDetalle.Rows
                Dim ListaPuntoPartida = New List(Of e_Combo)
                Dim oeDireccionEmpresa = New e_Combo
                oeDireccionEmpresa.Nombre = "Contacto"
                oeDireccionEmpresa.Id = fila.Cells("IdCliente").Value
                ListaPuntoPartida.AddRange(olDireccionEmpresa.Listar(oeDireccionEmpresa))
                Dim Dt As DataTable = olCombo.ComboGrilla(ListaPuntoPartida)
                CrearComboGridPorCelda("IdContactoCarga", "Nombre", j, griDetalle, Dt, True)
                CrearComboGridPorCelda("IdContactoDescarga", "Nombre", j, griDetalle, Dt, True)
                j = j + 1
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub griLista_ClickCellButton(sender As Object, e As CellEventArgs) Handles griLista.ClickCellButton
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            If e.Cell.Column.Key = "Observacion" Then
                Dim oeDemanda As New e_Demanda
                oeDemanda.Observacion = e.Cell.Text
                oeDemanda.UsuarioCreacion = gUsuarioSGI.Id
                oeDemanda.TipoOperacion = "P"
                oeDemanda.Id = griLista.Rows(e.Cell.Row.Index).Cells("IdDemanda").Value
                oeDemanda.PrefijoID = gs_PrefijoIdSucursal '@0001
                olDemanda.GuardarObservacion(oeDemanda)
            End If
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub ficDemanda_SelectedTabChanging(sender As Object, e As UltraWinTabControl.SelectedTabChangingEventArgs) Handles ficDemanda.SelectedTabChanging
        Try
            If e.Tab.Index = 1 Then
                CargarExtras()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarExtras()
        Try
            If bandCarga = "" Then
                bandCarga = "S"
                LlenaCombos()
                ComboGrilla()
                Me.dtFechaRecepcion.Value = FechaServidor.AddDays(1)
                Me.dtFechaAtencion.Value = FechaServidor
                Me.dtSolicita.Value = FechaServidor
                With griDetalle.DisplayLayout.Bands(0)
                    If PerfilAsignado(gNombrePerfilAutorizaTarifas) Then
                        .Columns("FleteUnitario").Header.Enabled = True
                    Else
                        .Columns("FleteUnitario").EditorComponent = Nothing
                        .Columns("FleteUnitario").CellClickAction = CellClickAction.CellSelect
                        .Columns("DireccionOrigen").CellClickAction = CellClickAction.RowSelect
                        .Columns("DireccionDestino").CellClickAction = CellClickAction.RowSelect
                        .Columns("Cliente").CellClickAction = CellClickAction.RowSelect
                        .Columns("DireccionOrigen").EditorComponent = Nothing
                        .Columns("DireccionDestino").EditorComponent = Nothing
                        .Columns("Cliente").EditorComponent = Nothing
                    End If
                End With
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub LlenaComboUsuario()
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
    End Sub
End Class