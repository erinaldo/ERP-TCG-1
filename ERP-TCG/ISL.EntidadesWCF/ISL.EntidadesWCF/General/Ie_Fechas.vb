Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Fechas", también debe actualizar la referencia a "Ie_Fechas" en Web.config.
<ServiceContract()> _
Public Interface Ie_Fechas

    <OperationContract()> _
    Function Obtener(ByVal fechas As e_Fechas) As e_Fechas

End Interface
