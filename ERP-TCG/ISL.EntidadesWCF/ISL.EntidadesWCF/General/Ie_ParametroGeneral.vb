Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_ParametroGeneral", también debe actualizar la referencia a "Ie_ParametroGeneral" en Web.config.
<ServiceContract()> _
Public Interface Ie_ParametroGeneral

    <OperationContract()> _
    Function Obtener(ByVal parametroGeneral As e_ParametroGeneral) As e_ParametroGeneral

End Interface
