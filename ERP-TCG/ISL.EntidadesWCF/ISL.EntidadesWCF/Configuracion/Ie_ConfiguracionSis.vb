Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_ConfiguracionSis", también debe actualizar la referencia a "Ie_ConfiguracionSis" en Web.config.
<ServiceContract()> _
Public Interface Ie_ConfiguracionSis

    <OperationContract()> _
    Function Obtener(ByVal configuracionSis As e_ConfiguracionSis) As e_ConfiguracionSis

End Interface
