Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_ResumenAsistencia" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_ResumenAsistencia

    Function AsistenciaOperativos(oeResumenAsistencia As e_ResumenAsistencia) As DataTable

    <OperationContract()> _
    Function Obtener(ByVal oeResumenAsistencia As e_ResumenAsistencia) As e_ResumenAsistencia

    <OperationContract()> _
    Function Listar(ByVal oeResumenAsistencia As e_ResumenAsistencia) As List(Of e_ResumenAsistencia)

    <OperationContract()> _
    Function Validar(ByVal oeResumenAsistencia As e_ResumenAsistencia) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeResumenAsistencia As e_ResumenAsistencia) As Boolean

    <OperationContract()> _
    Function GuardarLista(ByVal leResumenAsistencia As List(Of e_ResumenAsistencia)) As Boolean

    <OperationContract()> _
    Function GuardarMasivo(ByVal leResumenAsistencia As List(Of e_ResumenAsistencia)) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeResumenAsistencia As e_ResumenAsistencia) As Boolean

    <OperationContract()> _
    Function EliminarLista(ByVal leResumenAsistencia As List(Of e_ResumenAsistencia)) As Boolean

    <OperationContract()> _
    Function CrearDT() As Data.DataTable

    <OperationContract()> _
    Function CompletaConCeros(ByVal ls_Tex As String, ByVal lnCantidad As Integer) As String



End Interface
