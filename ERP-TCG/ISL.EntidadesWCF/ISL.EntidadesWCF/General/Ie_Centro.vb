Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Centro", también debe actualizar la referencia a "Ie_Centro" en Web.config.
<ServiceContract()> _
Public Interface Ie_Centro

    <OperationContract()> _
    Function Obtener(ByVal centro As e_Centro) As e_Centro

End Interface
