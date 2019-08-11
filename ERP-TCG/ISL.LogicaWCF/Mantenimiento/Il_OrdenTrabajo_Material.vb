Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_OrdenTrabajo_Material", también debe actualizar la referencia a "Il_OrdenTrabajo_Material" en Web.config.
<ServiceContract()> _
Public Interface Il_OrdenTrabajo_Material

    <OperationContract()> _
    Function Obtener(ByVal oeOrdenTrabajoMaterial As e_OrdenTrabajo_Material) As e_OrdenTrabajo_Material

    <OperationContract()> _
    Function Listar(ByVal oeOrdenTrabajoMaterial As e_OrdenTrabajo_Material) As List(Of e_OrdenTrabajo_Material)

    <OperationContract()> _
    Function ListarReporte(ByVal oeReporteOTM As e_ReporteOTMaterial) As List(Of e_ReporteOTMaterial)

    <OperationContract()> _
    Function ListarDataSet(ByVal ls_IdOrdenTrabajo As String) As Data.DataSet

    <OperationContract()> _
    Function Validar(ByVal oeOrdenTrabajoMaterial As e_OrdenTrabajo_Material) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeOrdenTrabajoMaterial As e_OrdenTrabajo_Material) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeOrdenTrabajoMaterial As e_OrdenTrabajo_Material) As Boolean

End Interface
