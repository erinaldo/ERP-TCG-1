Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_CierreCaja", también debe actualizar la referencia a "Il_CierreCaja" en Web.config.
<ServiceContract()> _
Public Interface Il_CierreCaja

    <OperationContract()> _
    Function Obtener(ByVal oeCierreCaja As e_CierreCaja) As e_CierreCaja

    <OperationContract()> _
    Function Listar(ByVal oeCierreCaja As e_CierreCaja) As List(Of e_CierreCaja)

    <OperationContract()> _
    Function Validar(ByVal oeCierreCaja As e_CierreCaja) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeCierreCaja As e_CierreCaja) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeCierreCaja As e_CierreCaja) As Boolean

End Interface
