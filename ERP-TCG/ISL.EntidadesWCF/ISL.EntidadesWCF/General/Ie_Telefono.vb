Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Telefono", también debe actualizar la referencia a "Ie_Telefono" en Web.config.
<ServiceContract()> _
Public Interface Ie_Telefono

    <OperationContract()> _
    Function Obtener(ByVal telefono As e_Telefono) As e_Telefono

End Interface
