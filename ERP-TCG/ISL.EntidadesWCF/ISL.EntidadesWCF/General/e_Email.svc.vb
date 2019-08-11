<DataContract()> _
Public Class e_Email
    Implements Ie_Email
    Implements IEquatable(Of e_Email)

#Region "Declaracion de Variables"

    Private _id As String
    Private _tipopersonaempresa As Integer
    Private _idpersonaempresa As String
    Private _nombre As String
    Private _principal As Integer
    Private _activo As Boolean
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _nombrecompleto As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public Equivale As Integer

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
    Public Property TipoPersonaEmpresa() As Integer
        Get
            Return _tipopersonaempresa
        End Get
        Set(ByVal value As Integer)
            _tipopersonaempresa = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdPersonaEmpresa() As String
        Get
            Return _idpersonaempresa
        End Get
        Set(ByVal value As String)
            _idpersonaempresa = value
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
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    <DataMember()> _
    Public Property Principal() As Integer
        Get
            Return _principal
        End Get
        Set(ByVal value As Integer)
            _principal = value
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

#End Region

#Region "Constructor"

    Public Sub New()
        _id = ""
        _nombre = ""
        _activo = True
        _fechacreacion = #1/1/1901#
        _usuariocreacion = ""
        _nombrecompleto = ""
        _idpersonaempresa = ""
        _tipopersonaempresa = 0
        _principal = 0
        TipoOperacion = ""
    End Sub

    Public Sub New( _
              ByVal Id As String _
              , ByVal TipoPersonaEmpresa As Integer _
              , ByVal IdPersonaEmpresa As String _
              , ByVal Nombre As String _
              , ByVal Principal As Integer _
              , ByVal Activo As Boolean _
              , ByVal FechaCreacion As Date _
              , ByVal UsuarioCreacion As String _
              , ByVal NombreCompleto As String _
           )
        _id = Id
        _tipopersonaempresa = TipoPersonaEmpresa
        _idpersonaempresa = IdPersonaEmpresa
        _nombrecompleto = NombreCompleto
        _nombre = Nombre
        _principal = Principal
        _activo = Activo
        _fechacreacion = FechaCreacion
        _usuariocreacion = UsuarioCreacion

    End Sub

#End Region

#Region "Metodos"

    Public Function Obtener(ByVal email As e_Email) As e_Email Implements Ie_Email.Obtener
        Return email
    End Function

    Public Overloads Function Equals(ByVal oeEma As e_Email) _
As Boolean Implements System.IEquatable(Of e_Email).Equals
        Select Case oeEma.Equivale
            Case 1 : If Me.Id = oeEma.Id Then Return True
            Case 2 : If Me.Nombre = oeEma.Nombre Then Return True
        End Select
        Return False
    End Function

#End Region

End Class


