Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_CCPP", también debe actualizar la referencia a "Ie_CCPP" en Web.config.
<ServiceContract()> _
Public Interface Ie_CCPP

    <OperationContract()> _
    Function Obtener(ByVal centroPoblado As e_CCPP) As e_CCPP

End Interface
