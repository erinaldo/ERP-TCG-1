<DataContract()> _
Public Class e_Equipo
    Implements Ie_Equipo

#Region "Propiedad"

    Private _id As String
    Private _codigo As String
    Private _nombre As String
    Private _idtipoequipo As String
    Private _tipoequipo As String
    Private _idmarca As String
    Private _marca As String
    Private _idmodelo As String
    Private _modelo As String
    Private _vehiculo As String
    Private _activo As Boolean
    Private _usuariocreacion As String
    Private _descripcion As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
    Public Event DatoCambiado()

#End Region

#Region "Constructores"

    Public Sub New()
        _id = ""
        _codigo = ""
        _nombre = ""
        _idtipoequipo = ""
        _tipoequipo = ""
        _idmarca = ""
        _marca = ""
        _idmodelo = ""
        _modelo = ""
        _vehiculo = ""
        _activo = True
        _descripcion = ""
        TipoOperacion = ""
    End Sub

    Public Sub New(ByVal ls_Id As String _
              , ByVal ls_Codigo As String _
              , ByVal ls_Nombre As String _
              , ByVal ls_IdTipoEquipo As String _
              , ByVal ls_TipoEquipo As String _
              , ByVal ls_IdMarca As String _
              , ByVal ls_Marca As String _
              , ByVal ls_IdModelo As String _
              , ByVal ls_Modelo As String _
              , ByVal ls_IdVehiculo As String _
              , ByVal ls_Descripcion As String _
              , ByVal ls_Activo As Boolean _
              )

        _id = ls_Id
        _codigo = ls_Codigo
        _nombre = ls_Nombre
        _idtipoequipo = ls_IdTipoEquipo
        _tipoequipo = ls_TipoEquipo
        _idmarca = ls_IdMarca
        _marca = ls_Marca
        _idmodelo = ls_IdModelo
        _modelo = ls_Modelo
        _vehiculo = ls_IdVehiculo
        _activo = ls_Activo
        _descripcion = ls_Descripcion
    End Sub

#End Region

#Region "Propiedad"

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
    Public Property IdTipoEquipo() As String
        Get
            Return _idtipoequipo
        End Get
        Set(ByVal value As String)
            _idtipoequipo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property TipoEquipo() As String
        Get
            Return _tipoequipo
        End Get
        Set(ByVal value As String)
            _tipoequipo = value
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
    Public Property IdMarca() As String
        Get
            Return _idmarca
        End Get
        Set(ByVal value As String)
            _idmarca = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Marca() As String
        Get
            Return _marca
        End Get
        Set(ByVal value As String)
            _marca = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdModelo() As String
        Get
            Return _idmodelo
        End Get
        Set(ByVal value As String)
            _idmodelo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Modelo() As String
        Get
            Return _modelo
        End Get
        Set(ByVal value As String)
            _modelo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdVehiculo() As String
        Get
            Return _vehiculo
        End Get
        Set(ByVal value As String)
            _vehiculo = value
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
    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
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
        End Set
    End Property

#End Region

    Public Function Obtener(ByVal equipo As e_Equipo) As e_Equipo Implements Ie_Equipo.Obtener
        Return equipo
    End Function

End Class
