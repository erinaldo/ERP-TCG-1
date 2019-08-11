Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_RegistroDevolucion", también debe actualizar la referencia a "Ie_RegistroDevolucion" en Web.config.
<ServiceContract()> _
Public Interface Ie_RegistroDevolucion

    <OperationContract()> _
   Function Obtener(ByVal registrodevolucion As e_RegistroDevolucion) As e_RegistroDevolucion

End Interface
