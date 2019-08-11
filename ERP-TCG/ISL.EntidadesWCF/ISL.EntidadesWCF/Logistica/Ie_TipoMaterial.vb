Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_TipoMaterial", también debe actualizar la referencia a "Ie_TipoMaterial" en Web.config.
<ServiceContract()> _
Public Interface Ie_TipoMaterial

    <OperationContract()> _
    Function Obtener(ByVal tipoMaterial As e_TipoMaterial) As e_TipoMaterial

End Interface
