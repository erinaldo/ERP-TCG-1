Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_DetalleGratificacion" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_DetalleGratificacion

    <OperationContract()> _
    Function Obtener(ByVal oeDetalleGratificacion As e_DetalleGratificacion) As e_DetalleGratificacion

    <OperationContract()> _
    Function Listar(ByVal oeDetalleGratificacion As e_DetalleGratificacion) As List(Of e_DetalleGratificacion)

    <OperationContract()> _
    Function Validar(ByVal oeDetalleGratificacion As e_DetalleGratificacion) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeDetalleGratificacion As e_DetalleGratificacion) As Boolean

    '<OperationContract()> _
    'Function GuardarMasivo(ByVal oeCuentaCtePersonal As List(Of e_CuentaCtePersonal)) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeDetalleGratificacion As e_DetalleGratificacion) As Boolean

    <OperationContract()> _
    Function CrearDT() As Data.DataTable

    <OperationContract()> _
    Function CompletaConCeros(ByVal ls_Tex As String, ByVal lnCantidad As Integer) As String

End Interface
