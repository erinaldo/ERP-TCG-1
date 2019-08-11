Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_MontoCaja", también debe actualizar la referencia a "Il_MontoCaja" en Web.config.
<ServiceContract()> _
Public Interface Il_MontoCaja

    <OperationContract()> _
    Function Obtener(ByVal oeMontoCaja As e_MontoCaja) As e_MontoCaja

    <OperationContract()> _
    Function Listar(ByVal oeMontoCaja As e_MontoCaja) As List(Of e_MontoCaja)

    <OperationContract()> _
    Function Validar(ByVal oeMontoCaja As e_MontoCaja) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeMontoCaja As e_MontoCaja) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeMontoCaja As e_MontoCaja) As Boolean

End Interface
