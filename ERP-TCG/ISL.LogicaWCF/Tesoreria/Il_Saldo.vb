Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Saldo", también debe actualizar la referencia a "Il_Saldo" en Web.config.
<ServiceContract()> _
Public Interface Il_Saldo

    <OperationContract()> _
    Function Obtener(ByVal oeSaldo As e_Saldo) As e_Saldo

    <OperationContract()> _
    Function Listar(ByVal oeSaldo As e_Saldo) As List(Of e_Saldo)

    <OperationContract()> _
    Function Validar(ByVal oeSaldo As e_Saldo) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeSaldo As e_Saldo) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeSaldo As e_Saldo) As Boolean

End Interface
