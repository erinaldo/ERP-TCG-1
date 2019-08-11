Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_TipoVenta", también debe actualizar la referencia a "Ie_TipoVenta" en Web.config.
<ServiceContract()> _
Public Interface Ie_TipoVenta

    <OperationContract()> _
    Function Obtener(ByVal tipoVenta As e_TipoVenta) As e_TipoVenta

End Interface
