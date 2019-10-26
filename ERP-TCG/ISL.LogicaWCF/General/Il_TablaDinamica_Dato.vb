Imports System.ServiceModel
Imports ERP.EntidadesWCF
' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_TablaDinamica_Dato" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_TablaDinamica_Dato

    <OperationContract()>
    Function Obtener(ByVal oeTablaDinamica_Dato As e_TablaDinamica_Dato) As e_TablaDinamica_Dato

    <OperationContract()>
    Function Listar(ByVal oeTablaDinamica_Dato As e_TablaDinamica_Dato) As List(Of e_TablaDinamica_Dato)

    <OperationContract()>
    Function Guardar(ByVal oeTablaDinamica_Dato As e_TablaDinamica_Dato) As Boolean

    <OperationContract()>
    Function Eliminar(ByVal oeTablaDinamica_Dato As e_TablaDinamica_Dato) As Boolean

    <OperationContract()>
    Function CrearDT() As Data.DataTable

    <OperationContract()>
    Function CompletaConCeros(ByVal ls_Tex As String, ByVal lnCantidad As Integer) As String

End Interface
