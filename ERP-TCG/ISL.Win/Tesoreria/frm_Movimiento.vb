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
Imports Infragistics.Win.UltraWinGrid
Imports System.Transactions

Public Class frm_Movimiento
    Inherits ISL.Win.frm_MenuPadre

#Region "Inicializacion"

    Private _buscarIdCta As String

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Public Overrides Function getInstancia() As frm_MenuPadre
        Operacion = "Inicializa"
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_Movimiento()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaración de variables"

    'Declaración de instancia para el control de modificaciones de la entidad en el formulario  oeMovSaldo, oeMovObtener,
    Private WithEvents oeMovimiento, oeMovimientoPrestamo, oeMovimientoDescuento, oeMovimientoDevolucion, oeMovimientoIngresoFF As New e_Movimiento

    Dim olMovimiento As New l_Movimiento

    Private IndCajaPrincipal As Boolean = False

    Dim oeOperacionDetalle As New e_OperacionDetalle
    Dim olOperacion As New l_Operacion

    Dim idCompraAlm As String = ""
    Dim oeMovimiento_Viaje_Detalle, oeViajeAsociado As New e_Movimiento_Viaje
    Dim olMovimiento_Viaje_Detalle, olViajeAsociado As New l_Movimiento_Viaje

    Dim oeMovimiento_Administrativo As New e_Movimiento_Administrativo
    Dim olMovimiento_Administrativo As New l_Movimiento_Administrativo

    Private WithEvents oeMovimiento_Viaje As New e_Movimiento_Viaje

    Dim olMovimiento_Viaje As New l_Movimiento_Viaje

    Dim oeCuentaCorriente As New e_CuentaCorriente
    Dim olCuentaCorriente As New l_CuentaCorriente
    Dim idPilotoOriginal As String = ""
    Dim oeChequeEmitido As New e_ChequeEmitido
    Dim olChequeEmitido As New l_ChequeEmitido

    Dim frm As New frm_TarifasProveedor

    Dim oeCaja As New e_Caja
    Dim olCaja As New l_Caja

    Dim oeSeg As New e_Seguimiento
    Dim olSeg As New l_Seguimiento

    Dim oeCajaUsuario As New e_CajaUsuario
    Dim olCajaUsuario As New l_CajaUsuario

    Dim oeProveedor As New e_Proveedor
    Dim olProveedor As New l_Proveedor

    Dim oeViaje, OeViajeOperacion As New e_Viaje

    Dim loOtrIng As New List(Of e_OtrosIngresos)

    Dim oeTrabajador As New e_Trabajador
    Dim olTrabajador As New l_Trabajador

    Dim oeVehiculo As New e_Vehiculo
    Dim olVehiculo As New l_Vehiculo

    Dim oeProcesoGlosa As New e_ProcesoGlosa
    Dim olProcesoGlosa As New l_ProcesoGlosa

    Dim loMovimientoViaje As New List(Of e_Movimiento_Viaje)
    Dim loMovimiento_Viaje_Detalle As New List(Of e_Movimiento_Viaje)
    Dim loViajeAsociado As New List(Of e_Movimiento_Viaje)

    Dim loMovimiento_Administrativo As New List(Of e_Movimiento_Administrativo)
    Dim loCuentaCorriente As New List(Of e_CuentaCorriente)
    Dim loChequeEmitido As New List(Of e_ChequeEmitido)
    Dim loCaja As New List(Of e_Caja)

    Dim oeMaterial As New e_Material
    Dim olMaterial As New l_Material

    Dim oeBolsaViaje As New e_BolsaViaje
    Dim olBolsaViaje As New l_BolsaViaje

    Dim oeRuta As New e_Ruta
    Dim olRuta As New l_Ruta

    Private olGrupo As New l_Grupo
    Private GloAux As String = ""
    'Manejador de Empresas Para Grifos
    Dim oeEmpresa As New e_Empresa, olEmpresa As New l_Empresa
    'Manejador de Lugares
    Dim oeCcpp As New e_CCPP, olCcpp As New l_CCPP
    'Manejador de Direccion
    Dim oeDireccion As New e_Direccion, olDireccion As New l_Direccion

    Dim oeZona As New e_Flota
    Dim olZona As New l_Flota
    Dim ListaZona As New List(Of e_Flota)

    Dim oeCentro As New e_Centro
    Dim olCentro As New l_Centro
    Dim ListaCentro As New List(Of e_Centro)

    Dim ListaFlujoCuenta As New List(Of e_FlujoCaja)
    Dim ListaFlujoCaja As New List(Of e_FlujoCaja)
    Dim ListaTipoDocumento As New List(Of e_TipoDocumento)
    Dim ListaTipoGasto As New List(Of e_TipoGasto)
    Dim ListaProveedor As New List(Of e_Proveedor)
    Dim ListaAreaTrabajador As New List(Of e_Area)

    Dim Prefijo As New l_Configuracion

    Dim loMovimiento As New List(Of e_Movimiento)

    Dim idOperacion, idPiloto, idCopiloto, idAyudante, tipoTransa, _
    idMovimiento, idCuentaTrabajador, idTrabajador, strTrabajador, CuentaAdm, idCajaCentro, _
    Glosa_Mov, Voucher_Mov, idTipoVehiculo, idOrigen, idDestino, idRuta As String

    Dim Placas As New List(Of e_GastoVehiculo)
    Dim Placas1 As New List(Of Object)

    Public idViajePrestamo As String = ""
    Dim MontoFleteAdm As Decimal

    Private Shared instancia As frm_Movimiento = Nothing
    Private Shared Operacion As String
    Private Estado As String
    Private IdDocumentoAlmacen As String = ""
    Private SaldoDocumento As Double = 0
    Dim _ingresando_datos As Boolean = False

    Dim Opcion As Boolean
    Dim IndChiclayo As Boolean = False
    Dim IndicadorIGV As Boolean = False
    Dim IngresoFlete As Boolean = False
    Private oeIGV As New e_Impuesto
    Private olImp As New l_Impuesto
    Dim TipoMov As Integer

    Dim band As Boolean = False
    Dim TipoAmp As Integer = 0
    Dim DobleClick As Integer = 0
    Private aux1 As Decimal = 0
    Private aux2 As Decimal = 0
    Private aux3 As Boolean = False
    'Nuevo Codigo 04/06/2012
    Dim loCC As New List(Of e_CuentaCorriente)
    Dim loCA As New List(Of e_CuentaCorriente)

    '-----------------maximo
    Private ldFechaPeriodo As Date = Date.Parse("01/01/1901")
    Private oePeriodo, oePerGrupo, oePer As New e_Periodo
    Private olPeriodo As New l_Periodo
    Private oeMonedaGasto As New e_Moneda
    Private oeProveedorGasto As New e_Proveedor
    Private oeTipoDocGasto As New e_TipoDocumento
    Private oeFlujoCaja As New e_FlujoCaja
    Dim olFlujoCaja As New l_FlujoCaja
    Private IdCuentaContableCompraAlmacen As String = ""
    Private IndCompraAlmacen As Boolean = False
    Private BanderaDocSustento As Boolean = False
    Private leFlujoCajaConta As New List(Of e_FlujoCaja)
    Private oeFlujoPlaca As New e_ProcesoFlujoCaja
    Private olFlujoPlaca As New l_ProcesoFlujoCaja
    Private loFlujoPlaca As New List(Of e_ProcesoFlujoCaja)

    Private olPersona As New l_Persona
    Private leTipoGastoDetalle As List(Of e_TipoGastoDetalle)

    Dim RegistroEditado As Integer = 0
    Dim IdRegistroEditado As String = ""

    Dim oeRegistroEditado As New e_RegistrosEditados
    Dim olRegistroEditado As New l_RegistrosEditados

    Dim olTrabajadorSeguridad As New l_TrabajadorSeguridad

    Dim IdMaterial As String = ""
    Dim IdCliente As String = ""

    Dim Modificado As Boolean = False

    'CAJA EXTERNA
    Private loValRen As New List(Of e_ValesRendir)
    Private loGastosCaja As New List(Of e_GastoOperacion)

    'variables para retencion de rrhh
    'Private oeEmpresaAporte As New e_EmpresaAportacion
    'Private olEmpresaAporte As New l_EmpresaAportacion

    'Agregado By: Renzo
    Private loTarjetaMovimiento As List(Of e_TarjetaMovimiento)
    Private olTarjetaMovimiento As l_TarjetaMovimiento
    Private loRutaPeaje As List(Of e_RutaPeaje)

    'Variables Estaticas
    Private Const IdFCPeajes As String = "1CH000000021"
    Private Const IdTDTicketCinta As String = "1CH000000047"
    Private Const IdTDOrdenTrabajo As String = "1SI000000001"
    Private Const IdCBolsaViaje As String = "1SI000001"

    Private lenSerie As Integer = 0, lenNumero As Integer = 0

    'Concepto
    Private oeConcepto As New e_Concepto
    Private olConcepto As New l_Concepto
    Private loConcepto As New List(Of e_Concepto)

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Operacion = "Inicializa"
            Tiempo1.Enabled = True
            Listar(Activo)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If Not ValidaUsuarioCajaCentro(idCajaCentro, ObtenerCentro.Id, gUsuarioSGI.IdTrabajador) Then Throw New Exception("No puede Realizar Movimientos en esta Sede")
            oeMovimiento.IndPrestamoHab = 0
            Select Case ficMovimiento.SelectedTab.Index
                Case 0
                    Select Case ficTipoMovimiento.SelectedTab.Index
                        Case 1
                            If ValidaIngresoFF() Then
                                If GuardarIngresoFF() Then
                                    Me.expIngresoFF.Expanded = False
                                    Consultar(True)
                                Else
                                    Exit Sub
                                End If
                            End If
                    End Select
                Case 1
                    Select Case ficMovimientoViaje.SelectedTab.Index
                        Case 0
                            Select Case ficMovimientoDetalle.SelectedTab.Index
                                Case 0
                                    If GuardarMovimiento() Then MyBase.Guardar()
                                Case 1
                                    If Me.cboTrabajadorPrestamo.SelectedIndex = -1 Or Me.cboViaje.SelectedIndex = -1 Then
                                        Throw New Exception("Seleccione Viaje Por Favor")
                                    Else
                                        If GuardarMovimientoPrestamo() Then
                                            LimpiaPrestamo()
                                            If ficMovimiento.SelectedTab.Index = 1 Then
                                                ControlBoton(0, 0, 0, 1, 1, 0, 1, 0, 1)
                                            Else
                                                ControlBoton(1)
                                            End If
                                        End If
                                    End If
                                Case 2
                                    If GuardarMovimientoDescuento() Then MyBase.Guardar()
                            End Select
                        Case 1
                            If GuardaGastoOperacion() Then
                                If TipoMov = 1 Then
                                    ControlBoton(0, 0, 0, 1, 1, 0, 1, 0, 0)
                                Else
                                    ControlBoton(1, 0, 0, 0, 1, 0, 0, 0, 0)
                                End If
                            End If
                    End Select
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If ficMovimiento.SelectedTab.Index = 1 Then
                If ficMovimientoViaje.SelectedTab.Index = 0 Then
                    If DobleClick = 0 Then
                        MostrarTabs(0, ficMovimiento, 0)
                        ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                    Else
                        Select Case ficMovimientoDetalle.SelectedTab.Index
                            Case 0
                                If oeMovimiento_Viaje.Modificado Then
                                    If txtEstado.Text <> "REEMBOLSADO" Then
                                        Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                                            Case Windows.Forms.DialogResult.Yes
                                                If GuardarMovimiento() Then
                                                    MostrarTabs(0, ficMovimiento)
                                                    _ingresando_datos = False
                                                    ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                                                    Consultar(True)
                                                Else
                                                    _ingresando_datos = True
                                                    MostrarTabs(1, ficMovimiento)
                                                    MostrarTabs(0, ficMovimientoDetalle)
                                                End If
                                            Case Windows.Forms.DialogResult.No
                                                etiLiquidar.Visible = False
                                                btnLiquidar.Visible = False
                                                Me.UltraExpandableGroupBoxMovCuenta.Expanded = True
                                                MostrarTabs(0, ficMovimiento)
                                                _ingresando_datos = False
                                                ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                                                Consultar(True)
                                        End Select
                                    Else
                                        etiLiquidar.Visible = False
                                        btnLiquidar.Visible = False
                                        MostrarTabs(0, ficMovimiento)
                                        _ingresando_datos = False
                                        ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                                        Consultar(True)
                                    End If
                                Else
                                    etiLiquidar.Visible = False
                                    btnLiquidar.Visible = False
                                    Me.UltraExpandableGroupBoxMovCuenta.Expanded = True
                                    MostrarTabs(0, ficMovimiento, 0)
                                    MostrarTabs(0, ficMovimientoDetalle, 0)
                                    _ingresando_datos = False
                                    Consultar(True)
                                End If
                            Case 1, 2, 3
                                If ficMovimientoDetalle.SelectedTab.Index = 0 Then
                                    MostrarTabs(0, ficMovimiento, 0)
                                Else
                                    MostrarTabs(0, ficMovimientoDetalle, 0)
                                    MostrarTabs(1, ficMovimiento, 1)
                                End If
                        End Select
                    End If
                    ActualizaRegistroEditado()
                Else
                    If Modificado Then
                        Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en Gastos?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                            Case Windows.Forms.DialogResult.Yes
                                Guardar()
                            Case Windows.Forms.DialogResult.No
                                CancelarGasto()
                            Case Windows.Forms.DialogResult.Cancel
                        End Select
                    Else
                        CancelarGasto()
                    End If
                End If
            Else
                MostrarTabs(0, ficTipoMovimiento, 1)
                Me.cboTrabajadorMovimiento.SelectedIndex = 0
                ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                ActualizaRegistroEditado()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

    Public Overrides Sub Exportar()
        Try
            If ficMovimiento.SelectedTab.Index = 0 Then
                Select Case ficTipoMovimiento.SelectedTab.Index
                    Case 0
                        Exportar_Excel(griLista)
                    Case 1
                        Exportar_Excel(GriCuentaAdministrativa)
                End Select
            Else
                If ficMovimientoViaje.SelectedTab.Index = 0 Then
                    Exportar_Excel(griMovimiento)
                Else
                    Exportar_Excel(griGastoOperacion)
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        Dim TipoOperacion As String = "0"
        Dim id As String = ""
        Try
            Dim formulario As New frm_ReporteVoucherMovimientoCaja
            If griMovimiento.Selected.Rows.Count > 0 Then
                Dim a As String = griMovimiento.ActiveRow.Cells("TipoTransa").Value
                If griMovimiento.ActiveRow.Cells("TipoTransa").Value = "1" Or griMovimiento.ActiveRow.Cells("TipoTransa").Value = "2" Or griMovimiento.ActiveRow.Cells("TipoTransa").Value = "4" Then
                    If griMovimiento.ActiveRow.Cells("TipoTransa").Value = "1" Or griMovimiento.ActiveRow.Cells("TipoTransa").Value = "2" Then TipoOperacion = "1"
                    If griMovimiento.ActiveRow.Cells("TipoTransa").Value = "4" Then TipoOperacion = "2"
                    Dim IdMov As String = griMovimiento.ActiveRow.Cells("IdMovimiento").Value
                    formulario.CargarDatos(TipoOperacion, IdMov)
                    formulario.ShowDialog()
                ElseIf griMovimiento.ActiveRow.Cells("TipoTransa").Value = 5 Then
                    id = griMovimiento.ActiveRow.Cells("IdMovimiento").Value
                    TipoOperacion = "3"
                    formulario.CargarDatos(TipoOperacion, id)
                    formulario.ShowDialog()
                ElseIf griMovimiento.ActiveRow.Cells("TipoTransa").Value = 3 Then
                    id = griMovimiento.ActiveRow.Cells("IdMovimiento").Value
                    TipoOperacion = "5"
                    formulario.CargarDatos(TipoOperacion, id)
                    formulario.ShowDialog()
                Else

                    id = griMovimiento.ActiveRow.Cells("Id").Value
                    TipoOperacion = "4"
                    formulario.CargarDatos(TipoOperacion, id)
                    formulario.ShowDialog()
                End If
                ControlBoton(0, 0, 0, 1, 1, 0, 1, 0, 0)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Sub CancelarGasto()
        If TipoMov = 1 Then
            MostrarTabs(1, ficMovimiento, 1)
            MostrarTabs(0, ficMovimientoViaje, 0)
            ControlBoton(0, 0, 0, 1, 1, 0, 1, 0, 0)
            lblCantidadPeajes.Visible = False
            txtCantidadPeajes.Visible = False
            txtCantidadPeajes.Value = 0
        Else
            MostrarTabs(0, ficMovimiento, 0)
            MostrarTabs(0, ficTipoMovimiento, 1)
            ficTipoMovimiento.Tabs(1).Selected = True
            ControlBoton(1, 0, 0, 0, 1, 0, 0, 0, 1)
        End If
    End Sub

    Public Function GuardarIngresoFF() As Boolean
        Dim TipoOperacion As String = "0"
        If expIngresoFF.Expanded = True Then
            oeMovimientoIngresoFF.Ingreso = decIngresoFF.Value
            oeMovimientoIngresoFF.Egreso = 0
            oeMovimientoIngresoFF.Glosa = txtGlosaFF.Text
            oeMovimientoIngresoFF.Saldo = 0
            oeMovimientoIngresoFF.Descuento = 0
            oeMovimientoIngresoFF.TipoTransa = 5
            oeMovimientoIngresoFF.Fecha = fecIngresoFF.Value
            TipoOperacion = "8" ' Reporte Vale Ingreso a Fondo
            oeMovimientoIngresoFF.IdCuentaCorrienteOrigen = BuscarIdCtaCte(gUsuarioSGI.IdTrabajador, 1, loCuentaCorriente)
            If cboTrabajadorMovimiento.Value = CuentaAdm Then
                Return False
            End If
            oeMovimientoIngresoFF.IdCuentaCorrienteDestino = cboTrabajadorMovimiento.Value
            oeMovimientoIngresoFF.TipoProceso = "AMPLIACION"
            oeMovimientoIngresoFF.TipoOperacion = "I"
            oeMovimientoIngresoFF.UsuarioCreacion = gUsuarioSGI.Id
            oeMovimientoIngresoFF.IndicadorCorrelativo = True
            oeCajaUsuario = New e_CajaUsuario
            oeCajaUsuario.IdTrabajador = idTrabajador
            oeCajaUsuario = olCajaUsuario.Obtener(oeCajaUsuario)
            oeMovimientoIngresoFF.IdCaja = oeCajaUsuario.IdCaja
            If oeMovimientoIngresoFF.IdCaja = "1CH001" Then
                Throw New Exception("No puede Retirar de su misma Caja")
            ElseIf oeMovimientoIngresoFF.IdCaja = "1CH006" Then
                Throw New Exception("Caja Administrativa solo Habilitada para Movimientos con Fletes")
            End If
            oeMovimientoIngresoFF.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olMovimiento.Guardar(oeMovimientoIngresoFF, New e_Movimiento) Then
                Dim formulario As New frm_ReporteVoucherMovimientoCaja
                formulario.CargarDatos(TipoOperacion, oeMovimientoIngresoFF.Id)
                formulario.ShowDialog()
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
                Me.expIngresoFF.Expanded = False
            End If
            Return True
        Else
            Return False
        End If
    End Function

    Private Function GuardarMovimiento() As Boolean
        Dim oeMovAux As New e_Movimiento
        Dim TipoOperacion As String = "0"
        Dim id_movimiento_imprimir As String = ""
        Dim voucher As String = ""
        If oeMovimiento.TipoProceso <> "HABILITACION_CUENTA" Then
            If decImporte.Value = 0 Then
                Return True
            End If
        End If
        Try
            If opcSalidaEntrada.CheckedIndex = 1 Then
                If oeMovimiento.TipoProceso <> "HABILITACION_CUENTA" Then
                    If Me.decImporte.Value > Math.Round(Me.decSaldo.Value, 2) Then
                        Throw New Exception("Monto de Ingreso Excede al Saldo")
                    End If
                    If decImporte.Value = 0 Then
                        Throw New Exception("El Monto de Ingreso tiene que ser Mayor a 0")
                    End If
                End If
            End If
            If IndCajaPrincipal Then
                Select Case opcSalidaEntrada.CheckedIndex
                    Case 0
                        oeMovimiento.Ingreso = 0
                        TipoOperacion = "1"
                        oeMovimiento.IdCuentaCorrienteOrigen = BuscarIdCtaCte(gUsuarioSGI.IdTrabajador, 1, loCuentaCorriente)
                        If FicDatos.SelectedTab.Index = 2 Then
                            oeMovimiento.Egreso = decHabEfectivo.Value
                        Else
                            If Me.decImporte.Value = 0.0 Then
                                Return True
                            Else
                                oeMovimiento.Egreso = decImporte.Value
                            End If
                        End If
                    Case 1
                        oeMovimiento.Ingreso = decImporte.Value
                        oeMovimiento.Egreso = 0
                        oeMovimiento.Saldo = 0
                        oeMovimiento.Descuento = 0
                        oeMovimiento.TipoTransa = 5
                        TipoOperacion = "3" ' Reporte Vale Ingreso a Fondo
                        oeMovimiento.IdCuentaCorrienteOrigen = BuscarIdCtaCte(gUsuarioSGI.IdTrabajador, 1, loCuentaCorriente)
                        If oeMovimiento.IdCuentaCorrienteOrigen = "" Then oeMovimiento.IdCuentaCorrienteOrigen = BuscarIdCtaCte(gUsuarioSGI.IdTrabajador, 0, loCuentaCorriente)
                        oeMovimiento.IdCuentaCorrienteDestino = BuscarIdCtaCte(idPiloto, 0, loCuentaCorriente)
                End Select
                oeMovimiento.TipoOperacion = "I"
                oeMovimiento.Glosa = txtGlosa.Text & " " & txtPiloto.Text & " " & txtViaje.Text
                oeMovimiento.UsuarioCreacion = gUsuarioSGI.Id
                oeMovimiento.IndicadorCorrelativo = True
                oeMovimiento.oeMovimientoViaje = oeMovimiento_Viaje
                oeMovimiento.oeMovimientoViaje.IdViaje = txtViaje.Tag
                If oeMovimiento.TipoProceso = "HABILITACION_CUENTA" Then
                    oeMovimiento.TipoTransa = 0 '1
                    oeMovimiento.UsuarioCreacion = gUsuarioSGI.Id
                    oeMovimiento.TipoMovimiento = 2 '0 '2
                    oeMovimiento.Descuento = 0
                    oeMovimiento.IdEstado = "HABILITADA"
                    oeMovimiento.oeMovimientoViaje = New e_Movimiento_Viaje
                    oeCajaUsuario = New e_CajaUsuario
                    oeCajaUsuario.IdTrabajador = idTrabajador
                    oeCajaUsuario = olCajaUsuario.Obtener(oeCajaUsuario)
                    oeMovimiento.IdCaja = oeCajaUsuario.IdCaja
                Else
                    If oeMovimiento.Ingreso = 0 Then
                        oeMovimiento.IdCuentaCorrienteDestino = BuscarIdCtaCte(idPiloto, 0, loCuentaCorriente)
                        If txtEstado.Text = gNombreEstadoPendiente Then
                            oeMovAux = New e_Movimiento
                            oeMovAux.TipoTransa = 1
                            oeMovAux.TipoOperacion = "D"
                            oeMovAux.Id = idMovimiento
                            oeMovAux.IdEstado = gNombreEstadoHabilitada
                        End If
                        oeMovimiento.TipoTransa = 2
                        oeMovimiento.TipoOperacion = "I"
                    End If
                    oeMovimiento.IdCaja = idCajaCentro
                    oeMovimiento.IdEstado = gNombreEstadoHabilitada
                    oeMovimiento.IndPrestamoHab = 0
                End If
                oeMovimiento.PrefijoID = gs_PrefijoIdSucursal '@0001
                oeMovAux.PrefijoID = gs_PrefijoIdSucursal '@0001
                If olMovimiento.Guardar(oeMovimiento, oeMovAux) Then
                    'If opcSalidaEntrada.CheckedIndex = 0 Then
                    Dim formulario As New frm_ReporteVoucherMovimientoCaja
                    If oeMovimiento.TipoProceso = "HABILITACION_CUENTA" Then
                        id_movimiento_imprimir = oeMovimiento.Id
                        voucher = oeMovimiento.Voucher
                        TipoOperacion = "4"
                    Else
                        ActualizaRegistroEditado()
                        formulario.CargarDatos(TipoOperacion, oeMovimiento.Id)
                        formulario.ShowDialog()
                    End If
                    If oeMovimiento.TipoProceso = "HABILITACION_CUENTA" Then
                        formulario.CargarDatos(TipoOperacion, id_movimiento_imprimir)
                        formulario.ShowDialog()
                        mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
                        'End If
                    End If
                Else
                    Return False
                End If
            Else
                If opcSalidaEntrada.CheckedIndex = 0 Then
                    If Not olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "HAB BOLSA VIAJE") Then Return False
                    If decImporte.Value = 0 Then Return False
                    oeMovimientoPrestamo.IndPrestamoHab = 1
                    oeMovimientoPrestamo.TipoOperacion = "I"
                    oeMovimientoPrestamo.Descuento = "0"
                    oeMovimientoPrestamo.Activo = True
                    oeMovimientoPrestamo.Ingreso = decImporte.Value
                    oeMovimientoPrestamo.Egreso = 0
                    oeMovimientoPrestamo.Saldo = 0
                    oeMovimientoPrestamo.Glosa = txtGlosa.Text & " " & txtPiloto.Text & " " & txtViaje.Text
                    oeMovimientoPrestamo.UsuarioCreacion = gUsuarioSGI.Id
                    oeMovimientoPrestamo.IdCuentaCorrienteDestino = BuscarIdCtaCte(gUsuarioSGI.IdTrabajador, 1, loCuentaCorriente)
                    oeMovimientoPrestamo.IdCuentaCorrienteOrigen = ""
                    oeMovimientoPrestamo.TipoProceso = "PRESTAMO_CUENTA"
                    oeMovimientoPrestamo.TipoTransa = 3
                    oeMovimientoPrestamo.IndicadorCorrelativo = False
                    oeMovimientoPrestamo.IdCaja = idCajaCentro
                    oeMovimientoPrestamo.oeMovimientoViaje = New e_Movimiento_Viaje
                    Dim formularioclave As frm_AutenticarTrabajador
                    formularioclave = New frm_AutenticarTrabajador
                    Dim idTrabEntr As String = ""
                    If formularioclave.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                        ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
                        Return False
                    Else
                        If idCajaCentro = "1CH002" Then
                            idTrabEntr = formularioclave.idTrabajador
                            If gUsuarioSGI.IdTrabajador = idTrabEntr Then
                                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
                                Throw New Exception("No Puede Poner Su Propia Clave al Momento de Habilitar")
                            End If
                        End If

                    End If
                    formularioclave = Nothing
                    Dim oeMovimientoPrestamo2 As New e_Movimiento
                    oeMovimientoPrestamo2 = oeMovimientoPrestamo.Clonar
                    oeMovimientoPrestamo2.Egreso = decImporte.Value
                    oeMovimientoPrestamo2.IndicadorCorrelativo = True
                    oeMovimientoPrestamo2.Ingreso = 0
                    oeMovimientoPrestamo2.Saldo = decImporte.Value
                    oeMovimientoPrestamo2.Glosa = txtGlosa.Text & " " & txtViaje.Text & " DE: " & oeCajaUsuario.NombreCompleto
                    oeMovimientoPrestamo2.IdCuentaCorrienteDestino = BuscarIdCtaCte(idPiloto, 0, loCuentaCorriente)
                    oeMovimientoPrestamo2.IdCuentaCorrienteOrigen = oeMovimientoPrestamo.IdCuentaCorrienteDestino
                    If txtEstado.Text = gNombreEstadoPendiente Then
                        oeMovAux = New e_Movimiento
                        oeMovAux.IdEstado = gNombreEstadoHabilitada
                        oeMovAux.TipoTransa = 1
                        oeMovAux.TipoOperacion = "D"
                        oeMovAux.Id = idMovimiento
                        'oeMovimientoPrestamo2.oeMovimientoViaje = New e_Movimiento_Viaje
                        'oeMovimientoPrestamo2.oeMovimientoViaje.TipoTRB = ""
                        'oeMovimientoPrestamo2.oeMovimientoViaje.IdViaje = txtViaje.Tag
                        'oeMovimientoPrestamo2.oeMovimientoViaje.TipoOperacion = "A"
                        'oeMovimientoPrestamo2.oeMovimientoViaje.IdMovimiento = idMovimiento
                    End If
                    oeMovimientoPrestamo2.TipoTransa = 2
                    oeMovimientoPrestamo2.IndPrestamoHab = 1
                    oeMovimientoPrestamo2.TipoOperacion = "I"
                    oeMovimientoPrestamo2.IdEstado = gNombreEstadoHabilitada
                    oeMovimientoPrestamo2.oeMovimientoViaje = New e_Movimiento_Viaje
                    oeMovimientoPrestamo2.oeMovimientoViaje.TipoTRB = ""
                    oeMovimientoPrestamo2.oeMovimientoViaje.IdViaje = txtViaje.Tag
                    oeMovimientoPrestamo2.oeMovimientoViaje.TipoOperacion = "I"
                    oeMovimientoPrestamo2.IdCaja = ""
                    oeMovimientoPrestamo2.oeMovimientoViaje.IdTrabajadorRecepciona = idTrabEntr
                    oeMovimientoPrestamo2.oeMovimientoViaje.IdTrabajadorClave = idTrabEntr
                    ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
                    Dim loMovimientoPrestamo As New List(Of e_Movimiento)
                    oeMovimientoPrestamo.PrefijoID = gs_PrefijoIdSucursal '@0001
                    loMovimientoPrestamo.Add(oeMovimientoPrestamo)
                    oeMovimientoPrestamo2.PrefijoID = gs_PrefijoIdSucursal '@0001
                    loMovimientoPrestamo.Add(oeMovimientoPrestamo2)
                    oeMovAux.PrefijoID = gs_PrefijoIdSucursal '@0001
                    If olMovimiento.GuardarDobleMovimiento(loMovimientoPrestamo, oeMovAux) Then '---------cuenta y piloto
                        ActualizaRegistroEditado()
                        Dim formulario As New frm_ReporteVoucherMovimientoCaja
                        TipoOperacion = 7
                        formulario.CargarDatos(TipoOperacion, oeMovimientoPrestamo2.Id)
                        formulario.ShowDialog()
                        mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
                    End If
                Else
                    Dim loMovimientosDev As New List(Of e_Movimiento)
                    Dim oeCom As New e_Combo
                    Dim idCtaCteCja As String = ""
                    oeCom.Id = idCajaCentro
                    oeCom.Tipo = 0
                    If AsistenteCajaPublic.Contains(oeCom) Then
                        oeCom = AsistenteCajaPublic.Item(AsistenteCajaPublic.IndexOf(oeCom))
                        idCtaCteCja = oeCom.Nombre.Trim
                    Else
                        idCtaCteCja = BuscarIdCtaCte(gUsuarioSGI.IdTrabajador, 1, loCuentaCorriente)
                        If idCtaCteCja = "" Then idCtaCteCja = BuscarIdCtaCte(gUsuarioSGI.IdTrabajador, 0, loCuentaCorriente)
                    End If
                    With oeMovimientoDevolucion
                        .TipoOperacion = "I"
                        .AsignadoGrupo = False
                        .Descuento = 0
                        .Activo = True
                        .Ingreso = decImporte.Value
                        .TipoMovimiento = 2
                        .IndPrestamoHab = 1
                        .Egreso = 0
                        .Saldo = decImporte.Value
                        .Glosa = txtGlosa.Text & " / " & Me.txtViaje.Text
                        .Fecha = fechaMovimiento.Value
                        .UsuarioCreacion = gUsuarioSGI.Id
                        .TipoTransa = "3"
                        .TipoProceso = "DEVOLUCION"
                        .Voucher = ""
                        .IndicadorCorrelativo = False
                        .IdCuentaCorrienteDestino = BuscarIdCtaCte(idPiloto, 0, loCuentaCorriente)
                        .oeMovimientoViaje = oeMovimiento_Viaje
                        .oeMovimientoViaje.IdViaje = txtViaje.Tag
                        .oeMovimientoViaje.RecibeBolsa = ""
                    End With
                    loMovimientosDev.Add(oeMovimientoDevolucion)
                    Dim oeMovDev As New e_Movimiento
                    With oeMovDev
                        .TipoOperacion = "I"
                        .AsignadoGrupo = 0
                        .Descuento = 0
                        .Activo = True
                        .Fecha = fechaMovimiento.Value
                        .UsuarioCreacion = gUsuarioSGI.Id
                        .IdCuentaCorrienteDestino = idCtaCteCja
                        .Glosa = oeMovimientoDevolucion.Glosa
                        .TipoProceso = "DEVOLUCION"
                        .Egreso = decImporte.Value
                        .Saldo = 0
                        .Ingreso = 0
                        .TipoTransa = 5
                        .IdCaja = idCajaCentro
                        .IndicadorCorrelativo = True
                        .oeMovimientoViaje = New e_Movimiento_Viaje
                    End With
                    oeMovDev.PrefijoID = gs_PrefijoIdSucursal '@0001
                    loMovimientosDev.Add(oeMovDev)
                    Dim oeMovimientoDM = New e_Movimiento '@0001
                    oeMovimientoDM.PrefijoID = gs_PrefijoIdSucursal '@0001
                    If olMovimiento.GuardarDobleMovimiento(loMovimientosDev, oeMovimientoDM) Then
                        TipoOperacion = "5"
                        Dim formulario As frm_ReporteVoucherMovimientoCaja
                        formulario = New frm_ReporteVoucherMovimientoCaja
                        ActualizaRegistroEditado()
                        formulario.CargarDatos(TipoOperacion, oeMovDev.Id)
                        formulario.ShowDialog()
                        mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
                        If Me.decImporte.Value = Math.Round(Me.decSaldo.Value, 2) Then
                            Liquidar(txtViaje.Tag)
                            Return True
                        End If
                    Else
                        Return False
                    End If
                End If
            End If
            Select Case opcSalidaEntrada.CheckedIndex
                Case 0
                    MostrarTabs(0, ficMovimiento)
                    MostrarTabs(0, ficMovimientoDetalle)
                    Consultar(True)
                    griLista.Focus()
                Case 1
                    Dim oemov As New e_Movimiento_Viaje
                    ListarMovimientoDetalle(oemov)
            End Select
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ValidaIngresoFF() As Boolean
        If decIngresoFF.Value = 0.0 Then
            mensajeEmergente.Problema("Ingrese Monto por Favor", True)
            Return False
        ElseIf txtGlosaFF.Text = "" Then
            mensajeEmergente.Problema("Ingrese Glosa por Favor", True)
            Return False
        Else
            Return True
        End If
    End Function

    Private Function GuardarMovimientoPrestamo() As Boolean
        Try
            Dim oeMovAux As New e_Movimiento
            If decImportePrestamo.Value > 0 Then
                oeMovimientoPrestamo.TipoOperacion = "I"
                oeMovimientoPrestamo.Descuento = "0"
                oeMovimientoPrestamo.Activo = True
                oeMovimientoPrestamo.Ingreso = decImportePrestamo.Value
                oeMovimientoPrestamo.Egreso = 0
                oeMovimientoPrestamo.Saldo = 0
                oeMovimientoPrestamo.Glosa = txtGlosaOrigen.Text
                oeMovimientoPrestamo.IndPrestamoHab = 1
                oeMovimientoPrestamo.TipoProceso = "PRESTAMO"
                oeMovimientoPrestamo.oeMovimientoViaje = oeMovimiento_Viaje
                oeMovimientoPrestamo.oeMovimientoViaje.IdViaje = txtViaje.Tag
                oeMovimientoPrestamo.oeMovimientoViaje.TipoOperacion = "I"
                oeMovimientoPrestamo.IdCaja = ""
                If Me.cboViaje.Text = Me.txtViaje.Text Then
                    MessageBox.Show("No puede realizar un prestamo a su mismo viaje", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    cboViaje.SelectedIndex = -1
                    Return False
                Else
                    Dim oeMovPres As New e_Movimiento
                    Dim oeMovViaPres As New e_Movimiento_Viaje
                    oeMovPres.Egreso = decImportePrestamo.Value
                    oeMovPres.IdCuentaCorrienteOrigen = BuscarIdCtaCte(idPiloto, 0, loCuentaCorriente)
                    oeMovPres.IdCuentaCorrienteDestino = BuscarIdCtaCte(cboTrabajadorPrestamo.Value, 0, loCuentaCorriente)
                    oeMovPres.UsuarioCreacion = gUsuarioSGI.Id
                    oeMovPres.TipoProceso = "PRESTAMO"
                    oeMovPres.Ingreso = 0
                    oeMovPres.Fecha = ObtenerFechaServidor()
                    oeMovPres.Saldo = decImportePrestamo.Value
                    oeMovPres.Glosa = txtGlosaDestino.Text
                    oeMovPres.IdCaja = ""
                    If etiEstadoAsociado.Text = "PENDIENTE" Then
                        oeMovAux.IdEstado = "HABILITADA"
                        oeMovAux.TipoTransa = 1
                        oeMovAux.IndPrestamoHab = 1
                        oeMovAux.TipoOperacion = "D"
                        oeMovAux.Id = idMovimiento
                    End If
                    'ElseIf etiEstadoAsociado.Text = "HABILITADA" Then
                    oeMovPres.TipoTransa = 2
                    oeMovPres.IndPrestamoHab = 1
                    oeMovPres.TipoOperacion = "I"
                    oeMovPres.IdEstado = "HABILITADA"
                    oeMovViaPres = New e_Movimiento_Viaje
                    oeMovViaPres.TipoTRB = ""
                    oeMovViaPres.IdViaje = idViajePrestamo
                    oeMovViaPres.TipoOperacion = "I"
                    oeMovViaPres.IdMovimiento = idMovimiento
                    oeMovPres.oeMovimientoViaje = oeMovViaPres
                    Dim loMovimientoDoble As New List(Of e_Movimiento)
                    oeMovimientoPrestamo.PrefijoID = gs_PrefijoIdSucursal '@0001
                    loMovimientoDoble.Add(oeMovimientoPrestamo)
                    oeMovPres.PrefijoID = gs_PrefijoIdSucursal '@0001
                    loMovimientoDoble.Add(oeMovPres)
                    oeMovAux.PrefijoID = gs_PrefijoIdSucursal '@0001
                    If olMovimiento.GuardarDobleMovimiento(loMovimientoDoble, oeMovAux) Then
                        MostrarTabs(1, ficMovimiento, 1)
                        MostrarTabs(0, ficMovimientoDetalle)
                        oeMovimiento_Viaje_Detalle = New e_Movimiento_Viaje
                        oeMovimiento_Viaje_Detalle.IdViaje = txtViaje.Tag
                        If Me.decImportePrestamo.Value = Me.decSaldo.Value Then
                            Liquidar(txtViaje.Tag)
                        Else
                            mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
                            oeMovimiento_Viaje_Detalle = New e_Movimiento_Viaje
                            oeMovimiento_Viaje_Detalle.IdViaje = txtViaje.Tag
                            ListarMovimientoDetalle(oeMovimiento_Viaje_Detalle) ', True)
                        End If
                    Else
                        Return False
                    End If
                End If
                Return True
            Else
                Throw New Exception("El Importe de Prestamo debe ser Mayor a 0.00")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Function

    Private Function GuardarMovimientoDescuento() As Boolean
        Dim TipoOperacion As String = "0"
        Try
            With oeMovimientoDescuento
                .TipoOperacion = "I"
                .AsignadoGrupo = False
                .Descuento = "1"
                .Activo = True
                .Ingreso = decImporteDescuento.Value
                .Egreso = 0
                .Saldo = decImporteDescuento.Value
                .Glosa = txtGlosaDescuento.Text
                .Fecha = fecFechaDescuento.Value
                .UsuarioCreacion = gUsuarioSGI.Id
                .TipoTransa = "4"
                .TipoProceso = "DESCUENTO"
                .IdCaja = ""
                .NroCuotas = numCuotas.Value
                .Concepto = cboConceptoDsct.Value
                .IndicadorCorrelativo = True
                .oeMovimientoViaje = New e_Movimiento_Viaje
                With .oeMovimientoViaje
                    .TipoOperacion = "I"
                    .IdViaje = txtViaje.Tag
                    .RecibeBolsa = ""
                    .IdTrabajadorRecepciona = ""
                    Select Case opcTrabajadorDescuento.CheckedIndex
                        Case 0
                            oeMovimiento_Viaje.TipoTRB = "P"
                        Case 1
                            oeMovimiento_Viaje.TipoTRB = "C"
                        Case 2
                            oeMovimiento_Viaje.TipoTRB = "A"
                    End Select
                End With
            End With
            If oeMovimientoDescuento.IdCuentaCorrienteDestino = "" Then Throw New Exception("Trabajador sin Cuenta Corriente Verificar")
            oeMovimientoDescuento.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olMovimiento.Guardar(oeMovimientoDescuento, New e_Movimiento) Then
                TipoOperacion = "2"
                Dim formulario As New frm_ReporteVoucherMovimientoCaja
                formulario.CargarDatos(TipoOperacion, oeMovimientoDescuento.Id)
                formulario.ShowDialog()

                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)

                oeMovimiento_Viaje_Detalle = New e_Movimiento_Viaje
                oeMovimiento_Viaje_Detalle.IdViaje = txtViaje.Tag
                ListarMovimientoDetalle(oeMovimiento_Viaje_Detalle) ', True)
                MostrarTabs(1, ficMovimiento, 1)
                MostrarTabs(0, ficMovimientoDetalle)
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Function

    Private Sub InicializarMovimientoViaje()
        loMovimiento_Viaje_Detalle.Clear()
        decImporte.Value = 0
        decSaldo.Value = 0
        decEgresos.Value = 0
        decTotalGastos.Value = 0
        decImportePrestamo.Value = 0
        decImporteDescuento.Value = 0
        decImporte.Enabled = True
        opcVerPiloto.Checked = False
        opcVerCopiloto.Checked = False
        opcVerAyudante.Checked = False
        opcVerOtro.Checked = False
        fechaMovimiento.Value = Date.Now
        fechaBalancin.Value = Date.Now
        oeMovimiento = New e_Movimiento
        oeMovimiento_Viaje = New e_Movimiento_Viaje
        etiFechaRecepcion.Visible = False
        fechaRecibidor.Visible = False
        cboTrabajador.Visible = False
        opcSalidaEntrada.CheckedIndex = 0
        etiLiquidar.Visible = False
        btnLiquidar.Visible = False
    End Sub

    Private Sub Listar(ByVal Activo As Boolean)
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Select Case ficTipoMovimiento.SelectedTab.Index
                Case 0
                    oeMovimiento_Viaje = New e_Movimiento_Viaje
                    oeMovimiento_Viaje.TipoOperacion = "4"
                    oeMovimiento_Viaje.IdPiloto = idTrabajador
                    oeMovimiento_Viaje.VincularViajePiloto = IIf(Me.chkBuscarCopiloto.Checked, 1, 0)
                    oeMovimiento_Viaje.IndViajeVacio = IIf(Me.chkViajeVacio.Checked, 1, 0)
                    oeMovimiento_Viaje.IdTracto = IIf(cboTracto.Text = "TODOS", "", cboTracto.Value)
                    oeMovimiento_Viaje.Viaje = IIf(txtCodViaje.Text <> "", "%" & txtCodViaje.Text, "")
                    oeMovimiento_Viaje.Estado = IIf(cboEstadoViaje.Text = "TODOS", "", cboEstadoViaje.Text)
                    oeMovimiento_Viaje.FechaDesde = fecDesde.Value
                    oeMovimiento_Viaje.FechaHasta = fecHasta.Value
                    oeMovimiento_Viaje.Activo = True
                    Cursor.Current = Cursors.WaitCursor
                    loMovimientoViaje = olMovimiento_Viaje.Listar(oeMovimiento_Viaje)
                    With griLista
                        .DataSource = loMovimientoViaje
                        .DisplayLayout.UseFixedHeaders = True
                        .DisplayLayout.Override.FixedHeaderIndicator = FixedHeaderIndicator.None
                        .DisplayLayout.Bands(0).Columns("Viaje").Header.Fixed = True
                        .DisplayLayout.Bands(0).Columns("Tracto").Header.Fixed = True
                        .DisplayLayout.Bands(0).Columns("Fecha").Header.Fixed = True
                        .DisplayLayout.Bands(0).Columns("Piloto").Header.Fixed = True
                        .DisplayLayout.Bands(0).Columns("Estado").Header.Fixed = True
                        .DisplayLayout.Bands(0).Columns("Fecha").Header.Caption = "Fecha Viaje"
                        .DisplayLayout.Bands(0).Columns("Fecha").Style = ColumnStyle.DateTime
                        .DisplayLayout.Bands(0).Columns("Fecha").Width = 100
                        .DisplayLayout.Bands(0).Columns("FecSalOrigen").Style = ColumnStyle.DateTime
                        .DisplayLayout.Bands(0).Columns("FecSalOrigen").Width = 100
                        .DisplayLayout.Bands(0).Columns("FecLleDestino").Style = ColumnStyle.DateTime
                        .DisplayLayout.Bands(0).Columns("FecLleDestino").Width = 100
                        .DisplayLayout.Bands(0).Columns("IdOperacion").Hidden = True
                        .DisplayLayout.Bands(0).Columns("Operacion").Hidden = True
                        .DisplayLayout.Bands(0).Columns("IngresoTotal").Header.Caption = "Egreso"
                        .DisplayLayout.Bands(0).Columns("EgresoTotal").Header.Caption = "Ingreso"
                    End With
                    For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griLista.Rows
                        If fila.Cells("Estado").Value = gNombreEstadoPendiente Then
                            fila.CellAppearance.BackColor = Me.ColorPendiente.Color
                        End If
                        If fila.Cells("Estado").Value = gNombreEstadoHabilitada Then
                            fila.CellAppearance.BackColor = Me.ColorHabilitada.Color
                        End If
                        If fila.Cells("Estado").Value = gNombreEstadoLiquidada Then
                            fila.CellAppearance.BackColor = Me.ColorLiquidada.Color
                        End If
                        If fila.Cells("Estado").Value = gNombreEstadoReembolsado Then
                            fila.CellAppearance.BackColor = Me.ColorReembolsado.Color
                        End If
                    Next
                    If griLista.Rows.Count > 0 Then
                        ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
                    Else
                        ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                    End If
                    If griLista.Rows.Count > 0 Then
                        griLista.Rows.Item(0).Selected = True
                        griLista.Rows(0).Activated = True
                    End If
                    CalcularTotales(griLista, "IngresoTotal", "EgresoTotal", "SaldoTotal")
                Case 1
                    If idCuentaTrabajador <> "" Then
                        CargarMovimientosCuentaCorriente(idCuentaTrabajador, GriCuentaAdministrativa)
                        If Me.expIngresoFF.Expanded And Me.expIngresoFF.Visible Then
                            ControlBoton(1, 0, 0, 1, 1, 0, 0, 1, 1)
                        Else
                            ControlBoton(1, 0, 0, 0, 1, 0, 0, 1, 1)
                        End If
                    Else
                        LimpiaGrid(GriCuentaAdministrativa, ogdAdministrativo)
                        ControlBoton(1, 0, 0, 0, 1, 0, 0, 1, 1)
                    End If
            End Select
        Catch ex As Exception
            Throw ex
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub LlenaCombos()
        Try
            ListarCuentaCorriente()
            'Carga Listado de cajas
            oeCaja = New e_Caja
            loCaja = olCaja.Listar(oeCaja)
            LlenarCombo(cboCaja, "Nombre", loCaja, -1)
            'Carga Tracto
            Dim loVeh As New List(Of e_Vehiculo)
            oeVehiculo = New e_Vehiculo
            oeVehiculo.Id = ""
            oeVehiculo.Placa = "TODOS"
            loVeh.Add(oeVehiculo)
            oeVehiculo = New e_Vehiculo
            oeVehiculo.TipoOperacion = "A"
            oeVehiculo.Motriz = True
            oeVehiculo.Activo = True
            oeVehiculo.IdEmpresaPropietaria = ISL_IdEmpresa
            loVeh.AddRange(olVehiculo.Listar(oeVehiculo))
            LlenarCombo(cboTracto, "Placa", loVeh, 0)
            'Carga Estado Bolsa de Viaje
            Dim loEstado As New List(Of e_Estado)
            Dim oeEstado As New e_Estado
            Dim olEstado As New l_Estado
            oeEstado.Id = ""
            oeEstado.Nombre = "TODOS"
            loEstado.Add(oeEstado)
            oeEstado = New e_Estado
            oeEstado.Nombre = "BOLSA DE VIAJE"
            loEstado.AddRange(olEstado.Listar(oeEstado))
            LlenarCombo(cboEstadoViaje, "Nombre", loEstado, 0)
            'cargar flujo caja concepto
            loConcepto = New List(Of e_Concepto)
            oeConcepto = New e_Concepto
            oeConcepto.Activo = True
            oeConcepto.Prefijo = "32"
            loConcepto = olConcepto.Listar(oeConcepto)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub LlenaCombosTrabajadores()
        Try
            Dim loTrabajador As New List(Of e_Trabajador)
            oeTrabajador = New e_Trabajador
            oeTrabajador.TipoOperacion = ""
            loTrabajador.AddRange(olTrabajador.Listar(oeTrabajador))
            Dim _leTrabAux = From le In loTrabajador Select le.Id, le.oePersona.NombreCompleto
            LlenarCombo(cboTrabajador, "NombreCompleto", _leTrabAux.ToList, -1)
            LlenarCombo(cboTrabajadorPrestamo, "NombreCompleto", _leTrabAux.ToList, -1)
            LlenarCombo(cboAutoriza, "NombreCompleto", _leTrabAux.ToList, -1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub LlenaComboTrabajadorMovimiento()
        Try
            Dim oeCC As New e_CuentaCorriente
            oeCC.Id = ""
            oeCC.Trabajador = "TODOS"
            loCC.Add(oeCC)
            loCA.Add(oeCC)
            loCC.AddRange(loCuentaCorriente.Where(Function(item) item.Tipo = 0))
            loCA.AddRange(loCuentaCorriente.Where(Function(item) item.Tipo = 1))
            LlenarCombo(cboTrabajadorMovimiento, "Trabajador", loCC, -1)
            cboTrabajadorMovimiento.SelectedIndex = 0
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenaComboProveedor()
        oeProveedor = New e_Proveedor
        oeProveedor.TipoOperacion = "5"
        cboProveedores.Value = Nothing
        ListaProveedor = New List(Of e_Proveedor)
        ListaProveedor.AddRange(olProveedor.Listar(oeProveedor))
        With cboProveedores
            .ValueMember = "Id"
            .DisplayMember = "Nombre"
            .DataSource = ListaProveedor
        End With
        InicializarComboProveedor()
    End Sub

    Private Sub MostrarViaje()
        Try
            oeViaje = New e_Viaje
            oeViaje.Id = griLista.ActiveRow.Cells("IdViaje").Value.ToString
            oeViaje.TipoOperacion = "V"
            oeViaje = olOperacion.ObtenerViaje(oeViaje)
            With oeViaje
                txtViaje.Tag = .Id
                txtViaje.Text = .Codigo
                txtTracto.Text = .Tracto
                txtTracto.Tag = .IdTracto
                txtCarreta.Text = .Carreta
                txtTipoVehiculo.Text = .TipoVehiculo
                txtRuta.Text = .Origen + " - " + .Destino
                txtPilotoDescuento.Text = .Piloto
                txtCopilotoDescuento.Text = .Copiloto
                txtAyudanteDescuento.Text = .Ayudante
                txtAyudante.Text = .Ayudante
                txtPiloto.Text = .Piloto
                txtCopiloto.Text = .Copiloto
                idPiloto = .IdPiloto
                idCopiloto = .IdCopiloto
                idAyudante = .IdAyudante
                IdViaje = .Id
                idOrigen = .IdOrigen
                idDestino = .IdDestino
                idTipoVehiculo = .IdTipoVehiculo
                IdMaterial = .UsuarioModifica
                IdCliente = .UsuarioSeguimiento
                txtCarga.Text = .CargaMaterial
                txtCliente.Text = .Cliente
                fecFechaViaje.Value = .Fecha
                txtComisionista.Text = .Zona
                decComision.Value = .KmTractoOrigen
                numCostoEstiba.Value = .Produccion
                txtTipoCarga.Text = .Tesoreria
                If IndCajaPrincipal Then
                    MostrarPeso(.Id)
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub AmpliacionBolsaViaje()
        Try
            If griLista.ActiveRow.Cells("Estado").Value = "HABILITADA" Or griLista.ActiveRow.Cells("Estado").Value = "LIQUIDADA" Or griLista.ActiveRow.Cells("Estado").Value = "REEMBOLSADO" Then
                band = False
                opcVerPiloto.Checked = True
                loMovimiento_Viaje_Detalle = New List(Of e_Movimiento_Viaje)
                tipoTransa = "2"
                oeMovimiento_Viaje = New e_Movimiento_Viaje
                oeMovimiento = New e_Movimiento
                oeMovimiento.Id = griLista.ActiveRow.Cells("Id").Value.ToString
                oeMovimiento.TipoTransa = 2
                oeMovimiento.TipoProceso = "AMPLIACION"
                oeMovimiento.UsuarioCreacion = gUsuarioSGI.Id
                txtEstado.Tag = griLista.ActiveRow.Cells("IdEstado").Value.ToString
                txtEstado.Text = griLista.ActiveRow.Cells("Estado").Value.ToString
                oeMovimiento.IdEstado = griLista.ActiveRow.Cells("Estado").Value.ToString
                Glosa_Mov = oeMovimiento_Viaje.Glosa
                txtGlosa.Text = "AMPLIACION DE BOLSA DE VIAJE " & fechaMovimiento.Value
                oeMovimiento.Glosa = txtGlosa.Text
                oeMovimiento.Fecha = oeMovimiento_Viaje.Fecha
                ListarMovimientoDetalle(oeMovimiento_Viaje_Detalle) ', True)
                oeMovimiento.IdCuentaCorrienteDestino = BuscarIdCtaCte(idPiloto, 0, loCuentaCorriente)
                fechaMovimiento.Value = ObtenerFechaServidor()
                fechaRecibidor.Value = fechaMovimiento.Value
                fechaBalancin.Value = fechaMovimiento.Value
                MostrarTabs(0, ficMovimientoViaje, 0)
                agrCuenta.Text = "Cuenta Movimiento Viaje"
                cboTrabajadorPrestamo.Value = griLista.ActiveRow.Cells("IdPiloto").Value.ToString
                'ActualizaViajes()
                cboViaje.Value = griLista.ActiveRow.Cells("Id").Value.ToString
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub HabilitacionBolsaViaje()
        Try
            Dim estado As String
            band = False
            ListarUsuarioCaja()
            estado = griLista.ActiveRow.Cells("Id").Value
            idPiloto = griLista.ActiveRow.Cells("IdPiloto").Value
            If VerificarNumeroHabilitaciones(idPiloto) > 5 Then
                Throw New Exception("Numero Maximo de Habilitaciones alcanzado por Piloto")
            End If
            If VerificarRegistroEditado() Then
                oeMovimiento_Viaje = New e_Movimiento_Viaje
                oeMovimiento_Viaje.TipoOperacion = "5"
                oeMovimiento_Viaje.IdViaje = griLista.ActiveRow.Cells("IdViaje").Value.ToString
                oeMovimiento_Viaje.Id = griLista.ActiveRow.Cells("Id").Value.ToString
                oeMovimiento_Viaje.IdPiloto = griLista.ActiveRow.Cells("IdPiloto").Value.ToString
                oeMovimiento_Viaje.VincularViajePiloto = 0
                oeMovimiento_Viaje = olMovimiento_Viaje.Obtener(oeMovimiento_Viaje)
                If oeMovimiento_Viaje.Estado = "PENDIENTE" Or oeMovimiento_Viaje.Estado = "LIQUIDADA" Then
                    idTipoVehiculo = griLista.ActiveRow.Cells("IdTipoVehiculo").Value.ToString
                    loMovimiento_Viaje_Detalle = New List(Of e_Movimiento_Viaje)
                    agrCuenta.Text = "Cuenta Movimiento Viaje"
                    MostrarTabs(1, ficMovimiento, 1)
                    MostrarTabs(0, FicDatos)
                    MostrarTabs(0, ficMovimientoViaje, 0)
                    opcDefinicion.Enabled = True
                    cboCaja.Enabled = True
                    agrDatosViaje.Visible = True
                    FicObservacion.Visible = True
                    agrCuenta.Visible = True
                    Agrupacion8.Enabled = True
                    agrIEFF.Visible = True
                    ExpGroupBoxReceptor.Visible = True
                    UltraExpandableGroupBoxMovCuenta.Expanded = False
                    UltraExpandableGroupBoxMovCuenta.Visible = False
                    tipoTransa = "1"
                    ListarUsuarioCaja()
                    MostrarViaje()
                    MontosProgramados()
                    oeMovimiento = New e_Movimiento
                    oeMovimiento.Id = oeMovimiento_Viaje.IdMovimiento
                    oeMovimiento_Viaje_Detalle.Id = oeMovimiento_Viaje.IdMovimiento
                    ListarMovimientoDetalle(oeMovimiento_Viaje_Detalle) ', True)
                    oeMovimiento.TipoTransa = 1
                    oeMovimiento.TipoProceso = "HABILITACION"
                    oeMovimiento.UsuarioCreacion = gUsuarioSGI.Id
                    oeMovimiento.IdEstado = "HABILITADA"
                    oeMovimiento.Voucher = ""
                    oeMovimiento.IdCuentaCorrienteDestino = BuscarIdCtaCte(idPiloto, 0, loCuentaCorriente)
                    txtEstado.Tag = oeMovimiento_Viaje.IdEstado
                    txtEstado.Text = oeMovimiento_Viaje.Estado
                    fechaMovimiento.Value = Date.Now
                    fechaBalancin.Value = Date.Now
                    fechaRecibidor.Value = Date.Now
                    txtGlosa.Text = "HABILITACION DE BOLSA DE VIAJE " & fechaMovimiento.Value
                    FormatoGrillaMovimiento()
                Else
                    mensajeEmergente.Problema("No se puede habilitar", True)
                End If
                GuardarRegistroEditado()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub FormatoGrillaMovimiento()
        With griMovimiento.DisplayLayout.Bands(0)
            .Columns("IdMovimiento").Hidden = True
            .Columns("IdViaje").Hidden = True
            .Columns("Viaje").Hidden = True
            .Columns("Ruta").Hidden = True
            .Columns("TipoVehiculo").Hidden = True
            .Columns("IdTipoVehiculo").Hidden = True
        End With
    End Sub

    Private Sub MontosProgramados()
        Try
            oeBolsaViaje = New e_BolsaViaje
            oeBolsaViaje.TipoOperacion = "1"
            oeBolsaViaje.Id = oeViaje.IdOrigen
            oeBolsaViaje.IdRuta = oeViaje.IdDestino
            oeBolsaViaje = olBolsaViaje.Obtener(oeBolsaViaje)
            decMontoMinimo.Value = oeBolsaViaje.Minimo
            decMontoNormal.Value = oeBolsaViaje.Normal
            decMontoMaximo.Value = oeBolsaViaje.Maximo
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ListarUsuarioCaja()
        Try
            oeCajaUsuario = New e_CajaUsuario
            oeCajaUsuario = BuscarCajaUsuario(gUsuarioSGI.IdTrabajador)
            If oeCajaUsuario.Id <> "" Then
                IdCen = oeCajaUsuario.IdCentro
                For Each ListaCaja As e_Caja In loCaja
                    If ListaCaja.Id = oeCajaUsuario.IdCaja Then
                        idCajaCentro = ListaCaja.Id
                        cboCaja.Value = ListaCaja.Id
                        opcDefinicion.CheckedIndex = 0
                        cboCaja.Enabled = False
                        IndCajaPrincipal = ListaCaja.IndPrincipal
                        Exit For
                    End If
                Next
            Else
                mensajeEmergente.Problema("Este Usuario no esta asignado a ninguna caja", True)
                IdCen = ""
                cboCaja.Enabled = True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargaComboViajePiloto(ByVal IdTrabajador As String)
        Try
            Dim oeViajePiloto As New e_Movimiento_Viaje
            Dim olViajePiloto As New l_Movimiento_Viaje
            oeViajePiloto.TipoOperacion = "1"
            oeViajePiloto.IdPiloto = IdTrabajador
            oeViajePiloto.VincularViajePiloto = "1"
            oeViajePiloto.TipoTransa = "1"
            LlenarCombo(cboViaje, "Viaje", olViajePiloto.Listar(oeViajePiloto), -1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub ListarMovimientoDetalle(ByVal oeMov As e_Movimiento_Viaje)
        Try
            oeMov.TipoOperacion = "0"
            oeMov.IdPiloto = idPiloto
            oeMov.IdTracto = txtTracto.Tag
            oeMov.IdViaje = txtViaje.Tag
            oeMov.TipoTransa = ""
            loMovimiento_Viaje_Detalle = olMovimiento_Viaje_Detalle.Listar(oeMov)
            With griMovimiento
                .DataSource = loMovimiento_Viaje_Detalle
                .DisplayLayout.Bands(0).Columns("IdMovimiento").Hidden = True
                .DisplayLayout.Bands(0).Columns("Copiloto").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdViaje").Hidden = True
                .DisplayLayout.Bands(0).Columns("DiasAtrasados").Hidden = True
                .DisplayLayout.Bands(0).Columns("Viaje").Hidden = True
                .DisplayLayout.Bands(0).Columns("Usuario").Hidden = False
                .DisplayLayout.Bands(0).Columns("Ruta").Hidden = True
                .DisplayLayout.Bands(0).Columns("TipoVehiculo").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdTipoVehiculo").Hidden = True
                .DisplayLayout.Bands(0).Columns("Estado").Hidden = True
                .DisplayLayout.Bands(0).Columns("Carreta").Hidden = True
                .DisplayLayout.Bands(0).Columns("Tracto").Hidden = True
                .DisplayLayout.Bands(0).Columns("Piloto").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdPiloto").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdTrabajadorRecepciona").Hidden = True
                .DisplayLayout.Bands(0).Columns("TipoTRB").Hidden = True
                .DisplayLayout.Bands(0).Columns("Empresa").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdTipoDocumento").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdTracto").Hidden = True
                .DisplayLayout.Bands(0).Columns("TipoDocumento").Hidden = True
                .DisplayLayout.Bands(0).Columns("FechaLiquidacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("FechaReembolso").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdOperacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("Operacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("FecSalOrigen").Hidden = True
                .DisplayLayout.Bands(0).Columns("FecLleDestino").Hidden = True
                .DisplayLayout.Bands(0).Columns("Carga").Hidden = True
                .DisplayLayout.Bands(0).Columns("Ingreso").Header.Caption = "Egreso"
                .DisplayLayout.Bands(0).Columns("Egreso").Header.Caption = "Ingreso"
                .DisplayLayout.Bands(0).Columns("Descuento").Hidden = True
                .DisplayLayout.Bands(0).Columns("Usuario").Width = 250
                .DisplayLayout.Bands(0).Columns("RecibeBolsa").Width = 250
                .DisplayLayout.Bands(0).Columns("Ingreso").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(0).Columns("Egreso").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(0).Columns("Ingreso").Style = ColumnStyle.Double
                .DisplayLayout.Bands(0).Columns("Egreso").Style = ColumnStyle.Double
                .DisplayLayout.Bands(0).Columns("Voucher").Width = 90
            End With
            CalcularTotales(griMovimiento, "Ingreso", "Egreso")
            LlenarMontos(loMovimiento_Viaje_Detalle, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Private Sub LlenarMontos(ByVal loMovimiento As List(Of e_Movimiento_Viaje), ByVal Tipo As Integer)
        Try
            If loMovimiento.Count > 0 Then
                Dim a, b, c, d As Double
                a = 0 : b = 0 : c = 0 : d = 0
                For Each Lista As e_Movimiento_Viaje In loMovimiento
                    a += Lista.Egreso
                    If Lista.TipoTransa <> "6" Then b += Lista.Ingreso
                    c += Lista.GastosRendidos
                    If Tipo = 1 And Lista.TipoTransa = 1 Then
                        decImporte.Value = 0
                        If decSaldo.Value = 0 And decEgresos.Value > 0 Then
                            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
                            If txtEstado.Text = "HABILITADA" Or txtEstado.Text = "PENDIENTE" Then
                                etiLiquidar.Visible = True
                                btnLiquidar.Visible = True
                            End If
                        Else
                            If decImporte.Value = 0 Then
                                ControlBoton(0, 0, 0, 0, 1, 0, 0, 0, 1)
                            Else
                                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
                            End If

                        End If
                    End If
                Next
                decEgresos.Value = a
                decIngresos.Value = b
                decTotalGastos.Value = c
                decSaldo.Value = a - (b + c)
                If decSaldo.Value = 0 And txtEstado.Text <> "LIQUIDADA" Then
                    If txtEstado.Text <> gNombreEstadoReembolsado Then
                        etiLiquidar.Visible = True
                        btnLiquidar.Visible = True
                    End If
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ReporteFondoFijo()
        Try
            Dim frm As New frm_ReporteFondoFijo
            frm = frm.getInstancia()
            frm.MdiParent = frm_Menu
            frm.getInstancia()
            frm.Show()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub ListarGlosa(ByVal proceso As String)
        Try
            oeProcesoGlosa.ProcesoNegocio = proceso
            With griListaGlosa
                oeProcesoGlosa.Activo = 1
                .DataSource = olProcesoGlosa.Listar(oeProcesoGlosa)
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdProcesoNegocio").Hidden = True
                .DisplayLayout.Bands(0).Columns("ProcesoNegocio").Hidden = True
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True

                .DisplayLayout.Bands(0).Columns("ProcesoNegocio").Width = 300
                .DisplayLayout.Bands(0).Columns("Nombre").Width = 700

                .DisplayLayout.Bands(0).Columns("Nombre").Header.Caption = "Glosa"

                .DisplayLayout.Bands(0).Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect

                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                    .Rows.Item(0).Activated = True
                End If
            End With
            griListaGlosa.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
            griListaGlosa.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub ListarCuentaCorriente()
        Try
            oeCuentaCorriente = New e_CuentaCorriente
            oeCuentaCorriente.Tipooperacion = "0"
            loCC = New List(Of e_CuentaCorriente)
            loCA = New List(Of e_CuentaCorriente)
            oeCuentaCorriente.Activo = True
            loCuentaCorriente = olCuentaCorriente.Listar(oeCuentaCorriente).OrderBy(Function(item) item.Trabajador).ToList
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub LimpiarCuenta()
        decTotalGastos.Value = 0
        decIngresos.Value = 0
        decEgresos.Value = 0
        decSaldo.Value = 0
    End Sub

    Private Sub HabilitarFicha(ByVal tipo As Integer)
        Select Case tipo
            Case 1
                ficMovimientoDetalle.Tabs(0).Visible = True
                ficMovimientoDetalle.Tabs(2).Visible = True
                ficMovimientoDetalle.Tabs(3).Visible = True
                MostrarTabs(0, ficMovimientoDetalle, 0)
            Case 2
                ficMovimientoDetalle.Tabs(0).Visible = False
                ficMovimientoDetalle.Tabs(2).Visible = False
                ficMovimientoDetalle.Tabs(3).Visible = False
                ficMovimientoDetalle.Tabs(1).Enabled = True
        End Select
    End Sub

    Private Sub EditarMov()
        Try
            TipoAmp = 1
            idMovimiento = griLista.ActiveRow.Cells("IdMovimiento").Value
            idOperacion = griLista.ActiveRow.Cells("IdOperacion").Value
            idPilotoOriginal = griLista.ActiveRow.Cells("IdPiloto").Value
            IdViaje = griLista.ActiveRow.Cells("IdViaje").Value
            agrDatosViaje.Visible = True
            FicObservacion.Visible = True
            agrCuenta.Visible = True
            Agrupacion8.Enabled = True
            agrIEFF.Visible = True
            ExpGroupBoxReceptor.Visible = True
            ListarGlosa("PRESTAMO")
            If VerificarRegistroEditado() Then
                Ampliacion()
                If griLista.ActiveRow.Cells("Estado").Value = "REEMBOLSADO" Or griLista.ActiveRow.Cells("Estado").Value = "LIQUIDADA" Then
                    MostrarTabs(0, ficMovimientoDetalle, 0)
                    etiLiquidar.Visible = False
                    btnLiquidar.Visible = False
                    decImporte.Value = 0
                    decImporte.Enabled = False
                Else
                    opcVerPiloto.Checked = True
                End If
                ControlBoton(0, 0, 0, 0, 1, 0, 1, 1, 1)
                GuardarRegistroEditado()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub LimpiaPrestamo()
        cboTrabajadorPrestamo.SelectedIndex = -1
        cboViaje.DataSource = Nothing
        etiRuta.Text = String.Empty
        etiEstadoAsociado.Text = String.Empty
        etiFechaViajeAsociado.Text = String.Empty
        decSaldoViaje.Value = 0
        txtGlosaOrigen.Text = String.Empty
        txtGlosaDestino.Text = String.Empty
        decImportePrestamo.Value = 0
        decImportePrestamo.Refresh()
    End Sub

    Public Sub Liquidar(ByVal IdVia As String)
        Try
            Dim cadenas As String = ""
            Dim loMovLiquidacion As New List(Of e_Movimiento)
            oeMovimiento = New e_Movimiento
            oeMovimiento.TipoOperacion = "S"
            oeMovimiento.Id = IdVia
            loViajeAsociado = New List(Of e_Movimiento_Viaje)
            loViajeAsociado.AddRange(ListaViajesAsociados())
            If loViajeAsociado.Count > 1 Then
                For Each Lista As e_Movimiento_Viaje In loViajeAsociado
                    cadenas = cadenas & " " & Lista.Viaje
                Next
                Select Case MessageBox.Show("Existen viajes que no estan liquidadas. ¿Desea liquidar los viajes? " & cadenas, ". Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        For Each emovvia As e_Movimiento_Viaje In loViajeAsociado
                            oeMovimiento = New e_Movimiento()
                            oeMovimiento.Id = emovvia.IdViaje
                            oeMovimiento.TipoOperacion = "S"
                            loMovLiquidacion.Add(oeMovimiento)
                        Next
                    Case Windows.Forms.DialogResult.No
                        loMovLiquidacion.Add(oeMovimiento)
                End Select
            Else
                loMovLiquidacion.Add(oeMovimiento)
            End If
            If olMovimiento.LiquidarHabilitar(loMovLiquidacion) Then
                If loMovLiquidacion.Count = 1 Then
                    mensajeEmergente.Confirmacion("El viaje se liquidó exitosamente" & Me.Text)
                Else
                    mensajeEmergente.Confirmacion("Los viajes se liquidaron exitosamente" & Me.Text)
                End If
                ActualizaRegistroEditado()
                MostrarTabs(0, ficMovimiento)
                InicializarMovimientoViaje()
                etiLiquidar.Visible = False
                btnLiquidar.Visible = False
                Consultar(True)
                griLista.Focus()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function ListaViajesAsociados() As List(Of e_Movimiento_Viaje)
        Try
            Dim loListViaAsoc As New List(Of e_Movimiento_Viaje)
            oeViajeAsociado = New e_Movimiento_Viaje
            oeViajeAsociado.TipoOperacion = "3"
            oeViajeAsociado.IdOperacion = idOperacion
            oeViajeAsociado.VincularViajePiloto = "0"
            oeViajeAsociado.TipoTransa = "1"
            loListViaAsoc = olViajeAsociado.Listar(oeViajeAsociado)
            Return loListViaAsoc
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub DocumentosViajes()
        IdCuentaCte = BuscarIdCtaCte(idPiloto, 0, loCuentaCorriente) 'oeCuentaCorriente.Id
        IdViaje = txtViaje.Tag
        IndicadorIGV = False
        agrDatos.Expanded = True
        MostrarTabs(1, ficMovimiento, 1)
        MostrarTabs(1, ficMovimientoViaje, 1)
        CargarCombosRG()
        ListaGastoOperacion()
        numGasto.Value = Me.decTotalGastos.Value
        numAgregado.Value = Me.decTotalGastos.Value
        numCubrir.Value = decSaldo.Value 'numGasto.Value - numAgregado.Value
        aux2 = numCubrir.Value + numAgregado.Value
        agrDatoOperacion.Visible = IIf(oeMovimiento.TipoMovimiento = 1, False, True)
        fecHoraPeaje.Visible = False
        LimpiarDatoDetalle()
        fecPeriodo.Focus()
        fecPeriodo.SelectAll()
        ExpRegistroConsumoCombustible.Visible = False
        ' Inicializa_Calendario() 'Para la info del calendario
        Dim le1 As New List(Of e_CuentaCorriente)
        Dim le2 As New List(Of e_CuentaCorriente)
        le1 = loCuentaCorriente.ToList
        le2 = loCuentaCorriente.ToList
        'LlenarCombo(cboPilotoCV, "Trabajador", loCuentaCorriente, -1)
        'LlenarCombo(cboCopilotoCV, "Trabajador", le1, -1)
        'LlenarCombo(cboAyudanteCV, "Trabajador", le2, -1)
        'LimpiaCalendario(1)
        'LimpiaCalendario(2)
        'LimpiaCalendario(3)
        'Habilita_Vaiticos(False)
        'Inicializar_Viaticos()
        'If CCPiloto <> "" Then cboPilotoCV.Value = CCPiloto : CargaCalendar(1, CCPiloto)
        'If CCCopiloto <> "" Then cboCopilotoCV.Value = CCCopiloto : CargaCalendar(2, CCCopiloto)
        'If CCAyudante <> "" Then cboAyudanteCV.Value = CCAyudante : CargaCalendar(3, CCAyudante)
        'leGastoViatico = New List(Of e_GastoViatico)
        'agrCalendarioViatico.Expanded = False
        'agrCalendarioViatico.Visible = True
        expDocumento.Visible = False
        Modificado = False
        If txtEstado.Text <> gNombreEstadoReembolsado Then
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 0)
        Else
            ControlBoton(0, 0, 0, 0, 1, 0, 0, 1, 0)
        End If
        'Agregado By: Renzo
        'Obtener Cantidad de Peajes
        Dim loRuta As New List(Of e_Ruta)
        loRutaPeaje = New List(Of e_RutaPeaje)
        Dim olRuta As New l_Ruta
        loRuta.AddRange(olRuta.Listar(New e_Ruta With {.IdOrigen = idOrigen, _
                                                       .IdDestino = idDestino}))
        If loRuta.Count > 0 Then
            Dim olRutaPeaje As New l_RutaPeaje
            loRutaPeaje.AddRange(olRutaPeaje.Listar(New e_RutaPeaje With {.TipoOperacion = "GEN", _
                                                                          .IdRuta = loRuta(0).Id}))
            lblCantidadPeajes.Visible = True
            txtCantidadPeajes.Visible = True
            txtCantidadPeajes.Value = loRutaPeaje.Count
        End If
        dtpDesde.Value = fecFechaViaje.Value.Date.AddDays(-1)
        dtpHasta.Value = dtpDesde.Value.Date.AddDays(3)
        loTarjetaMovimiento = New List(Of e_TarjetaMovimiento)
        With griMovTarjeta
            .DataSource = loTarjetaMovimiento
            .DataBind()
            .Text = ""
        End With
        expTarjetaMovimiento.Expanded = False
    End Sub

    Public Sub InicializarComboProveedor()
        Try
            Me.cboProveedores.ValueMember = "Id"
            Me.cboProveedores.DisplayMember = "Nombre"
            With cboProveedores.DisplayLayout.Bands(0)
                '.Columns("Id").Hidden = True
                .Columns("Codigo").Hidden = True
                .Columns("TipoPersonaEmpresa").Hidden = True
                .Columns("IdPersona").Hidden = True
                .Columns("IdEmpresa").Hidden = True
                .Columns("FechaActividad").Hidden = True
                .Columns("UsuarioCreacion").Hidden = True
                .Columns("Activo").Hidden = True
                .Columns("Seleccion").Hidden = True
                .Columns("Email").Hidden = True
                .Columns("Contacto").Hidden = True
                .Columns("NroDocumento").Header.Caption = "RUC/DNI"
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ActualizarDatosFecha()
        fecHasta.Value = Date.Today
        fecDesde.Value = Date.Today.AddDays(-5)
    End Sub

    Private Sub Editar2()
        If griLista.Selected.Rows.Count > 0 Then
            etiLiquidar.Visible = False
            btnLiquidar.Visible = False
            If griLista.ActiveRow.Cells("Estado").Value <> "PENDIENTE" Then
                DobleClick = 1
                Me.decImportePrestamo.ReadOnly = False
                Me.agrIEFF.Visible = True
                EditarMov()
                If griLista.ActiveRow.Cells("Estado").Value = "LIQUIDADA" Or griLista.ActiveRow.Cells("Estado").Value = "REEMBOLSADO" Then
                    btnPrestamos.Visible = False
                    btnDescuento.Visible = False
                Else
                    btnPrestamos.Visible = True
                    btnDescuento.Visible = True
                    If decSaldo.Value = 0 Then etiLiquidar.Visible = True : btnLiquidar.Visible = True
                End If
            End If
            decImporte.Focus()
            decImporte.SelectAll()
        End If
    End Sub

    Private Sub ActualizaViajes()
        'Dim otemp As New e_Trabajador
        With cboTrabajadorPrestamo
            If .SelectedIndex > -1 Then
                Dim i As Integer = .SelectedIndex
                'oetemp(Id, NombreCompleto) {e_Trabajador}
                Dim otemp = .Items(i).ListObject
                CargaComboViajePiloto(otemp.Id)
                oeMovimientoPrestamo.IdCuentaCorrienteDestino = BuscarIdCtaCte(otemp.Id, 0, loCuentaCorriente)
            End If
        End With
    End Sub

    'Private Sub CargarAsientoModelo()
    '    Try
    '        AsientoModelo() 
    '        dtReferencia = GeneraDTRef(loReferencia)
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub

    'Private Sub AsientoModelo()
    '    oeAsientoModelo = New e_AsientoModelo
    '    loAsientoModelo = New List(Of e_AsientoModelo)
    '    oeAsientoModelo.TipoOperacion = "A" : oeAsientoModelo.Activo = True : oeAsientoModelo.Nombre = pIdActividadNegocio
    '    loAsientoModelo = olAsientoModelo.Listar(oeAsientoModelo)

    '    oeReferencia = New e_AsientoModelo_Referencia
    '    loReferencia = New List(Of e_AsientoModelo_Referencia)
    '    oeReferencia.TipoOperacion = "N" : oeReferencia.Activo = True : oeReferencia.IdReferencia = pIdActividadNegocio
    '    loReferencia = olReferencia.Listar(oeReferencia)
    'End Sub

    'Public Sub ObtenerAsientoModelo(IdTipoDocumento As String, IdMoneda As String)
    '    Try
    '        Dim dtAux = New Data.DataTable
    '        Dim _rwAux() As Data.DataRow
    '        Dim cadSQL As String = String.Empty
    '        cadSQL = "TipoRef1 = 4 AND IdRef1 = '" & IdMoneda & "' AND TipoRef2 = 5 AND IdRef2 = '" & IdTipoDocumento & "'"
    '        _rwAux = dtReferencia.Select(cadSQL, "")
    '        If _rwAux.Count = 0 Then Throw New Exception("Error en el Modelo de Asiento Contable. Verificar")
    '        dtAux = _rwAux.CopyToDataTable
    '        oeAsientoModeloGastos = New e_AsientoModelo
    '        oeAsientoModeloGastos.TipoOperacion = "" : oeAsientoModeloGastos.Activo = True
    '        oeAsientoModeloGastos.Id = dtAux.Rows(0).Item("IdAsientoModelo").ToString
    '        oeAsientoModeloGastos = olAsientoModelo.Obtener(oeAsientoModeloGastos)
    '        'oeGastoOperacion.loAsientoModelo.Add(oeAsientoModeloGastos)
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub

#End Region

#Region "Eventos"

    Private Sub numImporte_Click(sender As Object, e As EventArgs) Handles numImporte.Click
        numImporte.SelectAll()
    End Sub

    Private Sub decImporte_Click(sender As Object, e As EventArgs) Handles decImporte.Click
        decImporte.SelectAll()
    End Sub

    Private Sub decImportePrestamo_Click(sender As Object, e As EventArgs) Handles decImportePrestamo.Click
        decImportePrestamo.SelectAll()
    End Sub

    Private Sub decImporteDescuento_Click(sender As Object, e As EventArgs) Handles decImporteDescuento.Click
        decImporteDescuento.SelectAll()
    End Sub

    Private Sub frm_Movimiento_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Select Case ficMovimiento.SelectedTab.Index
            Case 0
                Select Case ficTipoMovimiento.SelectedTab.Index
                    Case 0
                        ControlBoton(1)
                    Case 1
                        If Not IndCajaPrincipal Then
                            ControlBoton(1, 0, 0, 0, 1, 0, 0, 1, 1)
                        Else
                            If expIngresoFF.Expanded Then
                                ControlBoton(1, 0, 0, 1, 1, 0, 0, 1, 1)
                            Else
                                ControlBoton(1, 0, 0, 0, 1, 0, 0, 1, 1)
                            End If
                        End If
                End Select
            Case 1
                Select Case ficMovimientoViaje.SelectedTab.Index
                    Case 0
                        Select Case ficMovimientoDetalle.SelectedTab.Index
                            Case 0
                                If IndCajaPrincipal Then
                                    If decImporte.Value > 0 Then
                                        ControlBoton(0, 0, 0, 1, 1, 0, 1, 0, 1)
                                    ElseIf decSaldoCuenta.Value > 0 Then
                                        ControlBoton(0, 0, 0, 1, 1, 0, 1, 0, 1)
                                    ElseIf Me.decHabEfectivo.Value > 0 Then
                                        ControlBoton(0, 0, 0, 1, 1, 0, 1, 0, 1)
                                    Else
                                        ControlBoton(0, 0, 0, 0, 1, 0, 1, 0, 1)
                                    End If
                                Else
                                    If decImporte.Value > 0 Then
                                        ControlBoton(0, 0, 0, 1, 1, 0, 1, 0, 1)
                                    Else
                                        ControlBoton(0, 0, 0, 0, 1, 0, 1, 0, 1)
                                    End If
                                End If
                            Case 1
                                If decImportePrestamo.Value <= decSaldo.Value And decImportePrestamo.Value > 0 Then
                                    decImportePrestamo.Appearance.BackColor = Color.LightBlue
                                    ToolTip.Enabled = False
                                    ControlBoton(0, 0, 0, 1, 1, 0, 1, 0, 1)
                                Else
                                    decImportePrestamo.Appearance.BackColor = Color.IndianRed
                                    ToolTip.Enabled = True
                                    Dim ToolTipInfo As New UltraWinToolTip.UltraToolTipInfo
                                    ToolTipInfo.ToolTipTitle = "Información del Sistema"
                                    ToolTipInfo.ToolTipText = "El importe de prestamo supera al Saldo"
                                    ToolTipInfo.ToolTipImage = ToolTipImage.Warning
                                    ToolTip.SetUltraToolTip(decImportePrestamo, ToolTipInfo)
                                    ControlBoton(0, 0, 0, 0, 1, 0, 0, 0, 1)
                                End If
                            Case 2
                                If decImporteDescuento.Value > 0 Then
                                    ControlBoton(0, 0, 0, 1, 1)
                                Else
                                    ControlBoton(0, 0, 0, 0, 1)
                                End If
                        End Select
                    Case 1
                        If TipoMov = 1 Then
                            If txtEstado.Text = gNombreEstadoReembolsado Then
                                ControlBoton(0, 0, 0, 0, 1)
                            Else
                                ControlBoton(0, 0, 0, 1, 1)
                            End If
                        Else
                            ControlBoton(0, 0, 0, 1, 1)
                        End If
                End Select
        End Select
    End Sub

    Private Sub ficMovimientoViaje_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles ficMovimientoViaje.SelectedTabChanged
        If Me.ficMovimientoViaje.SelectedTab.Index = 0 Then
            Me.agrDefinicion.Controls.Add(Me.agrDatosViaje)
            Me.agrDatosViaje.Location = New System.Drawing.Point(544, 5)
            FicObservacion.Visible = True
        Else
            If TipoMov = 1 Then
                Me.agrContenedor1.Controls.Add(Me.agrDatosViaje)
                Me.agrDatosViaje.Location = New System.Drawing.Point(816, 5)
            End If
            FicObservacion.Visible = False
        End If
    End Sub

    Private Sub decHabEfectivo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decHabEfectivo.ValueChanged
        If IsDBNull(decHabEfectivo.Value) Then decHabEfectivo.Value = 0.0
        If decHabEfectivo.Value > 0 Then
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
        Else
            ControlBoton(0, 0, 0, 0, 1, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_Movimiento_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        ActualizaRegistroEditado()
        instancia = Nothing
    End Sub

    Private Sub frm_Movimiento_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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
        ActualizaRegistroEditado()
    End Sub

    Private Sub frm_Movimiento_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Try
            Select Case ficMovimiento.SelectedTab.Index
                Case 0
                Case 1
                    Select Case ficMovimientoViaje.SelectedTab.Index
                        Case 1
                            Select Case e.KeyCode
                                Case Keys.Enter
                                    SendKeys.Send("{TAB}")
                            End Select
                    End Select
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_Movimiento_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            gf_AsignarEventoSeleccionarTexto(Me)
            ColorPendiente.Color = Color.LightGreen
            ColorHabilitada.Color = Color.LemonChiffon
            ColorLiquidada.Color = Color.NavajoWhite
            ColorNoReembolsado.Color = Color.Azure
            ColorReembolsado.Color = Color.RosyBrown
            fechaMovimiento.Value = Date.Now
            opcDefinicion.CheckedIndex = 0
            ActualizarDatosFecha()
            ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
            fecPeriodo.Value = ObtenerFechaServidor()
            txtCodViaje.Focus()
            fecHoraPeaje.Value = Date.Parse("01/01/1901").Date
            MostrarTabs(0, ficMovimiento)
            MostrarTabs(0, ficMovimientoDetalle)
            LlenaCombos()
            LlenaCombosTrabajadores()
            LlenaComboTrabajadorMovimiento()
            LlenaComboProveedor()
            ListarUsuarioCaja()
            btnReporteFondoFijo.Visible = IIf(IndCajaPrincipal, True, False)
            If olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "HAB BOLSA VIAJE") Then
                ficTipoMovimiento.Tabs(1).Enabled = True
            Else
                ficTipoMovimiento.Tabs(1).Enabled = False
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub oeMovimiento_Viaje_DatoCambiado() Handles oeMovimiento_Viaje.DatoCambiado
        oeMovimiento_Viaje.Modificado = True
    End Sub

    Private Sub oeMovimiento_DatoCambiado() Handles oeMovimiento.DatoCambiado
        oeMovimiento.Modificado = True
    End Sub

    Private Sub oeMovimientoDescuento_DatoCambiado() Handles oeMovimientoDescuento.DatoCambiado
        oeMovimientoDescuento.Modificado = True
    End Sub

    Private Sub oeMovimientoPrestamo_DatoCambiado() Handles oeMovimientoPrestamo.DatoCambiado
        oeMovimientoPrestamo.Modificado = True
    End Sub

    Private Sub opcDefinicion_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opcDefinicion.ValueChanged
        If opcDefinicion.CheckedIndex = -1 Then
            cboCaja.Enabled = False
        ElseIf opcDefinicion.CheckedIndex = 0 Then
            cboCaja.Enabled = False
        ElseIf opcDefinicion.CheckedIndex = 1 Then
            cboCaja.Enabled = False
        End If
    End Sub

    Private Sub fechaMovimiento_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fechaMovimiento.ValueChanged, _
                                                                                                        fechaMovimiento.KeyDown, fechaMovimiento.GotFocus
        oeMovimiento.Fecha = fechaMovimiento.Value
    End Sub

    Private Sub decImporte_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decImporte.ValueChanged
        If IsDBNull(decImporte.Value) Then decImporte.Value = 0.0
        If decSaldo.Value = 0 And decEgresos.Value > 0 Then
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
            etiLiquidar.Visible = True
            btnLiquidar.Visible = True
        Else
            If IsNumeric(decImporte.Value) Then
                If decImporte.Value = 0 Then
                    ControlBoton(0, 0, 0, 0, 1, 0, 0, 0, 1)
                Else
                    ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
                End If
            End If
        End If
        If decImporte.Value > decSaldo.Value Then
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
        Else
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
        End If
        If IsNumeric(decImporte.Value) Then
            oeMovimiento.Egreso = decImporte.Value
            oeMovimiento.Saldo = decImporte.Value
        End If
    End Sub

    Private Sub griGastoOperacion_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griGastoOperacion.AfterCellUpdate
        Try
            With griGastoOperacion
                If .ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                    Select Case e.Cell.Column.Key
                        Case "Glosa", "IdFlujoCaja"
                            Dim oeGO As New e_GastoOperacion
                            oeGO = griGastoOperacion.ActiveRow.ListObject
                            If oeGO.TipoOperacion <> "I" Then
                                oeGO = leGastoOperacion.Item(leGastoOperacion.IndexOf(oeGO))
                                oeGO.TipoOperacion = "A"
                            End If
                    End Select
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtGlosa_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGlosa.GotFocus
        txtGlosa.Text = txtGlosa.Text.Trim
    End Sub

    Private Sub txtGlosa_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGlosa.ValueChanged
        oeMovimiento.Glosa = txtGlosa.Text
    End Sub

    Private Sub fechaRecibidor_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fechaRecibidor.ValueChanged, _
                                                                                                fechaRecibidor.KeyDown, fechaRecibidor.GotFocus
        oeMovimiento_Viaje.FechaRecepcion = fechaRecibidor.Value
    End Sub

    Private Sub opcTipoMovimiento_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opcTipoMovimiento.ValueChanged
        Select Case opcTipoMovimiento.CheckedIndex
            Case 0
                oeMovimiento.TipoMovimiento = 1
            Case 1
                oeMovimiento.TipoMovimiento = 2
            Case 2
                oeMovimiento.TipoMovimiento = 3
        End Select
    End Sub

    Private Sub opcVerRecibidor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opcVerPiloto.CheckedChanged, opcVerAyudante.CheckedChanged, opcVerCopiloto.CheckedChanged, opcVerOtro.CheckedChanged
        Try
            oeTrabajador.InicializaTrabajador()
            If opcVerPiloto.Checked Then
                oeMovimiento_Viaje.IdTrabajadorRecepciona = idPiloto
                oeMovimiento_Viaje.TipoTRB = "P"
                cboTrabajador.Visible = False
                etiFechaRecepcion.Visible = False
                fechaRecibidor.Visible = False
                oeTrabajador = New e_Trabajador
                oeTrabajador.Id = idPiloto
                oeTrabajador.CargaCompleto = False
                oeTrabajador = olTrabajador.Obtener(oeTrabajador)
                ExpGroupBoxReceptor.Expanded = True
            End If
            If opcVerCopiloto.Checked Then
                If idCopiloto = "" Then
                    mensajeEmergente.Problema("No se encuentra copiloto asociado al viaje", True)
                    opcVerPiloto.Checked = True
                End If
                oeMovimiento_Viaje.IdTrabajadorRecepciona = idCopiloto
                oeMovimiento_Viaje.TipoTRB = "C"
                cboTrabajador.Visible = False
                etiFechaRecepcion.Visible = False
                fechaRecibidor.Visible = False
                oeTrabajador = New e_Trabajador
                oeTrabajador.Id = idCopiloto
                oeTrabajador.CargaCompleto = False
                oeTrabajador = olTrabajador.Obtener(oeTrabajador)
                ExpGroupBoxReceptor.Expanded = True
            End If
            'If Not String.IsNullOrEmpty(oeTrabajador.oePersona.Dni) Then picRecibidor.Image = olPersona.Foto(oeTrabajador.oePersona.Dni)
            If opcVerOtro.Checked Then
                picRecibidor.Image = Nothing
                cboTrabajador.Visible = True
                etiFechaRecepcion.Visible = True
                fechaRecibidor.Visible = True
                cboTrabajador.Value = idPiloto
                oeMovimiento_Viaje.TipoTRB = "O"
                ExpGroupBoxReceptor.Expanded = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboCaja_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCaja.ValueChanged
        oeMovimiento.IdCaja = cboCaja.Value
    End Sub

    Private Sub griMovimiento_AfterCellActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griMovimiento.AfterCellActivate
        Try
            If UltraExpandableGroupBoxMovCuenta.Expanded = True AndAlso griMovimiento.ActiveRow.Index > -1 Then
                Select Case griMovimiento.ActiveCell.Row.Cells("TipoTRB").Value.ToString
                    Case "P"
                        opcVerPiloto.Checked = True
                    Case "C"
                        opcVerCopiloto.Checked = True
                    Case "A"
                        opcVerAyudante.Checked = True
                    Case "O"
                        'opcVerOtro.Checked = True
                        'cboTrabajador.Value = griMovimiento.ActiveCell.Row.Cells("IdTrabajadorRecepciona").Value.ToString
                End Select
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnPrestamos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrestamos.Click
        Try
            If olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "LIQUIDACION") Then
                Me.decImporte.Value = 0
                ExpGroupBoxReceptor.Expanded = False
                MostrarTabs(1, ficMovimientoDetalle)
                Me.agrCuenta.Visible = True
                agrIEFF.Visible = True
                Agrupacion8.Enabled = True
                fechaPrestamo.Value = Date.Now
                Dim a As String = cboViaje.Value
                oeMovimientoPrestamo.IdCuentaCorrienteOrigen = BuscarIdCtaCte(idPiloto, 0, loCuentaCorriente)
                cboTrabajadorPrestamo.Value = idPiloto
                decImportePrestamo.Value = decSaldo.Value
                oeMovimientoPrestamo.Fecha = ObtenerFechaServidor()
                oeMovimientoPrestamo.TipoTransa = "3"
                oeMovimientoPrestamo.UsuarioCreacion = gUsuarioSGI.Id
                oeMovimientoPrestamo.IdEstado = ""
                Me.decImportePrestamo.Value = Me.decSaldo.Value
                ListarGlosa("PRESTAMO")
                cboViaje.Enabled = True
                cboTrabajadorPrestamo.Focus()
                cboTrabajadorPrestamo.SelectAll()
                ActualizaViajes()
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
            Else
                Throw New Exception("No Tiene Permisos para Prestar Entre Conductores")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnDescuento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDescuento.Click
        Try
            Me.decImporte.Value = 0
            ExpGroupBoxReceptor.Expanded = False
            MostrarTabs(2, ficMovimientoDetalle)
            decImporteDescuento.Value = decSaldo.Value
            txtPilotoDescuento.Text = txtPiloto.Text
            fecFechaDescuento.Value = Date.Now
            MostrarTabs(0, FicTrabajadorDescuento, 1)
            opcTrabajadorDescuento.CheckedIndex = 0
            opcTrabajadorDescuento_ValueChanged(opcTrabajadorDescuento, e)
            ListarGlosa("DESCUENTO")
            Dim loConcepto As New List(Of e_Concepto_Prestamo)
            Dim olConcepto As New l_Concepto_Prestamo
            loConcepto.AddRange(olConcepto.Listar(New e_Concepto_Prestamo With {.TipoOperacion = "R"}))
            ComboNormal(cboConceptoDsct, loConcepto, -1)
            If CType(cboConceptoDsct.DataSource, List(Of e_Concepto_Prestamo)).Count > 0 Then
                cboConceptoDsct.Value = IdCBolsaViaje
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub FicTrabajadorDescuento_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles FicTrabajadorDescuento.SelectedTabChanged
        Select Case opcTrabajadorDescuento.CheckedIndex
            Case 0
                oeMovimientoDescuento.IdCuentaCorrienteDestino = BuscarIdCtaCte(idPiloto, 0, loCuentaCorriente)
                txtGlosaDescuento.Text = "DESCUENTO AL TRABAJADOR: " & txtPilotoDescuento.Text & ", FECHA: " & fecFechaDescuento.Value
            Case 1
                oeMovimientoDescuento.IdCuentaCorrienteDestino = BuscarIdCtaCte(idCopiloto, 0, loCuentaCorriente)
                txtGlosaDescuento.Text = "DESCUENTO AL TRABAJADOR: " & txtCopilotoDescuento.Text & ", FECHA: " & fecFechaDescuento.Value
            Case 2
                oeMovimientoDescuento.IdCuentaCorrienteDestino = BuscarIdCtaCte(idAyudante, 0, loCuentaCorriente)
                txtGlosaDescuento.Text = "DESCUENTO AL TRABAJADOR: " & txtAyudanteDescuento.Text & ", FECHA: " & fecFechaDescuento.Value
        End Select
    End Sub

    Private Sub opcTrabajadorDescuento_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opcTrabajadorDescuento.ValueChanged
        If opcTrabajadorDescuento.CheckedIndex = 0 Then
            txtGlosaDescuento.Text = "DESCUENTO AL TRABAJADOR: " & txtPilotoDescuento.Text & ", FECHA: " & fecFechaDescuento.Value
            oeMovimientoDescuento.IdCuentaCorrienteDestino = BuscarIdCtaCte(idPiloto, 0, loCuentaCorriente)
        ElseIf opcTrabajadorDescuento.CheckedIndex = 1 And txtCopilotoDescuento.Text <> "NINGUNO" Then
            txtGlosaDescuento.Text = "DESCUENTO AL TRABAJADOR: " & txtCopilotoDescuento.Text & ", FECHA: " & fecFechaDescuento.Value
            oeMovimientoDescuento.IdCuentaCorrienteDestino = BuscarIdCtaCte(idCopiloto, 0, loCuentaCorriente)
        ElseIf opcTrabajadorDescuento.CheckedIndex = 2 And txtAyudanteDescuento.Text <> "NINGUNO" Then
            txtGlosaDescuento.Text = "DESCUENTO AL TRABAJADOR: " & txtAyudanteDescuento.Text & ", FECHA: " & fecFechaDescuento.Value
            oeMovimientoDescuento.IdCuentaCorrienteDestino = BuscarIdCtaCte(idAyudante, 0, loCuentaCorriente)
        ElseIf opcTrabajadorDescuento.CheckedIndex <> -1 Then
            opcTrabajadorDescuento.CheckedIndex = 0
            mensajeEmergente.Problema("No Existe Trabajador para Aplicar Descuento", True)
        End If
    End Sub

    Private Sub cboViaje_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboViaje.ValueChanged
        Try
            Dim oeTemp As New e_Movimiento_Viaje
            etiRutaPrestamo.Text = String.Empty
            decSaldoViaje.Value = 0
            etiEstadoAsociado.Text = String.Empty
            etiFechaViajeAsociado.Text = String.Empty
            oeMovimiento_Viaje = New e_Movimiento_Viaje
            idMovimiento = String.Empty
            Dim id As String
            id = cboViaje.Value
            With cboViaje
                If .SelectedIndex > -1 Then
                    Dim i As Integer = .SelectedIndex
                    oeTemp = .Items(i).ListObject
                    etiRutaPrestamo.Text = oeTemp.Ruta
                    decSaldoViaje.Value = oeTemp.SaldoTotal
                    idViajePrestamo = oeTemp.IdViaje
                    etiCarga.Text = oeTemp.Carga
                    etiFecLleDestino.Text = oeTemp.FecLleDestino
                    etiFecSalOrigen.Text = oeTemp.FecSalOrigen
                    etiEstadoAsociado.Text = oeTemp.Estado
                    etiFechaViajeAsociado.Text = oeTemp.Fecha
                    idMovimiento = oeTemp.IdMovimiento
                    If cboTrabajadorPrestamo.Text <> "" And griListaGlosa.Rows.Count > 0 Then
                        txtGlosaOrigen.Text = griListaGlosa.Rows(8).Cells("Nombre").Value.ToString & " " & cboTrabajadorPrestamo.Text & " " & cboViaje.Text
                        txtGlosaDestino.Text = griListaGlosa.Rows(9).Cells("Nombre").Value.ToString & " " & Me.txtPiloto.Text & " " & txtViaje.Text
                    End If
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub fechaPrestamo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fechaPrestamo.ValueChanged, fechaPrestamo.KeyDown, _
                                                                                                                fechaPrestamo.GotFocus
        oeMovimientoPrestamo.Fecha = fechaPrestamo.Value
    End Sub

    Private Sub decImportePrestamo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decImportePrestamo.ValueChanged
        Try
            If IsDBNull(decImportePrestamo.Value) Then decImportePrestamo.Value = 0.0
            Dim _saldo As Double = decSaldo.Value
            If decImportePrestamo.Value <= _saldo And decImportePrestamo.Value > 0 Then
                oeMovimientoPrestamo.Ingreso = decImportePrestamo.Value
                oeMovimientoPrestamo.Egreso = decImportePrestamo.Value
                decImportePrestamo.Appearance.BackColor = Color.LightBlue
                ToolTip.Enabled = False
                ControlBoton(0, 0, 0, 1, 1, 0, 1, 0, 1)
            Else
                decImportePrestamo.Appearance.BackColor = Color.IndianRed
                'Agregado para tool
                ToolTip.Enabled = True
                Dim ToolTipInfo As New UltraWinToolTip.UltraToolTipInfo
                ToolTipInfo.ToolTipTitle = "Información del Sistema"
                ToolTipInfo.ToolTipText = "El importe de prestamo supera al Saldo"
                ToolTipInfo.ToolTipImage = ToolTipImage.Warning
                ToolTip.SetUltraToolTip(decImportePrestamo, ToolTipInfo)
                'fin
                ControlBoton(0, 0, 0, 0, 1, 0, 0, 0, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griLista_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griLista.InitializeLayout
        e.Layout.Grid.CalcManager = UltraCalcManager
    End Sub

    Private Sub griListaGlosa_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griListaGlosa.InitializeLayout
        e.Layout.Grid.CalcManager = Nothing
    End Sub

    Private Sub griGastoOperacion_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griGastoOperacion.InitializeLayout
        e.Layout.Grid.CalcManager = UltraCalcManager
    End Sub

    Private Sub btnDocumentos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDocumentos.Click
        Try
            If olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "LIQUIDACION") Then
                Me.decImporte.Value = 0
                If Me.txtCarga.Text = "VACIO" Then
                    If MessageBox.Show("Desea Liquidar el Viaje Vacío?: " & Me.txtViaje.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) = Windows.Forms.DialogResult.Yes Then
                        DocumentosViajes()
                    End If
                Else
                    DocumentosViajes()
                End If
            Else
                Throw New Exception("No Tiene Permisos para Ingresar Gastos a los Viajes")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboTrabajadorMovimiento_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTrabajadorMovimiento.GotFocus
        cboTrabajadorMovimiento.SelectAll()
    End Sub

    Private Sub cboTrabajadorMovimiento_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTrabajadorMovimiento.ValueChanged, _
                                                                                                         cboTrabajadorMovimiento.SelectionChangeCommitted
        Dim oeTemp As New e_CuentaCorriente
        With cboTrabajadorMovimiento
            If .SelectedIndex > -1 Then
                Dim i As Integer = .SelectedIndex
                oeTemp = .Items(i).ListObject
                idTrabajador = oeTemp.IdTrabajador
                idCuentaTrabajador = oeTemp.Id
                etiTrabajadorCuenta.Text = "Trabajador - Cuenta: " & oeTemp.TipoCuenta
            End If
        End With
        oeMovimiento_Viaje.IdPiloto = idTrabajador
    End Sub

    Private Sub cboTracto_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTracto.ValueChanged
        oeMovimiento_Viaje.IdTracto = cboTracto.Value
    End Sub

    Private Sub decImporteDescuento_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decImporteDescuento.ValueChanged
        If IsDBNull(decImporteDescuento.Value) Then decImporteDescuento.Value = 0.0
        If Math.Round(decImporteDescuento.Value, 2) <= Math.Round(decSaldo.Value, 2) And decImporteDescuento.Value > 0 Then
            oeMovimientoDescuento.Ingreso = decImporteDescuento.Value
            oeMovimientoDescuento.Saldo = decImporteDescuento.Value
            ToolTip.Enabled = False
            decImporteDescuento.Appearance.BackColor = Color.LightBlue
            ControlBoton(0, 0, 0, 1, 1, 0, 1, 0, 0)
        Else
            decImporteDescuento.Appearance.BackColor = Color.IndianRed
            'Agregado para tool
            ToolTip.Enabled = True
            Dim ToolTipInfo As New UltraWinToolTip.UltraToolTipInfo
            ToolTipInfo.ToolTipTitle = "Información del Sistema"
            ToolTipInfo.ToolTipText = "El importe de descuento supera al Saldo"
            ToolTipInfo.ToolTipImage = ToolTipImage.Warning
            ToolTip.SetUltraToolTip(decImporteDescuento, ToolTipInfo)
            'fin
            ControlBoton(0, 0, 0, 0, 1, 0, 1, 0, 0)
        End If

    End Sub

    Private Sub fecFechaDescuento_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecFechaDescuento.ValueChanged, _
                                                                                                            fecFechaDescuento.KeyDown, fecFechaDescuento.GotFocus
        oeMovimientoDescuento.Fecha = fecFechaDescuento.Value
    End Sub

    Private Sub txtGlosaDescuento_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGlosaDescuento.ValueChanged
        oeMovimientoDescuento.Glosa = txtGlosaDescuento.Text
    End Sub

    Private Sub ficMovimientoDetalle_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles ficMovimientoDetalle.SelectedTabChanged
        Select Case ficMovimientoDetalle.SelectedTab.Index
            Case 0 'MOVIMIENTO 
                ControlBoton(0, 0, 0, 0, 1, 0, 1, 0, 0)
                expGlosa.Visible = False
            Case 1, 2 ' PRESTAMO
                ControlBoton(0, 0, 0, 1, 1, 0, 1, 0, 0)
                expGlosa.Visible = True
                expGlosa.Expanded = False
                verGlosaOrigen.Checked = False
                verGlosaDestino.Checked = False
        End Select
    End Sub

    Private Sub griMovimiento_AfterRowActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griMovimiento.AfterRowActivate
        'If griMovimiento.Rows.Count > 0 AndAlso griMovimiento.ActiveRow.Cells("voucher").Value.ToString <> "" Then
        '    If decSaldo.Value = 0 And decEgresos.Value > 0 And txtEstado.Text = "HABILITADA" Then
        '        ControlBoton(0, 0, 0, 1, 1, 0, 1, 0, 1)
        '        etiLiquidar.Visible = True
        '        btnLiquidar.Visible = True
        '    Else
        '        If decImporte.Value = 0 Then
        '            ControlBoton(0, 0, 0, 0, 1, 0, 1, 0, 1)
        '        Else
        '            ControlBoton(0, 0, 0, 1, 1, 0, 1, 0, 1)
        '        End If
        '    End If|
        'End If
    End Sub

    Private Sub btnReporteFondoFijo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReporteFondoFijo.Click
        ReporteFondoFijo()
    End Sub

    Private Sub txtCodViaje_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodViaje.KeyPress
        Try
            If txtCodViaje.Text.Trim <> "" Then
                Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
                KeyAscii = CShort(SoloNumeros(KeyAscii))
                If KeyAscii = 0 Then
                    e.Handled = True
                End If
                Dim ea As New System.EventArgs
                If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                    txtCodViaje_Validated(txtCodViaje, ea)
                    If CInt(txtCodViaje.Text) > 0 Then Listar(True)
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtCodViaje_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodViaje.Validated
        Try
            If txtCodViaje.Text <> "" Then
                If CInt(txtCodViaje.Text) > 0 Then txtCodViaje.Text = FormatoDocumento(txtCodViaje.Text.Trim, 12)
                txtCodViaje.Update()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Dim IdTra As String = ""

    Private Sub FicTipoMovimiento_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles ficTipoMovimiento.SelectedTabChanged
        Try
            Select Case ficTipoMovimiento.SelectedTab.Index
                Case 0
                    TipoMov = 1
                    agrDatoOperacion.Visible = False
                    agrDatos.Expanded = False
                    Me.fecDesde.Visible = True
                    Me.fecHasta.Visible = True
                    Me.Etiqueta50.Visible = True
                    Me.Etiqueta51.Visible = True
                    cboTracto.Visible = True
                    etitracto.Visible = True
                    chkViajeVacio.Visible = True
                    grupoEstado.Visible = True
                    etiViaje.Visible = True
                    txtCodViaje.Visible = True
                    etiEstado.Visible = True
                    cboEstadoViaje.Visible = True
                    idCuentaTrabajador = ""
                    cboTrabajadorMovimiento.Value = ""
                    Me.chkBuscarCopiloto.Visible = True
                    'Nuevo Codigo 04/06/2012
                    cboTrabajadorMovimiento.DataSource = New List(Of e_CuentaCorriente)
                    LlenarCombo(cboTrabajadorMovimiento, "Trabajador", loCC, -1)
                    cboTrabajadorMovimiento.Enabled = True
                    agrSaldo.Visible = False
                    agrGastosAdm.Visible = False
                    agrVales.Visible = False
                    agrTotalFF.Visible = False
                    agrOtrosIngresos.Visible = False
                    txtCodViaje.Focus()
                    btnReporteFondoFijo.Visible = IIf(IndCajaPrincipal, True, False)
                    cboTrabajadorMovimiento.Text = IdTra
                    ControlBoton(1, 0, 0, 0, 1, 0, 0, 0, 1)
                Case 1
                    IdTra = cboTrabajadorMovimiento.Text
                    TipoMov = 2
                    oeGastoOperacion.IdViaje = ""
                    agrDatoOperacion.Visible = True
                    agrDatos.Expanded = False
                    cboTracto.Visible = False
                    etitracto.Visible = False
                    etiViaje.Visible = False
                    chkViajeVacio.Visible = False
                    txtCodViaje.Visible = False
                    grupoEstado.Visible = False
                    etiEstado.Visible = False
                    cboEstadoViaje.Visible = False
                    Me.chkBuscarCopiloto.Visible = False
                    Me.expDocumento.Visible = True
                    Me.fecDesde.Visible = True
                    Me.fecHasta.Visible = True
                    Me.Etiqueta50.Visible = False
                    Me.Etiqueta51.Visible = False
                    If loCuentaCorriente.Count > 0 Then
                        Dim oeTemp As New e_CuentaCorriente
                        oeTemp.IdTrabajador = gUsuarioSGI.IdTrabajador
                        oeTemp.Tipo = 1
                        Dim index As Integer = loCuentaCorriente.IndexOf(oeTemp)
                        If index <> -1 Then
                            oeTemp = loCuentaCorriente.Item(loCuentaCorriente.IndexOf(oeTemp))
                            cboTrabajadorMovimiento.DataSource = New List(Of e_CuentaCorriente)
                            LlenarCombo(cboTrabajadorMovimiento, "Trabajador", loCA, -1)
                            CuentaAdm = oeTemp.Id
                            cboTrabajadorMovimiento.Value = CuentaAdm
                        Else
                            mensajeEmergente.Problema("Se debe Habilitar Cuenta Corriente de Usuario.")
                        End If
                    End If
                    If Not IndCajaPrincipal Then
                        cboTrabajadorMovimiento.Enabled = False
                    Else
                        Me.expIngresoFF.Visible = True
                        Me.expIngresoFF.Expanded = False
                    End If
                    agrSaldo.Visible = True
                    agrGastosAdm.Visible = True
                    agrVales.Visible = True
                    agrOtrosIngresos.Visible = True
                    If IndCajaPrincipal Then agrTotalFF.Visible = True
                    cboTrabajadorMovimiento.Focus()
                    ControlBoton(1, 0, 0, 0, 1, 0, 0, 1, 1)
                    btnReporteFondoFijo.Visible = False
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboLugar_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLugar.ValueChanged
        Try
            If cboLugar.SelectedIndex <> -1 Then
                CargaDireccionesGrifo(cboProveedores.ActiveRow.Cells("IdEmpresa").Value)
                If cboDireccion.Items.Count > 1 Then
                    cboDireccion.SelectedIndex = -1
                Else
                    cboDireccion.SelectedIndex = 0
                End If
            Else
                Me.cboDireccion.Value = Nothing
                Me.cboDireccion.DataSource = Nothing
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tsmiEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        EditarMov()
    End Sub

    Private Sub griLista_DoubleClickRow(sender As Object, e As DoubleClickRowEventArgs) Handles griLista.DoubleClickRow
        Editar2()
        MostrarTabs(0, FicObservacion)
    End Sub

    Private Sub griListaGlosa_AfterRowActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griListaGlosa.AfterRowActivate
        Try
            If ficMovimientoDetalle.SelectedTab.Index = 1 Then
                If griListaGlosa.Rows.Count > 0 Then
                    If verGlosaOrigen.Checked Then
                        txtGlosaOrigen.Text = griListaGlosa.ActiveRow.Cells("Nombre").Value.ToString & " " & cboTrabajadorPrestamo.Text & " " & cboViaje.Text
                    ElseIf verGlosaDestino.Checked Then
                        txtGlosaDestino.Text = griListaGlosa.ActiveRow.Cells("Nombre").Value.ToString & " " & txtPiloto.Text & " " & txtViaje.Text
                    End If
                    If IndCajaPrincipal Then
                        If verGlosaOrigen.Checked Then
                            txtGlosaOrigen.Text = griListaGlosa.ActiveRow.Cells("Nombre").Value.ToString & " " & cboTrabajadorPrestamo.Text & " " & cboViaje.Text
                        ElseIf verGlosaDestino.Checked Then
                            txtGlosaDestino.Text = griListaGlosa.ActiveRow.Cells("Nombre").Value.ToString & " " & txtPiloto.Text & " " & txtViaje.Text
                        End If
                    End If
                End If
            ElseIf ficMovimientoDetalle.SelectedTab.Index = 2 Then
                Select Case opcTrabajadorDescuento.CheckedIndex
                    Case 0
                        oeMovimientoDescuento.IdCuentaCorrienteDestino = BuscarIdCtaCte(idPiloto, 0, loCuentaCorriente)
                        txtGlosaDescuento.Text = griListaGlosa.ActiveRow.Cells("Nombre").Value.ToString & " " & txtPilotoDescuento.Text & ", FECHA: " & fecFechaDescuento.Value
                    Case 1
                        oeMovimientoDescuento.IdCuentaCorrienteDestino = BuscarIdCtaCte(idCopiloto, 0, loCuentaCorriente)
                        txtGlosaDescuento.Text = griListaGlosa.ActiveRow.Cells("Nombre").Value.ToString & " " & txtCopilotoDescuento.Text & ", FECHA: " & fecFechaDescuento.Value
                    Case 2
                        oeMovimientoDescuento.IdCuentaCorrienteDestino = BuscarIdCtaCte(idAyudante, 0, loCuentaCorriente)
                        txtGlosaDescuento.Text = griListaGlosa.ActiveRow.Cells("Nombre").Value.ToString & " " & txtAyudanteDescuento.Text & ", FECHA: " & fecFechaDescuento.Value
                End Select
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub opcSalidaEntrada_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opcSalidaEntrada.ValueChanged
        Try
            Select Case opcSalidaEntrada.CheckedIndex
                Case 0
                    If txtEstado.Text = "PENDIENTE" Then
                        txtGlosa.Text = "HABILITACION DE BOLSA DE VIAJE " & fechaMovimiento.Value
                    ElseIf txtEstado.Text = "HABILITADA" Then
                        txtGlosa.Text = "AMPLIACION DE BOLSA DE VIAJE " & fechaMovimiento.Value
                    End If
                Case 1
                    If decSaldo.Value = 0 Then
                        opcSalidaEntrada.CheckedIndex = 0
                        MessageBox.Show("Usted no puede hacer un ingreso por no tener saldo", "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Else
                        txtGlosa.Text = "INGRESO A CAJA " & Date.Now & " / Trabajador: " & txtPiloto.Text
                    End If
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtCodViaje_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodViaje.Click
        txtCodViaje.SelectAll()
    End Sub

    Private Sub txtCodViaje_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodViaje.Enter
        txtCodViaje.SelectAll()
    End Sub

    Private Sub cboTrabajadorMovimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTrabajadorMovimiento.Click
        cboTrabajadorMovimiento.SelectAll()
    End Sub

    Private Sub cboTrabajadorMovimiento_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTrabajadorMovimiento.Enter
        cboTrabajadorMovimiento.SelectAll()
    End Sub

    Private Sub cboTracto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTracto.Click
        cboTracto.SelectAll()
    End Sub

    Private Sub cboTracto_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTracto.Enter
        cboTracto.SelectAll()
    End Sub

    Private Sub cboEstadoViaje_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEstadoViaje.Click
        cboEstadoViaje.SelectAll()
    End Sub

    Private Sub cboEstadoViaje_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEstadoViaje.Enter
        cboEstadoViaje.SelectAll()
    End Sub

    Private Sub btnLiquidar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLiquidar.Click
        Try
            Liquidar(txtViaje.Tag)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub MnAdministrativo_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MnAdministrativo.Opening
        Try
            MnAdministrativo.Items("HabilitarCuentaToolStripMenuItem").Visible = False
            MnAdministrativo.Items("tsmiDocumentos").Visible = True
            MnAdministrativo.Items("CierreCuentaToolStripMenuItem").Visible = False
            MnAdministrativo.Items("CuadreCajaToolStripMenuItem").Visible = False
            If IndCajaPrincipal Then
                MnAdministrativo.Items("HabilitarCuentaToolStripMenuItem").Visible = True
            Else
                If GriCuentaAdministrativa.Rows.Count >= 1 Then
                    MnAdministrativo.Items("CierreCuentaToolStripMenuItem").Visible = True
                    MnAdministrativo.Items("CuadreCajaToolStripMenuItem").Visible = True
                End If
            End If
            If GriCuentaAdministrativa.Rows.Count >= 1 Then
                MnAdministrativo.Items("GenerarGrupoFlete").Visible = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtRUC_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRUC.ValueChanged
        If Not txtRUC.Value Is Nothing Then
            If txtRUC.Value.ToString.Trim.Length > 10 Then
                Dim leProveedorList As New List(Of e_Proveedor)
                leProveedorList = ListaProveedor.ToList
                leProveedorList = ListaProveedor.Where(Function(item) item.NroDocumento.Contains(txtRUC.Value)).ToList
                If leProveedorList.Count > 0 Then
                    cboProveedores.Value = leProveedorList(0).Id
                Else
                    cboProveedores.Value = Nothing
                End If
            End If
        Else
            cboProveedores.Value = Nothing
        End If
    End Sub

    Private Sub frm_Movimiento_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub

    Private Sub verGlosaOrigen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verGlosaOrigen.CheckedChanged
        If verGlosaOrigen.Checked Then
            verGlosaDestino.Checked = False
            expGlosa.Expanded = True
            expGlosa.Visible = True
        Else
            expGlosa.Expanded = False
            expGlosa.Visible = False
        End If
    End Sub

    Private Sub verGlosaDestino_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verGlosaDestino.CheckedChanged
        If verGlosaDestino.Checked Then
            verGlosaOrigen.Checked = False
            expGlosa.Expanded = True
            expGlosa.Visible = True
        Else
            expGlosa.Expanded = False
            expGlosa.Visible = False
        End If
    End Sub

    Private Sub verGlosa_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verGlosa.CheckedChanged
        If verGlosa.Checked Then
            expGlosa.Expanded = True
            expGlosa.Visible = True
        Else
            expGlosa.Expanded = False
            expGlosa.Visible = False
        End If
    End Sub

    Private Sub griMovimiento_BeforeCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeCellUpdateEventArgs) Handles griMovimiento.BeforeCellUpdate
        With griMovimiento
            Select Case e.Cell.Column.Key
                Case "Glosa"
                    If e.Cell.Column.Key = "Glosa" Then If IsDBNull(e.NewValue) Then e.Cancel = True

            End Select
        End With
    End Sub

    Private Sub griMovimiento_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griMovimiento.CellChange
        griMovimiento.UpdateData()
    End Sub

    Private Function VerificarNumeroHabilitaciones(ByVal Trabajador As String) As Integer
        Dim oeMovimientoNumHab As New e_Movimiento_Viaje
        Dim ListaViajesAsignados As New List(Of e_Movimiento_Viaje)
        Dim Count As Integer = 0
        Try
            oeMovimientoNumHab.TipoOperacion = "9"
            oeMovimientoNumHab.VincularViajePiloto = 1
            oeMovimientoNumHab.IdPiloto = Trabajador
            ListaViajesAsignados = olMovimiento_Viaje.Listar(oeMovimientoNumHab)
            For Each movvia As e_Movimiento_Viaje In ListaViajesAsignados
                If movvia.SaldoTotal > 0 Then
                    Count += 1
                End If
            Next
            Return Count
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub griMovimiento_ClickCellButton(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griMovimiento.ClickCellButton
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            If UltraExpandableGroupBoxMovCuenta.Expanded = True Then
                Select Case e.Cell.Column.Key
                    Case "Glosa"
                        Dim oeMovimientoGlosa As New e_Movimiento
                        oeMovimientoGlosa.TipoOperacion = "B"
                        oeMovimientoGlosa.Glosa = griMovimiento.ActiveRow.Cells("Glosa").Value
                        oeMovimientoGlosa.Id = griMovimiento.ActiveRow.Cells("IdMovimiento").Value
                        oeMovimientoGlosa.TipoTransa = griMovimiento.ActiveRow.Cells("TipoTransa").Value
                        oeMovimientoGlosa.PrefijoID = gs_PrefijoIdSucursal '@0001
                        If olMovimiento.Guardar(oeMovimientoGlosa, New e_Movimiento) Then mensajeEmergente.Confirmacion(Me.Text & ": La Informacion ha sido grabada Satisfactoriamente; " & griMovimiento.ActiveRow.Cells("Glosa").Value, True)
                        'ControlBoton(0, 0, 0,1, 1, 0, 0, 0, 0)
                End Select
            Else
                Exit Sub
            End If

            'ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub MnuIngresoFleteCta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuIngresoFleteCta.Click
        'Dim oeMovimiento2 As New e_Movimiento
        'oeMovimientoPrestamo = New e_Movimiento
        'oeMovObtener = New e_Movimiento
        'oeMovSaldo = New e_Movimiento
        'oeMovimientoFlete = New e_Movimiento_Flete
        'Try
        '    If MessageBox.Show("¿Desea ingresar flete : " & griMovimiento.ActiveRow.Cells("Egreso").Value & " a su cuenta " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) = Windows.Forms.DialogResult.Yes Then
        '        oeMovObtener.Id = griMovimiento.ActiveRow.Cells("IdMovimiento").Value
        '        oeMovObtener = olMovimiento.Obtener(oeMovObtener)
        '        If oeMovObtener.Voucher <> "CARGADO" Then
        '            oeMovSaldo.TipoOperacion = "A"
        '            oeMovSaldo.TipoProceso = "FLETE_ADM2"
        '            oeMovSaldo.Id = oeMovObtener.Id
        '            oeMovSaldo.IdEstado = "HABILITADA"
        '            oeMovSaldo.IdCuentaCorrienteDestino = oeMovObtener.IdCuentaCorrienteDestino
        '            oeMovSaldo.IdCuentaCorrienteOrigen = oeMovObtener.IdCuentaCorrienteOrigen
        '            oeMovSaldo.Ingreso = 0
        '            If oeMovObtener.TipoTransa = 1 Then
        '                oeMovSaldo.TipoTransa = 1
        '            Else
        '                oeMovSaldo.TipoTransa = 2
        '            End If
        '            oeMovSaldo.Egreso = oeMovObtener.Egreso
        '            oeMovSaldo.Glosa = griMovimiento.ActiveRow.Cells("Glosa").Value
        '            oeMovSaldo.Saldo = CDec(oeMovObtener.Egreso) - CDec(oeMovObtener.Saldo)
        '            oeMovSaldo.SaldoPorDepositar = oeMovObtener.SaldoPorDepositar
        '            oeMovSaldo.UsuarioCreacion = gUsuarioSGI.Id
        '            oeMovSaldo.Fecha = Date.Now
        '            oeMovSaldo.IndPrestamoHab = 1
        '            oeMovSaldo.Descuento = 1
        '            oeMovSaldo.Voucher = oeMovObtener.Voucher
        '            oeMovSaldo.IndPrestamoHab = oeMovObtener.IndPrestamoHab

        '            '''''''''''''''''''''''''

        '            oeMovimiento = New e_Movimiento
        '            oeMovimiento_Viaje = New e_Movimiento_Viaje

        '            Dim oeTemp As New e_CuentaCorriente

        '            oeTemp.IdTrabajador = gUsuarioSGI.IdTrabajador
        '            oeTemp.Tipo = 1
        '            oeTemp = loCuentaCorriente.Item(loCuentaCorriente.IndexOf(oeTemp))
        '            ' oeMovimiento = oeMovSaldo

        '            With oeMovimiento
        '                .TipoOperacion = "I"
        '                .TipoProceso = ""
        '                .Depositado = 0
        '                .Descuento = 1
        '                .Egreso = 0
        '                .Ingreso = oeMovSaldo.Egreso
        '                .Fecha = Date.Now
        '                .Glosa = "DESCARGA FLETE A: " & oeTemp.Trabajador & " (" & CajaUsuario & ") " & "/FECHA: " & Date.Now & _
        '                 "/VIAJE : " & txtViaje.Text
        '                .IndPrestamoHab = 1
        '                .Descuento = 1
        '                .Fecha = Date.Now
        '                .IdCuentaCorrienteDestino = oeMovSaldo.IdCuentaCorrienteDestino
        '                .IdCuentaCorrienteOrigen = oeMovSaldo.IdCuentaCorrienteOrigen
        '                .IdEstado = "HABILITADA"
        '                .Saldo = 0
        '                .SaldoPorDepositar = 0
        '                .TipoMovimiento = 1
        '                .UsuarioCreacion = gUsuarioSGI.Id
        '                .Voucher = oeMovSaldo.Voucher
        '                .TipoTransa = 5
        '            End With

        '            oeMovimiento.loMovimientoViaje.Clear()
        '            oeMovimiento.loMovimientoViaje.Add(oeMovimiento_Viaje)
        '            oeMovimiento.loMovimientoViaje(0).IdViaje = txtViaje.Tag
        '            oeMovimiento.loMovimientoViaje(0).TipoOperacion = "I"

        '            oeMovSaldo.loMovimiento.Add(oeMovimiento)

        '            ''''''''''''''''''''''''''agregar a lista de movimientos 

        '            oeMovimiento2.Egreso = CDec(oeMovSaldo.Egreso)
        '            oeMovimiento2.Ingreso = 0
        '            oeMovimiento2.Saldo = 0 'CDec(oeMovSaldo.Egreso)
        '            oeMovimiento2.SaldoPorDepositar = 0 'CDec(oeMovSaldo.Egreso)
        '            oeMovimiento2.Glosa = "FLETE DESCARGADO DEL TRABAJADOR: " & txtPiloto.Text & "/FECHA: " & Date.Now & _
        '             "/VIAJE : " & txtViaje.Text
        '            oeMovimiento2.Fecha = Date.Now
        '            oeMovimiento2.IdCuentaCorrienteDestino = BuscarIdCtaCte(gUsuarioSGI.IdTrabajador, 1, loCuentaCorriente)
        '            oeMovimiento2.IdCuentaCorrienteOrigen = BuscarIdCtaCte(idPiloto, 0, loCuentaCorriente)

        '            oeMovimiento2.TipoTransa = 5
        '            oeMovimiento2.IndPrestamoHab = 1
        '            oeMovimiento2.Descuento = 1
        '            oeMovimiento2.TipoOperacion = "I"
        '            oeMovimiento2.IdEstado = "HABILITADA"
        '            oeMovimiento2.UsuarioCreacion = gUsuarioSGI.Id

        '            oeMovimientoFlete.TipoOperacion = "F"
        '            oeMovimiento2.loMovimientoFlete.Add(oeMovimientoFlete)

        '            oeMovSaldo.loMovimiento.Add(oeMovimiento2)
        '            ''''''''''''''''''''''''''agregar a lista de movimientos

        '            If olMovimiento.Guardar(oeMovSaldo) Then
        '                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
        '                Dim IdMov As String = griMovimiento.ActiveRow.Cells("IdMovimiento").Value.ToString
        '                Dim oeMov As New e_Movimiento
        '                Dim olMov As New l_Movimiento
        '                oeMov.Id = IdMov
        '                oeMov.Voucher = "CARGADO"
        '                oeMov.TipoOperacion = "Z"
        '                olMov.Guardar2(oeMov)
        '                oeMovimiento_Viaje_Detalle = New e_Movimiento_Viaje
        '                oeMovimiento_Viaje_Detalle.IdViaje = txtViaje.Tag
        '                ListarMovimientoDetalle(oeMovimiento_Viaje_Detalle) ', True)
        '                oeMovimiento_Viaje.Modificado = False
        '                ControlBoton(0, 0, 0, 0, 1, 0, 0, 0, 1)

        '            End If
        '        End If
        '    End If
        'Catch ex As Exception
        '    mensajeEmergente.Problema(ex.Message, True)
        'End Try
    End Sub

    Private Sub MnuIngresoFlete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuIngresoFlete.Click
        'Dim TipoOperacion As String = "0"
        'Dim oeMovFle As New e_Movimiento_Flete
        'Dim oeMovCta As New e_Movimiento
        'Try
        '    If griMovimiento.ActiveRow.Cells("Voucher").Value.ToString = "" Then
        '        If MessageBox.Show("¿Desea ingresar el flete: " & griMovimiento.ActiveRow.Cells("Egreso").Value & " al fondo fijo " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) = Windows.Forms.DialogResult.Yes Then
        '            oeMovimiento.Ingreso = griMovimiento.ActiveRow.Cells("Egreso").Value
        '            oeMovimiento.Egreso = 0
        '            oeMovimiento.Glosa = "INGRESO FLETE A FONDO FIJO " & Date.Now & "/ Trabajador: " & txtPiloto.Text
        '            oeMovimiento.Saldo = 0
        '            oeMovimiento.TipoTransa = 5
        '            oeMovimiento.IndPrestamoHab = 1
        '            oeMovimiento.Descuento = 1
        '            oeMovimiento.IdCaja = idCajaCentro
        '            TipoOperacion = "3" ' Reporte Vale Ingreso a Fondo
        '            oeMovimiento.IdCuentaCorrienteOrigen = BuscarIdCtaCte(gUsuarioSGI.IdTrabajador, 1, loCuentaCorriente)
        '            oeMovimiento.IdCuentaCorrienteDestino = BuscarIdCtaCte(idPiloto, 0, loCuentaCorriente)
        '            'oeMovimiento.Glosa = oeMovimiento.Glosa & " " & Date.Now
        '            oeMovimiento.loMovimientoViaje.Add(oeMovimiento_Viaje)
        '            oeMovimiento.loMovimientoViaje(0).IdViaje = txtViaje.Tag

        '            'oeMovCta.Ingreso = 
        '            Dim IdMov As String = griMovimiento.ActiveRow.Cells("IdMovimiento").Value.ToString
        '            Dim oeMov As New e_Movimiento
        '            Dim olMov As New l_Movimiento
        '            oeMov.Id = IdMov
        '            oeMov.Voucher = "CARGADO"
        '            oeMov.TipoOperacion = "Z"
        '            olMov.Guardar2(oeMov)

        '            If olMovimiento.Guardar(oeMovimiento) Then
        '                With oeMovCta
        '                    .Ingreso = oeMovimiento.Ingreso
        '                    .Egreso = 0
        '                    .Descuento = 0
        '                    .Glosa = "FLETE DESCARGADO DEL TRABAJADOR: " & txtPiloto.Text & "/FECHA: " & Date.Now & "/VIAJE : " & txtViaje.Text
        '                    .TipoTransa = 5
        '                    .IdCuentaCorrienteOrigen = BuscarIdCtaCte(gUsuarioSGI.IdTrabajador, 1, loCuentaCorriente)
        '                    .IdCuentaCorrienteDestino = ""
        '                    .IndPrestamoHab = 0
        '                    .TipoOperacion = "I"
        '                    .IdEstado = "HABILITADA"
        '                    .UsuarioCreacion = gUsuarioSGI.Id
        '                    .Fecha = Date.Now
        '                    oeMovFle.TipoOperacion = "F"
        '                    .loMovimientoFlete.Add(oeMovFle)
        '                    '.loMovimientoViaje.Clear()
        '                    '.loMovimientoViaje(0).IdViaje = ""
        '                End With
        '                If olMovimiento.Guardar(oeMovCta) Then
        '                    Dim formulario As New frm_ReporteVoucherMovimientoCaja
        '                    formulario.CargarDatos(TipoOperacion, oeMovimiento.Id)
        '                    formulario.ShowDialog()
        '                    mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
        '                End If

        '                If CajaUsuario = "CCH" Then
        '                    oeMovimiento_Viaje_Detalle = New e_Movimiento_Viaje
        '                    oeMovimiento_Viaje_Detalle.IdViaje = txtViaje.Tag
        '                    ListarMovimientoDetalle(oeMovimiento_Viaje_Detalle) ', True)
        '                    MostrarTabs(1, ficMovimiento, 1)
        '                    MostrarTabs(0, ficMovimientoDetalle)
        '                Else
        '                    MostrarTabs(0, ficMovimiento)
        '                    MostrarTabs(0, ficTipoMovimiento, 1)
        '                End If

        '            End If
        '        End If
        '    End If

        'Catch ex As Exception
        '    mensajeEmergente.Problema(ex.Message, True)
        'End Try

    End Sub

    Private Sub MenuContextualFlete_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuContextualFlete.Opening
        MenuContextualFlete.Items("MnuIngresoFlete").Visible = False
        MenuContextualFlete.Items("MnuIngresoFleteCta").Visible = False
        If griMovimiento.Rows.Count > 0 AndAlso griMovimiento.ActiveRow.Cells("Descuento").Value = 1 AndAlso griMovimiento.ActiveRow.Cells("Egreso").Value > 0 Then
            If IndCajaPrincipal Then
                If griMovimiento.ActiveRow.Cells("Voucher").Value.ToString = "CARGADO" Then
                    MenuContextualFlete.Items("MnuIngresoFlete").Visible = False
                Else
                    MenuContextualFlete.Items("MnuIngresoFlete").Visible = True
                    MenuContextualFlete.Items("MnuIngresoFleteCta").Visible = False
                End If
            Else
                MenuContextualFlete.Items("MnuIngresoFlete").Visible = False
                If griMovimiento.ActiveRow.Cells("Voucher").Value.ToString = "CARGADO" Then
                    MenuContextualFlete.Items("MnuIngresoFleteCta").Visible = False
                Else
                    MenuContextualFlete.Items("MnuIngresoFleteCta").Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub DecNoGravada_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecNoGravada.ValueChanged
        If IsNumeric(DecNoGravada.Value) Then
            numTotal.Value = numImporte.Value + numIGV.Value + DecNoGravada.Value + DecPercepcion.Value
        Else
            DecNoGravada.Value = 0
        End If
    End Sub

    Private Sub DecPercepcion_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecPercepcion.ValueChanged
        If IsNumeric(DecPercepcion.Value) Then
            numTotal.Value = numImporte.Value + numIGV.Value + DecNoGravada.Value + DecPercepcion.Value
        Else
            DecPercepcion.Value = 0
        End If
    End Sub

    Private Sub ChkVehiculoProper_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkVehiculoProper.CheckedChanged
        Try
            If ChkVehiculoProper.Checked Then
                With cboPlaca.CheckedListSettings
                    .CheckBoxStyle = Infragistics.Win.CheckStyle.CheckBox
                    .EditorValueSource = Infragistics.Win.EditorWithComboValueSource.CheckedItems
                    .ListSeparator = ";"
                End With
                DescheckearTodosItemsCombo()
            Else
                Me.cboPlaca.CheckedListSettings.Reset()
                cboPlaca.SelectedIndex = -1
                'With cboPlaca.CheckedListSettings
                '    .CheckBoxStyle = Infragistics.Win.CheckStyle.None
                '    .EditorValueSource = Infragistics.Win.EditorWithComboValueSource.SelectedItem
                '    .ListSeparator = ""
                'End With
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub DescheckearTodosItemsCombo()
        Dim itemList As ICheckedItemList = DirectCast(Me.cboPlaca.Items.ValueList, ICheckedItemList)
        For i As Integer = 0 To Me.cboPlaca.Items.Count - 1
            itemList.SetCheckState(i, CheckState.Unchecked)
        Next
    End Sub

    Private Sub btnNuevoProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoProveedor.Click
        Dim Formulario As New frm_Proveedor
        Formulario.RegistroProveedor = "TES"
        'Formulario.txtRuc.Text = txtRUC.Text
        'txtRUC.Text = String.Empty
        Formulario.ShowDialog()
        If Formulario.RegistroProveedor <> "TES" Then
            LlenaComboProveedor()
            txtRUC.Text = Formulario.RegistroProveedor
        End If
        Formulario.Dispose()
        Formulario.Close()
        ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
    End Sub

    Private Sub cboTrabajadorMovimiento_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboTrabajadorMovimiento.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            Listar(True)
        End If
    End Sub

    Private Sub cboTrabajadorMovimiento_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTrabajadorMovimiento.MouseEnter
        cboTrabajadorMovimiento.SelectAll()
    End Sub

    Private Sub numImporte_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numImporte.Enter
        Me.numImporte.SelectAll()
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        LimpiarDatoDetalle()
    End Sub

    Private Sub txtNumero_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNumero.MouseEnter
        txtNumero.SelectAll()
    End Sub

    Private Sub numAgregado_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numAgregado.ValueChanged
        If aux3 = False Then
            Dim aux As Decimal = Me.numCubrir.Value
            Me.numCubrir.Value = (Me.numCubrir.Value + aux1) - Me.numAgregado.Value
        Else
            Me.numCubrir.Value = aux2 - Me.numAgregado.Value
        End If
        aux3 = False
    End Sub

    Private Sub cboTrabajadorPrestamo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboTrabajadorPrestamo.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            'Dim otemp As New e_Trabajador
            With cboTrabajadorPrestamo
                If .SelectedIndex > -1 Then
                    Dim i As Integer = .SelectedIndex
                    Dim otemp = .Items(i).ListObject
                    CargaComboViajePiloto(otemp.Id)
                    cboViaje.Focus()
                    oeMovimientoPrestamo.IdCuentaCorrienteDestino = BuscarIdCtaCte(otemp.Id, 0, loCuentaCorriente)
                    If cboTrabajadorPrestamo.Text <> "" And griListaGlosa.Rows.Count > 0 Then
                        txtGlosaOrigen.Text = griListaGlosa.Rows(8).Cells("Nombre").Value.ToString & " " & txtPiloto.Text & " " & cboViaje.Text
                        txtGlosaDestino.Text = griListaGlosa.Rows(9).Cells("Nombre").Value.ToString & " " & cboTrabajadorPrestamo.Text & " " & cboViaje.Text
                    End If
                End If
            End With
        End If
    End Sub

    Private Sub txtNumero_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumero.Enter
        Me.txtNumero.SelectAll()
    End Sub

    Private Sub cboTrabajador2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTrabajador2.Enter
        cboTrabajador2.SelectAll()
    End Sub

    Private Sub cboFlujoCaja_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFlujoCaja.Enter
        cboFlujoCaja.SelectAll()
    End Sub

    Private Sub cboTipoGasto_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoGasto.Enter
        cboTipoGasto.SelectAll()
    End Sub

    Private Sub FicDatos_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles FicDatos.SelectedTabChanged
        Me.decHabEfectivo.Value = 0.0
    End Sub

    Private Sub cboEstadoViaje_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboEstadoViaje.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            Listar(True)
        End If
    End Sub

    Private Sub cboTracto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboTracto.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            Listar(True)
        End If
    End Sub

    Private Sub GriCuentaAdministrativa_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs)
        e.Cancel = True
    End Sub

    Private Sub griLista_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griLista.BeforeRowsDeleted
        e.Cancel = True
    End Sub

    Private Sub griMovimiento_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griMovimiento.BeforeRowsDeleted
        e.Cancel = True
    End Sub

    Private Sub fecHasta_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles fecHasta.KeyDown
        If e.KeyCode = Keys.Tab Then
            txtCodViaje.Focus()
        End If
    End Sub

    Private Sub chkPagoxCaja_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPagoxCaja.CheckedChanged
        Try
            If cboTipoDocumento.Text <> "VALE" And cboTipoDocumento.Text <> "SUSTENTO CONTABLE" Then
                If chkPagoxCaja.Checked Then
                    DecPagoxCaja.Enabled = True
                Else
                    DecPagoxCaja.Enabled = False
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dtpFechaEmision_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaEmision.Validated
        Try
            If dtpFechaEmision.Value.Date > ObtenerFechaServidor.Date Then
                dtpFechaEmision.Value = ObtenerFechaServidor.Date
                Throw New Exception("No Puede Guardar un Documento Mayor a la Fecha Actual")
            End If
            If TipoMov = 1 Then
                If DateDiff(DateInterval.Day, dtpFechaEmision.Value.Date, CDate(Me.fecFechaViaje.Value)) > 31 Then
                    dtpFechaEmision.Value = ObtenerFechaServidor.Date
                    dtpFechaEmision.Focus()
                    Throw New Exception("No Puede Ingresar un Documento con mas de un Mes de Diferencia entre la Fecha del Viaje")
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboTrabajadorMovimiento_EditorButtonClick(sender As Object, e As UltraWinEditors.EditorButtonEventArgs) Handles cboTrabajadorMovimiento.EditorButtonClick
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            'Select Case e.Button.Key
            '    Case "Right"
            Select Case ficTipoMovimiento.SelectedTab.Index
                Case 0
                    ListarCuentaCorriente()
                    LlenaCombosTrabajadores()
                    LlenaComboTrabajadorMovimiento()
                Case 1
                    If loCuentaCorriente.Count > 0 Then
                        Dim oeTemp As New e_CuentaCorriente
                        oeTemp.IdTrabajador = gUsuarioSGI.IdTrabajador
                        oeTemp.Tipo = 1
                        oeTemp = loCuentaCorriente.Item(loCuentaCorriente.IndexOf(oeTemp))
                        cboTrabajadorMovimiento.DataSource = New List(Of e_CuentaCorriente)
                        LlenarCombo(cboTrabajadorMovimiento, "Trabajador", loCA, -1)
                        CuentaAdm = oeTemp.Id
                        cboTrabajadorMovimiento.Value = CuentaAdm
                    End If
            End Select

            'End Select
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

