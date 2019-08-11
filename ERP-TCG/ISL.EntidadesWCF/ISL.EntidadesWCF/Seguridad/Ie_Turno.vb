Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Turno", también debe actualizar la referencia a "Ie_Turno" en Web.config.
<ServiceContract()> _
Public Interface Ie_Turno

    <OperationContract()> _
    Function Obtener(ByVal turno As e_Turno) As e_Turno

End Interface
