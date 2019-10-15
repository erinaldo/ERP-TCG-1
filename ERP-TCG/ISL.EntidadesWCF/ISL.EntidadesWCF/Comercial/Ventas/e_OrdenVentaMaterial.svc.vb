' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_OrdenVentaMaterial" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_OrdenVentaMaterial.svc o e_OrdenVentaMaterial.svc.vb en el Explorador de soluciones e inicie la depuración.
Imports ISL.EntidadesWCF

Public Class e_OrdenVentaMaterial
    Implements Ie_OrdenVentaMaterial

#Region "Declaracion Variables"

    Private _id As String
    Private _empresasis As String
    Private _sucursal As String
    Private _ordencomercial As String
    Private _subalmacen As New e_SubAlmacen
    Private _material As New e_Material
    Private _unidadmedida As New e_UnidadMedida
    Private _glosa As String
    Private _cantidad As Double
    Private _cantidadpendiente As Double
    Private _cantidadatender As Double
    Private _cantidadreal As Double
    Private _costounitario As Double
    Private _costoinventario As Double
    Private _preciounitario As Double
    Private _pdscto As Double
    Private _dscto As Double
    Private _preciototal As Double
    Private _indimpuesto As Boolean
    Private _usuariocrea As String
    Private _fechacrea As Date
    Private _usuariomodifica As String
    Private _fechamodifica As Date
    Private _activo As Boolean

    Private _IndOperacion As Integer
    Private _IdOrigen As String
    Private _IdDestino As String
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
    Public TipoOperacion As String

#End Region

