Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Prestamo_Sancion", también debe actualizar la referencia a "Ie_Prestamo_Sancion" en Web.config.
<ServiceContract()> _
Public Interface Ie_Prestamo_Sancion

    <OperationContract()> _
      Function Obtener(ByVal prestamo_sancion As e_Prestamo_Sancion) As e_Prestamo_Sancion

End Interface
