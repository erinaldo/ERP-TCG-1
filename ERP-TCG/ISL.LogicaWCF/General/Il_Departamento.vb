Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Departamento", también debe actualizar la referencia a "Il_Departamento" en Web.config.
<ServiceContract()> _
Public Interface Il_Departamento

    <OperationContract()> _
    Function Obtener(ByVal oeDepartamento As e_Departamento) As e_Departamento

    <OperationContract()> _
    Function Listar(ByVal oeDepartamento As e_Departamento) As List(Of e_Departamento)

    <OperationContract()> _
    Function Guardar(ByVal oeDepartamento As e_Departamento) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeDepartamento As e_Departamento) As Boolean

    <OperationContract()> _
    Function Validar(ByVal oeDepartamento As e_Departamento) As Boolean

End Interface
