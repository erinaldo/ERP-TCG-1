Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_MovimientoNeumatico", también debe actualizar la referencia a "Ie_MovimientoNeumatico" en Web.config.
<ServiceContract()> _
Public Interface Ie_MovimientoNeumatico

    <OperationContract()> _
    Function Obtener(ByVal movimientoNeumatico As e_MovimientoNeumatico) As e_MovimientoNeumatico

End Interface
