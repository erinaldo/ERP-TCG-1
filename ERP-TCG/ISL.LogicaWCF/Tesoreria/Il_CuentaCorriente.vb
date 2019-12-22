Imports System.ServiceModel
Imports ERP.EntidadesWCF
' NOTA: si cambia aquí el nombre de clase "Il_CuentaCorriente", también debe actualizar la referencia a "Il_CuentaCorriente" en Web.config.
<ServiceContract()> _
Public Interface Il_CuentaCorriente

    <OperationContract()> _
    Function ValidarDuplicado(ByVal ID As String, ByVal IDTRABAJADOR As String, ByVal TRABAJADOR As String, ByVal Tipo As Integer) As Boolean

    <OperationContract()> _
    Function Obtener(ByVal oeCuentaCorriente As e_CuentaCorriente) As e_CuentaCorriente

    <OperationContract()> _
    Function Listar(ByVal oeCuentaCorriente As e_CuentaCorriente) As List(Of e_CuentaCorriente)

    <OperationContract()> _
    Function Validar(ByVal oeCuentaCorriente As e_CuentaCorriente) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeCuentaCorriente As e_CuentaCorriente) As Boolean

    <OperationContract()>
    Function Guardar_CuentaCorriente(ByVal oeCuentaCorriente As e_CuentaCorriente) As e_CuentaCorriente

    <OperationContract()> _
    Function Eliminar(ByVal oeCuentaCorriente As e_CuentaCorriente) As Boolean

End Interface
