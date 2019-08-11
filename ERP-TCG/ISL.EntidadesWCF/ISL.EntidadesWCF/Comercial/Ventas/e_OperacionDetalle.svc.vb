<DataContract()> _
Public Class e_OperacionDetalle
    Implements Ie_OperacionDetalle

#Region "Propiedad"

    Private _seleccion As Boolean
    Private _id As String
    Private _idOperacion As String
    Private _iddemanda As String
    Private _iddemandaDetalle As String
    Private _idcliente As String
    Private _idcomisionista As String
    Private _idTipoCarga As String
    Private _idmaterial As String
    Private _idmoneda As String
    Private _cantidad As Decimal
    Private _IncluyeIgv As Boolean
    Private _flete As Double
    Private _fleteunitario As Double
    Private _comision As Double
    Private _consolidado As Double
    Private _facturado As Boolean
    Private _pagocontraentrega As Boolean
    Private _activo As Boolean
    'Private _IGV As Double
    Private _Origen As String
    Private _Destino As String
    Private _pesotoneladas As Decimal
    Private _glosa As String
    Private _pesotoneladascarga As Decimal
    Private _pesotoneladasdescarga As Decimal
    Private _Cargar As Boolean
    Private _Descarga As Boolean
    Private _IndPesoTnDescarga As Boolean
    Private _Saldo As Decimal
    'Private _SaldoCarga As Decimal
    Private _FechaCrea As Date
    Private _FechaModifica As Date

    Private _idclientefinal As String

    Private _CostoEstiba As Decimal
    Private _CostoEstibaDescarga As Decimal
    Private _Subtotal As Decimal    
    Private _AdelantoFlete As Decimal
    Private _IncluyeIgvConsolidado As Boolean
    Private _PagoEfectivoDeposito As String
    Private _MotivoConsolidado As String
    Private _FalsoFlete As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public UsuarioCreacion As String
    <DataMember()> _
    Public Ind As String

    <DataMember()> _
    Public FechaDesde As String
    <DataMember()> _
    Public FechaHasta As String
    <DataMember()> _
    Public Proveedor As String
    <DataMember()> _
    Public IGV As Double
    <DataMember()> _
    Public SaldoCarga As Decimal
    <DataMember()> _
    Public oeIncidenciaAutentificadas As New e_IncidenciasAutentificadas


    <DataMember()> _
    Public Property Seleccion() As Boolean
        Get
            Return _seleccion
        End Get
        Set(ByVal value As Boolean)
            _seleccion = value
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
    Public Property Origen() As String
        Get
            Return _Origen
        End Get
        Set(ByVal value As String)
            _Origen = value
        End Set
    End Property
    'cambios
    <DataMember()> _
    Public Property Subtotal() As Decimal
        Get
            Return _Subtotal
        End Get
        Set(ByVal value As Decimal)
            _Subtotal = value
        End Set
    End Property
    <DataMember()> _
    Public Property CostoEstiba() As String
        Get
            Return _CostoEstiba
        End Get
        Set(ByVal value As String)
            _CostoEstiba = value
        End Set
    End Property
    <DataMember()> _
    Public Property CostoEstibaDescarga() As String
        Get
            Return _CostoEstibaDescarga
        End Get
        Set(ByVal value As String)
            _CostoEstibaDescarga = value
        End Set
    End Property
    <DataMember()> _
    Public Property AdelantoFlete() As Decimal
        Get
            Return _AdelantoFlete
        End Get
        Set(ByVal value As Decimal)
            _AdelantoFlete = value
        End Set
    End Property
    <DataMember()> _
    Public Property IncluyeIgvConsolidado() As Boolean
        Get
            Return _IncluyeIgvConsolidado
        End Get
        Set(ByVal value As Boolean)
            _IncluyeIgvConsolidado = value
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
    '<DataMember()> _
    'Public Property SaldoCarga() As Decimal
    '    Get
    '        Return _SaldoCarga
    '    End Get
    '    Set(ByVal value As Decimal)
    '        _SaldoCarga = value
    '    End Set
    'End Property

    <DataMember()> _
    Public Property Destino() As String
        Get
            Return _Destino
        End Get
        Set(ByVal value As String)
            _Destino = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdOperacion() As String
        Get
            Return _idOperacion
        End Get
        Set(ByVal value As String)
            _idOperacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdDemanda() As String
        Get
            Return _iddemanda
        End Get
        Set(ByVal value As String)
            _iddemanda = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdDemandaDetalle() As String
        Get
            Return _iddemandaDetalle
        End Get
        Set(ByVal value As String)
            _iddemandaDetalle = value
        End Set
    End Property

    <DataMember()> _
    Public Property Cliente() As String
        Get
            Return _idcliente
        End Get
        Set(ByVal value As String)
            _idcliente = value
        End Set
    End Property

    <DataMember()> _
    Public Property Comisionista() As String
        Get
            Return _idcomisionista
        End Get
        Set(ByVal value As String)
            _idcomisionista = value
        End Set
    End Property

    <DataMember()> _
    Public Property Carga() As String
        Get
            Return _idTipoCarga
        End Get
        Set(ByVal value As String)
            _idTipoCarga = value
        End Set
    End Property

    <DataMember()> _
    Public Property Material() As String
        Get
            Return _idmaterial
        End Get
        Set(ByVal value As String)
            _idmaterial = value
        End Set
    End Property

    <DataMember()> _
    Public Property Moneda() As String
        Get
            Return _idmoneda
        End Get
        Set(ByVal value As String)
            _idmoneda = value
        End Set
    End Property

    <DataMember()> _
    Public Property Cantidad() As Decimal
        Get
            Return _cantidad
        End Get
        Set(ByVal value As Decimal)
            _cantidad = value
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
    Public Property FleteUnitario() As Double
        Get
            Return _fleteunitario
        End Get
        Set(ByVal value As Double)
            _fleteunitario = value
        End Set
    End Property

    <DataMember()> _
    Public Property Flete() As Double
        Get
            Return _flete
        End Get
        Set(ByVal value As Double)
            _flete = value
        End Set
    End Property

    <DataMember()> _
    Public Property Comision() As Double
        Get
            Return _comision
        End Get
        Set(ByVal value As Double)
            _comision = value
        End Set
    End Property

    <DataMember()> _
    Public Property Consolidado() As Double
        Get
            Return _consolidado
        End Get
        Set(ByVal value As Double)
            _consolidado = value
        End Set
    End Property

    <DataMember()> _
    Public Property Facturado() As Boolean
        Get
            Return _facturado
        End Get
        Set(ByVal value As Boolean)
            _facturado = value
        End Set
    End Property

    <DataMember()> _
    Public Property PagoContraEntrega() As Boolean
        Get
            Return _pagocontraentrega
        End Get
        Set(ByVal value As Boolean)
            _pagocontraentrega = value
        End Set
    End Property

    <DataMember()> _
    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
        End Set
    End Property

    '<DataMember()> _
    'Public Property IGV() As Double
    '    Get
    '        Return _IGV
    '    End Get
    '    Set(ByVal value As Double)
    '        _IGV = value
    '    End Set
    'End Property

    <DataMember()> _
    Public Property PesoToneladas() As Decimal
        Get
            Return _pesotoneladas
        End Get
        Set(ByVal value As Decimal)
            _pesotoneladas = value
        End Set
    End Property

    <DataMember()> _
    Public Property Glosa() As String
        Get
            Return _glosa
        End Get
        Set(ByVal value As String)
            _glosa = value
        End Set
    End Property

    '<DataMember()> _
    'Public Property FleteCalcular() As Double
    '    Get
    '        Return (_fleteunitario + ((_fleteunitario * _IGV) * _cantidad)).ToString("###,##0.00")
    '    End Get
    '    Set(ByVal value As Double)
    '        _fleteunitario = value
    '        _cantidad = value
    '        _IGV = value
    '    End Set
    'End Property

    <DataMember()> _
    Public Property PesoToneladasCarga() As Decimal
        Get
            Return _pesotoneladascarga
        End Get
        Set(ByVal value As Decimal)
            _pesotoneladascarga = value
        End Set
    End Property

    <DataMember()> _
    Public Property PesoToneladasDescarga() As Decimal
        Get
            Return _pesotoneladasdescarga
        End Get
        Set(ByVal value As Decimal)
            _pesotoneladasdescarga = value
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
    Public Property Descarga() As Boolean
        Get
            Return _Descarga
        End Get
        Set(ByVal value As Boolean)
            _Descarga = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndPesoTnDescarga() As Boolean
        Get
            Return _IndPesoTnDescarga
        End Get
        Set(ByVal value As Boolean)
            _IndPesoTnDescarga = value
        End Set
    End Property

    <DataMember()> _
    Public Property Saldo() As Double
        Get
            Return _Saldo
        End Get
        Set(ByVal value As Double)
            _Saldo = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaCrea As Date
        Get
            Return _FechaCrea
        End Get
        Set(value As Date)
            _FechaCrea = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaModifica As Date
        Get
            Return _FechaModifica
        End Get
        Set(value As Date)
            _FechaModifica = value
        End Set
    End Property

    <DataMember()> _
    Public Property ClienteFinal() As String
        Get
            Return _idclientefinal
        End Get
        Set(ByVal value As String)
            _idclientefinal = value
        End Set
    End Property

    <DataMember()> _
    Public Property MotivoConsolidado() As String
        Get
            Return _MotivoConsolidado
        End Get
        Set(ByVal value As String)
            _MotivoConsolidado = value
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
#End Region

