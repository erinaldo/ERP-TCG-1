Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_SueldoTrabajador", también debe actualizar la referencia a "Il_SueldoTrabajador" en Web.config.
<ServiceContract()> _
Public Interface Il_SueldoTrabajador

    <OperationContract()> _
    Function Obtener(ByVal oeSueldoTrabajador As e_SueldoTrabajador) As e_SueldoTrabajador

    <OperationContract()> _
    Function Listar(ByVal oeSueldoTrabajador As e_SueldoTrabajador) As List(Of e_SueldoTrabajador)

    <OperationContract()> _
    Function Validar(ByVal oeSueldoTrabajador As e_SueldoTrabajador) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeSueldoTrabajador As e_SueldoTrabajador) As Boolean

    <OperationContract()>
    Function GuardarMasivo(ByVal leSueldoTrabajador As List(Of e_SueldoTrabajador), ByVal PrefijoID As String) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeSueldoTrabajador As e_SueldoTrabajador) As Boolean

    <OperationContract()> _
    Function CrearDT() As Data.DataTable

    <OperationContract()> _
    Function CompletaConCeros(ByVal ls_Tex As String, ByVal lnCantidad As Integer) As String

End Interface
