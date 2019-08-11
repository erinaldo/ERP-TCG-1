Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Ocupacion", también debe actualizar la referencia a "Ie_Ocupacion" en Web.config.
<ServiceContract()> _
Public Interface Ie_Ocupacion

    <OperationContract()> _
    Function Obtener(ByVal ocupacion As e_Ocupacion) As e_Ocupacion

End Interface
