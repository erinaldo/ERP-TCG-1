Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_ProyMantenimiento", también debe actualizar la referencia a "Ie_ProyMantenimiento" en Web.config.
<ServiceContract()> _
Public Interface Ie_ProyMantenimiento

    <OperationContract()> _
     Function Obtener(ByVal proymantenimiento As e_ProyMantenimiento) As e_ProyMantenimiento

End Interface
