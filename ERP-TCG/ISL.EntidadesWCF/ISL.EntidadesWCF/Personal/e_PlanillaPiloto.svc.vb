' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_PlanillaPiloto" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_PlanillaPiloto.svc o e_PlanillaPiloto.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_PlanillaPiloto
    Implements Ie_PlanillaPiloto

#Region "Propiedad"

    Private _id As String
    Private _descripcion As String
    Private _codigo As String
    Private _estado As New e_Estado
    Private _planilla As New e_Planilla
    Private _fechainicio As Date
    Private _fechafin As Date
    Private _fecha As Date
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _total As Double
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public listaPlanillaPiloto As New List(Of e_PlanillaPilotoDet)
    <DataMember()>
    Public PrefijoID As String = ""
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
    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdPlanilla() As String
        Get
            Return _planilla.Id
        End Get
        Set(ByVal value As String)
            _planilla.Id = value
            RaiseEvent DatoCambiado()
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
    Public Property Planilla() As String
        Get
            Return _planilla.Codigo
        End Get
        Set(ByVal value As String)
            _planilla.Codigo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdEstado() As String
        Get
            Return _estado.Id
        End Get
        Set(ByVal value As String)
            _estado.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Estado() As String
        Get
            Return _estado.Nombre
        End Get
        Set(ByVal value As String)
            _estado.Nombre = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Total() As Double
        Get
            Return _total
        End Get
        Set(ByVal value As Double)
            _total = value
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
    Public Property Fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
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
        Id = String.Empty
        TipoOperacion = ""
        Activo = True
        Fecha = Date.Parse("01/01/1901")
        FechaInicio = Date.Parse("01/01/1901")
        FechaFin = Date.Parse("01/01/1901")
        FechaCreacion = Date.Parse("01/01/1901")
        IdPlanilla = String.Empty
    End Sub

    Public Sub New(ByVal ls_Id As String _
              , ByVal ls_Descripcion As String _
              , ByVal ls_Codigo As String _
              , ByVal ls_IdPlanilla As String _
              , ByVal ls_Planilla As String _
              , ByVal ls_IdEstado As String _
              , ByVal ls_Estado As String _
              , ByVal ld_Total As Double _
              , ByVal ld_FechaInicio As Date _
              , ByVal ld_FechaFin As Date _
              , ByVal ld_Fecha As Date _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean)
        _id = ls_Id
        _descripcion = ls_Descripcion
        _codigo = ls_Codigo
        _planilla.Id = ls_IdPlanilla
        _planilla.Codigo = ls_Planilla
        _estado.Id = ls_IdEstado
        _estado.Nombre = ls_Estado
        _total = ld_Total
        _fechainicio = ld_FechaInicio
        _fechafin = ld_FechaFin
        _fecha = ld_Fecha
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _activo = lb_Activo
    End Sub

#End Region

    Public Function Obtener(planillapiloto As e_PlanillaPiloto) As e_PlanillaPiloto Implements Ie_PlanillaPiloto.Obtener
        Return planillapiloto
    End Function

End Class
