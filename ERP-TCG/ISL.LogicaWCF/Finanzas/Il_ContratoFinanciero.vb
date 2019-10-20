Imports ERP.EntidadesWCF
Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_ContratoFinanciero" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_ContratoFinanciero

    <OperationContract()> _
    Function Validar(oeContratoFinanciero As e_ContratoFinanciero) As Boolean

    <OperationContract()> _
    Function Eliminar(oeContratoFinanciero As e_ContratoFinanciero) As Boolean

    <OperationContract()> _
    Function Guardar(oeContratoFinanciero As e_ContratoFinanciero, oeAsientoModel As e_AsientoModelo) As Boolean

    <OperationContract()> _
    Function GuardarPagare(oeContratoFinanciero As e_ContratoFinanciero, oeAsientoModel As e_AsientoModelo) As Boolean

    <OperationContract()> _
    Function GuardarLetra(oeContratoFinanciero As e_ContratoFinanciero, oeAsientoModel As e_AsientoModelo, ln_TasaRetencion As Double) As Boolean

    <OperationContract()> _
    Function GuardarFec(oeContratoFinanciero As e_ContratoFinanciero, oeAsientoModel As e_AsientoModelo) As Boolean

    <OperationContract()> _
    Function GuardarFedd(oeContratoFinanciero As e_ContratoFinanciero, oeAsientoModel As e_AsientoModelo) As Boolean

    <OperationContract()> _
    Function GuardarFactDesc(oeContratoFinanciero As e_ContratoFinanciero, leAsientoModel As List(Of e_AsientoModelo)) As Boolean

    <OperationContract()> _
    Function GuardarCreditoHipotecario(oeContratoFinanciero As e_ContratoFinanciero, oeAsientoModel As e_AsientoModelo) As Boolean

    <OperationContract()> _
    Function GuardarGastoFin(oeContratoFinanciero As e_ContratoFinanciero, oeAsientoModel As e_AsientoModelo) As Boolean

    <OperationContract()> _
    Function GuardarInteresMensualLeasing(oeContratoFinanciero As e_ContratoFinanciero, leAsientoModelo As List(Of e_AsientoModelo)) As Boolean

    <OperationContract()> _
    Function GuardarInteresMensualPagare(oeContratoFinanciero As e_ContratoFinanciero, oeAsientoModelo As e_AsientoModelo) As Boolean

    <OperationContract()> _
    Function GuardarInteresMensualFec(oeContratoFinanciero As e_ContratoFinanciero, leAsientoModelo As List(Of e_AsientoModelo)) As Boolean

    <OperationContract()> _
    Function GuardarInteresMensualFed(oeContratoFinanciero As e_ContratoFinanciero, oeAsientoModelo As e_AsientoModelo) As Boolean

    <OperationContract()> _
    Function GuardarInteresMensualLeasingReversion(oeContratoFinanciero As e_ContratoFinanciero, leAsientoModelo As List(Of e_AsientoModelo)) As Boolean

    <OperationContract()> _
    Function GuardarInteresMensualCreditoHipotecario(oeContratoFinanciero As e_ContratoFinanciero, leAsientoModelo As List(Of e_AsientoModelo)) As Boolean

    <OperationContract()> _
    Function GuardarInteresMensualPuenteCreHip(oeContratoFinanciero As e_ContratoFinanciero, leAsientoModelo As List(Of e_AsientoModelo)) As Boolean

    <OperationContract()> _
    Function Listar(oeContratoFinanciero As e_ContratoFinanciero) As List(Of e_ContratoFinanciero)

    <OperationContract()> _
    Function ListarDS(oeContratoFinanciero As e_ContratoFinanciero) As System.Data.DataSet

    <OperationContract()> _
    Function e_ContratoFinanciero(oeContratoFinanciero As e_ContratoFinanciero) As e_ContratoFinanciero

End Interface
