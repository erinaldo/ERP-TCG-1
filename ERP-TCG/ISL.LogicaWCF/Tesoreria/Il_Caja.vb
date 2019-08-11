Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Caja", también debe actualizar la referencia a "Il_Caja" en Web.config.
<ServiceContract()> _
Public Interface Il_Caja

    <OperationContract()> _
    Function ValidarDuplicado(ByVal ID As String, ByVal NOMBRE As String) As Boolean

    <OperationContract()> _
    Function Obtener(ByVal oeCaja As e_Caja) As e_Caja

    <OperationContract()> _
    Function Listar(ByVal oeCaja As e_Caja) As List(Of e_Caja)

    <OperationContract()> _
    Function Validar(ByVal oeCaja As e_Caja) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeCaja As e_Caja) As Boolean

    <OperationContract()> _
    Function ComboGrilla(ByVal loCaja As List(Of e_Caja)) As Object

    <OperationContract()> _
    Function Eliminar(ByVal oeCaja As e_Caja) As Boolean

End Interface
