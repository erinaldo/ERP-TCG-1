<DataContract()> _
Public Class e_Surtidor
    Implements Ie_Surtidor


#Region "Declaración de variables"
    Private _numero As String
    Private _cara As Integer
    Private _manguera As Integer
    Private _galones As Double
    Private _fecha As DateTime
    <DataMember()> _
        Public TipoOperacion As String
#End Region

#Region "Propiedades"

    <DataMember()> _
    Public Property Numero() As String
        Get
            Return _numero
        End Get
        Set(ByVal value As String)
            _numero = value
        End Set
    End Property

    <DataMember()> _
    Public Property Cara() As Integer
        Get
            Return _cara
        End Get
        Set(ByVal value As Integer)
            _cara = value
        End Set
    End Property

    <DataMember()> _
    Public Property Manguera() As Integer
        Get
            Return _manguera
        End Get
        Set(ByVal value As Integer)
            _manguera = value
        End Set
    End Property

    <DataMember()> _
    Public Property Galones() As Double
        Get
            Return _galones
        End Get
        Set(ByVal value As Double)
            _galones = value
        End Set
    End Property

    <DataMember()> _
    Public Property Fecha() As DateTime
        Get
            Return _fecha
        End Get
        Set(ByVal value As DateTime)
            _fecha = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Sub New()
        TipoOperacion = ""
    End Sub

    Sub New( _
              ByVal Numero As String, _
              ByVal Cara As Integer, _
              ByVal Manguera As Integer, _
              ByVal Galones As Double, _
              ByVal Fecha As DateTime _
             )
        _numero = Numero
        _cara = Cara
        _manguera = Manguera
        _galones = Galones
        _fecha = Fecha
    End Sub
#End Region

    Public Function Obtener(ByVal surtidor As e_Surtidor) As e_Surtidor Implements Ie_Surtidor.Obtener
        Return surtidor
    End Function

End Class
