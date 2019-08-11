Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_ChequexCobrar", también debe actualizar la referencia a "Ie_ChequexCobrar" en Web.config.
<ServiceContract()> _
Public Interface Ie_ChequexCobrar

    <OperationContract()> _
    Function Obtener(ByVal chequexCobrar As e_ChequexCobrar) As e_ChequexCobrar

End Interface
