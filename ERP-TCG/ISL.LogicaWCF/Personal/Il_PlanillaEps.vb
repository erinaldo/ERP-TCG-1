Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_PlanillaEps" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_PlanillaEps

    <OperationContract()> _
    Function Obtener(ByVal oePlanillaEps As e_PlanillaEps) As e_PlanillaEps

    <OperationContract()> _
    Function Listar(ByVal oePlanillaEps As e_PlanillaEps) As List(Of e_PlanillaEps)

    <OperationContract()> _
    Function Validar(ByVal oePlanillaEps As e_PlanillaEps) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oePlanillaEps As e_PlanillaEps) As Boolean

    '<OperationContract()> _
    'Function GuardarMasivo(ByVal oeCuentaCtePersonal As List(Of e_CuentaCtePersonal)) As Boolean

    <OperationContract()> _
    Function GuardarLista(ByVal lePlanillaEps As List(Of e_PlanillaEps)) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oePlanillaEps As e_PlanillaEps) As Boolean

    <OperationContract()> _
    Function EliminarLista(ByVal lePlanillaEps As List(Of e_PlanillaEps)) As Boolean

    '<OperationContract()> _
    'Function CrearDT() As Data.DataTable

    '<OperationContract()> _
    'Function CompletaConCeros(ByVal ls_Tex As String, ByVal lnCantidad As Integer) As String

End Interface
