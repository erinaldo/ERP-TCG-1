Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Denominacion", también debe actualizar la referencia a "Ie_Denominacion" en Web.config.
<ServiceContract()> _
Public Interface Ie_Denominacion

    <OperationContract()> _
    Function Obtener(ByVal denominacion As e_Denominacion) As e_Denominacion

End Interface
