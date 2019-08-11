Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_PrestamoDetalle", también debe actualizar la referencia a "Ie_PrestamoDetalle" en Web.config.
<ServiceContract()> _
Public Interface Ie_PrestamoDetalle

    <OperationContract()> _
     Function Obtener(ByVal prestamodetalle As e_PrestamoDetalle) As e_PrestamoDetalle

End Interface
