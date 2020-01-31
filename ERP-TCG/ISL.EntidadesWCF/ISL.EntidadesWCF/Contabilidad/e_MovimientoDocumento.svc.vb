<DataContract()> _
Public Class e_MovimientoDocumento
    Implements Ie_MovimientoDocumento
    Implements IEquatable(Of e_MovimientoDocumento)
    Implements ICloneable

#Region "Declaración de variables"

    Private _id As String
    Private _idtipodocumento As String
    Private _nombredocumento As String
    <DataMember()> _
    Public _AbrevTipoDoc As String
    Private _serie As String
    Private _numero As String
    Private _fechaemision As Date
    Private _fechavencimiento As Date
    Private _igv As Double
    Private _subtotal As Double
    Private _total As Double
    Private _saldo As Double
    Private _idclienteproveedor As String
    Public _NombreClienteProveedor As String
    Private _idasientomovimiento As String
    Private _activo As Boolean
    Private _IdPeriodo As String
    Private _IdMoneda As String
    Private _Moneda As String
    Private _abreviaturaMoneda As String
    Private _IndCompraVentas As Integer
    Private _TipoCambio As Double
    Private _IdUsuarioCrea As String
    Private _FechaCreacion As Date
    Private _SaldoDetraccion As Double
    Private _glosa As String
    Private _Neto As Double
    Private _IndDetraccion As Boolean
    Private _IndElectronico As Boolean
    Private _OrdenCompra As String
    Private _IdTipoBien As String
    Private _IndAnexo As Boolean
    Private _CodMotivo As String
    Private _EstadoSunat As String
    Private _IndDetalleGlosa As Boolean
    'Private _IndEnviado As Boolean
    Private _IndAnulado As Boolean
    Private _Abrev_Empresa As String
    Private _Item As Integer

    Public Property IdEmpresaSis() As String
    Public Property IdSucursal() As String
    Public DatosImpresion As New e_MovimientoDocumento_Impresion
    'ANTICIPOS
    Private _IndAnticipo As Boolean
    Private _IndAfectaAnticipo As Boolean
    Private _Monto_Anticipo As Double

    <DataMember()> _
    Public _Operador As Integer
    Private _IdCuentaContable As String 'Id de Cuenta Contable - Módulo Cobranza
    <DataMember()> _
    Public _idMovimientoCajaBanco As String ' Id de Moviento Caja Banco para modulo cobranza
    <DataMember()> _
    Public _IdFlujoMovimientoCaja As String ' Id flujo del anticipo de caja
    <DataMember()> _
    Public _MontoOperar As Double
    <DataMember()> _
    Public _MontoCanje As Double
    <DataMember()> _
    Public _Retencion As Double
    <DataMember()> _
    Public _Retencion_Letra As Double
    <DataMember()> _
    Public _Retencion_Saldo As Double
    Private _idestadodocumento As String
    Private _estadodocumento As String
    <DataMember()> _
    Public CuentaxCyP As e_CuentaxCyP
    <DataMember()> _
    Public Venta As New e_Venta
    <DataMember()> _
    Public Compra As New e_Compra
    <DataMember()> _
    Public DocSinAsoc As New e_DocumentoSinAsociacion
    <DataMember()> _
    Public LstOrden As New List(Of e_Orden)
    <DataMember()> _
    Public oeTipoDocumento As e_TipoDocumento
    <DataMember()>
    Public DocAsoc As New List(Of e_DocumentoAsociado)
    <DataMember()>
    Public MovimientoAnalisis As List(Of e_MovimientoAnalisis)
    <DataMember()>
    Public MovDocCuenta As List(Of e_MovimientoDocumentoCuenta)
    <DataMember()>
    Public oeAsientoModelo As New e_AsientoModelo
    <DataMember()>
    Public IdDocAsoc As String
    <DataMember()> _
    Public Ejercicio As Integer = 0
    <DataMember()> _
    Public IdLiquidacion As String
    <DataMember()>
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public Tipo As String = "" 'para compras FACTURACOMPRA
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
    Public Event DatoCambiado()
    <DataMember()>
    Public lstDetalleDocumento As New List(Of e_DetalleDocumento)
    <DataMember()>
    Public ListaDetalles As New List(Of e_DetalleDocumento_css)

    Private _lstDetalleDocumentoCombustible As New List(Of e_DetalleDocumentoCombustible)
    '--------------Parametros para el listado de facturas----------------------------
    <DataMember()> _
    Public FechaInicio As Date
    <DataMember()> _
    Public FechaFinal As Date
    'Public IndMaterialServicio As String

    '--------------------MAXIMO--------------
    <DataMember()> _
    Public Mac_PC_Local As String

    '---------Facturacion/EENEBA----------------------
    <DataMember()> _
    Public dtDetalleDoc As DataTable
    <DataMember()> _
    Public dtDetalleDocGT As DataTable
    <DataMember()> _
    Public CadIdGuiasTrans As String = ""
    <DataMember()> _
    Public CadIdOperacionDet As String = ""
    Private _diasven As Integer
    <DataMember()> _
    Public leDetalleDocOperDet As New List(Of e_DetalleDoc_OperacionDet)
    <DataMember()> _
    Public leGRT As New List(Of e_GuiaTransportista)
    <DataMember()> _
    Public leGRR As New List(Of e_GuiaRemitente)
    <DataMember()> _
    Public Direccion As String = ""
    <DataMember()> _
    Public Ruc As String = ""
    <DataMember()> _
    Public ImporteDetraer As Double = 0
    <DataMember()> _
    Public NetoPagar As Double = 0
    <DataMember()> _
    Public Observacion As String = ""
    <DataMember()> _
    Public CargarCompleto As Boolean = True
    <DataMember()>
    Public Property IndServicioMaterial As String
    <DataMember()> _
    Public interfazContable As Boolean
    <DataMember()> _
    Public GlosaViajeGrupo As String
    <DataMember()>
    Public PagoAutomatico As e_PagoAutomatico
    <DataMember()>
    Public lo_OrdenDocumento As New List(Of e_Orden_Documento)
    <DataMember()>
    Public CuentaVentaxServicio As String
    <DataMember()> _
    Public Mes As String
    <DataMember()>
    Public NoGravado As Double
    <DataMember()>
    Public DetraccionPorc As Double = 0
    <DataMember()> _
    Public Detraccion As Double = 0
    <DataMember()> _
    Public ImpuestoRenta As Double = 0
    <DataMember()> _
    Public CobraCajaChica As Integer = 0
    <DataMember()> _
    Public IdMotivoDocumento As String = ""
    <DataMember()> _
    Public IndOrigenContable As Integer = 0
    <DataMember()> _
    Public Documentos As String = ""
    <DataMember()> _
    Public IndEmitirDoc As Boolean = False
    <DataMember()> _
    Public IndAsientoGuia As Boolean = False
    <DataMember()> _
    Public IndTipoFactura As String = ""
    <DataMember()> _
    Public IndConsignacion As Boolean = False
    <DataMember()> _
    Public loAsientoModelo As New List(Of e_AsientoModelo)
    <DataMember()> _
    Public loCtaCtbleSFam As New List(Of e_CtaCtbleSubFamiliaMat)
    <DataMember()> _
    Public loCtaCtbleCSer As New List(Of e_CtaCtbleCatServicio)
    <DataMember()> _
    Public leCuotaDocVehMovimiento As New List(Of e_CuotaDocVeh_Movimiento)
    <DataMember()> _
    Public IndConta As Boolean = False
    <DataMember()> _
    Public loCtas As New List(Of e_Combo)
    <DataMember()>
    Public IdCtaPagarCobrar As String = String.Empty
    <DataMember()>
    Public Equivale As Integer = 0

    Public CargaCompleta As Boolean

