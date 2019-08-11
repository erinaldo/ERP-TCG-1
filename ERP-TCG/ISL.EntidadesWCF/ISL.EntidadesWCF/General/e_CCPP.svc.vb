''' <summary>
''' Entidad CCPP para trabajar con la tabla CCPP estandar
''' </summary>
''' <remarks></remarks>
<DataContract()> _
Public Class e_CCPP
    Inherits e_Ubigeo
    Implements IPropiedadesBasicas
    Implements Ie_CCPP

#Region "Constructores"

    Sub New()

    End Sub

    ''' <summary>
    ''' Generación de un CCPP a partir de sus datos básicos
    ''' </summary>0
    ''' <param name="id">Id de la provincia</param>
    ''' <param name="codigo">Código del CCPP</param>
    ''' <param name="nombre">Nombre del CCPP</param>
    ''' <remarks></remarks>
    Sub New(ByVal id As String, _
            ByVal codigoDepartamento As String, _
            ByVal codigoProvincia As String, _
            ByVal codigoDistrito As String, _
            ByVal codigo As String, _
            ByVal nombre As String, _
            ByVal activo As Boolean, _
            ByVal ls_IdEmpresa As String)
        _id = id
        _codigoDepartamento = codigoDepartamento
        _codigoProvincia = codigoProvincia
        _codigoDistrito = codigoDistrito
        _codigo = codigo
        _nombre = nombre
        _activo = activo
        IdEmpresa = ls_IdEmpresa
    End Sub

#End Region

    <DataMember()> _
    Public TipOoperacion As String
    <DataMember()> _
    Public Modificado As Boolean

#Region "Propiedades"

    ''' <summary>
    ''' Id del CCPP
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
        End Set
    End Property

    Private _codigoDistrito As String
    <DataMember()> _
    Public Property CodigoDistrito() As String
        Get
            Return _codigoDistrito
        End Get
        Set(ByVal value As String)
            _codigoDistrito = value
        End Set
    End Property

    ''' <summary>
    ''' Código del CCPP
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
        End Set
    End Property

    ''' <summary>
    ''' Nombre del CCPP
    ''' </summary>
    ''' <remarks></remarks>
    Private _nombre As String
    Public Overloads Property Nombre() As String Implements IPropiedadesBasicas.Nombre
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
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
        End Set
    End Property

    <DataMember()> _
    Public IdEmpresa As String

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Obtener una entidad de tipo e_CCPP
    ''' </summary>
    ''' <param name="centroPoblado">Objeto de tipo e_CCPP (Centro Poblado)</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Obtener(ByVal centroPoblado As e_CCPP) As e_CCPP Implements Ie_CCPP.Obtener
        Return centroPoblado
    End Function

#End Region

End Class


