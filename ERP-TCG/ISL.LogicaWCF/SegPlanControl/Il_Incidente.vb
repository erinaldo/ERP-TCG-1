Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_Incidente" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_Incidente

    <OperationContract()>
    Sub DoWork()

    <OperationContract()>
    Function Obtener(ByVal oeIncidente As e_Incidente) As e_Incidente

    <OperationContract()>
    Function Listar(ByVal oeIncidente As e_Incidente) As List(Of e_Incidente)

    <OperationContract()>
    Function Validar(ByVal oeIncidente As e_Incidente) As Boolean

    <OperationContract()>
    Function Guardar(ByVal oeIncidente As e_Incidente) As Boolean

    <OperationContract()>
    Function Eliminar(ByVal oeIncidente As e_Incidente) As Boolean
End Interface
