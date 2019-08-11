Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Modelo", también debe actualizar la referencia a "Ie_Modelo" en Web.config.
<ServiceContract()> _
Public Interface Ie_Modelo

    <OperationContract()> _
    Function Obtener(ByVal modelo As e_Modelo) As e_Modelo

End Interface
