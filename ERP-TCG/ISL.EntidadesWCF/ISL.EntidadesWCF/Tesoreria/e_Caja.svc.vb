


<DataContract()> _
Public Class e_Caja
    Implements Ie_Caja

#Region "Propiedad"

    Private _id As String
    Private _codigo As String
    Private _nombre As String
    Private _abreviatura As String
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _Usuarios As String
    Private _activo As Boolean
    Private _indprincipal As Boolean

    <DataMember()> _
    Public Tipooperacion As String
    <DataMember()> _
    Public Modificado As Boolean = False
    Private _idcentro As String
    Private _centro As String
    <DataMember()> _
    Public leCajaUsuario As New List(Of e_CajaUsuario)
    <DataMember()>
    Public PrefijoID As String = ""
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
    Public Property Codigo() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Abreviatura() As String
        Get
            Return _abreviatura
        End Get
        Set(ByVal value As String)
            _abreviatura = value
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
    Public Property IndPrincipal() As Boolean
        Get
            Return _indprincipal
        End Get
        Set(ByVal value As Boolean)
            _indprincipal = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdCentro() As String
        Get
            Return _idcentro
        End Get
        Set(ByVal value As String)
            _idcentro = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Centro() As String
        Get
            Return _centro
        End Get
        Set(ByVal value As String)
            _centro = value
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
    Public Property Usuarios() As String
        Get
            Return _Usuarios
        End Get
        Set(ByVal value As String)
            _Usuarios = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

#End Region

#Region "Constructor"
    Public Sub New()
        _id = String.Empty
        _codigo = String.Empty
        _nombre = String.Empty
        _abreviatura = String.Empty
        _idcentro = String.Empty
        _centro = String.Empty
        _activo = True
        IndPrincipal = 0
    End Sub

    Public Sub New(ByVal ls_Id As String _
              , ByVal ls_Codigo As String _
              , ByVal ls_Nombre As String _
              , ByVal ls_Abreviatura As String _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_IdCentro As String _
              , ByVal ls_Centro As String _
              , ByVal lb_IndPrincipal As Boolean)

        _id = ls_Id
        _codigo = ls_Codigo
        _nombre = ls_Nombre
        _abreviatura = ls_Abreviatura
        _usuariocreacion = ls_UsuarioCreacion
        _activo = lb_Activo
        _idcentro = ls_IdCentro
        _centro = ls_Centro
        _indprincipal = lb_IndPrincipal
    End Sub

#End Region

    Public Function Obtener(ByVal caja As e_Caja) As e_Caja Implements Ie_Caja.Obtener
        Return caja
    End Function

End Class

