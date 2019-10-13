<DataContract()> _
Public Class e_Zona
    Implements Ie_Zona

#Region "Declaración de variables"

    Private _Seleccion As Boolean
    Private _Id As String

    Private _Activo As Boolean
    Private _idAlmacen As String
    Private _Almacen As String
    Private _nivel As String
    Private _seccion As String
    Private _ubicacion As String
    Private _subzona As String
    Private _zona As String
    Private _iddependencia As String
    Private _usuariocreacion As String
    
    <DataMember()> _
    Public Modificado As Boolean = False
    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
#End Region

#Region "Constructor"
    Sub New()

    End Sub

    Sub New(ByVal Seleccion As Boolean, _
            ByVal Id As String, _
            ByVal Almacen As String, _
            ByVal Activo As Boolean, _
            ByVal idDependencia As String, _
            ByVal Zona As String, _
            ByVal SubZona As String, _
            ByVal Ubicacion As String, _
            ByVal Seccion As String, _
            ByVal Nivel As String, _
            ByVal IdAlmacen As String)
        _Seleccion = Seleccion
        _Id = Id
        _zona = Zona
        _subzona = SubZona
        _ubicacion = Ubicacion
        _seccion = Seccion
        _iddependencia = idDependencia
        _nivel = Nivel
        _Activo = Activo
        _Almacen = Almacen
        _idAlmacen = IdAlmacen
    End Sub

#End Region

#Region "Propiedades"

    <DataMember()> _
    Public Property Seleccion() As Boolean
        Get
            Return _Seleccion
        End Get
        Set(ByVal value As Boolean)
            _Seleccion = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdDependencia() As String
        Get
            Return _iddependencia
        End Get
        Set(ByVal value As String)
            _iddependencia = value
        End Set
    End Property

    <DataMember()> _
    Public Property Zona() As String
        Get
            Return _zona
        End Get
        Set(ByVal value As String)
            _zona = value
        End Set
    End Property

    <DataMember()> _
    Public Property Seccion() As String
        Get
            Return _seccion
        End Get
        Set(ByVal value As String)
            _seccion = value
        End Set
    End Property

    <DataMember()> _
    Public Property Ubicacion() As String
        Get
            Return _ubicacion
        End Get
        Set(ByVal value As String)
            _ubicacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property SubZona() As String
        Get
            Return _subzona
        End Get
        Set(ByVal value As String)
            _subzona = value
        End Set
    End Property

    <DataMember()> _
    Public Property Nivel() As String
        Get
            Return _nivel
        End Get
        Set(ByVal value As String)
            _nivel = value
        End Set
    End Property

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
    Public Property Activo() As Boolean
        Get
            Return _Activo
        End Get
        Set(ByVal value As Boolean)
            _Activo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Almacen() As String
        Get
            Return _Almacen
        End Get
        Set(ByVal value As String)
            _Almacen = value
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
    Public Property UsuarioCreacion() As String
        Get
            Return _usuariocreacion
        End Get
        Set(ByVal value As String)
            _usuariocreacion = value
        End Set
    End Property


#End Region

    Public Function Obtener(ByVal zona As e_Zona) As e_Zona Implements Ie_Zona.Obtener
        Return zona
    End Function

End Class
