<DataContract()> _
Public Class e_ObligacionFin
    Implements Ie_ObligacionFin
    Implements IEquatable(Of e_ObligacionFin)

#Region "Declaración de variables"

    Private _Id As String
    Private _IdContrato As String ' Nro de contrato bancario
    Private _NroVencimiento As String ' Nro Cuota
    Private _IndPeriodoGracia As Integer
    Private _FechaVencimiento As Date
    Private _MontoMN As Double
    Private _MontoME As Double
    Private _MontoInteres As Double
    Private _MontoInteresMoratorio As Double
    Private _MontoInteresDscto As Double
    Private _MontoInteresContable As Double
    Private _DiasFinMes As Integer
    Private _DiasProximaCuota As Integer
    Private _IndInteresMensual As Integer
    Private _Comision As Double
    Private _Gastos As Double
    Private _Portes As Double
    Private _IGV As Double
    Private _ITF As Double
    Private _Saldo As Double
    Private _Glosa As String
    Private _Cuo As String
    Private _IdCuentContable As String
    Private _UsuarioCreacion As String
    Private _FechaCreacion As Date
    Private _UsuarioModifica As String
    Private _FechaModifica As Date
    Private _MacLocal As String
    Private _Activo As Boolean
    Private _retencionmn As Double
    Private _retencionme As Double
    Private _MontoCapital As Double ' Amortizacion de capital
    Private _FechaInicio As Date
    Private _MontoCuota As Double
    Private _Total As Double
    Private _NroContrato As String
    Private _Banco As String
    Private _IdTipoObligacion As String
    Private _IdMoneda As String
    Private _MontoOperar As Double
    
    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Ejercicio As Integer
    <DataMember()> _
    Public Mes As Integer

    <DataMember()> _
    Public oeFecLetra As New e_FecLetras
    <DataMember()> _
    Public leOblFinDoc As New List(Of e_ObligacionDocumento)
    <DataMember()> _
    Public oeMovCajaBanco As New e_MovimientoCajaBanco
    <DataMember()> _
    Public oeObligacionPago As New e_ObligacionPago

    <DataMember()> _
    Public SaldoAux As Double
    <DataMember()> _
    Public IdPeriodo As String
    <DataMember()> _
    Public IndExcluirInteres As Boolean = False
    <DataMember()> _
    Public IndFec As Boolean = False
    <DataMember()> _
    Public CtaFec As String = ""
    <DataMember()> _
    Public TipoCambio As Double
    <DataMember()> _
    Public _IdMovimientoCajaBanco As String = ""
    <DataMember()> _
    Public _IdAsientoMovimiento As String = ""

#End Region

