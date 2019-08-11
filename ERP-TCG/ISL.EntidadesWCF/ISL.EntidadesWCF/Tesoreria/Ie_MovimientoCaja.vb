Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_MovimientoCaja", también debe actualizar la referencia a "Ie_MovimientoCaja" en Web.config.
<ServiceContract()> _
Public Interface Ie_MovimientoCaja

    <OperationContract()> _
    Function Obtener(ByVal movimientoCaja As e_MovimientoCaja) As e_MovimientoCaja

End Interface
