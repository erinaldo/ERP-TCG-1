Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_ConceptoGasto", también debe actualizar la referencia a "Ie_ConceptoGasto" en Web.config.
<ServiceContract()> _
Public Interface Ie_ConceptoGasto

    <OperationContract()> _
    Function Obtener(ByVal conceptoGasto As e_ConceptoGasto) As e_ConceptoGasto

End Interface
