Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_GrupoAprobacion", también debe actualizar la referencia a "Ie_GrupoAprobacion" en Web.config.
<ServiceContract()> _
Public Interface Ie_GrupoAprobacion

    <OperationContract()> _
    Function Obtener(ByVal grupoaprobacion As e_GrupoAprobacion) As e_GrupoAprobacion

End Interface
