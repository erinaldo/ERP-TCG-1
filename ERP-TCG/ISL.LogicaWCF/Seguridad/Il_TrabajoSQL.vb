Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_TrabajoSQL", también debe actualizar la referencia a "Il_TrabajoSQL" en Web.config.
<ServiceContract()> _
Public Interface Il_TrabajoSQL

    <OperationContract()> _
    Function Obtener(ByVal oeTrabajoSQL As e_TrabajoSQL) As e_TrabajoSQL

    <OperationContract()> _
    Function Listar(ByVal oeTrabajoSQL As e_TrabajoSQL) As List(Of e_TrabajoSQL)

    <OperationContract()> _
    Function Validar(ByVal oeTrabajoSQL As e_TrabajoSQL) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeTrabajoSQL As e_TrabajoSQL) As Boolean

    <OperationContract()> _
    Function ListarProcedimiento(ByVal NombreProcedimiento As String) As DataTable

End Interface
