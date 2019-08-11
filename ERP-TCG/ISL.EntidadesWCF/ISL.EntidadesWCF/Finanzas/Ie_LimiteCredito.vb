Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_LimiteCredito", también debe actualizar la referencia a "Ie_LimiteCredito" en Web.config.
<ServiceContract()> _
Public Interface Ie_LimiteCredito

    <OperationContract()> _
    Function Obtener(ByVal LimiteCredito As e_LimiteCredito) As e_LimiteCredito

End Interface
