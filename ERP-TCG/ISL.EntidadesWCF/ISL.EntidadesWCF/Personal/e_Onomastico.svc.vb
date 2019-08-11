

<DataContract()> _
Public Class e_Onomastico
    Implements Ie_Onomastico

#Region "Constructor"

    Public Sub New()

    End Sub

    Public Sub New(ByVal dia As String, ByVal mes As String, ByVal nombreCompleto As String, _
                   ByVal area As String, ByVal ordenMes As Integer, ByVal edad As Integer, ByVal dni As String)
        _dia = dia
        _mes = mes
        _nombreCompleto = nombreCompleto
        _area = area
        _ordenMes = ordenMes
        _edad = edad
        _dni = dni
    End Sub

#End Region

#Region "Propiedades"

    Private _dia As String
    <DataMember()> _
    Public Property Dia() As String
        Get
            Return _dia
        End Get
        Set(ByVal value As String)
            _dia = value
        End Set
    End Property

    Private _mes As String
    <DataMember()> _
    Public Property Mes() As String
        Get
            Return _mes
        End Get
        Set(ByVal value As String)
            _mes = value
        End Set
    End Property

    Private _nombreCompleto As String
    <DataMember()> _
    Public Property NombreCompleto() As String
        Get
            Return _nombreCompleto
        End Get
        Set(ByVal value As String)
            _nombreCompleto = value
        End Set
    End Property

    Private _area As String
    <DataMember()> _
    Public Property Area() As String
        Get
            Return _area
        End Get
        Set(ByVal value As String)
            _area = value
        End Set
    End Property

    ''' <summary>
    ''' Propiedad temporal para almacenar el número del mes (se utiliza para ordenar las listas de cumpleaños)
    ''' </summary>
    ''' <remarks></remarks>
    Private _ordenMes As Integer
    <DataMember()> _
    Public Property OrdenMes() As Integer
        Get
            Return _ordenMes
        End Get
        Set(ByVal value As Integer)
            _ordenMes = value
        End Set
    End Property

    ''' <summary>
    ''' Propiedad para almacenar el valor calculado de la edad del trabajador
    ''' </summary>
    ''' <remarks></remarks>
    Private _edad As Integer
    <DataMember()> _
    Public Property Edad() As Integer
        Get
            Return _edad
        End Get
        Set(ByVal value As Integer)
            _edad = value
        End Set
    End Property

    Private _dni As String
    <DataMember()> _
    Public Property Dni() As String
        Get
            Return _dni
        End Get
        Set(ByVal value As String)
            _dni = value
        End Set
    End Property

#End Region

#Region "Metodos"

    ''' <summary>
    ''' Obtener una entidad de tipo e_Onomastico
    ''' </summary>
    ''' <param name="onomastico"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal onomastico As e_Onomastico) As e_Onomastico Implements Ie_Onomastico.Obtener
        Return onomastico
    End Function

#End Region

End Class



