Imports System.ServiceModel
Imports ERP.EntidadesWCF
' NOTA: si cambia aquí el nombre de clase "Il_MaterialesNegociados", también debe actualizar la referencia a "Il_MaterialesNegociados" en Web.config.
<ServiceContract()> _
Public Interface Il_MaterialesNegociados

    <OperationContract()> _
    Function Obtener(ByVal oeMaterialesNegociados As e_MaterialesNegociados) As e_MaterialesNegociados

    <OperationContract()> _
    Function Listar(ByVal oeMaterialesNegociados As e_MaterialesNegociados) As DataSet

    <OperationContract()> _
    Function Validar(ByVal oeMaterialesNegociados As e_MaterialesNegociados) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeMaterialesNegociados As e_MaterialesNegociados) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeMaterialesNegociados As e_MaterialesNegociados) As Boolean

End Interface
