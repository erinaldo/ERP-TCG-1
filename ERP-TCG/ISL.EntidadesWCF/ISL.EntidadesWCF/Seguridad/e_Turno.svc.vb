
<DataContract()> _
Public Class e_Turno
    Implements Ie_Turno

#Region "Declaracion de Variables"

    Private _id As String
    Private _horainicio As String
    Private _horasalida As String
    Private _dia As String
    Private _turno As String
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean

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
    Public Property HoraInicio() As String
        Get
            Return _horainicio
        End Get
        Set(ByVal value As String)
            _horainicio = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property HoraSalida() As String
        Get
            Return _horasalida
        End Get
        Set(ByVal value As String)
            _horasalida = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Dia() As String
        Get
            Return _dia
        End Get
        Set(ByVal value As String)
            _dia = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Turno() As String
        Get
            Return _turno
        End Get
        Set(ByVal value As String)
            _turno = value
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
        TipoOperacion = ""
        _id = ""
        _horainicio = "00:00:00"
        _horasalida = "00:00:00"
        _dia = ""
        _turno = ""
        _activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal HoraInicio As String _
              , ByVal HoraSalida As String _
              , ByVal ls_Dia As String _
              , ByVal ls_Turno As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _horainicio = HoraInicio
        _horasalida = HoraSalida
        _dia = ls_Dia
        _turno = ls_Turno
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _activo = lb_Activo
    End Sub

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Obtener una entidad de tipo e_Turno
    ''' </summary>
    ''' <param name="turno"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal turno As e_Turno) As e_Turno Implements Ie_Turno.Obtener
        Return turno
    End Function

#End Region

End Class
