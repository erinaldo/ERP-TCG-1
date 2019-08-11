Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_FondoFijo", también debe actualizar la referencia a "Il_FondoFijo" en Web.config.
<ServiceContract()> _
Public Interface Il_FondoFijo

    <OperationContract()> _
    Function Obtener(ByVal oeFondoFijo As e_FondoFijo) As e_FondoFijo

    <OperationContract()> _
    Function Listar(ByVal oeFondoFijo As e_FondoFijo) As List(Of e_FondoFijo)

    <OperationContract()> _
    Function Validar(ByVal oeFondoFijo As e_FondoFijo) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeFondoFijo As e_FondoFijo) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeFondoFijo As e_FondoFijo) As Boolean

End Interface
