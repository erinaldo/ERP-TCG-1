Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_ChequeContable", también debe actualizar la referencia a "Il_ChequeContable" en Web.config.
<ServiceContract()> _
Public Interface Il_ChequeContable

    <OperationContract()> _
    Function Obtener(ByVal oeChequeContable As e_ChequeContable) As e_ChequeContable

    <OperationContract()> _
    Function Listar(ByVal oeChequeContable As e_ChequeContable) As List(Of e_ChequeContable)

    <OperationContract()> _
    Function Validar(ByVal oeChequeContable As e_ChequeContable) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeChequeContable As e_ChequeContable) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeChequeContable As e_ChequeContable) As Boolean

End Interface
