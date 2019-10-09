
<DataContract()> _
Public Class e_AlertaDestino
    Implements Ie_AlertaDestino
    Implements IEquatable(Of e_AlertaDestino)

#Region "Declaracion de Variables"

    Private _id As String
    Private _idalerta As String
    Private _idpersona As String
    Private _nombrecompleto As String
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _activo As Boolean

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
    Public Event DatoCambiado()

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
    Public Property IdAlerta() As String
        Get
            Return _idalerta
        End Get
        Set(ByVal value As String)
            _idalerta = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdPersona() As String
        Get
            Return _idpersona
        End Get
        Set(ByVal value As String)
            _idpersona = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property NombreCompleto() As String
        Get
            Return _nombrecompleto
        End Get
        Set(ByVal value As String)
            _nombrecompleto = value
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
    Public Property UsuarioCreacion() As String
        Get
            Return _usuariocreacion
        End Get
        Set(ByVal value As String)
            _usuariocreacion = value
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

#End Region

#Region "Constructor"
    Public Sub New()
        _id = ""
        _fechacreacion = #1/1/1901#
        _usuariocreacion = ""
        _nombrecompleto = ""
        TipoOperacion = ""
        _activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdAlerta As String _
              , ByVal ls_IdPersona As String _
              , ByVal ls_NombreCompleto As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _idalerta = ls_IdAlerta
        _idpersona = ls_IdPersona
        _nombrecompleto = ls_NombreCompleto
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _activo = lb_Activo
    End Sub

#End Region

#Region "Metodos"

    Public Overloads Function Equals(ByVal oeAlertaDestino As e_AlertaDestino) _
    As Boolean Implements System.IEquatable(Of e_AlertaDestino).Equals
        If Me.IdPersona = oeAlertaDestino.IdPersona Then
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Obtener una entidad de tipo e_AlertaDestino
    ''' </summary>
    ''' <param name="alertaDestino"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal alertaDestino As e_AlertaDestino) As e_AlertaDestino Implements Ie_AlertaDestino.Obtener
        Return alertaDestino
    End Function

#End Region

End Class
