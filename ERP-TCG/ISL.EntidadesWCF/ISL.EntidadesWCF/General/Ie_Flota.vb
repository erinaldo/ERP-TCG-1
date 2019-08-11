Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Flota", también debe actualizar la referencia a "Ie_Flota" en Web.config.
<ServiceContract()> _
Public Interface Ie_Flota

    <OperationContract()> _
    Function Obtener(ByVal flota As e_Flota) As e_Flota

End Interface
