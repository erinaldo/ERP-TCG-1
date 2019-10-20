Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Direccion_EmpresaPersona", también debe actualizar la referencia a "Il_Direccion_EmpresaPersona" en Web.config.
<ServiceContract()> _
Public Interface Il_Direccion_EmpresaPersona

    <OperationContract()> _
    Function Obtener(ByVal oeDireccion_EmpresaPersona As e_Direccion_EmpresaPersona) As e_Direccion_EmpresaPersona

    <OperationContract()> _
    Function Listar(ByVal oeDireccion_EmpresaPersona As e_Direccion_EmpresaPersona) As List(Of e_Direccion_EmpresaPersona)

    <OperationContract()> _
    Function ListarTodo(ByVal oeDireccion_EmpresaPersona As e_Direccion_EmpresaPersona) As List(Of e_Direccion_EmpresaPersona)

    <OperationContract()> _
    Function Validar(ByVal oeDireccion_EmpresaPersona As e_Direccion_EmpresaPersona) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeDireccion_EmpresaPersona As e_Direccion_EmpresaPersona) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeDireccion_EmpresaPersona As e_Direccion_EmpresaPersona) As Boolean

End Interface
