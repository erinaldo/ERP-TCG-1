Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_DetallePreliminar", también debe actualizar la referencia a "Ie_DetallePreliminar" en Web.config.
<ServiceContract()> _
Public Interface Ie_DetallePreliminar

    <OperationContract()> _
    Function Obtener(ByVal detallepreliminar As e_DetallePreliminar) As e_DetallePreliminar

End Interface
