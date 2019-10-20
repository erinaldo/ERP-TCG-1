Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Sancion", también debe actualizar la referencia a "Il_Sancion" en Web.config.
<ServiceContract()> _
Public Interface Il_Sancion

    <OperationContract()> _
    Function Obtener(ByVal oeSancion As e_Sancion) As e_Sancion

    <OperationContract()> _
    Function Listar(ByVal oeSancion As e_Sancion) As List(Of e_Sancion)

    <OperationContract()> _
    Function Validar(ByVal oeSancion As e_Sancion) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeSancion As e_Sancion) As Boolean

    <OperationContract()> _
    Function GuardarLista(ByVal leSancion As List(Of e_Sancion)) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeSancion As e_Sancion) As Boolean



End Interface
