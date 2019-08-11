<DataContract()> _
Public Class e_PlanillaEps
    Implements Ie_PlanillaEps
    Implements IEquatable(Of e_PlanillaEps)

#Region "Declaracion de Variables"

    Private _id As String
    Private _idplanilla As String
    Private _planilla As String
    Private _idtrabajador As String
    Private _dni As String
    Private _trabajador As String
    Private _sueldo As Double
    Private _asignacionfamiliar As Double
    Private _bonos As Double
    Private _totalsueldo As Double
    Private _aporteessalud As Double
    Private _creditoeps As Double
    Private _idepscontratada As String
    Private _epscontratada As Double
    Private _adicional As Double
    Private _totaleps As Double
    Private _dependiente As Integer
    Private _titulardependiente As Integer
    Private _monto As Double
    Private _regularizacion As Double
    Private _montoplanilla As Double
    Private _idestado As String
    Private _estado As String
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _fechamodifica As Date
    Private _usuariomodifica As String
    Private _activo As Boolean
    Private _HoraExtra25 As Double
    Private _HoraExtra35 As Double
    Private _HorasNocturnas As Double
    Private _Movilidad As Double
    Private _BonoProduccion As Double
    Private _CompensacionVacacional As Double
    Private _RenumeracionVacacional As Double
    Private _BonoResponsabilidad As Double
    Private _DescansoMedico As Double
    Private _VueltaAdicionalPiura As Double
    Private _BonoCombustiblePiura As Double
    Private _BonoJefeConvoy As Double
    Private _VueltaAdicionalLima As Double
    Private _Otros As Double
    Private _VueltaCaliza As Double
    Private _Semaforo As Double

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public Equivale As Integer = 0
    <DataMember()> _
    Public PorcEss As Double = 0
    <DataMember()> _
    Public PorcEps As Double = 0
    <DataMember()> _
    Public Calcula As Boolean = False

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
    Public Property IdPlanilla() As String
        Get
            Return _idplanilla
        End Get
        Set(ByVal value As String)
            _idplanilla = value
        End Set
    End Property

    <DataMember()> _
    Public Property Planilla() As String
        Get
            Return _planilla
        End Get
        Set(ByVal value As String)
            _planilla = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdTrabajador() As String
        Get
            Return _idtrabajador
        End Get
        Set(ByVal value As String)
            _idtrabajador = value
        End Set
    End Property

    <DataMember()> _
    Public Property Dni() As String
        Get
            Return _dni
        End Get
        Set(ByVal value As String)
            _dni = value
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
    Public Property Sueldo() As Double
        Get
            Return _sueldo
        End Get
        Set(ByVal value As Double)
            _sueldo = value
        End Set
    End Property

    <DataMember()> _
    Public Property AsignacionFamiliar() As Double
        Get
            Return _asignacionfamiliar
        End Get
        Set(ByVal value As Double)
            _asignacionfamiliar = value
        End Set
    End Property

    <DataMember()> _
    Public Property HoraExtra25() As Double
        Get
            Return _HoraExtra25
        End Get
        Set(ByVal value As Double)
            _HoraExtra25 = value
        End Set
    End Property

    <DataMember()> _
    Public Property HoraExtra35() As Double
        Get
            Return _HoraExtra35
        End Get
        Set(ByVal value As Double)
            _HoraExtra35 = value
        End Set
    End Property

    <DataMember()> _
    Public Property HorasNocturnas() As Double
        Get
            Return _HorasNocturnas
        End Get
        Set(ByVal value As Double)
            _HorasNocturnas = value
        End Set
    End Property

    <DataMember()> _
    Public Property Movilidad() As Double
        Get
            Return _Movilidad
        End Get
        Set(ByVal value As Double)
            _Movilidad = value
        End Set
    End Property

    <DataMember()> _
    Public Property BonoProduccion() As Double
        Get
            Return _BonoProduccion
        End Get
        Set(ByVal value As Double)
            _BonoProduccion = value
        End Set
    End Property

    <DataMember()> _
    Public Property CompensacionVacacional() As Double
        Get
            Return _CompensacionVacacional
        End Get
        Set(ByVal value As Double)
            _CompensacionVacacional = value
        End Set
    End Property

    <DataMember()> _
    Public Property RenumeracionVacacional() As Double
        Get
            Return _RenumeracionVacacional
        End Get
        Set(ByVal value As Double)
            _RenumeracionVacacional = value
        End Set
    End Property

    <DataMember()> _
    Public Property BonoResponsabilidad() As Double
        Get
            Return _BonoResponsabilidad
        End Get
        Set(ByVal value As Double)
            _BonoResponsabilidad = value
        End Set
    End Property

    <DataMember()> _
    Public Property DescansoMedico() As Double
        Get
            Return _DescansoMedico
        End Get
        Set(ByVal value As Double)
            _DescansoMedico = value
        End Set
    End Property

    <DataMember()> _
    Public Property VueltaAdicionalPiura() As Double
        Get
            Return _VueltaAdicionalPiura
        End Get
        Set(ByVal value As Double)
            _VueltaAdicionalPiura = value
        End Set
    End Property

    <DataMember()> _
    Public Property BonoCombustiblePiura() As Double
        Get
            Return _BonoCombustiblePiura
        End Get
        Set(ByVal value As Double)
            _BonoCombustiblePiura = value
        End Set
    End Property

    <DataMember()> _
    Public Property BonoJefeConvoy() As Double
        Get
            Return _BonoJefeConvoy
        End Get
        Set(ByVal value As Double)
            _BonoJefeConvoy = value
        End Set
    End Property

    <DataMember()> _
    Public Property VueltaAdicionalLima() As Double
        Get
            Return _VueltaAdicionalLima
        End Get
        Set(ByVal value As Double)
            _VueltaAdicionalLima = value
        End Set
    End Property

    <DataMember()> _
    Public Property Otros() As Double
        Get
            Return _Otros
        End Get
        Set(ByVal value As Double)
            _Otros = value
        End Set
    End Property

    <DataMember()> _
    Public Property VueltaCaliza() As Double
        Get
            Return _VueltaCaliza
        End Get
        Set(ByVal value As Double)
            _VueltaCaliza = value
        End Set
    End Property

    <DataMember()> _
    Public Property Semaforo() As Double
        Get
            Return _Semaforo
        End Get
        Set(ByVal value As Double)
            _Semaforo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Bonos() As Double
        Get
            Return _bonos
        End Get
        Set(ByVal value As Double)
            _bonos = value
        End Set
    End Property

    <DataMember()> _
    Public Property TotalSueldo() As Double
        Get
            If Calcula Then _totalsueldo = Sueldo + AsignacionFamiliar + Bonos + HoraExtra25 + HoraExtra35 + HorasNocturnas + Movilidad + BonoProduccion _
                + CompensacionVacacional + RenumeracionVacacional + BonoResponsabilidad + DescansoMedico + VueltaAdicionalPiura + BonoCombustiblePiura _
                + BonoJefeConvoy + VueltaAdicionalLima + Otros + VueltaCaliza + Semaforo
            Return _totalsueldo
        End Get
        Set(ByVal value As Double)
            _totalsueldo = value
        End Set
    End Property

    <DataMember()> _
    Public Property AporteEssalud() As Double
        Get
            If Calcula Then _aporteessalud = TotalSueldo * PorcEss / 100
            Return _aporteessalud
        End Get
        Set(ByVal value As Double)
            _aporteessalud = value
        End Set
    End Property

    <DataMember()> _
    Public Property CreditoEps() As Double
        Get
            If Calcula Then _creditoeps = TotalSueldo * PorcEps / 100
            Return _creditoeps
        End Get
        Set(ByVal value As Double)
            _creditoeps = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdEpsContratada() As String
        Get
            Return _idepscontratada
        End Get
        Set(ByVal value As String)
            _idepscontratada = value
        End Set
    End Property

    <DataMember()> _
    Public Property EpsContratada() As Double
        Get
            Return _epscontratada
        End Get
        Set(ByVal value As Double)
            _epscontratada = value
        End Set
    End Property

    <DataMember()> _
    Public Property Adicional() As Double
        Get
            Return _adicional
        End Get
        Set(ByVal value As Double)
            _adicional = value

        End Set
    End Property

    <DataMember()> _
    Public Property TotalEps() As Double
        Get
            If Calcula Then _totaleps = EpsContratada + Adicional
            Return _totaleps
        End Get
        Set(ByVal value As Double)
            _totaleps = value
        End Set
    End Property

    <DataMember()> _
    Public Property Dependiente() As Integer
        Get
            Return _dependiente
        End Get
        Set(ByVal value As Integer)
            _dependiente = value
        End Set
    End Property

    <DataMember()> _
    Public Property TitularDependiente() As Integer
        Get
            _titulardependiente = Dependiente + 1
            Return _titulardependiente
        End Get
        Set(ByVal value As Integer)
            _titulardependiente = value
        End Set
    End Property

    <DataMember()> _
    Public Property Monto() As Double
        Get
            If Not Calcula Then _monto = MontoPlanilla - Regularizacion
            Return _monto
        End Get
        Set(ByVal value As Double)
            _monto = value
        End Set
    End Property

    <DataMember()> _
    Public Property Regularizacion() As Double
        Get
            Return _regularizacion
        End Get
        Set(ByVal value As Double)
            _regularizacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property MontoPlanilla() As Double
        Get
            If Calcula Then _montoplanilla = Monto + Regularizacion
            Return _montoplanilla
        End Get
        Set(ByVal value As Double)
            _montoplanilla = value
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

