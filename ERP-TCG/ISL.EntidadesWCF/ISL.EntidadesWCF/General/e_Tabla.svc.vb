

<DataContract()> _
Public Class e_Tabla
    Implements Ie_Tabla

#Region "Constructores"

    Public Sub New()

    End Sub

    ''' <summary>
    ''' Construye una entidad de tipo tabla
    ''' </summary>
    ''' <param name="nombreColumna"></param>
    ''' <param name="tipoDato"></param>
    ''' <param name="longitud"></param>
    ''' <param name="nulo"></param>
    ''' <remarks></remarks>
    Public Sub New(ByVal nombreColumna As String, ByVal tipoDato As String, ByVal longitud As String, ByVal nulo As String)
        _nombreColumna = nombreColumna
        _tipoDato = tipoDato
        _longitud = longitud
        _nulo = nulo
    End Sub

#End Region

#Region "Propiedades"

    Private _nombreColumna As String
    <DataMember()> _
    Public Property NombreColumna() As String
        Get
            Return _nombreColumna
        End Get
        Set(ByVal value As String)
            _nombreColumna = value
        End Set
    End Property

    Private _tipoDato As String
    <DataMember()> _
    Public Property TipoDato() As String
        Get
            Return _tipoDato
        End Get
        Set(ByVal value As String)
            _tipoDato = value
        End Set
    End Property

    Private _longitud As String
    <DataMember()> _
    Public Property Longitud() As String
        Get
            Return _longitud
        End Get
        Set(ByVal value As String)
            _longitud = value
        End Set
    End Property


    Private _nulo As String
    <DataMember()> _
    Public Property Nulo() As String
        Get
            Return _nulo
        End Get
        Set(ByVal value As String)
            _nulo = value
        End Set
    End Property

#End Region

    Public Function Obtener(ByVal tabla As e_Tabla) As e_Tabla Implements Ie_Tabla.Obtener
        Return tabla
    End Function

End Class


