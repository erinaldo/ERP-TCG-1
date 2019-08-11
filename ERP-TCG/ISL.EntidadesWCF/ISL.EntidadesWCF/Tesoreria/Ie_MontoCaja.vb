Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_MontoCaja", también debe actualizar la referencia a "Ie_MontoCaja" en Web.config.
<ServiceContract()> _
Public Interface Ie_MontoCaja

    <OperationContract()> _
    Function Obtener(ByVal montoCaja As e_MontoCaja) As e_MontoCaja

End Interface
