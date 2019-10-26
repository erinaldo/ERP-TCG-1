Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_DetalleProgramacionPago", también debe actualizar la referencia a "Il_DetalleProgramacionPago" en Web.config.
<ServiceContract()> _
Public Interface Il_DetalleProgramacionPago
    <OperationContract()> _
    Function Listar(ByVal oeDetalleProgramacionPago As e_DetalleProgramacionPago) As DataTable
    <OperationContract()> _
    Function Guardar(ByVal oeDetalleProgramacionPago As e_DetalleProgramacionPago) As Boolean
End Interface
