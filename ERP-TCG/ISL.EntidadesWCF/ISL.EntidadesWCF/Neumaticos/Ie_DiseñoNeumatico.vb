Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_DiseñoNeumatico", también debe actualizar la referencia a "Ie_DiseñoNeumatico" en Web.config.
<ServiceContract()> _
Public Interface Ie_DiseñoNeumatico

    <OperationContract()> _
    Function Obtener(ByVal diseñoNeumatico As e_DiseñoNeumatico) As e_DiseñoNeumatico

End Interface
