' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_ProcesarTarifasProceso" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_ProcesarTarifasProceso.svc o e_ProcesarTarifasProceso.svc.vb en el Explorador de soluciones e inicie la depuración.
<DataContract()> _
Public Class e_ProcesarTarifasProceso
    Implements Ie_ProcesarTarifasProceso

    'Public Sub DoWork() Implements Ie_ProcesarTarifasProceso.DoWork
    'End Sub
#Region "Propiedad"

    Private _id As String
    Private _idoperacionproceso As String
    Private _codigo As String
    Private _idtracto As String
    Private _tracto As String
    Private _cuentanorte As Double
    Private _cuentasur As Double
    Private _costofijo As Double
    Private _valor As Integer
    Private _semana As Double
    Private _nviaje As Double
    Private _cfxviaje As Double
    Private _norte As Double
    Private _sur As Double
    Private _total As Double
    Private _variablexviaje As Double
    Private _costoviaje As Double
    Private _costoadicional As Double
    Private _adicional01 As Double
    Private _adicional02 As Double
    Private _costototal As Double
    Private _fechainicio As Date
    Private _fechafin As Date
    Private _observacion As String
    Private _usuariocreacion As String
    Private _activo As Boolean
    Private _guardar As String
    Public TipoOperacion As String
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""

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
    Public Property IdOperacionProceso() As String
        Get
            Return _idoperacionproceso
        End Get
        Set(ByVal value As String)
            _idoperacionproceso = value
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
    Public Property IdTracto() As String
        Get
            Return _idtracto
        End Get
        Set(ByVal value As String)
            _idtracto = value
        End Set
    End Property
    <DataMember()> _
    Public Property Tracto() As String
        Get
            Return _tracto
        End Get
        Set(ByVal value As String)
            _tracto = value
        End Set
    End Property
    <DataMember()> _
    Public Property CuentaNorte() As Double
        Get
            Return _cuentanorte
        End Get
        Set(ByVal value As Double)
            _cuentanorte = value
        End Set
    End Property
    <DataMember()> _
    Public Property CuentaSur() As Double
        Get
            Return _cuentasur
        End Get
        Set(ByVal value As Double)
            _cuentasur = value
        End Set
    End Property
    <DataMember()> _
    Public Property CostoFijo() As Double
        Get
            Return _costofijo
        End Get
        Set(ByVal value As Double)
            _costofijo = value
        End Set
    End Property
    <DataMember()> _
    Public Property Valor() As Integer
        Get
            Return _valor
        End Get
        Set(ByVal value As Integer)
            _valor = value
        End Set
    End Property
<DataMember()> _
    Public Property Semana() As Double
        Get
            Return _semana
        End Get
        Set(ByVal value As Double)
            _semana = value
        End Set
    End Property
<DataMember()> _
    Public Property NViaje() As Double
        Get
            Return _nviaje
        End Get
        Set(ByVal value As Double)
            _nviaje = value
        End Set
    End Property
    <DataMember()> _
    Public Property CFxViaje() As Double
        Get
            Return _cfxviaje
        End Get
        Set(ByVal value As Double)
            _cfxviaje = value
        End Set
    End Property
    <DataMember()> _
    Public Property Norte() As Double
        Get
            Return _norte
        End Get
        Set(ByVal value As Double)
            _norte = value
        End Set
    End Property
    <DataMember()> _
    Public Property Sur() As Double
        Get
            Return _sur
        End Get
        Set(ByVal value As Double)
            _sur = value
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
    Public Property VariableXViaje() As Double
        Get
            Return _variablexviaje
        End Get
        Set(ByVal value As Double)
            _variablexviaje = value
        End Set
    End Property
    <DataMember()> _
    Public Property CostoViaje() As Double
        Get
            Return _costoviaje
        End Get
        Set(ByVal value As Double)
            _costoviaje = value
        End Set
    End Property
    <DataMember()> _
    Public Property CostoAdicional() As Double
        Get
            Return _costoadicional
        End Get
        Set(ByVal value As Double)
            _costoadicional = value
        End Set
    End Property
    <DataMember()> _
        Public Property CostoTotal() As Double
        Get
            Return _costototal
        End Get
        Set(ByVal value As Double)
            _costototal = value
        End Set
    End Property
    <DataMember()> _
    Public Property Adicional01() As Double
        Get
            Return _adicional01
        End Get
        Set(ByVal value As Double)
            _adicional01 = value
        End Set
    End Property
    <DataMember()> _
    Public Property Adicional02() As Double
        Get
            Return _adicional02
        End Get
        Set(ByVal value As Double)
            _adicional02 = value
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
    Public Property Observacion() As String
        Get
            Return _observacion
        End Get
        Set(ByVal value As String)
            _observacion = value
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
    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
        End Set
    End Property
    <DataMember()> _
    Public Property Guardar() As String
        Get
            Return _guardar
        End Get
        Set(ByVal value As String)
            _guardar = value
        End Set
    End Property

#End Region
#Region "Constructor"
    Public Sub New()
        TipoOperacion = ""
        Id = ""
        IdOperacionProceso = ""
        Activo = True
    End Sub

    Public Sub New(ByVal ls_Id As String _
              , ByVal ls_IdOperacionProceso As String _
              , ByVal ls_Codigo As String _
              , ByVal ls_IdTracto As String _
              , ByVal ls_Tracto As String _
              , ByVal ln_CuentaNorte As Double _
              , ByVal ln_CuentaSur As Double _
              , ByVal ln_CostoFijo As Double _
        , ByVal li_valor As Integer _
              , ByVal ln_Semana As Double _
              , ByVal ln_NViaje As Double _
              , ByVal ln_CFxViaje As Double _
              , ByVal ln_Norte As Double _
              , ByVal ln_Sur As Double _
              , ByVal ln_Total As Double _
              , ByVal ln_VariableXViaje As Double _
              , ByVal ln_CostoViaje As Double _
         , ByVal ln_CostoAdicional As Double _
              , ByVal ln_CostoTotal As Double _
              , ByVal ln_Adicional01 As Double _
              , ByVal ln_Adicional02 As Double _
              , ByVal ld_FechaInicio As Date _
              , ByVal ld_FechaFin As Date _
              , ByVal ls_Observacion As String _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_Guardar As String)
        _id = ls_Id
        _idoperacionproceso = ls_IdOperacionProceso
        _codigo = ls_Codigo
        _idtracto = ls_IdTracto
        _tracto = ls_Tracto
        _cuentanorte = ln_CuentaNorte
        _cuentasur = ln_CuentaSur
        _costofijo = ln_CostoFijo
        _valor = li_valor
        _semana = ln_Semana
        _nviaje = ln_NViaje
        _cfxviaje = ln_CFxViaje
        _norte = ln_Norte
        _sur = ln_Sur
        _total = ln_Total
        _variablexviaje = ln_VariableXViaje
        _costoviaje = ln_CostoViaje
        _costoadicional = ln_CostoAdicional
        _costototal = ln_CostoTotal
        _adicional01 = ln_Adicional01
        _adicional02 = ln_Adicional02
        _fechainicio = ld_FechaInicio
        _fechafin = ld_FechaFin
        _observacion = ls_Observacion
        _usuariocreacion = ls_UsuarioCreacion
        _activo = lb_Activo
        _guardar = ls_Guardar
    End Sub

#End Region
End Class
