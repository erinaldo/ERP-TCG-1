Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_DetalleProduccionPiloto" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_DetalleProduccionPiloto

    <OperationContract()> _
    Function Obtener(ByVal oeDetalleProduccionPiloto As e_DetalleProduccionPiloto) As e_DetalleProduccionPiloto

    <OperationContract()> _
    Function Listar(ByVal oeDetalleProduccionPiloto As e_DetalleProduccionPiloto) As List(Of e_DetalleProduccionPiloto)

    <OperationContract()> _
    Function Validar(ByVal oeDetalleProduccionPiloto As e_DetalleProduccionPiloto) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeDetalleProduccionPiloto As e_DetalleProduccionPiloto) As Boolean

    '<OperationContract()> _
    'Function GuardarMasivo(ByVal oeCuentaCtePersonal As List(Of e_CuentaCtePersonal)) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeDetalleProduccionPiloto As e_DetalleProduccionPiloto) As Boolean

    '<OperationContract()> _
    'Function CrearDT() As Data.DataTable

    '<OperationContract()> _
    'Function CompletaConCeros(ByVal ls_Tex As String, ByVal lnCantidad As Integer) As String
End Interface
