Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Moneda", también debe actualizar la referencia a "Ie_Moneda" en Web.config.
<ServiceContract()> _
Public Interface Ie_Moneda

    <OperationContract()> _
    Function Obtener(ByVal moneda As e_Moneda) As e_Moneda

End Interface
