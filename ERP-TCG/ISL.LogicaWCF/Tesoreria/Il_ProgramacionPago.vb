Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_ProgramacionPago", también debe actualizar la referencia a "Il_ProgramacionPago" en Web.config.
<ServiceContract()> _
Public Interface Il_ProgramacionPago
    <OperationContract()> _
    Function ObtenerLote(ByVal oeProgramacionPago As e_ProgramacionPago) As e_ProgramacionPago
    <OperationContract()> _
    Function Guardar(ByVal oeProgramacionPago As e_ProgramacionPago) As Boolean
    <OperationContract()> _
    Function ListarProgramacionPagos(ByVal oeProgramacionPago As e_ProgramacionPago) As DataTable
End Interface
