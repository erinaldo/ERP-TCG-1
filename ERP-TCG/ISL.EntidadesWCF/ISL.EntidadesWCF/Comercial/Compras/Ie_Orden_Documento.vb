Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Orden_Documento", también debe actualizar la referencia a "Ie_Orden_Documento" en Web.config.
<ServiceContract()> _
Public Interface Ie_Orden_Documento

    <OperationContract()> _
    Function Obtener(ByVal orden_Documento As e_Orden_Documento) As e_Orden_Documento

End Interface
