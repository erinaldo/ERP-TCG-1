Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_Isla" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_Isla

    <OperationContract()>
    Function mt_Obtener(ByVal oeIsla As e_Isla) As e_Isla

    <OperationContract()>
    Function mt_Listar(ByVal oeIsla As e_Isla) As List(Of e_Isla)

    <OperationContract()>
    Function mt_Guardar(ByVal oeIsla As e_Isla) As Boolean

    <OperationContract()>
    Function mt_Eliminar(ByVal oeIsla As e_Isla) As Boolean

End Interface
