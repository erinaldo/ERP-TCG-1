' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_Horarios" en el código, en svc y en el archivo de configuración a la vez.
Public Class e_Horarios
    Implements Ie_Horarios

#Region "Propiedad"

    Private _id As String
    Private _tipohorario As New e_TipoHorario
    Private _horainicio As Date
    Private _horafin As Date
    Private _lunes As Boolean
    Private _martes As Boolean
    Private _miercoles As Boolean
    Private _jueves As Boolean
    Private _viernes As Boolean
    Private _sabado As Boolean
    Private _domingo As Boolean
    Private _vigente As Boolean
    Private _activo As Boolean
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _indhoraextra As Boolean

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
    Public Property TipoHorario() As String
        Get
            Return _tipohorario.Nombre
        End Get
        Set(ByVal value As String)
            _tipohorario.Nombre = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IndHoraExtra() As Boolean
        Get
            Return _indhoraextra
        End Get
        Set(ByVal value As Boolean)
            _indhoraextra = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdTipoHorario() As String
        Get
            Return _tipohorario.Id
        End Get
        Set(ByVal value As String)
            _tipohorario.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property HoraInicio() As Date
        Get
            Return _horainicio
        End Get
        Set(ByVal value As Date)
            _horainicio = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property HoraFin() As Date
        Get
            Return _horafin
        End Get
        Set(ByVal value As Date)
            _horafin = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Lunes() As Boolean
        Get
            Return _lunes
        End Get
        Set(ByVal value As Boolean)
            _lunes = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Martes() As Boolean
        Get
            Return _martes
        End Get
        Set(ByVal value As Boolean)
            _martes = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Miercoles() As Boolean
        Get
            Return _miercoles
        End Get
        Set(ByVal value As Boolean)
            _miercoles = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Jueves() As Boolean
        Get
            Return _jueves
        End Get
        Set(ByVal value As Boolean)
            _jueves = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Viernes() As Boolean
        Get
            Return _viernes
        End Get
        Set(ByVal value As Boolean)
            _viernes = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Sabado() As Boolean
        Get
            Return _sabado
        End Get
        Set(ByVal value As Boolean)
            _sabado = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Domingo() As Boolean
        Get
            Return _domingo
        End Get
        Set(ByVal value As Boolean)
            _domingo = value
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
        Vigente = True
        Activo = True
        Lunes = False
        Martes = False
        Miercoles = False
        Jueves = False
        Viernes = False
        Sabado = False
        Domingo = False
        IndHoraExtra = False
        FechaCreacion = Date.Parse("01/01/1901")
        HoraInicio = Date.Parse("01/01/1901")
        HoraFin = Date.Parse("01/01/1901")
    End Sub

    Public Sub New(ByVal ls_Id As String _
              , ByVal ls_IdTipoHorario As String _
              , ByVal ls_TipoHorario As String _
              , ByVal ld_HoraInicio As Date _
              , ByVal ld_HoraFin As Date _
              , ByVal lb_Lunes As Boolean _
              , ByVal lb_Martes As Boolean _
              , ByVal lb_Miercoles As Boolean _
              , ByVal lb_Jueves As Boolean _
              , ByVal lb_Viernes As Boolean _
              , ByVal lb_Sabado As Boolean _
              , ByVal lb_Domingo As Boolean _
              , ByVal lb_Vigente As Boolean _
              , ByVal lb_IndHoraExtra As Boolean _
              , ByVal lb_Activo As Boolean _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
           )
        _id = ls_Id
        _tipohorario.Id = ls_IdTipoHorario
        _tipohorario.Nombre = ls_TipoHorario
        _horainicio = ld_HoraInicio
        _horafin = ld_HoraFin
        _lunes = lb_Lunes
        _martes = lb_Martes
        _miercoles = lb_Miercoles
        _jueves = lb_Jueves
        _viernes = lb_Viernes
        _sabado = lb_Sabado
        _domingo = lb_Domingo
        _vigente = lb_Vigente
        _activo = lb_Activo
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
    End Sub

#End Region

    Public Function Obtener(ByVal horarios As e_Horarios) As e_Horarios Implements Ie_Horarios.Obtener
        Return horarios
    End Function

End Class
