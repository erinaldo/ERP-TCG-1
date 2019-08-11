Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_DetalleRegistroDevolucion", también debe actualizar la referencia a "Ie_DetalleRegistroDevolucion" en Web.config.
<ServiceContract()> _
Public Interface Ie_DetalleRegistroDevolucion

    <OperationContract()> _
     Function Obtener(ByVal detalleregistrodevolucion As e_DetalleRegistroDevolucion) As e_DetalleRegistroDevolucion

End Interface
