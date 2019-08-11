
<DataContract()> _
Public Class e_Cotizacion_Proveedor
    Implements Ie_Cotizacion_Proveedor

#Region "Propiedad"

    Private _id As String
    Private _idcotizacion As String
    Private _idproveedor As String
    Private _proveedor As String
    Private _codproveedor As String
    Private _email As String
    Private _contacto As String
    Private _activo As Boolean
    Private _usuariocreacion As String
    Private _fechacreacion As Date
    Private _seleccion As Boolean
    Private _indaprobado As Boolean
    
    <DataMember()> _
    Public Tipooperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public lstCotizacionDetalleMat As New List(Of e_CotizacionDetalleMat)
    <DataMember()> _
    Public lstCotizacionDetalleSer As New List(Of e_CotizacionDetalleSer)

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
    Public Property IdCotizacion() As String
        Get
            Return _idcotizacion
        End Get
        Set(ByVal value As String)
            _idcotizacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndAprobado() As Boolean
        Get
            Return _indaprobado
        End Get
        Set(ByVal value As Boolean)
            _indaprobado = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdProveedor() As String
        Get
            Return _idproveedor
        End Get
        Set(ByVal value As String)
            _idproveedor = value
        End Set
    End Property

    <DataMember()> _
    Public Property CodigoProveedor() As String
        Get
            Return _codproveedor
        End Get
        Set(ByVal value As String)
            _codproveedor = value
        End Set
    End Property

    <DataMember()> _
    Public Property Proveedor() As String
        Get
            Return _proveedor
        End Get
        Set(ByVal value As String)
            _proveedor = value
        End Set
    End Property

    <DataMember()> _
    Public Property Email() As String
        Get
            Return _email
        End Get
        Set(ByVal value As String)
            _email = value
        End Set
    End Property

    <DataMember()> _
    Public Property Contacto() As String
        Get
            Return _contacto
        End Get
        Set(ByVal value As String)
            _contacto = value
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

    <DataMember()> _
    Public Property FechaCreacion() As Date
        Get
            Return _fechacreacion
        End Get
        Set(ByVal value As Date)
            _fechacreacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property Seleccion() As Boolean
        Get
            Return _seleccion
        End Get
        Set(ByVal value As Boolean)
            _seleccion = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        Seleccion = False
    End Sub

    Public Sub New(ByVal ls_Seleccion As Boolean _
              , ByVal ls_Id As String _
              , ByVal ls_IdCotizacion As String _
              , ByVal ls_IdProveedor As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_Proveedor As String _
              , ByVal ls_Email As String _
              , ByVal ls_Contacto As String _
              , ByVal ls_CodigoProveedor As String _
              , ByVal lb_IndAprobado As Boolean)
        _seleccion = ls_Seleccion
        _id = ls_Id
        _idcotizacion = ls_IdCotizacion
        _idproveedor = ls_IdProveedor
        _activo = lb_Activo
        _usuariocreacion = ls_UsuarioCreacion
        _fechacreacion = ld_FechaCreacion
        _proveedor = ls_Proveedor
        _contacto = ls_Contacto
        _email = ls_Email
        _codproveedor = ls_CodigoProveedor
        _indaprobado = lb_IndAprobado
    End Sub

#End Region

    Public Function Obtener(ByVal cotizacion_Proveedor As e_Cotizacion_Proveedor) As e_Cotizacion_Proveedor Implements Ie_Cotizacion_Proveedor.Obtener
        Return cotizacion_Proveedor
    End Function

End Class


