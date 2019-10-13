' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_ReporteFlujoBanco" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_ReporteFlujoBanco.svc o e_ReporteFlujoBanco.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_ReporteFlujoBanco
    Implements Ie_ReporteFlujoBanco

#Region "Declaracion de Variables"

    Private _id As String
    Private _periodo As New e_Periodo
    Private _movcajabanco As New e_MovimientoCajaBanco
    Private _flujonuevo As New e_FlujoCaja
    Private _ingresoegreso As String
    Private _flujocaja As String
    Private _indfinanciamiento As Boolean
    Private _usuariocreacion As String
    Private _seleccion As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public IdFlujoApoyo As String
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
    Event DatoCambiado()

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
    Public Property IdMovCajaBanco() As String
        Get
            Return _movcajabanco.Id
        End Get
        Set(ByVal value As String)
            _movcajabanco.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Total() As Double
        Get
            Return _movcajabanco.TotalMN
        End Get
        Set(ByVal value As Double)
            _movcajabanco.TotalMN = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Glosa() As String
        Get
            Return _movcajabanco.Glosa
        End Get
        Set(ByVal value As String)
            _movcajabanco.Glosa = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IngresoEgreso() As String
        Get
            Return _ingresoegreso
        End Get
        Set(ByVal value As String)
            _ingresoegreso = value
        End Set
    End Property

    <DataMember()> _
    Public Property Seleccion() As Boolean
        Get
            Return _seleccion
        End Get
        Set(ByVal value As Boolean)
            _seleccion = value
        End Set
    End Property

    <DataMember()> _
    Public Property Fecha() As Date
        Get
            Return _movcajabanco.Fecha
        End Get
        Set(ByVal value As Date)
            _movcajabanco.Fecha = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FlujoCaja() As String
        Get
            Return _flujocaja
        End Get
        Set(ByVal value As String)
            _flujocaja = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdFlujoNuevo() As String
        Get
            Return _flujonuevo.Id
        End Get
        Set(ByVal value As String)
            _flujonuevo.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IndFinanciamiento() As Boolean
        Get
            Return _indfinanciamiento
        End Get
        Set(ByVal value As Boolean)
            _indfinanciamiento = value
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
        TipoOperacion = ""
        IdFlujoNuevo = ""
    End Sub

    Public Sub New(ByVal lb_Seleccion As Boolean _
                   , ByVal ls_Id As String _
              , ByVal ls_IdPeriodo As String _
              , ByVal ls_IdMovCajaBanco As String _
              , ByVal ld_Total As Double _
              , ByVal ls_Glosa As String _
              , ByVal ld_Fecha As Date _
              , ByVal ls_FlujoCaja As String _
              , ByVal ls_IdFlujoNuevo As String _
              , ByVal ls_IngresoEgreso As String _
              , ByVal lb_IndFinanciamiento As Boolean _
              , ByVal ls_UsuarioCreacion As String)
        _id = ls_Id
        _periodo.Id = ls_IdPeriodo
        _movcajabanco.Id = ls_IdMovCajaBanco
        _movcajabanco.TotalMN = ld_Total
        _movcajabanco.Fecha = ld_Fecha
        _movcajabanco.Glosa = ls_Glosa
        _flujocaja = ls_FlujoCaja
        _flujonuevo.Id = ls_IdFlujoNuevo
        IdFlujoApoyo = ls_IdFlujoNuevo
        _ingresoegreso = ls_IngresoEgreso
        _indfinanciamiento = lb_IndFinanciamiento
        _usuariocreacion = ls_UsuarioCreacion
    End Sub

#End Region

#Region "Métodos"

    Public Function Obtener(ByVal ReporteFlujoBanco As e_ReporteFlujoBanco) As e_ReporteFlujoBanco Implements Ie_ReporteFlujoBanco.Obtener
        Return ReporteFlujoBanco
    End Function

#End Region

End Class
