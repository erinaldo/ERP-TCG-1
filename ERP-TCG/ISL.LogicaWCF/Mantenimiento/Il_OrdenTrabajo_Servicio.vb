Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_OrdenTrabajo_Servicio", también debe actualizar la referencia a "Il_OrdenTrabajo_Servicio" en Web.config.
<ServiceContract()> _
Public Interface Il_OrdenTrabajo_Servicio

    <OperationContract()> _
    Function Obtener(ByVal oeOrdenTrabajo_Servicio As e_OrdenTrabajo_Servicio) As e_OrdenTrabajo_Servicio

    <OperationContract()> _
    Function Listar(ByVal oeOrdenTrabajo_Servicio As e_OrdenTrabajo_Servicio) As List(Of e_OrdenTrabajo_Servicio)

    <OperationContract()> _
    Function ListarReporte(ByVal oeReporteOTS As e_ReporteOTServicio) As List(Of e_ReporteOTServicio)

    <OperationContract()> _
    Function ListarDataSet(ByVal ls_OrdenTrabajo As String) As Data.DataSet

    <OperationContract()> _
    Function Validar(ByVal oeOrdenTrabajo_Servicio As e_OrdenTrabajo_Servicio) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeOrdenTrabajo_Servicio As e_OrdenTrabajo_Servicio) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeOrdenTrabajo_Servicio As e_OrdenTrabajo_Servicio) As Boolean

End Interface
