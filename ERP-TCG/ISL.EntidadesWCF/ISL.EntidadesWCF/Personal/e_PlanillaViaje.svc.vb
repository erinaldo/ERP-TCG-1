
<DataContract()>
Public Class e_PlanillaViaje
    Implements Ie_PlanillaViaje

#Region "Propiedad"

    Private _id As String
    Private _idplanillapiloto As New e_PlanillaPiloto
    Private _viaje As New e_Viaje
    Private _copiloto As String
    Private _piloto As String
    Private _idpiloto As String
    Private _montopiloto As Double
    Private _ayudante As String
    Private _montoayudante As Double
    Private _idayudante As String
    Private _idcopiloto As String
    Private _montocopiloto As Double
    Private _ruta As New e_Ruta
    Private _indpago As Boolean
    Private _indvacio As Boolean
    Private _montosolo As Double
    Private _montoacompañado As Double
    Private _porcentajecopiloto As Double
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _activo As Boolean
    Private _tipo As Integer
    Private _bonosolo As Double
    Private _bonocruceropiloto As Double
    Private _bonocrucerocopiloto As Double
    Private _cuentapiloto As Integer
    Private _cuentacopiloto As Integer

    <DataMember()>
    Public TipoOperacion As String
    <DataMember()>
    Public Modificado As Boolean
    <DataMember()>
    Public FechaInicio As Date
    <DataMember()>
    Public FechaFin As Date
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
    Event DatoCambiado()

    <DataMember()>
    Public Property Id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    <DataMember()>
    Public Property IdPlanillaPiloto() As String
        Get
            Return _idplanillapiloto.Id
        End Get
        Set(ByVal value As String)
            _idplanillapiloto.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()>
    Public Property IdViaje() As String
        Get
            Return _viaje.Id
        End Get
        Set(ByVal value As String)
            _viaje.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()>
    Public Property IdPiloto() As String
        Get
            Return _idpiloto
        End Get
        Set(ByVal value As String)
            _idpiloto = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()>
    Public Property Tipo() As Integer
        Get
            Return _tipo
        End Get
        Set(ByVal value As Integer)
            _tipo = value
        End Set
    End Property

    <DataMember()>
    Public Property IndVacio() As Boolean
        Get
            Return _indvacio
        End Get
        Set(ByVal value As Boolean)
            _indvacio = value
        End Set
    End Property

    <DataMember()>
    Public Property Ayudante() As String
        Get
            Return _ayudante
        End Get
        Set(ByVal value As String)
            _ayudante = value
        End Set
    End Property

    <DataMember()>
    Public Property IdAyudante() As String
        Get
            Return _idayudante
        End Get
        Set(ByVal value As String)
            _idayudante = value
        End Set
    End Property

    <DataMember()>
    Public Property CuentaPiloto() As Integer
        Get
            Return _cuentapiloto
        End Get
        Set(ByVal value As Integer)
            _cuentapiloto = value
        End Set
    End Property

    <DataMember()>
    Public Property CuentaCoPiloto() As Integer
        Get
            Return _cuentacopiloto
        End Get
        Set(ByVal value As Integer)
            _cuentacopiloto = value
        End Set
    End Property

    <DataMember()>
    Public Property MontoPiloto() As Double
        Get
            Return _montopiloto
        End Get
        Set(ByVal value As Double)
            _montopiloto = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()>
    Public Property IdCopiloto() As String
        Get
            Return _idcopiloto
        End Get
        Set(ByVal value As String)
            _idcopiloto = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()>
    Public Property MontoCopiloto() As Double
        Get
            Return _montocopiloto
        End Get
        Set(ByVal value As Double)
            _montocopiloto = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()>
    Public Property MontoAyudante() As Double
        Get
            Return _montoayudante
        End Get
        Set(ByVal value As Double)
            _montoayudante = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()>
    Public Property IndPago() As Boolean
        Get
            Return _indpago
        End Get
        Set(ByVal value As Boolean)
            _indpago = value
        End Set
    End Property

    <DataMember()>
    Public Property IdRuta() As String
        Get
            Return _ruta.Id
        End Get
        Set(ByVal value As String)
            _ruta.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()>
    Public Property Origen() As String
        Get
            Return _ruta.Origen
        End Get
        Set(ByVal value As String)
            _ruta.Origen = value
        End Set
    End Property

    <DataMember()>
    Public Property Destino() As String
        Get
            Return _ruta.Destino
        End Get
        Set(ByVal value As String)
            _ruta.Destino = value
        End Set
    End Property

    <DataMember()>
    Public Property Copiloto() As String
        Get
            Return _copiloto
        End Get
        Set(ByVal value As String)
            _copiloto = value
        End Set
    End Property

    <DataMember()>
    Public Property Piloto() As String
        Get
            Return _piloto
        End Get
        Set(ByVal value As String)
            _piloto = value
        End Set
    End Property

    <DataMember()>
    Public Property Viaje() As String
        Get
            Return _viaje.Codigo
        End Get
        Set(ByVal value As String)
            _viaje.Codigo = value
        End Set
    End Property

    <DataMember()>
    Public Property FechaViaje() As Date
        Get
            Return _viaje.Fecha
        End Get
        Set(ByVal value As Date)
            _viaje.Fecha = value
        End Set
    End Property

    <DataMember()>
    Public Property Retorno() As Integer
        Get
            Return _viaje.ViajeRetorno
        End Get
        Set(ByVal value As Integer)
            _viaje.ViajeRetorno = value
        End Set
    End Property

    <DataMember()>
    Public Property Tracto() As String
        Get
            Return _viaje.Tracto
        End Get
        Set(ByVal value As String)
            _viaje.Tracto = value
        End Set
    End Property

    <DataMember()>
    Public Property MontoSolo() As Double
        Get
            Return _montosolo
        End Get
        Set(ByVal value As Double)
            _montosolo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()>
    Public Property MontoAcompañado() As Double
        Get
            Return _montoacompañado
        End Get
        Set(ByVal value As Double)
            _montoacompañado = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()>
    Public Property PorcentajeCopiloto() As Double
        Get
            Return _porcentajecopiloto
        End Get
        Set(ByVal value As Double)
            _porcentajecopiloto = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()>
    Public Property BonoCruceroCopiloto() As Double
        Get
            Return _bonocrucerocopiloto
        End Get
        Set(ByVal value As Double)
            _bonocrucerocopiloto = value
        End Set
    End Property

    <DataMember()>
    Public Property BonoCruceroPiloto() As Double
        Get
            Return _bonocruceropiloto
        End Get
        Set(ByVal value As Double)
            _bonocruceropiloto = value
        End Set
    End Property

    <DataMember()>
    Public Property BonoSolo() As Double
        Get
            Return _bonosolo
        End Get
        Set(ByVal value As Double)
            _bonosolo = value
        End Set
    End Property

    <DataMember()>
    Public Property FechaCreacion() As Date
        Get
            Return _fechacreacion
        End Get
        Set(ByVal value As Date)
            _fechacreacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()>
    Public Property UsuarioCreacion() As String
        Get
            Return _usuariocreacion
        End Get
        Set(ByVal value As String)
            _usuariocreacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()>
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
        Activo = True
        CuentaPiloto = 0
        CuentaCoPiloto = 0
        FechaCreacion = Date.Parse("01/01/1901")
        FechaInicio = Date.Parse("01/01/1901")
        FechaFin = Date.Parse("01/01/1901")
    End Sub

    Public Sub New(ByVal ls_Id As String _
              , ByVal ls_IdPlanillaPiloto As String _
              , ByVal ls_IdViaje As String _
              , ByVal ls_Viaje As String _
              , ByVal ld_FechaViaje As Date _
              , ByVal ls_IdPiloto As String _
              , ByVal ls_Piloto As String _
              , ByVal ln_MontoPiloto As Double _
              , ByVal ls_IdCopiloto As String _
              , ByVal ls_Copiloto As String _
              , ByVal ln_MontoCopiloto As Double _
              , ByVal ls_IdAyudante As String _
              , ByVal ls_Ayudante As String _
              , ByVal ld_MontoAyudante As Double _
              , ByVal ls_IdRuta As String _
              , ByVal lb_IndPago As Boolean _
              , ByVal lb_IndVacio As Boolean _
              , ByVal ld_BonoSolo As Double _
              , ByVal ld_BonoCruceroPiloto As Double _
              , ByVal ld_BonoCruceroCopiloto As Double _
              , ByVal ls_Origen As String _
              , ByVal ls_Destino As String _
              , ByVal ln_MontoSolo As Double _
              , ByVal ln_MontoAcompañado As Double _
              , ByVal ln_PorcentajeCopiloto As Double _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean _
              , ByVal li_Tipo As Integer _
              , ByVal li_CuentaPiloto As Integer _
              , ByVal li_CuentaCoPiloto As Integer _
              , ByVal ls_Tracto As String _
              , ByVal li_Retorno As Integer)
        _id = ls_Id
        _idplanillapiloto.Id = ls_IdPlanillaPiloto
        _viaje.Id = ls_IdViaje
        _viaje.Codigo = ls_Viaje
        _viaje.Fecha = ld_FechaViaje
        _idpiloto = ls_IdPiloto
        _piloto = ls_Piloto
        _montopiloto = ln_MontoPiloto
        _cuentapiloto = li_CuentaPiloto
        _cuentacopiloto = li_CuentaCoPiloto
        _idcopiloto = ls_IdCopiloto
        _copiloto = ls_Copiloto
        _montocopiloto = ln_MontoCopiloto
        _idayudante = ls_IdAyudante
        _ayudante = ls_Ayudante
        _montoayudante = ld_MontoAyudante
        _ruta.Id = ls_IdRuta
        _indpago = lb_IndPago
        _indvacio = lb_IndVacio
        _ruta.Origen = ls_Origen
        _ruta.Destino = ls_Destino
        _bonosolo = ld_BonoSolo
        _bonocruceropiloto = ld_BonoCruceroPiloto
        _bonocrucerocopiloto = ld_BonoCruceroCopiloto
        _montosolo = ln_MontoSolo
        _montoacompañado = ln_MontoAcompañado
        _porcentajecopiloto = ln_PorcentajeCopiloto
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _activo = lb_Activo
        _tipo = li_Tipo
        _viaje.Tracto = ls_Tracto
        _viaje.ViajeRetorno = li_Retorno
    End Sub

#End Region

#Region "Metodos"

    Public Function Obtener(planillaviaje As e_PlanillaViaje) As e_PlanillaViaje Implements Ie_PlanillaViaje.Obtener
        Return planillaviaje
    End Function

#End Region

End Class
