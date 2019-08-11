Imports System.ServiceModel
Imports System.ComponentModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_TablaContableDet", también debe actualizar la referencia a "Il_TablaContableDet" en Web.config.
<ServiceContract()> _
Public Interface Il_TablaContableDet

    <OperationContract()> _
    Function Obtener(ByVal oeTablaContableDet As e_TablaContableDet) As e_TablaContableDet

    <OperationContract()> _
    Function Listar(ByVal oeTablaContableDet As e_TablaContableDet) As List(Of e_TablaContableDet)

    <OperationContract()> _
    Function ListarBind(ByVal oeTablaContableDet As e_TablaContableDet) As BindingList(Of e_TablaContableDet)

    <OperationContract()> _
    Function Validar(ByVal oeTablaContableDet As e_TablaContableDet) As Boolean

    <OperationContract()> _
    Function ValidarDuplicado(ByVal id As String, ByVal valor As String, ByVal campo As String) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeTablaContableDet As e_TablaContableDet) As Boolean

    <OperationContract()> _
    Function GuardarMasivo(ByVal leTablaContableDet As List(Of e_TablaContableDet)) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeTablaContableDet As e_TablaContableDet) As Boolean

    <OperationContract()> _
    Function CrearDT() As Data.DataTable

    <OperationContract()> _
    Function CompletaConCeros(ByVal ls_Tex As String, ByVal lnCantidad As Integer) As String

End Interface
