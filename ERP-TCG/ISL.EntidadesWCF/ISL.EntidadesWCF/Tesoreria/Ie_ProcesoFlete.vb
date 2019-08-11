Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_ProcesoFlete", también debe actualizar la referencia a "Ie_ProcesoFlete" en Web.config.
<ServiceContract()> _
Public Interface Ie_ProcesoFlete

    <OperationContract()> _
    Function Obtener(ByVal procesoFlete As e_ProcesoFlete) As e_ProcesoFlete

End Interface
