Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Demanda", también debe actualizar la referencia a "Ie_Demanda" en Web.config.
<ServiceContract()> _
Public Interface Ie_Demanda

    <OperationContract()> _
    Function Obtener(ByVal demanda As e_Demanda) As e_Demanda

End Interface
