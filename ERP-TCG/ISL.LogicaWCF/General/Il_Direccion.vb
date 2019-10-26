Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Direccion", también debe actualizar la referencia a "Il_Direccion" en Web.config.
<ServiceContract()> _
Public Interface Il_Direccion

    <OperationContract()> _
    Function Obtener(ByVal oeDireccion As e_Direccion) As e_Direccion

    <OperationContract()> _
    Function Listar(ByVal oeDireccion As e_Direccion) As List(Of e_Direccion)

    <OperationContract()> _
    Function Validar(ByVal oeDireccion As e_Direccion) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeDireccion As e_Direccion) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeDireccion As e_Direccion) As Boolean

End Interface
