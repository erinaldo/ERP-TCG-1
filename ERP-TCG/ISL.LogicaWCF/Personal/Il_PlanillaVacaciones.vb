Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_PlanillaVacaciones" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_PlanillaVacaciones

    <OperationContract()> _
    Function Obtener(ByVal oePlanillaVacaciones As e_PlanillaVacaciones) As e_PlanillaVacaciones

    <OperationContract()> _
    Function Listar(ByVal oePlanillaVacaciones As e_PlanillaVacaciones) As List(Of e_PlanillaVacaciones)

    <OperationContract()> _
    Function Validar(ByVal oePlanillaVacaciones As e_PlanillaVacaciones) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oePlanillaVacaciones As e_PlanillaVacaciones) As Boolean

    '<OperationContract()> _
    'Function GuardarMasivo(ByVal oeCuentaCtePersonal As List(Of e_CuentaCtePersonal)) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oePlanillaVacaciones As e_PlanillaVacaciones) As Boolean

    '<OperationContract()> _
    'Function CrearDT() As Data.DataTable

    '<OperationContract()> _
    'Function CompletaConCeros(ByVal ls_Tex As String, ByVal lnCantidad As Integer) As String

End Interface
