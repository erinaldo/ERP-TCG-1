Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Zona", también debe actualizar la referencia a "Ie_Zona" en Web.config.
<ServiceContract()> _
Public Interface Ie_Zona

    <OperationContract()> _
    Function Obtener(ByVal zona As e_Zona) As e_Zona

End Interface
