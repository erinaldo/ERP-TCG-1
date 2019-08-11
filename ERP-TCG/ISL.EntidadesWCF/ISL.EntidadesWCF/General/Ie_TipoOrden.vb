Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_TipoOrden", también debe actualizar la referencia a "Ie_TipoOrden" en Web.config.
<ServiceContract()> _
Public Interface Ie_TipoOrden

    <OperationContract()> _
    Function Obtener(ByVal tipoOrden As e_TipoOrden) As e_TipoOrden

End Interface
