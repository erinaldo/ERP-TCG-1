Imports System.ServiceModel
Imports ERP.EntidadesWCF
' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_TarifasProveedor" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_TarifasProveedor

    <OperationContract()> _
    Function Obtener(ByVal oeTarifasProveedor As e_TarifasProveedor) As e_TarifasProveedor

    <OperationContract()> _
    Function Listar(ByVal oeTarifasProveedor As e_TarifasProveedor) As List(Of e_TarifasProveedor)

    <OperationContract()> _
    Function Validar(ByVal oeTarifasProveedor As e_TarifasProveedor) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeTarifasProveedor As e_TarifasProveedor) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeTarifasProveedor As e_TarifasProveedor) As Boolean

End Interface
