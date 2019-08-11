Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Periodo", también debe actualizar la referencia a "Ie_Periodo" en Web.config.
<ServiceContract()> _
Public Interface Ie_Periodo

    <OperationContract()> _
    Function Obtener(ByVal periodo As e_Periodo) As e_Periodo

End Interface
