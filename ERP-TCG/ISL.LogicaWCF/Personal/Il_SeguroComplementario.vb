Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_SeguroComplementario" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_SeguroComplementario

    <OperationContract()> _
    Function Obtener(ByVal oeSeguroComplementario As e_SeguroComplementario) As e_SeguroComplementario

    <OperationContract()> _
    Function Listar(ByVal oeSeguroComplementario As e_SeguroComplementario) As List(Of e_SeguroComplementario)

    <OperationContract()> _
    Function Validar(ByVal oeSeguroComplementario As e_SeguroComplementario) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeSeguroComplementario As e_SeguroComplementario) As Boolean

    '<OperationContract()> _
    'Function GuardarMasivo(ByVal oeCuentaCtePersonal As List(Of e_CuentaCtePersonal)) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeSeguroComplementario As e_SeguroComplementario) As Boolean

    '<OperationContract()> _
    'Function CrearDT() As Data.DataTable

    '<OperationContract()> _
    'Function CompletaConCeros(ByVal ls_Tex As String, ByVal lnCantidad As Integer) As String

End Interface
