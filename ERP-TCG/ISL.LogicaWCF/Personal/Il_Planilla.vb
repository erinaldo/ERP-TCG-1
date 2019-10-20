Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_Planilla" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_Planilla

    <OperationContract()> _
    Function Obtener(ByVal oePlanilla As e_Planilla) As e_Planilla

    <OperationContract()> _
    Function ObtenerUltimaPlanilla(ByVal oePlanilla As e_Planilla) As e_Planilla

    <OperationContract()> _
    Function Listar(ByVal oePlanilla As e_Planilla) As List(Of e_Planilla)

    <OperationContract()> _
    Function Validar(ByVal oePlanilla As e_Planilla) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oePlanilla As e_Planilla) As Boolean

    <OperationContract()> _
    Function Provisionar(ByVal oePlanilla As e_Planilla, ByVal oeAsientoModel As e_AsientoModelo, ByVal oePeriodo As e_Periodo) As Boolean

    '<OperationContract()> _
    'Function GuardarMasivo(ByVal leCuentaCtePersonal As List(Of e_CuentaCtePersonal)) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oePlanilla As e_Planilla) As Boolean

    '<OperationContract()> _
    'Function CrearDT() As Data.DataTable

    <OperationContract()> _
    Function CompletaConCeros(ByVal ls_Tex As String, ByVal lnCantidad As Integer) As String

End Interface
