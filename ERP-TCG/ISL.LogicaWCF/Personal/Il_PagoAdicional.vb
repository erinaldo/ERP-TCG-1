Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_PagoAdicional" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_PagoAdicional

    <OperationContract()> _
    Function Obtener(ByVal oePagoAdicional As e_PagoAdicional) As e_PagoAdicional

    <OperationContract()> _
    Function Listar(ByVal oePagoAdicional As e_PagoAdicional) As List(Of e_PagoAdicional)

    <OperationContract()> _
    Function Validar(ByVal oePagoAdicional As e_PagoAdicional) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oePagoAdicional As e_PagoAdicional) As Boolean

    <OperationContract()> _
    Function ImportarDatos(ByVal oePagoAdicional As e_PagoAdicional) As Boolean

    '<OperationContract()> _
    'Function GuardarMasivo(ByVal oeCuentaCtePersonal As List(Of e_CuentaCtePersonal)) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oePagoAdicional As e_PagoAdicional) As Boolean

    '<OperationContract()> _
    'Function CrearDT() As Data.DataTable

    '<OperationContract()> _
    'Function CompletaConCeros(ByVal ls_Tex As String, ByVal lnCantidad As Integer) As String

End Interface
