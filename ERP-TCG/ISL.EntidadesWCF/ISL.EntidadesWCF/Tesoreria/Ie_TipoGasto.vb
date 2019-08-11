Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_TipoGasto", también debe actualizar la referencia a "Ie_TipoGasto" en Web.config.
<ServiceContract()> _
Public Interface Ie_TipoGasto

    <OperationContract()> _
    Function Obtener(ByVal tipoGasto As e_TipoGasto) As e_TipoGasto

End Interface
