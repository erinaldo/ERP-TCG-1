Imports System.ServiceModel
Imports ISL.EntidadesWCF


' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_DetalleConfiguracionPlanilla" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_DetalleConfiguracionPlanilla

    <OperationContract()> _
    Function Obtener(ByVal oeDetalleConfiguracionPlanilla As e_DetalleConfiguracionPlanilla) As e_DetalleConfiguracionPlanilla

    <OperationContract()> _
    Function Listar(ByVal oeDetalleConfiguracionPlanilla As e_DetalleConfiguracionPlanilla) As List(Of e_DetalleConfiguracionPlanilla)

    <OperationContract()> _
    Function Validar(ByVal oeDetalleConfiguracionPlanilla As e_DetalleConfiguracionPlanilla) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeDetalleConfiguracionPlanilla As e_DetalleConfiguracionPlanilla) As Boolean

    '<OperationContract()> _
    'Function GuardarMasivo(ByVal oeCuentaCtePersonal As List(Of e_CuentaCtePersonal)) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeDetalleConfiguracionPlanilla As e_DetalleConfiguracionPlanilla) As Boolean

    '<OperationContract()> _
    'Function CrearDT() As Data.DataTable

    '<OperationContract()> _
    'Function CompletaConCeros(ByVal ls_Tex As String, ByVal lnCantidad As Integer) As String

End Interface
