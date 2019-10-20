Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_GradoIncidencia" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_GradoIncidencia

    <OperationContract()>
    Sub DoWork()

    <OperationContract()>
    Function Obtener(ByVal oeGradoIncidencia As e_GradoIncidencia) As e_GradoIncidencia

    <OperationContract()>
    Function Listar(ByVal oeGradoIncidencia As e_GradoIncidencia) As List(Of e_GradoIncidencia)

    <OperationContract()>
    Function Validar(ByVal oeGradoIncidencia As e_GradoIncidencia) As Boolean

    <OperationContract()>
    Function Guardar(ByVal oeGradoIncidencia As e_GradoIncidencia) As Boolean

    <OperationContract()>
    Function Eliminar(ByVal oeGradoIncidencia As e_GradoIncidencia) As Boolean
End Interface
