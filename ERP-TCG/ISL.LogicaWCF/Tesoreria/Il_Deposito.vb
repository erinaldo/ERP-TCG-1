Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Deposito", también debe actualizar la referencia a "Il_Deposito" en Web.config.
<ServiceContract()> _
Public Interface Il_Deposito

    <OperationContract()> _
    Function Obtener(ByVal oeDeposito As e_Deposito) As e_Deposito

    <OperationContract()> _
    Function Listar(ByVal oeDeposito As e_Deposito) As List(Of e_Deposito)

    <OperationContract()> _
    Function Validar(ByVal oeDeposito As e_Deposito) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeDeposito As e_Deposito) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeDeposito As e_Deposito) As Boolean

End Interface
