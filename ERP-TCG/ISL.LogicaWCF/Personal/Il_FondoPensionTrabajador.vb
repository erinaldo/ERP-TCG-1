Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_FondoPensionTrabajador", también debe actualizar la referencia a "Il_FondoPensionTrabajador" en Web.config.
<ServiceContract()> _
Public Interface Il_FondoPensionTrabajador

    <OperationContract()> _
    Function Obtener(ByVal oeFondoPensionTrabajador As e_FondoPensionTrabajador) As e_FondoPensionTrabajador

    <OperationContract()> _
    Function Listar(ByVal oeFondoPensionTrabajador As e_FondoPensionTrabajador) As List(Of e_FondoPensionTrabajador)

    <OperationContract()> _
    Function Validar(ByVal oeFondoPensionTrabajador As e_FondoPensionTrabajador) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeFondoPensionTrabajador As e_FondoPensionTrabajador) As Boolean

    <OperationContract()>
    Function GuardarMasivo(ByVal leFondoPensionTrabajador As List(Of e_FondoPensionTrabajador), ByVal PrefijoID As String) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeFondoPensionTrabajador As e_FondoPensionTrabajador) As Boolean

    <OperationContract()> _
    Function CrearDT() As Data.DataTable

    <OperationContract()> _
    Function CompletaConCeros(ByVal ls_Tex As String, ByVal lnCantidad As Integer) As String

End Interface
