<DataContract()> _
Public Class e_DetalleCapacitacion
    Implements Ie_DetalleCapacitacion

#Region "Declaracion de Variables"

    Private _id As String
    Private _idcapacitacion As String
    Private _idasistente As String
    Private _asistente As String
    Private _indasistencia As Integer
    Private _observacion As String
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _fechamodifica As Date
    Private _usuariomodifica As String
    Private _activo As Boolean

    <DataMember()> _
    Public Modificado As Boolean = False
    <DataMember()> _
    Public TipoOperacion As String

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
    Public Property IdCapacitacion() As String
        Get
            Return _idcapacitacion
        End Get
        Set(ByVal value As String)
            _idcapacitacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdAsistente() As String
        Get
            Return _idasistente
        End Get
        Set(ByVal value As String)
            _idasistente = value
        End Set
    End Property

    <DataMember()> _
    Public Property Asistente() As String
        Get
            Return _asistente
        End Get
        Set(ByVal value As String)
            _asistente = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndAsistencia() As Integer
        Get
            Return _indasistencia
        End Get
        Set(ByVal value As Integer)
            _indasistencia = value
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

#End Region

#Region "Construtor"

    Public Sub New()
        _id = String.Empty
        _idcapacitacion = String.Empty
        _idasistente = String.Empty
        _asistente = String.Empty
        _indasistencia = 0
        _observacion = String.Empty
        _fechacreacion = #1/1/1901#
        _usuariocreacion = String.Empty
        _fechamodifica = #1/1/1901#
        _usuariomodifica = String.Empty
        _activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdCapacitacion As String _
              , ByVal ls_IdAsistente As String _
              , ByVal ls_Asistente As String _
              , ByVal ln_IndAsistencia As Integer _
              , ByVal ls_Observacion As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ld_FechaModifica As Date _
              , ByVal ls_UsuarioModifica As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _idcapacitacion = ls_IdCapacitacion
        _idasistente = ls_IdAsistente
        _asistente = ls_Asistente
        _indasistencia = ln_IndAsistencia
        _observacion = ls_Observacion
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _fechamodifica = ld_FechaModifica
        _usuariomodifica = ls_UsuarioModifica
        _activo = lb_Activo
    End Sub

#End Region

#Region "Metodos"

    Public Function Obtener(detallecapacitacion As e_DetalleCapacitacion) As e_DetalleCapacitacion Implements Ie_DetalleCapacitacion.Obtener
        Return detallecapacitacion
    End Function

#End Region

End Class
