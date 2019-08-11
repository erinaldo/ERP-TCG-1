Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Tabla", también debe actualizar la referencia a "Ie_Tabla" en Web.config.
<ServiceContract()> _
Public Interface Ie_Tabla

    <OperationContract()> _
    Function Obtener(ByVal tabla As e_Tabla) As e_Tabla

End Interface
