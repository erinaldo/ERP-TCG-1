Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Direccion", también debe actualizar la referencia a "Ie_Direccion" en Web.config.
<ServiceContract()> _
Public Interface Ie_Direccion

    <OperationContract()> _
    Function Obtener(ByVal direccion As e_Direccion) As e_Direccion

End Interface
