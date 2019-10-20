Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_Disponibilidad" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_Disponibilidad

    <OperationContract()>
    Function VerificarDisponibilidadBD() As Boolean

    <OperationContract()>
    Function VerificarDisponibilidadReplica() As Boolean

    <OperationContract()>
    Function FotosDisponibles() As Boolean

    <OperationContract()>
    Function FechaLimite(area As gAreasSGI) As Date

    <OperationContract()>
    Function FechaLimitePerfil(perfil As String) As Integer
End Interface
