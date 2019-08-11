Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Placa", también debe actualizar la referencia a "Ie_Placa" en Web.config.
<ServiceContract()> _
Public Interface Ie_Placa

    <OperationContract()> _
    Function Obtener(ByVal placa As e_Placa) As e_Placa

End Interface
