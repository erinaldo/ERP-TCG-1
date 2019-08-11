Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_ConceptoIngresos", también debe actualizar la referencia a "Ie_ConceptoIngresos" en Web.config.
<ServiceContract()> _
Public Interface Ie_ConceptoIngresos

    <OperationContract()> _
     Function Obtener(ByVal conceptoingresos As e_ConceptoIngresos) As e_ConceptoIngresos

End Interface
