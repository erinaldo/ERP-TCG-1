Imports System.ServiceModel
Imports ERP.EntidadesWCF

<ServiceContract()> _
Public Interface Il_OrdenCompraMaterial

    <OperationContract()> _
    Function Obtener(ByVal oeOrdenMaterial As e_OrdenCompraMaterial) As e_OrdenCompraMaterial

    <OperationContract()> _
    Function Listar(ByVal oeOrdenMaterial As e_OrdenCompraMaterial) As List(Of e_OrdenCompraMaterial)

    <OperationContract()> _
    Function ListarHistorial(ByVal oeOrdenMaterial As e_OrdenCompraMaterial) As DataSet

    <OperationContract()> _
    Function Validar(ByVal oeOrdenMaterial As e_OrdenCompraMaterial) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeOrdenMaterial As e_OrdenCompraMaterial) As Boolean

    <OperationContract()> _
    Sub GuardarLista(ByVal llOrden As List(Of e_OrdenCompraMaterial))

    <OperationContract()> _
    Function Eliminar(ByVal oeOrdenMaterial As e_OrdenCompraMaterial) As Boolean

End Interface
