Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_TipoCompra", también debe actualizar la referencia a "Ie_TipoCompra" en Web.config.
<ServiceContract()> _
Public Interface Ie_TipoCompra

    <OperationContract()> _
    Function Obtener(ByVal tipoCompra As e_TipoCompra) As e_TipoCompra

End Interface
