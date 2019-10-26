Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_CuentaContable", también debe actualizar la referencia a "Il_CuentaContable" en Web.config.
<ServiceContract()> _
Public Interface Il_CuentaContable

    <OperationContract()> _
    Function Obtener(ByVal oeCuentaContable As e_CuentaContable) As e_CuentaContable

    <OperationContract()> _
    Function Listar(ByVal oeCuentaContable As e_CuentaContable) As List(Of e_CuentaContable)

    <OperationContract()> _
    Function Validar(ByVal oeCuentaContable As e_CuentaContable) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeCuentaContable As e_CuentaContable) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeCuentaContable As e_CuentaContable) As Boolean

    <OperationContract()> _
    Function ComboGrilla(ByVal oeMaterialAlmacen As e_CuentaContable)
End Interface
