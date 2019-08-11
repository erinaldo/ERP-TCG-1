Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_OrdenTrabajo_MantenimientoEquipo", también debe actualizar la referencia a "Il_OrdenTrabajo_MantenimientoEquipo" en Web.config.
<ServiceContract()> _
Public Interface Il_OrdenTrabajo_MantenimientoEquipo

    <OperationContract()> _
    Function Obtener(ByVal oeOrdenTrabajo_MantenimientoEquipo As e_OrdenTrabajo_MantenimientoEquipo) As e_OrdenTrabajo_MantenimientoEquipo

    <OperationContract()> _
    Function Listar(ByVal oeOrdenTrabajo_MantenimientoEquipo As e_OrdenTrabajo_MantenimientoEquipo) As List(Of e_OrdenTrabajo_MantenimientoEquipo)

    <OperationContract()> _
    Function ListarDataSet(ByVal ls_IdOrdenTrabajo As String) As Data.DataSet

    <OperationContract()> _
    Function Validar(ByVal oeOrdenTrabajo_MantenimientoEquipo As e_OrdenTrabajo_MantenimientoEquipo) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeOrdenTrabajo_MantenimientoEquipo As e_OrdenTrabajo_MantenimientoEquipo) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeOrdenTrabajo_MantenimientoEquipo As e_OrdenTrabajo_MantenimientoEquipo) As Boolean

End Interface
