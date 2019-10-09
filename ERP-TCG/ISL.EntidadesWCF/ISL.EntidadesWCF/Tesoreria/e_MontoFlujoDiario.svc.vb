


<DataContract()> _
Public Class e_MontoFlujoDiario
    Implements Ie_MontoFlujoDiario

#Region "Declaracion de Variables"

    Private _id As String
    Private _idflujocaja As String
    Private _flujocaja As String
    Private _idtipovehiculo As String
    Private _tipovehiculo As String
    Private _idruta As String
    Private _ruta As String
    Private _monto As Double
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
    Public Event DatoCambiado()

    <DataMember()> _
    Public leMontoFlujoDiarioDet As New List(Of e_MontoFlujoDiario_Det)

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
    Public Property IdFlujoCaja() As String
        Get
            Return _idflujocaja
        End Get
        Set(ByVal value As String)
            _idflujocaja = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FlujoCaja() As String
        Get
            Return _flujocaja
        End Get
        Set(ByVal value As String)
            _flujocaja = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdTipoVehiculo() As String
        Get
            Return _idtipovehiculo
        End Get
        Set(ByVal value As String)
            _idtipovehiculo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property TipoVehiculo() As String
        Get
            Return _tipovehiculo
        End Get
        Set(ByVal value As String)
            _tipovehiculo = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdRuta() As String
        Get
            Return _idruta
        End Get
        Set(ByVal value As String)
            _idruta = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Ruta() As String
        Get
            Return _ruta
        End Get
        Set(ByVal value As String)
            _ruta = value
        End Set
    End Property

    <DataMember()> _
    Public Property Monto() As Double
        Get
            Return _monto
        End Get
        Set(ByVal value As Double)
            _monto = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaCreacion() As Date
        Get
            Return _fechacreacion
        End Get
        Set(ByVal value As Date)
            _fechacreacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioCreacion() As String
        Get
            Return _usuariocreacion
        End Get
        Set(ByVal value As String)
            _usuariocreacion = value
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

#Region "Constructor"

    Public Sub New()
        _id = ""
        _monto = 0
        _fechacreacion = #1/1/1901#
        _usuariocreacion = ""
        _activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdFlujoCaja As String _
              , ByVal ls_FlujoCaja As String _
              , ByVal ls_IdTipoVehiculo As String _
              , ByVal ls_TipoVehiculo As String _
              , ByVal ls_IdRuta As String _
              , ByVal ls_Ruta As String _
              , ByVal ln_Monto As Double _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _idflujocaja = ls_IdFlujoCaja
        _flujocaja = ls_FlujoCaja
        _idtipovehiculo = ls_IdTipoVehiculo
        _tipovehiculo = ls_TipoVehiculo
        _idruta = ls_IdRuta
        _ruta = ls_Ruta
        _monto = ln_Monto
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _activo = lb_Activo
    End Sub

#End Region

    Public Function Obtener(ByVal montoFlujoDiario As e_MontoFlujoDiario) As e_MontoFlujoDiario Implements Ie_MontoFlujoDiario.Obtener
        Return montoFlujoDiario
    End Function

End Class
