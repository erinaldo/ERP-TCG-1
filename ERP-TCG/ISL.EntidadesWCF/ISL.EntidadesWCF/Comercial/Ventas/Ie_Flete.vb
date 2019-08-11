Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Flete", también debe actualizar la referencia a "Ie_Flete" en Web.config.
<ServiceContract()> _
Public Interface Ie_Flete

    <OperationContract()> _
    Function Obtener(ByVal flete As e_Flete) As e_Flete

End Interface