#End Region

#Region "Propiedades"

    <DataMember()> _
    Public Property lstDetalleDocumentoCombustible() As List(Of e_DetalleDocumentoCombustible)
        Get
            Return _lstDetalleDocumentoCombustible
        End Get
        Set(ByVal value As List(Of e_DetalleDocumentoCombustible))
            _lstDetalleDocumentoCombustible = value
        End Set
    End Property

    Public Property IndAnulado() As Boolean
        Get
            Return _IndAnulado
        End Get
        Set(ByVal value As Boolean)
            _IndAnulado = value
        End Set
    End Property

    <DataMember()> _
    Public Property Abrev_Empresa() As String
        Get
            Return _Abrev_Empresa
        End Get
        Set(ByVal value As String)
            _Abrev_Empresa = value
        End Set
    End Property

    <DataMember()> _
    Public Property Id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdTipoDocumento() As String
        Get
            Return _idtipodocumento
        End Get
        Set(ByVal value As String)
            _idtipodocumento = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property NombreDocumento() As String
        Get
            Return _nombredocumento
        End Get
        Set(ByVal value As String)
            _nombredocumento = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Glosa() As String
        Get
            Return _glosa
        End Get
        Set(ByVal value As String)
            _glosa = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Serie() As String
        Get
            Return _serie
        End Get
        Set(ByVal value As String)
            _serie = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Numero() As String
        Get
            Return _numero
        End Get
        Set(ByVal value As String)
            _numero = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaEmision() As Date
        Get
            Return _fechaemision
        End Get
        Set(ByVal value As Date)
            _fechaemision = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaVencimiento() As Date
        Get
            Return _fechavencimiento
        End Get
        Set(ByVal value As Date)
            _fechavencimiento = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property DiasVen() As Integer
        Get
            If _saldo > 0 Then
                DiasVen = DateDiff(DateInterval.Day, _fechavencimiento, Date.Now)
            Else
                DiasVen = 0
            End If
            Return DiasVen
        End Get
        Set(ByVal value As Integer)
            _diasven = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IGV() As Double
        Get
            Return _igv
        End Get
        Set(ByVal value As Double)
            _igv = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property SubTotal() As Double
        Get
            Return _subtotal
        End Get
        Set(ByVal value As Double)
            _subtotal = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Total() As Double
        Get
            Return _total
        End Get
        Set(ByVal value As Double)
            _total = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Saldo() As Double
        Get
            Return _saldo
        End Get
        Set(ByVal value As Double)
            _saldo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IndDetraccion() As Boolean
        Get
            Return _IndDetraccion
        End Get
        Set(ByVal value As Boolean)
            _IndDetraccion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IndElectronico() As Boolean
        Get
            Return _IndElectronico
        End Get
        Set(ByVal value As Boolean)
            _IndElectronico = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IndAnexo() As Boolean
        Get
            Return _IndAnexo
        End Get
        Set(ByVal value As Boolean)
            _IndAnexo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IndDetalleGlosa() As Boolean
        Get
            Return _IndDetalleGlosa
        End Get
        Set(ByVal value As Boolean)
            _IndDetalleGlosa = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property TipoCambio() As Double
        Get
            Return _TipoCambio
        End Get
        Set(ByVal value As Double)
            _TipoCambio = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property MontoOperar() As Double
        Get
            Return _MontoOperar
        End Get
        Set(ByVal value As Double)
            _MontoOperar = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property MontoCanje() As Double
        Get
            Return _MontoCanje
        End Get
        Set(ByVal value As Double)
            _MontoCanje = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Retencion() As Double
        Get
            Return _Retencion
        End Get
        Set(ByVal value As Double)
            _Retencion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Retencion_Letra() As Double
        Get
            Return _Retencion_Letra
        End Get
        Set(ByVal value As Double)
            _Retencion_Letra = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Retencion_Saldo() As Double
        Get
            Return _Retencion_Saldo
        End Get
        Set(ByVal value As Double)
            _Retencion_Saldo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property NombreProveedor() As String
        Get
            Return _NombreClienteProveedor
        End Get
        Set(ByVal value As String)
            _NombreClienteProveedor = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Item() As Integer
        Get
            Return _Item
        End Get
        Set(ByVal value As Integer)
            _Item = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdClienteProveedor() As String
        Get
            Return _idclienteproveedor
        End Get
        Set(ByVal value As String)
            _idclienteproveedor = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdAsientoMovimiento() As String
        Get
            Return _idasientomovimiento
        End Get
        Set(ByVal value As String)
            _idasientomovimiento = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IndCompraVenta() As Integer
        Get
            Return _IndCompraVentas
        End Get
        Set(ByVal value As Integer)
            _IndCompraVentas = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdPeriodo() As String
        Get
            Return _IdPeriodo
        End Get
        Set(ByVal value As String)
            _IdPeriodo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdUsuarioCrea() As String
        Get
            Return _IdUsuarioCrea
        End Get
        Set(ByVal value As String)
            _IdUsuarioCrea = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaCreacion() As Date
        Get
            Return _FechaCreacion
        End Get
        Set(ByVal value As Date)
            _FechaCreacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdMoneda() As String
        Get
            Return _IdMoneda
        End Get
        Set(ByVal value As String)
            _IdMoneda = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Moneda() As String
        Get
            Return _Moneda
        End Get
        Set(ByVal value As String)
            _Moneda = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property AbreviaturaMoneda() As String
        Get
            Return _abreviaturaMoneda
        End Get
        Set(ByVal value As String)
            _abreviaturaMoneda = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property SaldoDetraccion() As Double
        Get
            Return _SaldoDetraccion
        End Get
        Set(ByVal value As Double)
            _SaldoDetraccion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Neto() As Double
        Get
            Return _Neto
        End Get
        Set(ByVal value As Double)
            _Neto = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdCuentaContable() As String
        Get
            Return _IdCuentaContable
        End Get
        Set(ByVal value As String)
            _IdCuentaContable = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdEstadoDocumento() As String
        Get
            Return _idestadodocumento
        End Get
        Set(ByVal value As String)
            _idestadodocumento = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property EstadoDocumento() As String
        Get
            Return _estadodocumento
        End Get
        Set(ByVal value As String)
            _estadodocumento = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdTipoPago() As String
        Get
            Return Compra.IdTipoPago
        End Get
        Set(ByVal value As String)
            Compra.IdTipoPago = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property TipoPago() As String
        Get
            Return Compra.TipoPago
        End Get
        Set(ByVal value As String)
            Compra.TipoPago = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public PercepcionPorc As Double = 0

    <DataMember()> _
    Public Property Percepcion() As Double
        Get
            Return Compra.Percepcion
        End Get
        Set(ByVal value As Double)
            Compra.Percepcion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdTipoBien() As String
        Get
            Return _IdTipoBien
        End Get
        Set(ByVal value As String)
            _IdTipoBien = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CodMotivo() As String
        Get
            Return _CodMotivo
        End Get
        Set(ByVal value As String)
            _CodMotivo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property OrdenCompra() As String
        Get
            Return _OrdenCompra
        End Get
        Set(ByVal value As String)
            _OrdenCompra = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property EstadoSunat() As String
        Get
            Return _EstadoSunat
        End Get
        Set(ByVal value As String)
            _EstadoSunat = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IndAnticipo() As Boolean
        Get
            Return _IndAnticipo
        End Get
        Set(ByVal value As Boolean)
            _IndAnticipo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IndAfectaAnticipo() As Boolean
        Get
            Return _IndAfectaAnticipo
        End Get
        Set(ByVal value As Boolean)
            _IndAfectaAnticipo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Monto_Anticipo() As Double
        Get
            Return _Monto_Anticipo
        End Get
        Set(ByVal value As Double)
            _Monto_Anticipo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        TipoOperacion = ""
        _id = ""
        Activo = True
        FechaEmision = Date.Parse("01/01/1901")
        FechaVencimiento = Date.Parse("01/01/1901")
        FechaFinal = Date.Parse("01/01/1901")
        FechaInicio = Date.Parse("01/01/1901")
        TipoOperacion = ""
        _Operador = 0
        IndServicioMaterial = ""
        interfazContable = False
        CuentaVentaxServicio = ""
        Mes = ""
        IdLiquidacion = ""
        IdTipoDocumento = ""
        Documentos = ""
        IndAsientoGuia = False
        IndConsignacion = False
        Serie = ""
        Numero = ""
        IndTipoFactura = ""
        IdPeriodo = ""
        IndElectronico = False
        IndAnexo = False
        OrdenCompra = ""
        IdTipoBien = ""
        CodMotivo = ""
        Monto_Anticipo = 0
        IndAfectaAnticipo = False
        IndAnticipo = False
        NombreDocumento = ""
        Abrev_Empresa = ""
        IndAnulado = False
        Item = 0
    End Sub

    Public Sub New(ByVal ls_Id As String, ByVal ls_IdTipoDocumento As String, ByVal ls_NombreDocumento As String _
              , ByVal ls_Serie As String, ByVal ls_Numero As String, ByVal ld_FechaEmision As Date _
              , ByVal ld_FechaVencimiento As Date, ByVal ln_IGV As Double, ByVal ln_SubTotal As Double _
              , ByVal ln_Total As Double, ByVal ln_Saldo As Double, ByVal ls_IdClienteProveedor As String _
              , ByVal ls_NombreClienteProveedor As String, ByVal ls_IdMoneda As String, ByVal ls_abreviaturaMoneda As String _
              , ByVal ls_IdPeriodo As String, ByVal ln_IndCompraVentas As Integer, ByVal ln_TipoCambio As Double _
              , ByVal lb_Activo As Boolean, ByVal ls_IdUsuarioCrea As String, ByVal ld_FechaCreacion As Date _
              , ByVal ls_SaldoDetraccion As Double, ByVal IdCuentaContable As String, ByVal lb_Moneda As String _
              , ByVal lb_IdEstadoDocumento As String, ByVal lb_EstadoDocumento As String, ByVal lb_IdTipoPago As String _
              , ByVal lb_TipoPago As String, ByVal lb_ClienteProveedor As String, ByVal lb_IdCompra As String _
              , ByVal ls_AbrevTipoDoc As String, ByVal lsIndServicioMaterial As String, ByVal lnPercepcionPorc As Double _
              , ByVal lnPercepcion As Double, ByVal lnDetraccionPorc As Double, ByVal lnDetraccion As Double _
              , ByVal ls_Glosa As String, ByVal ln_ImpuestoRen As Double, ByVal lnOperador As Integer, ByVal lsMes As String, ByVal ln_CobraCajaChica As Integer _
              , ByVal ls_IdMotivoDocumento As String, ByVal lb_IndDetraccion As Boolean)
        _id = ls_Id : _idtipodocumento = ls_IdTipoDocumento : _nombredocumento = ls_NombreDocumento
        _serie = ls_Serie : _numero = ls_Numero : _nombredocumento = _serie & " - " & _numero
        _fechaemision = ld_FechaEmision : _fechavencimiento = ld_FechaVencimiento
        _igv = ln_IGV : _subtotal = ln_SubTotal : _total = ln_Total
        _saldo = ln_Saldo : _IdMoneda = ls_IdMoneda : _IndDetraccion = lb_IndDetraccion
        _Moneda = lb_Moneda : _abreviaturaMoneda = ls_abreviaturaMoneda
        _idclienteproveedor = ls_IdClienteProveedor : _NombreClienteProveedor = ls_NombreClienteProveedor
        _IdPeriodo = ls_IdPeriodo : _IndCompraVentas = ln_IndCompraVentas
        _TipoCambio = ln_TipoCambio : _IdUsuarioCrea = ls_IdUsuarioCrea
        _FechaCreacion = ld_FechaCreacion : _activo = lb_Activo
        _SaldoDetraccion = ls_SaldoDetraccion : _Neto = -ls_SaldoDetraccion + ln_Saldo
        _IdCuentaContable = IdCuentaContable : _MontoOperar = ln_Saldo
        _idestadodocumento = lb_IdEstadoDocumento : _estadodocumento = lb_EstadoDocumento
        Compra.IdTipoPago = lb_IdTipoPago : Compra.TipoPago = lb_TipoPago
        DetraccionPorc = lnDetraccionPorc : Detraccion = lnDetraccion
        PercepcionPorc = lnPercepcionPorc : Compra.Percepcion = lnPercepcion
        _NombreClienteProveedor = lb_ClienteProveedor : Compra.Id = lb_IdCompra
        _AbrevTipoDoc = ls_AbrevTipoDoc : IndServicioMaterial = lsIndServicioMaterial
        ImpuestoRenta = ln_ImpuestoRen : _glosa = ls_Glosa : _Operador = lnOperador
        Mes = lsMes : CobraCajaChica = ln_CobraCajaChica : IdMotivoDocumento = ls_IdMotivoDocumento
        _MontoCanje = ln_Saldo : _Retencion = 0.0
    End Sub

