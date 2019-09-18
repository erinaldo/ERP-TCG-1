<DataContract()> _
Public Class e_MovimientoPeaje
    Implements Ie_MovimientoPeaje

#Region "Declaracion de Variables"

    Private _id As String
    Private _codigo As String
    Private _idempresa As String
    Private _nrotarjeta As String
    Private _idvehiculo As String
    Private _placa As String
    Private _fecha As Date
    Private _iddocumento As String
    Private _serie As String
    Private _numero As String
    Private _monto As Double
    Private _indingresado As Boolean
    Private _idgastooperacion As String
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _fechamodifica As Date
    Private _usuariomodifica As String
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public fechaFin As Date
    <DataMember()> _
    Public fechaInicio As Date
    <DataMember()>
    Public PrefijoID As String = ""

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
    Public Property Codigo() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdEmpresa() As String
        Get
            Return _idempresa
        End Get
        Set(ByVal value As String)
            _idempresa = value
        End Set
    End Property

    <DataMember()> _
    Public Property NroTarjeta() As String
        Get
            Return _nrotarjeta
        End Get
        Set(ByVal value As String)
            _nrotarjeta = value
        End Set
    End Property

    <DataMember()> _
    Public Property Placa() As String
        Get
            Return _placa
        End Get
        Set(ByVal value As String)
            _placa = value
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
    Public Property Fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdDocumento() As String
        Get
            Return _iddocumento
        End Get
        Set(ByVal value As String)
            _iddocumento = value
        End Set
    End Property

    <DataMember()> _
    Public Property Serie() As String
        Get
            Return _serie
        End Get
        Set(ByVal value As String)
            _serie = value
        End Set
    End Property

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
    Public Property Monto() As Double
        Get
            Return _monto
        End Get
        Set(ByVal value As Double)
            _monto = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndIngresado() As Boolean
        Get
            Return _indingresado
        End Get
        Set(ByVal value As Boolean)
            _indingresado = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdGastoOperacion() As String
        Get
            Return _idgastooperacion
        End Get
        Set(ByVal value As String)
            _idgastooperacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaCreacion() As Date
        Get
            Return _fechacreacion
        End Get
        Set(ByVal value As Date)
            _fechacreacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioCreacion() As String
        Get
            Return _usuariocreacion
        End Get
        Set(ByVal value As String)
            _usuariocreacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaModifica() As Date
        Get
            Return _fechamodifica
        End Get
        Set(ByVal value As Date)
            _fechamodifica = value
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioModifica() As String
        Get
            Return _usuariomodifica
        End Get
        Set(ByVal value As String)
            _usuariomodifica = value
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

    Private _empresa As String
    <DataMember()> _
    Public Property Empresa() As String
        Get
            Return _empresa
        End Get
        Set(ByVal value As String)
            _empresa = value
        End Set
    End Property

    Private _viaje As String
    <DataMember()> _
    Public Property Viaje() As String
        Get
            Return _viaje
        End Get
        Set(ByVal value As String)
            _viaje = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        _id = String.Empty
        _idempresa = String.Empty
        _nrotarjeta = String.Empty
        _idvehiculo = String.Empty
        _placa = String.Empty
        _fecha = #1/1/1901#
        _iddocumento = String.Empty
        _serie = String.Empty
        _numero = String.Empty
        _monto = 0
        _indingresado = False
        _idgastooperacion = String.Empty
        _fechacreacion = #1/1/1901#
        _usuariocreacion = String.Empty
        _fechamodifica = #1/1/1901#
        _usuariomodifica = String.Empty
        _activo = True
        fechaInicio = "01/01/1901"
        fechaFin = "01/01/1901"
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_Codigo As String _
              , ByVal ls_IdEmpresa As String _
              , ByVal ls_NroTarjeta As String _
              , ByVal ls_IdVehiculo As String _
              , ByVal ls_Placa As String _
              , ByVal ls_Fecha As Date _
              , ByVal ls_IdDocumento As String _
              , ByVal ls_Serie As String _
              , ByVal ls_Numero As String _
              , ByVal ls_Monto As Double _
              , ByVal ls_IndIngresado As Boolean _
              , ByVal ls_IdGastoOperacion As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ld_FechaModifica As Date _
              , ByVal ls_UsuarioModifica As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _codigo = ls_Codigo
        _idempresa = ls_IdEmpresa
        _nrotarjeta = ls_NroTarjeta
        _idvehiculo = ls_IdVehiculo
        _placa = ls_Placa
        _fecha = ls_Fecha
        _iddocumento = ls_IdDocumento
        _serie = ls_Serie
        _numero = ls_Numero
        _monto = ls_Monto
        _indingresado = ls_IndIngresado
        _idgastooperacion = ls_IdGastoOperacion
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _fechamodifica = ld_FechaModifica
        _usuariomodifica = ls_UsuarioModifica
        _activo = lb_Activo
    End Sub

#End Region

#Region "Metodos"

    Public Function obtener(oePagoAdicional As e_MovimientoPeaje) As e_MovimientoPeaje Implements Ie_MovimientoPeaje.obtener
        Return oePagoAdicional
    End Function

#End Region

End Class
