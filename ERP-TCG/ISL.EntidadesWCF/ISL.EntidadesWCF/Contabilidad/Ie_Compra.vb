Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Compra", también debe actualizar la referencia a "Ie_Compra" en Web.config.
<ServiceContract()> _
Public Interface Ie_Compra

    <OperationContract()> _
    Function Obtener(ByVal compra As e_Compra) As e_Compra

End Interface
