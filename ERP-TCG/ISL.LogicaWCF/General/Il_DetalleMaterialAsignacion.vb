Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_DetalleMaterialAsignacion", también debe actualizar la referencia a "Il_DetalleMaterialAsignacion" en Web.config.
<ServiceContract()> _
Public Interface Il_DetalleMaterialAsignacion

    <OperationContract()> _
    Function Obtener(ByVal oeDetalleMaterialAsignacion As e_DetalleMaterialAsignacion) As e_DetalleMaterialAsignacion

    <OperationContract()> _
    Function Listar(ByVal oeDetalleMaterialAsignacion As e_DetalleMaterialAsignacion) As List(Of e_DetalleMaterialAsignacion)

    <OperationContract()> _
    Function ListarDetalle(ByVal oeDetalleMaterial As e_DetalleMaterialAsignacion) As DataSet

    <OperationContract()> _
    Function Validar(ByVal oeDetalleMaterialAsignacion As e_DetalleMaterialAsignacion) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeDetalleMaterialAsignacion As e_DetalleMaterialAsignacion) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeDetalleMaterialAsignacion As e_DetalleMaterialAsignacion) As Boolean

End Interface
