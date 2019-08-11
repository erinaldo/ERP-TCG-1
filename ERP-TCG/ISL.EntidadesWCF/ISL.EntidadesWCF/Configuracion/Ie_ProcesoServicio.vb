Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_ProcesoServicio", también debe actualizar la referencia a "Ie_ProcesoServicio" en Web.config.
<ServiceContract()> _
Public Interface Ie_ProcesoServicio

    <OperationContract()> _
    Function Obtener(ByVal procesoServicio As e_ProcesoServicio) As e_ProcesoServicio

End Interface
