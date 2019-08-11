Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_MaterialCuentaContable", también debe actualizar la referencia a "Il_MaterialCuentaContable" en Web.config.
<ServiceContract()> _
Public Interface Il_MaterialCuentaContable

    <OperationContract()> _
    Function Obtener(ByVal oeMaterialCuentaContable As e_MaterialCuentaContable) As e_MaterialCuentaContable

    <OperationContract()> _
    Function Listar(ByVal oeMaterialCuentaContable As e_MaterialCuentaContable) As List(Of e_MaterialCuentaContable)

    <OperationContract()> _
    Function Validar(ByVal oeMaterialCuentaContable As e_MaterialCuentaContable) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeMaterialCuentaContable As e_MaterialCuentaContable) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeMaterialCuentaContable As e_MaterialCuentaContable) As Boolean

End Interface
