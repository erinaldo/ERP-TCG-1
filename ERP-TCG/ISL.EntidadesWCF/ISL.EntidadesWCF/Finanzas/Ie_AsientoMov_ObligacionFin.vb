Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_AsientoMov_ObligacionFin", también debe actualizar la referencia a "Ie_AsientoMov_ObligacionFin" en Web.config.
<ServiceContract()> _
Public Interface Ie_AsientoMov_ObligacionFin

    <OperationContract()> _
    Function Obtener(ByVal asientoMov_ObligacionFin As e_AsientoMov_ObligacionFin) As e_AsientoMov_ObligacionFin

End Interface
