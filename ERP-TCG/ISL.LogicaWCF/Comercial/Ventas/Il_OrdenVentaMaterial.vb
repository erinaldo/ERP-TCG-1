Imports System.ServiceModel
Imports ERP.EntidadesWCF
' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_OrdenVentaMaterial" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_OrdenVentaMaterial

    <OperationContract()>
    Function Obtener(ByVal oeOrdenComercial_Material As e_OrdenVentaMaterial) As e_OrdenVentaMaterial

    <OperationContract()>
    Function Listar(ByVal oeOrdenComercial_Material As e_OrdenVentaMaterial) As List(Of e_OrdenVentaMaterial)

    <OperationContract()>
    Function Guardar(ByVal oeOrdenComercial_Material As e_OrdenVentaMaterial) As Boolean

    <OperationContract()>
    Function Eliminar(ByVal oeOrdenComercial_Material As e_OrdenVentaMaterial) As Boolean

End Interface
