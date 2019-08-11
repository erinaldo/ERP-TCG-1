Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_FamiliaMaterial", también debe actualizar la referencia a "Ie_FamiliaMaterial" en Web.config.
<ServiceContract()> _
Public Interface Ie_FamiliaMaterial

    <OperationContract()> _
    Function Obtener(ByVal familiaMaterial As e_FamiliaMaterial) As e_FamiliaMaterial

End Interface
