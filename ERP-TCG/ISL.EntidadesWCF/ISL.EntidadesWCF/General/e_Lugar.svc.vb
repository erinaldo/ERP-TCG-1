''' <summary>
''' Clase para definir la entidad: Lugar
''' </summary>
''' <remarks></remarks>
<DataContract()> _
Public Class e_Lugar
    Implements Ie_Lugar
    Implements IPropiedadesBasicas

#Region "Propiedad"

    Private _id As String
    Private _idubigeo As String
    Private _nombre As String
    Private _nombrecorto As String
    Private _abreviatura As String
    Private _activo As Boolean
    Private _codigo As String
    Private _tipoRuta As String
    Private _IdReferencia As String
    Public _usuariocreacion As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public ListaClienteLugar As New List(Of e_ClienteLugar)
    <DataMember()> _
    Public ListaVentanaHoraria As New List(Of e_VentanaHoraria)

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
    Public Property Id() As String Implements IPropiedadesBasicas.Id
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property
    <DataMember()> _
    Public Property IdUbigeo() As String
        Get
            Return _idubigeo
        End Get
        Set(ByVal value As String)
            _idubigeo = value
        End Set
    End Property
    <DataMember()> _
    Public Property Nombre() As String Implements IPropiedadesBasicas.Nombre
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property
    <DataMember()> _
    Public Property NombreCorto() As String
        Get
            Return _nombrecorto
        End Get
        Set(ByVal value As String)
            _nombrecorto = value
        End Set
    End Property
    <DataMember()> _
    Public Property Abreviatura() As String
        Get
            Return _abreviatura
        End Get
        Set(ByVal value As String)
            _abreviatura = value
        End Set
    End Property
    <DataMember()> _
    Public Property Activo() As Boolean Implements IPropiedadesBasicas.Activo
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
        End Set
    End Property
    <DataMember()> _
    Public Property Codigo() As String Implements IPropiedadesBasicas.Codigo
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
        End Set
    End Property
    <DataMember()> _
    Public Property TipoRuta() As String
        Get
            Return _tipoRuta
        End Get
        Set(ByVal value As String)
            _tipoRuta = value
        End Set
    End Property
    <DataMember()>
    Public Property IdReferencia() As String
        Get
            Return _IdReferencia
        End Get
        Set(value As String)
            _IdReferencia = value
        End Set
    End Property
#End Region

#Region "Constructor"
    Sub New()
        Activo = True
        TipoOperacion = ""
        Id = ""
    End Sub

    Public Sub New(ByVal ls_Id As String _
              , ByVal ls_IdUbigeo As String _
              , ByVal ls_Nombre As String _
              , ByVal ls_NombreCorto As String _
              , ByVal ls_Abreviatura As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_Codigo As String _
              , ByVal ls_TipoRuta As String _
              , ByVal ls_usuariocreacion As String _
              , ls_IdReferencia As String)
        _id = ls_Id
        _idubigeo = ls_IdUbigeo
        _nombre = ls_Nombre
        _nombrecorto = ls_NombreCorto
        _abreviatura = ls_Abreviatura
        _activo = lb_Activo
        _codigo = ls_Codigo
        _tipoRuta = ls_TipoRuta
        _usuariocreacion = ls_usuariocreacion
        _IdReferencia = ls_IdReferencia
    End Sub

#End Region

#Region "Métodos"

    Public Function Obtener(ByVal lugar As e_Lugar) As e_Lugar Implements Ie_Lugar.Obtener
        Return lugar
    End Function

#End Region

End Class


