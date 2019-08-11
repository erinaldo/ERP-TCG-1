Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_RetencionQuinta" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_RetencionQuinta

    <OperationContract()> _
    Function Obtener(ByVal oeRetencionQuinta As e_RetencionQuinta) As e_RetencionQuinta

    <OperationContract()> _
    Function Listar(ByVal oeRetencionQuinta As e_RetencionQuinta) As List(Of e_RetencionQuinta)

    <OperationContract()> _
    Function Validar(ByVal oeRetencionQuinta As e_RetencionQuinta) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeRetencionQuinta As e_RetencionQuinta) As Boolean

    <OperationContract()> _
    Function ImportarDatos(ByVal oeRetencionQuinta As e_RetencionQuinta) As Boolean

    '<OperationContract()> _
    'Function GuardarMasivo(ByVal oeCuentaCtePersonal As List(Of e_CuentaCtePersonal)) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeRetencionQuinta As e_RetencionQuinta) As Boolean

    '<OperationContract()> _
    'Function CrearDT() As Data.DataTable

    '<OperationContract()> _
    'Function CompletaConCeros(ByVal ls_Tex As String, ByVal lnCantidad As Integer) As String

End Interface
