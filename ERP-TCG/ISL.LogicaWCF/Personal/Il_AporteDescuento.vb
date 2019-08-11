Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_AporteDescuento" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_AporteDescuento

    <OperationContract()> _
    Function Obtener(ByVal oeAporteDescuento As e_AporteDescuento) As e_AporteDescuento

    <OperationContract()> _
    Function Listar(ByVal oeAporteDescuento As e_AporteDescuento) As List(Of e_AporteDescuento)

    <OperationContract()> _
    Function Validar(ByVal oeAporteDescuento As e_AporteDescuento) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeAporteDescuento As e_AporteDescuento) As Boolean

    '<OperationContract()> _
    'Function GuardarMasivo(ByVal oeCuentaCtePersonal As List(Of e_CuentaCtePersonal)) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeAporteDescuento As e_AporteDescuento) As Boolean

    '<OperationContract()> _
    'Function CrearDT() As Data.DataTable

    '<OperationContract()> _
    'Function CompletaConCeros(ByVal ls_Tex As String, ByVal lnCantidad As Integer) As String

End Interface
