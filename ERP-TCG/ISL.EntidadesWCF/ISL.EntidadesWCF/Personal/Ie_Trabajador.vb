Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Trabajador", también debe actualizar la referencia a "Ie_Trabajador" en Web.config.
<ServiceContract()> _
Public Interface Ie_Trabajador

    <OperationContract()> _
    Function Obtener(ByVal trabajador As e_Trabajador) As e_Trabajador

End Interface
