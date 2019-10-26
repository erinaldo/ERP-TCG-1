Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_ChequesTalonarios", también debe actualizar la referencia a "Il_ChequesTalonarios" en Web.config.
<ServiceContract()> _
Public Interface Il_ChequesTalonarios

    <OperationContract()> _
    Function Obtener(ByVal oeChequesTalonarios As e_ChequesTalonarios) As e_ChequesTalonarios

    <OperationContract()> _
    Function Listar(ByVal oeChequesTalonarios As e_ChequesTalonarios) As List(Of e_ChequesTalonarios)

    <OperationContract()> _
    Function Validar(ByVal oeChequesTalonarios As e_ChequesTalonarios) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeChequesTalonarios As e_ChequesTalonarios) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeChequesTalonarios As e_ChequesTalonarios) As Boolean

End Interface
