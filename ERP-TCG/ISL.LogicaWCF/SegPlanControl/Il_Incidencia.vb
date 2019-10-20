Imports ERP.EntidadesWCF
Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_Incidencia" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_Incidencia

    <OperationContract()>
    Sub DoWork()

    <OperationContract()> _
    Function Obtener(ByVal oed_Incidencia As e_Incidencia) As e_Incidencia

    <OperationContract()> _
    Function Listar(ByVal oed_Incidencia As e_Incidencia) As List(Of e_Incidencia)

    <OperationContract()> _
    Function Validar(ByVal oed_Incidencia As e_Incidencia) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oed_Incidencia As e_Incidencia) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oed_Incidencia As e_Incidencia) As Boolean
End Interface
