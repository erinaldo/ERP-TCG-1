' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_DetalleUtilidad" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_DetalleUtilidad.svc o e_DetalleUtilidad.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_DetalleUtilidad
    Implements Ie_DetalleUtilidad

#Region "Propiedad"

    Private _id As String
    Private _idutilidad As New e_Utilidad
    Private _periodo As New e_Periodo
    Private _idtrabajador As String
    Private _trabajador As String
    Private _dni As String
    Private _gratificacion As Double
    Private _brutomensual As Double
    Private _ingresos As Double
    Private _indestado As Integer
    Private _estado As String
    Private _diasmes As Integer
    Private _diaslaborados As Integer
    Private _faltas As Integer
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public Año As Integer
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
    Public Property IdUtilidad() As String
        Get
            Return _idutilidad.Id
        End Get
        Set(ByVal value As String)
            _idutilidad.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdPeriodo() As String
        Get
            Return _periodo.Id
        End Get
        Set(ByVal value As String)
            _periodo.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Periodo() As String
        Get
            Return _periodo.Codigo
        End Get
        Set(ByVal value As String)
            _periodo.Codigo = value
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
    Public Property Trabajador() As String
        Get
            Return _trabajador
        End Get
        Set(ByVal value As String)
            _trabajador = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property DNI() As String
        Get
            Return _dni
        End Get
        Set(ByVal value As String)
            _dni = value
        End Set
    End Property


    <DataMember()> _
    Public Property Gratificacion() As Double
        Get
            Return _gratificacion
        End Get
        Set(ByVal value As Double)
            _gratificacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property BrutoMensual() As Double
        Get
            Return _brutomensual
        End Get
        Set(ByVal value As Double)
            _brutomensual = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IndEstado() As Integer
        Get
            Return _indestado
        End Get
        Set(ByVal value As Integer)
            _indestado = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property DiasMes() As Integer
        Get
            Return _diasmes
        End Get
        Set(ByVal value As Integer)
            _diasmes = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Faltas() As Integer
        Get
            Return _faltas
        End Get
        Set(ByVal value As Integer)
            _faltas = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IngresoMensual() As Double
        Get
            _ingresos = _gratificacion + _brutomensual
            Return _ingresos
        End Get
        Set(ByVal value As Double)
            _ingresos = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property DiasLaborados() As Integer
        Get
            Return _diaslaborados
        End Get
        Set(ByVal value As Integer)
            _diaslaborados = value
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
    Public Property Estado() As String
        Get
            Return _estado
        End Get
        Set(ByVal value As String)
            _estado = value
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
        Activo = True
    End Sub

    Public Sub New(ByVal ls_Id As String _
              , ByVal ls_IdUtilidad As String _
              , ByVal ls_IdPeriodo As String _
              , ByVal ls_Periodo As String _
              , ByVal ls_DNI As String _
              , ByVal ls_IdTrabajador As String _
              , ByVal ls_Trabajador As String _
              , ByVal ln_Gratificacion As Double _
              , ByVal ln_BrutoMensual As Double _
              , ByVal ln_IndEstado As Integer _
              , ByVal ls_Estado As String _
              , ByVal ln_DiasMes As Integer _
              , ByVal ln_DiasLaborados As Integer _
              , ByVal ln_Faltas As Integer _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean)
        _id = ls_Id
        _idutilidad.Id = ls_IdUtilidad
        _periodo.Id = ls_IdPeriodo
        _periodo.Codigo = ls_Periodo
        _dni = ls_DNI
        _idtrabajador = ls_IdTrabajador
        _trabajador = ls_Trabajador
        _gratificacion = ln_Gratificacion
        _brutomensual = ln_BrutoMensual
        _indestado = ln_IndEstado
        _estado = ls_Estado
        _diasmes = ln_DiasMes
        _diaslaborados = ln_DiasLaborados
        _faltas = ln_Faltas
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _activo = lb_Activo
    End Sub

#End Region

    Public Function obtener(oeDetalleUtilidad As e_DetalleUtilidad) As e_DetalleUtilidad Implements Ie_DetalleUtilidad.obtener
        Return oeDetalleUtilidad
    End Function

End Class
