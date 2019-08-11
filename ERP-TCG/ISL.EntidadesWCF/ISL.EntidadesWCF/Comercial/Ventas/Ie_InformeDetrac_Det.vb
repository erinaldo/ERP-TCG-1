Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_InformeDetrac_Det", también debe actualizar la referencia a "Ie_InformeDetrac_Det" en Web.config.
<ServiceContract()> _
Public Interface Ie_InformeDetrac_Det

    <OperationContract()> _
    Function Obtener(ByVal informeDetrac_Det As e_InformeDetrac_Det) As e_InformeDetrac_Det

End Interface
