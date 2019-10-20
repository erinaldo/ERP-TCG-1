Imports System.ServiceModel
Imports ERP.EntidadesWCF
' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_DetraccionDetalle" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_DetraccionDetalle

    <OperationContract()>
    Function Obtener(ByVal oeDetraccionDetalle As e_DetraccionDetalle) As e_DetraccionDetalle

    <OperationContract()>
    Function Listar(ByVal oeDetraccionDetalle As e_DetraccionDetalle) As List(Of e_DetraccionDetalle)

    <OperationContract()>
    Function Guardar(ByVal oeDetraccionDetalle As e_DetraccionDetalle) As Boolean

    <OperationContract()>
    Function Eliminar(ByVal oeDetraccionDetalle As e_DetraccionDetalle) As Boolean

End Interface
