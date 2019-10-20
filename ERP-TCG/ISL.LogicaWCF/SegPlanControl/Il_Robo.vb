Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_Robo" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_Robo

    <OperationContract()>
    Sub DoWork()

    <OperationContract()>
    Function Obtener(ByVal oeRobo As e_Robo) As e_Robo

    <OperationContract()>
    Function Listar(ByVal oeRobo As e_Robo) As List(Of e_Robo)

    <OperationContract()>
    Function Validar(ByVal oeRobo As e_Robo) As Boolean

    <OperationContract()>
    Function Guardar(ByVal oeRobo As e_Robo) As Boolean

    <OperationContract()>
    Function Eliminar(ByVal oeRobo As e_Robo) As Boolean
End Interface
