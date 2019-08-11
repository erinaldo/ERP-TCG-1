Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_IncidenciaMaestro" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_IncidenciaMaestro

    <OperationContract()>
    Sub DoWork()

    <OperationContract()>
    Function Obtener(ByVal oeIncidenciaMaestro As e_IncidenciaMaestro) As e_IncidenciaMaestro

    <OperationContract()>
    Function Listar(ByVal oeIncidenciaMaestro As e_IncidenciaMaestro) As List(Of e_IncidenciaMaestro)

    <OperationContract()>
    Function Validar(ByVal oeIncidenciaMaestro As e_IncidenciaMaestro) As Boolean

    <OperationContract()>
    Function Guardar(ByVal oeIncidenciaMaestro As e_IncidenciaMaestro) As Boolean

    <OperationContract()>
    Function Eliminar(ByVal oeIncidenciaMaestro As e_IncidenciaMaestro) As Boolean
End Interface