#Region "Contructor"

    Public Sub New()
        _id = String.Empty
        _idplanilla = String.Empty
        _planilla = String.Empty
        _idtrabajador = String.Empty
        _dni = String.Empty
        _trabajador = String.Empty
        _sueldo = 0
        _asignacionfamiliar = 0
        _HoraExtra25 = 0
        _HoraExtra35 = 0
        _HorasNocturnas = 0
        _Movilidad = 0
        _BonoProduccion = 0
        _CompensacionVacacional = 0
        _RenumeracionVacacional = 0
        _BonoResponsabilidad = 0
        _DescansoMedico = 0
        _VueltaAdicionalPiura = 0
        _BonoCombustiblePiura = 0
        _BonoJefeConvoy = 0
        _VueltaAdicionalLima = 0
        _Otros = 0
        _VueltaCaliza = 0
        _Semaforo = 0
        _bonos = 0
        _totalsueldo = 0
        _aporteessalud = 0
        _creditoeps = 0
        _idepscontratada = String.Empty
        _adicional = 0
        _totaleps = 0
        _dependiente = 0
        _titulardependiente = 0
        _regularizacion = 0
        _montoplanilla = 0
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
              , ByVal ls_IdPlanilla As String _
              , ByVal ls_Planilla As String _
              , ByVal ls_IdTrabajador As String _
              , ByVal ls_Dni As String _
              , ByVal ls_Trabajador As String _
              , ByVal ln_Sueldo As Double _
              , ByVal ln_AsignacionFamiliar As Double _
              , ByVal ln_HoraExtra25 As Double _
              , ByVal ln_HoraExtra35 As Double _
              , ByVal ln_HorasNocturnas As Double _
              , ByVal ln_Movilidad As Double _
              , ByVal ln_BonoProduccion As Double _
              , ByVal ln_CompensacionVacacional As Double _
              , ByVal ln_RenumeracionVacacional As Double _
              , ByVal ln_BonoResponsabilidad As Double _
              , ByVal ln_DescansoMedico As Double _
              , ByVal ln_VueltaAdicionalPiura As Double _
              , ByVal ln_BonoCombustiblePiura As Double _
              , ByVal ln_BonoJefeConvoy As Double _
              , ByVal ln_VueltaAdicionalLima As Double _
              , ByVal ln_Otros As Double _
              , ByVal ln_VueltaCaliza As Double _
              , ByVal ln_Semaforo As Double _
              , ByVal ln_Bonos As Double _
              , ByVal ln_TotalSueldo As Double _
              , ByVal ln_AporteEssalud As Double _
              , ByVal ln_CreditoEps As Double _
              , ByVal ls_IdEpsContratada As String _
              , ByVal ln_EpsContratada As Double _
              , ByVal ln_Adicional As Double _
              , ByVal ln_TotalEps As Double _
              , ByVal ln_Dependiente As Integer _
              , ByVal ln_Regularizacon As Double _
              , ByVal ln_MontoPlanilla As Double _
              , ByVal ls_IdEstado As String _
              , ByVal ls_Estado As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ld_FechaModifica As Date _
              , ByVal ls_UsuarioModifica As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _idplanilla = ls_IdPlanilla
        _planilla = ls_Planilla
        _idtrabajador = ls_IdTrabajador
        _dni = ls_Dni
        _trabajador = ls_Trabajador
        _sueldo = ln_Sueldo
        _asignacionfamiliar = ln_AsignacionFamiliar
        _HoraExtra25 = ln_HoraExtra25
        _HoraExtra35 = ln_HoraExtra35
        _HorasNocturnas = ln_HorasNocturnas
        _Movilidad = ln_Movilidad
        _BonoProduccion = ln_BonoProduccion
        _CompensacionVacacional = ln_CompensacionVacacional
        _RenumeracionVacacional = ln_RenumeracionVacacional
        _BonoResponsabilidad = ln_BonoResponsabilidad
        _DescansoMedico = ln_DescansoMedico
        _VueltaAdicionalPiura = ln_VueltaAdicionalPiura
        _BonoCombustiblePiura = ln_BonoCombustiblePiura
        _BonoJefeConvoy = ln_BonoJefeConvoy
        _VueltaAdicionalLima = ln_VueltaAdicionalLima
        _Otros = ln_Otros
        _VueltaCaliza = ln_VueltaCaliza
        _Semaforo = ln_Semaforo
        _bonos = ln_Bonos
        _totalsueldo = ln_TotalSueldo
        _aporteessalud = ln_AporteEssalud
        _creditoeps = ln_CreditoEps
        _idepscontratada = ls_IdEpsContratada
        _epscontratada = ln_EpsContratada
        _adicional = ln_Adicional
        _totaleps = ln_TotalEps
        _dependiente = ln_Dependiente
        _regularizacion = ln_Regularizacon
        _montoplanilla = ln_MontoPlanilla
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

    Public Function obtener(oePlanillaEps As e_PlanillaEps) As e_PlanillaEps Implements Ie_PlanillaEps.obtener
        Return oePlanillaEps
    End Function

    Public Overloads Function Equals(ByVal oePeps As e_PlanillaEps) As Boolean Implements System.IEquatable(Of e_PlanillaEps).Equals
        Select Case oePeps.Equivale
            Case 0 : If Me.Id = oePeps.Id Then Return True
            Case 1 : If Me.Dni = oePeps.Dni Then Return True
        End Select
        Return False
    End Function

#End Region

End Class
