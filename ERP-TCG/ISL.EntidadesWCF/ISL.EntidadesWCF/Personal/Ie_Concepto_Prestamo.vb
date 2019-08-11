Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Concepto_Prestamo", también debe actualizar la referencia a "Ie_Concepto_Prestamo" en Web.config.
<ServiceContract()> _
Public Interface Ie_Concepto_Prestamo

    <OperationContract()> _
     Function Obtener(ByVal concepto_prestamo As e_Concepto_Prestamo) As e_Concepto_Prestamo

End Interface
