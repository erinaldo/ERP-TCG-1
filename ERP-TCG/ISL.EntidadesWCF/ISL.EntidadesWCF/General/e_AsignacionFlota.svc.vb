<DataContract()> _
Public Class e_AsignacionFlota
    Implements Ie_AsignacionFlota

    Public Sub DoWork() Implements Ie_AsignacionFlota.DoWork
    End Sub

#Region "Variables"

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public UsuarioCrea As String
    Private _id As String
    Private _idvehiculo As String
    Private _idflota As String
    Private _observacion As String
    Private _fechainicio As Date
    Private _fechafin As Date
    Private _actual As Boolean
    Private _activo As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
#End Region

#Region "Propiedad"

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
    Public Property IdVehiculo() As String
        Get
            Return _idvehiculo
        End Get
        Set(ByVal value As String)
            _idvehiculo = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdFlota() As String
        Get
            Return _idflota
        End Get
        Set(ByVal value As String)
            _idflota = value
        End Set
    End Property

    <DataMember()> _
    Public Property Observacion() As String
        Get
            Return _observacion
        End Get
        Set(ByVal value As String)
            _observacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaInicio() As Date
        Get
            Return _fechainicio
        End Get
        Set(ByVal value As Date)
            _fechainicio = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaFin() As Date
        Get
            Return _fechafin
        End Get
        Set(ByVal value As Date)
            _fechafin = value
        End Set
    End Property

    <DataMember()> _
    Public Property Actual() As Boolean
        Get
            Return _actual
        End Get
        Set(ByVal value As Boolean)
            _actual = value
        End Set
    End Property

    <DataMember()> _
    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        TipoOperacion = ""
        UsuarioCrea = ""
        Id = ""
        IdVehiculo = ""
        IdFlota = ""
        Observacion = ""
        FechaInicio = #1/1/1901#
        FechaFin = #1/1/1901#
        Actual = False
        Activo = True
    End Sub

    Public Sub New(ByVal ls_Id As String _
                  , ByVal ls_IdVehiculo As String _
                  , ByVal ls_IdFlota As String _
                  , ByVal ls_Observacion As String _
                  , ByVal ld_FechaInicio As Date _
                  , ByVal ld_FechaFin As Date _
                  , ByVal lb_Actual As Boolean _
                  , ByVal lb_Activo As Boolean)
        _id = ls_Id
        _idvehiculo = ls_IdVehiculo
        _idflota = ls_IdFlota
        _observacion = ls_Observacion
        _fechainicio = ld_FechaInicio
        _fechafin = ld_FechaFin
        _actual = lb_Actual
        _activo = lb_Activo
    End Sub

#End Region

    Public Function Obtener(ByVal asignacionflota As e_AsignacionFlota) As e_AsignacionFlota Implements Ie_AsignacionFlota.Obtener
        Return asignacionflota
    End Function

End Class
