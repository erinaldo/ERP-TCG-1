Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_TipoOrdenCompra", también debe actualizar la referencia a "Ie_TipoOrdenCompra" en Web.config.
<ServiceContract()> _
Public Interface Ie_TipoOrdenCompra

    <OperationContract()> _
    Function Obtener(ByVal tipoOrdenCompra As e_TipoOrdenCompra) As e_TipoOrdenCompra

End Interface