#Region "Constructor"

    Public Sub New()
        Id = ""
        IdOperacion = ""
        IdDemanda = ""
        IdDemandaDetalle = ""
        Activo = True
        Glosa = ""
        Seleccion = True
        Cliente = ""
        Comisionista = ""
        Proveedor = ""
        FechaDesde = ""
        FechaHasta = ""
        Consolidado = 0
        Cantidad = 0
        FleteUnitario = 0
        Flete = 0
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdOperacion As String _
              , ByVal ls_IdDemanda As String _
              , ByVal ls_IdDemandaDetalle As String _
              , ByVal ls_IdCliente As String _
              , ByVal ls_IdComisionista As String _
              , ByVal ls_IdUnidadCarga As String _
              , ByVal ls_IdMaterial As String _
              , ByVal ls_IdMoneda As String _
              , ByVal ln_Cantidad As Decimal _
              , ByVal IncluyeIgv As Boolean _
              , ByVal ln_FleteUnitario As Double _
              , ByVal ln_Flete As Double _
              , ByVal ln_Comision As Double _
              , ByVal ln_Consolidado As Double _
              , ByVal lb_Facturado As Boolean _
              , ByVal lb_PagoContraEntrega As Boolean _
              , ByVal lb_Activo As Boolean, _
              ByVal IdOrigen As String, _
              ByVal IdDestino As String _
              , ByVal ln_PesoToneladas As Decimal _
              , ByVal ln_Glosa As String _
              , ByVal ln_PesoToneladasCarga As Decimal _
              , ByVal ln_PesoToneladasDescarga As Decimal, _
            ByVal Cargar As Boolean, _
            ByVal Descarga As Boolean, _
            ByVal IndPesoTnDescarga As Boolean, _
            ByVal ld_Saldo As Decimal, _
            ByVal ls_FechaCrea As Date, _
            ByVal ls_FechaModifica As Date, _
            ByVal ls_IdClienteFinal As String)
        _id = ls_Id
        _idOperacion = ls_IdOperacion
        _iddemanda = ls_IdDemanda
        _iddemandaDetalle = ls_IdDemandaDetalle
        _idcliente = ls_IdCliente
        _idcomisionista = ls_IdComisionista
        _idTipoCarga = ls_IdUnidadCarga
        _idmaterial = ls_IdMaterial
        _idmoneda = ls_IdMoneda
        _cantidad = ln_Cantidad
        _IncluyeIgv = IncluyeIgv
        _fleteunitario = ln_FleteUnitario
        _flete = ln_Flete
        _comision = ln_Comision
        _consolidado = ln_Consolidado
        _facturado = lb_Facturado
        _pagocontraentrega = lb_PagoContraEntrega
        _activo = lb_Activo
        _Origen = IdOrigen
        _Destino = IdDestino
        _pesotoneladas = ln_PesoToneladas
        _glosa = ln_Glosa
        _pesotoneladascarga = ln_PesoToneladasCarga
        _pesotoneladasdescarga = ln_PesoToneladasDescarga
        _Cargar = Cargar
        _Descarga = Descarga
        _IndPesoTnDescarga = IndPesoTnDescarga
        _Saldo = ld_Saldo
        _FechaCrea = ls_FechaCrea
        _FechaModifica = ls_FechaModifica
        _idclientefinal = ls_IdClienteFinal
    End Sub
#End Region

    Public Function Obtener(ByVal operacionDetalle As e_OperacionDetalle) As e_OperacionDetalle Implements Ie_OperacionDetalle.Obtener
        Return operacionDetalle
    End Function

End Class


