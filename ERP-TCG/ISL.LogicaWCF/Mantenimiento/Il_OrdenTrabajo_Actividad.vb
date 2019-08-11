Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_OrdenTrabajo_Actividad", también debe actualizar la referencia a "Il_OrdenTrabajo_Actividad" en Web.config.
<ServiceContract()> _
Public Interface Il_OrdenTrabajo_Actividad

    <OperationContract()> _
    Function Obtener(ByVal oeOrdenTrabajo_Actividad As e_OrdenTrabajo_Actividad) As e_OrdenTrabajo_Actividad

    <OperationContract()> _
    Function Listar(ByVal oeOrdenTrabajo_Actividad As e_OrdenTrabajo_Actividad) As List(Of e_OrdenTrabajo_Actividad)

    <OperationContract()> _
    Function ListarDataSet(ByVal ls_IdOrdenTrabajo As String) As Data.DataSet

    <OperationContract()> _
    Function Validar(ByVal oeOrdenTrabajo_Actividad As e_OrdenTrabajo_Actividad) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeOrdenTrabajo_Actividad As e_OrdenTrabajo_Actividad) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeOrdenTrabajo_Actividad As e_OrdenTrabajo_Actividad) As Boolean

End Interface
