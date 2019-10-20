Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_CuentaItemGasto", también debe actualizar la referencia a "Il_CuentaItemGasto" en Web.config.
<ServiceContract()> _
Public Interface Il_CuentaItemGasto

    <OperationContract()> _
    Function Obtener(ByVal oeCuentaItemGasto As e_CuentaItemGasto) As e_CuentaItemGasto

    <OperationContract()> _
    Function Listar(ByVal oeCuentaItemGasto As e_CuentaItemGasto) As List(Of e_CuentaItemGasto)

    <OperationContract()> _
    Function Validar(ByVal oeCuentaItemGasto As e_CuentaItemGasto) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeCuentaItemGasto As e_CuentaItemGasto) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeCuentaItemGasto As e_CuentaItemGasto) As Boolean

End Interface
