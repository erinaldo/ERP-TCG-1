Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_SubFamiliaMaterial", también debe actualizar la referencia a "Ie_SubFamiliaMaterial" en Web.config.
<ServiceContract()> _
Public Interface Ie_SubFamiliaMaterial

    <OperationContract()> _
    Function Obtener(ByVal subFamiliaMaterial As e_SubFamiliaMaterial) As e_SubFamiliaMaterial

End Interface
