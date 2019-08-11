Imports System.ServiceModel
Imports ISL.EntidadesWCF
' NOTA: si cambia aquí el nombre de clase "Il_TarifasCliente", también debe actualizar la referencia a "Il_TarifasCliente" en Web.config.
<ServiceContract()> _
Public Interface Il_TarifasCliente

    '<OperationContract()> _
    'Sub DoWork()

    <OperationContract()> _
    Function Obtener(ByVal oeTarifasCliente As e_TarifasCliente) As e_TarifasCliente

    <OperationContract()> _
    Function Listar(ByVal oeTarifasCliente As e_TarifasCliente) As List(Of e_TarifasCliente)

    <OperationContract()> _
    Function ListarTarifas(ByVal oeTarifasCliente As e_TarifasCliente) As DataTable

    <OperationContract()> _
    Function Validar(ByVal oeTarifasCliente As e_TarifasCliente) As Boolean


    <OperationContract()> _
    Function Guardar(ByVal oeTarifasCliente As e_TarifasCliente) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeTarifasCliente As e_TarifasCliente) As Boolean

End Interface
