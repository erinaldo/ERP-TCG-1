

<DataContract()> _
Public Class e_TiempoCiclo
    Implements Ie_TiempoCiclo

#Region "Propiedad"

    Private _id As String
    Private _idruta As String
    Private _idtipovehiculo As String
    Private _idcliente As String
    Private _horascarga As Double
    Private _horastraslado As Double
    Private _horasdescarga As Double
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Private Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
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
    Public Property IdRuta() As String
        Get
            Return _idruta
        End Get
        Set(ByVal value As String)
            _idruta = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoVehiculo() As String
        Get
            Return _idtipovehiculo
        End Get
        Set(ByVal value As String)
            _idtipovehiculo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Cliente() As String
        Get
            Return _idcliente
        End Get
        Set(ByVal value As String)
            _idcliente = value
        End Set
    End Property

    <DataMember()> _
    Public Property HorasCarga() As Double
        Get
            Return _horascarga
        End Get
        Set(ByVal value As Double)
            _horascarga = value
        End Set
    End Property

    <DataMember()> _
    Public Property HorasTraslado() As Double
        Get
            Return _horastraslado
        End Get
        Set(ByVal value As Double)
            _horastraslado = value
        End Set
    End Property

    <DataMember()> _
    Public Property HorasDescarga() As Double
        Get
            Return _horasdescarga
        End Get
        Set(ByVal value As Double)
            _horasdescarga = value
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
        Id = ""
        IdRuta = ""
        Activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdRuta As String _
              , ByVal ls_IdTipoVehiculo As String _
              , ByVal ls_IdCliente As String _
              , ByVal ln_HorasCarga As Double _
              , ByVal ln_HorasTraslado As Double _
              , ByVal ln_HorasDescarga As Double _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _idruta = ls_IdRuta
        _idtipovehiculo = ls_IdTipoVehiculo
        _idcliente = ls_IdCliente
        _horascarga = ln_HorasCarga
        _horastraslado = ln_HorasTraslado
        _horasdescarga = ln_HorasDescarga
        _activo = lb_Activo
    End Sub

#End Region

    Public Function Obtener(ByVal tiempoCiclo As e_TiempoCiclo) As e_TiempoCiclo Implements Ie_TiempoCiclo.Obtener
        Return tiempoCiclo
    End Function

End Class


