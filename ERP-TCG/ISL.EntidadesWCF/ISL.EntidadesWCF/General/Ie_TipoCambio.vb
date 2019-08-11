Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_TipoCambio", también debe actualizar la referencia a "Ie_TipoCambio" en Web.config.
<ServiceContract()> _
Public Interface Ie_TipoCambio

    <OperationContract()> _
    Function Obtener(ByVal tipoCambio As e_TipoCambio) As e_TipoCambio

End Interface
