Imports System.ServiceModel
Imports ISL.EntidadesWCF

<ServiceContract()> _
Public Interface Il_ObligacionFinanciera

    <OperationContract()> _
    Function CrearDT() As Data.DataTable

    <OperationContract()> _
    Function CompletaConCeros(ByVal ls_Tex As String, ByVal lnCantidad As Integer) As String

    <OperationContract()> _
    Function Obtener(ByVal oeObligacionFinanciera As e_ObligacionFinanciera) As e_ObligacionFinanciera

    <OperationContract()> _
    Function Obtener2(ByVal oeObligacionFin As e_ObligacionFin) As e_ObligacionFin

    <OperationContract()> _
    Function Listar(ByVal oeObligacionFinanciera As e_ObligacionFinanciera) As List(Of e_ObligacionFinanciera)

    <OperationContract()> _
    Function Validar(ByVal oeObligacionFinanciera As e_ObligacionFinanciera, ByVal lsNombreObligacion As String) As Boolean

    <OperationContract()> _
    Function GuardarFEC(ByVal oeObligacionFinanciera As e_ObligacionFinanciera) As Boolean

    <OperationContract()> _
    Function GuardarFedd(ByVal oeObligacionFinanciera As e_ObligacionFinanciera, ByVal oeCuentaBancaria As e_CuentaBancaria) As Boolean

    <OperationContract()> _
    Function GuardarFactoring(ByVal oeObligacionFinanciera As e_ObligacionFinanciera, ByVal oeCuentaBancaria As e_CuentaBancaria, _
                                   ByVal o_Oblig As Object(), ByVal FactoringReal As Boolean) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeObligacionFinanciera As e_ObligacionFinanciera) As Boolean

    <OperationContract()> _
    Function GuardarObli(ByVal oeObligacionFinanciera As e_ObligacionFinanciera) As Boolean

    <OperationContract()> _
    Function CambiarGlosa(ByVal oeObligacionFinanciera As e_ObligacionFinanciera) As Boolean

    <OperationContract()> _
    Function ValidarPagoObligacion(ByVal leDocumentosAgregados As List(Of e_ObligacionFinanciera), ByVal fecha As Date)

    <OperationContract()> _
    Function GuardarPago(ByVal leMovDocAgregado As List(Of e_ObligacionFinanciera), _
                                   ByRef oeMovCajaBanco As e_MovimientoCajaBanco, ByVal oeMedioPago As e_MedioPago, _
                                   ByVal idUsuario As String, ByVal MacLocal As String, ByVal oeCtaCble As e_CuentaContable) As Boolean

    <OperationContract()> _
    Function GuardarPago2(ByVal oeObliFin As e_ObligacionFin, oeAsientoModel As e_AsientoModelo, lst_DocRetDet As List(Of e_DocumentoRetencionDetalle)) As Boolean

    <OperationContract()> _
    Function GuardarLetras(ByVal leOblig As List(Of e_ObligacionFinanciera), ByVal IdUsuario As String) As Boolean

    <OperationContract()> _
    Function GuardarCreditoHipotecario(ByVal oeMovCajaBanco As e_MovimientoCajaBanco, ByVal leObligacion As List(Of e_ObligacionFinanciera), oeCtaCtble As e_CuentaContable) As Boolean

    <OperationContract()> _
    Function GuardarLeasing(ByVal oeObligacionFinanciera As e_ObligacionFinanciera, _
                          ByVal o_Oblig As Object()) As Boolean

    <OperationContract()> _
    Function GuardarInteresReversionMensualLeasingSoles(ByVal Fecha As Date, ByVal TipoCambio As Double, _
                    ByVal UsuarioCreacion As String, ByVal lsIdObligacion As String, ByVal lsFechaAsiento As Date) As Boolean

    <OperationContract()> _
    Function GuardarInteresReversionMensualLeasingDolares(ByVal Fecha As Date, ByVal TipoCambio As Double, _
                    ByVal UsuarioCreacion As String, ByVal lsIdObligacion As String, ByVal lsFechaAsiento As Date) As Boolean

    <OperationContract()> _
    Function GuardarInteresMensualLeasingSoles(ByVal Fecha As Date, ByVal TipoCambio As Double, _
                        ByVal UsuarioCreacion As String, ByVal lsIdObligacion As String, ByVal lsTipoOperacion As String, ByVal lsFechaAsiento As Date) As Boolean

    <OperationContract()> _
    Function GuardarInteresMensualLeasingDolares(ByVal Fecha As Date, ByVal TipoCambio As Double, _
                    ByVal UsuarioCreacion As String, ByVal lsIdObligacion As String, ByVal lsTipoOperacion As String, ByVal lsFechaAsiento As Date) As Boolean

    <OperationContract()> _
    Function GuardarInteresMensualPagareSoles(ByVal Fecha As Date, ByVal TipoCambio As Double, _
                     ByVal UsuarioCreacion As String, ByVal lsIdObligacion As String, ByVal lsFechaAsiento As Date) As Boolean

    <OperationContract()> _
    Function GuardarInteresMensualPagareDolares(ByVal Fecha As Date, ByVal TipoCambio As Double, _
                    ByVal UsuarioCreacion As String, ByVal lsIdObligacion As String, ByVal lsFechaAsiento As Date) As Boolean

    <OperationContract()> _
    Function GuardarPagarePrestamo(ByVal oeObligacionFinanciera As e_ObligacionFinanciera, ByVal oeCuentaBancaria As e_CuentaBancaria, _
                       ByVal o_Oblig As Object(), ByVal lsTipo As String) As Boolean

    <OperationContract()> _
    Function GuardarInteresMensualFedSoles(ByVal Fecha As Date, ByVal TipoCambio As Double, _
                  ByVal UsuarioCreacion As String, ByVal lsIdObligacion As String, ByVal lsFechaAsiento As Date) As Boolean

    <OperationContract()> _
    Function GuardarInteresMensualFedDolares(ByVal Fecha As Date, ByVal TipoCambio As Double, _
                    ByVal UsuarioCreacion As String, ByVal lsIdObligacion As String, ByVal lsFechaAsiento As Date) As Boolean

    <OperationContract()> _
    Function GuardarInteresMensualFactorySoles(ByVal Fecha As Date, ByVal TipoCambio As Double, _
                ByVal UsuarioCreacion As String, ByVal lsIdObligacion As String, ByVal lsFechaAsiento As Date) As Boolean

    <OperationContract()> _
    Function GuardarInteresMensualFactoryDolares(ByVal Fecha As Date, ByVal TipoCambio As Double, _
                    ByVal UsuarioCreacion As String, ByVal lsIdObligacion As String, ByVal lsFechaAsiento As Date) As Boolean

    <OperationContract()> _
    Function GuardarInteresMensualFecSoles(ByVal Fecha As Date, ByVal TipoCambio As Double, _
               ByVal UsuarioCreacion As String, ByVal lsIdObligacion As String, ByVal lsFechaAsiento As Date) As Boolean

    <OperationContract()> _
    Function GuardarInteresMensualFecDolares(ByVal Fecha As Date, ByVal TipoCambio As Double, _
                    ByVal UsuarioCreacion As String, ByVal lsIdObligacion As String, ByVal lsFechaAsiento As Date) As Boolean

    <OperationContract()> _
    Function GuardarInteresMensualProvisionCrediHipoSoles(ByVal Fecha As Date, ByVal TipoCambio As Double, _
               ByVal UsuarioCreacion As String, ByVal lsIdObligacion As String, ByVal lsFechaAsiento As Date) As Boolean

    <OperationContract()> _
    Function GuardarInteresMensualProvisionCrediHipoDolares(ByVal Fecha As Date, ByVal TipoCambio As Double, _
               ByVal UsuarioCreacion As String, ByVal lsIdObligacion As String, ByVal lsFechaAsiento As Date) As Boolean

    <OperationContract()> _
    Function GuardarInteresMensualPuenteCrediHipoSoles(ByVal Fecha As Date, ByVal TipoCambio As Double, _
               ByVal UsuarioCreacion As String, ByVal lsIdObligacion As String, ByVal lsFechaAsiento As Date) As Boolean

    <OperationContract()> _
    Function GuardarInteresMensualPuenteCrediHipoDolares(ByVal Fecha As Date, ByVal TipoCambio As Double, _
               ByVal UsuarioCreacion As String, ByVal lsIdObligacion As String, ByVal lsFechaAsiento As Date) As Boolean

    <OperationContract()> _
    Function GuardarInteresMensualPagoCrediHipoSoles(ByVal Fecha As Date, ByVal TipoCambio As Double, _
               ByVal UsuarioCreacion As String, ByVal lsIdObligacion As String, ByVal lsFechaAsiento As Date) As Boolean

    <OperationContract()> _
    Function GuardarInteresMensualPagoCrediHipoDolares(ByVal Fecha As Date, ByVal TipoCambio As Double, _
               ByVal UsuarioCreacion As String, ByVal lsIdObligacion As String, ByVal lsFechaAsiento As Date) As Boolean

    <OperationContract()> _
    Function Listar2(ByVal oeObligacionFin As e_ObligacionFin) As List(Of e_ObligacionFin)

    <OperationContract()> _
    Function GuardarLista(ByVal leObligacionFin As List(Of e_ObligacionFin)) As Boolean



End Interface
