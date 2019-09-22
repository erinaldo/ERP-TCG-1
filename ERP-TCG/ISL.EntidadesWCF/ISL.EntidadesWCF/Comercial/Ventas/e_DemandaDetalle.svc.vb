

''' <summary>
''' Clase Detalle Demanda
''' </summary>
''' <remarks></remarks>
<DataContract()> _
Public Class e_DemandaDetalle
    Implements Ie_DemandaDetalle

#Region "Declaracion de Variables"
    Private _Id As String
    Private _idDemanda As String
    Private _idCliente As String
    Private _nombreCliente As String
    Private _idMaterial As String
    Private _nombreMaterial As String
    Private _idTipoCarga As String
    Private _nombreTipoCarga As String
    Private _idComisionista As String
    Private _idMoneda As String
    Private _Cantidad As Decimal
    Private _IncluyeIgv As Boolean
    Private _Flete As Decimal
    Private _Comision As Decimal
    Private _FleteUnitario As Decimal
    Private _IGV As Decimal
    Private _PagoContraEntrega As Boolean
    Private _Facturado As Boolean
    Private _Activo As Boolean
    Private _Centro As String
    Private _idviaje As String
    Private _idOrigen As String
    Private _idDestino As String
    Private _Cargar As Boolean
    Private _Descarga As Boolean
    Private _idClienteFinal As String
    Private _indicador As String
    Private _idDireccionLugarPartida As String
    Private _idDireccionLugarLlegada As String
    Private _direccionLugarPartida As String
    Private _direccionLugarLlegada As String
    Private _consolidado As String
    Private _motivoConsolidado As String
    Private _direccionDestino As String
    Private _direccionOrigen As String
    Private _costoEstiba As Decimal
    Private _costoEstibaDescarga As Decimal
    Private _subtotal As Decimal
    Private _incluyeIGVConsolidado As Boolean
    Private _nombreClienteFinal As String
    Private _adelantoFlete As Decimal
    Private _Programado As Decimal
    Private _PorProgramar As Decimal
    Private _PagoEfectivoDeposito As String
    Private _GlosaCostoEstiba As String
    Private _Usuario As String
    Private _FalsoFlete As Boolean
    Private _IdContactoCarga As String
    Private _IdContactoDescarga As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()>
    Public Proceso As String
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()> _
    Public oeIncidenciaAutentificadas As New e_IncidenciasAutentificadas

#End Region

