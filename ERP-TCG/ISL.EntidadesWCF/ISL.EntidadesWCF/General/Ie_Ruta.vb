Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Ruta", también debe actualizar la referencia a "Ie_Ruta" en Web.config.
<ServiceContract()> _
Public Interface Ie_Ruta

    <OperationContract()> _
    Function Obtener(ByVal ruta As e_Ruta) As e_Ruta

End Interface
