Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_MaterialAlmacen", también debe actualizar la referencia a "Il_MaterialAlmacen" en Web.config.
<ServiceContract()> _
Public Interface Il_MaterialAlmacen

    <OperationContract()> _
    Function Obtener(ByVal oeMaterialAlmacen As e_MaterialAlmacen) As e_MaterialAlmacen

    <OperationContract()> _
    Function Guardar(ByVal listaObj As List(Of e_MaterialAlmacen)) As Boolean

    <OperationContract()> _
    Function Guardar1(ByVal oeMaterialAlmacen As e_MaterialAlmacen) As Boolean

    <OperationContract()> _
    Sub Validar(ByVal listaObj As List(Of e_MaterialAlmacen))

    <OperationContract()> _
    Function Listar(ByVal oeMaterialAlmacen As e_MaterialAlmacen) As List(Of e_Material)

    <OperationContract()> _
    Function Listar_(ByVal oeMaterialAlmacen As e_MaterialAlmacen) As List(Of e_MaterialAlmacen)

    <OperationContract()> _
    Function ListarMateriales(ByVal oeMaterialAlmacen As e_MaterialAlmacen) As List(Of e_Material)

    <OperationContract()> _
    Function ListarAlmacenMateriales(ByVal oeMaterialAlmacen As e_MaterialAlmacen) As DataSet

    <OperationContract()> _
    Function Eliminar(ByVal llMaterialAlmacen As List(Of e_MaterialAlmacen)) As Boolean

    <OperationContract()> _
    Function ComboGrilla(ByVal oeMaterialAlmacen As e_MaterialAlmacen)

End Interface
