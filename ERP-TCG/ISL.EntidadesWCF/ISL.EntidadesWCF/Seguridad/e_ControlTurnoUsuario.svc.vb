
<DataContract()> _
Public Class e_ControlTurnoUsuario
    Implements Ie_ControlTurnoUsuario

#Region "Declaracion de Variables"

    Private _id As String
    Private _idusuario As String
    Private _cierreautomatico As Boolean
    Private _lanzaalerta As Boolean
    Private _tiempoalerta As Integer
    Private _intervalo As Integer
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
    Public Property IdUsuario() As String
        Get
            Return _idusuario
        End Get
        Set(ByVal value As String)
            _idusuario = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CierreAutomatico() As Boolean
        Get
            Return _cierreautomatico
        End Get
        Set(ByVal value As Boolean)
            _cierreautomatico = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property LanzaAlerta() As Boolean
        Get
            Return _lanzaalerta
        End Get
        Set(ByVal value As Boolean)
            _lanzaalerta = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property TiempoAlerta() As Integer
        Get
            Return _tiempoalerta
        End Get
        Set(ByVal value As Integer)
            _tiempoalerta = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Intervalo() As Integer
        Get
            Return _intervalo
        End Get
        Set(ByVal value As Integer)
            _intervalo = value
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
        _usuariocreacion = ""
        TipoOperacion = ""
        _fechacreacion = #1/1/1901#
        _idusuario = ""
        _tiempoalerta = 0
        _intervalo = 0
        _cierreautomatico = False
        _lanzaalerta = False
        _activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdUsuario As String _
              , ByVal lb_CierreAutomatico As Boolean _
              , ByVal lb_LanzaAlerta As Boolean _
              , ByVal ln_TiempoAlerta As Integer _
              , ByVal ln_Intervalo As Integer _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _idusuario = ls_IdUsuario
        _cierreautomatico = lb_CierreAutomatico
        _lanzaalerta = lb_LanzaAlerta
        _tiempoalerta = ln_TiempoAlerta
        _intervalo = ln_Intervalo
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _activo = lb_Activo
    End Sub

#End Region

#Region "Metodos"

    ''' <summary>
    ''' Obtener una entidad de tipo e_ControlTurnoUsuario
    ''' </summary>
    ''' <param name="controlTurnoUsuario"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal controlTurnoUsuario As e_ControlTurnoUsuario) As e_ControlTurnoUsuario Implements Ie_ControlTurnoUsuario.Obtener
        Return controlTurnoUsuario
    End Function

#End Region

End Class
