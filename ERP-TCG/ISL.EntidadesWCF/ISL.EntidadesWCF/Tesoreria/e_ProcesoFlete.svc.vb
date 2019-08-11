


<DataContract()> _
Public Class e_ProcesoFlete
    Implements Ie_ProcesoFlete

#Region "Declaración de variables"

    Private _IdOperacion As String
    Private _Operacion As String
    Private _IdViaje As String
    Private _Viaje As String
    Private _Fecha As Date
    Private _Origen As String
    Private _Destino As String
    Private _IdPiloto As String
    Private _Piloto As String
    Private _Tracto As String
    Private _TipoVehiculo As String
    Private _ViajeVacio As Boolean
    Private _IdCliente As String
    Private _Cliente As String
    Private _UnidadCarga As String
    Private _IdMaterial As String
    Private _Material As String
    Private _Usuario As String
    Private _Comisionista As String
    Private _Comision As Decimal
    Private _Moneda As String
    Private _FleteUnitario As Decimal
    Private _Cantidad As Decimal
    Private _Flete As Decimal
    Private _ContraEntrega As String
    Private _PesoToneladasCarga As Decimal
    Private _PesoToneladasDescarga As Decimal
    Private _IndPesoTnDescarga As Boolean
    Private _PesoToneladas As Decimal
    Private _IncluyeIgv As Decimal
    Private _Activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String = ""

    <DataMember()> _
    Public FechaDesde As String
    <DataMember()> _
    Public FechaHasta As String

#End Region

#Region "Propiedades"

    <DataMember()> _
    Public Property IdOperacion() As String
        Get
            Return _IdOperacion
        End Get
        Set(ByVal value As String)
            _IdOperacion = value
        End Set
    End Property
    <DataMember()> _
    Public Property Operacion() As String
        Get
            Return _Operacion
        End Get
        Set(ByVal value As String)
            _Operacion = value
        End Set
    End Property
    <DataMember()> _
    Public Property IdViaje() As String
        Get
            Return _IdViaje
        End Get
        Set(ByVal value As String)
            _IdViaje = value
        End Set
    End Property
    <DataMember()> _
    Public Property Viaje() As String
        Get
            Return _Viaje
        End Get
        Set(ByVal value As String)
            _Viaje = value
        End Set
    End Property
    <DataMember()> _
    Public Property Fecha() As Date
        Get
            Return _Fecha
        End Get
        Set(ByVal value As Date)
            _Fecha = value
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
    Public Property IdPiloto() As String
        Get
            Return _IdPiloto
        End Get
        Set(ByVal value As String)
            _IdPiloto = value
        End Set
    End Property
    <DataMember()> _
    Public Property Piloto() As String
        Get
            Return _Piloto
        End Get
        Set(ByVal value As String)
            _Piloto = value
        End Set
    End Property
    <DataMember()> _
    Public Property Tracto() As String
        Get
            Return _Tracto
        End Get
        Set(ByVal value As String)
            _Tracto = value
        End Set
    End Property
    <DataMember()> _
    Public Property TipoVehiculo() As String
        Get
            Return _TipoVehiculo
        End Get
        Set(ByVal value As String)
            _TipoVehiculo = value
        End Set
    End Property
    <DataMember()> _
    Public Property ViajeVacio() As Boolean
        Get
            Return _ViajeVacio
        End Get
        Set(ByVal value As Boolean)
            _ViajeVacio = value
        End Set
    End Property
    <DataMember()> _
    Public Property IdCliente() As String
        Get
            Return _IdCliente
        End Get
        Set(ByVal value As String)
            _IdCliente = value
        End Set
    End Property
    <DataMember()> _
    Public Property Cliente() As String
        Get
            Return _Cliente
        End Get
        Set(ByVal value As String)
            _Cliente = value
        End Set
    End Property
    <DataMember()> _
    Public Property UnidadCarga() As String
        Get
            Return _UnidadCarga
        End Get
        Set(ByVal value As String)
            _UnidadCarga = value
        End Set
    End Property
    <DataMember()> _
    Public Property IdMaterial() As String
        Get
            Return _IdMaterial
        End Get
        Set(ByVal value As String)
            _IdMaterial = value
        End Set
    End Property
    <DataMember()> _
    Public Property Material() As String
        Get
            Return _Material
        End Get
        Set(ByVal value As String)
            _Material = value
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
    Public Property Comisionista() As String
        Get
            Return _Comisionista
        End Get
        Set(ByVal value As String)
            _Comisionista = value
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
    Public Property Moneda() As String
        Get
            Return _Moneda
        End Get
        Set(ByVal value As String)
            _Moneda = value
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
    Public Property ContraEntrega() As String
        Get
            Return _ContraEntrega
        End Get
        Set(ByVal value As String)
            _ContraEntrega = value
        End Set
    End Property
    <DataMember()> _
    Public Property PesoToneladasCarga() As Decimal
        Get
            Return _PesoToneladasCarga
        End Get
        Set(ByVal value As Decimal)
            _PesoToneladasCarga = value
        End Set
    End Property
    <DataMember()> _
    Public Property PesoToneladasDescarga() As Decimal
        Get
            Return _PesoToneladasDescarga
        End Get
        Set(ByVal value As Decimal)
            _PesoToneladasDescarga = value
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
    Public Property Cantidad() As Decimal
        Get
            Return _Cantidad
        End Get
        Set(ByVal value As Decimal)
            _Cantidad = value
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
    Public Property PesoToneladas() As Decimal
        Get
            Return _PesoToneladas
        End Get
        Set(ByVal value As Decimal)
            _PesoToneladas = value
        End Set
    End Property
    <DataMember()> _
    Public Property IncluyeIgv() As Decimal
        Get
            Return _IncluyeIgv
        End Get
        Set(ByVal value As Decimal)
            _IncluyeIgv = value
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

#End Region

#Region "Constructores"

    Sub New()

    End Sub

    Public Sub New(ByVal ls_IdOperacion As String, ByVal ls_Operacion As String, ByVal ls_IdViaje As String, ByVal ls_viaje As String, _
            ByVal ld_Fecha As Date, ByVal ls_Origen As String, ByVal ls_Destino As String, ByVal ls_IdPiloto As String, ByVal ls_Piloto As String, ByVal ls_Tracto As String, _
            ByVal ls_TipoVehiculo As String, ByVal lb_ViajeVacio As Boolean, ByVal ls_IdCliente As String, ByVal ls_Cliente As String, ByVal ls_UnidadCarga As String, _
            ByVal ls_IdMaterial As String, ByVal ls_Carga As String, _
            ByVal ls_Usuario As String, ByVal ls_Comisionista As String, ByVal ls_Comision As String, ByVal ls_Moneda As String, ByVal ls_FleteUnitario As Decimal, _
            ByVal ls_cantidad As Decimal, _
            ByVal ls_Flete As Decimal, ByVal ls_Contraentrega As Byte, ByVal ls_PesoToneladasCarga As Decimal, ByVal ls_PesoToneladasDescarga As Decimal, _
            ByVal IndPesoTnDescarga As Byte, ByVal ls_PesoToneladas As String, ByVal ls_IncluyeIgv As Decimal, ByVal ls_Activo As Byte)
    End Sub

#End Region

#Region "Métodos"

    Public Function Obtener(ByVal procesoFlete As e_ProcesoFlete) As e_ProcesoFlete Implements Ie_ProcesoFlete.Obtener
        Return procesoFlete
    End Function

#End Region

End Class

