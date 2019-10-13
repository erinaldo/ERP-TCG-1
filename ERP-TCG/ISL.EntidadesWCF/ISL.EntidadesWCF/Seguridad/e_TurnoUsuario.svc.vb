
<DataContract()> _
Public Class e_TurnoUsuario
    Implements Ie_TurnoUsuario
    Implements IEquatable(Of e_TurnoUsuario)

#Region "Declaracion de Variables"

    Private _id As String
    Private _idturno As String
    Private _idusuario As String
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _activo As Boolean

    Private _horainicio As String
    Private _horasalida As String
    Private _dia As String
    Private _turno As String

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
    Public Property IdTurno() As String
        Get
            Return _idturno
        End Get
        Set(ByVal value As String)
            _idturno = value
            RaiseEvent DatoCambiado()
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

    <DataMember()> _
    Public Property HoraInicio() As String
        Get
            Return _horainicio
        End Get
        Set(ByVal value As String)
            _horainicio = value
        End Set
    End Property

    <DataMember()> _
    Public Property HoraSalida() As String
        Get
            Return _horasalida
        End Get
        Set(ByVal value As String)
            _horasalida = value
        End Set
    End Property

    <DataMember()> _
    Public Property Dia() As String
        Get
            Return _dia
        End Get
        Set(ByVal value As String)
            _dia = value
        End Set
    End Property

    <DataMember()> _
    Public Property Turno() As String
        Get
            Return _turno
        End Get
        Set(ByVal value As String)
            _turno = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        TipoOperacion = ""
        _id = ""
        _fechacreacion = #1/1/1901#
        _usuariocreacion = ""
        _horainicio = "00:00:00"
        _horasalida = "00:00:00"
        _dia = ""
        _turno = ""
        _activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdTurno As String _
              , ByVal ls_IdUsuario As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_HoraInicio As String _
              , ByVal ls_HoraSalida As String _
              , ByVal ls_Dia As String _
              , ByVal ls_Turno As String _
           )
        _id = ls_Id
        _idturno = ls_IdTurno
        _idusuario = ls_IdUsuario
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _horainicio = ls_HoraInicio
        _horasalida = ls_HoraSalida
        _dia = ls_Dia
        _turno = ls_Turno
        _activo = lb_Activo
    End Sub

#End Region

#Region "Metodos"

    Public Overloads Function Equals(ByVal oeTurnoUsuario As e_TurnoUsuario) _
    As Boolean Implements System.IEquatable(Of e_TurnoUsuario).Equals
        If Me.IdTurno = oeTurnoUsuario.IdTurno Then
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Obtener una entidad de tipo e_TurnoUsuario
    ''' </summary>
    ''' <param name="turnoUsuario"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal turnoUsuario As e_TurnoUsuario) As e_TurnoUsuario Implements Ie_TurnoUsuario.Obtener
        Return turnoUsuario
    End Function

#End Region

End Class
