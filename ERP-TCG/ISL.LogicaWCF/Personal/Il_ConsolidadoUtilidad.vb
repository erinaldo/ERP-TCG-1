Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_DetalleUtilidad" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_ConsolidadoUtilidad

    <OperationContract()> _
    Function Obtener(ByVal oeConsolidadoUtilidad As e_ConsolidadoUtilidad) As e_ConsolidadoUtilidad

    <OperationContract()> _
    Function Listar(ByVal oeConsolidadoUtilidad As e_ConsolidadoUtilidad) As List(Of e_ConsolidadoUtilidad)

    <OperationContract()> _
    Function Validar(ByVal oeConsolidadoUtilidad As e_ConsolidadoUtilidad) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeConsolidadoUtilidad As e_ConsolidadoUtilidad) As Boolean

    '<OperationContract()> _
    'Function GuardarMasivo(ByVal oeCuentaCtePersonal As List(Of e_CuentaCtePersonal)) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeConsolidadoUtilidad As e_ConsolidadoUtilidad) As Boolean

    <OperationContract()> _
    Function CrearDT() As Data.DataTable

    <OperationContract()> _
    Function CompletaConCeros(ByVal ls_Tex As String, ByVal lnCantidad As Integer) As String

End Interface
