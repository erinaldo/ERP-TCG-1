Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_OrdenVenta" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_OrdenVenta

    <OperationContract()>
    Function Obtener(ByVal oeOrdenComercial As e_OrdenVenta) As e_OrdenVenta

    <OperationContract()>
    Function Listar(ByVal oeOrdenComercial As e_OrdenVenta) As List(Of e_OrdenVenta)

    <OperationContract()>
    Function ListarDataset(ByVal oeOrdenComercial As e_OrdenVenta) As Data.DataSet

    <OperationContract()>
    Function Guardar(ByVal oeOrdenComercial As e_OrdenVenta) As Boolean

    <OperationContract()>
    Function Eliminar(ByVal oeOrdenComercial As e_OrdenVenta) As Boolean

    <OperationContract()>
    Function EliminarExtornar(ByVal oeOrdenComercial As e_OrdenVenta) As Boolean

End Interface
