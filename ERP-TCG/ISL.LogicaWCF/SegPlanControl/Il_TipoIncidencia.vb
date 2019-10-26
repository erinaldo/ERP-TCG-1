Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_TipoIncidencia" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_TipoIncidencia

    <OperationContract()>
    Sub DoWork()

    <OperationContract()>
    Function Obtener(ByVal oeTipoIncidencia As e_TipoIncidencia) As e_TipoIncidencia

    <OperationContract()>
    Function Listar(ByVal oeTipoIncidencia As e_TipoIncidencia) As List(Of e_TipoIncidencia)

    <OperationContract()>
    Function Validar(ByVal oeTipoIncidencia As e_TipoIncidencia) As Boolean

    <OperationContract()>
    Function Guardar(ByVal oeTipoIncidencia As e_TipoIncidencia) As Boolean

    <OperationContract()>
    Function Eliminar(ByVal oeTipoIncidencia As e_TipoIncidencia) As Boolean
End Interface
