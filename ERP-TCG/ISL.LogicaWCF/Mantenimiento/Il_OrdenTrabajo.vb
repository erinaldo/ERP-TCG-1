Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_OrdenTrabajo", también debe actualizar la referencia a "Il_OrdenTrabajo" en Web.config.
<ServiceContract()> _
Public Interface Il_OrdenTrabajo

    <OperationContract()> _
    Function Obtener(ByVal oeOrdenTrabajo As e_OrdenTrabajo) As e_OrdenTrabajo

    <OperationContract()> _
    Function Listar(ByVal oeOrdenTrabajo As e_OrdenTrabajo) As Data.DataSet

    <OperationContract()> _
    Function ListarReporteCE(ByVal oeReporteCE As e_ReporteConsumoEquipo) As List(Of e_ReporteConsumoEquipo)

    <OperationContract()> _
    Function ListarRMDOT(ByVal oeReporteMDOT As e_MovimientoDiarioOT) As List(Of e_MovimientoDiarioOT)

    <OperationContract()> _
    Function Validar(ByVal oeOrdenTrabajo As e_OrdenTrabajo) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeOrdenTrabajo As e_OrdenTrabajo) As String

    <OperationContract()> _
    Function ActualizaEstadoOT(ByVal oeOrdenTrabajo As e_OrdenTrabajo) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeOrdenTrabajo As e_OrdenTrabajo) As Boolean

    <OperationContract()> _
    Function ObtieneGlosa(ByVal leOTMaterial As List(Of e_OrdenTrabajo_Material), ByVal Equipo As String) As String


End Interface
