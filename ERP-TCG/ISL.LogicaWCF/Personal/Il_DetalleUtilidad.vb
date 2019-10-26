Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_DetalleUtilidad" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_DetalleUtilidad

    <OperationContract()> _
    Function Obtener(ByVal oeDetalleUtilidad As e_DetalleUtilidad) As e_DetalleUtilidad

    <OperationContract()> _
    Function Listar(ByVal oeDetalleUtilidad As e_DetalleUtilidad) As List(Of e_DetalleUtilidad)

    <OperationContract()> _
    Function Validar(ByVal oeDetalleUtilidad As e_DetalleUtilidad) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeDetalleUtilidad As e_DetalleUtilidad) As Boolean

    '<OperationContract()> _
    'Function GuardarMasivo(ByVal oeCuentaCtePersonal As List(Of e_CuentaCtePersonal)) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeDetalleUtilidad As e_DetalleUtilidad) As Boolean

    <OperationContract()> _
    Function CrearDT() As Data.DataTable

    <OperationContract()> _
    Function CompletaConCeros(ByVal ls_Tex As String, ByVal lnCantidad As Integer) As String

End Interface
