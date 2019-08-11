Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Area", también debe actualizar la referencia a "Ie_Area" en Web.config.
<ServiceContract()> _
Public Interface Ie_Area

    <OperationContract()> _
    Function Obtener(ByVal area As e_Area) As e_Area

End Interface
