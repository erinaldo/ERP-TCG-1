Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Equipo", también debe actualizar la referencia a "Ie_Equipo" en Web.config.
<ServiceContract()> _
Public Interface Ie_Equipo

    <OperationContract()> _
    Function Obtener(ByVal equipo As e_Equipo) As e_Equipo

End Interface
