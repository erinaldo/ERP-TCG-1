Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_OrdenTrabajo_MantenimientoEquipo", también debe actualizar la referencia a "Ie_OrdenTrabajo_MantenimientoEquipo" en Web.config.
<ServiceContract()> _
Public Interface Ie_OrdenTrabajo_MantenimientoEquipo

    <OperationContract()> _
    Function Obtener(ByVal ordenTrabajo_MantenimientoEquipo As e_OrdenTrabajo_MantenimientoEquipo) As e_OrdenTrabajo_MantenimientoEquipo

End Interface
