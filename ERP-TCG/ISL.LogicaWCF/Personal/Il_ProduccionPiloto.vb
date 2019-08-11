Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_ProduccionPiloto" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_ProduccionPiloto

    <OperationContract()> _
    Function Obtener(ByVal oeProduccionPiloto As e_ProduccionPiloto) As e_ProduccionPiloto

    <OperationContract()> _
    Function Listar(ByVal oeProduccionPiloto As e_ProduccionPiloto) As List(Of e_ProduccionPiloto)

    <OperationContract()> _
    Function Validar(ByVal oeProduccionPiloto As e_ProduccionPiloto) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeProduccionPiloto As e_ProduccionPiloto) As Boolean

    '<OperationContract()> _
    'Function GuardarMasivo(ByVal oeCuentaCtePersonal As List(Of e_CuentaCtePersonal)) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeProduccionPiloto As e_ProduccionPiloto) As Boolean

    '<OperationContract()> _
    'Function CrearDT() As Data.DataTable

    '<OperationContract()> _
    'Function CompletaConCeros(ByVal ls_Tex As String, ByVal lnCantidad As Integer) As String

End Interface
