Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_ConfiguracionNeumatico", también debe actualizar la referencia a "Ie_ConfiguracionNeumatico" en Web.config.
<ServiceContract()> _
Public Interface Ie_ConfiguracionNeumatico

    <OperationContract()> _
    Function Obtener(ByVal configuracionNeumatico As e_ConfiguracionNeumatico) As e_ConfiguracionNeumatico

End Interface
