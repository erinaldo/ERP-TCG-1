Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_TipoOperacion", también debe actualizar la referencia a "Ie_TipoOperacion" en Web.config.
<ServiceContract()> _
Public Interface Ie_TipoOperacion

    <OperationContract()> _
    Function Obtener(ByVal tipoOrden As e_TipoOperacion) As e_TipoOperacion

End Interface
