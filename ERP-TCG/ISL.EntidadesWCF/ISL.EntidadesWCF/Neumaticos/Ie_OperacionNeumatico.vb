Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_OperacionNeumatico", también debe actualizar la referencia a "Ie_OperacionNeumatico" en Web.config.
<ServiceContract()> _
Public Interface Ie_OperacionNeumatico

    <OperationContract()> _
    Function Obtener(ByVal operacionNeumatico As e_OperacionNeumatico) As e_OperacionNeumatico

End Interface
