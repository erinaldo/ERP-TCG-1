''' <summary>
''' Clase para definir la entidad: Persona
''' Fecha: 14/10/2011
''' </summary>
''' <remarks></remarks>
<DataContract()> _
Public Class e_Persona
    Implements Ie_Persona
    Implements IPropiedadesBasicas

#Region "Declaración de Variables"

    Private _Id As String
    Private _Codigo As String
    Private _ApellidoPaterno As String
    Private _ApellidoMaterno As String
    Private _Nombre As String
    Private _NombreCompleto As String
    Private _FechaNacimiento As Date = #1/1/1901#
    Private _Dni As String
    Private _Activo As Boolean
    Private _usuariocreacion As String
    Private _contacto As Boolean
    Private _idContacto As String


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
    <DataMember()> _
    Public oeClienteProveedor As New e_ClienteProveedor
    <DataMember()> _
    Public leTelefono As New List(Of e_Telefono)
    <DataMember()> _
    Public leEmail As New List(Of e_Email)
    <DataMember()> _
    Public leDireccionEP As New List(Of e_Direccion_EmpresaPersona)
    <DataMember()> _
    Public leTipoPago As New List(Of e_PersonaEmpresa_TipoPago)
    <DataMember()> _
    Public leDocumento As New List(Of e_PersonaDocumento)
    <DataMember()> _
    Public CargaCompleta As Boolean = False

    <DataMember()> _
    Public oeSexo As New e_Sexo

    Event DatoCambio()

#End Region

#Region "Contructor"

    Public Sub New()
        _Id = ""
        _Codigo = ""
        _ApellidoPaterno = ""
        _ApellidoMaterno = ""
        _Nombre = ""
        _FechaNacimiento = #1/1/1901#
        _Dni = ""
        _Activo = True
        _usuariocreacion = ""
        TipoOperacion = ""
    End Sub

    Public Sub New(ByVal Id As String, _
                   ByVal Codigo As String, _
                   ByVal ApellidoPaterno As String, _
                   ByVal ApellidoMaterno As String, _
                   ByVal Nombre As String, _
                   ByVal Sexo As e_Sexo, _
                   ByVal FechaNacimiento As Date, _
                   ByVal Dni As String, _
                   ByVal Activo As Boolean)
        _Id = Id
        _Codigo = Codigo
        _ApellidoPaterno = ApellidoPaterno
        _ApellidoMaterno = ApellidoMaterno
        _Nombre = Nombre
        _FechaNacimiento = FechaNacimiento
        _Dni = Dni
        oeSexo = Sexo
        _Activo = Activo
    End Sub

#End Region

#Region "Propiedades"

    ''' <summary>
    ''' Id Persona
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember()> _
    Public Property Id() As String Implements IPropiedadesBasicas.Id
        Get
            Return _Id
        End Get
        Set(ByVal value As String)
            _Id = value
        End Set
    End Property

    ''' <summary>
    ''' Codigo Persona
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember()> _
    Public Property Codigo() As String Implements IPropiedadesBasicas.Codigo
        Get
            Return _Codigo
        End Get
        Set(ByVal value As String)
            _Codigo = value
            RaiseEvent DatoCambio()
        End Set
    End Property

    ''' <summary>
    ''' Apellido Paterno
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember()> _
    Public Property ApellidoPaterno() As String
        Get
            Return _ApellidoPaterno
        End Get
        Set(ByVal value As String)
            _ApellidoPaterno = value
            RaiseEvent DatoCambio()
        End Set
    End Property

    ''' <summary>
    ''' Apellido Materno
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember()> _
    Public Property ApellidoMaterno() As String
        Get
            Return _ApellidoMaterno
        End Get
        Set(ByVal value As String)
            _ApellidoMaterno = value
            RaiseEvent DatoCambio()
        End Set
    End Property

    ''' <summary>
    ''' Nombre
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember()> _
    Public Property Nombre() As String Implements IPropiedadesBasicas.Nombre
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
            RaiseEvent DatoCambio()
        End Set
    End Property

    Public Property NombreCompleto() As String
        Get
            If Nombre.Trim <> "" Then
                _NombreCompleto = ApellidoPaterno.Trim + " " + ApellidoMaterno.Trim + ", " + Nombre.Trim
            Else
                _NombreCompleto = ApellidoPaterno.Trim
            End If
            Return _NombreCompleto
        End Get
        Set(value As String)
            _NombreCompleto = value
        End Set
    End Property
    <DataMember()> _
    Public Property Contacto() As Boolean
        Get
            Return _contacto
        End Get
        Set(ByVal value As Boolean)
            _contacto = value
        End Set
    End Property


    ''' <summary>
    ''' Fecha Nacimiento
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember()> _
    Public Property FechaNacimiento() As Date
        Get
            Return _FechaNacimiento
        End Get
        Set(ByVal value As Date)
            _FechaNacimiento = value
            RaiseEvent DatoCambio()
        End Set
    End Property

    ''' <summary>
    ''' Documento Nacional de Indentidad
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember()> _
    Public Property Dni() As String
        Get
            Return _Dni
        End Get
        Set(ByVal value As String)
            _Dni = value
            RaiseEvent DatoCambio()
        End Set
    End Property

    ''' <summary>
    ''' Activo
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember()> _
    Public Property Activo() As Boolean Implements IPropiedadesBasicas.Activo
        Get
            Return _Activo
        End Get
        Set(ByVal value As Boolean)
            _Activo = value
            RaiseEvent DatoCambio()
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
    Public Property IdContacto() As String
        Get
            Return _idContacto
        End Get
        Set(ByVal value As String)
            _idContacto= value            
        End Set
    End Property

#End Region

#Region "Metodos"

    ' ''' <summary>
    ' ''' Función de la clase persona que retorna el nombre completo
    ' ''' en secuencia Apellido Paterno, Apellido Materno y Nombre
    ' ''' </summary>
    ' ''' <returns></returns>
    ' ''' <remarks></remarks>
    'Public Function NombreCompleto() As String
    '    Return Me.ApellidoPaterno.Trim + " " + Me.ApellidoMaterno.Trim + ", " + Me.Nombre.Trim
    'End Function

    ''' <summary>
    ''' Función de la clase persona que retorna el nombre completo
    ''' en secuencia Nombre, Apellido Paterno y Apellido Materno 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function NombreCompleto2() As String
        Return Me.Nombre.Trim + +Me.ApellidoPaterno.Trim + " " + Me.ApellidoMaterno.Trim
    End Function

    Public Function Obtener(ByVal persona As e_Persona) As e_Persona Implements Ie_Persona.Obtener
        Return persona
    End Function

#End Region

End Class


