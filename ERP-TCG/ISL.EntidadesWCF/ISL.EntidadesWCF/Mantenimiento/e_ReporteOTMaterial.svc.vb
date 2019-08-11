<DataContract()> _
Public Class e_ReporteOTMaterial
    Implements Ie_ReporteOTMaterial

#Region "Declaracion de Variables"

    Private _idtipomantenimiento As String
    Private _tipomantenimiento As String
    Private _mantenimiento As String
    Private _equipo As String
    Private _flota As String
    Private _tipovehiculo As String
    Private _IdMaterial As String
    Private _codigomat As String
    Private _material As String
    Private _cantmaterial As Double
    Private _cantreal As Double
    Private _preciounitario As Double
    Private _importe As Double
    Private _nroot As String
    Private _fechaprogramacion As Date
    Private _fechainiciotrabajo As Date
    Private _fechapedido As Date
    Private _estado As String
    Private _kmot As Double
    
    <DataMember()> _
    Public TipoOperacion As String

    <DataMember()> _
    Public IdTipoMantenimiento As String
    <DataMember()> _
    Public IdMantenimiento As String
    <DataMember()> _
    Public IdEquipo As String
    <DataMember()> _
    Public IdMaterial As String
    <DataMember()> _
    Public FechaInicio As Date
    <DataMember()> _
    Public FechaFin As Date
    <DataMember()> _
    Public IdAlmacen As String
    <DataMember()> _
    Public Tipo As Integer = 0

#End Region

#Region "Propiedades"

    <DataMember()> _
    Public Property IdTipoMant() As String
        Get
            Return _idtipomantenimiento
        End Get
        Set(ByVal value As String)
            _idtipomantenimiento = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoMantenimiento() As String
        Get
            Return _tipomantenimiento
        End Get
        Set(ByVal value As String)
            _tipomantenimiento = value
        End Set
    End Property

    <DataMember()> _
    Public Property Mantenimiento() As String
        Get
            Return _mantenimiento
        End Get
        Set(ByVal value As String)
            _mantenimiento = value
        End Set
    End Property

    <DataMember()> _
    Public Property Equipo() As String
        Get
            Return _equipo
        End Get
        Set(ByVal value As String)
            _equipo = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoVehiculo() As String
        Get
            Return _tipovehiculo
        End Get
        Set(ByVal value As String)
            _tipovehiculo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Flota() As String
        Get
            Return _flota
        End Get
        Set(ByVal value As String)
            _flota = value
        End Set
    End Property

    <DataMember()> _
   Public Property IdMat() As String
        Get
            Return _IdMaterial
        End Get
        Set(ByVal value As String)
            _IdMaterial = value
        End Set
    End Property

    <DataMember()> _
    Public Property CodigoMat() As String
        Get
            Return _codigomat
        End Get
        Set(ByVal value As String)
            _codigomat = value
        End Set
    End Property

    <DataMember()> _
    Public Property Material() As String
        Get
            Return _material
        End Get
        Set(ByVal value As String)
            _material = value
        End Set
    End Property

    <DataMember()> _
    Public Property CantidadMat() As Double
        Get
            Return _cantmaterial
        End Get
        Set(ByVal value As Double)
            _cantmaterial = value
        End Set
    End Property

    <DataMember()> _
    Public Property CantidadReal() As Double
        Get
            Return _cantreal
        End Get
        Set(ByVal value As Double)
            _cantreal = value
        End Set
    End Property

    <DataMember()> _
    Public Property PrecioUnitario() As Double
        Get
            Return _preciounitario
        End Get
        Set(ByVal value As Double)
            _preciounitario = value
        End Set
    End Property

    <DataMember()> _
    Public Property Importe() As Double
        Get
            Return _importe
        End Get
        Set(ByVal value As Double)
            _importe = value
        End Set
    End Property

    <DataMember()> _
    Public Property NroOT() As String
        Get
            Return _nroot
        End Get
        Set(ByVal value As String)
            _nroot = value
        End Set
    End Property

    <DataMember()> _
    Public Property KmOT() As Double
        Get
            Return _kmot
        End Get
        Set(ByVal value As Double)
            _kmot = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaProgramacion() As Date
        Get
            Return _fechaprogramacion
        End Get
        Set(ByVal value As Date)
            _fechaprogramacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaInicioTrabajo() As Date
        Get
            Return _fechainiciotrabajo
        End Get
        Set(ByVal value As Date)
            _fechainiciotrabajo = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaPedido() As Date
        Get
            Return _fechapedido
        End Get
        Set(ByVal value As Date)
            _fechapedido = value
        End Set
    End Property

    <DataMember()> _
    Public Property Estado() As String
        Get
            Return _estado
        End Get
        Set(ByVal value As String)
            _estado = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        TipoOperacion = String.Empty
        IdTipoMantenimiento = String.Empty
        IdMantenimiento = String.Empty
        IdEquipo = String.Empty
        IdMaterial = String.Empty
        TipoVehiculo = String.Empty
    End Sub

    Public Sub New(ByVal ls_IdTipoMantenimiento As String _
                   , ByVal ls_TipoMantenimiento As String _
                   , ByVal ls_Mantenimiento As String _
                   , ByVal ls_Equipo As String _
                   , ByVal ls_TipoVehiculo As String _
                   , ByVal ls_Flota As String _
                   , ByVal ls_IdMaterial As String _
                   , ByVal ls_CodigoMat As String _
                   , ByVal ls_Material As String _
                   , ByVal ln_CantidadMat As Double _
                   , ByVal ln_CantidadReal As Double _
                   , ByVal ln_PrecioUnitario As Double _
                   , ByVal ln_Importe As Double _
                   , ByVal ls_NroOT As String _
                   , ByVal ld_FechaProgramacion As Date _
                   , ByVal ld_FechaInicioTrabajo As Date _
                   , ByVal ld_FechaPedido As Date _
                   , ByVal ls_Estado As String _
                   , ByVal ln_KmOT As Double)
        _idtipomantenimiento = ls_IdTipoMantenimiento
        _tipomantenimiento = ls_TipoMantenimiento
        _mantenimiento = ls_Mantenimiento
        _equipo = ls_Equipo
        _tipovehiculo = ls_TipoVehiculo
        _IdMaterial = ls_IdMaterial
        _flota = ls_Flota
        _codigomat = ls_CodigoMat
        _material = ls_Material
        _cantmaterial = ln_CantidadMat
        _cantreal = ln_CantidadReal
        _preciounitario = ln_PrecioUnitario
        _importe = ln_Importe
        _nroot = ls_NroOT
        _fechaprogramacion = ld_FechaProgramacion
        _fechainiciotrabajo = ld_FechaInicioTrabajo
        _fechapedido = ld_FechaPedido
        _estado = ls_Estado
        _kmot = ln_KmOT
    End Sub

#End Region

#Region "Metodos"

    Public Function Obtener(ByVal reporteotmaterial As e_ReporteOTMaterial) As e_ReporteOTMaterial Implements Ie_ReporteOTMaterial.Obtener
        Return reporteotmaterial
    End Function

#End Region

End Class
