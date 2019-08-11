Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_CajaTurno", también debe actualizar la referencia a "Ie_CajaTurno" en Web.config.
<ServiceContract()> _
Public Interface Ie_CajaTurno

    <OperationContract()> _
    Function Obtener(ByVal cajaTurno As e_CajaTurno) As e_CajaTurno

End Interface
