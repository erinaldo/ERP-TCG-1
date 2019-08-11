Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_AsignacionFlota" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_AsignacionFlota

    <OperationContract()>
    Sub DoWork()

    <OperationContract()> _
    Function Obtener(ByVal oeAsignacionFlota As e_AsignacionFlota) As e_AsignacionFlota

    <OperationContract()> _
    Function Listar(ByVal oeAsignacionFlota As e_AsignacionFlota) As List(Of e_AsignacionFlota)

    <OperationContract()> _
    Function Validar(ByVal oeAsignacionFlota As e_AsignacionFlota) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeAsignacionFlota As e_AsignacionFlota) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeAsignacionFlota As e_AsignacionFlota) As Boolean
End Interface
