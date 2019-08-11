Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_ChequesControl", también debe actualizar la referencia a "Ie_ChequesControl" en Web.config.
<ServiceContract()> _
Public Interface Ie_ChequesControl


    <OperationContract()> _
    Function Obtener(ByVal chequescontrol As e_ChequesControl) As e_ChequesControl

End Interface
