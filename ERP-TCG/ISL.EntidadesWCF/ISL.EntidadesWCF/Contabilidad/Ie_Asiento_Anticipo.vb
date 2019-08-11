Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Asiento_Anticipo", también debe actualizar la referencia a "Ie_Asiento_Anticipo" en Web.config.
<ServiceContract()> _
Public Interface Ie_Asiento_Anticipo

    <OperationContract()> _
    Function Obtener(ByVal asiento_anticipo As e_Asiento_Anticipo) As e_Asiento_Anticipo

End Interface
