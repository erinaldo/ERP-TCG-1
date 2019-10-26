Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_CuentaFlujoCaja", también debe actualizar la referencia a "Il_CuentaFlujoCaja" en Web.config.
<ServiceContract()> _
Public Interface Il_CuentaFlujoCaja

    <OperationContract()> _
    Function Obtener(ByVal oeCuentaFlujoCaja As e_CuentaFlujoCaja) As e_CuentaFlujoCaja

    <OperationContract()> _
    Function Listar(ByVal oeCuentaFlujoCaja As e_CuentaFlujoCaja) As List(Of e_CuentaFlujoCaja)

    <OperationContract()> _
    Function Validar(ByVal oeCuentaFlujoCaja As e_CuentaFlujoCaja) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeCuentaFlujoCaja As e_CuentaFlujoCaja) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeCuentaFlujoCaja As e_CuentaFlujoCaja) As Boolean

End Interface
