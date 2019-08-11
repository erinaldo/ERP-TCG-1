Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_TrabajadorSeguridad", también debe actualizar la referencia a "Ie_TrabajadorSeguridad" en Web.config.
<ServiceContract()> _
Public Interface Ie_TrabajadorSeguridad

    <OperationContract()> _
    Function Obtener(ByVal trabajadorSeguridad As e_TrabajadorSeguridad) As e_TrabajadorSeguridad

End Interface
