Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Estado", también debe actualizar la referencia a "Ie_Estado" en Web.config.
<ServiceContract()> _
Public Interface Ie_Estado

    <OperationContract()> _
    Function Obtener(ByVal estado As e_Estado) As e_Estado

End Interface
