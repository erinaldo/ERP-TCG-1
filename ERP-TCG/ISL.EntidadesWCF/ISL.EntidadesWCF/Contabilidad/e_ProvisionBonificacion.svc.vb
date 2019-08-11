<DataContract()> _
Public Class e_ProvisionBonificacion
    Implements Ie_ProvisionBonificacion

#Region "Declaracion de Variables"

    Private _IdTrabajador As String
    Private _Dni As String
    Private _Trabajador As String
    Private _Ocupacion As String
    Private _CentroCosto As String
    Private _Remuneracion As Double
    Private _AsignacionFamiliar As Double
    Private _FechaIngreso As Date
    Private _FechaCese As Date
    Private _RemuneracionFija As Double
    Private _Gratificacion As Double
    Private _CostoComputable As Double
    Private _Dias As Double
    Private _Importe As Double

#End Region

#Region "Propiedades"

    <DataMember()> _
    Public Property IdTrabajador() As String
        Get
            Return _IdTrabajador
        End Get
        Set(value As String)
            _IdTrabajador = value
        End Set
    End Property

    <DataMember()> _
    Public Property Dni() As String
        Get
            Return _Dni
        End Get
        Set(value As String)
            _Dni = value
        End Set
    End Property

    <DataMember()> _
    Public Property Trabajador() As String
        Get
            Return _Trabajador
        End Get
        Set(value As String)
            _Trabajador = value
        End Set
    End Property

    <DataMember()> _
    Public Property Ocupacion() As String
        Get
            Return _Ocupacion
        End Get
        Set(value As String)
            _Ocupacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property CentroCosto() As String
        Get
            Return _CentroCosto
        End Get
        Set(value As String)
            _CentroCosto = value
        End Set
    End Property

    <DataMember()> _
    Public Property Remuneracion() As Double
        Get
            Return _Remuneracion
        End Get
        Set(value As Double)
            _Remuneracion = value
        End Set
    End Property

    <DataMember()> _
    Public Property AsignacionFamiliar() As Double
        Get
            Return _AsignacionFamiliar
        End Get
        Set(value As Double)
            _AsignacionFamiliar = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaIngreso() As Date
        Get
            Return _FechaIngreso
        End Get
        Set(value As Date)
            _FechaIngreso = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaCese() As Date
        Get
            Return _FechaCese
        End Get
        Set(value As Date)
            _FechaCese = value
        End Set
    End Property

    <DataMember()> _
    Public Property RemuneracionFija() As Double
        Get
            Return _RemuneracionFija
        End Get
        Set(value As Double)
            _RemuneracionFija = value
        End Set
    End Property

    <DataMember()> _
    Public Property Gratificacion() As Double
        Get
            Return _Gratificacion
        End Get
        Set(value As Double)
            _Gratificacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property CostoComputable() As Double
        Get
            Return _CostoComputable
        End Get
        Set(value As Double)
            _CostoComputable = value
        End Set
    End Property

    <DataMember()> _
    Public Property Dias() As Double
        Get
            Return _Dias
        End Get
        Set(value As Double)
            _Dias = value
        End Set
    End Property

    <DataMember()> _
    Public Property Importe() As Double
        Get
            Return _Importe
        End Get
        Set(value As Double)
            _Importe = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        _IdTrabajador = String.Empty
        _Dni = String.Empty
        _Trabajador = String.Empty
        _Ocupacion = String.Empty
        _CentroCosto = String.Empty
        _Remuneracion = 0
        _AsignacionFamiliar = 0
        _FechaIngreso = #1/1/1901#
        _FechaCese = #1/1/1901#

    End Sub


#End Region

#Region "Metodos"

    Public Function Obtener(provisionbonificacion As e_ProvisionBonificacion) As e_ProvisionBonificacion Implements Ie_ProvisionBonificacion.Obtener
        Return provisionbonificacion
    End Function

#End Region


    
End Class
