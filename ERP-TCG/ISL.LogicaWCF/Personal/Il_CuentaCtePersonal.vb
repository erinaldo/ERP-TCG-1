Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_CuentaCtePersonal", también debe actualizar la referencia a "Il_CuentaCtePersonal" en Web.config.
<ServiceContract()> _
Public Interface Il_CuentaCtePersonal

    <OperationContract()> _
    Function Obtener(ByVal oeCuentaCtePersonal As e_CuentaCtePersonal) As e_CuentaCtePersonal

    <OperationContract()> _
    Function Listar(ByVal oeCuentaCtePersonal As e_CuentaCtePersonal) As List(Of e_CuentaCtePersonal)

    <OperationContract()> _
    Function Validar(ByVal oeCuentaCtePersonal As e_CuentaCtePersonal) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeCuentaCtePersonal As e_CuentaCtePersonal) As Boolean

    <OperationContract()>
    Function GuardarMasivo(ByVal oeCuentaCtePersonal As List(Of e_CuentaCtePersonal), ByVal PrefijoID As String) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeCuentaCtePersonal As e_CuentaCtePersonal) As Boolean

    <OperationContract()> _
    Function CrearDT() As Data.DataTable

    <OperationContract()> _
    Function CompletaConCeros(ByVal ls_Tex As String, ByVal lnCantidad As Integer) As String

End Interface
