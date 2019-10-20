Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_OrdenTrabajo_Recurso", también debe actualizar la referencia a "Il_OrdenTrabajo_Recurso" en Web.config.
<ServiceContract()> _
Public Interface Il_OrdenTrabajo_Recurso

    <OperationContract()> _
    Function Obtener(ByVal oeOrdenTrabajo_Recurso As e_OrdenTrabajo_Recurso) As e_OrdenTrabajo_Recurso

    <OperationContract()> _
    Function Listar(ByVal oeOrdenTrabajo_Recurso As e_OrdenTrabajo_Recurso) As List(Of e_OrdenTrabajo_Recurso)

    <OperationContract()> _
    Function ListarDataSet(ByVal ls_IdOrdenTrabajo As String) As Data.DataSet

    <OperationContract()> _
    Function Validar(ByVal oeOrdenTrabajo_Recurso As e_OrdenTrabajo_Recurso) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeOrdenTrabajo_Recurso As e_OrdenTrabajo_Recurso) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeOrdenTrabajo_Recurso As e_OrdenTrabajo_Recurso) As Boolean

End Interface
