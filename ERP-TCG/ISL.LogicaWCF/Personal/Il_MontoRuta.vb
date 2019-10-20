Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_MontoRuta" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_MontoRuta

    <OperationContract()> _
    Function CrearDT() As Data.DataTable

    <OperationContract()> _
    Function CompletaConCeros(ByVal ls_Tex As String, ByVal lnCantidad As Integer) As String

    <OperationContract()> _
    Function Obtener(ByVal oeMontoRuta As e_MontoRuta) As e_MontoRuta

    <OperationContract()> _
    Function Listar(ByVal oeMontoRuta As e_MontoRuta) As List(Of e_MontoRuta)

    <OperationContract()>
    Function GuardarMasivo(ByVal lista As List(Of e_MontoRuta), ByVal PrefijoID As String) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeMontoRuta As e_MontoRuta) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeMontoRuta As e_MontoRuta) As Boolean

    <OperationContract()> _
    Function Validar(ByVal oeMontoRuta As e_MontoRuta) As Boolean

End Interface
