Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Marca", también debe actualizar la referencia a "Il_Marca" en Web.config.
<ServiceContract()> _
Public Interface Il_Marca

    <OperationContract()> _
    Function ValidarDuplicado(ByVal ls_Id As String, ByVal ls_Nombre As String) As Boolean

    <OperationContract()> _
    Function Obtener(ByVal oeMarca As e_Marca) As e_Marca

    <OperationContract()> _
    Function Listar(ByVal oeMarca As e_Marca) As List(Of e_Marca)

    <OperationContract()> _
    Function Validar(ByVal oeMarca As e_Marca) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeMarca As e_Marca) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeMarca As e_Marca) As Boolean

    <OperationContract()> _
    Function ComboGrilla(ByVal loMarca As List(Of e_Marca))

End Interface
