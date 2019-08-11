Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_MetasCombustible", también debe actualizar la referencia a "Ie_MetasCombustible" en Web.config.
<ServiceContract()> _
Public Interface Ie_MetasCombustible

    <OperationContract()> _
     Function Obtener(ByVal metasCombustible As e_MetasCombustible) As e_MetasCombustible

End Interface
