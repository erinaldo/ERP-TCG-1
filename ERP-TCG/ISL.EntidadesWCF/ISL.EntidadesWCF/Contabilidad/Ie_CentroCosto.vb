Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_CentroCosto", también debe actualizar la referencia a "Ie_CentroCosto" en Web.config.
<ServiceContract()> _
Public Interface Ie_CentroCosto

    <OperationContract()> _
    Function Obtener(ByVal centroCosto As e_CentroCosto) As e_CentroCosto

End Interface
