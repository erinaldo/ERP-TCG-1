Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_CuentaxCyP", también debe actualizar la referencia a "Il_CuentaxCyP" en Web.config.
<ServiceContract()> _
Public Interface Il_CuentaxCyP

    <OperationContract()> _
    Function CrearDT() As Data.DataTable

    <OperationContract()> _
    Function Obtener(ByVal oeCuentaxCyP As e_CuentaxCyP) As e_CuentaxCyP

    <OperationContract()> _
    Function Listar(ByVal oeCuentaxCyP As e_CuentaxCyP) As List(Of e_CuentaxCyP)

    <OperationContract()> _
    Function Validar(ByVal oeCuentaxCyP As e_CuentaxCyP) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeCuentaxCyP As e_CuentaxCyP) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeCuentaxCyP As e_CuentaxCyP) As Boolean

    <OperationContract()> _
    Function ReporteCuentasXC(ByVal IdClienteProveedor As String) As DataSet

End Interface
