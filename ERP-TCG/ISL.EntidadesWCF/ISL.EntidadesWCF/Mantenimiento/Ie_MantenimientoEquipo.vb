Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_MantenimientoEquipo", también debe actualizar la referencia a "Ie_MantenimientoEquipo" en Web.config.
<ServiceContract()> _
Public Interface Ie_MantenimientoEquipo

    <OperationContract()> _
    Function Obtener(ByVal mantenimientoEquipo As e_MantenimientoEquipo) As e_MantenimientoEquipo

End Interface
