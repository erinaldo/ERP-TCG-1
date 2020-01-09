' ===================================================================================================
' Modified | Developer
' 02/01/20 | Cess
' ===================================================================================================
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
    Private Periodo As New e_Periodo, dPeriodo As New l_Periodo
    Private ListaLado As New List(Of e_Lado), dLado As New l_Lado

    Private swConsumoInterno As Boolean
    Private IdTipoDocumento As String, TipoDocumento As String, TipoDocumentoAbrev As String
    Private IdTipoVenta As String, IdTipoPago As String 'Contado "1SI000000001", 
    Private sw_Lado As String
    Private IdMaterial_Combustible As String, Material_Combustible As String, Codigo_Combustible As String, IdAlmacen_Combustible As String, IdSubAlmacen_Combustible As String
    Private IdMoneda_Soles As String = "1CH01"
    Private PrecioNormal As Double
    Private CanDescuento As Double
    Private TipoCambio As Double = gfc_TipoCambio(ObtenerFechaServidor(), 1)
    Private FechaOrden As Date
    Private Ejercicio As Integer
    Private mdblIGV As Double = gfc_ParametroValor("IGV")
    Private EMPRESA As New e_Empresa, dEMPRESA As New l_Empresa
    Private DNI As String = "1CIX00000000000225"
    Private Ruc As String = "1CIX00000000000229"
    Private IdEmpresaCliente As String
    Private swCredito As Boolean

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)

    End Sub

    Public Overrides Sub Nuevo()
        Try
            mt_Inicializar()
            Operacion = "Nuevo" : gmt_ControlBoton(0, 1, 0, 1, 0, 0, 0, 0, 1)
            cmb_Cliente.Focus()
            cmb_Cliente.Select()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Public Overrides Sub Editar()

    End Sub

    Public Overrides Sub Guardar()
        Try
            swConsumoInterno = IIf(IdEmpresaCliente = gs_IdClienteProveedorSistema, 1, 0)

            '' Validacion
            If IdTipoDocumento = "" Then Throw New Exception("Seleccione un TIPO de documento")
            If IdEmpresaCliente = "" Then Throw New Exception("Seleccione la empresa")
            If IdEmpresaCliente = "1CH000000003" And IdTipoDocumento = "1CH000000026" Then Throw New Exception("No se puede emitir FACTURA al cliente seleccionado")
            If cmb_Vehiculo.Text = "" Then Throw New Exception("Ingrese una placa")
            If IdEmpresaCliente = "1CH000000003" And nud_Total.Value >= 700 And IdTipoDocumento = "1CH000000002" Then Throw New Exception("No se puede emitir BOLETA por un importe mayor a S/ 700")
            'If swCredito = True And (OrdenVenta.Total > CuentaCorriente.Saldo + (CuentaCorriente.Saldo) * 0.1) Then Throw New Exception("El importe EXCEDE la linea de CREDITO disponible")

            '' Confirmacion
            If MessageBox.Show("DETALLES DE VENTA:" & vbCrLf &
                               "> DOCUMENTO: " & TipoDocumento & " " & txt_Serie.Text & "-" & txt_Numero.Text & vbCrLf &
                               "> CLIENTE: " & cmb_Cliente.Text & vbCrLf &
                               "> PRODUCTO: " & Material_Combustible & vbCrLf &
                               "> IMPORTE: S/ " & nud_Total.Value & vbCrLf &
                               "> PLACA: " & cmb_Vehiculo.Text & vbCrLf, "ERP", MessageBoxButtons.YesNo) = DialogResult.No Then Exit Sub

            '' Cargar Data
            If Not fc_Cargar_OrdenVenta() Then Throw New Exception
            If Not fc_Guardar_OrdenVenta() Then Throw New Exception

            '' Generar la Salida
            If swConsumoInterno Then
                mt_Generar_ConsumoCombustible()
            Else
                mt_Ejecutar_OrdenSalida()
            End If

            '' Generar el Ingreso (Solo para Calibraciones)
            If IdTipoVenta = "CALIBRACION" Then
                mt_Ejecutar_OrdenIngreso()
            End If

            'If IdTipoDocumento <> "GCH000000001" Then 'Nota de Despacho no se emite
            If Not fc_Emitir_Documento() Then Throw New Exception
            'End If
            If swCredito = False Then
                If Not fc_Guardar_Cobros() Then Throw New Exception
                'MsgBox("La Informacion ha Sido guardada Correctamente", MsgBoxStyle.Information, Me.Text)
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
    'FHA2196DTM2
    Public Function fc_Cargar_OrdenVenta() As Boolean
        Try
            udg_Detalle.UpdateData()
            With OrdenVenta
                .TipoOperacion = "I" : .PrefijoID = gs_PrefijoIdSucursal : .IdEmpresaSis = gs_IdClienteProveedorSistema.Trim : .IdSucursal = gs_PrefijoIdSucursal : .UsuarioCrea = gUsuarioSGI.Login : .FechaCrea = FechaOrden
                .Tipo = 2
                .TipoExistencia = 1
                .TipoCambio = TipoCambio
                .IndFactSer = True 'Revisar
                .IdVendedorTrabajador = gUsuarioSGI.IdTrabajador
                .IdEmpresa = IdEmpresaCliente
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
                .GlosaResumen = TipoDocumentoAbrev & txt_Serie.Text & "-" & txt_Numero.Text & "//COMBUSTIBLE: " & Material_Combustible & "//TOTAL: S/" & nud_Total.Value & "//PLACA: " & cmb_Vehiculo.Text
                If swConsumoInterno = False Then
                    .oeOrdenSalida = fc_Cargar_OrdenSalida()
                End If
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
                .TipoOperacion = "I" : .IdEmpresaSis = gs_IdClienteProveedorSistema.Trim : .IdSucursal = gs_PrefijoIdSucursal : .PrefijoID = gs_PrefijoIdSucursal : .IdUsuarioCrea = gUsuarioSGI.Id : .FechaCreacion = FechaOrden
                .IdClienteProveedor = OrdenVenta.IdEmpresa
                .IdTipoDocumento = IdTipoDocumento
                .IdEstadoDocumento = "1CIX025"
                ._Operador = 1
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
                .Venta.IdSucursal = gs_IdSucursal
                .Venta.PrefijoID = gs_PrefijoIdSucursal
                .Venta.Gravado = Math.Round(nud_SubTotal.Value, 2)
                .Venta.IGV = Math.Round(nud_Impuesto.Value, 2)
                .Venta.TotalVenta = Math.Round(nud_Total.Value, 2)
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
                .IdEstadoOrden = "1CH000000003"
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

    Dim OrdenIngreso As New e_Orden
    Private Function fc_Cargar_OrdenIngreso() As e_Orden
        Try
            '' Cargar OS
            Dim ItemSalida As New e_OrdenMaterial
            Dim aux As New e_OrdenVenta
            aux = dOrdenVenta.Obtener(New e_OrdenVenta With {.TipoOperacion = "", .Id = OrdenVenta.Id})

            With OrdenIngreso
                .TipoOperacion = "I" : .IdEmpresaSis = gs_IdEmpresaSistema : .PrefijoID = gs_PrefijoIdSucursal : .IdSucursal = gs_IdSucursal : .UsuarioCreacion = gUsuarioSGI.Id
                .IdTurno = OrdenVenta.IdTurno : .IdTrabajador = OrdenVenta.IdVendedorTrabajador : .IdCanalVenta = OrdenVenta.IdCanalVenta
                .IdProveedor = OrdenVenta.IdEmpresa
                .Glosa = TipoDocumento & " " & txt_Serie.Text & " - " & txt_Numero.Text
                .IdTipoOrden = "1CH000000001" : .TipoOrden = "ORDEN DE INGRESO"
                .TipoReferencia = "ORDEN VENTA" : .Referencia = aux.OrdenComercial
                .FechaOrden = OrdenVenta.Fecha
                .TipoCambio = TipoCambio
                .IdMovimientoInventario = "1CH000000013" : .MovimientoInventario = "MANTENIMIENTO - DEVOLUCION" '"1CIX006"
                .IdSubAlmacenOrigen = IdSubAlmacen_Combustible : .IdSubAlmacenDestino = IdSubAlmacen_Combustible
                .IdMoneda = OrdenVenta.IdMoneda
                .IdEstadoOrden = "1CIX025"
                .Total = OrdenVenta.Total
                .Glosa = "INGRESO POR CALIBRACION"
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
                OrdenIngreso.lstOrdenMaterial.Add(ItemSalida)
            Next
            For Each item As e_OrdenMaterial In OrdenIngreso.lstOrdenMaterial
                Dim Inventario As New e_Inventario, RegistroInventario As New e_RegistroInventario

                '' Registro Inventario
                With RegistroInventario
                    .TipoOperacion = "I" : .IdEmpresaSis = gs_IdEmpresaSistema : .PrefijoID = gs_PrefijoIdSucursal : .IdSucursal = gs_IdSucursal : .UsuarioCreacion = gUsuarioSGI.Id
                    .Id = ""
                    .IdMovimientoInventario = OrdenIngreso.IdMovimientoInventario
                    .IdMaterial = item.IdMaterial
                    .IdUnidadMedida = item.IdUnidadMedida
                    .Cantidad = item.CantidadMaterial
                    .CantidadReal = ConvertirUnidadBase(item.CantidadMaterial, item.IdUnidadMedida)
                    .ValorUnitarioReal = (item.ValorVenta / .CantidadReal) / (1 + mdblIGV)
                    .ValorUnitario = item.PrecioUnitario / (1 + mdblIGV)
                    If OrdenIngreso.IdMoneda = "1CH02" Then
                        .ValorUnitarioReal = .ValorUnitarioReal * TipoCambio
                        .ValorUnitario = .ValorUnitario * TipoCambio
                    End If
                    .ValorTotal = item.CantidadMaterial * .ValorUnitario
                    .Activo = item.Activo
                    .Fecha = OrdenIngreso.FechaOrden
                    .IdAlmacen = item.IdAlmacen
                    .IdSubAlmacen = item.IdSubAlmacen
                    .TipoOperacion = OrdenIngreso.TipoOperacion
                    .IdOrden = OrdenIngreso.Id
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
                OrdenIngreso.lstInventario.Add(Inventario)

            Next
            Return OrdenIngreso
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Sub mt_Ejecutar_OrdenSalida()
        Try
            Dim olregistroinventario As New l_RegistroInventario
            Dim OrdenIngreso As New e_Orden, dOrden As New l_Orden

            If IdTipoVenta <> "CALIBRACION" Then
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
                    .IdEstadoOrden = "1CH000000003"
                    .UsuarioCreacion = gUsuarioSGI.Id
                    .IdSubAlmacenOrigen = IdSubAlmacen_Combustible : .IdSubAlmacenDestino = IdSubAlmacen_Combustible
                    .lstOrdenMaterial.AddRange(OrdenVenta.oeOrdenSalida.lstOrdenMaterial)
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

    Sub mt_Ejecutar_OrdenIngreso()
        Try
            Dim olregistroinventario As New l_RegistroInventario
            Dim OrdenIngreso As New e_Orden, dOrden As New l_Orden

            OrdenIngreso = fc_Cargar_OrdenIngreso()
            dOrden.Guardar(OrdenIngreso, ListaRegistroInventario)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Function fc_Guardar_Cobros() As Boolean
        Try
            '' Cargar Medio de Pago
            Dim MEDIOPAGO As New e_MedioPago, dMEDIOPAGO As New l_MedioPago
            MEDIOPAGO = dMEDIOPAGO.Obtener(New e_MedioPago With {.Id = "1CH03"})

            Dim _oeCajaUsuario As e_CajaUsuario
            _oeCajaUsuario = BuscarCajaUsuario(gUsuarioSGI.IdTrabajador)

            Dim _oecaja As e_Caja, _olcaja As New l_Caja
            _oecaja = _olcaja.Obtener(New e_Caja With {.Id = _oeCajaUsuario.IdCaja})


            Dim indicadortipo As String = ""
            MovimientoCajaBanco = New e_MovimientoCajaBanco
            With MovimientoCajaBanco
                ._Operador = 1
                .Glosa = txt_Serie.Text & "-" & txt_Numero.Text
                .TipoOperacion = "I" : .IdEmpresaSistema = gs_IdEmpresaSistema : .IdSucursalSistema = gs_IdSucursal : .PrefijoID = gs_PrefijoIdSucursal : .UsuarioCreacion = gUsuarioSGI.Id
                .Fecha = Now.Date
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
                .IdCuentaCorriente = IdEmpresaCliente
                .IdCaja = _oecaja.Id
            End With

            'If OptPerdida.Checked Then indicadortipo = "PER"
            'If OptGanancia.Checked Then indicadortipo = "GAN"
            'If OptCobro.Checked Then indicadortipo = "COB"
            ListaMovimientoDocumento = New List(Of e_MovimientoDocumento)
            MovimientoDocumento.MontoOperar = OrdenVenta.Total

            CuentaContable = dCuentaContable.Obtener2(New e_CuentaContable With {.TipoOperacion = "Q", .Cuenta = _oecaja.CuentaContable, .Ejercicio = FechaOrden.Year})

            ListaMovimientoDocumento.Add(MovimientoDocumento)
            'MovimientoDocumento.MontoOperar 
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
            'Dim frm As New Frm_PeriodoTipoAsiento(True, False, False, "VTA")

            Cliente = dCliente.Obtener(New e_Cliente With {.TipoOperacion = "", .TipoClienteProveedor = 1, .Id = OrdenVenta.IdEmpresa})
            TIPODOC = dTIPODOC.Obtener(New e_TipoDocumento With {.TipoOperacion = "", .Id = IdTipoDocumento})
            oeMoneda.Id = IdMoneda_Soles 'Revisar

            'If frm.ShowDialog = Windows.Forms.DialogResult.OK Then

            Periodo = dPeriodo.Obtener(New e_Periodo With {.Ejercicio = FechaOrden.Year, .Mes = FechaOrden.Month})
            ListaCuentaCotable = dCuentaContable.Listar(New e_CuentaContable With {.Ejercicio = Periodo.Ejercicio, .TipoOperacion = "N", .Movimiento = 1})
            MovimientoDocumento = OrdenVenta.oeDocumento
                'MovimientoDocumento = dMovimientoDocumento.Obtener(New e_MovimientoDocumento With {.Id = OrdenVenta.oeDocumento.Id, .CargaCompleta = True})
                With MovimientoDocumento
                .IdPeriodo = Periodo.Id
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
            'End If
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
            mt_Inicializar()
            Nuevo()
            gmt_ConfigurarEventoKeyEnter_Tab(Me, btn_Contado.Name, btnCredito.Name, btnCalibracion.Name, btnDocumento.Name, btnBoleta.Name, btnNotaDespacho.Name, btnAgregarDetalle.Name)
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
            Case "Combustible"
                btnDB5.Appearance.BackColor = Color.White
                btnG84.Appearance.BackColor = Color.White
                btnG90.Appearance.BackColor = Color.White
                btnG95.Appearance.BackColor = Color.White
            Case "Clean"
                btnDocumento.Appearance.BackColor = Color.White
                btnBoleta.Appearance.BackColor = Color.White
                btnNotaDespacho.Appearance.BackColor = Color.White
                btn_Contado.Appearance.BackColor = Color.White
                btnCredito.Appearance.BackColor = Color.White
                btnDB5.Appearance.BackColor = Color.Black
                btnG84.Appearance.BackColor = Color.Black
                btnG90.Appearance.BackColor = Color.Black
                btnG95.Appearance.BackColor = Color.Black
        End Select
    End Sub

    Private Sub mt_ValidarSurtidor()
        'Select Case sw_Lado
        '    Case "" : btnDB5.Enabled = False : btnG84.Enabled = False : btnG90.Enabled = False : btnG95.Enabled = False
        '    Case "LADO_1" : btnDB5.Enabled = True : btnG84.Enabled = True : btnG90.Enabled = True : btnG95.Enabled = True
        '    Case "LADO_2" : btnDB5.Enabled = True : btnG84.Enabled = True : btnG90.Enabled = True : btnG95.Enabled = True
        '    Case "LADO_3" : btnDB5.Enabled = True : btnG84.Enabled = False : btnG90.Enabled = False : btnG95.Enabled = False
        '    Case "LADO_4" : btnDB5.Enabled = True : btnG84.Enabled = False : btnG90.Enabled = False : btnG95.Enabled = False
        '    Case "LADO_5" : btnDB5.Enabled = True : btnG84.Enabled = True : btnG90.Enabled = True : btnG95.Enabled = True
        '    Case "LADO_6" : btnDB5.Enabled = True : btnG84.Enabled = True : btnG90.Enabled = True : btnG95.Enabled = True
        'End Select
    End Sub

    Private Function fc_Obtener_SaldoCuentaCorriente() As Double
        Try
            If IdEmpresaCliente = "" Then Return 0
            Dim dCuentaCorriente As New l_CuentaCorriente, ListaCuentaCorriente As New List(Of e_CuentaCorriente)
            Dim Limite As Double = 0, Saldo As Double = 0
            ListaCuentaCorriente = dCuentaCorriente.Listar(New e_CuentaCorriente With {.Tipooperacion = "", .IdTrabajador = IdEmpresaCliente})
            EMPRESA = dEMPRESA.Obtener(New e_Empresa With {.TipoOperacion = "6", .Id = IdEmpresaCliente})
            Limite = EMPRESA.Credito
            If ListaCuentaCorriente.Count > 0 Then
                nud_Saldo.Appearance.ForeColor = Color.Blue
                For Each Item In ListaCuentaCorriente
                    CuentaCorriente = Item
                    Saldo = Item.Saldo
                    Return Limite + Saldo
                Next
            Else
                mt_Generar_CuentaCorriente()
                Return 0
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub mt_Inicializar()
        OrdenVenta = New e_OrdenVenta
        MovimientoDocumento = New e_MovimientoDocumento
        cmb_Cliente.Text = String.Empty
        cmb_Vehiculo.Value = ""
        udg_Detalle.DataSource = OrdenVenta.lstOrdenComercialMaterial

        '' Limpiar Controles
        cmb_Piloto.Text = ""
        nud_Saldo.Value = 0
        chk_HabilitarImporte.Checked = False
        cmb_Direccion.Text = ""
        nud_Cantidad.Value = 0
        nud_Preciounitario.Value = 0
        nud_Importe.Value = 0
        nud_SubTotal.Value = 0
        nud_Impuesto.Value = 0
        nud_Total.Value = 0
        nud_Cantidad.Value = 0
        nud_Preciounitario.Value = 0
        nud_Importe.Value = 0
        txt_Serie.Text = String.Empty
        txt_Numero.Text = String.Empty
        txt_Glosa.Text = String.Empty
        grb_Combustible.Enabled = False
        nud_Kilometraje.Value = 0


        '' Valores Default
        mt_Cargar_TurnoActivo()
        FechaOrden = ObtenerFechaServidor()
        TipoCambio = gfc_TipoCambio(FechaOrden, True)
        btnDocumento.Enabled = False : btnBoleta.Enabled = False : btnNotaDespacho.Enabled = False
        mt_PaintBotones("Clean")
        udg_Detalle.DataSource = New List(Of e_OrdenVentaMaterial)
        gmt_OcultarColumna(udg_Detalle, True, "IndOperacion", "IdOrigen", "IdDestino")
        nud_Saldo.Appearance.ForeColor = Color.Gray
        btnDB5.Text = "DB5" : btnG84.Text = "G84" : btnG90.Text = "G90" : btnG95.Text = "G95"
        UltraGroupBox2.Enabled = False

        '' Cargar Listas y Combos
        mt_CargarCombo_Lado()

        ListaAsientoModelo = dAsientoModelo.Listar(New e_AsientoModelo With {.TipoOperacion = "A", .Activo = True, .Nombre = "1PY000000005"})
        leCuentaBancaria.AddRange(olCtaBancaria.Listar(New e_CuentaBancaria With {.IdCuentaContable = CuentaContable.Id, .Activo = True, .Ejercicio = Date.Parse(OrdenVenta.Fecha).Year, .TipoOperacion = "C"}))
        ListaServicioCuentaContable = dServicioCuentaContable.Listar(New e_ServicioCuentaContable With {.TipoOperacion = "V", .Activo = True, .Ejercicio = Date.Now.Year})

        cmb_Lado.Rows(0).Selected = True
        cboProducto.SelectedIndex = 0 : Procesar_BotonCombustible(cboProducto.Value)
        cmb_Cliente.SelectAll()
    End Sub



    Private Sub mt_CargarCombo_Combustible()
        Dim ListaCombustible As New List(Of e_Material)
        Dim olMaterial As New l_Material, loMaterial = olMaterial.Listar(New e_Material With {.TipoOperacion = "S", .Activo = True})
        For Each Lado In ListaLado
            If Lado.Id = cmb_Lado.Value Then
                For Each Combustible In loMaterial
                    Select Case Combustible.Id
                        Case "1CH000001990" : If Lado.Diesel Then ListaCombustible.Add(Combustible)
                        Case "1CH000000147" : If Lado.G84 Then ListaCombustible.Add(Combustible)
                        Case "1CH000000148" : If Lado.G90 Then ListaCombustible.Add(Combustible)
                        Case "1CH000000149" : If Lado.G95 Then ListaCombustible.Add(Combustible)
                    End Select
                Next
            End If
        Next
        gmt_ComboEspecifico(cboProducto, ListaCombustible, 0, "Nombre")
        Procesar_BotonCombustible(cboProducto.Value)
    End Sub

    Private Sub mt_CargarCombo_Lado()
        ListaLado = dLado.Listar(New e_Lado With {.TipoOperacion = "ALL"})
        LlenarComboMaestro(cmb_Lado, ListaLado, 0)
        With cmb_Lado.DisplayLayout.Bands(0)
            For Each Columna In .Columns
                Columna.Hidden = True
            Next
            .Columns("Nombre").Hidden = False : .Columns("Nombre").Width = 150
        End With
    End Sub

    Private Sub mt_Agregar_Detalle()
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
                .Glosa = sw_Lado
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
        swCredito = IIf(IdTipoPago = "1SI000000001", 0, 1)
        If IdMaterial_Combustible = "" Then Exit Sub
        If IdEmpresaCliente = "" Then Exit Sub

        ListaDescuentos = dEmpresaDescuento.Listar(New e_EmpresaDescuento With {.IdEmpresa = IdEmpresaCliente, .IdProducto = IdMaterial_Combustible})
        If ListaDescuentos.Count > 0 Then
            For Each Item In ListaDescuentos
                CanDescuento = IIf(swCredito, Item.DescuentoCredito, Item.DescuentoContado)
            Next
        Else
            CanDescuento = 0
        End If
        grb_Combustible.Text = "( " & Material_Combustible & " -> P. Normal: S/. " & PrecioNormal & " || Dscto x Galon: S/. " & CanDescuento & " )"
        nud_Preciounitario.Value = PrecioNormal - CanDescuento
        nud_Cantidad.SelectAll()
    End Sub

    Private Sub btnCrearCuentaCorriente_Click(sender As Object, e As EventArgs) Handles btnCrearCuentaCorriente.Click
        mt_Generar_CuentaCorriente()
    End Sub

    Private Sub mt_Generar_CuentaCorriente()
        CuentaCorriente = New e_CuentaCorriente
        With CuentaCorriente
            .Tipooperacion = "I" : .Tipo = 3 : .IdTrabajador = IdEmpresaCliente
            .Saldo = 0 : .TotalCargo = 0 : .TotalAbono = 0 : .Ejercicio = Ejercicio : .Usuario = gUsuarioSGI.Id
            .IdEstado = "HABILITADA" : .IdMoneda = "1CH01" : .Glosa = "CUENTA DE EMPRESA" : .PrefijoID = gs_PrefijoIdSucursal '@0001
        End With
        CuentaCorriente = dCuentaCorriente.Guardar_CuentaCorriente(CuentaCorriente)
        nud_Saldo.Appearance.ForeColor = IIf(CuentaCorriente.Id = "", Color.Gray, Color.Blue)
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
        btnNotaDespacho.PerformClick() : txt_Serie.SelectAll() : cmb_Vehiculo.Text = "SERAFIN" : cmb_Lado.Focus()
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



    Private Sub cboPuntoPartida_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles cmb_Direccion.InitializeLayout
        Me.cmb_Direccion.ValueMember = "Id"
        Me.cmb_Direccion.DisplayMember = "Nombre"

        With cmb_Direccion.DisplayLayout.Bands(0)
            For Each Columna In .Columns
                Columna.Hidden = True
            Next
            .Columns("Nombre").Hidden = False : .Columns("Nombre").Header.Caption = "Direccion" : .Columns("Nombre").Width = 700
        End With
    End Sub

    Private Sub Procesar_BotonCombustible(Titulo As String)
        mt_PaintBotones("Combustible")
        Select Case Titulo
            Case "1CH000001990" 'DB5
                btnDB5.Appearance.BackColor = Color.Gray
                IdMaterial_Combustible = "1CH000001990" : Material_Combustible = cboProducto.Text : Codigo_Combustible = "TR0012145"
                IdAlmacen_Combustible = IIf(sw_Lado = "LADO_3" Or sw_Lado = "LADO_4", "1CH000000001", "1CH000000002")
                IdSubAlmacen_Combustible = IIf(sw_Lado = "LADO_3" Or sw_Lado = "LADO_4", "1CH000000003", "1CH000000005")
            Case "1CH000000147" 'G84
                btnG84.Appearance.BackColor = Color.Red
                IdMaterial_Combustible = "1CH000000147" : Material_Combustible = cboProducto.Text : Codigo_Combustible = "TR0000154"
                IdAlmacen_Combustible = "1CH000000004" : IdSubAlmacen_Combustible = "1CH000000009"
            Case "1CH000000148" 'G90
                btnG90.Appearance.BackColor = Color.LightGreen
                IdMaterial_Combustible = "1CH000000148" : Material_Combustible = cboProducto.Text : Codigo_Combustible = "TR0000155"
                IdAlmacen_Combustible = "1CH000000007" : IdSubAlmacen_Combustible = "1CH000000014"
            Case "1CH000000149" 'G95
                btnG95.Appearance.BackColor = Color.Blue
                IdMaterial_Combustible = "1CH000000149" : Material_Combustible = cboProducto.Text : Codigo_Combustible = "TR0000156"
                IdAlmacen_Combustible = "1CH000000006" : IdSubAlmacen_Combustible = "1CH000000012"
        End Select

        '' Cargar Producto
        PrecioNormal = fc_Obtener_PrecioCombustible()
        nud_Preciounitario.Value = PrecioNormal
        mt_Calcular_DescuentoCombustible()

        nud_Preciounitario.Value = PrecioNormal - CanDescuento
        'grb_Combustible.Text = "( " & Material_Combustible & " -> P. Normal: S/. " & PrecioNormal & " || Dscto x Galon: S/. " & CanDescuento & " )"
        nud_Cantidad.SelectAll()
    End Sub

    Public Function fc_Obtener_PrecioCombustible() As Double
        For Each Item In TurnoActivo.Detalles
            If Item.IdConcepto = IdMaterial_Combustible And Item.Rubro = "PRECIO_COMBUSTIBLE" Then
                Return Item.ValorERP
            End If
        Next
        Return 0
    End Function

    Private Sub nud_Cantidad_Leave(sender As Object, e As EventArgs) Handles nud_Cantidad.Leave
        Try
            nud_Importe.Value = nud_Preciounitario.Value * nud_Cantidad.Value
            btnDB5.Text = "DB5" : btnG84.Text = "G84" : btnG90.Text = "G90" : btnG95.Text = "G95"
            Select Case IdMaterial_Combustible
                Case "1CH000001990" 'DB5
                    btnDB5.Text = "DB5" & vbCrLf & nud_Cantidad.Value & " Gl" & vbCrLf & "S/" & nud_Importe.Value
                Case "1CH000000147" 'G84
                    btnG84.Text = "G84" & vbCrLf & nud_Cantidad.Value & " Gl" & vbCrLf & "S/" & nud_Importe.Value
                Case "1CH000000148" 'G90
                    btnG90.Text = "G90" & vbCrLf & nud_Cantidad.Value & " Gl" & vbCrLf & "S/" & nud_Importe.Value
                Case "1CH000000149" 'G95
                    btnG95.Text = "G95" & vbCrLf & nud_Cantidad.Value & " Gl" & vbCrLf & "S/" & nud_Importe.Value
            End Select
            btnAgregarDetalle.Select()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub nud_Importe_Leave(sender As Object, e As EventArgs) Handles nud_Importe.Leave
        Try
            If nud_Preciounitario.Value > 0 Then
                nud_Cantidad.Value = nud_Importe.Value / nud_Preciounitario.Value
            End If
            btnAgregarDetalle.Select()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub chk_HabilitarImporte_CheckedChanged(sender As Object, e As EventArgs) Handles chk_HabilitarImporte.CheckedChanged
        nud_Importe.ReadOnly = Not (chk_HabilitarImporte.Checked)
    End Sub

    Private Sub btnDocumento_Click(sender As Object, e As EventArgs) Handles btnDocumento.Click
        IdTipoDocumento = "1CH000000026" : TipoDocumento = "FACTURA" : TipoDocumentoAbrev = "F."
        mt_PaintBotones("TipoDocumento") : btnDocumento.Appearance.BackColor = Color.Blue
        txt_Serie.Text = "F103" : txt_Serie.Focus()
        cmb_Vehiculo.Focus()
    End Sub

    Private Sub btnVale_Click(sender As Object, e As EventArgs) Handles btnBoleta.Click
        IdTipoDocumento = "1CH000000002" : TipoDocumento = "BOLETA DE VENTA" : TipoDocumentoAbrev = "BV."
        mt_PaintBotones("TipoDocumento") : btnBoleta.Appearance.BackColor = Color.Blue
        txt_Serie.Text = "B103" : txt_Serie.Focus()
        cmb_Vehiculo.Focus()
    End Sub

    Private Sub btnVarios_Click(sender As Object, e As EventArgs) Handles btnNotaDespacho.Click
        IdTipoDocumento = "GCH000000001" : TipoDocumento = "NOTA DE DESPACHO" : TipoDocumentoAbrev = "NTD."
        mt_PaintBotones("TipoDocumento") : btnNotaDespacho.Appearance.BackColor = Color.Blue
        txt_Serie.Text = "0004" : txt_Serie.Focus()
        cmb_Vehiculo.Focus()
    End Sub

    Private Sub cmb_Lado_Leave(sender As Object, e As EventArgs) Handles cmb_Lado.Leave
        sw_Lado = cmb_Lado.Text
        If cmb_Lado.Text = "" Then
            grb_Combustible.Enabled = False
        Else
            grb_Combustible.Enabled = True
        End If
    End Sub

    Private Sub btn_Turno_Click(sender As Object, e As EventArgs) Handles btn_Turno.Click
        mt_Cargar_TurnoActivo()
    End Sub

    Private Sub mt_Cargar_TurnoActivo()
        TurnoActivo = gfc_obtener_TurnoActivo()
        Select Case RTrim(TurnoActivo.IdTurno)
            Case "1", "3", "5" : btn_Turno.Text = TurnoActivo.Turno : btn_Turno.Appearance.BackColor = Color.LightGreen
            Case "2", "4" : btn_Turno.Text = TurnoActivo.Turno : btn_Turno.Appearance.BackColor = Color.LightBlue
            Case "" : btn_Turno.Text = "REGISTRAR TURNO" : btn_Turno.Appearance.BackColor = Color.Red
        End Select
    End Sub
    Private Sub frm_EstacionServicio_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        instancia = Nothing
    End Sub

    Private Sub cmb_Lado_ValueChanged(sender As Object, e As EventArgs) Handles cmb_Lado.ValueChanged
        Procesar_Lado(cmb_Lado.Text)
        cboProducto.Focus()
        cboProducto.Select()
    End Sub

    Private Sub cboProducto_ValueChanged(sender As Object, e As EventArgs) Handles cboProducto.ValueChanged
        Procesar_BotonCombustible(cboProducto.Value)
        nud_Cantidad.Select()
    End Sub

    Private Sub TipoVenta_KeyDown(sender As Object, e As KeyEventArgs) Handles btn_Contado.KeyDown, btnCredito.KeyDown, btnCalibracion.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnDocumento.Select()
        End If
    End Sub

    Private Sub Documento_KeyDown(sender As Object, e As KeyEventArgs) Handles btnDocumento.KeyDown, btnBoleta.KeyDown, btnNotaDespacho.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmb_Piloto.Select()
        End If
    End Sub

    Private Sub cmb_Lado_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_Lado.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboProducto.Select()
        End If
    End Sub

    Private Sub cboProducto_KeyDown(sender As Object, e As KeyEventArgs) Handles cboProducto.KeyDown
        nud_Cantidad.Select()
    End Sub

    Private Sub nud_Cantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles nud_Cantidad.KeyDown
        btnAgregarDetalle.PerformClick()
    End Sub

    Private Sub btnNosotros_Click(sender As Object, e As EventArgs) Handles btnNosotros.Click
        mt_Cargar_EmpresaAutomatico("NOSOTROS")
        cmb_Piloto.Focus()
        cmb_Piloto.Select()
    End Sub

    Private Sub btn_Otros_Click(sender As Object, e As EventArgs) Handles btn_Otros.Click
        mt_Cargar_EmpresaAutomatico("OTROS")
        cmb_Vehiculo.Focus()
        cmb_Vehiculo.Select()
    End Sub

    Private Sub mt_Cargar_EmpresaAutomatico(ByVal Empresa As String)
        Select Case Empresa
            Case "NOSOTROS"
                cmb_Cliente.Value = gs_IdClienteProveedorSistema
                cmb_Cliente.Text = gs_TxtEmpresaSistema
                'cmb_Direccion.Text = gs_DireccionEmpresaSistema
                IdEmpresaCliente = gs_IdClienteProveedorSistema
                mt_Validar_OperacionesCliente(IdEmpresaCliente)
                Cargar_Pilotos()
                Cargar_VehiculoCliente()
                Cargar_Direcciones()
            Case "OTROS"
                cmb_Cliente.Value = "1CH000000003"
                cmb_Cliente.Text = "OTROS"
                'cmb_Direccion.Text = ""
                IdEmpresaCliente = "1CH000000003"
                mt_Validar_OperacionesCliente(IdEmpresaCliente)
                Cargar_Direcciones()
        End Select
    End Sub

    Private Sub frm_EstacionServicio_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        instancia = Nothing
    End Sub

    Private Sub Procesar_Lado(Lado As String)
        sw_Lado = Lado : mt_CargarCombo_Combustible() : mt_ValidarSurtidor() : mt_PaintBotones("Lado") : grb_Combustible.Enabled = True
    End Sub

    Private Async Sub btnObtenerSunat_Click(sender As Object, e As EventArgs) Handles btnConsultarSUNAT.Click
        Try
            Dim empresa As New e_Empresa, lista_Empresa As New List(Of e_Empresa), d_Empresa As New l_Empresa, id As String = ""
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

    Private Sub btn_RUC_Click(sender As Object, e As EventArgs) Handles btn_RUC.Click
        cbRuc.Checked = IIf(cbRuc.Checked, False, True)
        btn_RUC.Appearance.BackColor = IIf(cbRuc.Checked, Color.LightGreen, Color.LightGray)
    End Sub

    Private Sub btnContado_Click(sender As Object, e As EventArgs) Handles btn_Contado.Click
        IdTipoPago = "1SI000000001" : IdTipoVenta = "VENTA_COMBUSTIBLE"
        mt_PaintBotones("TipoPago") : btn_Contado.Appearance.BackColor = Color.Blue
        btnDocumento.Enabled = True : btnBoleta.Enabled = True : btnNotaDespacho.Enabled = False
        btnDocumento.Enabled = IIf(IdEmpresaCliente = "1CH000000003", False, True)
        mt_Calcular_DescuentoCombustible()
    End Sub

    Private Sub btnCredito_Click(sender As Object, e As EventArgs) Handles btnCredito.Click
        IdTipoPago = "1SI000000017" : IdTipoVenta = "VENTA_COMBUSTIBLE"
        mt_PaintBotones("TipoPago") : btnCredito.Appearance.BackColor = Color.Blue
        btnDocumento.Enabled = False : btnBoleta.Enabled = False : btnNotaDespacho.Enabled = True
        mt_Calcular_DescuentoCombustible()
    End Sub

    Private Sub btnAgregarDetalle_Click(sender As Object, e As EventArgs) Handles btnAgregarDetalle.Click
        If nud_Importe.Value = 0 Then Exit Sub
        mt_Agregar_Detalle()
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
                IdEmpresaCliente = cmb_Cliente.Value
                ListaClienteProveedor = dClienteProveedor.Listar(New e_ClienteProveedor With {.TipoOperacion = "T", .Id = IdEmpresaCliente})

                For Each Item In ListaClienteProveedor
                    loempresa = dEMPRESA.Listar(New e_Empresa With {.Id = Item.IdPersonaEmpresa})
                    For Each It In loempresa
                        cmb_Direccion.Text = It.DireccionFiscal
                    Next
                Next
                nud_Saldo.Value = fc_Obtener_SaldoCuentaCorriente()

                Cargar_Pilotos()
                Cargar_VehiculoCliente()
                Cargar_Direcciones()

                '' Validacion por Empresa
            End If

            mt_Validar_OperacionesCliente(cmb_Cliente.Value)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_Validar_OperacionesCliente(IdCliente As String)
        Select Case IdCliente
            Case gs_IdClienteProveedorSistema
                UltraGroupBox2.Enabled = True
                btn_Contado.Enabled = False : btnCredito.Enabled = True : btnCalibracion.Enabled = True
                btnCredito.PerformClick() : btnNotaDespacho.PerformClick() : txt_Serie.Focus() : txt_Serie.SelectAll() : cmb_Vehiculo.Focus() : cmb_Vehiculo.SelectAll()
            Case "1CH000000003"
                UltraGroupBox2.Enabled = True
                btn_Contado.Enabled = True : btnCredito.Enabled = False : btnCalibracion.Enabled = False
                btn_Contado.PerformClick() : btnBoleta.PerformClick() : txt_Serie.Focus() : txt_Serie.SelectAll() : cmb_Vehiculo.Focus() : cmb_Vehiculo.SelectAll()
            Case ""
                UltraGroupBox2.Enabled = False
                btn_Contado.Enabled = True : btnCredito.Enabled = True : btnCalibracion.Enabled = True
            Case Else
                UltraGroupBox2.Enabled = True
                btn_Contado.Enabled = True : btnCredito.Enabled = True : btnCalibracion.Enabled = True
        End Select
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
        If IdEmpresaCliente = gs_IdClienteProveedorSistema Then
            ListaVehiculo.AddRange(dVehiculo.Listar(New e_Vehiculo With {.Motriz = 1, .IndPropiedad = 1, .TipoOperacion = "A"}))
        Else
            Dim eClienteProveedor As New e_ClienteProveedor
            Dim lCliente As New l_ClienteProveedor
            eClienteProveedor.TipoOperacion = ""
            eClienteProveedor.Id = IdEmpresaCliente
            eClienteProveedor = lCliente.Obtener(eClienteProveedor)
            ListaVehiculo.AddRange(dVehiculo.Listar(New e_Vehiculo With {.Motriz = 1, .IdEmpresaPropietaria = eClienteProveedor.IdPersonaEmpresa, .TipoOperacion = "A"}))
        End If
        LlenarCombo(cmb_Vehiculo, "Placa", ListaVehiculo, -1)
    End Sub

    Private Sub Cargar_Pilotos()
        If IdEmpresaCliente = gs_IdClienteProveedorSistema Then
            LlenarCombo(cmb_Piloto, "Nombre", PilotoPublic, -1)
        End If
    End Sub
    Private Sub Cargar_Direcciones()
        Dim ListaPuntoPartida As New List(Of e_Combo)
        Dim oeDireccionEmpresa As New e_Combo, ddireccionempresa As New l_Combo
        oeDireccionEmpresa.Nombre = "DireccionEmpresaFiscal"
        oeDireccionEmpresa.Id = IdEmpresaCliente
        ListaPuntoPartida = ddireccionempresa.Listar(oeDireccionEmpresa)
        If ListaPuntoPartida.Count > 0 Then
            LlenarComboMaestro(cmb_Direccion, ListaPuntoPartida, 0)
            cmb_Direccion.Rows(0).Selected = True
            btn_Contado.Select()
        End If
    End Sub

    Private OrdenAux As New e_Orden
    Private oeRegConsumoCombustible As New e_RegistroConsumoCombustible, olRegConsumoCombustible As New l_RegistroConsumoCombustible
    Private Referencia As New e_AsientoModelo_Referencia, olReferencia As New l_AsientoModelo_Referencia, loReferencia As New List(Of e_AsientoModelo_Referencia)
    Private dtReferencia As New DataTable

    Public Sub AsientoConsumo(oeRegConsumoCombustible As e_RegistroConsumoCombustible, Tipo As Integer)
        Try
            OrdenAux = New e_Orden

            Periodo = dPeriodo.Obtener(New e_Periodo With {.Ejercicio = FechaOrden.Year, .Mes = FechaOrden.Month})
            If Periodo.Id = "" Then Throw New Exception("No Existe el Periodo Contable de Este Periodo. Comunicar a Contabilidad")
            OrdenAux.IndAsiento = True
            OrdenAux.loAsientoModelo = New List(Of e_AsientoModelo)
            OrdenAux.lstInventario = New List(Of e_Inventario)

            '' Obtener Asiento Modelo
            Dim dtAux = New Data.DataTable, _rwAux() As Data.DataRow, cadSQL As String = String.Empty
            cadSQL = "TipoRef1 = 4 AND IdRef1 = '" & IdMoneda_Soles & "'"
            _rwAux = dtReferencia.Select(cadSQL, "")
            If _rwAux.Count = 0 Then Throw New Exception("Error en el Modelo de Asiento Contable. Verificar")
            dtAux = _rwAux.CopyToDataTable
            AsientoModelo = dAsientoModelo.Obtener(New e_AsientoModelo With {.TipoOperacion = "", .Activo = True, .Id = dtAux.Rows(0).Item("IdAsientoModelo").ToString, .Ejercicio = Periodo.Ejercicio})
            OrdenAux.loAsientoModelo = New List(Of e_AsientoModelo)
            OrdenAux.loAsientoModelo.Add(AsientoModelo)

            If Tipo = 1 Then
                OrdenAux.Total = (oeRegConsumoCombustible.CantidadGalon * oeRegConsumoCombustible.PrecioUnitario)
            End If
            OrdenAux.IdPeriodo = Periodo.Id
            OrdenAux.UsuarioCreacion = gUsuarioSGI.Id
            OrdenAux.FechaOrden = FechaOrden
            OrdenAux.TipoCambio = TipoCambio
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function mt_Generar_ConsumoCombustible() As Boolean
        Try
            '' Listar Asientos Modelo
            ListaAsientoModelo = dAsientoModelo.Listar(New e_AsientoModelo With {.TipoOperacion = "A", .Activo = True, .Nombre = "1CH000000138"}) 'Registro Consumo Combustible
            loReferencia = olReferencia.Listar(New e_AsientoModelo_Referencia With {.TipoOperacion = "N", .Activo = True, .IdReferencia = "1CH000000138"})
            dtReferencia = GeneraDTRef(loReferencia)

            For Each ItemVenta In OrdenVenta.lstOrdenComercialMaterial
                With oeRegConsumoCombustible
                    .TipoOperacion = "I" : .PrefijoID = gs_PrefijoIdSucursal : .UsuarioCreacion = gUsuarioSGI.Id
                    .FechaTanqueo = FechaOrden
                    .CantidadGalon = ItemVenta.Cantidad
                    .Perfil = ObtenerPerfilPrincipal.Nombre
                    .Ind_Masivo = False
                    .Estado = IIf(.Estado = "PAR", .Estado, IIf(.Estado = "FAC", .Estado, "SIN"))
                    .SaldoGls = 0.0
                    .IdMaterial = ItemVenta.IdMaterial
                    If .FechaCreacion.Date = Date.Parse("01/01/1901") Then .FechaCreacion = ObtenerFechaServidor()
                    .IndIsl = IIf(IdEmpresaCliente = gs_IdClienteProveedorSistema, True, False)
                    .PrecioUnitario = ItemVenta.PrecioUnitario
                    .GlosaValeTanqueo = ItemVenta.Glosa
                    .KilometrosTanqueo = IIf(OrdenVenta.Kilometraje = 0, 1, OrdenVenta.Kilometraje)
                    .IdVehiculo = IIf(cmb_Vehiculo.Value <> "", cmb_Vehiculo.Value, cmb_Vehiculo.Text)
                    .NroVale = OrdenVenta.Id
                    .IdPiloto = OrdenVenta.IdPiloto
                    .Glosa = OrdenVenta.GlosaResumen
                    .IdGrifo = "1SI000004245" 'Inversiones y Servicios Alex y Lalito
                    .IdDireccion = "CHT0000001"
                    .IdAlmacen = ItemVenta.IdAlmacen : .IdSubAlmacen = ItemVenta.IdSubAlmacen
                    .lstInventario = New List(Of e_Inventario)
                    If .TipoOperacion = "I" Then
                        If .IndIsl Then AsientoConsumo(oeRegConsumoCombustible, 1)
                        'oeCombo = New e_Combo
                        'oeCombo.Tipo = 4
                        'oeCombo.Nombre = cboGrifo.Value
                        'oeCombo.Descripcion = cboDireccion.Value
                        'If SubAlmDiesel.Contains(oeCombo) Then
                        '    oeCombo = SubAlmDiesel.Item(SubAlmDiesel.IndexOf(oeCombo))
                        'Else
                        '    Throw New Exception("No existe el SubAlmacen. Verificar")
                        'End If
                        'IdSubAlmacen = oeCombo.Id
                        .lstInventario = Inventario(oeRegConsumoCombustible, False, ObtenerFechaServidor())
                    End If
                    '@0001
                End With
                oeRegConsumoCombustible = olRegConsumoCombustible.Guardar(oeRegConsumoCombustible, New e_Orden With {.FechaOrden = FechaOrden, .PrefijoID = gs_PrefijoIdSucursal})
            Next
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Function

    Private Function Inventario(oe As e_RegistroConsumoCombustible, IndValidar As Boolean, FechaActual As Date) As List(Of e_Inventario)
        Try
            Dim loInventario As New List(Of e_Inventario), oeRegInventario As e_RegistroInventario, oeInventario As New e_Inventario
            With oeInventario
                .IdOrden = oe.NroVale
                .IdMaterial = oe.IdMaterial
                .FechaCreacion = FechaActual
                .IdSubAlmacen = oe.IdSubAlmacen
                .CantidadSalida = oe.CantidadGalon
                .ValorUnitario = Math.Round(oe.PrecioUnitario, 4)
                .Usuario = gUsuarioSGI.Id
                .IndValidar = IndValidar
            End With
            oeRegInventario = New e_RegistroInventario
            With oeRegInventario
                .Fecha = FechaOrden
                .TipoOperacion = "I"
                .IdMaterial = oe.IdMaterial
                .IdSubAlmacen = oe.IdSubAlmacen
                .IdMovimientoInventario = "1CH000000028"
                .IdUnidadMedida = "1CH000000001"
                .Cantidad = oe.CantidadGalon
                .IdOrden = oe.NroVale
                .UsuarioCreacion = gUsuarioSGI.Id
            End With
            oeInventario.oeRegistroInventario = New e_RegistroInventario
            oeInventario.oeRegistroInventario = oeRegInventario
            loInventario.Add(oeInventario)
            Return loInventario
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub mt_Quitar_Detalle()
        Dim oeOrdenComercialMaterial As New e_OrdenVentaMaterial
        If udg_Detalle.Selected.Rows.Count > 0 Then
            oeOrdenComercialMaterial = New e_OrdenVentaMaterial
            oeOrdenComercialMaterial = udg_Detalle.ActiveRow.ListObject
            If oeOrdenComercialMaterial.TipoOperacion = "I" Then
                OrdenVenta.lstOrdenComercialMaterial.Remove(oeOrdenComercialMaterial)
            End If
        End If
        udg_Detalle.DataBind()
        mt_CalcularTotalOrden()
    End Sub

    Private Sub udg_Detalle_KeyDown(sender As Object, e As KeyEventArgs) Handles udg_Detalle.KeyDown
        If udg_Detalle.Selected.Rows.Count > 0 Then
            If e.KeyCode = Keys.Delete Then
                mt_Quitar_Detalle()
            End If
        End If
    End Sub

    ''REVISAR:
    'Public Sub ObtenerStockUltPrecio()
    '    Try
    '        If Not String.IsNullOrEmpty(cboDireccion.Value) Then
    '            oeCombo = New e_Combo
    '            oeCombo.Tipo = 4
    '            oeCombo.Nombre = cboGrifo.Value
    '            oeCombo.Descripcion = cboDireccion.Value
    '            If SubAlmDiesel.Contains(oeCombo) Then
    '                oeCombo = SubAlmDiesel.Item(SubAlmDiesel.IndexOf(oeCombo))
    '            Else
    '                Throw New Exception("No existe el SubAlmacen. Verificar")
    '            End If
    '            IdSubAlmacen = oeCombo.Id
    '            If Not String.IsNullOrEmpty(oeCombo.Id) Then
    '                'oeMaterialAlmacen = New e_MaterialAlmacen
    '                'oeMaterialAlmacen.TipoOperacion = "1"
    '                'oeMaterialAlmacen.IdAlmacen = oeSubAlmacen.IdAlmacen
    '                'oeMaterialAlmacen.IdMaterial = cmb_TipoCombustible.Value
    '                'oeMaterialAlmacen = olMaterialAlmacen.Obtener(oeMaterialAlmacen)
    '                oeInventario = New e_Inventario
    '                oeInventario.TipoOperacion = "5"
    '                oeInventario.IdSubAlmacen = oeCombo.Id
    '                oeInventario.IdMaterial = cmb_TipoCombustible.Value
    '                oeInventario = olInventario.Obtener(oeInventario)
    '                decStock.Value = oeInventario.CantidadFinal
    '                nd_PrecioUnitario.Value = oeInventario.ValorUnitario ''REVISAR
    '            Else
    '                decStock.Value = 0
    '                nd_PrecioUnitario.Value = 0
    '            End If
    '        End If
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub

End Class