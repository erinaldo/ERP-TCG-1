Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_TablaContable", también debe actualizar la referencia a "Il_TablaContable" en Web.config.
<ServiceContract()> _
Public Interface Il_TablaContable

    <OperationContract()> _
    Function Obtener(ByVal oeTablaContable As e_TablaContable) As e_TablaContable

    <OperationContract()> _
    Function Listar(ByVal oeTablaContable As e_TablaContable) As List(Of e_TablaContable)

    <OperationContract()> _
    Function Validar(ByVal oeTablaContable As e_TablaContable) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeTablaContable As e_TablaContable) As Boolean

    <OperationContract()>
    Function GuardarMasivo(ByVal leTablaContable As List(Of e_TablaContable), ByVal PrefijoID As String) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeTablaContable As e_TablaContable) As Boolean

    <OperationContract()> _
    Function CrearDT() As Data.DataTable

    <OperationContract()> _
    Function CompletaConCeros(ByVal ls_Tex As String, ByVal lnCantidad As Integer) As String

End Interface
