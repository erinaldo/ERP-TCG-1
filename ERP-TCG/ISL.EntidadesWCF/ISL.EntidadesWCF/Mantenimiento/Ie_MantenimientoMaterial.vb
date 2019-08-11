Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_MantenimientoMaterial", también debe actualizar la referencia a "Ie_MantenimientoMaterial" en Web.config.
<ServiceContract()> _
Public Interface Ie_MantenimientoMaterial

    <OperationContract()> _
    Function Obtener(ByVal mantenimientoMaterial As e_MantenimientoMaterial) As e_MantenimientoMaterial

End Interface
