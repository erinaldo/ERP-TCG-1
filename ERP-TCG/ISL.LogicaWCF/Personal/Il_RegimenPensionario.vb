Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_RegimenPensionario", también debe actualizar la referencia a "Il_RegimenPensionario" en Web.config.
<ServiceContract()> _
Public Interface Il_RegimenPensionario

    <OperationContract()> _
   Function Obtener(ByVal oeRegimenPensionario As e_RegimenPensionario) As e_RegimenPensionario

    <OperationContract()> _
    Function Listar(ByVal oeRegimenPensionario As e_RegimenPensionario) As List(Of e_RegimenPensionario)

    <OperationContract()> _
    Function Validar(ByVal oeRegimenPensionario As e_RegimenPensionario) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeRegimenPensionario As e_RegimenPensionario) As Boolean

    <OperationContract()>
    Function GuardarMasivo(ByVal leRegimenPensionario As List(Of e_RegimenPensionario), ByVal PrefijoID As String) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeRegimenPensionario As e_RegimenPensionario) As Boolean

    <OperationContract()> _
   Function CrearDT() As Data.DataTable

    <OperationContract()> _
    Function CompletaConCeros(ByVal ls_Tex As String, ByVal lnCantidad As Integer) As String

End Interface
