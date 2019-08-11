Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_RequerimientoMaterial", también debe actualizar la referencia a "Ie_RequerimientoMaterial" en Web.config.
<ServiceContract()> _
Public Interface Ie_RequerimientoMaterial

    <OperationContract()> _
    Function Obtener(ByVal requerimientoMaterial As e_RequerimientoMaterial) As e_RequerimientoMaterial

End Interface
