Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_ConfiguracionPlanilla" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_ConfiguracionPlanilla

    <OperationContract()> _
    Function Obtener(ByVal oeConfiguracionPlanilla As e_ConfiguracionPlanilla) As e_ConfiguracionPlanilla

    <OperationContract()> _
    Function Listar(ByVal oeConfiguracionPlanilla As e_ConfiguracionPlanilla) As List(Of e_ConfiguracionPlanilla)

    <OperationContract()> _
    Function Validar(ByVal oeConfiguracionPlanilla As e_ConfiguracionPlanilla) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeConfiguracionPlanilla As e_ConfiguracionPlanilla) As Boolean

    '<OperationContract()> _
    'Function GuardarMasivo(ByVal oeCuentaCtePersonal As List(Of e_CuentaCtePersonal)) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeConfiguracionPlanilla As e_ConfiguracionPlanilla) As Boolean

    '<OperationContract()> _
    'Function CrearDT() As Data.DataTable

    '<OperationContract()> _
    'Function CompletaConCeros(ByVal ls_Tex As String, ByVal lnCantidad As Integer) As String

End Interface
