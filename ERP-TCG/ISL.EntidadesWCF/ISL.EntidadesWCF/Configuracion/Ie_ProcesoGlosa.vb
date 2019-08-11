Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_ProcesoGlosa", también debe actualizar la referencia a "Ie_ProcesoGlosa" en Web.config.
<ServiceContract()> _
Public Interface Ie_ProcesoGlosa

    <OperationContract()> _
    Function Obtener(ByVal procesoGlosa As e_ProcesoGlosa) As e_ProcesoGlosa

End Interface