#End Region

#Region "Métodos"

    Public Function CalcularImporte() As Double Implements Ie_MovimientoDocumento.CalcularImporte
        Dim Imp As Double = 0.0
        For Each lista As e_DetalleDocumentoCombustible In lstDetalleDocumentoCombustible
            Imp += (lista.PrecioUnit * lista.Cantidad)
        Next
        Return Imp
    End Function

    Public Function CalcularTotal() As Double Implements Ie_MovimientoDocumento.CalcularTotal
        Dim Total As Double = 0.0
        For Each lista As e_DetalleDocumentoCombustible In lstDetalleDocumentoCombustible
            Total += lista.Valor
        Next
        Return Total
    End Function

    Public Function comparar(ByVal other As e_MovimientoDocumento) As Boolean Implements System.IEquatable(Of e_MovimientoDocumento).Equals
        Select Case other.Equivale
            Case 0
                If Me.IdAsientoMovimiento = other.IdAsientoMovimiento And Me.IdTipoDocumento = other.IdTipoDocumento And Me.Serie = other.Serie _
              And Me.Numero = other.Numero And Me.IdClienteProveedor = other.IdClienteProveedor Then
                    Return True
                End If
            Case 1
                If Me.Id = other.Id Then Return True
        End Select
        Return False
    End Function

    Public Function Clonar() As Object Implements System.ICloneable.Clone
        Dim oeMovDoc As New e_MovimientoDocumento
        With oeMovDoc
            .Id = Me.Id
            .IdEmpresaSis = Me.IdEmpresaSis
            .IdSucursal = Me.IdSucursal
            .IdTipoDocumento = Me.IdTipoDocumento
            .Serie = Me.Serie
            .Numero = Me.Numero
            .FechaEmision = Me.FechaEmision
            .FechaVencimiento = Me.FechaVencimiento
            .IGV = Me.IGV
            .SubTotal = Me.SubTotal
            .Total = Me.Total
            .Saldo = Me.Saldo
            .IdClienteProveedor = Me.IdClienteProveedor
            .IdAsientoMovimiento = Me.IdAsientoMovimiento
            .IdCuentaContable = Me.IdCuentaContable
            .Activo = Me.Activo
            .IdPeriodo = Me.IdPeriodo
            .IdMoneda = Me.IdMoneda
            .IndCompraVenta = Me.IndCompraVenta
            .TipoCambio = Me.TipoCambio
            .IdUsuarioCrea = Me.IdUsuarioCrea
            .FechaCreacion = Me.FechaCreacion
            .SaldoDetraccion = Me.SaldoDetraccion
            .MontoOperar = Me.MontoOperar
            .Neto = Me.Neto
            .IdEstadoDocumento = Me.IdEstadoDocumento
            ._Operador = Me._Operador
            ._NombreClienteProveedor = Me._NombreClienteProveedor
            ._nombredocumento = Me.NombreDocumento

            ._Moneda = Me.Moneda
            ._estadodocumento = Me.EstadoDocumento
            .Compra.TipoPago = Me.TipoPago
            ._AbrevTipoDoc = Me._AbrevTipoDoc
            .IdMotivoDocumento = Me.IdMotivoDocumento

            .PercepcionPorc = Me.PercepcionPorc
            .Percepcion = Me.Percepcion
            .MontoCanje = Me.MontoCanje
            .Retencion = Me.Retencion
        End With
        Return oeMovDoc
    End Function

    Public Function Obtener(ByVal movimientoDocumento As e_MovimientoDocumento) As e_MovimientoDocumento Implements Ie_MovimientoDocumento.Obtener
        Return movimientoDocumento
    End Function

#End Region

End Class
