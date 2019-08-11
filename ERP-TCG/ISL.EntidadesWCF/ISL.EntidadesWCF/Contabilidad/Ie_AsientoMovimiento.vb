Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_AsientoMovimiento", también debe actualizar la referencia a "Ie_AsientoMovimiento" en Web.config.
<ServiceContract()> _
Public Interface Ie_AsientoMovimiento

    <OperationContract()> _
    Function Obtener(ByVal asientoMovimiento As e_AsientoMovimiento) As e_AsientoMovimiento

End Interface
