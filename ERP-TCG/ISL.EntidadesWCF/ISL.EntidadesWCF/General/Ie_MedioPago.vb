Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_MedioPago", también debe actualizar la referencia a "Ie_MedioPago" en Web.config.
<ServiceContract()> _
Public Interface Ie_MedioPago

    <OperationContract()> _
    Function Obtener(ByVal medioPago As e_MedioPago) As e_MedioPago

End Interface
