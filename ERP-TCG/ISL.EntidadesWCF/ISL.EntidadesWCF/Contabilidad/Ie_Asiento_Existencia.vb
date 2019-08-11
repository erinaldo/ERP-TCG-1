Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Asiento_Existencia", también debe actualizar la referencia a "Ie_Asiento_Existencia" en Web.config.
<ServiceContract()> _
Public Interface Ie_Asiento_Existencia

    <OperationContract()> _
    Function Obtener(ByVal asiento_existencia As e_Asiento_Existencia) As e_Asiento_Existencia

End Interface
