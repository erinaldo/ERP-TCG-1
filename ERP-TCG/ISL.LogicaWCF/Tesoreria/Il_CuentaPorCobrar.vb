Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_CuentaPorCobrar", también debe actualizar la referencia a "Il_CuentaPorCobrar" en Web.config.
<ServiceContract()> _
Public Interface Il_CuentaPorCobrar

    <OperationContract()> _
    Function Obtener(ByVal oeCuentaPorCobrar As e_CuentaPorCobrar) As e_CuentaPorCobrar

    <OperationContract()> _
    Function Listar(ByVal oeCuentaPorCobrar As e_CuentaPorCobrar) As List(Of e_CuentaPorCobrar)

    <OperationContract()> _
    Function Validar(ByVal oeCuentaPorCobrar As e_CuentaPorCobrar) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeCuentaPorCobrar As e_CuentaPorCobrar) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeCuentaPorCobrar As e_CuentaPorCobrar) As Boolean

End Interface
