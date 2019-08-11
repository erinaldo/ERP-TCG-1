<DataContract()> _
Public Class e_ConceptosGenerales
    Implements Ie_ConceptosGenerales
    Implements IPropiedadesBasicas

#Region "Declaración de variables"

    Private _id As String
    Private _codigo As String
    Private _nombre As String
    Private _abreviatura As String
    Private _activo As Boolean
    Private _idProcesoNegocio As String
    Private _orden As Integer
    Private _protegido As Integer
    Private _usuarioCreacion As String

    <DataMember()> _
    Public Modificado As Boolean = False
    <DataMember()> _
    Public TipoOperacion As String

    Public Event DatoCambiado()

#End Region

#Region "Constructores"

    Public Sub New()

    End Sub

    Public Sub New(ByVal id As String, ByVal idProcesoNegocio As String, ByVal codigo As String, ByVal nombre As String, ByVal abreviatura As String, ByVal orden As Integer, ByVal activo As Boolean, ByVal protegido As Integer, ByVal usuarioCreacion As String)
        _id = id
        _idProcesoNegocio = idProcesoNegocio
        _codigo = codigo
        _nombre = nombre
        _abreviatura = abreviatura
        _orden = orden
        _activo = activo
        _protegido = protegido
        _usuarioCreacion = usuarioCreacion
    End Sub

#End Region

#Region "Propiedades"

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
    Public Property IdProcesoNegocio() As String
        Get
            Return _idProcesoNegocio
        End Get
        Set(ByVal value As String)
            _idProcesoNegocio = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Codigo() As String Implements IPropiedadesBasicas.Codigo
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Nombre() As String Implements IPropiedadesBasicas.Nombre
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
    Public Property Orden() As Integer
        Get
            Return _orden
        End Get
        Set(ByVal value As Integer)
            _orden = value
            RaiseEvent DatoCambiado()
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
    Public Property Protegido() As Integer
        Get
            Return _protegido
        End Get
        Set(ByVal value As Integer)
            _protegido = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioCreacion() As String
        Get
            Return _usuarioCreacion
        End Get
        Set(ByVal value As String)
            _usuarioCreacion = value
        End Set
    End Property


#End Region

#Region "Métodos"

    ''' <summary>
    ''' Obtener una entidad de tipo e_ConceptosGenerales
    ''' </summary>
    ''' <param name="conceptosGenerales"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal conceptosGenerales As e_ConceptosGenerales) As e_ConceptosGenerales Implements Ie_ConceptosGenerales.Obtener
        Return conceptosGenerales
    End Function

#End Region

    'Public Property Activo1 As Boolean
    'Public Property Codigo1 As String

    'Public Property Id1 As String

    'Public Property Nombre1 As String
End Class


