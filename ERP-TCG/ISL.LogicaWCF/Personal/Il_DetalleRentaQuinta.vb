Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_DetalleRentaQuinta" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_DetalleRentaQuinta

    <OperationContract()> _
    Function Obtener(ByVal oeDetalleRentaQuinta As e_DetalleRentaQuinta) As e_DetalleRentaQuinta

    <OperationContract()> _
    Function Listar(ByVal oeDetalleRentaQuinta As e_DetalleRentaQuinta) As List(Of e_DetalleRentaQuinta)

    <OperationContract()> _
    Function Validar(ByVal oeDetalleRentaQuinta As e_DetalleRentaQuinta) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeDetalleRentaQuinta As e_DetalleRentaQuinta) As Boolean

    '<OperationContract()> _
    'Function GuardarMasivo(ByVal oeCuentaCtePersonal As List(Of e_CuentaCtePersonal)) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeDetalleRentaQuinta As e_DetalleRentaQuinta) As Boolean

    <OperationContract()> _
    Function CrearDT() As Data.DataTable

    <OperationContract()> _
    Function CompletaConCeros(ByVal ls_Tex As String, ByVal lnCantidad As Integer) As String

End Interface
