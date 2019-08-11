Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_OrdenAsignacion_Material", también debe actualizar la referencia a "Il_OrdenAsignacion_Material" en Web.config.
<ServiceContract()> _
Public Interface Il_OrdenAsignacion_Material

    <OperationContract()> _
    Function Obtener(ByVal oeOrdenAsignacion_Material As e_OrdenAsignacion_Material) As e_OrdenAsignacion_Material

    <OperationContract()> _
    Function Listar(ByVal oeOrdenAsignacion_Material As e_OrdenAsignacion_Material) As List(Of e_OrdenAsignacion_Material)

    <OperationContract()> _
    Function Validar(ByVal oeOrdenAsignacion_Material As e_OrdenAsignacion_Material) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeOrdenAsignacion_Material As e_OrdenAsignacion_Material) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeOrdenAsignacion_Material As e_OrdenAsignacion_Material) As Boolean

    <OperationContract()> _
    Function ListarUnidadAsignadaMaterial(ByVal oeUnidadAsignadaMaterial As e_OrdenAsignacion_Material) As DataSet

End Interface
