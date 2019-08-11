Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_FlujoCaja", también debe actualizar la referencia a "Ie_FlujoCaja" en Web.config.
<ServiceContract()> _
Public Interface Ie_FlujoCaja

    <OperationContract()> _
    Function Obtener(ByVal flujoCaja As e_FlujoCaja) As e_FlujoCaja

End Interface
