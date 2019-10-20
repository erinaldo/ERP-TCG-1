Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_PagoAdicional" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_MovimientoPeaje

    Function GuardarConDocumento(ListaMovimientoPeaje As List(Of e_MovimientoPeaje), ListaDocumentos As List(Of e_MovimientoDocumento)) As Boolean

    Function ListaAsociacionMovimientoPeaje(oeMovimientoPeaje As e_MovimientoPeaje) As DataSet

    <OperationContract()> _
    Function ImportarDatos(leMovimientoPeaje As List(Of e_MovimientoPeaje)) As Boolean

    <OperationContract()> _
    Function Obtener(ByVal oePagoAdicional As e_MovimientoPeaje) As e_MovimientoPeaje

    <OperationContract()> _
    Function Listar(ByVal oePagoAdicional As e_MovimientoPeaje) As List(Of e_MovimientoPeaje)

    <OperationContract()> _
    Function Validar(ByVal oePagoAdicional As e_MovimientoPeaje) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oePagoAdicional As e_MovimientoPeaje) As Boolean

    '<OperationContract()> _
    'Function ImportarDatos(ByVal oePagoAdicional As e_MovimientoPeaje) As Boolean

    '<OperationContract()> _
    'Function GuardarMasivo(ByVal oeCuentaCtePersonal As List(Of e_CuentaCtePersonal)) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oePagoAdicional As e_MovimientoPeaje) As Boolean

    '<OperationContract()> _
    'Function CrearDT() As Data.DataTable

    '<OperationContract()> _
    'Function CompletaConCeros(ByVal ls_Tex As String, ByVal lnCantidad As Integer) As String

End Interface
