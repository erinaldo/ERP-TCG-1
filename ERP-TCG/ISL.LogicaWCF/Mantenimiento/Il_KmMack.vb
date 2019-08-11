Imports System.ServiceModel
Imports ISL.EntidadesWCF
' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_KmMack" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_KmMack

    <OperationContract()>
    Function Obtener(ByVal oeKmMack As e_KmMack) As e_KmMack

    <OperationContract()>
    Function Listar(ByVal oeKmMack As e_KmMack) As List(Of e_KmMack)

    <OperationContract()>
    Function Guardar(ByVal oeKmMack As e_KmMack) As Boolean

    <OperationContract()>
    Function Eliminar(ByVal oeKmMack As e_KmMack) As Boolean

End Interface
