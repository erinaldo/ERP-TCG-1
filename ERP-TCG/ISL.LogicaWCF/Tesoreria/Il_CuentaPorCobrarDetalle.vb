Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_CuentaPorCobrarDetalle", también debe actualizar la referencia a "Il_CuentaPorCobrarDetalle" en Web.config.
<ServiceContract()> _
Public Interface Il_CuentaPorCobrarDetalle

    <OperationContract()> _
    Function Obtener(ByVal oeCuentaPorCobrarDetalle As e_CuentaPorCobrarDetalle) As e_CuentaPorCobrarDetalle

    <OperationContract()> _
    Function Listar(ByVal oeCuentaPorCobrarDetalle As e_CuentaPorCobrarDetalle) As List(Of e_CuentaPorCobrarDetalle)

    <OperationContract()> _
    Function Validar(ByVal oeCuentaPorCobrarDetalle As e_CuentaPorCobrarDetalle) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeCuentaPorCobrarDetalle As e_CuentaPorCobrarDetalle) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeCuentaPorCobrarDetalle As e_CuentaPorCobrarDetalle) As Boolean

End Interface
