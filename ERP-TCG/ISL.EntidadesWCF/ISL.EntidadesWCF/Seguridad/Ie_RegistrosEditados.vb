Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_RegistrosEditados", también debe actualizar la referencia a "Ie_RegistrosEditados" en Web.config.
<ServiceContract()> _
Public Interface Ie_RegistrosEditados

    '<OperationContract()> _
    'Sub DoWork()
    <OperationContract()> _
    Function Obtener(ByVal RegistrosEditados As e_RegistrosEditados) As e_RegistrosEditados

End Interface
