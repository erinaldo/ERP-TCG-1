Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_OtrosDescuentos" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_OtrosDescuentos

    <OperationContract()> _
    Function Obtener(ByVal oeOtrosDescuentos As e_OtrosDescuentos) As e_OtrosDescuentos

    <OperationContract()> _
    Function Listar(ByVal oeOtrosDescuentos As e_OtrosDescuentos) As List(Of e_OtrosDescuentos)

    <OperationContract()> _
    Function Validar(ByVal oeOtrosDescuentos As e_OtrosDescuentos) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeOtrosDescuentos As e_OtrosDescuentos) As Boolean

    <OperationContract()>
    Function GuardarMasivo(ByVal leOtrosDescuentos As List(Of e_OtrosDescuentos), ByVal PrefijoID As String) As Boolean

    <OperationContract()> _
    Function GuardarLista(ByVal leOtrosDescuentos As List(Of e_OtrosDescuentos)) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeOtrosDescuentos As e_OtrosDescuentos) As Boolean

    <OperationContract()> _
    Function CrearDT() As Data.DataTable

    <OperationContract()> _
    Function CompletaConCeros(ByVal ls_Tex As String, ByVal lnCantidad As Integer) As String

End Interface
