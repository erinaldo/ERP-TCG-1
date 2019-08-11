''' <summary>
''' Entidad departamento para trabajar con la tabla UBIGEO estandar
''' </summary>
''' <remarks></remarks>
<DataContract()> _
Public Class e_Departamento
    Inherits e_Ubigeo
    Implements IPropiedadesBasicas
    Implements Ie_Departamento

    <DataMember()> _
    Public Modificado As Boolean = False
    <DataMember()> _
    Public TipoOperacion As String

    Public Event DatoCambiado()

#Region "Constructores"

    Sub New()

    End Sub

    ''' <summary>
    ''' Generación de un departamento a partir de sus datos básicos
    ''' </summary>
    ''' <param name="id">Id del departamento</param>
    ''' <param name="codigo">Código del departamento</param>
    ''' <param name="nombre">Nombre del departamento</param>
    ''' <remarks></remarks>
    Sub New(ByVal id As String, ByVal codigo As String, ByVal nombre As String, ByVal activo As Boolean)
        _id = id
        _codigo = codigo
        _nombre = nombre
        _activo = activo
    End Sub

#End Region

#Region "Propiedades"

    ''' <summary>
    ''' Id del departamento
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
    ''' Nombre del departamento
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

    Public Overloads Function Obtener(ByVal departamento As e_Departamento) As e_Departamento Implements Ie_Departamento.Obtener
        Return departamento
    End Function

End Class


