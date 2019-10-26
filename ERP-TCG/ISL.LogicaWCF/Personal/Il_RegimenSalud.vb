Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_RegimenSalud" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_RegimenSalud

    <OperationContract()> _
    Function Obtener(ByVal oeRegimenSalud As e_RegimenSalud) As e_RegimenSalud

    <OperationContract()> _
    Function Listar(ByVal oeRegimenSalud As e_RegimenSalud) As List(Of e_RegimenSalud)

    <OperationContract()> _
    Function Validar(ByVal oeRegimenSalud As e_RegimenSalud) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeRegimenSalud As e_RegimenSalud) As Boolean

    '<OperationContract()> _
    'Function GuardarMasivo(ByVal oeCuentaCtePersonal As List(Of e_CuentaCtePersonal)) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeRegimenSalud As e_RegimenSalud) As Boolean

    '<OperationContract()> _
    'Function CrearDT() As Data.DataTable

    '<OperationContract()> _
    'Function CompletaConCeros(ByVal ls_Tex As String, ByVal lnCantidad As Integer) As String

End Interface
