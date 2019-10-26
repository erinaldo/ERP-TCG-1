Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_DetallePlanilla" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_DetallePlanilla

    <OperationContract()> _
    Function Obtener(ByVal oeDetallePlanilla As e_DetallePlanilla) As e_DetallePlanilla

    <OperationContract()> _
    Function Listar(ByVal oeDetallePlanilla As e_DetallePlanilla) As List(Of e_DetallePlanilla)

    <OperationContract()> _
    Function Validar(ByVal oeDetallePlanilla As e_DetallePlanilla) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeDetallePlanilla As e_DetallePlanilla) As Boolean

    <OperationContract()>
    Function GuardarMasivo(ByVal leDetallePlanilla As List(Of e_DetallePlanilla), ByVal PrefijoID As String) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeDetallePlanilla As e_DetallePlanilla) As Boolean

    <OperationContract()> _
    Function CrearDT() As Data.DataTable

    <OperationContract()> _
    Function CompletaConCeros(ByVal ls_Tex As String, ByVal lnCantidad As Integer) As String

End Interface
