<DataContract()> _
Public Class e_Capacitacion
    Implements Ie_Capacitacion

#Region "Declaracion de Variables"

    Private _id As String
    Private _codigo As String
    Private _nombre As String
    Private _indtipo As Integer
    Private _tipo As String
    Private _idexpositor As String
    Private _expositor As String
    Private _indexpositor As Integer
    Private _fechainicio As Date
    Private _fechafin As Date
    Private _lugar As String
    Private _resumen As String
    Private _idestado As String
    Private _estado As String
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _fechamodifica As Date
    Private _usuariomodifica As String
    Private _activo As Boolean

    <DataMember()> _
    Public Modificado As Boolean = False
    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public leDetalle As New List(Of e_DetalleCapacitacion)
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
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndTipo() As Integer
        Get
            Return _indtipo
        End Get
        Set(ByVal value As Integer)
            _indtipo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Tipo() As String
        Get
            Select Case _indtipo
                Case 1 : _tipo = "CONBTROL ASISTENCIA - CHARLA DE 5 MIN"
                Case 2 : _tipo = "REGISTRO DE CAPACITACION / ENTRENAMIENTO"
                Case 3 : _tipo = "REGISTRO INDUCCION Y REINDUCCION DE SEGURIDAD"
            End Select
            Return _tipo
        End Get
        Set(ByVal value As String)
            _tipo = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdExpositor() As String
        Get
            Return _idexpositor
        End Get
        Set(ByVal value As String)
            _idexpositor = value
        End Set
    End Property

    <DataMember()> _
    Public Property Expositor() As String
        Get
            Return _expositor
        End Get
        Set(ByVal value As String)
            _expositor = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndExpositor() As Integer
        Get
            Return _indexpositor
        End Get
        Set(ByVal value As Integer)
            _indexpositor = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaInicio() As Date
        Get
            Return _fechainicio
        End Get
        Set(ByVal value As Date)
            _fechainicio = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaFin() As Date
        Get
            Return _fechafin
        End Get
        Set(ByVal value As Date)
            _fechafin = value
        End Set
    End Property

    <DataMember()> _
    Public Property Lugar() As String
        Get
            Return _lugar
        End Get
        Set(ByVal value As String)
            _lugar = value
        End Set
    End Property

    <DataMember()> _
    Public Property Resumen() As String
        Get
            Return _resumen
        End Get
        Set(ByVal value As String)
            _resumen = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdEstado() As String
        Get
            Return _idestado
        End Get
        Set(ByVal value As String)
            _idestado = value
        End Set
    End Property

    <DataMember()> _
    Public Property Estado() As String
        Get
            Return _estado
        End Get
        Set(ByVal value As String)
            _estado = value
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

#Region "Contrcutor"

    Public Sub New()
        _id = String.Empty
        _codigo = String.Empty
        _nombre = String.Empty
        _indtipo = 0
        _idexpositor = String.Empty
        _expositor = String.Empty
        _indexpositor = 0
        _fechainicio = #1/1/1901#
        _fechafin = #1/1/1901#
        _lugar = String.Empty
        _resumen = String.Empty
        _idestado = String.Empty
        _estado = String.Empty
        _fechacreacion = #1/1/1901#
        _usuariocreacion = String.Empty
        _fechamodifica = #1/1/1901#
        _usuariomodifica = String.Empty
        _activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_Codigo As String _
              , ByVal ls_Nombre As String _
              , ByVal ln_IndTipo As Integer _
              , ByVal ls_IdExpositor As String _
              , ByVal ls_Expositor As String _
              , ByVal ln_IndExpositor As Integer _
              , ByVal ld_FechaInicio As Date _
              , ByVal ld_FechaFin As Date _
              , ByVal ls_Lugar As String _
              , ByVal ls_Resumen As String _
              , ByVal ls_IdEstado As String _
              , ByVal ls_Estado As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ld_FechaModifica As Date _
              , ByVal ls_UsuarioModifica As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _codigo = ls_Codigo
        _nombre = ls_Nombre
        _indtipo = ln_IndTipo
        _idexpositor = ls_IdExpositor
        _expositor = ls_Expositor
        _indexpositor = ln_IndExpositor
        _fechainicio = ld_FechaInicio
        _fechafin = ld_FechaFin
        _lugar = ls_Lugar
        _resumen = ls_Resumen
        _idestado = ls_IdEstado
        _estado = ls_Estado
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _fechamodifica = ld_FechaModifica
        _usuariomodifica = ls_UsuarioModifica
        _activo = lb_Activo
    End Sub

#End Region

#Region "Metodos"

    Public Function Obtener(capacitacion As e_Capacitacion) As e_Capacitacion Implements Ie_Capacitacion.Obtener
        Return capacitacion
    End Function

#End Region

End Class