#Region "Propiedades"

    <DataMember()> _
    Public Property Id() As String
        Get
            Return _Id
        End Get
        Set(ByVal value As String)
            _Id = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdContrato() As String
        Get
            Return _IdContrato
        End Get
        Set(ByVal value As String)
            _IdContrato = value
        End Set
    End Property

    <DataMember()> _
    Public Property NroVencimiento() As String
        Get
            Return _NroVencimiento
        End Get
        Set(ByVal value As String)
            _NroVencimiento = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndPeriodoGracia() As Integer
        Get
            Return _IndPeriodoGracia
        End Get
        Set(ByVal value As Integer)
            _IndPeriodoGracia = value
        End Set
    End Property

    <DataMember()> _
 Public Property FechaVencimiento() As Date
        Get
            Return _FechaVencimiento
        End Get
        Set(ByVal value As Date)
            _FechaVencimiento = value
        End Set
    End Property

    <DataMember()> _
    Public Property MontoMN() As Double
        Get
            Return _MontoMN
        End Get
        Set(ByVal value As Double)
            _MontoMN = value
        End Set
    End Property

    <DataMember()> _
    Public Property MontoME() As Double
        Get
            Return _MontoME
        End Get
        Set(ByVal value As Double)
            _MontoME = value
        End Set
    End Property

    <DataMember()> _
    Public Property RetencionMN() As Double
        Get
            Return _retencionmn
        End Get
        Set(ByVal value As Double)
            _retencionmn = value
        End Set
    End Property

    <DataMember()> _
    Public Property RetencionME() As Double
        Get
            Return _retencionme
        End Get
        Set(ByVal value As Double)
            _retencionme = value
        End Set
    End Property

    <DataMember()> _
    Public Property MontoCuota() As Double
        Get
            Return MontoCapital + MontoInteres
        End Get
        Set(ByVal value As Double)
            _MontoCuota = value
        End Set
    End Property

    <DataMember()> _
    Public Property MontoInteres() As Double
        Get
            Return _MontoInteres
        End Get
        Set(ByVal value As Double)
            _MontoInteres = value
        End Set
    End Property

    <DataMember()> _
    Public Property MontoInteresMoratorio() As Double
        Get
            Return _MontoInteresMoratorio
        End Get
        Set(ByVal value As Double)
            _MontoInteresMoratorio = value
        End Set
    End Property

    <DataMember()> _
    Public Property MontoInteresDscto() As Double
        Get
            Return _MontoInteresDscto
        End Get
        Set(ByVal value As Double)
            _MontoInteresDscto = value
        End Set
    End Property

    <DataMember()> _
    Public Property MontoInteresContable() As Double
        Get
            Return _MontoInteresContable
        End Get
        Set(ByVal value As Double)
            _MontoInteresContable = value
        End Set
    End Property

    Public Property DiasFinMes() As Integer
        Get
            Return _DiasFinMes
        End Get
        Set(ByVal value As Integer)
            _DiasFinMes = value
        End Set
    End Property

    Public Property DiasProximaCuota() As Integer
        Get
            Return _DiasProximaCuota
        End Get
        Set(ByVal value As Integer)
            _DiasProximaCuota = value
        End Set
    End Property

    Public Property IndInteresMensual() As Integer
        Get
            Return _IndInteresMensual
        End Get
        Set(ByVal value As Integer)
            _IndInteresMensual = value
        End Set
    End Property

    <DataMember()> _
    Public Property Comision() As Double
        Get
            Return _Comision
        End Get
        Set(ByVal value As Double)
            _Comision = value
        End Set
    End Property

    <DataMember()> _
    Public Property Gastos() As Double
        Get
            Return _Gastos
        End Get
        Set(ByVal value As Double)
            _Gastos = value
        End Set
    End Property

    <DataMember()> _
    Public Property Portes() As Double
        Get
            Return _Portes
        End Get
        Set(ByVal value As Double)
            _Portes = value
        End Set
    End Property

    <DataMember()> _
    Public Property IGV() As Double
        Get
            Return _IGV
        End Get
        Set(ByVal value As Double)
            _IGV = value
        End Set
    End Property

    <DataMember()> _
    Public Property ITF() As Double
        Get
            Return _ITF
        End Get
        Set(ByVal value As Double)
            _ITF = value
        End Set
    End Property

    <DataMember()> _
    Public Property Saldo() As Double
        Get
            Return _Saldo
        End Get
        Set(ByVal value As Double)
            _Saldo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Glosa() As String
        Get
            Return _Glosa
        End Get
        Set(ByVal value As String)
            _Glosa = value
        End Set
    End Property

    <DataMember()> _
    Public Property Cuo() As String
        Get
            Return _Cuo
        End Get
        Set(ByVal value As String)
            _Cuo = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdCuentaContable() As String
        Get
            Return _IdCuentContable
        End Get
        Set(ByVal value As String)
            _IdCuentContable = value
        End Set
    End Property

    <DataMember()> _
    Public Property Usuario() As String
        Get
            Return _UsuarioCreacion
        End Get
        Set(ByVal value As String)
            _UsuarioCreacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaCreacion() As Date
        Get
            Return _FechaCreacion
        End Get
        Set(ByVal value As Date)
            _FechaCreacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioModifica() As String
        Get
            Return _UsuarioModifica
        End Get
        Set(ByVal value As String)
            _UsuarioModifica = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaModifica() As Date
        Get
            Return _FechaModifica
        End Get
        Set(ByVal value As Date)
            _FechaModifica = value
        End Set
    End Property

    <DataMember()> _
    Public Property MacLocal() As String
        Get
            Return _MacLocal
        End Get
        Set(ByVal value As String)
            _MacLocal = value
        End Set
    End Property

    Public Property Activo() As Boolean
        Get
            Return _Activo
        End Get
        Set(ByVal value As Boolean)
            _Activo = value
        End Set
    End Property


    <DataMember()> _
    Public Property FechaInicio() As Date
        Get
            Return _FechaInicio
        End Get
        Set(ByVal value As Date)
            _FechaInicio = value
        End Set
    End Property

    <DataMember()> _
    Public Property MontoCapital() As Double
        Get
            Return _MontoCapital
        End Get
        Set(ByVal value As Double)
            _MontoCapital = value
        End Set
    End Property

    <DataMember()> _
    Public Property Total() As Double
        Get
            Return MontoCuota + Portes + IGV + Comision + Gastos + MontoInteresMoratorio - MontoInteresDscto
        End Get
        Set(ByVal value As Double)
            _Total = value
        End Set
    End Property

    <DataMember()> _
    Public Property NroContrato() As String
        Get
            Return _NroContrato
        End Get
        Set(ByVal value As String)
            _NroContrato = value
        End Set
    End Property

    <DataMember()> _
    Public Property Banco() As String
        Get
            Return _Banco
        End Get
        Set(ByVal value As String)
            _Banco = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdTipoObligacion() As String
        Get
            Return _IdTipoObligacion
        End Get
        Set(ByVal value As String)
            _IdTipoObligacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdMoneda() As String
        Get
            Return _IdMoneda
        End Get
        Set(ByVal value As String)
            _IdMoneda = value
        End Set
    End Property

    <DataMember()> _
    Public Property MontoOperar() As Double
        Get
            Return _MontoOperar
        End Get
        Set(ByVal value As Double)
            _MontoOperar = value
        End Set
    End Property

