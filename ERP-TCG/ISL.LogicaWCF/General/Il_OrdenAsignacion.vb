Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_OrdenAsignacion", también debe actualizar la referencia a "Il_OrdenAsignacion" en Web.config.
<ServiceContract()> _
Public Interface Il_OrdenAsignacion

    <OperationContract()> _
    Function Obtener(ByVal oeOrdenAsignacion As e_OrdenAsignacion) As e_OrdenAsignacion

    <OperationContract()> _
    Function Listar(ByVal oeOrdenAsignacion As e_OrdenAsignacion) As List(Of e_OrdenAsignacion)

    <OperationContract()> _
    Function ListarReporte(ByVal oeReporteOA As e_ReporteOA) As List(Of e_ReporteOA)

    <OperationContract()> _
    Function Validar(ByVal oeOrdenAsignacion As e_OrdenAsignacion) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeOrdenAsignacion As e_OrdenAsignacion) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeOrdenAsignacion As e_OrdenAsignacion) As Boolean

End Interface
