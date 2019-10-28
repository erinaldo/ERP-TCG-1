Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_Lado" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_Lado

    <OperationContract()>
    Function mt_Obtener(ByVal oeLado As e_Lado) As e_Lado

    <OperationContract()>
    Function mt_Listar(ByVal oeLado As e_Lado) As List(Of e_Lado)

    <OperationContract()>
    Function mt_Guardar(ByVal oeLado As e_Lado) As Boolean

    <OperationContract()>
    Function mt_Eliminar(ByVal oeLado As e_Lado) As Boolean

End Interface
