Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_MovimientoAnalisis", también debe actualizar la referencia a "Ie_MovimientoAnalisis" en Web.config.
<ServiceContract()> _
Public Interface Ie_MovimientoAnalisis

    <OperationContract()> _
    Function Obtener(ByVal movimientoAnalisis As e_MovimientoAnalisis) As e_MovimientoAnalisis

End Interface
