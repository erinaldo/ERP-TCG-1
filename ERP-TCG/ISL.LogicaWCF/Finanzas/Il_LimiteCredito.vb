Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_LimiteCredito", también debe actualizar la referencia a "Il_LimiteCredito" en Web.config.
<ServiceContract()> _
Public Interface Il_LimiteCredito
    <OperationContract()> _
   Function Obtener(ByVal oeLimiteCredito As e_LimiteCredito) As e_LimiteCredito

    <OperationContract()> _
    Function Listar(ByVal oeLimiteCredito As e_LimiteCredito) As List(Of e_LimiteCredito)

    <OperationContract()> _
    Function Guardar(ByVal oeLimiteCredito As e_LimiteCredito) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeLimiteCredito As e_LimiteCredito) As Boolean

End Interface
