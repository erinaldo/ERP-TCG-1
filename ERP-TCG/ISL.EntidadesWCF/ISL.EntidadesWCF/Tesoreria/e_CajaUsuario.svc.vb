

<DataContract()> _
Public Class e_CajaUsuario
    Implements Ie_CajaUsuario
    Implements IEquatable(Of e_CajaUsuario)

#Region "Propiedad"
    Private _id As String
    Private _idcaja As String
    Private _idtrabajador As String
    Private _nomtrabajador As String
    Private _apepattrabajador As String
    Private _apemattrabajador As String
    Private _codtrabajador As String
    Private _usuariocreacion As String
    Private _activo As Boolean
    Private _idcentro As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean = False

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
    Public Property IdCaja() As String
        Get
            Return _idcaja
        End Get
        Set(ByVal value As String)
            _idcaja = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdTrabajador() As String
        Get
            Return _idtrabajador
        End Get
        Set(ByVal value As String)
            _idtrabajador = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property ApellidoPaterno() As String
        Get
            Return _apepattrabajador
        End Get
        Set(ByVal value As String)
            _apepattrabajador = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property ApellidoMaterno() As String
        Get
            Return _apemattrabajador
        End Get
        Set(ByVal value As String)
            _apemattrabajador = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Nombre() As String
        Get
            Return _nomtrabajador
        End Get
        Set(ByVal value As String)
            _nomtrabajador = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Codigo() As String
        Get
            Return _codtrabajador
        End Get
        Set(ByVal value As String)
            _codtrabajador = value
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
    Public Overridable Property NombreCompleto() As String
        Get
            Return _apepattrabajador + " " + _apemattrabajador + ", " + _nomtrabajador
        End Get
        Set(ByVal value As String)
        End Set
    End Property

#End Region

#Region "Constructor"
    Public Sub New()
        _id = String.Empty
        _idcaja = String.Empty
        _idtrabajador = String.Empty
        _apepattrabajador = String.Empty
        _apemattrabajador = String.Empty
        _nomtrabajador = String.Empty
        _idcentro = String.Empty
        _activo = True
    End Sub

    Public Sub New(ByVal ls_Id As String _
              , ByVal ls_IdCaja As String _
              , ByVal ls_IdTrabajador As String _
              , ByVal ls_Codigo As String _
              , ByVal ls_ApellidoPaterno As String _
              , ByVal ls_ApellidoMaterno As String _
              , ByVal ls_Nombre As String _
              , ByVal lb_Activo As String _
              , ByVal ls_IdCentro As String _
           )
        _id = ls_Id
        _idcaja = ls_IdCaja
        _idtrabajador = ls_IdTrabajador
        _apepattrabajador = ls_ApellidoPaterno
        _apemattrabajador = ls_ApellidoMaterno
        _nomtrabajador = ls_Nombre
        _codtrabajador = ls_Codigo
        _activo = lb_Activo
        _idcentro = ls_IdCentro
    End Sub

#End Region

#Region "Metodos"

    Public Overloads Function Equals(ByVal oeCajaUsuario As e_CajaUsuario) _
    As Boolean Implements System.IEquatable(Of e_CajaUsuario).Equals
        If Me.IdTrabajador = oeCajaUsuario.IdTrabajador Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function Obtener(ByVal cajaUsuario As e_CajaUsuario) As e_CajaUsuario Implements Ie_CajaUsuario.Obtener
        Return cajaUsuario
    End Function

#End Region

End Class
