Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_ConfiguracionMTC", también debe actualizar la referencia a "Ie_ConfiguracionMTC" en Web.config.
<ServiceContract()> _
Public Interface Ie_ConfiguracionMTC

    <OperationContract()> _
    Function Obtener(ByVal configuracionMTC As e_ConfiguracionMTC) As e_ConfiguracionMTC

End Interface
