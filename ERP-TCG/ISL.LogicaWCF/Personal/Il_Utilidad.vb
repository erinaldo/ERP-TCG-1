Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_Utilidad" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_Utilidad

    <OperationContract()> _
    Function Obtener(ByVal oeUtilidad As e_Utilidad) As e_Utilidad

    <OperationContract()> _
    Function Listar(ByVal oeUtilidad As e_Utilidad) As List(Of e_Utilidad)

    <OperationContract()> _
    Function Validar(ByVal oeUtilidad As e_Utilidad) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeUtilidad As e_Utilidad) As Boolean

    <OperationContract()> _
    Function ImportarDatos(ByVal oeUtilidad As e_Utilidad) As Boolean

    '<OperationContract()> _
    'Function GuardarMasivo(ByVal oeCuentaCtePersonal As List(Of e_CuentaCtePersonal)) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeUtilidad As e_Utilidad) As Boolean

    '<OperationContract()> _
    'Function CrearDT() As Data.DataTable

    '<OperationContract()> _
    'Function CompletaConCeros(ByVal ls_Tex As String, ByVal lnCantidad As Integer) As String

    <OperationContract()> _
    Function Provisionar(ByVal oeUtilidad As e_Utilidad, ByVal oeAsientoModel As e_AsientoModelo, ByVal oePeriodo As e_Periodo) As Boolean

End Interface
