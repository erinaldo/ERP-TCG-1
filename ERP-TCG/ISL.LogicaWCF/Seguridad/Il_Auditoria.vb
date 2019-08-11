Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Auditoria", también debe actualizar la referencia a "Il_Auditoria" en Web.config.
<ServiceContract()> _
Public Interface Il_Auditoria

    <OperationContract()> _
   Function Obtener(ByVal oeAuditoria As e_Auditoria) As e_Auditoria

    <OperationContract()> _
    Function Listar(ByVal oeAuditoria As e_Auditoria) As List(Of e_Auditoria)

    <OperationContract()> _
    Function Guardar(ByVal oeAuditoria As e_Auditoria) As Boolean

End Interface
