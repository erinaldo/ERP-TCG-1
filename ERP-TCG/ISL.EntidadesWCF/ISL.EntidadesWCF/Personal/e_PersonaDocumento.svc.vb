<DataContract()> _
Public Class e_PersonaDocumento
    Implements Ie_PersonaDocumento
    Implements IEquatable(Of e_PersonaDocumento)

#Region "Declaracion de Variables"

    Private _id As String
    Private _idpersona As String
    Private _nombre As String
    Private _dni As String
    Private _idtipodocumento As String
    Private _tipodocumento As String
    Private _numerodocumento As String
    Private _descripcion As String
    Private _fechaactividad As Date
    Private _fechavencimiento As Date
    Private _vigente As Integer
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _activo As Boolean
    Private _rutaimagen As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public leHistorial As New List(Of e_PersonaDocumento)
    <DataMember()> _
    Public Equivale As Integer

#End Region

#Region "Propiedades"

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
    Public Property IdPersona() As String
        Get
            Return _idpersona
        End Get
        Set(ByVal value As String)
            _idpersona = value
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
    Public Property Dni() As String
        Get
            Return _dni
        End Get
        Set(ByVal value As String)
            _dni = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdTipoDocumento() As String
        Get
            Return _idtipodocumento
        End Get
        Set(ByVal value As String)
            _idtipodocumento = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoDocumento() As String
        Get
            Return _tipodocumento
        End Get
        Set(ByVal value As String)
            _tipodocumento = value
        End Set
    End Property

    <DataMember()> _
    Public Property NumeroDocumento() As String
        Get
            Return _numerodocumento
        End Get
        Set(ByVal value As String)
            _numerodocumento = value
        End Set
    End Property

    <DataMember()> _
    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaActividad() As Date
        Get
            Return _fechaactividad
        End Get
        Set(ByVal value As Date)
            _fechaactividad = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaVencimiento() As Date
        Get
            Return _fechavencimiento
        End Get
        Set(ByVal value As Date)
            _fechavencimiento = value
        End Set
    End Property

    <DataMember()> _
    Public Property Vigente() As Integer
        Get
            Return _vigente
        End Get
        Set(ByVal value As Integer)
            _vigente = value
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
        End Set
    End Property

    <DataMember()> _
    Public Property RutaImagen() As String
        Get
            Return _rutaimagen
        End Get
        Set(ByVal value As String)
            _rutaimagen = value
        End Set
    End Property

#End Region

#Region "Contructor"

    Public Sub New()
        _id = String.Empty
        _idpersona = String.Empty
        _nombre = String.Empty
        _dni = String.Empty
        _idtipodocumento = String.Empty
        _tipodocumento = String.Empty
        _numerodocumento = String.Empty
        _descripcion = String.Empty
        _fechaactividad = #1/1/1901#
        _fechavencimiento = #1/1/1901#
        _vigente = 0
        _fechacreacion = #1/1/1901#
        _usuariocreacion = String.Empty
        _activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdPersona As String _
              , ByVal ls_Nombre As String _
              , ByVal ls_Dni As String _
              , ByVal ls_IdTipoDocumento As String _
              , ByVal ls_TipoDocumento As String _
              , ByVal ls_NumeroDocumento As String _
              , ByVal ls_Decripcion As String _
              , ByVal ld_FechaActividad As Date _
              , ByVal ld_FechaVencimiento As Date _
              , ByVal ln_Vigente As Integer _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _idpersona = ls_IdPersona
        _nombre = ls_Nombre
        _dni = ls_Dni
        _idtipodocumento = ls_IdTipoDocumento
        _tipodocumento = ls_TipoDocumento
        _numerodocumento = ls_NumeroDocumento
        _descripcion = ls_Decripcion
        _fechaactividad = ld_FechaActividad
        _fechavencimiento = ld_FechaVencimiento
        _vigente = ln_Vigente
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _activo = lb_Activo
    End Sub

#End Region

#Region "Metodos"

    Public Function obtener(oePersonaDocumento As e_PersonaDocumento) As e_PersonaDocumento Implements Ie_PersonaDocumento.obtener
        Return oePersonaDocumento
    End Function

    Public Overloads Function Equals(ByVal oePerDoc As e_PersonaDocumento) _
As Boolean Implements System.IEquatable(Of e_PersonaDocumento).Equals
        Select Case oePerDoc.Equivale
            Case 1 : If Me.Id = oePerDoc.Id Then Return True
            Case 2 : If Me.NumeroDocumento = oePerDoc.NumeroDocumento Then Return True
        End Select
        Return False
    End Function

#End Region

End Class
