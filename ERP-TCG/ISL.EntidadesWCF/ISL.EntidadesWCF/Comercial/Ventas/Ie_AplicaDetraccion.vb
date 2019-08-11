Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_AplicaDetraccion", también debe actualizar la referencia a "Ie_AplicaDetraccion" en Web.config.
<ServiceContract()> _
Public Interface Ie_AplicaDetraccion

    <OperationContract()> _
    Function Obtener(ByVal aplicaDetraccion As e_AplicaDetraccion) As e_AplicaDetraccion

End Interface
