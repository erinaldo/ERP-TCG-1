Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_EstacionServicio" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_EstacionServicio

    <OperationContract()>
    Function mt_Obtener(ByVal oeEstacionServicio As e_EstacionServicio) As e_EstacionServicio

    <OperationContract()>
    Function mt_Listar(ByVal oeEstacionServicio As e_EstacionServicio) As List(Of e_EstacionServicio)

    <OperationContract()>
    Function mt_Guardar(ByVal oeEstacionServicio As e_EstacionServicio) As Boolean

    <OperationContract()>
    Function mt_Eliminar(ByVal oeEstacionServicio As e_EstacionServicio) As Boolean

End Interface
