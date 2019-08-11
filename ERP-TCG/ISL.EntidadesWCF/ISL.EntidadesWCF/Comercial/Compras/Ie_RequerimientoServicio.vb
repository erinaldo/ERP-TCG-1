Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_RequerimientoServicio", también debe actualizar la referencia a "Ie_RequerimientoServicio" en Web.config.
<ServiceContract()> _
Public Interface Ie_RequerimientoServicio

    <OperationContract()> _
    Function Obtener(ByVal requerimientoServicio As e_RequerimientoServicio) As e_RequerimientoServicio

End Interface