#Region "Propiedad"

    Public Property Id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    Public Property IdEmpresaSis() As String
        Get
            Return _empresasis
        End Get
        Set(ByVal value As String)
            _empresasis = value
        End Set
    End Property

    Public Property IdSucursal() As String
        Get
            Return _sucursal
        End Get
        Set(ByVal value As String)
            _sucursal = value
        End Set
    End Property

    Public Property IdOrdenComercial() As String
        Get
            Return _ordencomercial
        End Get
        Set(ByVal value As String)
            _ordencomercial = value
        End Set
    End Property

    Public Property IdSubAlmacen() As String
        Get
            Return _subalmacen.Id
        End Get
        Set(ByVal value As String)
            _subalmacen.Id = value
        End Set
    End Property

    Public Property IdAlmacen() As String
        Get
            Return _subalmacen.IdAlmacen
        End Get
        Set(ByVal value As String)
            _subalmacen.IdAlmacen = value
        End Set
    End Property

    Public Property IdMaterial() As String
        Get
            Return _material.Id
        End Get
        Set(ByVal value As String)
            _material.Id = value
        End Set
    End Property

    Public Property Codigo() As String
        Get
            Return _material.Codigo
        End Get
        Set(ByVal value As String)
            _material.Codigo = value
        End Set
    End Property

    Public Property Material() As String
        Get
            Return _material.Nombre
        End Get
        Set(ByVal value As String)
            _material.Nombre = value
        End Set
    End Property

    Public Property IdTipoUnidadMedida() As String
        Get
            Return _unidadmedida.IdTipoUnidadMedida
        End Get
        Set(ByVal value As String)
            _unidadmedida.IdTipoUnidadMedida = value
        End Set
    End Property

    Public Property IdUnidadMedida() As String
        Get
            Return _unidadmedida.Id
        End Get
        Set(ByVal value As String)
            _unidadmedida.Id = value
        End Set
    End Property

    Public Property Glosa() As String
        Get
            Return _glosa
        End Get
        Set(ByVal value As String)
            _glosa = value
        End Set
    End Property

    Public Property Cantidad() As Double
        Get
            Return _cantidad
        End Get
        Set(ByVal value As Double)
            _cantidad = value
        End Set
    End Property

    Public Property CantidadPendiente() As Double
        Get
            Return _cantidadpendiente
        End Get
        Set(ByVal value As Double)
            _cantidadpendiente = value
        End Set
    End Property

    Public Property CantidadAtender() As Double
        Get
            Return _cantidadatender
        End Get
        Set(ByVal value As Double)
            _cantidadatender = value
        End Set
    End Property

    Public Property CantidadReal() As Double
        Get
            Return _cantidadreal
        End Get
        Set(ByVal value As Double)
            _cantidadreal = value
        End Set
    End Property

    Public Property CostoUnitario() As Double
        Get
            Return _costounitario
        End Get
        Set(ByVal value As Double)
            _costounitario = value
        End Set
    End Property

    Public Property CostoInventario() As Double
        Get
            Return _costoinventario
        End Get
        Set(ByVal value As Double)
            _costoinventario = value
        End Set
    End Property

    Public Property PrecioUnitario() As Double
        Get
            Return _preciounitario
        End Get
        Set(ByVal value As Double)
            _preciounitario = value
        End Set
    End Property

    Public Property PDscto() As Double
        Get
            Return _pdscto
        End Get
        Set(ByVal value As Double)
            _pdscto = value
        End Set
    End Property

    Public Property Dscto() As Double
        Get
            Return _dscto
        End Get
        Set(ByVal value As Double)
            _dscto = value
        End Set
    End Property

    Public Property PrecioTotal() As Double
        Get
            Return _preciototal
        End Get
        Set(ByVal value As Double)
            _preciototal = value
        End Set
    End Property

    Public Property IndImpuesto() As Boolean
        Get
            Return _indimpuesto
        End Get
        Set(ByVal value As Boolean)
            _indimpuesto = value
        End Set
    End Property

    Public Property UsuarioCrea() As String
        Get
            Return _usuariocrea
        End Get
        Set(ByVal value As String)
            _usuariocrea = value
        End Set
    End Property

    Public Property FechaCrea() As Date
        Get
            Return _fechacrea
        End Get
        Set(ByVal value As Date)
            _fechacrea = value
        End Set
    End Property

    Public Property UsuarioModifica() As String
        Get
            Return _usuariomodifica
        End Get
        Set(ByVal value As String)
            _usuariomodifica = value
        End Set
    End Property

    Public Property FechaModifica() As Date
        Get
            Return _fechamodifica
        End Get
        Set(ByVal value As Date)
            _fechamodifica = value
        End Set
    End Property

    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
        End Set
    End Property

    Public Property IndOperacion() As Integer
        Get
            Return _IndOperacion
        End Get
        Set(ByVal value As Integer)
            _IndOperacion = value
        End Set
    End Property

    Public Property IdOrigen() As String
        Get
            Return _IdOrigen
        End Get
        Set(ByVal value As String)
            _IdOrigen = value
        End Set
    End Property

    Public Property IdDestino() As String
        Get
            Return _IdDestino
        End Get
        Set(ByVal value As String)
            _IdDestino = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        TipoOperacion = ""
        _id = ""
        _cantidad = 0
        _cantidadpendiente = 0
        _cantidadatender = 0
        _cantidadreal = 0
        _costounitario = 0
        _costoinventario = 0
        _preciounitario = 0
        _pdscto = 0
        _dscto = 0
        _preciototal = 0
        _activo = True
    End Sub

    Public Sub New(
              ByVal ls_Id As String _
              , ByVal ls_IdOrdenComercial As String _
              , ByVal ls_IdSubAlmacen As String _
              , ByVal ls_IdAlmacen As String _
              , ByVal ls_IdMaterial As String _
              , ByVal ls_Codigo As String _
              , ByVal ls_Material As String _
              , ByVal ls_IdUnidadMedida As String _
              , ByVal ls_IdTipoUnidadMedida As String _
              , ByVal ls_Glosa As String _
              , ByVal ln_Cantidad As Double _
              , ByVal ln_CantidadPendiente As Double _
              , ByVal ln_CantidadReal As Double _
              , ByVal ln_CostoUnitario As Double _
              , ByVal ln_CostoInventario As Double _
              , ByVal ln_Pdscto As Double _
              , ByVal ln_Dscto As Double _
              , ByVal ln_PrecioTotal As Double _
              , ByVal lb_IndImpuesto As Boolean _
              , ByVal ls_UsuarioCrea As String _
              , ByVal ld_FechaCrea As Date _
              , ByVal ls_UsuarioModifica As String _
              , ByVal ld_FechaModifica As Date _
              , ByVal lb_Activo As Boolean _
              , ByRef lb_IndOperacion As Integer _
              , ByVal lb_IdOrigen As String _
              , ByVal lb_IdDestino As String)
        _id = ls_Id
        _ordencomercial = ls_IdOrdenComercial
        _subalmacen.Id = ls_IdSubAlmacen
        _subalmacen.IdAlmacen = ls_IdAlmacen
        _material.Id = ls_IdMaterial
        _material.Codigo = ls_Codigo
        _material.Nombre = ls_Material
        _unidadmedida.Id = ls_IdUnidadMedida
        _unidadmedida.IdTipoUnidadMedida = ls_IdTipoUnidadMedida
        _glosa = ls_Glosa
        _cantidad = ln_Cantidad
        _cantidadpendiente = ln_CantidadPendiente
        _cantidadreal = ln_CantidadReal
        _costounitario = ln_CostoUnitario
        _costoinventario = ln_CostoInventario
        _pdscto = ln_Pdscto
        _dscto = ln_Dscto
        _preciototal = ln_PrecioTotal
        _preciounitario = _preciototal / _cantidad
        _indimpuesto = lb_IndImpuesto
        _usuariocrea = ls_UsuarioCrea
        _fechacrea = ld_FechaCrea
        _usuariomodifica = ls_UsuarioModifica
        _fechamodifica = ld_FechaModifica
        _activo = lb_Activo
        _IndOperacion = lb_IndOperacion
        _IdOrigen = lb_IdOrigen
        _IdDestino = lb_IdDestino
    End Sub

    Public Sub DoWork() Implements Ie_OrdenVentaMaterial.DoWork
        Throw New NotImplementedException()
    End Sub

#End Region

End Class
