<DataContract()> _
Public Class e_Dispositivo
    Implements Ie_Dispositivo

#Region "Variables"

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    Public Event DatoCambiado()

    Private _id As String
    Private _idtipodispositivo As String
    Private _idvehiculo As String
    Private _nroserie As String
    Private _cantidad As Double
    Private _fechainicio As Date
    Private _fechaultimaact As Date
    Private _activo As Boolean
    Private _actual As Boolean

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
    Public Property IdTipoDispositivo() As String
        Get
            Return _idtipodispositivo
        End Get
        Set(ByVal value As String)
            _idtipodispositivo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdVehiculo() As String
        Get
            Return _idvehiculo
        End Get
        Set(ByVal value As String)
            _idvehiculo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property NroSerie() As String
        Get
            Return _nroserie
        End Get
        Set(ByVal value As String)
            _nroserie = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Cantidad() As Double
        Get
            Return _cantidad
        End Get
        Set(ByVal value As Double)
            _cantidad = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaInicio() As Date
        Get
            Return _fechainicio
        End Get
        Set(ByVal value As Date)
            _fechainicio = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaUltimaAct() As Date
        Get
            Return _fechaultimaact
        End Get
        Set(ByVal value As Date)
            _fechaultimaact = value
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

    <DataMember()> _
    Public Property Actual() As Boolean
        Get
            Return _actual
        End Get
        Set(ByVal value As Boolean)
            _actual = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        TipoOperacion = ""
        Modificado = False
        Id = ""
        IdTipoDispositivo = ""
        IdVehiculo = ""
        NroSerie = ""
        Cantidad = 0.0
        FechaInicio = #1/1/1901#
        FechaUltimaAct = #1/1/1901#
        Actual = False
        Activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdTipoDispositivo As String _
              , ByVal ls_IdVehiculo As String _
              , ByVal ls_NroSerie As String _
              , ByVal ln_Cantidad As Double _
              , ByVal ld_FechaInicio As Date _
              , ByVal ld_FechaUltimaAct As Date _
              , ByVal lb_Activo As Boolean _
              , ByVal lb_Actual As Boolean _
           )
        _id = ls_Id
        _idtipodispositivo = ls_IdTipoDispositivo
        _idvehiculo = ls_IdVehiculo
        _nroserie = ls_NroSerie
        _cantidad = ln_Cantidad
        _fechainicio = ld_FechaInicio
        _fechaultimaact = ld_FechaUltimaAct
        _activo = lb_Activo
        _actual = lb_Actual
    End Sub

#End Region

    Public Function Obtener(ByVal dispositivo As e_Dispositivo) As e_Dispositivo Implements Ie_Dispositivo.Obtener
        Return dispositivo
    End Function

End Class


