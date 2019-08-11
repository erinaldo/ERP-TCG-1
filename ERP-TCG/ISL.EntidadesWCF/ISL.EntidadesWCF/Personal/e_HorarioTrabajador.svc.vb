' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_HorarioTrabajador" en el código, en svc y en el archivo de configuración a la vez.
Public Class e_HorarioTrabajador
    Implements Ie_HorarioTrabajador

#Region "Propiedad"


    Private _id As String
    Private _idtrabajador As String
    Private _horario As New e_Horarios
    Private _nombrehorario As String
    Private _fechainicio As Date
    Private _fechafin As Date
    Private _vigente As Boolean
    Private _glosa As String
    Private _activo As Boolean
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    
    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean

    Event DatoCambiado()

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
    Public Property IdHorario() As String
        Get
            Return _horario.Id
        End Get
        Set(ByVal value As String)
            _horario.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property HoraInicio() As Date
        Get
            Return _horario.HoraInicio
        End Get
        Set(ByVal value As Date)
            _horario.HoraInicio = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property HoraFin() As Date
        Get
            Return _horario.HoraFin
        End Get
        Set(ByVal value As Date)
            _horario.HoraFin = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdTrabajador() As String
        Get
            Return _idtrabajador
        End Get
        Set(ByVal value As String)
            _idtrabajador = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Horario() As String
        Get
            Return _nombrehorario
        End Get
        Set(ByVal value As String)
            _nombrehorario = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Vigente() As Boolean
        Get
            Return _vigente
        End Get
        Set(ByVal value As Boolean)
            _vigente = value
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
    Public Property FechaFin() As Date
        Get
            Return _fechafin
        End Get
        Set(ByVal value As Date)
            _fechafin = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Property Glosa() As String
        Get
            Return _glosa
        End Get
        Set(ByVal value As String)
            _glosa = value
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

#End Region

#Region "Constructor"

    Public Sub New()
        Activo = True
        FechaCreacion = Date.Parse("01/01/1901")
        FechaFin = Date.Parse("01/01/1901")
        FechaInicio = Date.Parse("01/01/1901")
        Vigente = True
    End Sub

    Public Sub New(ByVal ls_Id As String _
              , ByVal ls_IdTrabajador As String _
              , ByVal ls_IdHorario As String _
              , ByVal ls_Horario As String _
              , ByVal lb_Vigente As Boolean _
              , ByVal ls_Glosa As String _
              , ByVal ld_FechaInicio As Date _
              , ByVal ld_FechaFin As Date _
              , ByVal ld_HoraInicio As Date _
              , ByVal ld_HoraFin As Date _
              , ByVal lb_Activo As Boolean _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String)
        _id = ls_Id
        _idtrabajador = ls_IdTrabajador
        _horario.Id = ls_IdHorario
        _nombrehorario = ls_Horario
        _vigente = lb_Vigente
        _fechainicio = ld_FechaInicio
        _fechafin = ld_FechaFin
        _horario.HoraFin = ld_HoraFin
        _horario.HoraInicio = ld_HoraInicio
        _glosa = ls_Glosa
        _activo = lb_Activo
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
    End Sub

#End Region

    Public Function Obtener(ByVal horariotrabajador As e_HorarioTrabajador) As e_HorarioTrabajador Implements Ie_HorarioTrabajador.Obtener
        Return horariotrabajador
    End Function

End Class
