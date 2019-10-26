Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Material", también debe actualizar la referencia a "Il_Material" en Web.config.
<ServiceContract()> _
Public Interface Il_Material

    <OperationContract()> _
    Function Obtener(ByVal oeMaterial As e_Material) As e_Material

    <OperationContract()> _
    Function ObtenerMatNeu(ByVal oeMaterial As e_Material) As e_Material

    <OperationContract()> _
    Function Obtener_(ByVal oeMaterial As e_Material) As e_Material

    <OperationContract()> _
    Function ObtenerMaterialSegunAlmacen(ByVal oeMaterial As e_Material) As e_Material

    <OperationContract()> _
    Function Listar(ByVal oeMaterial As e_Material) As List(Of e_Material)

    <OperationContract()> _
    Function ListarMatAlm(ByVal oeMaterial As e_Material) As List(Of e_MaterialAlmacen)

    <OperationContract()> _
    Function ListarDS(ByVal oeMaterial As e_Material) As DataSet

    <OperationContract()> _
    Function Listar_(ByVal oeMaterial As e_Material) As List(Of e_Material)

    <OperationContract()> _
    Function ComboGrilla(ByVal ListaMaterial As List(Of e_Material))

    <OperationContract()> _
    Function Validar(ByVal oeMaterial As e_Material) As Boolean

    <OperationContract()> _
    Function ValidarSubFamilia(ByVal id As String) As Boolean

    <OperationContract()> _
    Function ValidarUnidadMedida(ByVal id As String) As Boolean

    <OperationContract()> _
    Function ValidarMarca(ByVal id As String) As Boolean

    <OperationContract()> _
    Function ValidarDuplicado(ByVal id As String, ByVal nombre As String) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeMaterial As e_Material) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeMaterial As e_Material) As Boolean

End Interface
