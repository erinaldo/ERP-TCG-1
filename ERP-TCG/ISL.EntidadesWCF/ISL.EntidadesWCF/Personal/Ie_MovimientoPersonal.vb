Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_MovimientoPersonal", también debe actualizar la referencia a "Ie_MovimientoPersonal" en Web.config.
<ServiceContract()> _
Public Interface Ie_MovimientoPersonal

    <OperationContract()> _
    Function Obtener(ByVal movimientoPersonal As e_MovimientoPersonal) As e_MovimientoPersonal

End Interface
