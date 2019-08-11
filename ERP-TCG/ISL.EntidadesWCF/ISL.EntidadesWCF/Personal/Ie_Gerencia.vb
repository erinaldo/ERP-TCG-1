Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Gerencia", también debe actualizar la referencia a "Ie_Gerencia" en Web.config.
<ServiceContract()> _
Public Interface Ie_Gerencia

    <OperationContract()> _
    Function Obtener(ByVal area As e_Gerencia) As e_Gerencia

End Interface
