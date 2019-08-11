Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_CierreCajaDet", también debe actualizar la referencia a "Il_CierreCajaDet" en Web.config.
<ServiceContract()> _
Public Interface Il_CierreCajaDet

    <OperationContract()> _
   Function Obtener(ByVal oeCierreCajaDet As e_CierreCajaDet) As e_CierreCajaDet

    <OperationContract()> _
    Function Listar(ByVal oeCierreCajaDet As e_CierreCajaDet) As List(Of e_CierreCajaDet)

    <OperationContract()> _
    Function Validar(ByVal oeCierreCajaDet As e_CierreCajaDet) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeCierreCajaDet As e_CierreCajaDet) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeCierreCajaDet As e_CierreCajaDet) As Boolean

End Interface
