Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_DetalleAporteDescuento" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_DetalleAporteDescuento

    <OperationContract()> _
    Function Obtener(ByVal oeDetalleAporteDescuento As e_DetalleAporteDescuento) As e_DetalleAporteDescuento

    <OperationContract()> _
    Function Listar(ByVal oeDetalleAporteDescuento As e_DetalleAporteDescuento) As List(Of e_DetalleAporteDescuento)

    <OperationContract()> _
    Function Validar(ByVal oeDetalleAporteDescuento As e_DetalleAporteDescuento) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeDetalleAporteDescuento As e_DetalleAporteDescuento) As Boolean

    '<OperationContract()> _
    'Function GuardarMasivo(ByVal oeCuentaCtePersonal As List(Of e_CuentaCtePersonal)) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeDetalleAporteDescuento As e_DetalleAporteDescuento) As Boolean

    '<OperationContract()> _
    'Function CrearDT() As Data.DataTable

    '<OperationContract()> _
    'Function CompletaConCeros(ByVal ls_Tex As String, ByVal lnCantidad As Integer) As String

End Interface
