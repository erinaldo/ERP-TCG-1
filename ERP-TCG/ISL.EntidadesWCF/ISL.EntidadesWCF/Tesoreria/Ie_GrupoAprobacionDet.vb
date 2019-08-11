Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_GrupoAprobacionDet", también debe actualizar la referencia a "Ie_GrupoAprobacionDet" en Web.config.
<ServiceContract()> _
Public Interface Ie_GrupoAprobacionDet

    <OperationContract()> _
     Function Obtener(ByVal grupoaprobaciondet As e_GrupoAprobacionDet) As e_GrupoAprobacionDet

End Interface
