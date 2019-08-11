Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_Gratificacion" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_Gratificacion

    <OperationContract()> _
    Function Obtener(ByVal oeGratificacion As e_Gratificacion) As e_Gratificacion

    <OperationContract()> _
    Function Listar(ByVal oeGratificacion As e_Gratificacion) As List(Of e_Gratificacion)

    <OperationContract()> _
    Function Validar(ByVal oeGratificacion As e_Gratificacion) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeGratificacion As e_Gratificacion) As Boolean

    <OperationContract()> _
    Function ImportarDatos(ByVal oeGratificacion As e_Gratificacion) As Boolean

    '<OperationContract()> _
    'Function GuardarMasivo(ByVal oeCuentaCtePersonal As List(Of e_CuentaCtePersonal)) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeGratificacion As e_Gratificacion) As Boolean

    '<OperationContract()> _
    'Function CrearDT() As Data.DataTable

    '<OperationContract()> _
    'Function CompletaConCeros(ByVal ls_Tex As String, ByVal lnCantidad As Integer) As String

    <OperationContract()> _
    Function Provisionar(ByVal oeGratificacion As e_Gratificacion, ByVal oeAsientoModel As e_AsientoModelo, ByVal oePeriodo As e_Periodo) As Boolean

End Interface
