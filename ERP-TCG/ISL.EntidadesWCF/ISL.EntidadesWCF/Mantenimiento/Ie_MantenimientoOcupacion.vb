Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_MantenimientoOcupacion", también debe actualizar la referencia a "Ie_MantenimientoOcupacion" en Web.config.
<ServiceContract()> _
Public Interface Ie_MantenimientoOcupacion

    <OperationContract()> _
    Function Obtener(ByVal mantenimientoOcupacion As e_MantenimientoOcupacion) As e_MantenimientoOcupacion

End Interface
