''' <summary>
''' Entidad Distrito para trabajar con la tabla UBIGEO estandar
''' </summary>
''' <remarks></remarks>
<DataContract()> _
Public Class e_Distrito
    Inherits e_Ubigeo
    Implements Ie_Distrito
    Implements IPropiedadesBasicas

#Region "Declaración de variables"

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean = False
    <DataMember()>
    Public PrefijoID As String = ""
    Public Event DatoCambiado()

#End Region

#Region "Constructores"

    Sub New()

    End Sub

    ''' <summary>
    ''' Generación de un distrito a partir de sus datos básicos
    ''' </summary>
    ''' <param name="id">Id de la provincia</param>
    ''' <param name="codigo">Código del distrito</param>
    ''' <param name="nombre">Nombre del distrito</param>
    ''' <remarks></remarks>
    Sub New(ByVal id As String, ByVal codigoDepartamento As String, ByVal codigoProvincia As String, ByVal codigo As String, ByVal nombre As String, ByVal activo As Boolean)
        _id = id
        _codigoDepartamento = codigoDepartamento
        _codigoProvincia = codigoProvincia
        _codigo = codigo
        _nombre = nombre
        _activo = activo
    End Sub

#End Region

#Region "Propiedades"

    ''' <summary>
    ''' Id del distrito
    ''' </summary>
    ''' <remarks></remarks>
    Private _id As String
    <DataMember()> _
    Public Overloads Property Id() As String Implements IPropiedadesBasicas.Id
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    ''' <summary>
    ''' Código del departamento
    ''' </summary>
    ''' <remarks></remarks>
    Private _codigoDepartamento As String
    <DataMember()> _
    Public Property CodigoDepartamento() As String
        Get
            Return _codigoDepartamento
        End Get
        Set(ByVal value As String)
            _codigoDepartamento = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    ''' <summary>
    ''' Código de la Provincia
    ''' </summary>
    ''' <remarks></remarks>
    Private _codigoProvincia As String
    <DataMember()> _
    Public Property CodigoProvincia() As String
        Get
            Return _codigoProvincia
        End Get
        Set(ByVal value As String)
            _codigoProvincia = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    ''' <summary>
    ''' Código del distrito
    ''' </summary>
    ''' <remarks></remarks>
    Private _codigo As String
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

    ''' <summary>
    ''' Nombre del distrito
    ''' </summary>
    ''' <remarks></remarks>
    Private _nombre As String
    <DataMember()> _
    Public Overloads Property Nombre() As String Implements IPropiedadesBasicas.Nombre
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    Private _activo As Boolean
    <DataMember()> _
    Public Property Activo() As Boolean Implements IPropiedadesBasicas.Activo
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

#End Region

#Region "Métodos"

    Public Overloads Function Obtener(ByVal distrito As e_Distrito) As e_Distrito Implements Ie_Distrito.Obtener
        Return distrito
    End Function

#End Region

End Class