#Region "Constructor"

    Sub New()
        Id = ""
        Activo = True
    End Sub

    Sub New(ByVal Id As String, _
            ByVal IdDemanda As String, _
            ByVal IdCliente As String, _
            ByVal IdComisionista As String, _
            ByVal IdUnidadCarga As String, _
            ByVal IdMaterial As String, _
            ByVal IdMoneda As String, _
            ByVal Cantidad As Decimal, _
            ByVal IncluyeIgv As Boolean, _
            ByVal FleteUnitario As Decimal, _
            ByVal Flete As Decimal, _
            ByVal Comision As Decimal, _
            ByVal Facturado As Boolean, _
            ByVal PagoContraEntrega As Boolean, _
            ByVal Activo As Boolean, _
            ByVal IdOrigen As String, _
            ByVal IdDestino As String, _
            ByVal Cargar As Boolean, _
            ByVal Descarga As Boolean, _
            ByVal IdClienteFinal As String
            )
        _Id = Id
        _idDemanda = IdDemanda
        _idCliente = IdCliente
        _idComisionista = IdComisionista
        _idTipoCarga = IdUnidadCarga
        _idMaterial = IdMaterial
        _idMoneda = IdMoneda
        _Cantidad = Cantidad
        _IncluyeIgv = IncluyeIgv
        _FleteUnitario = FleteUnitario
        _Flete = Flete
        _Comision = Comision
        _Facturado = Facturado
        _PagoContraEntrega = PagoContraEntrega
        _Activo = Activo
        _idOrigen = IdOrigen
        _idDestino = IdDestino
        _Cargar = Cargar
        _Descarga = Descarga
        _idClienteFinal = IdClienteFinal
    End Sub

    Sub New(ByVal Id As String, _
            ByVal IdDemanda As String, _
            ByVal IdCliente As String, _
            ByVal Cliente As String, _
            ByVal IdComisionista As String, _
            ByVal IdUnidadCarga As String, _
            ByVal IdMaterial As String, _
            ByVal IdMoneda As String, _
            ByVal Cantidad As Decimal, _
            ByVal IncluyeIgv As Boolean, _
            ByVal FleteUnitario As Decimal, _
            ByVal Flete As Decimal, _
            ByVal Comision As Decimal, _
            ByVal Facturado As Boolean, _
            ByVal PagoContraEntrega As Boolean, _
            ByVal Activo As Boolean, _
            ByVal IdOrigen As String, _
            ByVal IdDestino As String, _
            ByVal Cargar As Boolean, _
            ByVal Descarga As Boolean, _
            ByVal IdClienteFinal As String, _
            ByVal ClienteFinal As String, _
            ByVal consolidado As String, _
            ByVal motivoConsolidado As String, _
            ByVal direcciondestino As String, _
            ByVal direccionOrigen As String, _
            ByVal idDireccionLugarPartida As String, _
            ByVal idDIreccionLugarLlegada As String, _
            ByVal nombreOrigen As String, _
            ByVal nombreDestino As String, _
            ByVal incluyeIGVConsolidado As Boolean, _
            ByVal costoEstiba As Decimal, _
            ByVal subtotal As Decimal
            )
        _Id = Id
        _idDemanda = IdDemanda
        _idCliente = IdCliente
        _idComisionista = IdComisionista
        _idTipoCarga = IdUnidadCarga
        _idMaterial = IdMaterial
        _idMoneda = IdMoneda
        _Cantidad = Cantidad
        _IncluyeIgv = IncluyeIgv
        _FleteUnitario = FleteUnitario
        _Flete = Flete
        _Comision = Comision
        _Facturado = Facturado
        _PagoContraEntrega = PagoContraEntrega
        _Activo = Activo
        _idOrigen = IdOrigen
        _idDestino = IdDestino
        _Cargar = Cargar
        _Descarga = Descarga
        _idClienteFinal = IdClienteFinal
        _nombreCliente = Cliente
        _nombreClienteFinal = ClienteFinal
        _motivoConsolidado = motivoConsolidado
        _consolidado = consolidado
        _indicador = 0
        _direccionDestino = direcciondestino
        _direccionOrigen = direccionOrigen
        _incluyeIGVConsolidado = incluyeIGVConsolidado
        _costoEstiba = costoEstiba
        _subtotal = subtotal
        _idDireccionLugarPartida = idDireccionLugarPartida
        _idDireccionLugarLlegada = idDIreccionLugarLlegada
        direccionOrigen = nombreOrigen
        direcciondestino = nombreDestino
    End Sub

#End Region

