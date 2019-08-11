

<DataContract()> _
Public Class e_Fechas
    Implements Ie_Fechas

#Region "Declaración de variables"

    Private _FechaInicio As Date
    Private _FechaFin As Date

    Private _OpcionFecha As String

    <DataMember()> _
    Public Activo As Boolean = True

#End Region

#Region "Propiedades"

    <DataMember()> _
    Public Property OpcionFecha() As String
        Get
            Return _OpcionFecha
        End Get
        Set(ByVal value As String)
            _OpcionFecha = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaInicio() As Date
        Get
            Return _FechaInicio
        End Get
        Set(ByVal value As Date)
            _FechaInicio = value
        End Set
    End Property
    <DataMember()> _
    Public Property FechaFin() As Date
        Get
            Return _FechaFin
        End Get
        Set(ByVal value As Date)
            _FechaFin = value
        End Set
    End Property

#End Region

#Region "Métodos"

    Sub New()
        FechaInicio = Date.Parse("01/01/1901")
        FechaFin = Date.Parse("01/01/1901")
        OpcionFecha = ""
    End Sub

    Public Function Obtener(ByVal fechas As e_Fechas) As e_Fechas Implements Ie_Fechas.Obtener
        Return fechas
    End Function

#End Region

End Class


