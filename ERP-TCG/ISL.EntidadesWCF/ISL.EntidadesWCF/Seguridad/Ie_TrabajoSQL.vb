Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_TrabajoSQL", también debe actualizar la referencia a "Ie_TrabajoSQL" en Web.config.
<ServiceContract()> _
Public Interface Ie_TrabajoSQL

    <OperationContract()> _
    Function Obtener(ByVal trabajoSQL As e_TrabajoSQL) As e_TrabajoSQL

End Interface
