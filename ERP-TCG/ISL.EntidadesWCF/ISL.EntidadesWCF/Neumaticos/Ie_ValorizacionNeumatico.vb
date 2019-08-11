Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_ValorizacionNeumatico", también debe actualizar la referencia a "Ie_ValorizacionNeumatico" en Web.config.
<ServiceContract()> _
Public Interface Ie_ValorizacionNeumatico

    <OperationContract()> _
    Function Obtener(ByVal valorizacionNeumatico As e_ValorizacionNeumatico) As e_ValorizacionNeumatico

End Interface
