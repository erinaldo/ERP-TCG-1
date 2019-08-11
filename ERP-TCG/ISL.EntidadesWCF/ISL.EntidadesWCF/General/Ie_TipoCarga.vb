Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_TipoCarga", también debe actualizar la referencia a "Ie_TipoCarga" en Web.config.
<ServiceContract()> _
Public Interface Ie_TipoCarga

    <OperationContract()> _
    Function Obtener(ByVal tipoCarga As e_TipoCarga) As e_TipoCarga

End Interface