#End Region

#Region "Menu Contexual"

    Private Sub MnContMovimiento_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MnContMovimiento.Opening
        Try
            MnContMovimiento.Items("HabilitarBolsaDeViajeToolStripMenuItem").Visible = False
            MnContMovimiento.Items("AmpliacionBolsaDeViajeToolStripMenuItem").Visible = False
            MnContMovimiento.Items("LiquidarToolStripMenuItem").Visible = False
            MnContMovimiento.Items("ReporteFondoFijoToolStripMenuItem").Visible = False
            If griLista.Rows.Count > 0 Then
                If griLista.ActiveRow.Cells("Estado").Value = gNombreEstadoPendiente Then
                    MnContMovimiento.Items("HabilitarBolsaDeViajeToolStripMenuItem").Visible = True
                    MnContMovimiento.Items("LiquidarToolStripMenuItem").Visible = True
                End If
                If griLista.ActiveRow.Cells("Estado").Value = gNombreEstadoLiquidada Then
                    MnContMovimiento.Items("HabilitarBolsaDeViajeToolStripMenuItem").Visible = True
                End If
                If griLista.ActiveRow.Cells("Estado").Value = gNombreEstadoHabilitada Then
                    If olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "HAB BOLSA VIAJE") Then MnContMovimiento.Items("AmpliacionBolsaDeViajeToolStripMenuItem").Visible = True
                End If
                If griLista.ActiveRow.Cells("SaldoTotal").Value = 0 And griLista.ActiveRow.Cells("Estado").Value = gNombreEstadoHabilitada Then
                    MnContMovimiento.Items("LiquidarToolStripMenuItem").Visible = True
                    If olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "HAB BOLSA VIAJE") Then MnContMovimiento.Items("AmpliacionBolsaDeViajeToolStripMenuItem").Visible = True
                End If
                MnContMovimiento.Items("ReporteFondoFijoToolStripMenuItem").Visible = IIf(IndCajaPrincipal, True, False)
            Else
                MnContMovimiento.Items("HabilitarBolsaDeViajeToolStripMenuItem").Visible = False
                MnContMovimiento.Items("AmpliacionBolsaDeViajeToolStripMenuItem").Visible = False
                MnContMovimiento.Items("LiquidarToolStripMenuItem").Visible = False
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub HabilitarBolsaDeViajeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HabilitarBolsaDeViajeToolStripMenuItem.Click
        Try
            DobleClick = 0
            'If VerificarRegistroEditado() Then
            If griLista.ActiveRow.Cells("Estado").Value = gNombreEstadoLiquidada Then
                If MessageBox.Show("Desea Habilitar el viaje: " & griLista.ActiveRow.Cells("Viaje").Value, "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3) = Windows.Forms.DialogResult.Yes Then
                    Dim loLiqHabMov As New List(Of e_Movimiento)
                    oeMovimiento_Viaje = New e_Movimiento_Viaje
                    oeMovimiento = New e_Movimiento
                    oeMovimiento.TipoOperacion = "H"
                    oeMovimiento.Id = griLista.ActiveRow.Cells("IdViaje").Value
                    loLiqHabMov.Add(oeMovimiento)
                    If olMovimiento.LiquidarHabilitar(loLiqHabMov) Then
                        mensajeEmergente.Confirmacion("El viaje se habilitó exitosamente ")
                        etiLiquidar.Visible = False
                        btnLiquidar.Visible = False
                        Consultar(True)
                    End If
                    Exit Sub
                End If
            Else
                If olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "HAB BOLSA VIAJE") Then
                    TipoAmp = IIf(IndCajaPrincipal, 1, 2)
                    idMovimiento = griLista.ActiveRow.Cells("IdMovimiento").Value
                    idOperacion = griLista.ActiveRow.Cells("IdOperacion").Value
                    InicializarMovimientoViaje()
                    agrIEFF.Visible = True
                    Me.decImportePrestamo.ReadOnly = False
                    MostrarTabs(1, FicObservacion)
                    HabilitacionBolsaViaje()
                    Operacion = "Nuevo"
                    ControlBoton(0, 0, 0, 1, 1, 0, 1, 0)
                    opcVerPiloto.Checked = True
                    decImporte.Focus()
                    decImporte.SelectAll()
                Else
                    mensajeEmergente.Problema("No Tiene Permisos Para Habilitar Bolsa de Viaje", True)
                End If
            End If
            '    GuardarRegistroEditado()
            'End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub AmpliacionBolsaDeViajeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AmpliacionBolsaDeViajeToolStripMenuItem.Click
        Try
            TipoAmp = 2
            idMovimiento = griLista.ActiveRow.Cells("IdMovimiento").Value
            idOperacion = griLista.ActiveRow.Cells("IdOperacion").Value
            agrDatosViaje.Visible = True
            FicObservacion.Visible = True
            agrCuenta.Visible = True
            Agrupacion8.Enabled = True
            agrIEFF.Visible = True
            ExpGroupBoxReceptor.Visible = True
            Me.decImportePrestamo.ReadOnly = False
            Me.agrIEFF.Visible = True
            If VerificarRegistroEditado() Then
                If VerificarNumeroHabilitaciones(griLista.ActiveRow.Cells("IdPiloto").Value) > 5 Then
                    Throw New Exception("Numero Maximo de Habilitaciones alcanzado por Piloto")
                End If
                Ampliacion()
                opcVerPiloto.Checked = True
                MostrarTabs(1, FicObservacion, 1)
                GuardarRegistroEditado()
                decImporte.Focus()
                decImporte.SelectAll()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub Ampliacion()
        Try
            opcDefinicion.Enabled = True
            cboCaja.Enabled = False
            MostrarTabs(1, ficMovimiento, 1)
            MostrarTabs(0, FicDatos)
            InicializarMovimientoViaje()
            MostrarViaje()
            MontosProgramados()
            AmpliacionBolsaViaje()
            Operacion = "Nuevo"
            If decSaldo.Value > 0 Then
                UltraExpandableGroupBoxMovCuenta.Expanded = True
                UltraExpandableGroupBoxMovCuenta.Visible = True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LiquidarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LiquidarToolStripMenuItem.Click
        Try
            idOperacion = griLista.ActiveRow.Cells("IdOperacion").Value
            If griLista.ActiveRow.Cells("Estado").Value = "PENDIENTE" Then
                Liquidar(griLista.ActiveRow.Cells("IdViaje").Value)
            Else
                Me.decImportePrestamo.ReadOnly = True
                If VerificarRegistroEditado() Then
                    Ampliacion()
                    etiLiquidar.Visible = True
                    btnLiquidar.Visible = True
                    '        LlenaCombosTrabajadores()
                    opcVerPiloto.Checked = True
                    ControlBoton(0, 0, 0, 0, 1, 0, 1, 0, 1)
                    GuardarRegistroEditado()
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub tsmiDocumentos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiDocumentos.Click
        Try
            'LlenaCombosTrabajadores()
            CargarCombosRG()
            MostrarTabs(1, ficMovimiento, 1)
            MostrarTabs(1, ficMovimientoViaje)
            Me.ficMovimientoViaje.Tabs(0).Enabled = False
            'oeCuentaCorriente = New e_CuentaCorriente
            'oeCuentaCorriente.IdTrabajador = gUsuarioSGI.IdTrabajador
            'oeCuentaCorriente = olCuentaCorriente.Obtener(oeCuentaCorriente)
            'IdCuentaCte = oeCuentaCorriente.Id
            agrDatos.Expanded = True
            expDocumento.Expanded = False
            ListaGastoOperacion()
            LimpiarDatoDetalle()
            If TipoMov = 1 Then
                cboFlujoCaja.Focus()
            Else
                cboTipoGasto.Focus()
            End If
            'agrCalendarioViatico.Expanded = False
            'agrCalendarioViatico.Visible = False
            Operacion = "Nuevo"
            idCompraAlm = ""
            IdCuentaContableCompraAlmacen = ""
            IdDocumentoAlmacen = ""
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            Modificado = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Private Sub OpcFlete_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If OpcFlete.CheckedIndex = 1 Then
        '    ExpRegistroFlete.Visible = True
        '    ExpRegistroFlete.Expanded = True
        '    MostrarTabs(1, FicRegistroFlete, 1)
        'ElseIf OpcFlete.CheckedIndex = 0 Then
        '    ExpRegistroFlete.Visible = True
        '    ExpRegistroFlete.Expanded = True
        '    MostrarTabs(0, FicRegistroFlete, 0)
        'Else
        '    ExpRegistroFlete.Visible = False
        '    ExpRegistroFlete.Expanded = False
        'End If
    End Sub

    Private Sub HabilitarCuentaToolStripMenuItem_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HabilitarCuentaToolStripMenuItem.Click
        Dim SaldoCuenta As Decimal = 0
        Dim NroCheques As String = ""
        Try
            If cboTrabajadorMovimiento.Value = BuscarIdCtaCte(gUsuarioSGI.IdTrabajador, 1, loCuentaCorriente) Then
                Throw New Exception("No Se Puede Habilitar a su misma Cuenta")
            End If
            ' LlenaCombosTrabajadores()
            oeMovimiento = New e_Movimiento
            opcDefinicion.Enabled = False
            cboCaja.Enabled = False
            MostrarTabs(1, ficMovimiento, 1)
            MostrarTabs(1, FicDatos, 1)
            Me.FicDatos.Tabs(2).Enabled = True
            agrDatosViaje.Visible = False
            etiLiquidar.Visible = False
            FicObservacion.Visible = False
            agrCuenta.Visible = False
            Agrupacion8.Enabled = False
            agrIEFF.Visible = False
            ExpGroupBoxReceptor.Visible = False
            oeMovimiento.TipoProceso = "HABILITACION_CUENTA"
            Me.UltraExpandableGroupBoxMovCuenta.Expanded = False
            Agrupacion8.Enabled = False
            opcSalidaEntrada.CheckedIndex = 0
            fechaMovimiento.Value = Date.Now
            oeMovimiento.Fecha = Date.Now
            LimpiarCuenta()
            Dim oeTemp As New e_CuentaCorriente
            If IndCajaPrincipal Then
                If cboTrabajadorMovimiento.SelectedIndex = 0 Then
                    mensajeEmergente.Problema("Seleccione Trabajador Para Habilitar Cuenta", True)
                    oeTemp = Nothing
                    Exit Sub
                End If
                oeTemp.IdTrabajador = idTrabajador
                oeTemp.Tipo = 1
            Else
                oeTemp.IdTrabajador = gUsuarioSGI.IdTrabajador
                oeTemp.Tipo = 0
            End If
            oeTemp = loCuentaCorriente.Item(loCuentaCorriente.IndexOf(oeTemp))
            CargarMovimientosCuentaCorriente(oeTemp.Id, griMovimiento)
            strTrabajador = oeTemp.Trabajador
            idCuentaTrabajador = oeTemp.Id
            oeMovimiento.IdCuentaCorrienteDestino = oeTemp.Id
            cboTrabajadorMovimiento.Value = BuscarIdCtaCte(oeTemp.IdTrabajador, 1, loCuentaCorriente)
            oeChequeEmitido.IdCuentaCorriente = oeTemp.Id
            oeChequeEmitido.TipoOperacion = "3"
            oeChequeEmitido.IdEstado = "1CH00031"
            oeChequeEmitido.Fecha = Date.Parse("01/01/1901")
            oeChequeEmitido.FechaCreacion = Date.Parse("01/01/1901")
            loChequeEmitido = olChequeEmitido.Listar(oeChequeEmitido)
            If loChequeEmitido.Count > 0 Then
                For Each Lista As e_ChequeEmitido In loChequeEmitido
                    decSaldoCuenta.Value = Lista.Importe
                    Me.etiCheque.Text = Lista.NroCheque
                    Me.decImporte.Value = decSaldoCuenta.Value
                    oeMovimiento.IdCheque = Lista.Id
                Next
            Else
                decSaldoCuenta.Value = 0.0
                Me.etiCheque.Text = ""
                Me.decImporte.Value = decSaldoCuenta.Value
                oeMovimiento.IdCheque = ""
            End If

            MostrarTabs(0, ficMovimientoViaje, 0)
            decImporte_ValueChanged(decImporte, e)
            If etiCheque.Text <> "" And decSaldoCuenta.Value <> 0.0 Then
                Me.FicDatos.Tabs(2).Enabled = False
            Else
                Me.FicDatos.Tabs(2).Enabled = True
            End If
            SaldoCuenta = 0
            oeTemp = New e_CuentaCorriente
            oeTemp.IdTrabajador = gUsuarioSGI.IdTrabajador
            oeTemp.Tipo = 0
            oeTemp = loCuentaCorriente.Item(loCuentaCorriente.IndexOf(oeTemp))
            If IndCajaPrincipal Then
                If etiCheque.Text <> "" Then
                    txtGlosa.Text = "Habilitacion cuenta trabajador de: " & oeTemp.Trabajador & " Con Cheque Numero: " & etiCheque.Text
                Else
                    txtGlosa.Text = "Habilitacion cuenta trabajador de: " & oeTemp.Trabajador
                End If
            End If
            Me.btnLiquidar.Visible = False
            ControlBoton(0, 0, 0, 1, 1, 0, 1, 0, 0)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub ReporteFondoFijoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteFondoFijoToolStripMenuItem.Click
        ReporteFondoFijo()
    End Sub

    Private Sub dtpFechaEmision_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Tab Then
            If TipoMov = 1 Then txtRUC.Focus()
        End If
    End Sub