#End Region

#Region "Constructores"

    Public Sub New()

        _Id = String.Empty
        _IdContrato = String.Empty
        _IndPeriodoGracia = 0
        _NroVencimiento = String.Empty
        _FechaVencimiento = #1/1/1901#
        _MontoMN = 0
        _MontoME = 0
        _MontoInteres = 0
        _MontoInteresMoratorio = 0
        _MontoInteresDscto = 0
        _MontoInteresContable = 0
        _DiasFinMes = 0
        _DiasProximaCuota = 0
        _IndInteresMensual = 0
        _Comision = 0
        _Gastos = 0
        _Portes = 0
        _IGV = 0
        _Saldo = 0
        _Glosa = String.Empty
        _Cuo = String.Empty
        _UsuarioCreacion = String.Empty
        _FechaCreacion = #1/1/1901#
        _UsuarioModifica = String.Empty
        _FechaModifica = #1/1/1901#
        _MacLocal = String.Empty
        _Activo = True

        _MontoCapital = 0
        _MontoCuota = 0
        _Total = 0
        _FechaInicio = #1/1/1901#
        _NroContrato = String.Empty
        _Banco = String.Empty
        _IdTipoObligacion = String.Empty
        _IdMoneda = String.Empty
        _MontoOperar = 0

    End Sub

    Sub New(ByVal lsCodBanco As String, ByVal ln_Mon As Double, ByVal ld_FecVenc As Date)
        _IdContrato = lsCodBanco
        _MontoCapital = ln_Mon
        _FechaVencimiento = ld_FecVenc
    End Sub

    Public Sub New( _
                  ByVal ls_Id As String _
                  , ByVal ls_IdContrato As String _
                  , ByVal ls_NroVencimiento As String _
                  , ByVal ln_IndPeriodoGracia As Integer _
                  , ByVal ld_FechaVencimiento As Date _
                  , ByVal ln_MontoMN As Double _
                  , ByVal ln_MontoME As Double _
                  , ByVal ln_MontoInteres As Double _
                  , ByVal ln_MontoInteresMoratorio As Double _
                  , ByVal ln_MontoInteresDscto As Double _
                  , ByVal ln_MontoInteresContable As Double _
                  , ByVal ln_DiasFinMes As Double _
                  , ByVal ln_DiasProximaCuota As Double _
                  , ByVal ln_IndInteresMensual As Integer _
                  , ByVal ln_Comision As Double _
                  , ByVal ln_Gastos As Double _
                  , ByVal ln_Portes As Double _
                  , ByVal ln_Igv As Double _
                  , ByVal ln_Itf As Double _
                  , ByVal ln_Saldo As Double _
                  , ByVal ls_Glosa As String _
                  , ByVal ls_Cuo As String _
                  , ByVal ls_IdCuentaContable As String _
                  , ByVal ls_Usuario As String _
                  , ByVal ld_FechaCreacion As Date _
                  , ByVal ls_UsuarioModifica As String _
                  , ByVal ld_FechaModifica As Date _
                  , ByVal ls_MacLocal As String _
                  , ByVal lb_Activo As Boolean _
                  , ByVal ls_NroContrato As String _
                  , ByVal ls_Banco As String _
                  , ByVal ls_TipoDocumento As String _
                  , ByVal ls_Moneda As String _
                  , ByVal ln_TipoCambio As Double _
                  , ByVal ln_RetencionMN As Double _
                  , ByVal ln_RetencionME As Double)

        _Id = ls_Id
        _IdContrato = ls_IdContrato
        _IndPeriodoGracia = ln_IndPeriodoGracia
        _NroVencimiento = ls_NroVencimiento
        _FechaVencimiento = ld_FechaVencimiento
        _MontoMN = ln_MontoMN
        _MontoME = ln_MontoME
        _MontoInteres = ln_MontoInteres
        _MontoInteresMoratorio = ln_MontoInteresMoratorio
        _MontoInteresDscto = ln_MontoInteresDscto
        _MontoInteresContable = ln_MontoInteresContable
        _DiasFinMes = ln_DiasFinMes
        _DiasProximaCuota = ln_DiasProximaCuota
        _IndInteresMensual = ln_IndInteresMensual
        _Comision = ln_Comision
        _Gastos = ln_Gastos
        _Portes = ln_Portes
        _IGV = ln_Igv
        _ITF = ln_Itf
        _Saldo = ln_Saldo
        _Glosa = ls_Glosa
        _Cuo = ls_Cuo
        _IdCuentContable = ls_IdCuentaContable
        _UsuarioCreacion = ls_Usuario
        _FechaCreacion = ld_FechaCreacion
        _UsuarioModifica = ls_UsuarioModifica
        _FechaModifica = ld_FechaModifica
        _NroContrato = ls_NroContrato
        _Banco = ls_Banco
        _IdTipoObligacion = ls_TipoDocumento
        _IdMoneda = ls_Moneda
        _MontoOperar = _Saldo
        _MontoCapital = IIf(IdMoneda = "SOLES", _MontoMN, _MontoME)
        TipoCambio = ln_TipoCambio
        _retencionmn = ln_RetencionMN
        _retencionme = ln_RetencionME
    End Sub

#End Region

#Region "Métodos"

    Public Function Equals2(ByVal other As e_ObligacionFin) As Boolean Implements System.IEquatable(Of e_ObligacionFin).Equals
        If Me.IdContrato = other.IdContrato And Me.MontoCapital = other.MontoCapital And Me.FechaVencimiento = other.FechaVencimiento Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function Obtener(ByVal factoryFEED As e_ObligacionAyudaDetalle) As e_ObligacionAyudaDetalle Implements Ie_ObligacionFin.Obtener
        Return factoryFEED
    End Function

#End Region

End Class
