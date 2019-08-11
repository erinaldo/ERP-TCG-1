Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_ProcesoFlujoCaja", también debe actualizar la referencia a "Ie_ProcesoFlujoCaja" en Web.config.
<ServiceContract()> _
Public Interface Ie_ProcesoFlujoCaja

    <OperationContract()> _
    Function Obtener(ByVal procesoFlujoCaja As e_ProcesoFlujoCaja) As e_ProcesoFlujoCaja

End Interface
