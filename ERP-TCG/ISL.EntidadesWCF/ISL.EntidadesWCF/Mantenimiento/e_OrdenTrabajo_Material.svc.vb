<DataContract()> _
Public Class e_OrdenTrabajo_Material
    Implements Ie_OrdenTrabajo_Material

#Region "Propiedad"

    Private _id As String
    Private _idmaterial As String
    Private _material As String
    Private _ordentrabajo As String
    Private _mantenimientoequipo As String
    Private _mantenimiento As String
    Private _equipo As String
    Private _unidadmedida As String
    Private _subalmacen As String
    Private _idalmacen As String
    Private _cantidadmaterial As Double
    Private _cantidadmaterialentregada As Double
    Private _cantidadmaterialdevuelto As Double
    Private _costo As Double
    Private _usuariocreacion As String
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public IdEquipo As String
    <DataMember()> _
    Public IdMantenimiento As String
    <DataMember()> _
    Public CantAux As String
    <DataMember()> _
    Public oeReqMaterial As New e_RequerimientoMaterial

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
    Public Property IdMaterial() As String
        Get
            Return _idmaterial
        End Get
        Set(ByVal value As String)
            _idmaterial = value
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
    Public Property IdOrdenTrabajo() As String
        Get
            Return _ordentrabajo
        End Get
        Set(ByVal value As String)
            _ordentrabajo = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdMantenimientoEquipo() As String
        Get
            Return _mantenimientoequipo
        End Get
        Set(ByVal value As String)
            _mantenimientoequipo = value
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
    Public Property IdUnidadMedida() As String
        Get
            Return _unidadmedida
        End Get
        Set(ByVal value As String)
            _unidadmedida = value
        End Set
    End Property

    <DataMember()> _
    Public Property CantidadMaterial() As Double
        Get
            Return _cantidadmaterial
        End Get
        Set(ByVal value As Double)
            _cantidadmaterial = value
        End Set
    End Property

    <DataMember()> _
    Public Property CantidadMaterialEntregada() As Double
        Get
            Return _cantidadmaterialentregada
        End Get
        Set(ByVal value As Double)
            _cantidadmaterialentregada = value
        End Set
    End Property

    <DataMember()> _
    Public Property CantidadMaterialDevuelto() As Double
        Get
            Return _cantidadmaterialdevuelto
        End Get
        Set(ByVal value As Double)
            _cantidadmaterialdevuelto = value
        End Set
    End Property

    <DataMember()> _
    Public Property Costo() As Double
        Get
            Return _costo
        End Get
        Set(ByVal value As Double)
            _costo = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdSubAlmacen() As String
        Get
            Return _subalmacen
        End Get
        Set(ByVal value As String)
            _subalmacen = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdAlmacen() As String
        Get
            Return _idalmacen
        End Get
        Set(ByVal value As String)
            _idalmacen = value
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
    <DataMember()> _
    Public Property UsuarioCreacion() As String
        Get
            Return _usuariocreacion
        End Get
        Set(ByVal value As String)
            _usuariocreacion = value
        End Set
    End Property

#End Region

#Region "Constructor"
    Sub New()
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdMaterial As String _
              , ByVal ls_IdOrdenTrabajo As String _
              , ByVal ls_IdMantenimientoEquipo As String _
              , ByVal ls_Mantenimiento As String _
              , ByVal ls_Equipo As String _
              , ByVal ls_IdUnidadMedida As String _
              , ByVal ln_CantidadMaterial As Double _
              , ByVal ln_CantidadMaterialEntregada As Double _
              , ByVal ln_CantidadMaterialDevuelto As Double _
              , ByVal ls_IdSubAlmacen As String _
              , ByVal ls_IdAlmacen As String _
              , ByVal lb_Activo As Boolean _
              )
        _id = ls_Id
        _idmaterial = ls_IdMaterial
        _ordentrabajo = ls_IdOrdenTrabajo
        _mantenimientoequipo = ls_IdMantenimientoEquipo
        _mantenimiento = ls_Mantenimiento
        _equipo = ls_Equipo
        _unidadmedida = ls_IdUnidadMedida
        _cantidadmaterial = ln_CantidadMaterial
        _cantidadmaterialentregada = ln_CantidadMaterialEntregada
        _cantidadmaterialdevuelto = ln_CantidadMaterialDevuelto
        _subalmacen = ls_IdSubAlmacen
        _idalmacen = ls_IdAlmacen
        _activo = lb_Activo
    End Sub

#End Region

    Public Function Obtener(ByVal ordenTrabajo_Material As e_OrdenTrabajo_Material) As e_OrdenTrabajo_Material Implements Ie_OrdenTrabajo_Material.Obtener
        Return ordenTrabajo_Material
    End Function

End Class
