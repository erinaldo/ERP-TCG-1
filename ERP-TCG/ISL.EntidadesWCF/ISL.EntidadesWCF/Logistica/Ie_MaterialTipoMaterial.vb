Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_MaterialTipoMaterial", también debe actualizar la referencia a "Ie_MaterialTipoMaterial" en Web.config.
<ServiceContract()> _
Public Interface Ie_MaterialTipoMaterial

    <OperationContract()> _
    Function Obtener(ByVal materialTipoMaterial As e_MaterialTipoMaterial) As e_MaterialTipoMaterial

End Interface
