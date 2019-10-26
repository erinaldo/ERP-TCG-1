Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Telefono", también debe actualizar la referencia a "Il_Telefono" en Web.config.
<ServiceContract()> _
Public Interface Il_Telefono

    <OperationContract()> _
    Function Obtener(ByVal oeTelefono As e_Telefono) As e_Telefono

    <OperationContract()> _
    Function Listar(ByVal oeTelefono As e_Telefono) As List(Of e_Telefono)

    <OperationContract()> _
    Function ValidarNombre(ByVal oeTelefono As e_Telefono) As Boolean

    <OperationContract()> _
    Function Validar(ByVal oeTelefono As e_Telefono) As Boolean

    <OperationContract()> _
    Function ValidarLista(ByVal leTelefono As List(Of e_Telefono)) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeTelefono As e_Telefono) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeTelefono As e_Telefono) As Boolean

End Interface
