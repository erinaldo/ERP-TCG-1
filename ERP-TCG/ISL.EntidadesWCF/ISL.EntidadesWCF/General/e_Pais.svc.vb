''' <summary>
''' Clase para definir la entidad: Pais
''' </summary>
''' <remarks></remarks>
<DataContract()> _
Public Class e_Pais
    Implements Ie_Pais
    Implements IPropiedadesBasicas

#Region "Declaracion de Variables"
    Private _Id As String
    Private _Codigo As String
    Private _Nombre As String
    Private _Abreviatura As String
    Private _Activo As Boolean
#End Region

#Region "Constructor"
    Sub New()

    End Sub

    Sub New(ByVal Id As String, ByVal Codigo As String, ByVal Nombre As String, ByVal Abreviatura As String, ByVal Activo As Boolean)
        _Id = Id
        _Codigo = Codigo
        _Nombre = Nombre
        _Abreviatura = Abreviatura
        _Activo = Activo
    End Sub
#End Region

#Region "Propiedades"
    ''' <summary>
    ''' Id de Pais
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
    ''' Codigo de Pais
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
        End Set
    End Property

    ''' <summary>
    ''' Nombre de Pais
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
        End Set
    End Property

    ''' <summary>
    ''' Abreviatura de Pais
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember()> _
    Public Property Abreviatura() As String
        Get
            Return _Abreviatura
        End Get
        Set(ByVal value As String)
            _Abreviatura = value
        End Set
    End Property

    ''' <summary>
    ''' Activo de Pais
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
        End Set
    End Property

#End Region

#Region "Métodos"

    Public Function Obtener(ByVal pais As e_Pais) As e_Pais Implements Ie_Pais.Obtener
        Return pais
    End Function

#End Region

End Class


