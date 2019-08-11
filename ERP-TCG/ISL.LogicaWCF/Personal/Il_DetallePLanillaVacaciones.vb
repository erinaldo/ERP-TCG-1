Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_DetalleDetallePlanillaVacaciones" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_DetallePlanillaVacaciones

    <OperationContract()> _
    Function Obtener(ByVal oeDetallePlanillaVacaciones As e_DetallePlanillaVacaciones) As e_DetallePlanillaVacaciones

    <OperationContract()> _
    Function Listar(ByVal oeDetallePlanillaVacaciones As e_DetallePlanillaVacaciones) As List(Of e_DetallePlanillaVacaciones)

    <OperationContract()> _
    Function Validar(ByVal oeDetallePlanillaVacaciones As e_DetallePlanillaVacaciones) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeDetallePlanillaVacaciones As e_DetallePlanillaVacaciones) As Boolean

    '<OperationContract()> _
    'Function GuardarMasivo(ByVal oeCuentaCtePersonal As List(Of e_CuentaCtePersonal)) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeDetallePlanillaVacaciones As e_DetallePlanillaVacaciones) As Boolean

    '<OperationContract()> _
    'Function CrearDT() As Data.DataTable

    '<OperationContract()> _
    'Function CompletaConCeros(ByVal ls_Tex As String, ByVal lnCantidad As Integer) As String
End Interface
