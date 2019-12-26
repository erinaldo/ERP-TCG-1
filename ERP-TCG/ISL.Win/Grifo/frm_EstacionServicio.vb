' Hola Maurixito

Imports ERP.LogicaWCF
Imports ERP.EntidadesWCF
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win

Public Class frm_EstacionServicio
    Inherits frm_MenuPadre

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

#Region "Instancia"

    Private Shared instancia As frm_EstacionServicio = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_EstacionServicio()
        End If
        instancia.Activate()
        Return instancia
    End Function

    Private Sub frm_EstacionServicio_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        gmt_ControlBoton(0, 1, 0, 1, 0, 0, 0, 0, 1)
    End Sub

#End Region

#Region "Declaracion de Variables"

    Private TurnoActivo As New e_CierreTurno
    Private ListaVehiculo As New List(Of e_Vehiculo), dVehiculo As New l_Vehiculo
    Private MovimientoDocumento As New e_MovimientoDocumento, dMovimientoDocumento As New l_MovimientoDocumento, ListaMovimientoDocumento As New List(Of e_MovimientoDocumento)
    Private CuentaCorriente As New e_CuentaCorriente, dCuentaCorriente As New l_CuentaCorriente
    Private AsientoModelo As New e_AsientoModelo, dAsientoModelo As New l_AsientoModelo, ListaAsientoModelo As New List(Of e_AsientoModelo)
    Private ServicioCuentaContable As New e_ServicioCuentaContable, dServicioCuentaContable As New l_ServicioCuentaContable, ListaServicioCuentaContable As New List(Of e_ServicioCuentaContable)
    Private OrdenVenta As New e_OrdenVenta, dOrdenVenta As New l_OrdenVenta
    Private ListaRegistroInventario As New List(Of e_RegistroInventario)
    Private oeCtaBancaria As New e_CuentaBancaria, olCtaBancaria As New l_CuentaBancaria, leCuentaBancaria As New List(Of e_CuentaBancaria)
    Private oeCombo As New e_Combo, olCombo As New l_Combo
    Private ASIENTO As New e_Asiento, dASIENTO As New l_Asiento
    Private MovimientoCajaBanco As New e_MovimientoCajaBanco, dMovimietoCajaBanco As New l_MovimientoCajaBanco
    Private oeSaldoCtaCte As e_SaldoCtaCorriente, olSaldoCtaCte As New l_SaldoCtaCorriente, leSaldoCtaCte As New List(Of e_SaldoCtaCorriente)
    Private CuentaContable As New e_CuentaContable, dCuentaContable As New l_CuentaContable, ListaCuentaCotable As New List(Of e_CuentaContable)
    Private oeMoneda As New e_Moneda

    Private IdTipoDocumento As String, TipoDocumento As String
    Private IdTipoVenta As String, IdTipoPago As String 'Contado "1SI000000001", 
    Private sw_Lado As String
    Private IdMaterial_Combustible As String, Material_Combustible As String, Codigo_Combustible As String, IdAlmacen_Combustible As String, IdSubAlmacen_Combustible As String
    Private IdMoneda_Soles As String = "1CH01"
    Private CanDescuento As Double
    Private TipoCambio As Double = gfc_TipoCambio(ObtenerFechaServidor(), 1)
    Private FechaOrden As Date
    Private Ejercicio As Integer
    Private mdblIGV As Double = gfc_ParametroValor("IGV")
    Private EMPRESA As New e_Empresa, dEMPRESA As New l_Empresa
    Private DNI As String = "1CIX00000000000225"
    Private Ruc As String = "1CIX00000000000229"

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)

    End Sub

    Public Overrides Sub Nuevo()
        Try
            mt_Inicializar()
            Operacion = "Nuevo" : gmt_ControlBoton(0, 0, 0, 1, 0, 0, 0, 0, 1)
            cmb_Cliente.Focus()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Public Overrides Sub Editar()

    End Sub

    Public Overrides Sub Guardar()
        Try
            If cmb_Cliente.Value = "" Then Throw New Exception("Seleccione la empresa")
            If cmb_Vehiculo.Text = "" Then Throw New Exception("Ingrese una placa")
            If Not fc_Cargar_OrdenVenta() Then Throw New Exception
            If Not fc_Guardar_OrdenVenta() Then Throw New Exception
            mt_Ejecutar_OrdenSalida()

            If IdTipoDocumento <> "GCH000000001" Then
                If Not fc_Emitir_Documento() Then Throw New Exception
                If Not fc_Guardar_Cobros() Then Throw New Exception
            Else
                MsgBox("La Informacion ha Sido guardada Correctamente", MsgBoxStyle.Information, Me.Text)
            End If
            Nuevo()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Public Overrides Sub Cancelar()

    End Sub

    Public Overrides Sub Eliminar()

    End Sub

    Public Overrides Sub Exportar()

    End Sub

    Public Overrides Sub Imprimir()
        MyBase.Imprimir()
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

    Private Function fc_Guardar_OrdenVenta() As Boolean
        Try
            OrdenVenta = dOrdenVenta.Guardar_VentaRapida(OrdenVenta)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function fc_Cargar_OrdenVenta() As Boolean
        Try
            udg_Detalle.UpdateData()
            If cmb_Cliente.SelectedRow Is Nothing Then Throw New Exception("Seleccione Cliente")
            With OrdenVenta
                .TipoOperacion = "I" : .PrefijoID = gs_PrefijoIdSucursal : .IdEmpresaSis = gs_IdClienteProveedorSistema.Trim : .IdSucursal = gs_PrefijoIdSucursal : .UsuarioCrea = gUsuarioSGI.Login
                .Tipo = 2
                .TipoExistencia = 1
                .TipoCambio = TipoCambio
                .IndFactSer = True 'Revisar
                .IdVendedorTrabajador = "" ' Trabajador
                .IdEmpresa = cmb_Cliente.Value
                .Fecha = ObtenerFechaServidor()
                .IdMoneda = IdMoneda_Soles
                .IdTipoPago = IdTipoPago
                .Glosa = txt_Glosa.Value
                .Total = nud_Total.Value
                .SubTotal = nud_SubTotal.Value
                .Impuesto = nud_Impuesto.Value
                .TipoCompra = 0
                .IdEstado = "1CH000000003"
                .IdTurno = TurnoActivo.Id
                .IdTipoVenta = IdTipoVenta
                .IdCanalVenta = "GRIFO"
                .IdPlaca = cmb_Vehiculo.Value
                .IdPiloto = cmb_Piloto.Value
                .Kilometraje = nud_Kilometraje.Value
                .oeOrdenSalida = fc_Cargar_OrdenSalida()
                .oeDocumento = fc_Cargar_MovimientoDocumento()
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function fc_Cargar_MovimientoDocumento() As e_MovimientoDocumento
        Try
            MovimientoDocumento = New e_MovimientoDocumento
            Dim ItemDocumento As New e_DetalleDocumento
            With MovimientoDocumento
                .TipoOperacion = "I" : .IdEmpresaSis = gs_IdClienteProveedorSistema.Trim : .IdSucursal = gs_PrefijoIdSucursal : .PrefijoID = gs_PrefijoIdSucursal
                .IdClienteProveedor = OrdenVenta.IdEmpresa
                .IdTipoDocumento = IdTipoDocumento
                .IdEstadoDocumento = "1CIX025"
                .IdPeriodo = ""
                .IdMoneda = IdMoneda_Soles
                .Tipo = 2
                .IdTipoBien = 1
                .Serie = txt_Serie.Text
                .Numero = txt_Numero.Text
                .FechaEmision = dtp_FechaDocumento.Value
                .FechaVencimiento = dtp_FechaDocumento.Value
                .NoGravado = 0
                .IndCompraVenta = 2
                .SubTotal = Math.Round(nud_SubTotal.Value, 2)
                .IGV = Math.Round(nud_Impuesto.Value, 2)
                .Total = Math.Round(nud_Total.Value, 2)
                .Saldo = .Total
                .TipoCambio = TipoCambio
                .IdUsuarioCrea = gUsuarioSGI.Id
                .Mac_PC_Local = MacPCLocal()

                '' Cargar Detalle de Documento
                .lstDetalleDocumento = New List(Of e_DetalleDocumento)
                For Each ItemVenta In OrdenVenta.lstOrdenComercialMaterial
                    ItemDocumento.TipoOperacion = "I" : ItemDocumento.IdEmpresaSis = gs_IdClienteProveedorSistema.Trim : ItemDocumento.IdSucursal = gs_IdSucursal : ItemDocumento.PrefijoID = gs_PrefijoIdSucursal
                    ItemDocumento.IdMaterialServicio = ItemVenta.IdMaterial
                    ItemDocumento.IdTipoUnidadMedida = ItemVenta.IdTipoUnidadMedida
                    ItemDocumento.IdUnidadMedida = ItemVenta.IdUnidadMedida
                    ItemDocumento.CodigoMaterialServicio = ItemVenta.Codigo
                    ItemDocumento.Cantidad = ItemVenta.Cantidad
                    ItemDocumento.IndGravado = ItemVenta.IndImpuesto
                    ItemDocumento.IndServicioMaterial = "M"
                    ItemDocumento.Precio = ItemVenta.PrecioUnitario
                    ItemDocumento.Total = ItemVenta.PrecioTotal
                    ItemDocumento.PrecioUnitarioSinImp = Math.Round(IIf(ItemVenta.IndImpuesto, (ItemVenta.PrecioUnitario - ItemVenta.Dscto) / (1 + mdblIGV), ItemVenta.PrecioUnitario - ItemVenta.Dscto), 4, MidpointRounding.AwayFromZero)
                    ItemDocumento.UsuarioCreacion = gUsuarioSGI.Id
                    .lstDetalleDocumento.Add(ItemDocumento)
                Next

                '' Cargar Venta
                .Venta = New e_Venta
                .Venta.IdEmpresaSis = gs_IdClienteProveedorSistema.Trim
                .Venta.IdSucursal = gs_PrefijoIdSucursal
                .Venta.PrefijoID = gs_PrefijoIdSucursal
                .Venta.Gravado = Math.Round(nud_SubTotal.Value, 2)
                .Venta.IGV = Math.Round(nud_Impuesto.Value, 2)
                .Venta.IdTipoPago = IdTipoPago
                .Venta.Glosa = txt_Glosa.Text
                .Venta.IdTipoVenta = "1CH000036"
                .Venta.IndCliente = 2
                .Venta.TipoOperacion = "I"
            End With
            Return MovimientoDocumento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function fc_Cargar_OrdenDocumento() As e_Orden_Documento
        Try
            Dim OrdenDocumento As New e_Orden_Documento
            With OrdenDocumento
                .TipoOperacion = "I" : .IdEmpresaSistema = gs_IdEmpresaSistema : .PrefijoID = gs_PrefijoIdSucursal : .IdSucursalSistema = gs_IdSucursal : .UsuarioCreacion = gUsuarioSGI.Id
                .IdDocumento = MovimientoDocumento.Id.Trim
                .IdTipoDocumento = MovimientoDocumento.IdTipoDocumento
                .IdOrden = String.Empty
                .TipoOrden = 1
                .TipoExistencia = 1
            End With
            Return OrdenDocumento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function fc_Cargar_OrdenSalida() As e_Orden
        Try
            '' Cargar OS
            Dim OrdenSalida As New e_Orden, ItemSalida As New e_OrdenMaterial

            With OrdenSalida
                .TipoOperacion = "I" : .IdEmpresaSis = gs_IdEmpresaSistema : .PrefijoID = gs_PrefijoIdSucursal : .IdSucursal = gs_IdSucursal : .UsuarioCreacion = gUsuarioSGI.Id
                .IdTurno = OrdenVenta.IdTurno : .IdTrabajador = OrdenVenta.IdVendedorTrabajador : .IdCanalVenta = OrdenVenta.IdCanalVenta
                .IdProveedor = OrdenVenta.IdEmpresa
                .Glosa = TipoDocumento & " " & txt_Serie.Text & " - " & txt_Numero.Text
                .IdTipoOrden = "1CH000000002" : .TipoOrden = "ORDEN DE SALIDA"
                .TipoReferencia = "ORDEN VENTA" : .Referencia = OrdenVenta.Id
                .FechaOrden = OrdenVenta.Fecha
                .TipoCambio = TipoCambio
                .IdMovimientoInventario = "1CH000000038" : .MovimientoInventario = "SALIDA POR VENTAS" '"1CIX006"
                .IdSubAlmacenOrigen = IdSubAlmacen_Combustible : .IdSubAlmacenDestino = IdSubAlmacen_Combustible
                .IdMoneda = OrdenVenta.IdMoneda
                .IdEstadoOrden = "1CIX025"
                .Total = OrdenVenta.Total
                .lstOrdenMaterial = New List(Of e_OrdenMaterial)
                .lstInventario = New List(Of e_Inventario)
            End With
            For Each ItemVenta As e_OrdenVentaMaterial In OrdenVenta.lstOrdenComercialMaterial.Where(Function(i) i.CantidadAtender > 0).ToList
                ItemSalida = New e_OrdenMaterial
                With ItemSalida
                    .TipoOperacion = "I" : .IdEmpresaSis = gs_IdEmpresaSistema : .PrefijoID = gs_PrefijoIdSucursal : .IdSucursal = gs_IdSucursal : .UsuarioCreacion = gUsuarioSGI.Id
                    .IdAlmacen = ItemVenta.IdAlmacen
                    .IdSubAlmacen = ItemVenta.IdSubAlmacen
                    .IdMaterial = ItemVenta.IdMaterial
                    .IdUnidadMedida = ItemVenta.IdUnidadMedida
                    .CantidadMaterial = ItemVenta.CantidadAtender
                    .PrecioUnitario = ItemVenta.PrecioUnitario
                    .ValorVenta = ItemVenta.PrecioTotal
                    .Importe = ItemVenta.PrecioTotal
                    .Glosa = ItemVenta.Glosa
                End With
                OrdenSalida.lstOrdenMaterial.Add(ItemSalida)
            Next
            For Each item As e_OrdenMaterial In OrdenSalida.lstOrdenMaterial
                Dim Inventario As New e_Inventario, RegistroInventario As New e_RegistroInventario

                '' Registro Inventario
                With RegistroInventario
                    .TipoOperacion = "I" : .IdEmpresaSis = gs_IdEmpresaSistema : .PrefijoID = gs_PrefijoIdSucursal : .IdSucursal = gs_IdSucursal : .UsuarioCreacion = gUsuarioSGI.Id
                    .Id = ""
                    .IdMovimientoInventario = OrdenSalida.IdMovimientoInventario
                    .IdMaterial = item.IdMaterial
                    .IdUnidadMedida = item.IdUnidadMedida
                    .Cantidad = item.CantidadMaterial
                    .CantidadReal = ConvertirUnidadBase(item.CantidadMaterial, item.IdUnidadMedida)
                    .ValorUnitarioReal = (item.ValorVenta / .CantidadReal) / (1 + mdblIGV)
                    .ValorUnitario = item.PrecioUnitario / (1 + mdblIGV)
                    If OrdenSalida.IdMoneda = "1CH02" Then
                        .ValorUnitarioReal = .ValorUnitarioReal * TipoCambio
                        .ValorUnitario = .ValorUnitario * TipoCambio
                    End If
                    .ValorTotal = item.CantidadMaterial * .ValorUnitario
                    .Activo = item.Activo
                    .Fecha = OrdenSalida.FechaOrden
                    .IdAlmacen = item.IdAlmacen
                    .IdSubAlmacen = item.IdSubAlmacen
                    .TipoOperacion = OrdenSalida.TipoOperacion
                    .IdOrden = OrdenSalida.Id
                End With

                '' Inventario
                With Inventario
                    .TipoOperacion = "I" : .IdEmpresaSistema = gs_IdEmpresaSistema : .PrefijoID = gs_PrefijoIdSucursal : .IdSucursalSistema = gs_IdSucursal : .Usuario = gUsuarioSGI.Id : .FechaCreacion = Date.Now
                    .IdMaterial = RegistroInventario.IdMaterial
                    .IdSubAlmacen = RegistroInventario.IdSubAlmacen
                    .ValorUnitario = RegistroInventario.ValorUnitario
                    .CantidadIngreso = 0
                    .CantidadSalida = RegistroInventario.Cantidad
                    .ValorTotal = RegistroInventario.ValorTotal
                End With
                Inventario.oeRegistroInventario = RegistroInventario
                OrdenSalida.lstInventario.Add(Inventario)

            Next
            Return OrdenSalida
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Sub mt_Ejecutar_OrdenSalida()
        Try
            Dim olregistroinventario As New l_RegistroInventario
            Dim OrdenIngreso As New e_Orden, dOrden As New l_Orden

            If IdTipoVenta <> "CALIBRACIONES" Then
                olregistroinventario.Guardar(ListaRegistroInventario)
            Else
                With OrdenIngreso
                    .TipoOperacion = "I"
                    .IdEmpresaSis = gs_IdEmpresaSistema : .PrefijoID = gs_PrefijoIdSucursal : .IdSucursal = gs_IdSucursal : .UsuarioCreacion = gUsuarioSGI.Id
                    .IdTipoOrden = "1CH000000001" ' ORDEN DE INGRESO
                    .TipoReferencia = "ORDEN DE TRANSFERENCIA"
                    .Referencia = OrdenVenta.oeOrdenSalida.Referencia
                    .Id = ""
                    .NroOrden = ""
                    .IdProveedor = gs_IdClienteProveedorSistema.Trim
                    .FechaOrden = Date.Now
                    .IdMoneda = IdMoneda_Soles
                    .IdMovimientoInventario = "1CH000000022" 'INGRESO POR TRANSFERENCIA ENTRE ALMACENES
                    .IdEstadoOrden = ""
                    .UsuarioCreacion = gUsuarioSGI.Id
                    .IdSubAlmacenOrigen = IdSubAlmacen_Combustible : .IdSubAlmacenDestino = IdSubAlmacen_Combustible
                    .lstOrdenMaterial = OrdenVenta.oeOrdenSalida.lstOrdenMaterial
                End With

                'Dim oeOrdenTransferencia As New e_Orden
                'oeOrdenTransferencia.Id = ""
                'oeOrdenTransferencia.NroOrden = oeOrden.Referencia
                'oeOrdenTransferencia = olOrden.Obtener(oeOrdenTransferencia)

                'For Each item As e_OrdenMaterial In OrdenVenta.oeOrdenSalida.lstOrdenMaterial
                '    item.TipoOperacion = "I"
                '    item.UsuarioCreacion = gUsuarioSGI.Id
                '    item.Activo = 1
                '    item.IdSubAlmacen = "" 'oeOrdenTransferencia.IdSubAlmacenDestino
                '    item.IdAlmacen = "" 'oeOrdenTransferencia.IdSubAlmacenOrigen
                '    item.PrefijoID = gs_PrefijoIdSucursal '@0001
                '    listaOrdenMaterial.Add(item)
                'Next
                'oeOrdenIngreso.lstOrdenMaterial = listaOrdenMaterial
                'oeOrdenIngreso.PrefijoID = gs_PrefijoIdSucursal '@0001
                dOrden.Guardar(OrdenIngreso, ListaRegistroInventario)
            End If
        Catch ex As Exception
            Throw
        End Try

    End Sub

    Private Function fc_Guardar_Cobros() As Boolean
        Try
            '' Cargar Medio de Pago
            Dim MEDIOPAGO As New e_MedioPago, dMEDIOPAGO As New l_MedioPago
            MEDIOPAGO = dMEDIOPAGO.Obtener(New e_MedioPago With {.Id = "1CH03"})

            Dim indicadortipo As String = ""
            MovimientoCajaBanco = New e_MovimientoCajaBanco
            With MovimientoCajaBanco
                ._Operador = 1
                .Glosa = txt_Serie.Text & "-" & txt_Numero.Text
                .TipoOperacion = "I" : .IdEmpresaSistema = gs_IdEmpresaSistema : .IdSucursalSistema = gs_IdSucursal : .PrefijoID = gs_PrefijoIdSucursal : .UsuarioCreacion = gUsuarioSGI.Id
                .Fecha = OrdenVenta.Fecha
                .IdFlujoCaja = "1CH000000085" '1CH000000002 Venta de bienes
                .NroBoucher = ""
                .IdCta10 = "" ' "CHG001" 'CAJA CHICLAYO GRIFO - ESTACION SERVICIO
                .IdCuentaBancaria = "" '"CHG001" 'CAJA CHICLAYO GRIFO - ESTACION SERVICIO
                .IdMedioPago = "1CH03" 'Efectivo
                .IdPeriodoConcilia = Ejercicio
                .Activo = True
                .TipoCambio = OrdenVenta.TipoCambio
                .TotalMN = OrdenVenta.Total
                .TotalME = OrdenVenta.Total / OrdenVenta.TipoCambio
                .MovDoc = Nothing
                .Glosa = txt_Glosa.Text
                .DifAGanancia = 0
                .IdCuentaCorriente = cmb_Cliente.Value
            End With

            'If OptPerdida.Checked Then indicadortipo = "PER"
            'If OptGanancia.Checked Then indicadortipo = "GAN"
            'If OptCobro.Checked Then indicadortipo = "COB"
            ListaMovimientoDocumento.Add(MovimientoDocumento)
            If dASIENTO.GuardarCobranza(ListaMovimientoDocumento, MovimientoCajaBanco, MEDIOPAGO, gUsuarioSGI.Id, MacPCLocal, CuentaContable, indicadortipo) Then
                'If indicadortipo <> "PER" Then
                '    mensajeEmergente.Confirmacion("Cobro(s) guardados satisfactoriamente", True)
                '    Dim frm2 As New frm_ImprimeCobroPagoAnticipo(MOVIMIENTO.Id, 1, "Documento")
                '    frm2.ShowDialog()
                '    frm2 = Nothing
                'End If
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub mt_Emitir_Documento(IndMensaje As Boolean)
        Try
            Dim Cliente As New e_Cliente, dCliente As New l_Cliente
            Dim TIPODOC As New e_TipoDocumento, dTIPODOC As New l_TipoDocumento
            Dim _banEmis As Boolean = False
            Dim frm As New Frm_PeriodoTipoAsiento(True, False, False, "VTA")

            Cliente = dCliente.Obtener(New e_Cliente With {.TipoOperacion = "", .TipoClienteProveedor = 1, .Id = OrdenVenta.IdEmpresa})
            TIPODOC = dTIPODOC.Obtener(New e_TipoDocumento With {.TipoOperacion = "", .Id = IdTipoDocumento})
            oeMoneda.Id = IdMoneda_Soles 'Revisar

            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                Ejercicio = frm.Año1.Año
                ListaCuentaCotable = dCuentaContable.Listar(New e_CuentaContable With {.Ejercicio = frm.Año1.Año, .TipoOperacion = "N", .Movimiento = 1})
                MovimientoDocumento = OrdenVenta.oeDocumento
                'MovimientoDocumento = dMovimientoDocumento.Obtener(New e_MovimientoDocumento With {.Id = OrdenVenta.oeDocumento.Id, .CargaCompleta = True})
                With MovimientoDocumento
                    .IdPeriodo = frm.cboMes.Value
                    .Venta.TipoDoc = TIPODOC
                    .Venta.Cliente = Cliente
                    .Venta.Moneda = oeMoneda
                End With
                AsientoModelo.Equivale = 1 : AsientoModelo.IdMoneda = oeMoneda.Id

                If ListaAsientoModelo.Contains(AsientoModelo) Then
                    AsientoModelo = ListaAsientoModelo.Item(ListaAsientoModelo.IndexOf(AsientoModelo))
                    AsientoModelo.TipoOperacion = ""
                    AsientoModelo.Ejercicio = MovimientoDocumento.FechaEmision.Year
                    AsientoModelo = dAsientoModelo.Obtener(AsientoModelo)
                    'For Each _oeDet In ASIENTOMODELO.leDetalle
                    '    oeCtaCtble = New e_CuentaContable
                    '    oeCtaCtble.Cuenta = "12121" : oeCtaCtble.Equivale = 0
                    '    If loCtaCtble.Contains(oeCtaCtble) Then
                    '        oeCtaCtble = loCtaCtble.Item(loCtaCtble.IndexOf(oeCtaCtble))
                    '        _oeDet.IdCuentaContable = oeCtaCtble.Id
                    '    End If
                    'Next

                    'CuentaCorriente = dCuentaCorriente.Obtener(New e_CuentaCorriente With {.Tipo = 3, .IdTrabajador = Me.MovimientoDocumento.IdClienteProveedor})
                    'MovimientoDocumento.IdUsuarioCrea = gUsuarioSGI.Id

                    ServicioCuentaContable.IdServicio = gVSMercaderia : ServicioCuentaContable.Equivale = 1
                    If ListaServicioCuentaContable.Contains(ServicioCuentaContable) Then
                        ServicioCuentaContable = ListaServicioCuentaContable.Item(ListaServicioCuentaContable.IndexOf(ServicioCuentaContable))
                    Else
                        Throw New Exception("No Existen Cuenta Contable para el Servicio: " & gVSMercaderia & " para el Año: " & Date.Now.Year &
                                        Environment.NewLine & "Solicite el Apoyo del Area Contable.")
                    End If

                    If CuentaCorriente.Id <> "" Then
                        _banEmis = dMovimientoDocumento.GuardarVentaAsiento(MovimientoDocumento, AsientoModelo, ServicioCuentaContable, False, String.Empty)
                    Else
                        btnCrearCuentaCorriente.PerformClick()
                        _banEmis = dMovimientoDocumento.GuardarVentaAsiento(Me.MovimientoDocumento, AsientoModelo, ServicioCuentaContable, False, String.Empty)
                    End If

                    ' Actualizar Cuenta para Empresas Relacionada
                    'Dim _oeEmpr As New e_Cliente
                    '_oeEmpr.Equivale = 1
                    '_oeEmpr.Id = oeDoc.IdClienteProveedor.Trim
                    'If leCliente.Contains(_oeEmpr) Then
                    '    _oeEmpr = leCliente.Item(leCliente.IndexOf(_oeEmpr))
                    '    If _oeEmpr.IndRelacionada = 1 Then
                    '        For Each _oeDet In oeAsientoModelo.leDetalle
                    '            If Microsoft.VisualBasic.Left(_oeDet.Cuenta.Trim, 2) = "12" Then
                    '                Dim strCuenta As String = Replace(_oeDet.Cuenta, "2", "3", 1, 1)
                    '                Dim strNuevaCuenta As String = Microsoft.VisualBasic.Left(strCuenta, 3) & "33" & Microsoft.VisualBasic.Right(strCuenta, 1)
                    '                _oeDet.Cuenta = strNuevaCuenta
                    '                oeCtaContable = New e_CuentaContable
                    '                oeCtaContable.Cuenta = strNuevaCuenta : oeCtaContable.Equivale = 0
                    '                If leCtaContable.Contains(oeCtaContable) Then
                    '                    oeCtaContable = leCtaContable.Item(leCtaContable.IndexOf(oeCtaContable))
                    '                    _oeDet.IdCuentaContable = oeCtaContable.Id
                    '                End If
                    '            End If
                    '        Next
                    '    End If
                    'End If
                Else
                    Throw New Exception("No Existe Configuracion Contable")
                End If
            End If
            If _banEmis = True Then mensajeEmergente.Confirmacion("El Documento Nº " & txt_Serie.Text & " - " & txt_Numero.Text & " ha sido Emitido", True)
            '    Ejercicio = frm.cmbEjercicio.Text
            '    mt_ListarCtaCtble(Ejercicio)
            '    Dim oeDoc As New e_MovimientoDocumento
            '    If frm.cmbPeriodo.Value <> gfc_ObtenerPeriodo(dtpFechaDoc.Value) Then Throw New Exception("El documento no se puede emitir, Pertenece a otro Periodo..!")
            '    oeDoc.TipoOperacion = "2"
            '    oeDoc.Id = oeDocumento.Id : oeDoc.CargaCompleta = True
            '    oeDoc = olDocumento.Obtener(oeDoc)
            '    oeDoc.TipoOperacion = "C"
            '    oeDoc.IdUsuarioCrea = gUsuarioSGI.Id
            '    oeDoc.IdPeriodo = frm.cmbPeriodo.Value
            '    oeDoc.IdEstadoDocumento = "1CIX020"
            '    oeDoc.FechaCreacion = ObtenerFechaServidor()
            '    mt_ObtenerAsiento(oeDoc.IdMoneda)
            '    oeDoc.IdCuentaContable = oeCtaCtble.Cuenta
            '    'oeDoc.Venta.IdAsientoModelo = oeAsientoModelo.Id
            '    oeDoc.Venta.TipoOperacion = "A"
            '    'oeDoc.Venta. = gUsuarioSGI.Id
            '    'If Not olAsientoModelo.GuardarVentaMaterial(oeAsientoModelo, oeDoc) Then
            '    '    Throw New Exception("Error Enviando el Documento")
            '    'Else
            '    '    If IndMensaje Then
            '    '        MsgBox("La Informacion ha Sido Guardada Correctamente", MsgBoxStyle.Information, Me.Text)
            '    '        gmt_MostrarTabs(0, ficOrdenComercial, 2)
            '    '        Consultar(True)
            '    '    End If
            '    'End If
            '    'If cb_CobroAutomatico.Checked Then gfc_CobroAutomatico(oeDocumento.Id, frm.cmbPeriodo.Value, loCtaCtble, oeDoc.FechaCrea)
            'End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub frm_EstacionServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            _Activo = True
            TurnoActivo = gfc_obtener_TurnoActivo()
            mt_Inicializar()
            Nuevo()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mt_PaintBotones(Grupo As String)
        Select Case Grupo
            Case "TipoDocumento"
                btnDocumento.Appearance.BackColor = Color.White
                btnBoleta.Appearance.BackColor = Color.White
                btnNotaDespacho.Appearance.BackColor = Color.White
            Case "TipoPago"
                btn_Contado.Appearance.BackColor = Color.White
                btnCredito.Appearance.BackColor = Color.White
                btnCalibracion.Appearance.BackColor = Color.White
            Case "Lado"
                btnLado1.Appearance.BackColor = Color.White
                btnLado2.Appearance.BackColor = Color.White
                btnLado3.Appearance.BackColor = Color.White
                btnLado4.Appearance.BackColor = Color.White
                btnLado5.Appearance.BackColor = Color.White
                btnLado6.Appearance.BackColor = Color.White
            Case "Combustible"
                btnDB5.Appearance.ForeColor = Color.Black
                btnG84.Appearance.ForeColor = Color.Black
                btnG90.Appearance.ForeColor = Color.Black
                btnG95.Appearance.ForeColor = Color.Black
            Case "Clean"
                btnDocumento.Appearance.BackColor = Color.White
                btnBoleta.Appearance.BackColor = Color.White
                btnNotaDespacho.Appearance.BackColor = Color.White
                btn_Contado.Appearance.BackColor = Color.White
                btnCredito.Appearance.BackColor = Color.White
                btnLado1.Appearance.ForeColor = Color.Black
                btnLado2.Appearance.ForeColor = Color.Black
                btnLado3.Appearance.ForeColor = Color.Black
                btnLado4.Appearance.ForeColor = Color.Black
                btnLado5.Appearance.ForeColor = Color.Black
                btnLado6.Appearance.ForeColor = Color.Black
                btnDB5.Appearance.ForeColor = Color.Black
                btnG84.Appearance.ForeColor = Color.Black
                btnG90.Appearance.ForeColor = Color.Black
                btnG95.Appearance.ForeColor = Color.Black
        End Select
    End Sub

    Private Sub mt_ValidarSurtidor()
        Select Case sw_Lado
            Case "1" : btnDB5.Enabled = True : btnG84.Enabled = True : btnG90.Enabled = True : btnG95.Enabled = True
            Case "2" : btnDB5.Enabled = True : btnG84.Enabled = True : btnG90.Enabled = True : btnG95.Enabled = True
            Case "3" : btnDB5.Enabled = True : btnG84.Enabled = False : btnG90.Enabled = False : btnG95.Enabled = False
            Case "4" : btnDB5.Enabled = True : btnG84.Enabled = False : btnG90.Enabled = False : btnG95.Enabled = False
            Case "5" : btnDB5.Enabled = True : btnG84.Enabled = True : btnG90.Enabled = True : btnG95.Enabled = True
            Case "6" : btnDB5.Enabled = True : btnG84.Enabled = True : btnG90.Enabled = True : btnG95.Enabled = True
        End Select
    End Sub

    Private Function fc_Obtener_SaldoCuentaCorriente() As Double
        Try
            If cmb_Cliente.Value.ToString = "" Then Return 0
            Dim dCuentaCorriente As New l_CuentaCorriente, ListaCuentaCorriente As New List(Of e_CuentaCorriente)
            Dim dSaldoCuentaCorriente As New l_SaldoCtaCorriente
            ListaCuentaCorriente = dCuentaCorriente.Listar(New e_CuentaCorriente With {.Tipooperacion = "", .IdTrabajador = cmb_Cliente.Value})
            If ListaCuentaCorriente.Count > 0 Then
                For Each Item In ListaCuentaCorriente
                    Dim Saldos As New List(Of e_SaldoCtaCorriente)
                    CuentaCorriente = Item
                    Saldos = dSaldoCuentaCorriente.Listar(New e_SaldoCtaCorriente With {.TipoOperacion = "1", .IdCuentaCorriente = CuentaCorriente.Id})
                    If Saldos.Count > 0 Then
                        For Each Saldo In Saldos.OrderBy(Function(it) it.Id).ToList
                            Return Saldo.Saldo
                        Next
                    Else
                        Return 0
                    End If
                Next
            Else
                btnCrearCuentaCorriente.PerformClick()
            End If
            Return 0
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub mt_Inicializar()
        OrdenVenta = New e_OrdenVenta
        cmb_Cliente.Text = String.Empty
        cmb_Vehiculo.Value = ""
        udg_Detalle.DataSource = OrdenVenta.lstOrdenComercialMaterial

        '' Limpiar Controles
        cmb_Direccion.Text = ""
        nud_Cantidad.Value = 0
        nud_Preciounitario.Value = 0
        nud_Importe.Value = 0
        nud_SubTotal.Value = 0
        nud_Impuesto.Value = 0
        nud_Total.Value = 0
        txt_Serie.Text = String.Empty
        txt_Numero.Text = String.Empty
        txt_Glosa.Text = String.Empty
        grb_Combustible.Enabled = False
        nud_Kilometraje.Value = 0

        '' Valores Default
        FechaOrden = ObtenerFechaServidor()
        TipoCambio = gfc_TipoCambio(FechaOrden, True)
        mt_PaintBotones("Clean")
        udg_Detalle.DataSource = New List(Of e_OrdenVentaMaterial)
        gmt_OcultarColumna(udg_Detalle, True, "IndOperacion", "IdOrigen", "IdDestino")

        '' Cargar Listas y Combos
        ListaAsientoModelo = dAsientoModelo.Listar(New e_AsientoModelo With {.TipoOperacion = "A", .Activo = True, .Nombre = "1PY000000005"})
        leCuentaBancaria.AddRange(olCtaBancaria.Listar(New e_CuentaBancaria With {.IdCuentaContable = CuentaContable.Id, .Activo = True, .Ejercicio = Date.Parse(OrdenVenta.Fecha).Year, .TipoOperacion = "C"}))
        ListaServicioCuentaContable = dServicioCuentaContable.Listar(New e_ServicioCuentaContable With {.TipoOperacion = "V", .Activo = True, .Ejercicio = Date.Now.Year})
    End Sub

    Private Sub mt_AgregarDetalle()
        Try
            Dim OV_DETALLE As New e_OrdenVentaMaterial
            With OV_DETALLE
                .TipoOperacion = "I" : .IdEmpresaSis = gs_IdClienteProveedorSistema.Trim : .IdSucursal = gs_IdSucursal : .PrefijoID = gs_PrefijoIdSucursal : .UsuarioCrea = gUsuarioSGI.Id : .FechaCrea = FechaOrden
                .IndImpuesto = True
                .IdMaterial = IdMaterial_Combustible
                .Material = Material_Combustible
                .Codigo = Codigo_Combustible
                .Cantidad = nud_Cantidad.Value
                .CantidadAtender = nud_Cantidad.Value
                .CantidadPendiente = nud_Cantidad.Value
                .CostoUnitario = nud_Preciounitario.Value
                .CostoInventario = 0 'DETALLE.CostoUnitario
                .PrecioUnitario = nud_Preciounitario.Value
                .Dscto = 0
                .IdAlmacen = IdAlmacen_Combustible : .IdSubAlmacen = IdSubAlmacen_Combustible
                .IdUnidadMedida = "1CH000000001"
                .PrecioTotal = Math.Round(.PrecioUnitario * .Cantidad, 4)
                .Glosa = "LADO_" & sw_Lado
            End With
            If OrdenVenta.lstOrdenComercialMaterial.Where(Function(i) i.IdMaterial = OV_DETALLE.IdMaterial And i.TipoOperacion <> "E").ToList.Count > 0 Then
                udg_Detalle.DataBind()
                mt_CalcularTotalOrden()
                Throw New Exception("Material: " & OV_DETALLE.Material & " ya Asignado a la Orden")
            End If
            OrdenVenta.lstOrdenComercialMaterial.Add(OV_DETALLE)
            udg_Detalle.DataSource = OrdenVenta.lstOrdenComercialMaterial
            udg_Detalle.DataBind()
            mt_CalcularTotalOrden()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_Calcular_DescuentoCombustible()
        Dim ListaDescuentos As New List(Of e_EmpresaDescuento), dEmpresaDescuento As New l_EmpresaDescuento
        If IdMaterial_Combustible = "" Then Exit Sub
        If cmb_Cliente.Value = "" Then Exit Sub

        ListaDescuentos = dEmpresaDescuento.Listar(New e_EmpresaDescuento With {.IdEmpresa = cmb_Cliente.Value, .IdProducto = IdMaterial_Combustible})
        If ListaDescuentos.Count > 0 Then
            For Each Item In ListaDescuentos
                CanDescuento = IIf(IdTipoPago = "", Item.DescuentoCredito, Item.DescuentoContado)
            Next
        Else
            CanDescuento = 0
        End If
        nud_Preciounitario.Value = nud_Preciounitario.Value - CanDescuento
        nud_Cantidad.SelectAll()
    End Sub

    Private Sub btnCrearCuentaCorriente_Click(sender As Object, e As EventArgs) Handles btnCrearCuentaCorriente.Click
        CuentaCorriente = New e_CuentaCorriente
        With CuentaCorriente
            .Tipooperacion = "I" : .Tipo = 3 : .IdTrabajador = cmb_Cliente.Value
            .Saldo = 0 : .TotalCargo = 0 : .TotalAbono = 0 : .Ejercicio = Ejercicio : .Usuario = gUsuarioSGI.Id
            .IdEstado = "HABILITADA" : .IdMoneda = "1CH01" : .Glosa = "CUENTA DE EMPRESA" : .PrefijoID = gs_PrefijoIdSucursal '@0001
        End With
        CuentaCorriente = dCuentaCorriente.Guardar_CuentaCorriente(CuentaCorriente)
        nud_Saldo.Value = 0
    End Sub

    Private Sub decPrecioTotal_ValueChanged(sender As Object, e As EventArgs)
        Dim Importe As Double, Precio As Double, Cantidad As Double
        Importe = nud_Importe.Value
        Precio = nud_Preciounitario.Value
        Cantidad = Importe / Precio
    End Sub

    Private Sub btnCalibracion_Click(sender As Object, e As EventArgs) Handles btnCalibracion.Click
        btnNosotros.PerformClick()
        IdTipoPago = "1SI000000017" : IdTipoVenta = "CALIBRACION"
        mt_PaintBotones("TipoPago") : btnCalibracion.Appearance.BackColor = Color.Blue
        btnDocumento.Enabled = False : btnBoleta.Enabled = False : btnNotaDespacho.Enabled = True
        mt_Calcular_DescuentoCombustible()
    End Sub

    Private Sub mt_CalcularTotalOrden()
        Try
            Dim SubTotal As Double = 0, DescuentoTotal As Double = 0, Total As Double = 0
            For Each Item In OrdenVenta.lstOrdenComercialMaterial
                SubTotal += Item.PrecioTotal
                DescuentoTotal += Item.Dscto
                Total += SubTotal
            Next
            nud_SubTotal.Value = SubTotal
            nud_Total.Value = Total
            nud_Impuesto.Value = Total * mdblIGV
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_Imprimir_Documento()
        Dim id As String = ""
        Try

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnNosotros_Click(sender As Object, e As EventArgs) Handles btnNosotros.Click
        cmb_Cliente.Value = gs_IdClienteProveedorSistema
    End Sub

    Private Sub ActualizarTipoPago()
        Try
            Dim oe As New e_Combo
            oe.Id = IdTipoPago
            oe.Tipo = 0
            If TipoPagoPublic.Contains(oe) Then
                oe = TipoPagoPublic.Item(TipoPagoPublic.IndexOf(oe))
                'dtpFechaPago.Value = dtpFecha.Value.AddDays(CInt(DETALLE.Descripcion))
            Else
                Throw New Exception("No se Encuentra el Tipo de Pago. Verificar")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function fc_Emitir_Documento() As Boolean
        Try
            fc_ValidarNumeroDoc()
            mt_Emitir_Documento(False)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'Private Function fc_OrdDocumento() As List(Of e_Orden_Documento)
    '    Try
    '        oeOrdDocumento = New e_Orden_Documento
    '        loOrdDocumento = New List(Of e_Orden_Documento)
    '        With oeOrdDocumento
    '            .IdOrden = OV.Id
    '            .TipoOrden = 2
    '            .TipoOperacion = "I"
    '            .TipoExistencia = 1
    '            .UsuarioCreacion = gUsuarioSGI.Id
    '            loOrdDocumento.Add(oeOrdDocumento)
    '        End With
    '        Return loOrdDocumento
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Function

    Private Sub btnDB5_Click(sender As Object, e As EventArgs) Handles btnDB5.Click
        Procesar_BotonCombustible(btnDB5.Text)
    End Sub

    Private Sub btnG84_Click(sender As Object, e As EventArgs) Handles btnG84.Click
        Procesar_BotonCombustible(btnG84.Text)
    End Sub

    Private Sub cboPuntoPartida_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles cmb_Direccion.InitializeLayout
        Me.cmb_Cliente.ValueMember = "Id"
        Me.cmb_Cliente.DisplayMember = "Nombre"

        With cmb_Cliente.DisplayLayout.Bands(0)
            For Each Columna In .Columns
                Columna.Hidden = True
            Next
            .Columns("Nombre").Hidden = False : .Columns("Nombre").Header.Caption = "Direccion" : .Columns("Nombre").Width = 700
        End With
    End Sub

    Private Sub btnG90_Click(sender As Object, e As EventArgs) Handles btnG90.Click
        Procesar_BotonCombustible(btnG90.Text)
    End Sub

    Private Sub btnG95_Click(sender As Object, e As EventArgs) Handles btnG95.Click
        Procesar_BotonCombustible(btnG95.Text)
    End Sub

    Private Sub Procesar_BotonCombustible(Titulo As String)
        mt_PaintBotones("Combustible")
        Select Case Titulo
            Case "DB5" 'DB5
                btnDB5.Appearance.ForeColor = Color.White
                IdMaterial_Combustible = "1CH000007256" : Material_Combustible = "DIESEL DB5" : Codigo_Combustible = "TR0012145"
                IdAlmacen_Combustible = "CHT000000001" : IdSubAlmacen_Combustible = IIf(sw_Lado = 3 Or sw_Lado = 4, "CHT000000001", "CHT000000002")
            Case "G84" 'G84
                btnG84.Appearance.ForeColor = Color.White
                IdMaterial_Combustible = "1CH000000147" : Material_Combustible = "GASOHOL 84" : Codigo_Combustible = "TR0000154"
                IdAlmacen_Combustible = "CHT000000001" : IdSubAlmacen_Combustible = "CHT000000003"
            Case "G90" 'G90
                btnG90.Appearance.ForeColor = Color.White
                IdMaterial_Combustible = "1CH000000148" : Material_Combustible = "GASOHOL 90" : Codigo_Combustible = "TR0000155"
                IdAlmacen_Combustible = "CHT000000001" : IdSubAlmacen_Combustible = "CHT000000004"
            Case "G95" 'G95
                btnG95.Appearance.ForeColor = Color.White
                IdMaterial_Combustible = "1CH000000149" : Material_Combustible = "GASOHOL 95" : Codigo_Combustible = "TR0000156"
                IdAlmacen_Combustible = "CHT000000001" : IdSubAlmacen_Combustible = "CHT000000004"
        End Select

        '' Cargar Producto
        Dim PrecioNormal As Double = fc_Obtener_PrecioCombustible()
        nud_Preciounitario.Value = PrecioNormal
        mt_Calcular_DescuentoCombustible()
        grb_Combustible.Text = "Combustible ( " & Material_Combustible & " -> Precio Normal: S/. " & PrecioNormal & " || Descuento por Galon: S/. " & CanDescuento & " )"
        nud_Cantidad.SelectAll()
    End Sub

    Public Function fc_Obtener_PrecioCombustible() As Double
        For Each Item In TurnoActivo.Detalles
            If Item.IdConcepto = IdMaterial_Combustible Then
                Return Item.ValorERP
            End If
        Next
        Return 0
    End Function

    Private Sub btnDocumento_Click(sender As Object, e As EventArgs) Handles btnDocumento.Click
        IdTipoDocumento = "1CH000000026" : TipoDocumento = "FACTURA"
        mt_PaintBotones("TipoDocumento") : btnDocumento.Appearance.BackColor = Color.Blue
        txt_Serie.Text = "F013" : txt_Serie.Focus() : txt_Serie.SelectAll()
    End Sub

    Private Sub nud_Cantidad_Leave(sender As Object, e As EventArgs) Handles nud_Cantidad.Leave
        nud_Importe.Value = nud_Preciounitario.Value * nud_Cantidad.Value
        btnAgregarDetalle.Select()
    End Sub

    Private Sub nud_Importe_Leave(sender As Object, e As EventArgs) Handles nud_Importe.Leave
        nud_Cantidad.Value = nud_Importe.Value / nud_Preciounitario.Value
        btnAgregarDetalle.Select()
    End Sub

    Private Sub chk_HabilitarImporte_CheckedChanged(sender As Object, e As EventArgs) Handles chk_HabilitarImporte.CheckedChanged
        nud_Importe.Enabled = chk_HabilitarImporte.Checked
    End Sub

    Private Sub btnVale_Click(sender As Object, e As EventArgs) Handles btnBoleta.Click
        IdTipoDocumento = "1CH000000002" : TipoDocumento = "BOLETA DE VENTA"
        mt_PaintBotones("TipoDocumento") : btnBoleta.Appearance.BackColor = Color.Blue
        txt_Serie.Text = "B013" : txt_Serie.Focus() : txt_Serie.SelectAll()
    End Sub

    Private Sub btnVarios_Click(sender As Object, e As EventArgs) Handles btnNotaDespacho.Click
        IdTipoDocumento = "GCH000000001" : TipoDocumento = "NOTA DE DESPACHO"
        mt_PaintBotones("TipoDocumento") : btnNotaDespacho.Appearance.BackColor = Color.Blue
        txt_Serie.Text = "0004" : txt_Serie.Focus() : txt_Serie.SelectAll()
    End Sub

    Private Sub btnLado1_Click(sender As Object, e As EventArgs) Handles btnLado1.Click
        Procesar_Lado(btnLado1.Text)
        btnLado1.Appearance.BackColor = Color.DimGray
    End Sub

    Private Sub btnLado2_Click(sender As Object, e As EventArgs) Handles btnLado2.Click
        Procesar_Lado(btnLado2.Text)
        btnLado2.Appearance.BackColor = Color.DimGray
    End Sub

    Private Sub btnLado3_Click(sender As Object, e As EventArgs) Handles btnLado3.Click
        Procesar_Lado(btnLado3.Text)
        btnLado3.Appearance.BackColor = Color.DimGray
    End Sub

    Private Sub btnLado4_Click(sender As Object, e As EventArgs) Handles btnLado4.Click
        Procesar_Lado(btnLado4.Text)
        btnLado4.Appearance.BackColor = Color.DimGray
    End Sub

    Private Sub btnLado5_Click(sender As Object, e As EventArgs) Handles btnLado5.Click
        Procesar_Lado(btnLado5.Text)
        btnLado5.Appearance.BackColor = Color.DimGray
    End Sub

    Private Sub btnLado6_Click(sender As Object, e As EventArgs) Handles btnLado6.Click
        Procesar_Lado(btnLado6.Text)
        btnLado6.Appearance.BackColor = Color.DimGray
    End Sub

    Private Sub Procesar_Lado(Lado As String)
        sw_Lado = Lado : mt_ValidarSurtidor() : mt_PaintBotones("Lado") : grb_Combustible.Enabled = True
    End Sub

    Private Async Sub btnObtenerSunat_Click(sender As Object, e As EventArgs) Handles btnConsultarSUNAT.Click
        Try
            Dim empresa As New e_Empresa, lista_Empresa As New List(Of e_Empresa), d_Empresa As New l_Empresa, id As String
            Dim consultaRucSunat As New ConsultaRucSunat()
            Dim contribuyente As New Contribuyente
            Dim RUC As String = cmb_Cliente.Text
            contribuyente = Await consultaRucSunat.SunatConsultaRuc(RUC)

            lista_Empresa = d_Empresa.Listar(New e_Empresa)
            If lista_Empresa.Where(Function(it) it.Ruc = RUC).ToList.Count = 0 Then
                With empresa
                    .Ruc = contribuyente.RUC
                    .Nombre = contribuyente.RazonSocial
                    .DireccionFiscal = contribuyente.Direccion
                End With
                id = d_Empresa.Guardar(empresa)
            End If
            cmb_Cliente.Value = id
            cmb_Cliente.Text = contribuyente.RazonSocial
            cmb_Direccion.Text = contribuyente.Direccion
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnContado_Click(sender As Object, e As EventArgs) Handles btn_Contado.Click
        IdTipoPago = "1SI000000001" : IdTipoVenta = "VENTA_COMBUSTIBLE"
        mt_PaintBotones("TipoPago") : btn_Contado.Appearance.BackColor = Color.Blue
        btnDocumento.Enabled = True : btnBoleta.Enabled = True : btnNotaDespacho.Enabled = False
        mt_Calcular_DescuentoCombustible()
    End Sub

    Private Sub btnCredito_Click(sender As Object, e As EventArgs) Handles btnCredito.Click
        IdTipoPago = "1SI000000017" : IdTipoVenta = "VENTA_COMBUSTIBLE"
        mt_PaintBotones("TipoPago") : btnCredito.Appearance.BackColor = Color.Blue
        btnDocumento.Enabled = False : btnBoleta.Enabled = False : btnNotaDespacho.Enabled = True
        mt_Calcular_DescuentoCombustible()
    End Sub

    Private Sub btnAgregarDetalle_Click(sender As Object, e As EventArgs) Handles btnAgregarDetalle.Click
        mt_AgregarDetalle()
        grb_Combustible.Text = "Seleccione Combustible:"
        nud_Cantidad.Value = 0
        nud_Preciounitario.Value = 0
        nud_Importe.Value = 0
        nud_Cantidad.SelectAll()
    End Sub

    Private Function fc_ValidarNumeroDoc() As Boolean
        Try
            If txt_Numero.Text = "" Or txt_Serie.Text = "" Or txt_Numero.Text = "0000000000" Or txt_Serie.Text = "0000" Then
                Throw New Exception("!..El Numero de Documento es Incorrecto..!")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub cbgCliente_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles cmb_Cliente.InitializeLayout
        Me.cmb_Cliente.ValueMember = "Id"
        Me.cmb_Cliente.DisplayMember = "Nombre"

        With cmb_Cliente.DisplayLayout.Bands(0)
            For Each Columna In .Columns
                Columna.Hidden = True
            Next
            .Columns("Ruc").Hidden = False : .Columns("Ruc").Header.Caption = "N° RUC" : .Columns("Ruc").Width = 100
            .Columns("Nombre").Hidden = False : .Columns("Nombre").Width = 700
        End With
    End Sub

    Private Sub cbgCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_Cliente.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If Not String.IsNullOrEmpty(cmb_Cliente.Text.Trim) Then
                    gmt_ListarEmpresa("6", cmb_Cliente, String.Empty, cbRuc.Checked) 'tipo 6
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Sub cbgCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmb_Cliente.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            cmb_Cliente.PerformAction(UltraComboAction.Dropdown)
        End If
    End Sub

    Private Sub cbgCliente_Leave(sender As Object, e As EventArgs) Handles cmb_Cliente.Leave
        Try
            Dim loempresa As New List(Of e_Empresa), dClienteProveedor As New l_ClienteProveedor, ListaClienteProveedor As New List(Of e_ClienteProveedor)
            If Not cmb_Cliente.Value = "" Then
                ListaClienteProveedor = dClienteProveedor.Listar(New e_ClienteProveedor With {.TipoOperacion = "T", .Id = cmb_Cliente.Value})

                For Each Item In ListaClienteProveedor
                    loempresa = dEMPRESA.Listar(New e_Empresa With {.Id = Item.IdPersonaEmpresa})
                    For Each It In loempresa
                        cmb_Direccion.Text = It.DireccionFiscal
                    Next
                Next
                nud_Saldo.Value = fc_Obtener_SaldoCuentaCorriente()
                Cargar_VehiculoCliente()
                Cargar_Direcciones()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cmbVehiculo_EditorButtonClick(sender As Object, e As EventArgs) Handles cmb_Vehiculo.EditorButtonClick
        Try
            If MessageBox.Show("¿Desea Agregar Nuevo Vehículo?", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim frm As New frm_Vehiculo
                frm = frm.getInstancia()
                With frm
                    .MdiParent = frm_Menu
                    .Show()
                    .Nuevo()
                End With
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Sub txtSerie_Validated(sender As Object, e As EventArgs) Handles txt_Serie.Validated
        Dim Tipo As String
        If IdTipoDocumento <> "" Then
            If txt_Serie.TextLength < 4 Then
                Select Case IdTipoDocumento
                    Case "1CH000000026" : Tipo = "F"
                    Case "1CH000000002" : Tipo = "B"
                    Case "GCH000000001" : Tipo = "X"
                End Select
                txt_Serie.Text = FormatoSerieElectronica(txt_Serie.Text, Tipo) 'FormatoDocumento(txtSerie.Text, 4)
            End If
            txt_Numero.Text = FormatoDocumento(CStr(gfc_ObtenerNumeroDoc(txt_Serie.Text, IdTipoDocumento, 2)), 8)
            cmb_Piloto.Focus()
        End If
    End Sub

    Private Sub txtNumero_Leave(sender As Object, e As EventArgs) Handles txt_Numero.Leave
        If txt_Numero.Text <> "" Then txt_Numero.Text = FormatoDocumento(txt_Numero.Text, 8)
    End Sub

    Private Sub decKilometraje_Click(sender As Object, e As EventArgs) Handles nud_Kilometraje.Click
        nud_Kilometraje.SelectAll()
    End Sub
    Sub Cargar_VehiculoCliente()
        ListaVehiculo = New List(Of e_Vehiculo)
        If cmb_Cliente.Value = gs_IdClienteProveedorSistema Then
            ListaVehiculo.AddRange(dVehiculo.Listar(New e_Vehiculo With {.Motriz = 1, .IndPropiedad = 1, .TipoOperacion = "A"}))
        Else
            Dim eClienteProveedor As New e_ClienteProveedor
            Dim lCliente As New l_ClienteProveedor
            eClienteProveedor.TipoOperacion = ""
            eClienteProveedor.Id = cmb_Cliente.Value
            eClienteProveedor = lCliente.Obtener(eClienteProveedor)
            ListaVehiculo.AddRange(dVehiculo.Listar(New e_Vehiculo With {.Motriz = 1, .IdEmpresaPropietaria = eClienteProveedor.IdPersonaEmpresa, .TipoOperacion = "A"}))
        End If
        LlenarCombo(cmb_Vehiculo, "Placa", ListaVehiculo, -1)
    End Sub

    Private Sub Cargar_Pilotos()
        If cmb_Cliente.Value = gs_IdClienteProveedorSistema Then
            LlenarCombo(cmb_Piloto, "Nombre", PilotoPublic, -1)
        End If
    End Sub
    Private Sub Cargar_Direcciones()
        Dim ListaPuntoPartida As New List(Of e_Combo)
        Dim oeDireccionEmpresa As New e_Combo, ddireccionempresa As New l_Combo
        oeDireccionEmpresa.Nombre = "DireccionEmpresaFiscal"
        oeDireccionEmpresa.Id = cmb_Cliente.Value
        ListaPuntoPartida.AddRange(ddireccionempresa.Listar(oeDireccionEmpresa))
        LlenarComboMaestro(cmb_Direccion, ListaPuntoPartida, 0)
    End Sub
End Class