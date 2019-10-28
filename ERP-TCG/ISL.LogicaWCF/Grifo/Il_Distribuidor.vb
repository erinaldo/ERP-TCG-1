Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_Distribuidor" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_Distribuidor

    <OperationContract()>
    Function mt_Obtener(ByVal oeDistribuidor As e_Distribuidor) As e_Distribuidor

    <OperationContract()>
    Function mt_Listar(ByVal oeDistribuidor As e_Distribuidor) As List(Of e_Distribuidor)

    <OperationContract()>
    Function mt_Guardar(ByVal oeDistribuidor As e_Distribuidor) As Boolean

    <OperationContract()>
    Function mt_Eliminar(ByVal oeDistribuidor As e_Distribuidor) As Boolean

End Interface
