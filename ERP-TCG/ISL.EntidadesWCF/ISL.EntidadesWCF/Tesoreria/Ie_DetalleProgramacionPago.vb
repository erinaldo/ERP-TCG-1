Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_DetalleProgramacionPago", también debe actualizar la referencia a "e_DetalleProgramacionPago" en Web.config.
<ServiceContract()> _
Public Interface Ie_DetalleProgramacionPago

    <OperationContract()> _
    Function Obtener(ByVal detalleprogramacionpago As e_DetalleProgramacionPago) As e_DetalleProgramacionPago

End Interface

