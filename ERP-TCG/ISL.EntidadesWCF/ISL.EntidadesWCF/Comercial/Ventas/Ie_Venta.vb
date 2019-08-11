Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Venta", también debe actualizar la referencia a "Ie_Venta" en Web.config.
<ServiceContract()> _
Public Interface Ie_Venta

    <OperationContract()> _
    Function Obtener(ByVal venta As e_Venta) As e_Venta

End Interface
