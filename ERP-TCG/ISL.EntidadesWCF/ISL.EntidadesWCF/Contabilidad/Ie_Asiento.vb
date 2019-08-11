Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Asiento", también debe actualizar la referencia a "Ie_Asiento" en Web.config.
<ServiceContract()> _
Public Interface Ie_Asiento

    <OperationContract()> _
    Function Obtener(ByVal asiento As e_Asiento) As e_Asiento

End Interface
