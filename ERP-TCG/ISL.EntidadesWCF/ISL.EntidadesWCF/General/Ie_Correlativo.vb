Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Correlativo", también debe actualizar la referencia a "Ie_Correlativo" en Web.config.
<ServiceContract()> _
Public Interface Ie_Correlativo

    <OperationContract()> _
    Function Obtener(ByVal correlativo As e_Correlativo) As e_Correlativo

End Interface
