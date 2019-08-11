Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_TipoGastoDetalle", también debe actualizar la referencia a "Ie_TipoGastoDetalle" en Web.config.
<ServiceContract()> _
Public Interface Ie_ValesRendir

    <OperationContract()> _
    Function Obtener(ByVal valesRendir As e_ValesRendir) As e_ValesRendir

End Interface
