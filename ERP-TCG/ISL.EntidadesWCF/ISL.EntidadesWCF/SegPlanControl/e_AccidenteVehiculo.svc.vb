
<DataContract()> _
Public Class e_AccidenteVehiculo
    Implements Ie_AccidenteVehiculo

#Region "Declaración de variables"

    Private _seleccion As Boolean
    Private _id As String
    Private _idAccidente As String
    Private _idvehiculo As String
    Private _vehiculo As String
    Private _propiedadISL As Integer
    Private _detalle As String
    Private _observaciones As String
    Private _activo As Boolean

    <DataMember()> _
    Public Modificado As Boolean = False
    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()>
    Public PrefijoID As String = ""
    Public Event DatoCambiado()

#End Region

#Region "Constructores"

    Public Sub New()

    End Sub


    Public Sub New(ByVal id As String, ByVal idAccidente As String, ByVal placa As String, ByVal propiedadISL As Integer, _
                   ByVal detalle As String, ByVal observaciones As String, ByVal activo As Boolean)
        _id = id
        _idAccidente = idAccidente
        _vehiculo = placa
        _propiedadISL = propiedadISL
        _detalle = detalle
        _observaciones = observaciones
        _activo = activo
    End Sub

#End Region

#Region "Propiedades"

    <DataMember()> _
    Public Property Id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    <DataMember()> _
    Public Property Placa() As String
        Get
            Return _vehiculo
        End Get
        Set(ByVal value As String)
            _vehiculo = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdAccidente() As String
        Get
            Return _idAccidente
        End Get
        Set(ByVal value As String)
            _idAccidente = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdVehiculo() As String
        Get
            Return _idvehiculo
        End Get
        Set(ByVal value As String)
            _idvehiculo = value
        End Set
    End Property


    <DataMember()> _
    Public Property PropiedadISL() As Integer
        Get
            Return _propiedadISL
        End Get
        Set(ByVal value As Integer)
            _propiedadISL = value
        End Set
    End Property

    <DataMember()> _
    Public Property Detalle() As String
        Get
            Return _detalle
        End Get
        Set(ByVal value As String)
            _detalle = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Observacion() As String
        Get
            Return _observaciones
        End Get
        Set(ByVal value As String)
            _observaciones = value

        End Set
    End Property

    <DataMember()> _
    Public Property Seleccion() As Boolean
        Get
            Return _seleccion
        End Get
        Set(ByVal value As Boolean)
            _seleccion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Activo() As Boolean
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

    Public Function Obtener(ByVal accidenteVehiculo As e_AccidenteVehiculo) As e_AccidenteVehiculo Implements Ie_AccidenteVehiculo.Obtener
        Return accidenteVehiculo
    End Function

#End Region

End Class



