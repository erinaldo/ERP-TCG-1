Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Banco", también debe actualizar la referencia a "Ie_Banco" en Web.config.
<ServiceContract()> _
Public Interface Ie_Banco

    <OperationContract()> _
    Function Obtener(ByVal banco As e_Banco) As e_Banco

End Interface
