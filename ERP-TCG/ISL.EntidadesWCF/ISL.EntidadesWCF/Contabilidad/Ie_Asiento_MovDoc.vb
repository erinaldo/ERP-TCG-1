Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Asiento_MovDoc", también debe actualizar la referencia a "Ie_Asiento_MovDoc" en Web.config.
<ServiceContract()> _
Public Interface Ie_Asiento_MovDoc

    <OperationContract()> _
    Function Obtener(ByVal asiento_MovDoc As e_Asiento_MovDoc) As e_Asiento_MovDoc

End Interface
