Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_OrdenMaterial", también debe actualizar la referencia a "Il_OrdenMaterial" en Web.config.
<ServiceContract()> _
Public Interface Il_OrdenMaterial

    <OperationContract()> _
    Function Obtener(ByVal oeOrdenMaterial As e_OrdenMaterial) As e_OrdenMaterial

    <OperationContract()> _
    Function Listar(ByVal oeOrdenMaterial As e_OrdenMaterial) As List(Of e_OrdenMaterial)

    <OperationContract()> _
    Function ListarDS(ByVal oeOrdenMaterial As e_OrdenMaterial) As DataSet

    <OperationContract()> _
    Function ListarOSNeumaticos(ByVal oeOrdenMaterial As e_OrdenMaterial) As List(Of e_OrdenMaterial)

    <OperationContract()> _
    Function ListarDetalle(ByVal oeOrden As e_OrdenMaterial) As List(Of e_OrdenMaterial)

    <OperationContract()> _
    Function ListarParaOCC(ByVal oeOrdenMaterial As e_OrdenMaterial) As DataSet

    <OperationContract()> _
    Function ValidarParaOCC(ByVal oeOrdenMaterial As e_OrdenMaterial) As Boolean

    <OperationContract()> _
    Function Validar(ByVal oeOrdenMaterial As e_OrdenMaterial) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeOrdenMaterial As e_OrdenMaterial) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeOrdenMaterial As e_OrdenMaterial) As Boolean

End Interface
