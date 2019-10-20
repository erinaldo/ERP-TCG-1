Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_TipoCambio", también debe actualizar la referencia a "Il_TipoCambio" en Web.config.
<ServiceContract()> _
Public Interface Il_TipoCambio

    <OperationContract()> _
    Function Obtener(ByVal oeTipoCambio As e_TipoCambio) As e_TipoCambio

    <OperationContract()> _
    Function Listar(ByVal oeTipoCambio As e_TipoCambio) As List(Of e_TipoCambio)

    <OperationContract()> _
    Function Validar(ByVal oeTipoCambio As e_TipoCambio) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeTipoCambio As e_TipoCambio) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeTipoCambio As e_TipoCambio) As Boolean

    <OperationContract()> _
    Function ValidarDuplicado(ByVal id As String, ByVal fecha As Date) As Boolean

End Interface