#Region "Propiedades"

    <DataMember()> _
    Public Property Id() As String
        Get
            Return _Id
        End Get
        Set(ByVal value As String)
            _Id = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdOrigen() As String
        Get
            Return _idOrigen
        End Get
        Set(ByVal value As String)
            _idOrigen = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdDestino() As String
        Get
            Return _idDestino
        End Get
        Set(ByVal value As String)
            _idDestino = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdViaje() As String
        Get
            Return _idviaje
        End Get
        Set(ByVal value As String)
            _idviaje = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdDemanda() As String
        Get
            Return _idDemanda
        End Get
        Set(ByVal value As String)
            _idDemanda = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdCliente() As String
        Get
            Return _idCliente
        End Get
        Set(ByVal value As String)
            _idCliente = value
        End Set
    End Property

    <DataMember()> _
    Public Property Cliente() As String
        Get
            Return _nombreCliente
        End Get
        Set(ByVal value As String)
            _nombreCliente = value
        End Set
    End Property

    <DataMember()> _
    Public Property Material() As String
        Get
            Return _nombreMaterial
        End Get
        Set(ByVal value As String)
            _nombreMaterial = value
        End Set
    End Property
    <DataMember()> _
    Public Property IdMaterial() As String
        Get
            Return _idMaterial
        End Get
        Set(ByVal value As String)
            _idMaterial = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdTipoCarga() As String
        Get
            Return _idTipoCarga
        End Get
        Set(ByVal value As String)
            _idTipoCarga = value
        End Set
    End Property
    <DataMember()> _
    Public Property TipoCarga() As String
        Get
            Return _nombreTipoCarga
        End Get
        Set(ByVal value As String)
            _nombreTipoCarga = value
        End Set
    End Property

    <DataMember()> _
    Public Property Comisionista() As String
        Get
            Return _idComisionista
        End Get
        Set(ByVal value As String)
            _idComisionista = value
        End Set
    End Property

    <DataMember()> _
    Public Property Moneda() As String
        Get
            Return _idMoneda
        End Get
        Set(ByVal value As String)
            _idMoneda = value
        End Set
    End Property

    <DataMember()> _
    Public Property Cantidad() As Decimal
        Get
            Return _Cantidad
        End Get
        Set(ByVal value As Decimal)
            _Cantidad = value
        End Set
    End Property

    <DataMember()> _
    Public Property IncluyeIgv() As Boolean
        Get
            Return _IncluyeIgv
        End Get
        Set(ByVal value As Boolean)
            _IncluyeIgv = value
        End Set
    End Property

    <DataMember()> _
    Public Property Flete() As Decimal
        Get
            Return _Flete
        End Get
        Set(ByVal value As Decimal)
            _Flete = value
        End Set
    End Property

    <DataMember()> _
    Public Property Comision() As Decimal
        Get
            Return _Comision
        End Get
        Set(ByVal value As Decimal)
            _Comision = value
        End Set
    End Property
    <DataMember()> _
    Public Property FleteUnitario() As Decimal
        Get
            Return _FleteUnitario
        End Get
        Set(ByVal value As Decimal)
            _FleteUnitario = value
        End Set
    End Property

    <DataMember()> _
    Public Property IGV() As Decimal
        Get
            Return _IGV
        End Get
        Set(ByVal value As Decimal)
            _IGV = value
        End Set
    End Property

    <DataMember()> _
    Public Property CostoEstiba() As Decimal
        Get
            Return _costoEstiba
        End Get
        Set(ByVal value As Decimal)
            _costoEstiba = value
        End Set
    End Property
    '_costoEstibaDescarga
    <DataMember()> _
    Public Property CostoEstibaDescarga() As Decimal
        Get
            Return _costoEstibaDescarga
        End Get
        Set(ByVal value As Decimal)
            _costoEstibaDescarga = value
        End Set
    End Property
    <DataMember()> _
    Public Property Subtotal() As Decimal
        Get
            Return _subtotal
        End Get
        Set(ByVal value As Decimal)
            _subtotal = value
        End Set
    End Property

    '<DataMember()> _
    'Public Property FleteCalcularIgv() As Decimal
    '    Get
    '        Return ((_FleteUnitario * _Cantidad) + ((_FleteUnitario * _Cantidad) * _IGV)).ToString("###,##0.00")
    '    End Get
    '    Set(ByVal value As Decimal)
    '        _FleteUnitario = value
    '        _Cantidad = value
    '        _IGV = value
    '    End Set
    'End Property

    Public Function FleteCalcularIgv() As Decimal
        Return ((_FleteUnitario * _Cantidad) + ((_FleteUnitario * _Cantidad) * _IGV)).ToString("###,##0.0000")
    End Function

    '<DataMember()> _
    'Public Property FleteCalcularSinIgv() As Decimal
    '    Get
    '        Return (_FleteUnitario * _Cantidad).ToString("###,##0.00")
    '    End Get
    '    Set(ByVal value As Decimal)
    '        _FleteUnitario = value
    '        _Cantidad = value
    '    End Set
    'End Property

    Public Function FleteCalcularSinIgv() As Decimal
        Return (_FleteUnitario * _Cantidad).ToString("###,##0.0000")
    End Function

    <DataMember()> _
    Public Property PagoContraEntrega() As Boolean
        Get
            Return _PagoContraEntrega
        End Get
        Set(ByVal value As Boolean)
            _PagoContraEntrega = value
        End Set
    End Property

    <DataMember()> _
    Public Property Facturado() As Boolean
        Get
            Return _Facturado
        End Get
        Set(ByVal value As Boolean)
            _Facturado = value
        End Set
    End Property

    <DataMember()> _
    Public Property Activo() As Boolean
        Get
            Return _Activo
        End Get
        Set(ByVal value As Boolean)
            _Activo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Cargar() As Boolean
        Get
            Return _Cargar
        End Get
        Set(ByVal value As Boolean)
            _Cargar = value
        End Set
    End Property

    <DataMember()> _
    Public Property IncluyeIGVConsolidado() As Boolean
        Get
            Return _incluyeIGVConsolidado
        End Get
        Set(ByVal value As Boolean)
            _incluyeIGVConsolidado = value
        End Set
    End Property

    <DataMember()> _
    Public Property Descarga() As Boolean
        Get
            Return _Descarga
        End Get
        Set(ByVal value As Boolean)
            _Descarga = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdClienteFinal() As String
        Get
            Return _idClienteFinal
        End Get
        Set(ByVal value As String)
            _idClienteFinal = value
        End Set
    End Property
    <DataMember()> _
    Public Property ClienteFinal() As String
        Get
            Return _nombreClienteFinal
        End Get
        Set(ByVal value As String)
            _nombreClienteFinal = value
        End Set
    End Property


    <DataMember()> _
    Public Property Indicador() As String
        Get
            Return _indicador
        End Get
        Set(ByVal value As String)
            _indicador = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdDireccionLugarPartida() As String
        Get
            Return _idDireccionLugarPartida
        End Get
        Set(ByVal value As String)
            _idDireccionLugarPartida = value
        End Set
    End Property
    <DataMember()> _
    Public Property DireccionLugarPartida() As String
        Get
            Return _direccionLugarPartida
        End Get
        Set(ByVal value As String)
            _direccionLugarPartida = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdDireccionLugarLlegada() As String
        Get
            Return _idDireccionLugarLlegada
        End Get
        Set(ByVal value As String)
            _idDireccionLugarLlegada = value
        End Set
    End Property
    <DataMember()> _
    Public Property DireccionLugarLlegada() As String
        Get
            Return _direccionLugarLlegada
        End Get
        Set(ByVal value As String)
            _direccionLugarLlegada = value
        End Set
    End Property

    <DataMember()> _
    Public Property Consolidado() As String
        Get
            Return _consolidado
        End Get
        Set(ByVal value As String)
            _consolidado = value
        End Set
    End Property

    <DataMember()> _
    Public Property MotivoConsolidado() As String
        Get
            Return _motivoConsolidado
        End Get
        Set(ByVal value As String)
            _motivoConsolidado = value
        End Set
    End Property

    <DataMember()> _
    Public Property DireccionDestino() As String
        Get
            Return _direccionDestino
        End Get
        Set(ByVal value As String)
            _direccionDestino = value
        End Set
    End Property

    <DataMember()> _
    Public Property DireccionOrigen() As String
        Get
            Return _direccionOrigen
        End Get
        Set(ByVal value As String)
            _direccionOrigen = value
        End Set
    End Property

    <DataMember()> _
    Public Property AdelantoFlete() As Decimal
        Get
            Return _adelantoFlete
        End Get
        Set(ByVal value As Decimal)
            _adelantoFlete = value
        End Set
    End Property

    <DataMember()> _
    Public Property Programado() As Decimal
        Get
            Return _Programado
        End Get
        Set(ByVal value As Decimal)
            _Programado = value
        End Set
    End Property
    <DataMember()> _
    Public Property PorProgramar() As Decimal
        Get
            Return _PorProgramar
        End Get
        Set(ByVal value As Decimal)
            _PorProgramar = value
        End Set
    End Property
    <DataMember()> _
    Public Property PagoEfectivoDeposito() As String
        Get
            Return _PagoEfectivoDeposito
        End Get
        Set(ByVal value As String)
            _PagoEfectivoDeposito = value
        End Set
    End Property

    <DataMember()> _
    Public Property GlosaCostoEstiba() As String
        Get
            Return _GlosaCostoEstiba
        End Get
        Set(ByVal value As String)
            _GlosaCostoEstiba = value
        End Set
    End Property

    <DataMember()> _
    Public Property Usuario() As String
        Get
            Return _Usuario
        End Get
        Set(ByVal value As String)
            _Usuario = value
        End Set
    End Property

    <DataMember()> _
    Public Property FalsoFlete() As Boolean
        Get
            Return _FalsoFlete
        End Get
        Set(ByVal value As Boolean)
            _FalsoFlete = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdContactoCarga() As String
        Get
            Return _IdContactoCarga
        End Get
        Set(ByVal value As String)
            _IdContactoCarga = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdContactoDescarga() As String
        Get
            Return _IdContactoDescarga
        End Get
        Set(ByVal value As String)
            _IdContactoDescarga = value
        End Set
    End Property
#End Region

#Region "Métodos"

    Public Function CalcularFlete(ByVal DemandaDetalle As e_DemandaDetalle) As Double Implements Ie_DemandaDetalle.CalcularFlete
        Return ((DemandaDetalle.Flete * 0.18) * DemandaDetalle.Cantidad).ToString("###,##0.00")
    End Function

    Public Function Obtener(ByVal demandaDetalle As e_DemandaDetalle) As e_DemandaDetalle Implements Ie_DemandaDetalle.Obtener
        Return demandaDetalle
    End Function

#End Region

End Class


