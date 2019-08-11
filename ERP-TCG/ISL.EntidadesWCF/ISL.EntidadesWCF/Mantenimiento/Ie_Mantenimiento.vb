Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Mantenimiento", también debe actualizar la referencia a "Ie_Mantenimiento" en Web.config.
<ServiceContract()> _
Public Interface Ie_Mantenimiento

    <OperationContract()> _
    Function Obtener(ByVal mantenimiento As e_Mantenimiento) As e_Mantenimiento

End Interface
