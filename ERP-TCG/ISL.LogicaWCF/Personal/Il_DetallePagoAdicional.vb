Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_DetallePagoAdicional" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_DetallePagoAdicional

    <OperationContract()> _
    Function Obtener(ByVal oeDetallePagoAdicional As e_DetallePagoAdicional) As e_DetallePagoAdicional

    <OperationContract()> _
    Function Listar(ByVal oeDetallePagoAdicional As e_DetallePagoAdicional) As List(Of e_DetallePagoAdicional)

    <OperationContract()> _
    Function Validar(ByVal oeDetallePagoAdicional As e_DetallePagoAdicional) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeDetallePagoAdicional As e_DetallePagoAdicional) As Boolean

    '<OperationContract()> _
    'Function GuardarMasivo(ByVal oeCuentaCtePersonal As List(Of e_CuentaCtePersonal)) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeDetallePagoAdicional As e_DetallePagoAdicional) As Boolean

    <OperationContract()> _
    Function CrearDT() As Data.DataTable

    <OperationContract()> _
    Function CompletaConCeros(ByVal ls_Tex As String, ByVal lnCantidad As Integer) As String

End Interface
