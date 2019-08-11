Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_FondoFijo", también debe actualizar la referencia a "Ie_FondoFijo" en Web.config.
<ServiceContract()> _
Public Interface Ie_FondoFijo

    <OperationContract()> _
    Function Obtener(ByVal fondoFijo As e_FondoFijo) As e_FondoFijo

End Interface
