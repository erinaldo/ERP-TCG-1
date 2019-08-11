Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_MantenimientoServicio", también debe actualizar la referencia a "Ie_MantenimientoServicio" en Web.config.
<ServiceContract()> _
Public Interface Ie_MantenimientoServicio

    <OperationContract()> _
    Function Obtener(ByVal mantenimientoServicio As e_MantenimientoServicio) As e_MantenimientoServicio

End Interface