#End Region

#Region "Gasto Operación"

#Region "Declaracion de Variables"

    Dim oeGastoOperacion As New e_GastoOperacion
    Dim olGastoOperacion As New l_GastoOperacion
    Dim leGastoOperacion As New List(Of e_GastoOperacion)

    Dim oeTipoGastoDet As New e_TipoGastoDetalle
    Dim olTipoGastoDet As New l_TipoGastoDetalle
    Dim loTipoGastoDet As New List(Of e_TipoGastoDetalle)

    Dim IdCuentaCte As String = String.Empty
    Dim IdViaje As String = String.Empty
    Dim IndCombo As Boolean = False
    Dim longglosa As Integer = 0
    Dim IdCen As String = ""
    Dim nroid As Integer = 0

#End Region

#Region "Eventos"

    Private Sub txtGlosa2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtGlosa2.KeyDown
        If Keys.Tab = Keys.Tab Then
            If TipoMov = 1 Then
                If cboFlujoCaja.Value = "1CH000000085" Then
                    DecCantidadGalones.Focus()
                    DecCantidadGalones.SelectAll()
                End If
            End If
        End If
    End Sub

    Private Sub cboProveedores_Validated(sender As Object, e As EventArgs) Handles cboProveedores.Validated
        Try
            If cboTipoDocumento.Value = "1SI000000001" Then
                frm = New frm_TarifasProveedor
                frm.Listar(cboProveedores.Value, cboFlujoCaja.Value, IdMaterial, IdCliente)
                frm.ShowDialog()
                Me.numImporte.Value = frm.oeTarifasProveedor.Importe
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
            End If
            Dim ruc As String = ""
            If cboTipoDocumento.Value <> "1CH000000062" Then 'VALE
                For Each prov As e_Proveedor In ListaProveedor
                    If cboProveedores.Value = prov.Id Then
                        ruc = cboProveedores.ActiveRow.Cells("NroDocumento").Value.ToString
                        Exit For
                    End If
                Next
                If ruc <> "" Then
                    txtRUC.Text = ruc
                    If cboFlujoCaja.Text = "COMBUSTIBLES" Then
                        LimpiaCombos(cboLugar)
                        LimpiaCombos(cboDireccion)
                        If Me.cboProveedores.Value <> "" Then
                            CargaLugaresEmpresa(cboProveedores.ActiveRow.Cells("IdEmpresa").Value)
                            Dim obj As New e_Empresa
                            obj.Id = cboProveedores.ActiveRow.Cells("IdEmpresa").Value
                            obj = olEmpresa.Obtener(obj)
                            If Not String.IsNullOrEmpty(obj.IdDireccionTanqueo) Then
                                oeDireccion = New e_Direccion
                                oeDireccion.Activo = True
                                oeDireccion.Id = obj.IdDireccionTanqueo
                                oeDireccion.TipoOperacion = ""
                                oeDireccion = olDireccion.Obtener(oeDireccion)
                                cboLugar.Value = oeDireccion.CCPP
                            End If
                        Else
                            Me.cboLugar.Value = Nothing
                            Me.cboLugar.DataSource = Nothing
                        End If
                    End If
                End If

            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub cboProveedores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProveedores.Click
        cboProveedores.SelectAll()
    End Sub

    Private Sub cboProveedores_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProveedores.Enter
        cboProveedores.SelectAll()
    End Sub

    Private Sub cboProveedores_EditorButtonClick(sender As Object, e As UltraWinEditors.EditorButtonEventArgs) Handles cboProveedores.EditorButtonClick
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            'Select Case e.Button.Key
            '    Case "Right"
            Me.txtRUC.Text = String.Empty
            LlenaComboProveedor()
            'End Select
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub cboProveedores_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboProveedores.ValueChanged
        Try
            Dim oeProv As New e_Proveedor
            With cboProveedores
                If .Value <> Nothing Then
                    oeGastoOperacion.IdProveedor = cboProveedores.Value
                    oeGastoOperacion.Proveedor = cboProveedores.Text
                    If cboFlujoCaja.Text = "COMBUSTIBLES" Then
                        Me.cboLugar.DataSource = Nothing
                        Me.cboDireccion.DataSource = Nothing
                    End If
                    'Agregar Referencia
                    If TipoMov = 1 Then
                        Dim loClienteLugar As New List(Of e_ClienteLugar)
                        Dim olLugar As New l_Lugar
                        loClienteLugar.AddRange(olLugar.ListarClienteLugar(New e_ClienteLugar With {.IdCliente = cboProveedores.Value}))
                        cboReferencia.DataSource = loClienteLugar
                        cboReferencia.DisplayMember = "Nombre"
                        cboReferencia.ValueMember = "Id"
                        cboReferencia.SelectedIndex = -1
                    End If
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboProveedores_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles cboProveedores.InitializeLayout
        Try
            InicializarComboProveedor()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnAceptarDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptarDetalle.Click
        Try
            If Me.dtpFechaEmision.Value.Date > ObtenerFechaServidor.Date Then Throw New Exception("No Puede Guardar un Documento Mayor a la Fecha Actual")
            If TipoMov = 1 And Me.txtEstado.Text <> gNombreEstadoHabilitada Then
                If cboOpcionGasto.SelectedIndex <> 2 Then
                    Throw New Exception("Solo Puede Ingresar Gastos a Viajes Habilitados")
                End If
            End If
            Dim X As Double = numCubrir.Value
            X = Math.Round(X, 2)
            'Peajes
            If TipoMov = 1 AndAlso txtCantidadPeajes.Value <> 0 AndAlso oeGastoOperacion.IdFlujoCaja = IdFCPeajes AndAlso leGastoOperacion.Where(Function(i) i.IdFlujoCaja = IdFCPeajes And i.TipoOperacion <> "E").Count >= txtCantidadPeajes.Value AndAlso _
                MessageBox.Show("Cantidad de peajes excede a la cantidad de peajes configurados. Desea agregar?", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
            ValidaGasto()
            If TipoMov = 1 And Me.numTotal.Value > X Then
                If cboOpcionGasto.SelectedIndex = 0 Then
                    Throw New Exception("No Tiene Monto por Cubrir, No Puede Seguir Agregando Gastos")
                End If
            End If
            Dim olFuncion As New l_FuncionesGenerales
            If ldFechaPeriodo.Date <> Date.Parse(fecPeriodo.Value).Date Or oeGastoOperacion.IdPeriodo Is Nothing Or oePeriodo.Id = "" Then
                ldFechaPeriodo = Date.Parse(fecPeriodo.Value).Date
                oePeriodo = New e_Periodo
                oePeriodo.Ejercicio = fecPeriodo.DateTime.Year
                oePeriodo.Mes = fecPeriodo.DateTime.Month
                oePeriodo = olPeriodo.Obtener(oePeriodo)
                If oePeriodo.Id = "" Then
                    fecPeriodo.Focus()
                    Throw New Exception("No existe el periodo: " & fecPeriodo.DateTime.Month.ToString)
                Else
                    If oePeriodo.CierreCajaLiquidacion Then
                        mensajeEmergente.Problema("El periodo en CajaLiquidacion esta cerrado: " & fecPeriodo.DateTime.Month.ToString, True)
                        fecPeriodo.Focus()
                        Exit Sub
                    End If
                End If
                If oePeriodo.Ejercicio = dtpFechaEmision.Value.Year Then
                    If oePeriodo.Mes < dtpFechaEmision.Value.Month Then
                        mensajeEmergente.Problema("No Puede Ingresar un Gasto a un Periodo Menor", True)
                        fecPeriodo.Focus()
                        Exit Sub
                    End If
                ElseIf oePeriodo.Ejercicio < dtpFechaEmision.Value.Year Then
                    mensajeEmergente.Problema("No Puede Ingresar un Gasto a un Periodo Menor", True)
                    fecPeriodo.Focus()
                    Exit Sub
                End If
                If TipoMov = 2 Then
                    If oePeriodo.Id <> oePerGrupo.Id Then
                        mensajeEmergente.Problema("Periodo Seleccionado Diferente al Periodo del Grupo", True)
                        fecPeriodo.Focus()
                        Exit Sub
                    End If
                Else
                    If oePer.Id <> oePeriodo.Id Then
                        If dtpFechaEmision.Value.Year <= oePeriodo.Ejercicio Then
                            If dtpFechaEmision.Value.Month <= oePer.Mes Then
                                mensajeEmergente.Problema("Periodo " & oePer.Codigo & " Abierto para Tesoreria.", True)
                                fecPeriodo.Focus()
                                Exit Sub
                            End If
                        End If
                    End If
                End If
            End If
            With oeGastoOperacion
                If idCompraAlm <> "" Then
                    .IdDocumento = idCompraAlm
                Else
                    .IdDocumento = ""
                End If
                .IndGasto = cboOpcionGasto.Value
                If txtNumero.Tag <> "" Then
                    .IdTarjetaMovimiento = txtNumero.Tag.ToString().Trim()
                End If
                If TipoMov = 1 Then
                    If loTarjetaMovimiento.Where(Function(i) i.Id = txtNumero.Tag).Count > 0 Then
                        loTarjetaMovimiento.Remove(loTarjetaMovimiento.Where(Function(i) i.Id = txtNumero.Tag).ToList()(0))
                        griMovTarjeta.DataBind()
                    End If
                End If
                .IdPeriodo = oePeriodo.Id
                .UsuarioCreacion = gUsuarioSGI.Id
                .IdViaje = IdViaje
                .Ejercicio = fecPeriodo.DateTime.Year
                If TipoMov = 2 Then
                    .IdCuentaCorriente = CuentaAdm
                    .IdViaje = ""
                    .IdCaja = idCajaCentro
                Else
                    .IdCuentaCorriente = IdCuentaCte
                    If cboAutorizaGasto.SelectedIndex <> -1 Then
                        .IdTrabajadorAutoriza = Me.cboAutorizaGasto.Value
                    Else
                        .IdTrabajadorAutoriza = gUsuarioSGI.IdTrabajador
                    End If
                End If
                .IdFlujoCaja = cboFlujoCaja.Value
                .FlujoCaja = cboFlujoCaja.Text.Trim
                If .IdTipoDocumento = "1CH000000073" Then
                    If VerificaFlujoSustento(.IdFlujoCaja) = False Then
                        cboFlujoCaja.Focus()
                        mensajeEmergente.Problema("Flujo de Caja No Asociado a Documento Sustento Contable", True)
                    End If
                    'ElseIf .IdTipoDocumento = "1SI000000001" Then
                    '    .IndGasto = 1
                End If
                .FechaCreacion = ObtenerFechaServidor()
                If .IdFlujoCaja = "1CH000000021" Then
                    Dim hora2 As DateTime = Me.fecHoraPeaje.Value.TimeOfDay.ToString.Substring(0, 8)
                    Me.dtpFechaEmision.Value = dtpFechaEmision.Value.Date.ToShortDateString + " " + hora2
                    .FechaEmision = Me.dtpFechaEmision.Value
                Else
                    .FechaEmision = dtpFechaEmision.Value
                End If
                .SerieDoc = Me.txtSerie.Text
                .NroDoc = Me.txtNumero.Text
                .IdTipoDocumento = cboTipoDocumento.Value
                .TipoDocumento = cboTipoDocumento.Text.Trim
                .IdProveedor = cboProveedores.Value
                .Proveedor = cboProveedores.Text
                .IdPiloto = idPiloto
                If TipoMov = 2 Then
                    .Glosa = txtGlosa2.Text.Trim & " " & Me.cboTrabajador2.Text & " / " & Me.cboArea.Text
                    If cboPlaca.Text <> "" Then
                        .Glosa = .Glosa & " / " & Me.cboPlaca.Text
                    End If
                Else
                    .Glosa = txtGlosa2.Text.Trim
                End If
                .TipoCambio = numTipoCambio.Value
                .SubTotal = numImporte.Value
                .IGV = numIGV.Value
                .Total = numTotal.Value
                .IdGrupo = cboGrupo.Value
                .NroGrupo = cboGrupo.Text
                If .IdMoneda = "" Then .IdMoneda = "1CH01"
                .TipoOperacion = "I"
                .TipoMovimiento = TipoMov
                If TipoMov = 1 Then .IdEstado = "1CH00012"
                .Mac = MacPCLocal()
                If TipoMov = 1 Then
                    .Piloto = txtPiloto.Text
                    .IdTracto = oeViaje.IdTracto
                    If cboLugarL.SelectedIndex <> -1 Then .IdLugar = cboLugarL.Value
                ElseIf TipoMov = 2 Then
                    .Piloto = cboTrabajador2.Text
                    .IdEstado = "1CH00014"
                    .IndAlmacen = IndCompraAlmacen
                End If
                .IdPiloto = idPiloto
                .oeMovimientoDocumento = New e_MovimientoDocumento
                With .oeMovimientoDocumento
                    .Id = IdDocumentoAlmacen
                    .Serie = Me.txtSerie.Text
                    .Numero = Me.txtNumero.Text
                    .IdTipoDocumento = cboTipoDocumento.Value
                    .IdClienteProveedor = cboProveedores.Value
                    .IdCuentaContable = IdCuentaContableCompraAlmacen
                    .GlosaViajeGrupo = IIf(TipoMov = 1, oeViaje.Codigo + "/" + cboGrupo.Text, cboGrupo.Text)
                    .SubTotal = numImporte.Value + DecNoGravada.Value
                    .IGV = numIGV.Value + DecPercepcion.Value
                    .Total = numTotal.Value
                    .Ejercicio = fecPeriodo.DateTime.Year
                    .FechaEmision = dtpFechaEmision.Value
                    .FechaVencimiento = .FechaEmision
                    .NoGravado = DecNoGravada.Value
                    If .IdTipoDocumento <> "1CH000000062" And IndCompraAlmacen = False And .IdClienteProveedor <> "" Then
                        olFuncion.ValidarDocumentoDuplicado(oeGastoOperacion.oeMovimientoDocumento)
                    End If
                    .FechaFinal = oePeriodo.FechaFin
                End With
                If TipoMov = 2 Then
                    .oeGasto_Caja = New e_Gasto_Caja
                    With .oeGasto_Caja
                        .CentroGasto = cboCentroCosto.Value
                        .IdPiloto = cboTrabajador2.Value
                        .IdRuta = cboRuta.Value
                        .UsuarioAutoriza = cboAutoriza.Value
                        .IdTipoGasto = cboTipoGasto.Value
                        .IdArea = cboArea.Value
                        .IdPlaca = cboPlaca.Value
                        .IdGastoFuncion = cboGastoFuncion.Value
                        If .IdTipoGasto = "1CH000000006" Or .IdTipoGasto = "1CH000000009" Or .IdTipoGasto = "1CH000000010" Then
                            If cboPlaca.Text = "" Then
                                Throw New Exception("Ingrese Placa Por Favor")
                            End If
                        End If
                        If cboPlaca.Text <> "" Then
                            Dim oeGasVeh As New e_GastoVehiculo
                            Placas = New List(Of e_GastoVehiculo)
                            For i As Integer = 0 To Placas1.Count - 1
                                oeGasVeh = New e_GastoVehiculo
                                oeGasVeh.IdVehiculo = Placas1(i).ToString
                                Placas.Add(oeGasVeh)
                            Next
                            .loGastoVehiculo = Placas
                        End If
                        .IndCompraAlmacen = IndCompraAlmacen
                    End With
                End If
                Dim oeFlCj As New e_FlujoCaja
                oeFlCj.Id = .IdFlujoCaja
                oeFlCj.Ejercicio = oePeriodo.Ejercicio
                If ListaFlujoCuenta.Where(Function(i) i.Id = oeFlCj.Id And i.Ejercicio = oeFlCj.Ejercicio).Count > 0 Then
                    oeFlCj = ListaFlujoCuenta.Item(ListaFlujoCuenta.IndexOf(oeFlCj))
                    .oeFlujoCaja = oeFlCj
                Else
                    Throw New Exception("Flujo Caja Sin Cuenta Contable... Verificar")
                End If
                With .oeMovimientoDocumento.Compra
                    .OtrosTributos = DecPercepcion.Value
                    .NoGravadas = DecNoGravada.Value + IIf(numIGV.Value = 0, numImporte.Value, 0)
                    .TipoDoc = oeTipoDocGasto
                    .Proveedor = oeProveedorGasto
                    .Moneda = oeMonedaGasto
                    .Base1 = IIf(numIGV.Value = 0, 0, numImporte.Value)
                    .Igv1 = numIGV.Value
                    .TotalIGVCompra = numIGV.Value
                    .TotalBaseCompra = IIf(numIGV.Value = 0, 0, numImporte.Value)
                    .Proveedor = oeProveedorGasto
                    .TipoDoc = oeTipoDocGasto
                    .TipoCompra = New e_TablaContableDet
                    .TipoCompra.Id = oeFlCj.IdTipoCompra
                    .PagoXCajaTesoreria = DecPagoxCaja.Value
                End With
                If cboTipoDocumento.Text = "VALE" Or cboTipoDocumento.Text = "SUSTENTO CONTABLE" Then
                    .GastoAsiento = New e_GastoAsiento
                    With .GastoAsiento
                        .TipoOperacion = "I"
                    End With
                    DecPagoxCaja.Value = numTotal.Value
                End If
                '---capturo datos a ingresa-----
                Dim oeMovAn As New e_MovimientoAnalisis
                Dim leListaAn As New List(Of e_MovimientoAnalisis)
                Dim Divide As Integer = 0
                .oeMovimientoDocumento.MovimientoAnalisis = New List(Of e_MovimientoAnalisis)
                If ChkVehiculoProper.Checked Then
                    Dim checkedItemList As ICheckedItemList = DirectCast(cboPlaca.Items.ValueList, ICheckedItemList)
                    For i As Integer = 0 To cboPlaca.Items.Count - 1
                        Dim item As ValueListItem = cboPlaca.Items(i)
                        Dim checkState__1 As CheckState = checkedItemList.GetCheckState(i)
                        If checkState__1 = CheckState.Checked Then
                            oeMovAn = New e_MovimientoAnalisis
                            Divide = Divide + 1
                            oeMovAn.TipoOperacion = "I"
                            oeMovAn.IdItemGasto = oeFlCj.IdItemGasto
                            oeMovAn.IdTrabajador = idPiloto
                            oeMovAn.IdVehiculo = oeViaje.IdTracto
                            oeMovAn.IdRuta = "" 'viaje trabaja con origen y destino
                            oeMovAn.Monto = numImporte.Value + DecNoGravada.Value
                            oeMovAn.Saldo = numImporte.Value + DecNoGravada.Value
                            oeMovAn.IdGastoFuncion = IIf(TipoMov = 2, "1CH000087", IIf(cboGastoFuncion.Value Is Nothing, "1CH000087", cboGastoFuncion.Value))
                            oeMovAn.IdCuentaContable = oeFlCj.CtaContable
                            leListaAn.Add(oeMovAn)
                        End If
                    Next
                Else
                    Divide = 1
                    oeMovAn.TipoOperacion = "I"
                    oeMovAn.IdItemGasto = oeFlCj.IdItemGasto
                    oeMovAn.IdTrabajador = idPiloto
                    oeMovAn.IdVehiculo = oeViaje.IdTracto
                    oeMovAn.IdRuta = "" 'viaje trabaja con origen y destino
                    oeMovAn.Monto = numImporte.Value + DecNoGravada.Value
                    oeMovAn.Saldo = numImporte.Value + DecNoGravada.Value
                    oeMovAn.IdGastoFuncion = IIf(TipoMov = 2, "1CH000087", IIf(cboGastoFuncion.Value Is Nothing, "1CH000087", cboGastoFuncion.Value)) '--costo de venta
                    oeMovAn.IdCuentaContable = oeFlCj.CtaContable
                    leListaAn.Add(oeMovAn)
                End If
                For Each obj As e_MovimientoAnalisis In leListaAn
                    obj.Monto = obj.Monto / Divide
                    obj.Saldo = obj.Saldo / Divide
                    If cboTipoDocumento.Text = "SUSTENTO CONTABLE" Then
                        If (cboFlujoCaja.Text = "PAGO DE ITF" _
                            Or cboFlujoCaja.Text = "COMISIONES COBRADAS POR LOS BANCOS" _
                            Or cboFlujoCaja.Text = "PLANILLA DE MOVILIDAD") Then
                            obj.IdGastoFuncion = "1CH000088" 'gasto administrativo
                        ElseIf cboFlujoCaja.Text = "DESCUENTOS JUDICIALES" Then
                            obj.IdGastoFuncion = "" 'cta 46 no tiene destino
                        End If
                    End If
                    .oeMovimientoDocumento.MovimientoAnalisis.Add(obj)
                Next
            End With
            With oeGastoOperacion
                .oeRegistroCombustible = New e_RegistroConsumoCombustible
                If cboFlujoCaja.Value = "1CH000000085" Then
                    .oeRegistroCombustible.TipoOperacion = "I"
                    .oeRegistroCombustible.NroVale = .SerieDoc & " - " & .NroDoc
                    .oeRegistroCombustible.KilometrosTanqueo = 0
                    .oeRegistroCombustible.IdMaterial = cboMaterial.Value
                    .oeRegistroCombustible.IdGrifo = cboProveedores.ActiveRow.Cells("IdEmpresa").Value
                    .oeRegistroCombustible.IdLugar = cboLugar.Value
                    .oeRegistroCombustible.IdDireccion = cboDireccion.Value
                    .oeRegistroCombustible.IndCredito = False
                    .oeRegistroCombustible.IndTanqueo = False
                    .oeRegistroCombustible.IdRegistroInventario = ""
                    .oeRegistroCombustible.UsuarioCreacion = gUsuarioSGI.Id
                    .oeRegistroCombustible.CantidadGalon = DecCantidadGalones.Value
                    .oeRegistroCombustible.Activo = True
                    .oeRegistroCombustible.Ind_GastoViaje = 1
                    .oeRegistroCombustible.Estado = "CON"
                    .oeRegistroCombustible.FechaTanqueo = dtpFechaEmision.Value
                    .oeRegistroCombustible.IndIsl = False
                    If .TipoMovimiento = 2 Then
                        .oeRegistroCombustible.IdVehiculo = .oeGasto_Caja.IdPlaca
                        .oeRegistroCombustible.IdPiloto = cboTrabajador2.Value
                        .oeRegistroCombustible.IdViaje = ""
                    Else
                        .oeRegistroCombustible.IdViaje = IdViaje
                        .oeRegistroCombustible.IdVehiculo = txtTracto.Tag
                        .oeRegistroCombustible.IdPiloto = idPiloto
                    End If
                    With .oeMovimientoDocumento
                        .IndServicioMaterial = "M"
                        Dim oeDetalleDoc As New e_DetalleDocumento
                        oeDetalleDoc.TipoOperacion = "I"
                        oeDetalleDoc.IndServicioMaterial = "M"
                        oeDetalleDoc.IdMaterialServicio = cboMaterial.Value
                        oeDetalleDoc.Cantidad = oeGastoOperacion.oeRegistroCombustible.CantidadGalon
                        oeDetalleDoc.Precio = numImporte.Value / oeDetalleDoc.Cantidad
                        oeDetalleDoc.Subtotal = numImporte.Value
                        oeDetalleDoc.IndGravado = IIf(numIGV.Value > 0, True, False)
                        oeDetalleDoc.Igv = numIGV.Value + DecPercepcion.Value
                        oeDetalleDoc.Total = numTotal.Value
                        oeDetalleDoc.IdVehiculo = oeViaje.IdTracto
                        .lstDetalleDocumento.Add(oeDetalleDoc)
                    End With
                Else
                    .oeRegistroCombustible = Nothing
                    With .oeMovimientoDocumento
                        .IndServicioMaterial = "S"
                        Dim oeDetalleDoc As New e_DetalleDocumento
                        oeDetalleDoc.TipoOperacion = "I"
                        oeDetalleDoc.IndServicioMaterial = "S"
                        oeDetalleDoc.IdMaterialServicio = "1PY000000002" 'GASTOS DE VIAJE
                        oeDetalleDoc.Cantidad = 1
                        oeDetalleDoc.Precio = numImporte.Value + DecNoGravada.Value
                        oeDetalleDoc.Subtotal = numImporte.Value + DecNoGravada.Value
                        oeDetalleDoc.IndGravado = IIf(numIGV.Value > 0, True, False)
                        oeDetalleDoc.Igv = numIGV.Value + DecPercepcion.Value
                        oeDetalleDoc.Total = numTotal.Value
                        oeDetalleDoc.IdVehiculo = oeViaje.IdTracto
                        .lstDetalleDocumento.Add(oeDetalleDoc)
                    End With
                End If
            End With
            If oeGastoOperacion.TipoOperacion = "I" Then
                nroid = nroid + 1
                oeGastoOperacion.Id = nroid
            End If
            If griGastoOperacion.Rows.Count = 0 Then MostrarGO(leGastoOperacion)
            With oeGastoOperacion
                If ValidarGasto(.SerieDoc, oeGastoOperacion.NroDoc, .IdTipoDocumento, .IdProveedor, .IdTarjetaMovimiento, .IdGrupo) Then
                    CrearComboGrid("IdFlujoCaja", "Nombre", griGastoOperacion, olFlujoCaja.ComboGrilla(ListaFlujoCaja), True)
                    If .IndGasto = 0 Then
                        aux1 = numAgregado.Value
                        numAgregado.Value = numAgregado.Value + .Total
                    End If
                    Modificado = True
                    leGastoOperacion.Add(oeGastoOperacion)
                    griGastoOperacion.DataBind()
                    idCompraAlm = ""
                    IdCuentaContableCompraAlmacen = ""
                    IdDocumentoAlmacen = ""
                    IndCompraAlmacen = False
                    DecPagoxCaja.Enabled = False
                    chkPagoxCaja.Checked = True
                    If MessageBox.Show("¿Desea seguir Agregando Documentos?", "Mensaje de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                        LimpiarDatoDetalle(False)
                    Else
                        LimpiarDatoDetalle()
                        fecPeriodo.Focus()
                        fecPeriodo.SelectAll()
                        agrDatos.Expanded = False
                        BanderaDocSustento = False
                    End If
                    DecCantidadGalones.Value = 0
                    cboMaterial.SelectedIndex = -1
                    cboLugar.SelectedIndex = -1
                    cboDireccion.SelectedIndex = -1
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnCancelarDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarDetalle.Click
        Try
            If TipoMov = 1 Then
                If txtEstado.Text = "HABILITADA" Then
                    QuitarGastoOperacion()
                End If
            Else
                QuitarGastoOperacion()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboTipoGasto_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoGasto.ValueChanged
        If TipoMov = 2 Then
            LlenarFlujoItemGasto()
        End If
    End Sub

    Private Sub txtSerie_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSerie.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtSerie_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSerie.Validated
        txtSerie.Text = gfc_ConcatenarCeros(txtSerie.Text, lenSerie)
        oeGastoOperacion.SerieDoc = txtSerie.Text
    End Sub

    Private Sub txtNumero_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNumero.GotFocus
        txtNumero.SelectAll()
    End Sub

    Private Sub txtNumero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumero.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
        If Me.cboTipoDocumento.Value = "1CH000000047" Then
            If Char.IsLetter(e.KeyChar) Then
                e.Handled = False
            ElseIf Char.IsControl(e.KeyChar) Then
                e.Handled = False
            ElseIf Char.IsDigit(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtNumero_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumero.Validated
        'If IsNumeric(txtNumero.Text) Or txtNumero.Text = "" Then
        '    Me.txtNumero.Text = FormatoDocumento(txtNumero.Text, 10)
        'Else
        '    Me.txtNumero.Text = FormatoDocumento(txtNumero.Text, 15)
        'End If
        txtNumero.Text = gfc_ConcatenarCeros(txtNumero.Text, lenNumero)
        oeGastoOperacion.NroDoc = txtNumero.Text
    End Sub

    Private Sub fecHasta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles fecHasta.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        If KeyAscii = Keys.Tab Then
            Me.txtCodViaje.Focus()
            Me.txtCodViaje.SelectAll()
        End If
    End Sub

    Private Sub txtRUC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRUC.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub cboTrabajador2_Validated(sender As Object, e As EventArgs) Handles cboTrabajador2.Validated
        Dim oeMovimientoPersonal As New e_MovimientoPersonal
        If cboTrabajador2.SelectedIndex > -1 Then
            oeMovimientoPersonal.IdTrabajador = cboTrabajador2.Value
            Dim oeTrabajador As New e_Trabajador
            Dim olTrabajador As New l_Trabajador
            oeTrabajador.Id = oeMovimientoPersonal.IdTrabajador
            oeTrabajador.CargaCompleto = False
            oeTrabajador = olTrabajador.Obtener(oeTrabajador)
            cboArea.Value = oeTrabajador.oeArea.Id
        Else
            cboArea.Value = "1PY000000001"
        End If
    End Sub

    Private Sub cboArea_Enter(sender As Object, e As EventArgs) Handles cboArea.Enter
        cboArea.SelectAll()
    End Sub

    Private Sub cboTipoDocumento_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTipoDocumento.Validated
        'If cboTipoDocumento.Value = "1CH000000047" Then
        '    Me.txtNumero.MaxLength = 20
        'Else
        '    Me.txtNumero.MaxLength = 10
        'End If
        VerificarDocSustento()
    End Sub

    Private Sub cboTipoDocumento_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoDocumento.ValueChanged
        If cboTipoDocumento.SelectedIndex > -1 Then
            oeTipoDocGasto = cboTipoDocumento.Items(cboTipoDocumento.SelectedIndex).ListObject
            If oeTipoDocGasto.IndIGV = 1 Then
                IndicadorIGV = True
            Else
                IndicadorIGV = False
            End If
            CalculaTotal()
            oeGastoOperacion.IdTipoDocumento = cboTipoDocumento.Value
            oeGastoOperacion.TipoDocumento = cboTipoDocumento.Text
            VerificarDocSustento()
            If TipoMov = 1 AndAlso cboOpcionGasto.Visible Then
                If cboTipoDocumento.Value = IdTDOrdenTrabajo Then
                    cboOpcionGasto.SelectedIndex = 3
                    cboOpcionGasto.Enabled = False
                Else
                    cboOpcionGasto.Enabled = True
                End If
            End If
            lenSerie = gfc_ObtieneLongitudSerie(oeTipoDocGasto.Codigo)
            txtSerie.MaxLength = lenSerie
            lenNumero = gfc_ObtieneLongitudNumero(oeTipoDocGasto.Codigo)
            txtNumero.MaxLength = lenNumero
        End If
    End Sub

    Private Sub numImporte_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numImporte.ValueChanged
        If IsNumeric(numImporte.Value) Then
            CalculaTotal()
        Else
            numImporte.Value = 0
        End If
    End Sub

    Private Sub cboFlujoCaja_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboFlujoCaja.ValueChanged
        Try
            If cboFlujoCaja.SelectedIndex > -1 Then
                'oeFlujoCaja = cboFlujoCaja.Items(cboFlujoCaja.SelectedIndex).ListObject
                oeGastoOperacion.IdFlujoCaja = cboFlujoCaja.Value
                oeGastoOperacion.FlujoCaja = cboFlujoCaja.Text
                If TipoMov = 1 Then
                    txtGlosa2.Text = cboFlujoCaja.Text
                End If
                longglosa = txtGlosa2.Text.Trim.Length

                If cboFlujoCaja.Value = "1CH000000085" Then
                    ExpRegistroConsumoCombustible.Visible = True
                    ExpRegistroConsumoCombustible.Expanded = True
                    ChkVehiculoProper.Checked = False
                    ChkVehiculoProper.Enabled = False
                Else
                    ExpRegistroConsumoCombustible.Visible = False
                    ExpRegistroConsumoCombustible.Expanded = False
                    DecCantidadGalones.Value = 0
                    ChkVehiculoProper.Enabled = True
                End If
                If cboFlujoCaja.Value = "1CH000000021" Then
                    fecHoraPeaje.Visible = IIf(TipoMov = 1, True, False)

                Else
                    fecHoraPeaje.Visible = False
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub dtpFechaEmision_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaEmision.ValueChanged
        oeGastoOperacion.FechaEmision = dtpFechaEmision.Value
    End Sub

    Private Sub griGastoOperacion_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griGastoOperacion.CellChange
        Try
            griGastoOperacion.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema("No Puede Tener Datos Vacíos", True)
        End Try
    End Sub

    Private Sub tsmiQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        QuitarGastoOperacion()
    End Sub

    Private Sub cboMoneda_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboMoneda.ValueChanged
        If cboMoneda.SelectedIndex > -1 Then
            oeGastoOperacion.IdMoneda = cboMoneda.Value
            oeGastoOperacion.Moneda = cboMoneda.Text
            Dim i As Integer = cboMoneda.SelectedIndex
            oeMonedaGasto = cboMoneda.Items(i).ListObject
        End If
    End Sub

    Private Sub cboLugarL_Enter(sender As Object, e As EventArgs) Handles cboLugarL.Enter
        cboLugar.SelectAll()
    End Sub

    Private Sub dtpFecVencimiento_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        oeGastoOperacion.FechaVencimiento = dtpFecVencimiento.Value
    End Sub

    Private Sub cboAutoriza_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAutoriza.ValueChanged
        If cboAutoriza.SelectedIndex > -1 Then oeGastoOperacion.oeGasto_Caja.UsuarioAutoriza = cboAutoriza.Value
    End Sub

    Private Sub numTotal_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numTotal.ValueChanged
        'CalculaTotal()
        If numTotal.Value > 0 Then
            If numTotal.Value > numCubrir.Value And TipoMov = 1 Then
                numTotal.Appearance.BackColor = Color.Red
                ToolTip.Enabled = True
                Dim ToolTipInfo As New UltraWinToolTip.UltraToolTipInfo
                ToolTipInfo.ToolTipTitle = "Información del sistema"
                ToolTipInfo.ToolTipText = "El total del documento supera al Monto por Cubrir"
                ToolTipInfo.ToolTipImage = ToolTipImage.Warning
                ToolTip.SetUltraToolTip(numTotal, ToolTipInfo)
            Else
                numTotal.Appearance.BackColor = Color.Transparent
                ToolTip.Enabled = False
            End If
            DecPagoxCaja.Value = numTotal.Value
        End If

    End Sub

    Private Sub numIGV_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numIGV.ValueChanged
        If IsDBNull(numIGV.Value) Then numIGV.Value = 0.0
        If IsNumeric(numIGV.Value) Then
            numTotal.Value = numImporte.Value + numIGV.Value + DecNoGravada.Value + DecPercepcion.Value
        Else
            numIGV.Value = 0
        End If
    End Sub

    Private Sub numImporte_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles numImporte.KeyDown
        If e.KeyCode = Keys.Tab Then
            numIGV.Focus()
        End If
    End Sub

    Private Sub numIGV_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles numIGV.KeyDown
        If e.KeyCode = Keys.Tab Then
            If TipoMov = 1 Then
                cboAutorizaGasto.Focus()
                cboAutorizaGasto.SelectAll()
            Else
                txtGlosa2.Focus()
            End If
        End If
    End Sub

    Private Sub numTotal_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles numTotal.KeyDown
        If e.KeyCode = Keys.Tab Then
            txtGlosa2.Focus()
        End If
    End Sub

    Private Sub txtGlosa2_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGlosa2.Leave

    End Sub

    Private Sub txtGlosa2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGlosa2.ValueChanged
        oeGastoOperacion.Glosa = txtGlosa2.Text.Trim
    End Sub

    Private Sub agrDatos_ExpandedStateChanging(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles agrDatos.ExpandedStateChanging
        If agrDatos.Expanded Then agrDatos.Height = IIf(TipoMov = 1, 239, 327)
    End Sub

    Private Sub cboTipoDocumento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoDocumento.Click
        cboTipoDocumento.SelectAll()
    End Sub

    Private Sub cboTipoDocumento_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoDocumento.Enter
        cboTipoDocumento.SelectAll()
    End Sub

    Private Sub txtRUC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRUC.Click
        txtRUC.SelectAll()
    End Sub

    Private Sub txtRUC_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRUC.Enter
        txtRUC.SelectAll()
    End Sub

    Private Sub btnCancelarDetalle_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btnCancelarDetalle.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        If KeyAscii = Keys.Tab Then
            cboFlujoCaja.Focus()
            cboFlujoCaja.SelectAll()
        End If
    End Sub

    Private Sub numImporte_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles numImporte.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        If KeyAscii = Keys.Tab Then
            numIGV.Focus()
            numIGV.SelectAll()
        End If
    End Sub

    Private Sub txtSerie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSerie.Click
        txtSerie.SelectAll()
    End Sub

    Private Sub txtSerie_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSerie.Enter
        txtSerie.SelectAll()
    End Sub

    Private Sub txtNumero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumero.Click
        txtNumero.SelectAll()
    End Sub

    Private Sub txtGlosa2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGlosa2.Enter
        txtGlosa2.SelectAll()
    End Sub

    Private Sub txtGlosa2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGlosa2.Click
        txtGlosa2.SelectAll()
    End Sub

    Private Sub griGastoOperacion_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griGastoOperacion.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        If MessageBox.Show("¿Desea Quitar el Registro?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
            Exit Sub
        End If
    End Sub

    Private Sub griGastoOperacion_ClickCell(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.ClickCellEventArgs) Handles griGastoOperacion.ClickCell
        Try
            Select Case e.Cell.Column.Key
                Case "Glosa"
                    'If griGastoOperacion.ActiveRow.Cells("Id").Value.ToString.Length < 15 Then
                    griGastoOperacion.DisplayLayout.Bands(0).Columns("Glosa").CellClickAction = CellClickAction.EditAndSelectText
                    'Else
                    '    griGastoOperacion.DisplayLayout.Bands(0).Columns("Glosa").CellClickAction = CellClickAction.RowSelect
                    'End If
                    'Case "SubTotal"
                    '    If griGastoOperacion.ActiveRow.Cells("Id").Value.ToString.Length < 15 Then
                    '        griGastoOperacion.DisplayLayout.Bands(0).Columns("SubTotal").CellClickAction = CellClickAction.EditAndSelectText
                    '    Else
                    '        griGastoOperacion.DisplayLayout.Bands(0).Columns("SubTotal").CellClickAction = CellClickAction.RowSelect
                    '    End If
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboFlujoCaja_EditorButtonClick(sender As Object, e As UltraWinEditors.EditorButtonEventArgs) Handles cboFlujoCaja.EditorButtonClick
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            'Select Case e.Button.Key
            '    Case "Right"
            LlenarComboFlujoCaja()
            If TipoMov = 2 Then
                CargarTipoGastoDetalle()
                LlenarFlujoItemGasto()
            End If
            'End Select
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub cboLugarL_EditorButtonClick(sender As Object, e As UltraWinEditors.EditorButtonEventArgs) Handles cboLugarL.EditorButtonClick
        Try
            Dim Formulario As New frm_Lugar
            Dim oeCombo As New e_Combo
            Dim olCombo As New l_Combo
            Formulario.Proceso = "TES"
            Formulario.ShowDialog()
            Formulario.Dispose()
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
            LugaresPublic = New List(Of e_Combo)
            oeCombo = New e_Combo
            oeCombo.Nombre = "Lugares"
            LugaresPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)
            LlenarCombo(cboLugarL, "Nombre", LugaresPublic, -1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboTipoGasto_EditorButtonClick(sender As Object, e As UltraWinEditors.EditorButtonEventArgs) Handles cboTipoGasto.EditorButtonClick
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            'Select Case e.Button.Key
            '    Case "Right"
            CargarTipoGasto(True)
            'End Select
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub cboDireccion_Leave(sender As Object, e As EventArgs) Handles cboDireccion.Leave
        btnAceptarDetalle.Focus()
    End Sub

    Private Sub cboAutorizaGasto_Enter(sender As Object, e As EventArgs) Handles cboAutorizaGasto.Enter
        Me.cboAutorizaGasto.SelectAll()
    End Sub

#End Region

#Region "Metodos"

    Private Sub CargarCombosRG()
        Try
            Dim fechaPer As Date = ObtenerFechaServidor()
            CargarTipoGasto(False)
            CargarTipoDocumento()
            CargarMoneda()
            CargarFlujoCaja()
            If TipoMov = 1 Then
                CargarGrupo(1, cboGrupo)
                oePer = New e_Periodo
                oePer.Ejercicio = fechaPer.Year
                oePer = olPeriodo.ObtenerPeriodoVigente(oePer, 6)
                cboAutorizaGasto.Visible = True
                Me.Etiqueta34.Visible = True
                Me.Etiqueta19.Visible = True
                Me.cboLugarL.Visible = True
                'Etiqueta48.Visible = True
                'cboReferencia.Visible = True
                Etiqueta45.Visible = True
                cboOpcionGasto.Visible = True
                CargarLugar()
            Else
                CargarGrupo(2, cboGrupo)
                cboAutorizaGasto.Visible = False
                Me.Etiqueta34.Visible = False
                Me.Etiqueta19.Visible = False
                Me.cboLugarL.Visible = False
                'Etiqueta48.Visible = False
                'cboReferencia.Visible = False
                Etiqueta45.Visible = False
                cboOpcionGasto.Visible = False
            End If
            CargarMaterial()
            CargarGastoFuncion()
            If TipoMov = 2 Then
                CargarTipoGastoDetalle()
                CargarTrabajador()
                CargarRuta()
                CargarPlaca()
                CargaFlujoCajaConta()
                CargarAreaTrabajador()
                CargarAutoriza()
                CargarFlujoPlaca()
                LlenarCombo(cboCentroCosto, "Nombre", loCaja, -1)
                cboCentroCosto.Value = idCajaCentro
                cboGastoFuncion.Value = "1CH000087"
            Else
                CargarTrabajadorAutoriza()

            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub CargaFlujoCajaConta()
        Dim oeFlujoCajaConta As New e_FlujoCaja
        If leFlujoCajaConta.Count = 0 Then
            oeFlujoCajaConta.TipoOperacion = "P"
            oeFlujoCajaConta.NombProceso = "FLUJOCONTA"
            leFlujoCajaConta = olFlujoCaja.Listar(oeFlujoCajaConta)
        End If
    End Sub

    Private Sub CargarAreaTrabajador()
        If ListaAreaTrabajador.Count = 0 Then
            Dim oeArea As New e_Area
            Dim olArea As New l_Area
            oeArea.IndSector = -1
            ListaAreaTrabajador.AddRange(olArea.Listar(oeArea))
            LlenarCombo(cboArea, "Nombre", ListaAreaTrabajador, -1)
        End If
    End Sub

    Private Sub CargarLugar()
        If cboLugarL.Items.Count = 0 Then LlenarCombo(cboLugarL, "Nombre", LugaresPublic, -1)
    End Sub

    Private Sub CargaLugaresEmpresa(IdEmpresa As String)
        Try
            oeCcpp = New e_CCPP
            oeCcpp.TipOoperacion = 1
            oeCcpp.Activo = True
            oeCcpp.Nombre = IdEmpresa
            LimpiaCombos(cboLugar)
            LlenarCombo(cboLugar, "Nombre", olCcpp.Listar(oeCcpp), -1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargaDireccionesGrifo(IdEmpresa As String)
        Try
            oeDireccion = New e_Direccion
            oeDireccion.TipoOperacion = 1
            oeDireccion.IdTipoVia = IdEmpresa
            oeDireccion.Activo = True
            oeDireccion.Id = cboLugar.Value
            LimpiaCombos(cboDireccion)
            LlenarCombo(cboDireccion, "Via", olDireccion.Listar(oeDireccion), 0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function ValidarGasto(Serie As String, Numero As String, IdTipoDocumento As String, IdProveedor As String, IdTarjetaMovimiento As String, IdGrupo As String) As Boolean
        Try
            If leGastoOperacion.Count > 0 Then
                For Each gasope As e_GastoOperacion In leGastoOperacion
                    If gasope.TipoOperacion <> "E" AndAlso gasope.IdTipoDocumento <> "1CH000000062" Then
                        If gasope.SerieDoc = Serie And gasope.NroDoc = Numero And gasope.IdProveedor = IdProveedor And gasope.IdTipoDocumento = IdTipoDocumento Then
                            Throw New Exception("Documento Duplicado Verificar")
                        End If
                        If Not String.IsNullOrEmpty(txtNumero.Tag.ToString().Trim()) AndAlso gasope.IdTarjetaMovimiento = IdTarjetaMovimiento Then
                            Throw New Exception("Movimiento peaje duplicado")
                        End If
                        If gasope.IdTipoDocumento = "1SI000000001" AndAlso IdTipoDocumento = "1SI000000001" Then
                            Throw New Exception("Solo puede Ingresar una OT por Viaje")
                        End If
                        If gasope.IdGrupo <> IdGrupo And gasope.IndAlmacen = False And gasope.IndGasto <> 1 And gasope.IndGasto <> 2 Then
                            Throw New Exception("No Puede Ingresar Gastos en el Viaje de otro Grupo")
                        End If
                    End If
                Next
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub CargarMaterial()
        If cboMaterial.Items.Count = 0 Then
            oeMaterial = New e_Material
            oeMaterial.TipoOperacion = "O"
            oeMaterial.Activo = True
            LlenarComboMaestro(cboMaterial, olMaterial.Listar(oeMaterial), -1)
        End If
    End Sub

    Private Sub CargarFlujoCaja()
        Try
            LlenarComboFlujoCaja()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub CargarTipoGasto(ByVal Indicador As Boolean)
        Try
            If Indicador Then
                LlenarComboTipoGasto()
            Else
                If cboTipoGasto.Items.Count = 0 Then
                    LlenarComboTipoGasto()
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub CargarTipoDocumento()
        Try
            If cboTipoDocumento.Items.Count = 0 Then
                Dim oeTipoDoc As New e_TipoDocumento
                Dim olTipoDoc As New l_TipoDocumento
                oeTipoDoc.TipoOperacion = "S"
                ListaTipoDocumento = New List(Of e_TipoDocumento)
                ListaTipoDocumento.AddRange(olTipoDoc.Listar(oeTipoDoc))
                LlenarCombo(cboTipoDocumento, "Nombre", ListaTipoDocumento, -1)
                LlenarCombo(cboDocumentoAlmacen, "Nombre", ListaTipoDocumento, -1)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarMoneda()
        Try
            If cboMoneda.Items.Count = 0 Then
                Dim oeMoneda As New e_Moneda
                Dim olMoneda As New l_Moneda
                LlenarCombo(cboMoneda, "Abreviatura", olMoneda.Listar(oeMoneda), 0)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub LlenarComboFlujoCaja()
        Try
            oeFlujoCaja = New e_FlujoCaja
            oeFlujoCaja.TipoOperacion = "P"
            oeFlujoCaja.NombProceso = "Tesoreria"
            ListaFlujoCaja = New List(Of e_FlujoCaja)
            ListaFlujoCaja = olFlujoCaja.Listar(oeFlujoCaja)
            Dim listaIdsFlujoCaja As List(Of String)
            listaIdsFlujoCaja = loConcepto.Select(Function(x) x.Valor1).ToList
            ListaFlujoCaja = ListaFlujoCaja.Where(Function(x) listaIdsFlujoCaja.Contains(x.Id)).ToList
            LlenarCombo(cboFlujoCaja, "Nombre", ListaFlujoCaja, -1)

            oeFlujoCaja = New e_FlujoCaja
            oeFlujoCaja.TipoOperacion = "C"
            oeFlujoCaja.NombProceso = "Tesoreria"
            ListaFlujoCuenta = New List(Of e_FlujoCaja)
            ListaFlujoCuenta.AddRange(olFlujoCaja.Listar(oeFlujoCaja))
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenarComboTipoGasto()
        Try
            Dim oeTipoGasto As New e_TipoGasto
            Dim olTipoGasto As New l_TipoGasto
            ListaTipoGasto = New List(Of e_TipoGasto)
            ListaTipoGasto = olTipoGasto.Listar2(oeTipoGasto)
            LlenarCombo(cboTipoGasto, "Nombre", ListaTipoGasto, -1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenarFlujoItemGasto()
        Try
            LimpiaCombos(cboFlujoCaja)
            If cboTipoGasto.SelectedIndex <> -1 Then
                Dim loTipGasDet1 As New List(Of e_TipoGastoDetalle)
                loTipGasDet1.AddRange(loTipoGastoDet.Where(Function(item) item.IdTipoGasto = cboTipoGasto.Value).ToList)
                LlenarCombo(cboFlujoCaja, "FlujoCaja", loTipGasDet1.OrderBy(Function(item) item.FlujoCaja).ToList, -1)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarTipoGastoDetalle()
        Try
            ' If loTipoGastoDet.Count = 0 Then
            oeTipoGastoDet = New e_TipoGastoDetalle
            loTipoGastoDet = New List(Of e_TipoGastoDetalle)
            oeTipoGastoDet.TipoOperacion = "1"
            loTipoGastoDet.AddRange(olTipoGastoDet.Listar(oeTipoGastoDet))
            ' End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function VerificaFlujoSustento(ByVal idflujocaja As String) As Boolean
        For Each flujoconta As e_FlujoCaja In leFlujoCajaConta
            If idflujocaja = flujoconta.Id Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub CargarGrupo(ByVal Tipo As Integer, ByVal Combo As Object)
        Try
            Dim oeGrupo As New e_Grupo
            Dim olGrupo As New l_Grupo
            oeGrupo.TipoOperacion = "1"
            oeGrupo.Tipo = Tipo
            oeGrupo.Estado = "GENERADA"
            oeGrupo.Activo = True
            oeGrupo.IdCentro = IdCen
            LlenarCombo(Combo, "Codigo", olGrupo.Listar(oeGrupo).OrderByDescending(Function(item) item.FechaCreacion).ToList, 0)
            oeGrupo = olGrupo.Obtener(oeGrupo)
            oePerGrupo.Id = oeGrupo.IdPeriodo
            cboGrupo.SelectedIndex = 0
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarTrabajador()
        Try
            'If cboTrabajador2.Items.Count = 0 Then
            '    Dim oeTrabajador As New e_Trabajador
            '    Dim olTrabajador As New l_Trabajador
            '    Dim _leTrab2 = olTrabajador.Listar(oeTrabajador)
            '    Dim _leTrabAux = From le In _leTrab2 _
            '                     Select le.Id, le.oePersona.NombreCompleto
            '    LlenarCombo(cboTrabajador2, "NombreCompleto", _leTrabAux.ToList, -1)
            If cboTrabajador2.Items.Count = 0 Then
                LlenarCombo(cboTrabajador2, "Nombre", TrabajadorPublic.Where(Function(item) item.Descripcion = "1").ToList, -1)
            End If
            'End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarTrabajadorAutoriza()
        Try
            If cboAutorizaGasto.Items.Count = 0 Then
                LlenarCombo(cboAutorizaGasto, "Nombre", TrabajadorPublic.Where(Function(item) item.Descripcion = "1").ToList, -1)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarRuta()
        Try
            If cboRuta.Items.Count = 0 Then
                Dim oeRuta As New e_Ruta
                Dim olRuta As New l_Ruta
                oeRuta.Activo = True
                LlenarCombo(cboRuta, "Nombre", olRuta.Listar(oeRuta), -1)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarGastoFuncion()
        Try
            If cboGastoFuncion.Items.Count = 0 Then
                Dim oeTablaContableDet As New e_TablaContableDet
                Dim olTablaContableDet As New l_TablaContableDet
                Dim leTabla As New List(Of e_TablaContableDet)
                oeTablaContableDet.TipoOperacion = "N"
                oeTablaContableDet.Nombre = "GASTO FUNCION" 'Tipo de medio de pago
                oeTablaContableDet.Activo = True
                oeTablaContableDet.Logico1 = 1
                leTabla.AddRange(olTablaContableDet.Listar(oeTablaContableDet))
                With cboGastoFuncion
                    .ValueMember = "Id"
                    .DisplayMember = "Nombre"
                    .DataSource = leTabla
                End With

            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarPlaca()
        Try
            If cboPlaca.Items.Count = 0 Then
                oeVehiculo = New e_Vehiculo
                oeVehiculo.TipoOperacion = "A"
                oeVehiculo.Motriz = True
                oeVehiculo.Activo = True
                LlenarCombo(cboPlaca, "Placa", olVehiculo.Listar(oeVehiculo), -1)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarCentroCosto()
        Try
            If cboCentroCosto.Items.Count = 0 Then
                Dim oeCentroCosto As New e_CentroCosto
                Dim olCentroCosto As New l_CentroCosto
                'oeCentroCosto.Activo = 1
                LlenarCombo(cboCentroCosto, "Nombre", olCentroCosto.Listar(oeCentroCosto), -1)
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub CargarAutoriza()
        Try
            If cboAutoriza.Items.Count = 0 Then
                LlenarCombo(cboAutoriza, "Nombre", TrabajadorPublic, -1)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarFlujoPlaca()
        If loFlujoPlaca.Count = 0 Then
            oeFlujoPlaca = New e_ProcesoFlujoCaja
            oeFlujoPlaca.IdProcesoNegocio = "1CH000000006"
            loFlujoPlaca.AddRange(olFlujoPlaca.Listar(oeFlujoPlaca))
        End If
    End Sub

    Private Sub VerDatoDetalle()

        agrDatos.Expanded = True
        CargarCombosRG()
        LimpiarDatoDetalle(False)
        ExpRegistroConsumoCombustible.Visible = False
        If TipoMov = 1 Then
            cboGastoFuncion.Text = "COSTO DE VENTA"
        End If

    End Sub

    Private Sub LimpiarDatoDetalle(Optional ByVal ind As Boolean = True)
        oeGastoOperacion = New e_GastoOperacion
        'oeGastoOperacion.FechaEmision = Date.Now.Date
        oeGastoOperacion.FechaVencimiento = Date.Now.Date
        CalculaTipoCambio(Date.Now.Date)
        oeGastoOperacion.Moneda = "S/."
        cboMoneda.SelectedIndex = 0
        SaldoDocumento = 0
        txtSerie.Text = String.Empty
        txtNumero.Text = String.Empty
        txtNumero.Tag = String.Empty
        IndCompraAlmacen = False
        cboAutorizaGasto.SelectedIndex = -1
        cboLugarL.SelectedIndex = -1
        If ind Then
            cboTipoGasto.SelectedIndex = -1
            cboFlujoCaja.SelectedIndex = -1
            cboTipoDocumento.SelectedIndex = -1
            oeGastoOperacion.FechaEmision = Date.Now.Date
            dtpFechaEmision.Value = Date.Now.Date
            dtpFecVencimiento.Value = Date.Now.Date
            txtRUC.Text = String.Empty
            cboProveedores.Value = Nothing
            fecPeriodo.Value = Date.Now.Date
            txtGlosa2.Text = String.Empty
            If TipoMov = 2 Then
                cboTrabajador2.SelectedIndex = -1
                cboArea.SelectedIndex = -1
                cboAutoriza.SelectedIndex = -1
            End If
        End If
        DecNoGravada.Value = 0
        DecPercepcion.Value = 0
        numImporte.Value = 0
        numIGV.Value = 0
        numTotal.Value = 0
        If TipoMov <> 2 Then
            cboTrabajador2.SelectedIndex = -1
            cboAutoriza.SelectedIndex = -1
        End If
        cboCentroCosto.Value = idCajaCentro
        oeGastoOperacion.oeGasto_Caja = New e_Gasto_Caja
        cboRuta.SelectedIndex = -1
        ChkVehiculoProper.Checked = False
        cboPlaca.SelectedIndex = -1
        If TipoMov = 1 Then
            cboGastoFuncion.SelectedIndex = -1
        Else
            cboGastoFuncion.SelectedIndex = 1
        End If
        If cboFlujoCaja.Text = "COMBUSTIBLES" Then
            ExpRegistroConsumoCombustible.Visible = True
            ExpRegistroConsumoCombustible.Expanded = True
        Else
            ExpRegistroConsumoCombustible.Visible = False
            ExpRegistroConsumoCombustible.Expanded = False
        End If
        Me.txtNumeroDoc.Text = String.Empty
        Me.txtSerieDoc.Text = String.Empty
        DecCantidadGalones.Value = 0
        agrDatos.Height = IIf(TipoMov = 1, 239, 327)
        agrTotalGasto.Visible = IIf(TipoMov = 1, True, False)
        If TipoMov = 1 Then
            cboTipoGasto.Enabled = False
        Else
            cboTipoGasto.Enabled = True
        End If
        'cboTipoGasto.Enabled = IIf(TipoMov = 1, False, True)
        etiFechavencimiento.Visible = IIf(TipoMov = 1, False, True)
        dtpFecVencimiento.Visible = IIf(TipoMov = 1, False, True)
        If TipoMov = 1 Then
            cboFlujoCaja.Focus()
            cboFlujoCaja.SelectAll()
        Else
            cboTipoGasto.Focus()
            cboTipoGasto.SelectAll()
        End If
        If cboOpcionGasto.Items.Count > 0 Then
            cboOpcionGasto.SelectedIndex = 0
        End If
    End Sub

    Private Sub CalculaTotal()
        Try
            If IndicadorIGV Then
                numIGV.Value = Math.Round(numImporte.Value * oeIGV.Porcentaje, 2)
            Else
                numIGV.Value = 0
            End If
            numTotal.Value = numImporte.Value + numIGV.Value + DecNoGravada.Value ' + DecPercepcion.Value
            numIGV.Update()
            numTotal.Update()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, False)
        End Try

    End Sub

    Private Sub MostrarGO(ByVal leGO As List(Of e_GastoOperacion))
        Try
            With griGastoOperacion
                'CrearComboGrid("FlujoCaja", "Nombre", griGastoOperacion, olFlujoCaja.ComboGrilla(ListaFlujoCaja), True)
                .ResetDisplayLayout()
                .DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True
                .DataSource = leGO
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("TipoMovimiento").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdCuentaCorriente").Hidden = True
                .DisplayLayout.Bands(0).Columns("FlujoCaja").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdPeriodo").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdDocumento").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdTipoDocumento").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdMoneda").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdViaje").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdProveedor").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdEstado").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdGrupo").Hidden = True
                .DisplayLayout.Bands(0).Columns("FechaCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                .DisplayLayout.Bands(0).Columns("Viaje").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdPiloto").Hidden = True
                .DisplayLayout.Bands(0).Columns("Piloto").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdTipoVehiculo").Hidden = True
                .DisplayLayout.Bands(0).Columns("Vehiculo").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdCoPiloto").Hidden = True
                .DisplayLayout.Bands(0).Columns("Copiloto").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdOrigen").Hidden = True
                .DisplayLayout.Bands(0).Columns("Origen").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdDestino").Hidden = True
                .DisplayLayout.Bands(0).Columns("Destino").Hidden = True
                .DisplayLayout.Bands(0).Columns("Estado").Hidden = True
                .DisplayLayout.Bands(0).Columns("Ruta").Hidden = True
                .DisplayLayout.Bands(0).Columns("Periodo").Hidden = True
                .DisplayLayout.Bands(0).Columns("FechaVencimiento").Hidden = True
                .DisplayLayout.Bands(0).Columns("TipoCambio").Hidden = True
                .DisplayLayout.Bands(0).Columns("Moneda").Hidden = True
                .DisplayLayout.Bands(0).Columns("IndAlmacen").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdTrabajadorAutoriza").Hidden = True
                .DisplayLayout.Bands(0).Columns("TrabajadorAutoriza").Hidden = True
                '.DisplayLayout.Bands(0).Columns("IndGasto").Hidden = True

                .DisplayLayout.Bands(0).Columns("IdFlujoCaja").Width = 170
                .DisplayLayout.Bands(0).Columns("SerieDoc").Width = 40
                .DisplayLayout.Bands(0).Columns("NroDoc").Width = 95
                .DisplayLayout.Bands(0).Columns("Proveedor").Width = 150
                .DisplayLayout.Bands(0).Columns("Glosa").Width = 225
                .DisplayLayout.Bands(0).Columns("FechaEmision").Width = 70
                .DisplayLayout.Bands(0).Columns("FechaVencimiento").Width = 70
                .DisplayLayout.Bands(0).Columns("TipoDocumento").Width = 130
                .DisplayLayout.Bands(0).Columns("Moneda").Width = 50
                .DisplayLayout.Bands(0).Columns("SubTotal").Width = 60
                .DisplayLayout.Bands(0).Columns("IGV").Width = 60
                .DisplayLayout.Bands(0).Columns("Total").Width = 60
                .DisplayLayout.Bands(0).Columns("TipoCambio").Width = 40
                .DisplayLayout.Bands(0).Columns("Moneda").Width = 40
                .DisplayLayout.Bands(0).Columns("NroGrupo").Width = 110
                .DisplayLayout.Bands(0).Columns("IndGasto").Width = 75

                .DisplayLayout.Bands(0).Columns("TipoCambio").Style = ColumnStyle.Double
                .DisplayLayout.Bands(0).Columns("SubTotal").Style = ColumnStyle.Double
                .DisplayLayout.Bands(0).Columns("IGV").Style = ColumnStyle.Double
                .DisplayLayout.Bands(0).Columns("Total").Style = ColumnStyle.Double

                .DisplayLayout.Bands(0).Columns("SubTotal").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .DisplayLayout.Bands(0).Columns("IGV").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .DisplayLayout.Bands(0).Columns("Total").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .DisplayLayout.Bands(0).Columns("TipoCambio").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right

                .DisplayLayout.Bands(0).Columns("TipoCambio").Header.Caption = "T.C."
                .DisplayLayout.Bands(0).Columns("Moneda").Header.Caption = "Mon."
                .DisplayLayout.Bands(0).Columns("FechaEmision").Header.Caption = "Fecha"
                .DisplayLayout.Bands(0).Columns("IdFlujoCaja").Header.Caption = "FlujoCaja"
                .DisplayLayout.Bands(0).Columns("IndGasto").Header.Caption = "Op. Gasto"

                .DisplayLayout.Bands(0).Columns("IdFlujoCaja").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("FechaEmision").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("TipoDocumento").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("SerieDoc").Header.VisiblePosition = 4
                .DisplayLayout.Bands(0).Columns("NroDoc").Header.VisiblePosition = 5
                .DisplayLayout.Bands(0).Columns("Proveedor").Header.VisiblePosition = 6
                .DisplayLayout.Bands(0).Columns("Moneda").Header.VisiblePosition = 7
                .DisplayLayout.Bands(0).Columns("TipoCambio").Header.VisiblePosition = 8
                .DisplayLayout.Bands(0).Columns("SubTotal").Header.VisiblePosition = 9
                .DisplayLayout.Bands(0).Columns("IGV").Header.VisiblePosition = 10
                .DisplayLayout.Bands(0).Columns("Total").Header.VisiblePosition = 11
                .DisplayLayout.Bands(0).Columns("Glosa").Header.VisiblePosition = 12
                .DisplayLayout.Bands(0).Columns("NroGrupo").Header.VisiblePosition = 13
                .DisplayLayout.Bands(0).Columns("IndGasto").Header.VisiblePosition = 14
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                'If .Rows.Count = 0 Then
                'For Each Columna As UltraGridColumn In .DisplayLayout.Bands(0).Columns
                '    If Not Columna.Key = "SubTotal" And Not Columna.Key = "FlujoCaja" And Not Columna.Key = "Glosa" Then
                '        Columna.CellClickAction = CellClickAction.RowSelect : Columna.CellActivation = Activation.NoEdit
                '    End If
                'Next

                'griGastoOperacion.DisplayLayout.Bands(0).Columns("Glosa").CellClickAction = CellClickAction.RowSelect
                'griGastoOperacion.DisplayLayout.Bands(0).Columns("SubTotal").CellClickAction = CellClickAction.RowSelect

                For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In .Rows
                    If fila.Cells("TipoDocumento").Value = "ORDEN DE TRABAJO" Then
                        fila.CellAppearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
                    End If
                Next

                .DisplayLayout.Bands(0).Columns("SubTotal").Format = "#,###,###,####0.00"
                .DisplayLayout.Bands(0).Columns("SubTotal").MaskInput = "{LOC}n,nnn,nnn,nnn.nn"
                .DisplayLayout.Bands(0).Columns("Glosa").CharacterCasing = CharacterCasing.Upper

                .DisplayLayout.Bands(0).Columns("Glosa").CellAppearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
                .DisplayLayout.Bands(0).Columns("SerieDoc").MaxLength = 4
                .DisplayLayout.Bands(0).Columns("SerieDoc").CellActivation = Activation.NoEdit
                .DisplayLayout.Bands(0).Columns("NroDoc").MaxLength = 15
                .DisplayLayout.Bands(0).Columns("FechaEmision").CellActivation = Activation.NoEdit
                .DisplayLayout.Bands(0).Columns("FechaEmision").CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.Bands(0).Columns("NroDoc").CellActivation = Activation.NoEdit
                .DisplayLayout.Bands(0).Columns("SubTotal").CellActivation = Activation.NoEdit
                .DisplayLayout.Bands(0).Columns("TipoDocumento").CellActivation = Activation.NoEdit
                .DisplayLayout.Bands(0).Columns("Glosa").CellActivation = Activation.AllowEdit
                .DisplayLayout.Bands(0).Columns("SerieDoc").CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.Bands(0).Columns("NroDoc").CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.Bands(0).Columns("SubTotal").CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.Bands(0).Columns("IndGasto").CellActivation = Activation.NoEdit
                .DisplayLayout.Bands(0).Columns("IndGasto").EditorComponent = cboOpcionGasto
                .DisplayLayout.Bands(0).Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1

                .DisplayLayout.Bands(0).Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton

                .DisplayLayout.Bands(0).Override.SelectTypeGroupByRow = SelectType.None
                .DisplayLayout.Bands(0).Override.SelectTypeRow = SelectType.SingleAutoDrag
                .DisplayLayout.Bands(0).Override.RowSelectors = DefaultableBoolean.Default
                .DisplayLayout.Bands(0).Override.RowSizing = RowSizing.Default
                .DisplayLayout.Bands(0).Override.RowSizingArea = RowSizingArea.RowSelectorsOnly
                CrearComboGrid("IdFlujoCaja", "Nombre", griGastoOperacion, olFlujoCaja.ComboGrilla(ListaFlujoCaja), True)
                .Font = New System.Drawing.Font("Tahoma", 8.0!)
                .UpdateData()
            End With
            CalcularTotales(griGastoOperacion, "SubTotal", "IGV", "Total")
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Function GuardaGastoOperacion() As Boolean
        Try
            If txtCantidadPeajes.Value <> 0 AndAlso leGastoOperacion.Where(Function(x) x.IdFlujoCaja = IdFCPeajes And x.TipoOperacion <> "E").Count <> txtCantidadPeajes.Value AndAlso _
                MessageBox.Show("La cantidad de peajes configurados (" & txtCantidadPeajes.Value.ToString().Trim() & ") no coincide con el total de peajes ingresados (" & leGastoOperacion.Where(Function(x) x.IdFlujoCaja = IdFCPeajes And x.TipoOperacion <> "E").Count.ToString().Trim() & ")" & Environment.NewLine & "¿Desea continuar?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Return False
            End If
            Dim loGastoOperacionMasivo As New List(Of e_GastoOperacion)
            loGastoOperacionMasivo.AddRange(leGastoOperacion)
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            If TipoMov = 1 Then
                If txtTipoCarga.Text = "KILOMETRAJE" Then
                    If txtCliente.Text.Contains("ALICORP") Then
                        If loGastoOperacionMasivo.Where(Function(i) i.IdFlujoCaja = "1CH000000020").ToList.Count > 0 Then
                            If numCostoEstiba.Value = 0 Then
                                If MessageBox.Show("Se Está Liquidando Gastos de Estiba/Desestiba. Desea Guardar el Monto en el Viaje: " & Me.txtViaje.Text & "?", "Mensaje del Sistema",
                                               MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) = Windows.Forms.DialogResult.Yes Then
                                    Me.numCostoEstiba.Focus()
                                    Me.numCostoEstiba.SelectAll()
                                    Return False
                                End If
                            End If
                        End If
                    End If
                End If
            End If
            If olGastoOperacion.GuardaListaMasiva(loGastoOperacionMasivo, CtaCtblePublic, gs_PrefijoIdSucursal) Then
                leGastoOperacion = New List(Of e_GastoOperacion)
                ugb_Espera.Visible = False
                mensajeEmergente.Confirmacion("Se han Rendido Gastos Correctamente", True)
                If TipoMov = 1 Then
                    MostrarTabs(1, ficMovimiento, 1)
                    ficMovimientoViaje.Tabs(0).Enabled = True
                    ficMovimientoViaje.Tabs(0).Selected = True
                    ficMovimientoViaje.Tabs(1).Enabled = False
                Else
                    MostrarTabs(0, ficMovimiento, 0)
                    MostrarTabs(1, ficTipoMovimiento)
                End If
                If TipoMov = 1 Then
                    oeMovimiento_Viaje_Detalle = New e_Movimiento_Viaje
                    ListarMovimientoDetalle(oeMovimiento_Viaje_Detalle) ', True)
                End If
                Return True
            End If
        Catch ex As System.Data.SqlClient.SqlException
            mensajeEmergente.Problema("Sucedió un inconveniente al intentar registrar la información, Favor de volver a guardar.", True)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Function

    Private Function CancelaGastoOperacion() As Boolean
        MostrarTabs(1, ficMovimiento, 1)
        MostrarTabs(0, ficMovimientoViaje, 0)
        Return True
    End Function

    Private Sub ListaGastoOperacion()
        Try
            oeGastoOperacion = New e_GastoOperacion
            If TipoMov = 1 Then oeGastoOperacion.IdViaje = IdViaje
            If TipoMov = 2 Then
                oeGastoOperacion.IdCuentaCorriente = CuentaAdm
                oeGastoOperacion.IdCaja = idCajaCentro
            End If
            oeGastoOperacion.TipoOperacion = IIf(TipoMov = 1, "3", "5")
            leGastoOperacion = olGastoOperacion.Listar(oeGastoOperacion)
            MostrarGO(leGastoOperacion)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub QuitarGastoOperacion()
        Try
            Dim oeSaldo As New e_Saldo
            Dim olSaldo As New l_Saldo
            If TipoMov = 2 Then
                oeSaldo.TipoOperacion = "3"
                oeSaldo.IdCaja = idCajaCentro
                oeSaldo = olSaldo.Obtener(oeSaldo)
            Else
                If Not ValidaGastoLiquidacion() Then Throw New Exception("Viaje ya Verificado no Puede Quitar Gastos")
            End If
            If Me.griGastoOperacion.Rows.Count > 0 Then
                Dim oeGO As New e_GastoOperacion
                oeGO = griGastoOperacion.ActiveRow.ListObject
                If oeGO.TipoOperacion = "I" Then
                    leGastoOperacion.Remove(oeGO)
                Else
                    If TipoMov = 2 Then
                        If oeGO.FechaCreacion > oeSaldo.FechaHora Then
                            oeGO.TipoOperacion = "E"
                            griGastoOperacion.ActiveRow.Hidden = True
                        Else
                            mensajeEmergente.Problema("No Puede Quitar Gastos Despues del Cierre de Caja", True)
                        End If
                        If oeGO.IndAlmacen Then
                            Throw New Exception("No Puede Eliminar Pagos de Facturas de Logistica")
                        End If
                    Else
                        If oeGO.IndAlmacen And oeGO.IndGasto <> 0 Then
                            Throw New Exception("No Puede Eliminar Gasto Movimiento Peaje. se debe asociar a otro viaje.")
                        End If
                        oeGO.TipoOperacion = "E"
                        griGastoOperacion.ActiveRow.Hidden = True
                    End If
                End If
                griGastoOperacion.DataBind()
                If oeGO.IndGasto = 0 Then
                    aux3 = True
                    numAgregado.Value = numAgregado.Value - oeGO.Total
                End If
                Modificado = True
            Else
                Throw New Exception("No hay Registros para Quitar")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub VerificarDocSustento()
        If cboTipoDocumento.Text = "SUSTENTO CONTABLE" Then
            BanderaDocSustento = True
        Else
            BanderaDocSustento = False
        End If
    End Sub

    Private Function ValidaGasto() As Boolean
        Try
            ValidarCombo(cboGrupo, " Grupo")
            If ValidaCombos() Then
                If TipoMov = 1 Then
                    If DateDiff(DateInterval.Day, dtpFechaEmision.Value.Date, CDate(Me.fecFechaViaje.Value)) > 31 Then
                        dtpFechaEmision.Value = ObtenerFechaServidor.Date
                        dtpFechaEmision.Focus()
                        Throw New Exception("No Puede Ingresar un Documento con mas de un Mes de Diferencia entre la Fecha del Viaje")
                    End If
                Else
                    If cboArea.SelectedIndex = -1 Then Throw New Exception("Seleccione Area a la que Pertenece el Gasto")
                End If
                l_FuncionesGenerales.ValidarCampoNoNulo(txtSerie.Text, "Ingrese la Serie")
                l_FuncionesGenerales.ValidarCampoNoNulo(txtNumero.Text, "Ingrese el número")
                If Me.numImporte.Value = 0 Then Throw New Exception("Ingrese Importe")
                'If cboTipoDocumento.Value <> "1CH000000062" And cboTipoDocumento.Value <> "1CH000000073" Then 'VALE y SUSTENTO CONTABLE
                '    If IsNumeric(txtSerie.Text) Then
                '        If CInt(txtSerie.Text) = 0 Then
                '            txtSerie.Focus()
                '            txtSerie.SelectAll()
                '            Throw New Exception("Serie Incorrecta")
                '        End If
                '    End If
                '    If IsNumeric(Me.txtNumero.Value) Then
                '        If CDbl(txtNumero.Text) = 0 Then
                '            txtNumero.Focus()
                '            txtNumero.SelectAll()
                '            Throw New Exception("Numero Incorrecto")
                '        End If
                '    End If
                'End If
                gfc_ValidarSerieDoc(txtSerie.Text, oeTipoDocGasto.Codigo)
                gfc_ValidarNumeroDoc(txtNumero.Text, oeTipoDocGasto.Codigo)
                If cboTipoDocumento.Value = "1SI000000001" Then 'ORDEN DE TRABAJO
                    If txtCarga.Text = "VACIO" Then Throw New Exception("No Puede Agregar OT's a un Viaje Vacio")
                    If cboFlujoCaja.Value <> "1CH000000020" And cboFlujoCaja.Value <> "1CH000000266" Then
                        Throw New Exception("ORDEN DE TRABAJO, Solo puede estar asociada a GASTOS DE ESTIBA Y DESESTIBA o ALQUILER DE MONTACARGA")
                    End If
                    If frm.oeTarifasProveedor.Importe = 0 Then
                        Throw New Exception("Proveedor de Servicio sin Tarifario. No puede Ingresar el Gasto")
                    End If
                    If frm.oeTarifasProveedor.Importe <> numImporte.Value Then
                        Throw New Exception("El Importe tiene que ser el mismo del Tarifario")
                    End If
                    If frm.oeTarifasProveedor.IdProveedor <> cboProveedores.Value Then Throw New Exception("El Proveedor tiene que ser el mismo del Tarifario")
                    If frm.oeTarifasProveedor.IdFlujoCaja <> cboFlujoCaja.Value Then Throw New Exception("El Flujo tiene que ser el mismo del Tarifario")
                    'ElseIf cboTipoDocumento.Value = "1CH000000043" Then
                    '    If dtpFechaEmision.Value.Date >= Date.Parse("01/08/2014") Then ObtenerAportes()
                End If
                If cboTipoDocumento.Text <> "VALE" And cboTipoDocumento.Value <> "1CH000000073" Then
                    ValidarCombo(cboProveedores, "Seleccion Proveedor")
                End If
                If cboFlujoCaja.Value = "1CH000000085" Then 'COMBUSTIBLES
                    If DecCantidadGalones.Value <= 0 Then
                        DecCantidadGalones.Focus()
                        Throw New Exception("Ingrese Cantidad de Galones del Consumo de Combustible")
                    End If
                    If cboMaterial.SelectedIndex = -1 Then
                        cboMaterial.Focus()
                        Throw New Exception("Seleccione Material")
                    End If
                    If cboLugar.SelectedIndex = -1 Then
                        cboLugar.Focus()
                        Throw New Exception("Seleccion Lugar del Grifo")
                    End If
                    If cboDireccion.SelectedIndex = -1 Then
                        cboDireccion.Focus()
                        Throw New Exception("Seleccion Direccion del Grifo")
                    End If
                End If
                If cboFlujoCaja.Text = "PLANILLA DE MOVILIDAD" Then
                    If cboGastoFuncion.Text <> "GASTO DE ADMINISTRACION" Then
                        Throw New Exception("Para Planilla de Movilidad es GASTO ADMINISTRATIVO")
                    End If
                End If
                If cboTipoDocumento.Text <> "VALE" And cboTipoDocumento.Text <> "SUSTENTO CONTABLE" Then
                    If cboProveedores.Value = "1CH000004444" Then ''proveedor ISL
                        Throw New Exception("El proveedor no debe ser ISL")
                    End If
                Else
                    If TipoMov = 2 And cboTrabajador2.Text = "" And cboTipoDocumento.Text <> "SUSTENTO CONTABLE" Then
                        Throw New Exception("Ingrese Trabajador del Vale")
                    End If
                End If
                If numIGV.Value <> 0 And cboTipoDocumento.Value = "1CH000000002" Then
                    Throw New Exception("Las boletas no tienen IGV")
                End If
                If numIGV.Value <> 0 And cboTipoDocumento.Value = "1CH000000043" Then
                    Throw New Exception("Los recibos por Honorarios no tiene IGV")
                End If
                If DecPercepcion.Value <> 0 AndAlso (cboTipoDocumento.Value <> "1CH000000047" And cboTipoDocumento.Value <> "1CH000000026") Then
                    Throw New Exception("La percepcion solo existe en tickets y facturas")
                End If
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ValidaCombos() As Boolean
        Try
            Dim fc, tg, td, fcc, fdc As Boolean
            Dim pr As Boolean = False
            fc = True : fcc = True : fdc = True
            If BanderaDocSustento Then
                For Each flujocaja As e_FlujoCaja In leFlujoCajaConta
                    If cboFlujoCaja.Value = flujocaja.Id Then
                        fdc = True
                        Exit For
                    Else
                        fdc = False
                    End If
                Next
            Else
                If TipoMov = 1 Then
                    For Each flujocaja As e_FlujoCaja In ListaFlujoCaja
                        If cboFlujoCaja.Value = flujocaja.Id Then
                            fc = True
                            Exit For
                        Else
                            fc = False
                        End If
                    Next
                Else
                    For Each tipoflujo As e_TipoGastoDetalle In loTipoGastoDet
                        If cboFlujoCaja.Value = tipoflujo.Id Then
                            fc = True
                            For Each flujocajaconta As e_FlujoCaja In leFlujoCajaConta
                                If tipoflujo.Id = flujocajaconta.Id Then
                                    fcc = False
                                    Exit For
                                Else
                                    fcc = True
                                End If
                            Next
                            Exit For
                        Else
                            fc = False
                        End If
                    Next
                End If
            End If
            If fc = False Then
                Throw New Exception("Seleccione Flujo de Caja Correctamente")
            End If
            If fcc = False Then
                Throw New Exception("Flujo de Caja Especifico para Documento Sustento")
            End If
            If fdc = False Then
                Throw New Exception("Flujo de Caja No Asociado a Documento Sustento Contable")
            End If
            If TipoMov = 2 Then
                For Each tipogasto As e_TipoGasto In ListaTipoGasto
                    If cboTipoGasto.Value = tipogasto.Id Then
                        tg = True
                        Exit For
                    Else
                        tg = False
                    End If
                Next
                If tg = False Then
                    Throw New Exception("Seleccione Tipo Gasto Correctamente")
                End If
                For Each proflu As e_ProcesoFlujoCaja In loFlujoPlaca
                    If cboFlujoCaja.Value = proflu.IdFlujoCaja Then
                        If cboPlaca.SelectedIndex = -1 Then
                            Throw New Exception("Seleccione Placa para este Flujo de Caja")
                        End If
                    End If
                Next
            Else
                If cboLugarL.Value <> "" Then
                    Dim oeLugar As New e_Combo
                    oeLugar.Id = cboLugarL.Value
                    oeLugar.Tipo = 0
                    If Not LugaresPublic.Contains(oeLugar) Then
                        Throw New Exception("Seleccion Lugar Correctamente")
                    End If
                End If
            End If
            For Each tipodoc As e_TipoDocumento In ListaTipoDocumento
                If cboTipoDocumento.Value = tipodoc.Id Then
                    td = True
                    Exit For
                Else
                    td = False
                End If
            Next
            If td = False Then
                Throw New Exception("Seleccione Tipo de Documento Correctamente")
            End If
            Dim oepro As New e_Proveedor
            oepro.Id = cboProveedores.Value
            oepro.TipoOperacion = "5"
            oepro = olProveedor.Obtener(oepro)
            If oepro.Id = "" Then
                Throw New Exception("Seleccione Proveedor Correctamente")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'Private Sub Enfocar(ByVal excepcion As String)
    '    If excepcion.Contains("Flujo Caja") Then cboTipoGasto.Focus()
    '    If excepcion.Contains("Tipo Documento") Then cboTipoDocumento.Focus()
    '    If excepcion.Contains("Serie") Then txtSerie.Focus()
    '    If excepcion.Contains("Numero") Then txtNumero.Focus()
    '    If excepcion.Contains("Importe") Then numImporte.Focus()
    '    If excepcion.Contains("Fecha de Emision") Then dtpFechaEmision.Focus()
    'End Sub

    Private Sub CalculaTipoCambio(ByVal Fecha As Date)
        Try
            numTipoCambio.Value = TipoCambio(Fecha, True)(0)
            oeIGV = New e_Impuesto
            oeIGV = olImp.IGV(Fecha)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function ValidaGastoLiquidacion() As Boolean
        Try
            Dim oeDetGru As New e_GrupoDetalleLiq
            Dim olDetGru As New l_GrupoDetalleLiq
            oeDetGru.IdViaje = IdViaje
            oeDetGru = olDetGru.Obtener(oeDetGru)
            If oeDetGru.IdViaje <> "" Then Return False
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'Public Sub ObtenerAportes()
    '    Try
    '        oeEmpresaAporte = New e_EmpresaAportacion
    '        oeEmpresaAporte.IdEmpresa = cboProveedores.Value
    '        oeEmpresaAporte = olEmpresaAporte.Obtener(oeEmpresaAporte)
    '        If oeEmpresaAporte.Id = "" Then
    '            Dim frm As New frm_EmpresaAportacion
    '            frm.IdEmpresa = cboProveedores.Value
    '            frm.ShowDialog()
    '            ControlBoton(0, 0, 0, 1, 1)
    '            oeEmpresaAporte = New e_EmpresaAportacion
    '            oeEmpresaAporte.IdEmpresa = cboProveedores.Value
    '            oeEmpresaAporte = olEmpresaAporte.Obtener(oeEmpresaAporte)
    '        End If
    '        If oeEmpresaAporte.Id = "" Then Throw New Exception("Tiene Que Registrar los Datos de AFP del Proveedor")
    '        Dim loHistorialRH As New List(Of e_Combo)
    '        loHistorialRH.AddRange(ListaRH(cboProveedores.Value, dtpFechaEmision.Value))
    '        If oeEmpresaAporte.FechaNacimiento.Date >= Date.Parse("01/08/1973") Then
    '            Dim Total As Double = 0
    '            Total = loHistorialRH.Sum(Function(i) i.Descripcion) + Me.numTotal.Value
    '            If Total >= 750 Then
    '                If loHistorialRH.Count > 0 Then
    '                    If MessageBox.Show("No Puede Ingresar el Documento, MontoSuperado. Desea ver el Detalle?", "Mensaje de Sistema", _
    '                                   MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
    '                        Dim frm As New frm_DetalleCajaExterna
    '                        frm.MostrarDetalle("3", Nothing, Nothing, Nothing, loHistorialRH)
    '                        frm.ShowDialog()
    '                    End If
    '                End If                   
    '                Throw New Exception("No puede Ingresar RH se ha Superado el Monto sin Retencion ")
    '            End If
    '        End If
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub

#End Region

#End Region

#Region "GastoViatico"

    '#Region "Declaracion de Variables"

    '    Dim oeGastoViatico As New e_GastoViatico
    '    Dim olGastoViatico As New l_GastoViatico
    '    Dim leGastoViatico As New List(Of e_GastoViatico)
    '    Dim CCPiloto As String = "", CCCopiloto As String = "", CCAyudante As String = ""
    '    Dim NroPersona As Integer = 0
    '    Dim MontoViatico As Double = 0, MontoDesayuno As Double = 0, MontoAlmuerzo As Double = 0
    '    Dim MontoCena As Double = 0
    '    Dim TotConp As Integer = 0
    '    Dim oeMFD As New e_MontoFlujoDiario
    '    Dim olMFD As New l_MontoFlujoDiario
    '    Dim ApaVerde As New Appearance
    '    Dim ApaRojo As New Appearance

    '#End Region

    '#Region "Eventos"

    '    Private Sub Calendario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        HabAgrupacion(1, verPiloto.Checked)
    '        HabAgrupacion(2, verCopiloto.Checked)
    '        HabAgrupacion(3, verAyudante.Checked)
    '        agrPiloto.Enabled = False
    '        agrCopiloto.Enabled = False
    '        agrAyudante.Enabled = False
    '    End Sub

    '    Private Sub Calendario_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        Agregar_Viatico()
    '    End Sub

    '    'Private Sub optZona_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optZona.ValueChanged
    '    '    If verAlmuerzo.Checked Then MontoAlmuerzo = 10
    '    '    Select Case optZona.CheckedIndex
    '    '        Case 0
    '    '            MontoViatico = 30
    '    '            verDesayuno.Enabled = True
    '    '            verCena.Enabled = True
    '    '        Case 1
    '    '            MontoViatico = 35
    '    '            If verAlmuerzo.Checked Then MontoAlmuerzo = 15
    '    '            verDesayuno.Enabled = True
    '    '            verCena.Enabled = True
    '    '        Case 2
    '    '            MontoViatico = 10
    '    '            If verDesayuno.Checked Then verDesayuno.Checked = False : decMontoCV.Value = decMontoCV.Value - 10
    '    '            verDesayuno.Enabled = False
    '    '            If verCena.Checked Then verCena.Checked = False : decMontoCV.Value = decMontoCV.Value - 10
    '    '            verCena.Enabled = False
    '    '        Case 3
    '    '            MontoViatico = 20
    '    '    End Select
    '    '    Calcula_Viatico()
    '    'End Sub

    '    Private Sub verPiloto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        If verPiloto.Checked Then
    '            ' NroPersona = NroPersona + 1
    '            ObtenerCuentas(idPiloto, idCopiloto, idAyudante)
    '        Else
    '            'If NroPersona > 0 Then NroPersona = NroPersona - 1
    '            CCPiloto = "0"
    '        End If
    '        HabAgrupacion(1, verPiloto.Checked)
    '        Calcula_Viatico()
    '    End Sub

    '    Private Sub verCopiloto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        If verCopiloto.Checked Then
    '            ' NroPersona = NroPersona + 1
    '            'CCCopiloto = BuscarTrabajadorCuentaCorriente(idCopiloto)
    '            ObtenerCuentas(idPiloto, idCopiloto, idAyudante)
    '        Else
    '            'If NroPersona > 0 Then NroPersona = NroPersona - 1
    '            CCCopiloto = "0"
    '        End If
    '        HabAgrupacion(2, verCopiloto.Checked)
    '        ' Calcula_Viatico()
    '    End Sub

    '    Private Sub verDesayuno_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        If Not verDesayunoC.Checked Then MontoDesayuno = 0
    '        Calcula_Viatico()
    '    End Sub

    '    Private Sub verAlmuerzo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        If Not verAlmuerzoC.Checked Then MontoAlmuerzo = 0
    '        Calcula_Viatico()
    '    End Sub

    '    Private Sub verCena_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        If Not verCenaC.Checked Then MontoCena = 0
    '        Calcula_Viatico()
    '    End Sub

    '    Private Sub btnAceptarCV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        Try
    '            ObtieneConp()
    '            Dim FechaViatico As Date
    '            If CalendarioInfo.SelectedDateRanges.SelectedDaysCount > 0 Then
    '                For i As Integer = 0 To CalendarioInfo.SelectedDateRanges.SelectedDaysCount - 1
    '                    FechaViatico = CalendarioInfo.SelectedDateRanges.Item(0).Days(i).Date
    '                    AdicionarLista(FechaViatico)
    '                    If TotConp = 3 * NroPersona Then
    '                        CalendarioVista.GetDayLook(New DateTime(FechaViatico.Year, FechaViatico.Month, FechaViatico.Day), True).Appearance = ApaRojo
    '                        CalendarioC.CalendarLook.GetDayLook(New DateTime(FechaViatico.Year, FechaViatico.Month, FechaViatico.Day), True).Appearance = ApaRojo
    '                    Else
    '                        CalendarioVista.GetDayLook(New DateTime(FechaViatico.Year, FechaViatico.Month, FechaViatico.Day), True).Appearance = ApaVerde
    '                        CalendarioC.CalendarLook.GetDayLook(New DateTime(FechaViatico.Year, FechaViatico.Month, FechaViatico.Day), True).Appearance = ApaVerde
    '                    End If
    '                Next
    '            End If
    '            'decTotalCV.Value = (decTotalCV.Value + decMontoCV.Value) * CalendarioInfo.SelectedDateRanges.SelectedDaysCount
    '            Inicializar_Viaticos()
    '            HabAgrupacion(1, verPiloto.Checked)
    '            HabAgrupacion(2, verCopiloto.Checked)
    '            HabAgrupacion(3, verAyudante.Checked)
    '            agrPiloto.Enabled = False
    '            agrCopiloto.Enabled = False
    '            agrAyudante.Enabled = False
    '        Catch ex As Exception
    '            mensajeEmergente.Problema(ex.Message, True)
    '        End Try

    '    End Sub

    '    Private Sub btnCancelarCV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        Inicializar_Viaticos()
    '        HabAgrupacion(1, verPiloto.Checked)
    '        HabAgrupacion(2, verCopiloto.Checked)
    '        HabAgrupacion(3, verAyudante.Checked)
    '        agrPiloto.Enabled = False
    '        agrCopiloto.Enabled = False
    '        agrAyudante.Enabled = False

    '    End Sub

    '    'Private Sub btnActualizaTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizaTotal.Click
    '    '    'numTotal.Value = decTotalCV.Value
    '    '    'agrCalendarioViatico.Visible = False
    '    '    'agrCalendarioViatico.Visible = False
    '    'End Sub

    '    Private Sub verAyudante_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        If verAyudante.Checked Then
    '            ObtenerCuentas(idPiloto, idCopiloto, idAyudante)
    '        Else
    '            CCAyudante = "0"
    '        End If
    '        HabAgrupacion(3, verAyudante.Checked)
    '        Calcula_Viatico()
    '    End Sub

    '    Private Sub mnuCalendario_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mnuCalendario.Opening
    '        mnuCalendario.Items("tsmiAgregarCV").Visible = True
    '        mnuCalendario.Items("tsmiQuitarCV").Visible = True
    '        mnuCalendario.Items("tsmiEditarCV").Visible = True
    '        If CalendarioInfo.SelectedDateRanges.SelectedDaysCount = 0 Then
    '            mnuCalendario.Items("tsmiAgregarCV").Visible = False
    '            mnuCalendario.Items("tsmiQuitarCV").Visible = False
    '            mnuCalendario.Items("tsmiEditarCV").Visible = False
    '        End If
    '    End Sub

    '    Private Sub tsmiAgregarCV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiAgregarCV.Click
    '        Agregar_Viatico()
    '    End Sub

    '    Private Sub tsmiQuitarCV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiQuitarCV.Click
    '        Dim fecha As Date = CalendarioInfo.ActiveDay.Date
    '        CalendarioVista.GetDayLook(New DateTime(fecha.Year, fecha.Month, fecha.Day), True).Appearance = Nothing
    '    End Sub

    '    Private Sub cboCopilotoCV_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        If cboCopilotoCV.SelectedIndex > -1 Then CCCopiloto = cboCopilotoCV.Value : LimpiaCalendario(2) : CargaCalendar(2, CCCopiloto)
    '    End Sub

    '    Private Sub cboAyudanteCV_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        If cboAyudanteCV.SelectedIndex > -1 Then CCAyudante = cboAyudanteCV.Value : LimpiaCalendario(3) : CargaCalendar(3, CCAyudante)
    '    End Sub

    '#End Region

    '#Region "Metodos"

    '    Private Sub Inicializar_Viaticos(Optional ByVal Fecha As Date = #1/1/1901#)
    '        Try

    '            oeGastoViatico = New e_GastoViatico
    '            'oeMFD = New e_MontoFlujoDiario
    '            'oeMFD.IdRuta = idRuta
    '            'oeMFD.IdTipoVehiculo = idTipoVehiculo
    '            'oeMFD = olMFD.Obtener(oeMFD)
    '            'decMontoCV.Value = oeMFD.Monto
    '            ' MontoViatico = oeMFD.Monto
    '            HabConcepto(1, True)
    '            HabConcepto(2, True)
    '            HabConcepto(3, True)
    '            'For Each oe As e_MontoFlujoDiario_Det In oeMFD.leMontoFlujoDiarioDet
    '            '    Select Case oe.Tipo
    '            '        Case 1
    '            '            MontoDesayuno = oe.MontoPromedio
    '            '            HabConcepto(1, True)
    '            '        Case 2
    '            '            MontoAlmuerzo = oe.MontoPromedio
    '            '            HabConcepto(2, True)
    '            '        Case 3
    '            '            MontoCena = oe.MontoPromedio
    '            '            HabConcepto(3, True)
    '            '    End Select
    '            'Next
    '            NroPersona = 0
    '            TotConp = 0
    '            verPiloto.Checked = IIf(idPiloto <> "", True, False)
    '            'HabAgrupacion(1, verPiloto.Checked)
    '            verCopiloto.Checked = IIf(idCopiloto <> "", True, False)
    '            'HabAgrupacion(2, verCopiloto.Checked)
    '            verAyudante.Checked = IIf(idAyudante <> "", True, False)
    '            'HabAgrupacion(3, verAyudante.Checked)
    '            ObtenerCuentas(idPiloto, idCopiloto, idAyudante)
    '        Catch ex As Exception
    '            mensajeEmergente.Problema(ex.Message, True)
    '        End Try

    '    End Sub

    '    Private Sub Inicializa_Calendario()

    '        'Dim ApaRojo As New Appearance
    '        ApaRojo.Key = "Rojo"
    '        ApaRojo.BackColor = Color.Red
    '        ApaRojo.ForeColor = Color.White

    '        'Dim ApaVerde As New Appearance
    '        ApaVerde.Key = "Verde"
    '        ApaVerde.BackColor = Color.Green
    '        ApaVerde.ForeColor = Color.White

    '        'CalendarioVista.Appearances.Add("Rojo")
    '        'CalendarioVista.Appearances("Rojo").BackColor = Color.Red
    '        'CalendarioVista.Appearances("Rojo").ForeColor = Color.White
    '        'CalendarioVista.Appearances.Add("Verde")
    '        'CalendarioVista.Appearances("Verde").BackColor = Color.Green
    '        'CalendarioVista.Appearances("Verde").ForeColor = Color.White

    '        'CalendarioC.CalendarLook.Appearances.Add(ApaRojo)
    '        'CalendarioC.CalendarLook.Appearances.Add(ApaVerde)

    '        'CalendarioA.CalendarLook.Appearances.Add(ApaRojo)
    '        'CalendarioA.CalendarLook.Appearances.Add(ApaVerde)

    '    End Sub

    '    Private Sub Habilita_Vaiticos(ByVal Indicador As Boolean)

    '        HabAgrupacion(1, Indicador)
    '        HabAgrupacion(2, Indicador)
    '        HabAgrupacion(3, Indicador)
    '        btnAceptarCV.Enabled = Indicador
    '        btnCancelarCV.Enabled = Indicador
    '    End Sub

    '    Private Sub HabConcepto(ByVal Tipo As Integer, ByVal Band As Boolean)
    '        Select Case Tipo
    '            Case 1
    '                verDesayunoP.Checked = Band
    '                verDesayunoC.Checked = Band
    '                verDesayunoA.Checked = Band
    '            Case 2
    '                verAlmuerzoP.Checked = Band
    '                verAlmuerzoC.Checked = Band
    '                verAlmuerzoA.Checked = Band
    '            Case 3
    '                verCenaP.Checked = Band
    '                verCenaC.Checked = Band
    '                verCenaA.Checked = Band
    '        End Select
    '    End Sub

    '    Private Sub HabAgrupacion(ByVal Tipo As Integer, ByVal Band As Boolean)
    '        Select Case Tipo
    '            Case 1
    '                cboPilotoCV.Enabled = Band
    '                If Band Then
    '                    cboPilotoCV.Value = IIf(CCPiloto <> "", CCPiloto, "")
    '                Else
    '                    cboPilotoCV.SelectedIndex = -1
    '                End If
    '                agrPiloto.Enabled = Band
    '            Case 2
    '                cboCopilotoCV.Enabled = Band
    '                If Band Then
    '                    cboCopilotoCV.Value = IIf(CCCopiloto <> "", CCCopiloto, "")
    '                Else
    '                    cboCopilotoCV.SelectedIndex = -1
    '                End If
    '                agrCopiloto.Enabled = Band
    '            Case 3
    '                cboAyudanteCV.Enabled = Band
    '                If Band Then
    '                    cboAyudanteCV.Value = IIf(CCAyudante <> "", CCAyudante, "")
    '                Else
    '                    cboAyudanteCV.SelectedIndex = -1
    '                End If
    '                agrAyudante.Enabled = Band
    '        End Select
    '    End Sub

    '    Private Sub Calcula_Viatico()
    '        'decMontoCV.Value = (MontoDesayuno + MontoAlmuerzo + MontoCena) * NroPersona
    '    End Sub

    '    Private Sub Agregar_Viatico()
    '        If CalendarioInfo.SelectedDateRanges.SelectedDaysCount > 0 Then
    '            If CalendarioInfo.SelectedDateRanges.SelectedDaysCount < 4 Then
    '                'Habilita_Vaiticos(True)
    '                HabAgrupacion(1, verPiloto.Checked)
    '                HabAgrupacion(2, verCopiloto.Checked)
    '                HabAgrupacion(3, verAyudante.Checked)
    '                btnAceptarCV.Enabled = True
    '                btnCancelarCV.Enabled = True
    '                Inicializar_Viaticos()
    '            Else
    '                mensajeEmergente.Problema("Seleccione al como máximo tres días", True)
    '            End If

    '        Else
    '            mensajeEmergente.Problema("Seleccione al menos un día", True)
    '        End If
    '    End Sub

    '    Private Sub AdicionarLista(ByVal Fecha As Date)
    '        Try
    '            If CCPiloto <> "" Then
    '                AdicionaObjeto(Fecha, CCPiloto, 1)
    '            End If
    '            If CCCopiloto <> "" Then
    '                AdicionaObjeto(Fecha, CCCopiloto, 2)
    '            End If
    '            If CCAyudante <> "" Then
    '                AdicionaObjeto(Fecha, CCAyudante, 3)
    '            End If
    '        Catch ex As Exception
    '            Throw
    '        End Try

    '    End Sub

    '    Private Sub AdicionaObjeto(ByVal Fecha As Date, ByVal IdCuenta As String, ByVal Tipo As Integer)
    '        oeGastoViatico = New e_GastoViatico
    '        oeGastoViatico.Fecha = Fecha
    '        oeGastoViatico.IdCuentaCorriente = IdCuenta
    '        oeGastoViatico.TipoConductor = Tipo
    '        oeGastoViatico.IdViaje = IdViaje
    '        oeGastoViatico.IndZona = 0
    '        oeGastoViatico.IdEstado = ""
    '        If Not leGastoViatico.Contains(oeGastoViatico) Then
    '            oeGastoViatico.TipoOperacion = "I"
    '            oeGastoViatico.UsuarioCreacion = gUsuarioSGI.Id
    '            oeGastoViatico.Monto = 0
    '            Select Case Tipo
    '                Case 1
    '                    oeGastoViatico.IndDesayuno = IIf(verDesayunoP.Checked, 1, 0)
    '                    oeGastoViatico.IndAlmuerzo = IIf(verAlmuerzoP.Checked, 1, 0)
    '                    oeGastoViatico.IndCena = IIf(verCenaP.Checked, 1, 0)
    '                Case 2
    '                    oeGastoViatico.IndDesayuno = IIf(verDesayunoC.Checked, 1, 0)
    '                    oeGastoViatico.IndAlmuerzo = IIf(verAlmuerzoC.Checked, 1, 0)
    '                    oeGastoViatico.IndCena = IIf(verCenaC.Checked, 1, 0)
    '                Case 3
    '                    oeGastoViatico.IndDesayuno = IIf(verDesayunoA.Checked, 1, 0)
    '                    oeGastoViatico.IndAlmuerzo = IIf(verAlmuerzoA.Checked, 1, 0)
    '                    oeGastoViatico.IndCena = IIf(verCenaC.Checked, 1, 0)
    '            End Select
    '            oeGastoViatico.IndZona = IIf(oeGastoViatico.IndDesayuno = 1 And oeGastoViatico.IndAlmuerzo = 1 And oeGastoViatico.IndCena = 1, 1, 0)
    '            leGastoViatico.Add(oeGastoViatico)
    '        Else
    '            Dim strTipo As String = ""
    '            Select Case Tipo
    '                Case 1 : strTipo = "Piloto"
    '                Case 2 : strTipo = "CoPiloto"
    '                Case 3 : strTipo = "Ayudante"
    '            End Select
    '            Throw New Exception("Ya se registro viaticos al " & strTipo)
    '        End If
    '    End Sub

    '    Private Sub ObtenerCuentas(ByVal _IdPiloto As String, ByVal _IdCopiloto As String, ByVal _IdAyudante As String)
    '        If _IdPiloto <> "" Then
    '            CCPiloto = BuscarIdCtaCte(_IdPiloto, 0, loCuentaCorriente)
    '        End If
    '        If _IdCopiloto <> "" Then
    '            CCCopiloto = BuscarIdCtaCte(_IdCopiloto, 0, loCuentaCorriente)
    '        End If
    '        If _IdAyudante <> "" Then
    '            CCAyudante = BuscarIdCtaCte(_IdAyudante, 0, loCuentaCorriente)
    '        End If
    '    End Sub

    '    Private Sub ObtieneConp()
    '        If verPiloto.Checked Then
    '            NroPersona = NroPersona + 1
    '            If verDesayunoP.Checked Then TotConp = TotConp + 1
    '            If verAlmuerzoP.Checked Then TotConp = TotConp + 1
    '            If verCenaP.Checked Then TotConp = TotConp + 1
    '        End If
    '        If verCopiloto.Checked Then
    '            NroPersona = NroPersona + 1
    '            If verDesayunoC.Checked Then TotConp = TotConp + 1
    '            If verAlmuerzoC.Checked Then TotConp = TotConp + 1
    '            If verCenaC.Checked Then TotConp = TotConp + 1
    '        End If
    '        If verAyudante.Checked Then
    '            NroPersona = NroPersona + 1
    '            If verDesayunoA.Checked Then TotConp = TotConp + 1
    '            If verAlmuerzoA.Checked Then TotConp = TotConp + 1
    '            If verCenaA.Checked Then TotConp = TotConp + 1
    '        End If
    '    End Sub

    '    Private Sub CargaCalendar(ByVal Tipo As Integer, ByVal Cuenta As String)
    '        Try
    '            Dim oeGV As New e_GastoViatico
    '            Dim leGV As New List(Of e_GastoViatico)
    '            'oeGV.TipoConductor = Tipo
    '            'Select Case Tipo
    '            '    Case 1 : oeGV.IdCuentaCorriente = CCPiloto
    '            '    Case 2 : oeGV.IdCuentaCorriente = CCCopiloto
    '            '    Case 3 : oeGV.IdCuentaCorriente = CCAyudante
    '            'End Select
    '            oeGV.IdCuentaCorriente = Cuenta
    '            leGV = olGastoViatico.Listar(oeGV).OrderBy(Function(item) item.Fecha).ToList
    '            For Each oe As e_GastoViatico In leGV
    '                If oe.IndZona = 1 Then
    '                    Select Case Tipo
    '                        Case 1 : CalendarioVista.GetDayLook(New DateTime(oe.Fecha.Year, oe.Fecha.Month, oe.Fecha.Day), True).Appearance = ApaRojo
    '                        Case 2 : CalendarioC.CalendarLook.GetDayLook(New DateTime(oe.Fecha.Year, oe.Fecha.Month, oe.Fecha.Day), True).Appearance = ApaRojo
    '                        Case 3 : CalendarioA.CalendarLook.GetDayLook(New DateTime(oe.Fecha.Year, oe.Fecha.Month, oe.Fecha.Day), True).Appearance = ApaRojo
    '                    End Select
    '                    ' CalendarioVista.GetDayLook(New DateTime(oe.Fecha.Year, oe.Fecha.Month, oe.Fecha.Day), True).Appearance = ApaRojo
    '                Else
    '                    Select Case Tipo
    '                        Case 1 : CalendarioVista.GetDayLook(New DateTime(oe.Fecha.Year, oe.Fecha.Month, oe.Fecha.Day), True).Appearance = ApaVerde
    '                        Case 2 : CalendarioC.CalendarLook.GetDayLook(New DateTime(oe.Fecha.Year, oe.Fecha.Month, oe.Fecha.Day), True).Appearance = ApaVerde
    '                        Case 3 : CalendarioA.CalendarLook.GetDayLook(New DateTime(oe.Fecha.Year, oe.Fecha.Month, oe.Fecha.Day), True).Appearance = ApaVerde
    '                    End Select
    '                    ' CalendarioVista.GetDayLook(New DateTime(oe.Fecha.Year, oe.Fecha.Month, oe.Fecha.Day), True).Appearance = ApaVerde
    '                End If
    '            Next
    '        Catch ex As Exception
    '            Throw ex
    '        End Try
    '    End Sub

    '    Private Sub LimpiaCalendario(ByVal Tipo As Integer)
    '        Select Case Tipo
    '            Case 1 : CalendarioVista.ResetDateLooks(Infragistics.Win.UltraWinSchedule.LookObjects.DayLooks)
    '            Case 2 : CalendarioC.CalendarLook.ResetDateLooks(UltraWinSchedule.LookObjects.DayLooks)
    '            Case 3 : CalendarioA.CalendarLook.ResetDateLooks(UltraWinSchedule.LookObjects.DayLooks)
    '        End Select
    '    End Sub


    '#End Region

#End Region

#Region "Cuenta Administrativa"

    Private Sub CargarMovimientosCuentaCorriente(ByVal IdCuentaCorriente As String, ByVal Grilla As UltraGrid)
        oeCajaUsuario = New e_CajaUsuario
        oeCajaUsuario.IdTrabajador = idTrabajador
        oeCajaUsuario = olCajaUsuario.Obtener(oeCajaUsuario)

        oeMovimiento_Administrativo = New e_Movimiento_Administrativo
        oeMovimiento_Administrativo.TipoOperacion = "4"
        oeMovimiento_Administrativo.IdCaja = oeCajaUsuario.IdCaja

        If oeMovimiento_Administrativo.IdCuentaCorrienteD = "" Then
            oeMovimiento_Administrativo.TipoTransa = 0
        End If
        loMovimiento_Administrativo = olMovimiento_Administrativo.Listar(oeMovimiento_Administrativo)

        ''Caja Lima
        'Dim oeAux = loMovimiento_Administrativo(0)
        'oeAux.Egreso = oeAux.Egreso + 57981.78
        'Dim oeAdd As New e_Movimiento_Administrativo
        'oeAdd.Egreso = 7355
        'oeAdd.Fecha = #12/31/2014 11:59:59 PM#
        'oeAdd.Glosa = "POR COBRO DE FLETE - VIAJES VARIOS"
        'loMovimiento_Administrativo.Add(oeAdd)

        ''caja Pacasmayo
        'Dim oeAux = loMovimiento_Administrativo(0)
        'oeAux.Egreso = oeAux.Egreso + 23007.98
        'Dim oeAdd As New e_Movimiento_Administrativo
        'oeAdd.Egreso = 4993.5
        'oeAdd.Fecha = #12/31/2014 11:59:59 PM#
        'oeAdd.Glosa = "POR COBRO DE FLETE - VIAJES VARIOS"
        'loMovimiento_Administrativo.Add(oeAdd)

        Grilla.DataSource = loMovimiento_Administrativo

        Dim cantingreso As Double = loMovimiento_Administrativo.Sum(Function(item) item.Ingreso)
        Dim cantegreso As Double = loMovimiento_Administrativo.Sum(Function(item) item.Egreso)

        With Grilla.DisplayLayout
            .Bands(0).Columns("TipoMovimiento").Hidden = True
            .Bands(0).Columns("Descuento").Hidden = True
            .Bands(0).Columns("FechaCreacion").Hidden = True
            .Bands(0).Columns("CuentaDestino").Hidden = True
            .Bands(0).Columns("IdCuentaCorrienteD").Hidden = True
            .Bands(0).Columns("CuentaOrigen").Hidden = True
            .Bands(0).Columns("IdCuentaCorrienteO").Hidden = True
            .Bands(0).Columns("CuentaDestino").Hidden = True
            .Bands(0).Columns("IdTrabajadorCuentaCorriente").Hidden = True
            .Bands(0).Columns("Trabajador").Hidden = True
            .Bands(0).Columns("IndCerrado").Hidden = True
            .Bands(0).Columns("Saldo").Hidden = True
            'If CajaUsuario <> "CCH" Then
            .Bands(0).Columns("Ingreso").Header.Caption = "Egreso"
            .Bands(0).Columns("Egreso").Header.Caption = "Ingreso"
            decSaldoCuentaAdm.Value = Math.Round(cantegreso - cantingreso, 2)
            '' Caja Lima
            'decSaldoCuentaAdm.Value = 72860.0
            '' Caja Pacasmayo
            'decSaldoCuentaAdm.Value = 35573.0

            .Bands(0).Columns("Ingreso").CellAppearance.TextHAlign = HAlign.Right
            .Bands(0).Columns("Egreso").CellAppearance.TextHAlign = HAlign.Right

            .Bands(0).Columns("Ingreso").Style = ColumnStyle.Double
            .Bands(0).Columns("Egreso").Style = ColumnStyle.Double

            .Bands(0).Columns("Fecha").Header.VisiblePosition = 1
            .Bands(0).Columns("Glosa").Header.VisiblePosition = 2
            .Bands(0).Columns("Egreso").Header.VisiblePosition = 3
            .Bands(0).Columns("Ingreso").Header.VisiblePosition = 4
            .Bands(0).Columns("Voucher").Header.VisiblePosition = 5

            .Override.CellClickAction = CellClickAction.RowSelect
            .Override.AllowUpdate = DefaultableBoolean.False
        End With
        CalcularTotales(GriCuentaAdministrativa, "Ingreso", "Egreso")
        CalcularTotalGastoAdm(oeCajaUsuario.IdCaja)
    End Sub

    Public Sub CalcularTotalGastoAdm(IdCaja As String)
        Try
            Dim oeValRen As New e_ValesRendir
            Dim olValRen As New l_ValesRendir
            Dim oeGastosCaja As New e_GastoOperacion
            Dim olGastosCaja As New l_GastoOperacion
            loValRen = New List(Of e_ValesRendir)
            loGastosCaja = New List(Of e_GastoOperacion)

            oeGastosCaja.IdCaja = IdCaja
            oeGastosCaja.TipoOperacion = "Y"
            loGastosCaja = olGastosCaja.Listar(oeGastosCaja)

            oeValRen.IdCaja = IdCaja
            oeValRen.TipoOperacion = "3"
            oeValRen.Fecha = Date.Parse("01/01/1901")
            oeValRen.FechaCreacion = Date.Parse("01/01/1901")
            oeValRen.IndRendido = 0
            loValRen = olValRen.Listar(oeValRen)

            Dim oeOtrIng As New e_OtrosIngresos
            Dim olOtrIng As New l_OtrosIngresos
            loOtrIng = New List(Of e_OtrosIngresos)
            oeOtrIng.TipoOperacion = "3"
            oeOtrIng.IdCaja = IdCaja
            loOtrIng = olOtrIng.Listar(oeOtrIng)
            Dim oIng As Double = 0
            Dim oEgr As Double = 0
            For Each otring As e_OtrosIngresos In loOtrIng
                oIng += otring.Ingreso
                oEgr += otring.Egreso
            Next
            Me.decTotalOtrosIngresos.Value = oIng - oEgr
            Me.decGastosAdm.Value = loGastosCaja.Sum(Function(i) i.Total)
            Me.decTotalVales.Value = loValRen.Sum(Function(i) i.Importe)
            '' Caja Lima
            'Me.decGastosAdm.Value = adm + 15000
            'Me.decTotalVales.Value = val + 10013.85
            '' Caja Pacasmayo
            'Me.decGastosAdm.Value = adm + 10776.29
            'Me.decTotalVales.Value = val + 10000
            Me.decTotalFF.Value = decSaldoCuentaAdm.Value + Me.decGastosAdm.Value + Me.decTotalVales.Value - Me.decTotalOtrosIngresos.Value
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Compras Almacen"

    Private oeMovimientoDocumento As New e_MovimientoDocumento
    Private olMovimientoDocumento As New l_MovimientoDocumento
    Private lstMovimientoDocumento As New List(Of e_MovimientoDocumento)

    Private Sub txtSerieDoc_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSerieDoc.Enter
        txtSerieDoc.SelectAll()
    End Sub

    Private Sub txtNumeroDoc_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumeroDoc.Enter
        txtNumeroDoc.SelectAll()
    End Sub

    Private Sub btnBuscarDocumento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarDocumento.Click
        Try
            If ValidarBusquedaDocumento() Then
                Ficha1.Tabs(0).Selected = True
                ListarDocumento(True)
            Else
                Throw New Exception
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtNumeroDoc_Validated_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumeroDoc.Validated
        txtNumeroDoc.Text = FormatoDocumento(txtNumeroDoc.Text, 10)
    End Sub

    Private Sub txtSerieDoc_Validated_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSerieDoc.Validated
        txtSerieDoc.Text = FormatoDocumento(txtSerieDoc.Text, 4)
    End Sub

    Public Sub ListarDocumento(ByVal Activo As Boolean)
        Try
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Dim oeMovDoc As New e_MovimientoDocumento
            Dim oeOrdDoc As New e_Orden_Documento
            Dim olOrdDoc As New l_Orden_Documento
            With oeMovDoc
                .Serie = txtSerieDoc.Value : .Numero = txtNumeroDoc.Value
                .Serie = FormatoDocumento(.Serie.Trim, 4) : .Numero = FormatoDocumento(.Numero.Trim, 10)
                .TipoOperacion = "MOV"
                .IdTipoDocumento = cboDocumentoAlmacen.Value
            End With
            With griListaDocumentoCompra
                .DataSource = olMovimientoDocumento.ListarDocumentosPorCompras(oeMovDoc)
                .DisplayLayout.Bands(0).Columns("Glosa").Hidden = True
                .DisplayLayout.Bands(0).Columns("IndServicioMaterial").Hidden = True
                .DisplayLayout.Bands(0).Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            End With
            With griListaDocumentoCompra
                'Ubica el cursor el el primer registro de la grilla
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                    oeOrdDoc.IdDocumento = .ActiveRow.Cells("Id").Value
                    oeOrdDoc.TipoOperacion = "Z"
                    oeOrdDoc = olOrdDoc.Obtener(oeOrdDoc)
                    Me.txt_NroOrden.Text = oeOrdDoc.IdOrden
                    Me.txtGlosaOC.Text = oeOrdDoc.UsuarioCreacion
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function ValidarBusquedaDocumento() As Boolean
        Try
            If Me.cboDocumentoAlmacen.SelectedIndex = -1 Then
                mensajeEmergente.Problema("Seleccione Tipo de Documento Por Favor")
                Me.txtNumeroDoc.Focus()
                Return False
            ElseIf Me.txtNumeroDoc.Text = "" Then
                mensajeEmergente.Problema("Escriba el Numero de Documento Por Favor")
                Me.txtNumeroDoc.Focus()
                Return False
            ElseIf Me.txtSerieDoc.Text = "" Then
                mensajeEmergente.Problema("Escriba el Numero de Serie Por Favor")
                Me.txtNumeroDoc.Focus()
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub txtNumeroDoc_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumeroDoc.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            Me.btnBuscarDocumento.Focus()
            Try
                If ValidarBusquedaDocumento() Then
                    ListarDocumento(True)
                Else
                    Throw New Exception
                End If
            Catch ex As Exception
                mensajeEmergente.Problema(ex.Message, True)
            End Try
        End If
    End Sub

    Private Sub griListaDocumentoCompra_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griListaDocumentoCompra.DoubleClick
        Try
            With Me.griListaDocumentoCompra
                If .Rows.Count > 0 Then
                    Me.cboTipoDocumento.Value = Me.cboDocumentoAlmacen.Value
                    Me.txtNumero.Text = .ActiveRow.Cells("Numero").Value.ToString
                    Me.txtSerie.Text = .ActiveRow.Cells("Serie").Value.ToString
                    Me.numImporte.Value = .ActiveRow.Cells("SubTotal").Value
                    Me.numTotal.Value = .ActiveRow.Cells("Saldo").Value
                    Me.numIGV.Value = .ActiveRow.Cells("IGV").Value
                    Me.cboProveedores.Value = .ActiveRow.Cells("IdClienteProveedor").Value.ToString
                    dtpFechaEmision.Value = .ActiveRow.Cells("FechaEmision").Value
                    dtpFecVencimiento.Value = .ActiveRow.Cells("FechaVencimiento").Value
                    Me.cboMoneda.Value = .ActiveRow.Cells("IdMoneda").Value.ToString
                    Me.fecPeriodo.Value = .ActiveRow.Cells("IdPeriodo").Value.ToString
                    IdDocumentoAlmacen = .ActiveRow.Cells("Id").Value.ToString
                    Me.txtGlosa2.Text = .ActiveRow.Cells("TipoPago").Value.ToString & " " & Me.txtGlosaOC.Text
                    IndCompraAlmacen = True
                    GloAux = Me.txtGlosa2.Text
                    idCompraAlm = IdDocumentoAlmacen
                    IdCuentaContableCompraAlmacen = .ActiveRow.Cells("IdCuentaContable").Value.ToString
                    Me.expDocumento.Expanded = False
                    LimpiaGrid(griListaDocumentoCompra, odListadoDocumentos)
                    Me.cboDocumentoAlmacen.SelectedIndex = -1
                    txtSerieDoc.Text = String.Empty
                    txtNumeroDoc.Text = String.Empty
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub expDocumento_ExpandedStateChanging(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles expDocumento.ExpandedStateChanging
        LimpiaGrid(griListaDocumentoCompra, odListadoDocumentos)
        Me.cboDocumentoAlmacen.SelectedIndex = -1
        txtSerieDoc.Text = String.Empty
        txtNumeroDoc.Text = String.Empty
        If expDocumento.Expanded = True Then
            dtpFechaEmision.Visible = True
            dtpFecVencimiento.Visible = True
            numGasto.TabStop = False
        Else
            dtpFechaEmision.Visible = False
            dtpFecVencimiento.Visible = False
        End If
    End Sub

#End Region

#Region "Cierre de Caja Externa"

    Private Sub CierreCuentaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CierreCuentaToolStripMenuItem.Click
        Try
            CierreCaja()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Function CierreCaja() As Boolean
        Try
            Dim oeCierreCaja As New e_CierreCaja
            Dim olCierreCaja As New l_CierreCaja
            Dim oeCierreCajaDet As New e_CierreCajaDet
            Dim loCierreCajaDet As New List(Of e_CierreCajaDet)
            Dim oeSaldo As New e_Saldo
            Dim olSaldo As New l_Saldo
            Dim idCtaTemp As String
            Dim indAprobado As Boolean = True
            Dim _ban As Boolean = False
            idCtaTemp = BuscarIdCtaCte(gUsuarioSGI.IdTrabajador, 1, loCuentaCorriente)
            Consultar(True)
            If GriCuentaAdministrativa.Rows.Count >= 1 Then
                If MessageBox.Show("Desea Cerrar la Cuenta Corriente?" & " " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) = Windows.Forms.DialogResult.Yes Then
                    For Each movadm As e_Movimiento_Administrativo In loMovimiento_Administrativo.Where(Function(item) item.TipoTransa = 6)
                        If movadm.IdEstado = "1" Then
                            indAprobado = False
                        End If
                    Next
                    If indAprobado = False Then Throw New Exception("No Puede Cerrar Hasta que se Aprueben sus Gastos")
                    Dim FechaCierre As Date = ObtenerFechaServidor()
                    oeSaldo = New e_Saldo
                    For Each Fila As Infragistics.Win.UltraWinGrid.UltraGridRow In GriCuentaAdministrativa.Rows
                        If Fila.Cells("Glosa").Value = "VUELTO ANTERIOR" Then
                            oeSaldo.Id = Fila.Cells("Id").Value
                            Exit For
                        End If
                    Next
                    Using Scope As New TransactionScope()
                        oeSaldo.PrefijoID = gs_PrefijoIdSucursal '@0001
                        If GriCuentaAdministrativa.Rows.Count > 0 Then
                            oeSaldo.TipoOperacion = "I"
                            oeSaldo.Saldo = Me.decSaldoCuentaAdm.Value
                            oeSaldo.Tipo = 1
                            oeSaldo.IdCaja = idCajaCentro
                            oeSaldo.FechaHora = FechaCierre
                            oeSaldo.Activo = 1
                            oeSaldo.UsuarioCreacion = gUsuarioSGI.Id
                            oeSaldo.IdCuentaCorriente = idCtaTemp
                            olSaldo.Guardar(oeSaldo)
                        End If
                        If oeSaldo.Id <> "" Then
                            oeSaldo.TipoOperacion = "S"
                            olSaldo.Guardar(oeSaldo)
                        End If
                        Dim oeValeRendir As New e_ValesRendir
                        Dim oeOtrosIngresos As New e_OtrosIngresos
                        oeMovimiento = New e_Movimiento
                        oeGastoOperacion = New e_GastoOperacion
                        oeMovimiento.TipoOperacion = "C"
                        oeMovimiento.IdCaja = idCajaCentro
                        oeMovimiento.FechaCierre = FechaCierre
                        oeGastoOperacion.TipoOperacion = "C"
                        oeGastoOperacion.IdCaja = idCajaCentro
                        oeGastoOperacion.FechaCierre = FechaCierre
                        oeValeRendir.TipoOperacion = "C"
                        oeValeRendir.IdCaja = idCajaCentro
                        oeValeRendir.FechaCierre = FechaCierre
                        oeOtrosIngresos.TipoOperacion = "C"
                        oeOtrosIngresos.IdCaja = idCajaCentro
                        oeOtrosIngresos.FechaCierre = FechaCierre
                        With oeCierreCaja
                            .TipoOperacion = "I"
                            .Monto = Me.decSaldoCuentaAdm.Value
                            .IdCentro = ObtenerCentro.Id
                            .IdCaja = idCajaCentro
                            .FechaCreacion = Date.Now
                            .UsuarioCreacion = gUsuarioSGI.Id
                            .Glosa = "CIERRE DE CAJA DEL DIA: " & Date.Now
                            For Each movadm As e_Movimiento_Administrativo In loMovimiento_Administrativo
                                oeCierreCajaDet = New e_CierreCajaDet()
                                oeCierreCajaDet.Fecha = movadm.Fecha
                                oeCierreCajaDet.Voucher = movadm.Voucher
                                oeCierreCajaDet.Glosa = movadm.Glosa
                                oeCierreCajaDet.Ingreso = movadm.Egreso
                                oeCierreCajaDet.Egreso = movadm.Ingreso
                                oeCierreCajaDet.PrefijoID = gs_PrefijoIdSucursal '@0001
                                loCierreCajaDet.Add(oeCierreCajaDet)
                            Next
                            .loCierreCajaDet.AddRange(loCierreCajaDet)
                            .oeMovimiento = oeMovimiento
                            .oeGastoOperacion = oeGastoOperacion
                            .oeValesRendir = oeValeRendir
                            .oeOtrosIngresos = oeOtrosIngresos
                        End With
                        oeCierreCaja.PrefijoID = gs_PrefijoIdSucursal '@0001
                        If olCierreCaja.Guardar(oeCierreCaja) Then
                            _ban = True
                            Scope.Complete()
                        End If
                    End Using
                    If _ban = True Then
                        mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
                        CargarMovimientosCuentaCorriente(idCuentaTrabajador, GriCuentaAdministrativa)
                        ControlBoton(1, 0, 0, 0, 1, 0, 0, 0, 1)
                    End If
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub CuadreCajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuadreCajaToolStripMenuItem.Click
        Try
            CuadreCaja()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub CuadreCaja()
        Try
            Dim CierreCaja As New frm_CuadreCaja
            CierreCaja = CierreCaja.getInstancia()
            CierreCaja.MdiParent = frm_Menu
            CierreCaja.Show()
            CierreCaja.CargarCierre(decSaldoCuentaAdm.Value, Date.Parse("01/01/1901"))
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Ingreso a FF de Cajas Externas"

    Private Sub decIngresoFF_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decIngresoFF.ValueChanged
        If IsDBNull(decIngresoFF.Value) Then decIngresoFF.Value = 0.0
    End Sub

    Private Sub expIngresoFF_ExpandedStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles expIngresoFF.ExpandedStateChanged
        If expIngresoFF.Expanded = True Then
            ControlBoton(1, 0, 0, 1, 1, 0, 0, 0, 1)
            decImporte.Value = 0.0
            txtGlosaFF.Text = ""
        Else
            ControlBoton(1, 0, 0, 0, 1, 0, 0, 0, 1)
            decImporte.Value = 0.0
            txtGlosaFF.Text = ""
        End If
    End Sub

#End Region

#Region "Generar Grupo"

    Private Sub GenerarGrupoFlete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarGrupoFlete.Click
        Dim oeGrupo As New e_Grupo
        Dim loGrupo As New List(Of e_Grupo)
        Dim oeGrupoDetalle As New e_GrupoDetalle
        Dim olGrupoDetalle As New l_GrupoDetalle
        Dim loGrupoDetalle As New List(Of e_GrupoDetalle)
        Try

            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            If GriCuentaAdministrativa.Rows.Count > 0 Then
                Dim Grupo As New frm_Grupo
                Grupo = Grupo.getInstancia()
                Grupo.MdiParent = frm_Menu
                Grupo.Show()
                Grupo.cboTipoGrupo.SelectedIndex = 3
                Grupo.AutogeneraGrupo(cboTrabajadorMovimiento.Value)
            End If
            'Grupo.Nuevo()
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

#End Region

#Region "Glosa Referencial - Viajes"

    Private Sub griLista_ClickCellButton(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griLista.ClickCellButton
        Try
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Select Case e.Cell.Column.Key
                Case "Glosa"
                    Dim oeVia As New e_Viaje
                    Dim olVia As New l_Operacion
                    oeVia.TipoOperacion = "X"
                    oeVia.GlosaEscala = griLista.ActiveRow.Cells("Glosa").Value
                    oeVia.Id = griLista.ActiveRow.Cells("IdViaje").Value
                    oeVia.PrefijoID = gs_PrefijoIdSucursal '@0001
                    If olVia.GuardarViaje(oeVia) Then mensajeEmergente.Confirmacion("Se Actualizó la Glosa Referencial Correctamente", True)
                    Listar(True)
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub griLista_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griLista.CellChange
        Try
            griLista.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Actualizacion de Peso y Costo de Estiba"

    Private Sub btnActPeso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActPeso.Click
        Try
            If decPeso.Value = 0 Then Throw New Exception("El Peso no Puede ser 0. Verificar")
            ActualizarPeso()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub ActualizarPeso()
        Try
            oeSeg = New e_Seguimiento
            oeSeg.IdViaje = IdViaje
            oeSeg.PesoToneladas = decPeso.Value
            oeSeg.TipoOperacion = "P"
            oeSeg.UsuarioCreacion = gUsuarioSGI.Id
            oeSeg.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olSeg.Guardar1(oeSeg) Then
                mensajeEmergente.Confirmacion("PesoActualizadoCorrectamente", True)
                MostrarPeso(IdViaje)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub MostrarPeso(ByVal idViaje As String)
        oeSeg = New e_Seguimiento
        btnActPeso.Visible = True
        Etiqueta61.Visible = True
        decPeso.Visible = True
        oeSeg.IdViaje = idViaje
        oeSeg.TipoOperacion = ""
        oeSeg = olSeg.Obtener(oeSeg)
        decPeso.Value = oeSeg.PesoToneladas
    End Sub

    Private Sub btnAgregarCostoEstiba_Click(sender As Object, e As EventArgs) Handles btnAgregarCostoEstiba.Click
        Try
            oeOperacionDetalle = New e_OperacionDetalle
            oeOperacionDetalle.TipoOperacion = "2"
            oeOperacionDetalle.Id = IdViaje
            oeOperacionDetalle.Consolidado = numCostoEstiba.Value
            oeOperacionDetalle.PrefijoID = gs_PrefijoIdSucursal '@0001
            olOperacion.GuardarOperacionDetalle(oeOperacionDetalle)
            mensajeEmergente.Confirmacion("Se ingreso Correctamente el Costo de Estiba", True)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Detalle Cuenta Administrativa"

    Private Sub decGastosAdm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decGastosAdm.Click
        Try
            Dim frm As New frm_DetalleCajaExterna
            frm.MostrarDetalle("0", Nothing, loGastosCaja, Nothing)
            frm.ShowDialog()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub decTotalVales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decTotalVales.Click
        Try
            Dim frm As New frm_DetalleCajaExterna
            frm.MostrarDetalle("1", Nothing, Nothing, loValRen)
            frm.ShowDialog()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub decTotalOtrosIngresos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decTotalOtrosIngresos.Click
        Try
            Dim frm As New frm_DetalleCajaExterna
            frm.MostrarDetalle("2", loOtrIng, Nothing, Nothing)
            frm.ShowDialog()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Proteccion de Modificacion"

    Public Sub GuardarRegistroEditado()
        Try
            If RegistroEditado = 1 Then
                oeRegistroEditado = New e_RegistrosEditados
                With oeRegistroEditado
                    .IdRegistro = griLista.ActiveRow.Cells("IdMovimiento").Value
                    .Referencia = "Movimiento"
                    .UsuarioEdita = gUsuarioSGI.Id
                End With
                oeRegistroEditado.PrefijoID = gs_PrefijoIdSucursal '@0001
                IdRegistroEditado = olRegistroEditado.Guardar(oeRegistroEditado)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function VerificarRegistroEditado() As Boolean
        Try
            Dim oeMov As New e_Movimiento
            Dim olMov As New l_Movimiento
            oeMov.Id = griLista.ActiveRow.Cells("IdMovimiento").Value
            oeMov.TipoOperacion = "B"
            oeMov = olMov.ObtenerMovimiento(oeMov)
            If oeMov.IdCuentaCorrienteDestino <> "" Then
                If oeMov.IdCuentaCorrienteOrigen <> gUsuarioSGI.oePersona.NombreCompleto Then
                    mensajeEmergente.Confirmacion("La información del Viaje no es accesible pues esta siendo editado por" & Environment.NewLine & Environment.NewLine & _
                                        "el Usuario: " & oeMov.IdCuentaCorrienteOrigen & Environment.NewLine & _
                                        "desde: " & oeMov.Fecha & Environment.NewLine & _
                                        "en la Sucursal: " & oeMov.IdMovimientoViaje, True)
                    Return False
                Else
                    oeRegistroEditado = New e_RegistrosEditados
                    With oeRegistroEditado
                        .TipoOperacion = "A"
                        .Id = oeMov.IdCuentaCorrienteDestino
                        .FechaModificado = DateAdd(DateInterval.Minute, 5, oeMov.Fecha)
                    End With
                    oeRegistroEditado.PrefijoID = gs_PrefijoIdSucursal '@0001
                    olRegistroEditado.Guardar(oeRegistroEditado)
                    RegistroEditado = 1
                End If
            Else
                RegistroEditado = 1
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ActualizaRegistroEditado() As Boolean
        Try
            If RegistroEditado = 1 Then
                oeRegistroEditado = New e_RegistrosEditados
                With oeRegistroEditado
                    .Id = IdRegistroEditado
                End With
                oeRegistroEditado.PrefijoID = gs_PrefijoIdSucursal '@0001
                olRegistroEditado.Guardar(oeRegistroEditado)
                RegistroEditado = 0
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

#Region "Movimientos Generados por Peaje"

    Private Sub mt_ListarMovimientos()
        Try
            Dim olVehiculoTarjeta As New l_VehiculoTarjeta
            Dim oeVehiculoTarjeta As e_VehiculoTarjeta = olVehiculoTarjeta.Obtener(New e_VehiculoTarjeta With {.IdVehiculo = txtTracto.Tag, _
                                                                                                               .Actual = True})
            loTarjetaMovimiento.Clear()
            If Not String.IsNullOrEmpty(oeVehiculoTarjeta.Id.Trim()) Then
                olTarjetaMovimiento = New l_TarjetaMovimiento
                For Each _Movimientos As e_TarjetaMovimiento In olTarjetaMovimiento.Listar(New e_TarjetaMovimiento With {.TipoOperacion = "GEN", _
                                                                                                      .NroTarjeta = oeVehiculoTarjeta.NroTarjeta, _
                                                                                                      .Fecha = dtpDesde.Value, _
                                                                                                      .FechaHasta = dtpHasta.Value}).OrderBy(Function(x) x.Ticket).Where(Function(x) x.IndIngresado = False).ToList
                    If leGastoOperacion.Where(Function(x) x.IdTarjetaMovimiento = _Movimientos.Id).Count = 0 Then
                        loTarjetaMovimiento.Add(_Movimientos)
                    End If
                Next
                griMovTarjeta.Text = "Nro Tarjeta : " & oeVehiculoTarjeta.NroTarjeta
                griMovTarjeta.DataBind()
                If Not String.IsNullOrEmpty(txtNumero.Tag) AndAlso txtNumero.Tag.ToString().Trim().Length <> 0 AndAlso _
                    griMovTarjeta.Rows.Where(Function(x) x.Cells("Id").Value = txtNumero.Tag).Count > 0 Then
                    griMovTarjeta.Rows.Where(Function(x) x.Cells("Id").Value = txtNumero.Tag).ToList(0).Appearance.BackColor = Color.LightGreen
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub griMovTarjeta_CellChange(sender As Object, e As CellEventArgs) Handles griMovTarjeta.CellChange
        Try
            griMovTarjeta.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub mt_AgregarMovTarjeta()
        Try
            With griMovTarjeta.ActiveRow
                If ListaFlujoCaja.Where(Function(x) x.Id = IdFCPeajes).Count > 0 Then  'PEAJES Y ESTACIONAMIENTO
                    cboFlujoCaja.Value = ListaFlujoCaja.Where(Function(x) x.Id = IdFCPeajes)(0).Id
                End If
                If ListaTipoDocumento.Where(Function(x) x.Id = IdTDTicketCinta).Count > 0 Then  'TICKET O CINTA EMITIDO POR MÁQUINA REGISTRADORA
                    cboTipoDocumento.Value = ListaTipoDocumento.Where(Function(x) x.Id = IdTDTicketCinta)(0).Id
                End If
                txtSerie.Text = "0001"
                txtNumero.Text = FormatoDocumento(.Cells("Ticket").Value.ToString().Trim(), 10)
                txtNumero.Tag = .Cells("Id").Value.ToString().Trim()
                dtpFechaEmision.Value = Convert.ToDateTime(.Cells("Fecha").Value.ToString().Trim()).Date
                fecHoraPeaje.Value = Convert.ToDateTime(.Cells("Fecha").Value.ToString().Trim())
                If ListaProveedor.Where(Function(x) x.NroDocumento = "20522547957").Count > 0 Then 'CONCESIONARIA VIAL DEL SOL S.A. - COVISOL S.A.
                    txtRUC.Text = ListaProveedor.Where(Function(x) x.NroDocumento = "20522547957")(0).NroDocumento
                    cboProveedores.Value = ListaProveedor.Where(Function(x) x.NroDocumento = "20522547957")(0).Id
                End If
                cboLugarL.Value = .Cells("IdLugar").Value.ToString().Trim()
                numImporte.Value = Math.Round(Convert.ToDecimal(.Cells("Monto").Value) / (1 + oeIGV.Porcentaje), 2, MidpointRounding.AwayFromZero)
                numIGV.Value = 0
                cboOpcionGasto.SelectedIndex = 1 'Prepago
                For Each _Fila As UltraGridRow In griMovTarjeta.Rows
                    _Fila.Appearance.BackColor = Color.White
                    If _Fila.Cells("Id").Value = txtNumero.Tag Then
                        _Fila.Appearance.BackColor = Color.LightGreen
                    End If
                Next
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub griMovTarjeta_DoubleClickRow(sender As Object, e As DoubleClickRowEventArgs) Handles griMovTarjeta.DoubleClickRow
        Try
            If e.Row.Index > -1 Then
                mt_AgregarMovTarjeta()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        Try
            mt_ListarMovimientos()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboLugarL_Validated(sender As Object, e As EventArgs) Handles cboLugarL.Validated
        Try
            If cboLugarL.SelectedIndex <> -1 Then
                Dim oe As New e_Peaje
                Dim ol As New l_Peaje
                oe.IdLugar = cboLugarL.Value
                oe.TipoOperacion = "GEN"
                oe = ol.Obtener(oe, False)
                If oe.IdEmpresa.Trim <> "" Then
                    For Each pro As e_Proveedor In ListaProveedor.Where(Function(i) i.IdEmpresa = oe.IdEmpresa).ToList
                        txtRUC.Text = pro.NroDocumento
                        cboProveedores.Value = pro.Id
                    Next
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

    Private Sub fechaRecibidor_ValueChanged(sender As Object, e As KeyEventArgs)

    End Sub
    Private Sub fechaMovimiento_ValueChanged(sender As Object, e As KeyEventArgs)

    End Sub
    Private Sub fecFechaDescuento_ValueChanged(sender As Object, e As KeyEventArgs)

    End Sub
    Private Sub fechaPrestamo_ValueChanged(sender As Object, e As KeyEventArgs)

    End Sub
End Class