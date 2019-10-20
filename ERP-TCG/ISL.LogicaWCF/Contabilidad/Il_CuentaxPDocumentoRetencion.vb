Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_CuentaxPDocumentoRetencion", también debe actualizar la referencia a "Il_CuentaxPDocumentoRetencion" en Web.config.
<ServiceContract()> _
Public Interface Il_CuentaxPDocumentoRetencion

    <OperationContract()> _
    Function Obtener(ByVal oeCuentaxPDocumentoRetencion As e_CuentaxPDocumentoRetencion) As e_CuentaxPDocumentoRetencion

    <OperationContract()> _
    Function Listar(ByVal oeCuentaxPDocumentoRetencion As e_CuentaxPDocumentoRetencion) As List(Of e_CuentaxPDocumentoRetencion)

    <OperationContract()> _
    Function Validar(ByVal oeCuentaxPDocumentoRetencion As e_CuentaxPDocumentoRetencion) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeCuentaxPDocumentoRetencion As e_CuentaxPDocumentoRetencion) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeCuentaxPDocumentoRetencion As e_CuentaxPDocumentoRetencion) As Boolean

End Interface
