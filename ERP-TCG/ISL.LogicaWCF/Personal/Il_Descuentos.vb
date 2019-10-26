Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_Descuentos" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_Descuentos

    <OperationContract()> _
    Function Obtener(ByVal oeDescuentos As e_Descuentos) As e_Descuentos

    <OperationContract()> _
    Function Listar(ByVal oeDescuentos As e_Descuentos) As List(Of e_Descuentos)

    <OperationContract()> _
    Function Validar(ByVal oeDescuentos As e_Descuentos) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeDescuentos As e_Descuentos) As Boolean

    <OperationContract()>
    Function GuardarMasivo(ByVal leDescuentos As List(Of e_Descuentos), ByVal PrefijoID As String) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeDescuentos As e_Descuentos) As Boolean

    <OperationContract()> _
    Function CrearDT() As Data.DataTable

    <OperationContract()> _
    Function CompletaConCeros(ByVal ls_Tex As String, ByVal lnCantidad As Integer) As String

End Interface
