Imports System.ServiceModel
Imports System.ComponentModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_ItemGasto", también debe actualizar la referencia a "Il_ItemGasto" en Web.config.
<ServiceContract()> _
Public Interface Il_ItemGasto

    <OperationContract()> _
    Function Obtener(ByVal oeItemGasto As e_ItemGasto) As e_ItemGasto

    <OperationContract()> _
    Function Buscar(ByVal oeItemGasto As e_ItemGasto) As Boolean

    <OperationContract()> _
    Function Listar(ByVal oeItemGasto As e_ItemGasto) As List(Of e_ItemGasto)

    <OperationContract()> _
    Function ListarDS(ByVal oeItemGasto As e_ItemGasto) As DataSet

    <OperationContract()> _
    Function ListarBind(ByVal oeItemGasto As e_ItemGasto) As BindingList(Of e_ItemGasto)

    <OperationContract()> _
    Function Validar(ByVal oeItemGasto As e_ItemGasto) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeItemGasto As e_ItemGasto) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeItemGasto As e_ItemGasto) As Boolean

End Interface
