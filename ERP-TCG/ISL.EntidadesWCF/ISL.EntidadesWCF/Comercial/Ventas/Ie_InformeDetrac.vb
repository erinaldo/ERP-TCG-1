Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_InformeDetrac", también debe actualizar la referencia a "Ie_InformeDetrac" en Web.config.
<ServiceContract()> _
Public Interface Ie_InformeDetrac

    <OperationContract()> _
    Function Obtener(ByVal informeDetrac As e_InformeDetrac) As e_InformeDetrac

End Interface
