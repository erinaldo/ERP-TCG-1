Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_DetalleConcepto" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_DetalleConcepto

    <OperationContract()> _
    Function Obtener(ByVal oeDetalleConcepto As e_DetalleConcepto) As e_DetalleConcepto

    <OperationContract()> _
    Function Listar(ByVal oeDetalleConcepto As e_DetalleConcepto) As List(Of e_DetalleConcepto)

    <OperationContract()> _
    Function Validar(ByVal oeDetalleConcepto As e_DetalleConcepto) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeDetalleConcepto As e_DetalleConcepto) As Boolean

    '<OperationContract()> _
    'Function GuardarMasivo(ByVal oeCuentaCtePersonal As List(Of e_CuentaCtePersonal)) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeDetalleConcepto As e_DetalleConcepto) As Boolean

    <OperationContract()> _
    Function CrearDT() As Data.DataTable

    '<OperationContract()> _
    'Function CompletaConCeros(ByVal ls_Tex As String, ByVal lnCantidad As Integer) As String

End Interface
