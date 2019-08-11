Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_ConceptosGenerales", también debe actualizar la referencia a "Ie_ConceptosGenerales" en Web.config.
<ServiceContract()> _
Public Interface Ie_ConceptosGenerales

    <OperationContract()> _
    Function Obtener(ByVal conceptosGenerales As e_ConceptosGenerales) As e_ConceptosGenerales

End Interface
