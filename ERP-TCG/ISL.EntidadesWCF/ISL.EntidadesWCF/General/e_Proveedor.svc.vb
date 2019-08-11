''' <summary>
''' Clase para definir la entidad: Proveedor
''' </summary>
''' <remarks></remarks>
<DataContract()> _
Public Class e_Proveedor
    Implements Ie_Proveedor
    Implements IPropiedadesBasicas
    Implements IEquatable(Of e_Proveedor)


#Region "Declaracion de Variables"

    Private _id As String
    Private _codigo As String
    Private _tipopersonaempresa As Integer
    Private _idpersona As String
    Private _idempresa As String
    Private _fechaactividad As Date
    Private _usuariocreacion As String
    Private _activo As Boolean
    Private _Nombre As String
    Private _nrodoc As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public Tipo As Integer = 0
    <DataMember()> _
    Public IndRelacionada As Integer

    <DataMember()> _
    Public oePersona As New e_Persona
    <DataMember()> _
    Public oeEmpresa As New e_Empresa

    <DataMember()> _
    Public leEmail As New List(Of e_Email)
    <DataMember()> _
    Public leTelefono As New List(Of e_Telefono)
    <DataMember()> _
    Public leDireccion As New List(Of e_Direccion_EmpresaPersona)

    Private _email As New e_Email

    'Private _email As String
    Private _contacto As String
    Private _Seleccion As Boolean = False
    <DataMember()> _
    Public _chkRuc As Boolean = False
    <DataMember()> _
    Public IdTipoEmpresa As String

#End Region

#Region "Propiedades"

    <DataMember()> _
    Public Property NroDocumento() As String
        Get
            Return _nrodoc
        End Get
        Set(ByVal value As String)
        End Set
    End Property

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
    Public Property Email() As String
        Get
            Return _email.Nombre
        End Get
        Set(ByVal value As String)
            _email.Nombre = value
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
    Public Property Id() As String Implements IPropiedadesBasicas.Id
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
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
    Public Property TipoPersonaEmpresa() As Integer
        Get
            Return _tipopersonaempresa
        End Get
        Set(ByVal value As Integer)
            _tipopersonaempresa = value
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
    Public Property IdEmpresa() As String
        Get
            Return _idempresa
        End Get
        Set(ByVal value As String)
            _idempresa = value
        End Set
    End Property

    <DataMember()> _
    Public Property Nombre() As String Implements IPropiedadesBasicas.Nombre
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
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
    Public Property UsuarioCreacion() As String
        Get
            Return _usuariocreacion
        End Get
        Set(ByVal value As String)
            _usuariocreacion = value
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

#End Region

#Region "Constructor"

    Public Sub New()
        _id = ""
        _codigo = ""
        _tipopersonaempresa = -1
        _fechaactividad = #1/1/1901#
        _usuariocreacion = ""
        TipoOperacion = ""
        _activo = True
        IndRelacionada = 0
    End Sub

    Public Sub New( _
              ByVal Id As String _
              , ByVal Codigo As String _
              , ByVal TipoPersonaEmpresa As Integer _
              , ByVal IdPersonaEmpresa As String _
              , ByVal Nombre As String _
              , ByVal NroDoc As String _
              , ByVal FechaActividad As Date _
              , ByVal UsuarioCreacion As String _
              , ByVal Activo As Boolean _
              , ByVal ls_Email As String _
              , ByVal ls_IdTipoEmpresa As String _
              , ByVal ln_IndRelacionda As Integer _
            )
        _id = Id
        _codigo = Codigo
        _tipopersonaempresa = TipoPersonaEmpresa
        If TipoPersonaEmpresa = 1 Then
            _idpersona = IdPersonaEmpresa
        Else
            _idempresa = IdPersonaEmpresa
        End If
        _fechaactividad = FechaActividad
        _activo = Activo
        _Nombre = Nombre
        _nrodoc = NroDoc
        _usuariocreacion = UsuarioCreacion
        _email.Nombre = ls_Email
        IdTipoEmpresa = ls_IdTipoEmpresa
        IndRelacionada = ln_IndRelacionda
    End Sub

#End Region

#Region "Métodos"

    Public Function Obtener(ByVal proveedor As e_Proveedor) As e_Proveedor Implements Ie_Proveedor.Obtener
        Return proveedor
    End Function

#End Region

    Public Function Equals1(other As e_Proveedor) As Boolean Implements IEquatable(Of e_Proveedor).Equals
        Select Case other.Tipo
            Case 0
                If Me.Id = other.Id.Trim Then Return True
        End Select
        Return False
    End Function
End Class


