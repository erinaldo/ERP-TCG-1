<DataContract()> _
Public Class e_GPS
    Implements Ie_GPS

#Region "Declaración de variables"

#End Region

#Region "Propiedades"

    Private _placa As String
    Public Property Placa() As String
        Get
            Return _placa
        End Get
        Set(ByVal value As String)
            _placa = value
        End Set
    End Property

    Private _latitud As Double
    Public Property Latitud() As Double
        Get
            Return _latitud
        End Get
        Set(ByVal value As Double)
            _latitud = value
        End Set
    End Property

    Private _longitud As Double
    Public Property Longitud() As Double
        Get
            Return _longitud
        End Get
        Set(ByVal value As Double)
            _longitud = value
        End Set
    End Property

    Private _curso As Integer
    Public Property Curso() As Integer
        Get
            Return _curso
        End Get
        Set(ByVal value As Integer)
            _curso = value
        End Set
    End Property

    Private _velocidad As Double
    Public Property Velocidad() As Double
        Get
            Return _velocidad
        End Get
        Set(ByVal value As Double)
            _velocidad = value
        End Set
    End Property

    Private _odometro As String
    Public Property Odometro() As String
        Get
            Return _odometro
        End Get
        Set(ByVal value As String)
            _odometro = value
        End Set
    End Property

    Private _lugar As String
    Public Property Lugar() As String
        Get
            Return _lugar
        End Get
        Set(ByVal value As String)
            _lugar = value
        End Set
    End Property

    Private _fecha As Date
    Public Property Fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
        End Set
    End Property

    Private _encendido As Boolean
    Public Property Encendido() As Boolean
        Get
            Return _encendido
        End Get
        Set(ByVal value As Boolean)
            _encendido = value
        End Set
    End Property

    Private _puerta As Boolean
    Public Property Puerta() As Boolean
        Get
            Return _puerta
        End Get
        Set(ByVal value As Boolean)
            _puerta = value
        End Set
    End Property

    Private _panico As Boolean
    Public Property Panico() As Boolean
        Get
            Return _panico
        End Get
        Set(ByVal value As Boolean)
            _panico = value
        End Set
    End Property

#End Region

#Region "Métodos"

    Public Function Obtener(ByVal gps As e_GPS) As e_GPS Implements Ie_GPS.Obtener
        Return gps
    End Function

#End Region

End Class
