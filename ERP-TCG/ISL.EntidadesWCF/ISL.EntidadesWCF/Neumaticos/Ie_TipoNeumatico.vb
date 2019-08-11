Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_TipoNeumatico", también debe actualizar la referencia a "Ie_TipoNeumatico" en Web.config.
<ServiceContract()> _
Public Interface Ie_TipoNeumatico

    <OperationContract()> _
    Function Obtener(ByVal tipoNeumatico As e_TipoNeumatico) As e_TipoNeumatico

End Interface
