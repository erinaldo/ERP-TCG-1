Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_AplicaDetraccion", también debe actualizar la referencia a "Il_AplicaDetraccion" en Web.config.
<ServiceContract()> _
Public Interface Il_AplicaDetraccion

    <OperationContract()> _
    Function Listar(ByVal oeAplicaDetraccion As e_AplicaDetraccion) As List(Of e_AplicaDetraccion)

End Interface
