Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_GastoViatico", también debe actualizar la referencia a "Ie_GastoViatico" en Web.config.
<ServiceContract()> _
Public Interface Ie_GastoViatico

    <OperationContract()> _
    Function Obtener(ByVal gastoViatico As e_GastoViatico) As e_GastoViatico

End Interface
