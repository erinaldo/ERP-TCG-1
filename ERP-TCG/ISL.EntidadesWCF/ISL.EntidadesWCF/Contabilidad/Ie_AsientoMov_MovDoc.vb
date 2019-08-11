Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_AsientoMov_MovDoc", también debe actualizar la referencia a "Ie_AsientoMov_MovDoc" en Web.config.
<ServiceContract()> _
Public Interface Ie_AsientoMov_MovDoc

    <OperationContract()> _
    Function Obtener(ByVal asientoMov_MovDoc As e_AsientoMov_MovDoc) As e_AsientoMov_MovDoc

End Interface
