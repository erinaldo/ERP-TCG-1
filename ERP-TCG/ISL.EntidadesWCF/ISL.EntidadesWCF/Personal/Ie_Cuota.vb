Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Cuota", también debe actualizar la referencia a "Ie_Cuota" en Web.config.
<ServiceContract()> _
Public Interface Ie_Cuota

    <OperationContract()> _
    Function Obtener(ByVal couta As e_Cuota) As e_Cuota

End Interface
