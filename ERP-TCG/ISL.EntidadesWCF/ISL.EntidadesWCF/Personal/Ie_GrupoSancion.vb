Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_GrupoSancion", también debe actualizar la referencia a "Ie_GrupoSancion" en Web.config.
<ServiceContract()> _
Public Interface Ie_GrupoSancion

    <OperationContract()> _
      Function Obtener(ByVal gruposancion As e_GrupoSancion) As e_GrupoSancion

End Interface
