Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Pais", también debe actualizar la referencia a "Ie_Pais" en Web.config.
<ServiceContract()> _
Public Interface Ie_Pais

    <OperationContract()> _
    Function Obtener(ByVal pais As e_Pais) As e_Pais

End Interface
