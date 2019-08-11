Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_CuentaBancaria", también debe actualizar la referencia a "Il_CuentaBancaria" en Web.config.
<ServiceContract()> _
Public Interface Il_CuentaBancaria

    <OperationContract()> _
    Function ValidarDuplicado(ByVal ID As String, ByVal IDBANCO As String, ByVal NUMEROCUENTA As String) As Boolean

    <OperationContract()> _
    Function Obtener(ByVal oeCuentaBancaria As e_CuentaBancaria) As e_CuentaBancaria

    <OperationContract()> _
    Function Listar(ByVal oeCuentaBancaria As e_CuentaBancaria) As List(Of e_CuentaBancaria)

    <OperationContract()> _
    Function Validar(ByVal oeCuentaBancaria As e_CuentaBancaria) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeCuentaBancaria As e_CuentaBancaria) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeCuentaBancaria As e_CuentaBancaria) As Boolean

End Interface
