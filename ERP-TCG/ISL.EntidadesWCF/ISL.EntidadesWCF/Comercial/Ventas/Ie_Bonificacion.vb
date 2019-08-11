Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Bonificacion", también debe actualizar la referencia a "Ie_Bonificacion" en Web.config.
<ServiceContract()> _
Public Interface Ie_Bonificacion

    <OperationContract()> _
  Function Obtener(ByVal Bonificacion As e_Bonificacion) As e_Bonificacion

End Interface
