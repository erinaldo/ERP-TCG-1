Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_CajaMonto", también debe actualizar la referencia a "Ie_CajaMonto" en Web.config.
<ServiceContract()> _
Public Interface Ie_CajaMonto

    <OperationContract()> _
    Function Obtener(ByVal cajaMonto As e_CajaMonto) As e_CajaMonto

End Interface
