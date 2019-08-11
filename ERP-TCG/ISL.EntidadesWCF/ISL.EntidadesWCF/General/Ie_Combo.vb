Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Combo", también debe actualizar la referencia a "Ie_Combo" en Web.config.
<ServiceContract()> _
Public Interface Ie_Combo

    <OperationContract()> _
    Function Obtener(ByVal combo As e_Combo) As e_Combo

End Interface
