Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_TipoGastoDetalle", también debe actualizar la referencia a "Ie_TipoGastoDetalle" en Web.config.
<ServiceContract()> _
Public Interface Ie_TipoGastoDetalle

    <OperationContract()> _
    Function Obtener(ByVal tipoGastoDetalle As e_TipoGastoDetalle) As e_TipoGastoDetalle

End Interface
