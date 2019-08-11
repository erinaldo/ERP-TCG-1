Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Servicio", también debe actualizar la referencia a "Ie_Servicio" en Web.config.
<ServiceContract()> _
Public Interface Ie_Servicio

    <OperationContract()> _
    Function Obtener(ByVal servicio As e_Servicio) As e_Servicio

End Interface
