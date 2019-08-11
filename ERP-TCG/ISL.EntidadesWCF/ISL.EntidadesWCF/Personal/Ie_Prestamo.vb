Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Prestamo", también debe actualizar la referencia a "Ie_Prestamo" en Web.config.
<ServiceContract()> _
Public Interface Ie_Prestamo

    <OperationContract()> _
     Function Obtener(ByVal prestamo As e_Prestamo) As e_Prestamo

End Interface
