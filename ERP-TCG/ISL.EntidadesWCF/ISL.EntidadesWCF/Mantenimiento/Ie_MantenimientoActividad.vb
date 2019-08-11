Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_MantenimientoActividad", también debe actualizar la referencia a "Ie_MantenimientoActividad" en Web.config.
<ServiceContract()> _
Public Interface Ie_MantenimientoActividad

    <OperationContract()> _
    Function Obtener(ByVal mantenimientoActividad As e_MantenimientoActividad) As e_MantenimientoActividad

End Interface
