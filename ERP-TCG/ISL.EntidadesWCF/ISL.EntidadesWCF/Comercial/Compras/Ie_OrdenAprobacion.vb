Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_OrdenAprobacion", también debe actualizar la referencia a "Ie_OrdenAprobacion" en Web.config.
<ServiceContract()> _
Public Interface Ie_OrdenAprobacion

    <OperationContract()> _
    Function Obtener(ByVal ordenAprobacion As e_OrdenAprobacion) As e_OrdenAprobacion

End Interface
