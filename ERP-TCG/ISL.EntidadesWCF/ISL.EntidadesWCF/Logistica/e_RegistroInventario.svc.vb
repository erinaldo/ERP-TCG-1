<DataContract()> _
Public Class e_RegistroInventario
    Implements Ie_RegistroInventario

#Region "Propiedad"

    Private _id As String
    Private _idmovimientoinventario As String
    Private _fecha As Date
    Private _idSubAlmacen As String
    Private _SubAlmacen As String
    Private _idAlmacen As String
    Private _idmaterial As String
    Private _material As String
    Private _idunidadmedida As String
    Private _unidadmedida As String
    Private _idorden As String
    Private _cantidad As Double
    Private _cantidadreal As Double
    Private _valorunitario As Double
    Private _valortotal As Double
    Private _activo As Boolean
    Private _usuariocreacion As String
    Private _valorunitarioreal As Double
    Private _nroMovimiento As String
    Private _nombreAlmacen As String

    Public Property IdEmpresaSis() As String
    Public Property IdSucursal() As String
    Public Property ValorAdm() As Double = 0

    <DataMember()> _
    Public FechaInicio As Date
    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
    'Para Listar Ingresos Salidas
    <DataMember()> _
    Public Anio As String
    <DataMember()> _
    Public MesInicio As String
    <DataMember()> _
    Public MesFin As String
    <DataMember()> _
    Public IdTipoMovimiento As String

    'Para Ubicar Consumo Combustible
    <DataMember()> _
    Public IdRegistroCombustible As String = ""
    <DataMember()> _
    Public lstDetalleAsignacion As New List(Of e_DetalleAsignacion)

    <DataMember()> _
    Public oeRegInvOrden As New e_RegistroInventarioOrden

    Public Event DatoCambiado()

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
    Public Property NroMovimiento() As String
        Get
            Return _nroMovimiento
        End Get
        Set(ByVal value As String)
            _nroMovimiento = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdMovimientoInventario() As String
        Get
            Return _idmovimientoinventario
        End Get
        Set(ByVal value As String)
            _idmovimientoinventario = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdSubAlmacen() As String
        Get
            Return _idSubAlmacen
        End Get
        Set(ByVal value As String)
            _idSubAlmacen = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdAlmacen() As String
        Get
            Return _idAlmacen
        End Get
        Set(ByVal value As String)
            _idAlmacen = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdMaterial() As String
        Get
            Return _idmaterial
        End Get
        Set(ByVal value As String)
            _idmaterial = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property NombreMaterial() As String
        Get
            Return _material
        End Get
        Set(ByVal value As String)
            _material = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdUnidadMedida() As String
        Get
            Return _idunidadmedida
        End Get
        Set(ByVal value As String)
            _idunidadmedida = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Cantidad() As Double
        Get
            Return _cantidad
        End Get
        Set(ByVal value As Double)
            _cantidad = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CantidadReal() As Double
        Get
            Return _cantidadreal
        End Get
        Set(ByVal value As Double)
            _cantidadreal = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    '<DataMember()> _
    'Public Property Documento() As String
    '    Get
    '        Return _documento
    '    End Get
    '    Set(ByVal value As String)
    '        _documento = value
    '    End Set
    'End Property

    '<DataMember()> _
    'Public Property TipoDocumento() As String
    '    Get
    '        Return _tipodocumento
    '    End Get
    '    Set(ByVal value As String)
    '        _tipodocumento = value
    '    End Set
    'End Property

    <DataMember()> _
    Public Property ValorUnitario() As Double
        Get
            Return _valorunitario
        End Get
        Set(ByVal value As Double)
            _valorunitario = value
            RaiseEvent DatoCambiado()
        End Set
    End Property
    <DataMember()> _
    Public Property ValorUnitarioReal() As Double
        Get
            Return _valorunitarioreal
        End Get
        Set(ByVal value As Double)
            _valorunitarioreal = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property ValorTotal() As Double
        Get
            Return _valortotal
        End Get
        Set(ByVal value As Double)
            _valortotal = value
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
    Public Property UsuarioCreacion() As String
        Get
            Return _usuariocreacion
        End Get
        Set(ByVal value As String)
            _usuariocreacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property NombreUnidad() As String
        Get
            Return _unidadmedida
        End Get
        Set(ByVal value As String)
            _unidadmedida = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdOrden() As String
        Get
            Return _idorden
        End Get
        Set(ByVal value As String)
            _idorden = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CodigoSubAlmacen() As String
        Get
            Return _SubAlmacen
        End Get
        Set(ByVal value As String)
            _SubAlmacen = value
        End Set
    End Property

    <DataMember()> _
    Public Property NombreAlmacen() As String
        Get
            Return _nombreAlmacen
        End Get
        Set(ByVal value As String)
            _nombreAlmacen = value
        End Set
    End Property

    Private _NombreUsuario As String
    <DataMember()> _
    Public Property NombreUsuario() As String
        Get
            Return _NombreUsuario
        End Get
        Set(ByVal value As String)
            _NombreUsuario = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        Activo = True
        Modificado = False
        TipoOperacion = ""
        IdRegistroCombustible = ""
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_NroMovimiento As String _
              , ByVal ls_IdMovimientoInventario As String _
              , ByVal ld_Fecha As Date _
              , ByVal ls_IdSubAlmacen As String _
              , ByVal ls_IdMaterial As String _
              , ByVal ls_IdUnidadMedida As String _
              , ByVal ln_Cantidad As Double _
              , ByVal ln_CantidadReal As Double _
              , ByVal ValorUnitario As Double _
              , ByVal ValorUnitarioReal As Double _
              , ByVal ValorTotal As Double _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ls_IdOrden As String)
        _id = ls_Id
        _nroMovimiento = ls_NroMovimiento
        _idmovimientoinventario = ls_IdMovimientoInventario
        _fecha = ld_Fecha
        _idSubAlmacen = ls_IdSubAlmacen
        _idmaterial = ls_IdMaterial
        _idunidadmedida = ls_IdUnidadMedida
        _cantidad = ln_Cantidad
        _cantidadreal = ln_CantidadReal
        _valorunitario = ValorUnitario
        _valortotal = ValorTotal
        _activo = lb_Activo
        _usuariocreacion = ls_UsuarioCreacion
        _valorunitarioreal = ValorUnitarioReal
        _idorden = ls_IdOrden
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal NroMovimientoI As String _
              , ByVal ls_IdMovimientoInventario As String _
              , ByVal ls_IdMaterial As String _
              , ByVal NombreMaterial As String _
              , ByVal ln_Cantidad As Double _
              , ByVal ln_CantidadReal As Double _
              , ByVal ls_IdUnidadMedida As String _
              , ByVal NombreUnidadMedida As String _
              , ByVal ld_Fecha As Date _
              , ByVal ls_IdSubAlmacen As String _
              , ByVal CodigoSubAlmacen As String _
              , ByVal IdAlmacen As String _
              , ByVal NomAlmacen As String _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ls_NombUsuario As String _
              , ByVal ln_ValorUnitario As Double _
           )
        _id = ls_Id
        _nroMovimiento = NroMovimientoI
        _idmovimientoinventario = ls_IdMovimientoInventario
        _idmaterial = ls_IdMaterial
        _material = NombreMaterial
        _cantidad = ln_Cantidad
        _cantidadreal = ln_CantidadReal
        _idunidadmedida = ls_IdUnidadMedida
        _unidadmedida = NombreUnidadMedida
        _fecha = ld_Fecha
        _idSubAlmacen = ls_IdSubAlmacen
        _SubAlmacen = CodigoSubAlmacen
        _idAlmacen = IdAlmacen
        NombreAlmacen = NomAlmacen
        _usuariocreacion = ls_UsuarioCreacion
        _NombreUsuario = ls_NombUsuario
        _valorunitario = ln_ValorUnitario
        _valortotal = _valorunitario * _cantidadreal
    End Sub

#End Region

    Public Function Obtener(ByVal registroInventario As e_RegistroInventario) As e_RegistroInventario Implements Ie_RegistroInventario.Obtener
        Return registroInventario
    End Function

End Class
