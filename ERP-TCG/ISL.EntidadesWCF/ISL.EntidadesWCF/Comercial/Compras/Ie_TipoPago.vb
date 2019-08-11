Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_TipoPago", también debe actualizar la referencia a "Ie_TipoPago" en Web.config.
<ServiceContract()> _
Public Interface Ie_TipoPago

    <OperationContract()> _
    Function Obtener(ByVal tipoPago As e_TipoPago) As e_TipoPago

End Interface
