''' <summary>
''' Clase para definir la entidad: TipoOrden
''' </summary>
''' <remarks></remarks>
<DataContract()> _
Public Class e_TipoOrden
    Implements Ie_TipoOrden
    Implements IPropiedadesBasicas

#Region "Declaración de variables"
    Private _Id As String
    Private _Codigo As String = String.Empty
    Private _Nombre As String
    Private _Abreviatura As String = String.Empty
    Private _Activo As Boolean
    <DataMember()> _
    Public TipOoperacion As String
    <DataMember()> _
    Public Modificado As Boolean

#End Region

#Region "Constructor"
    Sub New()

    End Sub

    Sub New(ByVal Id As String, _
            ByVal Codigo As String, _
            ByVal Nombre As String, _
            ByVal Abreviatura As String, _
            ByVal Activo As Boolean)
        _Id = Id
        _Codigo = Codigo
        _Nombre = Nombre
        _Abreviatura = Abreviatura
        _Activo = Activo
    End Sub
#End Region

#Region "Propiedades"
    <DataMember()> _
    Public Property Id() As String Implements IPropiedadesBasicas.Id
        Get
            Return _Id
        End Get
        Set(ByVal value As String)
            _Id = value
        End Set
    End Property

    <DataMember()> _
    Public Property Codigo() As String Implements IPropiedadesBasicas.Codigo
        Get
            Return _Codigo
        End Get
        Set(ByVal value As String)
            _Codigo = value
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
    Public Property Abreviatura() As String
        Get
            Return _Abreviatura
        End Get
        Set(ByVal value As String)
            _Abreviatura = value
        End Set
    End Property

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

    Public Function Obtener(ByVal tipoOrden As e_TipoOrden) As e_TipoOrden Implements Ie_TipoOrden.Obtener
        Return tipoOrden
    End Function

#End Region

End Class


