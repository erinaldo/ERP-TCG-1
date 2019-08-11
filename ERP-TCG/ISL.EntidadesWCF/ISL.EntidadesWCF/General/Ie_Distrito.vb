Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Distrito", también debe actualizar la referencia a "Ie_Distrito" en Web.config.
<ServiceContract()> _
Public Interface Ie_Distrito

    <OperationContract()> _
    Function Obtener(ByVal distrito As e_Distrito) As e_Distrito

End Interface
