Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_GPS", también debe actualizar la referencia a "Ie_GPS" en Web.config.
<ServiceContract()> _
Public Interface Ie_GPS

    <OperationContract()> _
    Function Obtener(ByVal gps As e_GPS) As e_GPS

End Interface
