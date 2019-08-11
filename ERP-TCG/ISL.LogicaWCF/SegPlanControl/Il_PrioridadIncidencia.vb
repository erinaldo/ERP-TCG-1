Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_PrioridadIncidencia" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_PrioridadIncidencia

    <OperationContract()>
    Sub DoWork()

    <OperationContract()>
    Function Obtener(ByVal oePrioridadIncidencia As e_PrioridadIncidencia) As e_PrioridadIncidencia

    <OperationContract()>
    Function Listar(ByVal oePrioridadIncidencia As e_PrioridadIncidencia) As List(Of e_PrioridadIncidencia)

    <OperationContract()>
    Function Validar(ByVal oePrioridadIncidencia As e_PrioridadIncidencia) As Boolean

    <OperationContract()>
    Function Guardar(ByVal oePrioridadIncidencia As e_PrioridadIncidencia) As Boolean

    <OperationContract()>
    Function Eliminar(ByVal oePrioridadIncidencia As e_PrioridadIncidencia) As Boolean
End Interface
