' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_LiquidacionPersonal" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_LiquidacionPersonal.svc o e_LiquidacionPersonal.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_LiquidacionTrabajador
    Implements Ie_LiquidacionTrabajador

#Region "Propiedad"

    Private _id As String
    Private _codigo As String
    Private _fechaingreso As Date
    Private _fechacese As Date
    Private _idtrabajador As String
    Private _trabajador As String
    Private _ocupacion As New e_Ocupacion
    Private _motivocese As New e_MotivoCese
    Private _estado As New e_Estado
    Private _remuneracionbasica As Double
    Private _asigfamiliar As Double
    Private _promboniprod As Double
    Private _promhorasextras As Double
    Private _promgratificacion As Double
    Private _ctsm As Integer
    Private _ctsd As Integer
    Private _ctsxm As Double
    Private _ctsxd As Double
    Private _vta As Integer
    Private _vtm As Integer
    Private _vtd As Integer
    Private _vtdgozadas As Integer
    Private _vtxa As Double
    Private _vtxm As Double
    Private _vtxd As Double
    Private _vtgozadas As Double
    Private _vtxdescuentoafp As Double
    Private _gtm As Integer
    Private _gtd As Integer
    Private _gtxm As Double
    Private _gtxd As Double
    Private _boniextra As Double
    Private _cantidadgraciosa As Double
    Private _dt As Integer
    Private _dtxd As Double
    Private _dtasigfam As Double
    Private _dtessaludvida As Double
    Private _dtdsctoafp As Double
    Private _dtdsctoeps As Double
    Private _adelantosueldo As Double
    Private _dev5tacat As Double
    Private _totalpagar As Double
    Private _porcentajeafp As Double
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _activo As Boolean
    Private _fecha As Date
    Private _fechainiciocts As Date
    Private _fechainiciovt As Date
    Private _fechainiciogt As Date
    Private _fechainicioDT As Date

    Private _ctsf As Integer
    Private _ctsxf As Double
    Private _vtf As Integer
    Private _vtxf As Double
    Private _gtf As Integer
    Private _gtxf As Double
    Private _dtf As Integer
    Private _dtxf As Double
    Private _descuento As Double
    Private _retencion5ta As Double
    Private _aporteessalud As Double

    'AGREGADOS
    Private _tptexto As String
    Private _dni As String
    Private _fcdt As String
    Private _fcvt As String
    Private _fcgt As String
    Private _fccts As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public oeAsientoModelo As New e_AsientoModelo
    <DataMember()> _
    Public IdPeriodo As String = ""
    <DataMember()> _
    Public TipoCambio As Double = 0.0
    <DataMember()> _
    Public loPlacas As New List(Of e_Combo)
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
    Public Property Codigo() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaIngreso() As Date
        Get
            Return _fechaingreso
        End Get
        Set(ByVal value As Date)
            _fechaingreso = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaCese() As Date
        Get
            Return _fechacese
        End Get
        Set(ByVal value As Date)
            _fechacese = value
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
    Public Property TotalPagarTexto() As String
        Get
            Return _tptexto
        End Get
        Set(ByVal value As String)
            _tptexto = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdMotivoCese() As String
        Get
            Return _motivocese.Id
        End Get
        Set(ByVal value As String)
            _motivocese.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property VTDGozadas() As Integer
        Get
            Return _vtdgozadas
        End Get
        Set(ByVal value As Integer)
            _vtdgozadas = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property MotivoCese() As String
        Get
            Return _motivocese.Nombre
        End Get
        Set(ByVal value As String)
            _motivocese.Nombre = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdOcupacion() As String
        Get
            Return _ocupacion.Id
        End Get
        Set(ByVal value As String)
            _ocupacion.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Ocupacion() As String
        Get
            Return _ocupacion.Nombre
        End Get
        Set(ByVal value As String)
            _ocupacion.Nombre = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property RemuneracionBasica() As Double
        Get
            Return _remuneracionbasica
        End Get
        Set(ByVal value As Double)
            _remuneracionbasica = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property PromGratificacion() As Double
        Get
            Return _promgratificacion
        End Get
        Set(ByVal value As Double)
            _promgratificacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property PromHorasExtras() As Double
        Get
            Return _promhorasextras
        End Get
        Set(ByVal value As Double)
            _promhorasextras = value
        End Set
    End Property

    <DataMember()> _
    Public Property PromBoniProd() As Double
        Get
            Return _promboniprod
        End Get
        Set(ByVal value As Double)
            _promboniprod = value
        End Set
    End Property

    <DataMember()> _
    Public Property AsigFamiliar() As Double
        Get
            Return _asigfamiliar
        End Get
        Set(ByVal value As Double)
            _asigfamiliar = value
        End Set
    End Property

    <DataMember()> _
    Public Property PorcentajeAFP() As Double
        Get
            Return _porcentajeafp
        End Get
        Set(ByVal value As Double)
            _porcentajeafp = value
        End Set
    End Property

    <DataMember()> _
    Public Property Trabajador() As String
        Get
            Return _trabajador
        End Get
        Set(ByVal value As String)
            _trabajador = value
        End Set
    End Property

    <DataMember()> _
    Public Property Estado() As String
        Get
            Return _estado.Nombre
        End Get
        Set(ByVal value As String)
            _estado.Nombre = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdEstado() As String
        Get
            Return _estado.Id
        End Get
        Set(ByVal value As String)
            _estado.Id = value
        End Set
    End Property

    <DataMember()> _
    Public Property CTSM() As Integer
        Get
            Return _ctsm
        End Get
        Set(ByVal value As Integer)
            _ctsm = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CTSD() As Integer
        Get
            Return _ctsd
        End Get
        Set(ByVal value As Integer)
            _ctsd = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CTSxM() As Double
        Get
            Return _ctsxm
        End Get
        Set(ByVal value As Double)
            _ctsxm = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CTSxD() As Double
        Get
            Return _ctsxd
        End Get
        Set(ByVal value As Double)
            _ctsxd = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property VTA() As Integer
        Get
            Return _vta
        End Get
        Set(ByVal value As Integer)
            _vta = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property VTM() As Integer
        Get
            Return _vtm
        End Get
        Set(ByVal value As Integer)
            _vtm = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property VTD() As Integer
        Get
            Return _vtd
        End Get
        Set(ByVal value As Integer)
            _vtd = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property VTxA() As Double
        Get
            Return _vtxa
        End Get
        Set(ByVal value As Double)
            _vtxa = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property VTxM() As Double
        Get
            Return _vtxm
        End Get
        Set(ByVal value As Double)
            _vtxm = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property VTxD() As Double
        Get
            Return _vtxd
        End Get
        Set(ByVal value As Double)
            _vtxd = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property VTGozadas() As Double
        Get
            Return _vtgozadas
        End Get
        Set(ByVal value As Double)
            _vtgozadas = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property VTxDescuentoAFP() As Double
        Get
            Return _vtxdescuentoafp
        End Get
        Set(ByVal value As Double)
            _vtxdescuentoafp = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property GTM() As Integer
        Get
            Return _gtm
        End Get
        Set(ByVal value As Integer)
            _gtm = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property GTD() As Integer
        Get
            Return _gtd
        End Get
        Set(ByVal value As Integer)
            _gtd = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property GTxM() As Double
        Get
            Return _gtxm
        End Get
        Set(ByVal value As Double)
            _gtxm = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property GTxD() As Double
        Get
            Return _gtxd
        End Get
        Set(ByVal value As Double)
            _gtxd = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property BoniExtra() As Double
        Get
            Return _boniextra
        End Get
        Set(ByVal value As Double)
            _boniextra = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CantidadGraciosa() As Double
        Get
            Return _cantidadgraciosa
        End Get
        Set(ByVal value As Double)
            _cantidadgraciosa = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property DT() As Integer
        Get
            Return _dt
        End Get
        Set(ByVal value As Integer)
            _dt = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property DTxD() As Double
        Get
            Return _dtxd
        End Get
        Set(ByVal value As Double)
            _dtxd = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property DTAsigFam() As Double
        Get
            Return _dtasigfam
        End Get
        Set(ByVal value As Double)
            _dtasigfam = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property DTEssaludVida() As Double
        Get
            Return _dtessaludvida
        End Get
        Set(ByVal value As Double)
            _dtessaludvida = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property DTDsctoAFP() As Double
        Get
            Return _dtdsctoafp
        End Get
        Set(ByVal value As Double)
            _dtdsctoafp = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property DTDsctoEPS() As Double
        Get
            Return _dtdsctoeps
        End Get
        Set(ByVal value As Double)
            _dtdsctoeps = value
        End Set
    End Property

    <DataMember()> _
    Public Property Dev5taCat() As Double
        Get
            Return _dev5tacat
        End Get
        Set(ByVal value As Double)
            _dev5tacat = value
        End Set
    End Property

    <DataMember()> _
    Public Property AdelantoSueldo() As Double
        Get
            Return _adelantosueldo
        End Get
        Set(ByVal value As Double)
            _adelantosueldo = value
        End Set
    End Property

    <DataMember()> _
    Public Property TotalPagar() As Double
        Get
            Return _totalpagar
        End Get
        Set(ByVal value As Double)
            _totalpagar = value
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
        End Set
    End Property

    <DataMember()> _
    Public Property FechaInicioDT() As Date
        Get
            Return _fechainicioDT
        End Get
        Set(ByVal value As Date)
            _fechainicioDT = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaInicioGT() As Date
        Get
            Return _fechainiciogt
        End Get
        Set(ByVal value As Date)
            _fechainiciogt = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaInicioVT() As Date
        Get
            Return _fechainiciovt
        End Get
        Set(ByVal value As Date)
            _fechainiciovt = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaInicioCTS() As Date
        Get
            Return _fechainiciocts
        End Get
        Set(ByVal value As Date)
            _fechainiciocts = value
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
    Public Property DNI() As String
        Get
            Return _dni
        End Get
        Set(ByVal value As String)
            _dni = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaCompletaDT() As String
        Get
            Return _fcdt
        End Get
        Set(ByVal value As String)
            _fcdt = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaCompletaVT() As String
        Get
            Return _fcvt
        End Get
        Set(ByVal value As String)
            _fcvt = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaCompletaGT() As String
        Get
            Return _fcgt
        End Get
        Set(ByVal value As String)
            _fcgt = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaCompletaCTS() As String
        Get
            Return _fccts
        End Get
        Set(ByVal value As String)
            _fccts = value
        End Set
    End Property

    <DataMember()> _
    Public Property CTSF() As Integer
        Get
            Return _ctsf
        End Get
        Set(ByVal value As Integer)
            _ctsf = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CTSxF() As Double
        Get
            Return _ctsxf
        End Get
        Set(ByVal value As Double)
            _ctsxf = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property GTF() As Integer
        Get
            Return _gtf
        End Get
        Set(ByVal value As Integer)
            _gtf = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property GTxF() As Double
        Get
            Return _gtxf
        End Get
        Set(ByVal value As Double)
            _gtxf = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property VTF() As Integer
        Get
            Return _vtf
        End Get
        Set(ByVal value As Integer)
            _vtf = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property VTxF() As Double
        Get
            Return _vtxf
        End Get
        Set(ByVal value As Double)
            _vtxf = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property DTF() As Integer
        Get
            Return _dtf
        End Get
        Set(ByVal value As Integer)
            _dtf = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property DTxF() As Double
        Get
            Return _dtxf
        End Get
        Set(ByVal value As Double)
            _dtxf = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Descuento() As Double
        Get
            Return _descuento
        End Get
        Set(ByVal value As Double)
            _descuento = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Retencion5ta() As Double
        Get
            Return _retencion5ta
        End Get
        Set(ByVal value As Double)
            _retencion5ta = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property AporteEsalud() As Double
        Get
            Return _aporteessalud
        End Get
        Set(ByVal value As Double)
            _aporteessalud = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        Activo = True
        FechaIngreso = Date.Parse("01/01/1901")
        FechaCese = Date.Parse("01/01/1901")
    End Sub

    Public Sub New(ByVal ls_Id As String _
          , ByVal ls_Codigo As String _
          , ByVal ld_Fecha As Date _
          , ByVal ld_FechaIngreso As Date _
          , ByVal ld_FechaCese As Date _
          , ByVal ls_IdTrabajador As String _
          , ByVal ls_Trabajador As String _
          , ByVal ls_IdMotivoCese As String _
          , ByVal ls_MotivoCese As String _
          , ByVal ls_IdEstado As String _
          , ByVal ls_Estado As String _
          , ByVal ls_IdOcupacion As String _
          , ByVal ls_Ocupacion As String _
          , ByVal ln_TotalPagar As Double _
          , ByVal ln_RemuBasica As Double _
          , ByVal ln_AsigFamiliar As Double _
          , ByVal ln_PromBoniProd As Double _
          , ByVal ln_PromHorasExtras As Double _
          , ByVal ln_PromGratificacion As Double _
          , ByVal ld_FechaInicioCTS As Date _
          , ByVal ln_CTSM As Integer _
          , ByVal ln_CTSD As Integer _
          , ByVal ln_CTSxM As Double _
          , ByVal ln_CTSxD As Double _
          , ByVal ld_FechaInicioVT As Date _
          , ByVal ln_VTA As Integer _
          , ByVal ln_VTM As Integer _
          , ByVal ln_VTD As Integer _
          , ByVal ln_VTDGozadas As Integer _
          , ByVal ln_VTxA As Double _
          , ByVal ln_VTxM As Double _
          , ByVal ln_VTxD As Double _
          , ByVal ln_VTGozadas As Double _
          , ByVal ln_VTxDescuentoAFP As Double _
          , ByVal ld_FechaInicioGT As Date _
          , ByVal ln_GTM As Integer _
          , ByVal ln_GTD As Integer _
          , ByVal ln_GTxM As Double _
          , ByVal ln_GTxD As Double _
          , ByVal ln_BoniExtra As Double _
          , ByVal ln_CantidadGraciosa As Double _
          , ByVal ld_FechaInicioDT As Date _
          , ByVal ln_DT As Integer _
          , ByVal ln_DTxD As Double _
          , ByVal ln_DTAsigFam As Double _
          , ByVal ln_DTEssaludVida As Double _
          , ByVal ln_DTDsctoAFP As Double _
          , ByVal ln_DTDsctoEPS As Double _
          , ByVal ln_AdelantosSueldo As Double _
          , ByVal ln_Devolucion5ta As Double _
          , ByVal ld_FechaCreacion As Date _
          , ByVal ls_UsuarioCreacion As String _
          , ByVal lb_Activo As Boolean _
          , ByVal ld_PorcentajeAFP As Double _
          , ByVal ls_TotalPagarTexto As String _
          , ByVal ls_Dni As String)
        _id = ls_Id
        _codigo = ls_Codigo
        _fecha = ld_Fecha
        _fechaingreso = ld_FechaIngreso
        _fechacese = ld_FechaCese
        _idtrabajador = ls_IdTrabajador
        _trabajador = ls_Trabajador
        _motivocese.Id = ls_IdMotivoCese
        _motivocese.Nombre = ls_MotivoCese
        _ocupacion.Id = ls_IdOcupacion
        _ocupacion.Nombre = ls_Ocupacion
        _estado.Id = ls_IdEstado
        _estado.Nombre = ls_Estado
        _totalpagar = ln_TotalPagar
        _remuneracionbasica = ln_RemuBasica
        _asigfamiliar = ln_AsigFamiliar
        _promboniprod = ln_PromBoniProd
        _promhorasextras = ln_PromHorasExtras
        _promgratificacion = ln_PromGratificacion
        _fechainiciocts = ld_FechaInicioCTS
        _ctsm = ln_CTSM
        _ctsd = ln_CTSD
        _ctsxm = ln_CTSxM
        _ctsxd = ln_CTSxD
        _fechainiciovt = ld_FechaInicioVT
        _vta = ln_VTA
        _vtm = ln_VTM
        _vtd = ln_VTD
        _vtdgozadas = ln_VTDGozadas
        _vtxa = ln_VTxA
        _vtxm = ln_VTxM
        _vtxd = ln_VTxD
        _vtgozadas = ln_VTGozadas
        _vtxdescuentoafp = ln_VTxDescuentoAFP
        _fechainiciogt = ld_FechaInicioGT
        _gtm = ln_GTM
        _gtd = ln_GTD
        _gtxm = ln_GTxM
        _gtxd = ln_GTxD
        _boniextra = ln_BoniExtra
        _cantidadgraciosa = ln_CantidadGraciosa
        _fechainicioDT = ld_FechaInicioDT
        _dt = ln_DT
        _dtxd = ln_DTxD
        _dtasigfam = ln_DTAsigFam
        _dtessaludvida = ln_DTEssaludVida
        _dtdsctoafp = ln_DTDsctoAFP
        _dtdsctoeps = ln_DTDsctoEPS
        _adelantosueldo = ln_AdelantosSueldo
        _dev5tacat = ln_Devolucion5ta
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _activo = lb_Activo
        _porcentajeafp = ld_PorcentajeAFP
        _tptexto = ls_TotalPagarTexto
        _dni = ls_Dni
    End Sub

#End Region

#Region "Métodos"

    Public Function Obtener(ByVal liquidaciontrabajador As e_LiquidacionTrabajador) As e_LiquidacionTrabajador Implements Ie_LiquidacionTrabajador.Obtener
        Return liquidaciontrabajador
    End Function

#End Region

End Class