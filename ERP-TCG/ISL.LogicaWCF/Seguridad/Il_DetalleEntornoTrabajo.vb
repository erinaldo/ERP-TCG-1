Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_DetalleEntornoTrabajo", también debe actualizar la referencia a "Il_DetalleEntornoTrabajo" en Web.config.
<ServiceContract()> _
Public Interface Il_DetalleEntornoTrabajo

    <OperationContract()> _
    Function Obtener(ByVal oeDetalleEntornoTrabajo As e_DetalleEntornoTrabajo) As e_DetalleEntornoTrabajo

    <OperationContract()> _
    Function Listar(ByVal oeDetalleEntornoTrabajo As e_DetalleEntornoTrabajo) As List(Of e_DetalleEntornoTrabajo)

    <OperationContract()> _
    Function Validar(ByVal oeDetalleEntornoTrabajo As e_DetalleEntornoTrabajo) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeDetalleEntornoTrabajo As e_DetalleEntornoTrabajo) As Boolean

    <OperationContract()> _
    Function GuardarLista(ByVal leDetalleEntornoTrabajo As List(Of e_DetalleEntornoTrabajo)) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeDetalleEntornoTrabajo As e_DetalleEntornoTrabajo) As Boolean

End Interface
