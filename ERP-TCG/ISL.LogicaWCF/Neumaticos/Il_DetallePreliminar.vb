Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_DetallePreliminar", también debe actualizar la referencia a "Il_DetallePreliminar" en Web.config.
<ServiceContract()> _
Public Interface Il_DetallePreliminar

    <OperationContract()> _
   Function Obtener(ByVal oeDetallePreliminar As e_DetallePreliminar) As e_DetallePreliminar

    <OperationContract()> _
    Function Listar(ByVal oeDetallePreliminar As e_DetallePreliminar) As List(Of e_DetallePreliminar)

    <OperationContract()> _
    Function Validar(ByVal oeDetallePreliminar As e_DetallePreliminar) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeDetallePreliminar As e_DetallePreliminar) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeDetallePreliminar As e_DetallePreliminar) As Boolean


End Interface
