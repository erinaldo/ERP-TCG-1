Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_ConfiguracionSisDet", también debe actualizar la referencia a "Ie_ConfiguracionSisDet" en Web.config.
<ServiceContract()> _
Public Interface Ie_ConfiguracionSisDet

    <OperationContract()> _
    Function Obtener(ByVal configuracionSisDet As e_ConfiguracionSisDet) As e_ConfiguracionSisDet

End Interface
