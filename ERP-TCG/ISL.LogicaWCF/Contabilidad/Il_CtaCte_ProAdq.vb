Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_CtaCte_ProAdq" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_CtaCte_ProAdq

    <OperationContract()>
    Function Obtener(ByVal oeCtaCte_ProAdq As e_CtaCte_ProAdq) As e_CtaCte_ProAdq

    <OperationContract()>
    Function Listar(ByVal oeCtaCte_ProAdq As e_CtaCte_ProAdq) As List(Of e_CtaCte_ProAdq)

    <OperationContract()>
    Function Guardar(ByVal oeCtaCte_ProAdq As e_CtaCte_ProAdq) As Boolean

    <OperationContract()>
    Function Eliminar(ByVal oeCtaCte_ProAdq As e_CtaCte_ProAdq) As Boolean

End Interface
