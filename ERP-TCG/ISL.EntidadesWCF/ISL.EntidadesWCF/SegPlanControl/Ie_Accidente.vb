Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Accidente", también debe actualizar la referencia a "Ie_Accidente" en Web.config.
<ServiceContract()> _
Public Interface Ie_Accidente

    <OperationContract()> _
    Function Obtener(ByVal accidente As e_Accidente) As e_Accidente

End Interface
