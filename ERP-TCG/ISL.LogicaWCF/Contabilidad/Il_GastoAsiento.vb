Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_GastoAsiento", también debe actualizar la referencia a "Il_GastoAsiento" en Web.config.
<ServiceContract()> _
Public Interface Il_GastoAsiento

    <OperationContract()> _
    Function Obtener(ByVal oeGastoAsiento As e_GastoAsiento) As e_GastoAsiento

    <OperationContract()> _
    Function Listar(ByVal oeGastoAsiento As e_GastoAsiento) As List(Of e_GastoAsiento)

    <OperationContract()> _
    Function Validar(ByVal oeGastoAsiento As e_GastoAsiento) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeGastoAsiento As e_GastoAsiento) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeGastoAsiento As e_GastoAsiento) As Boolean

    <OperationContract()> _
    Function ListarGAAnalisis(oeGastoAsiento As e_GastoAsiento) As DataTable

End Interface
