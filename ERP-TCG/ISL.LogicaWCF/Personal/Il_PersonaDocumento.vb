Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_PersonaDocumento" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_PersonaDocumento

    <OperationContract()> _
    Function Obtener(ByVal oePersonaDocumento As e_PersonaDocumento) As e_PersonaDocumento

    <OperationContract()> _
    Function Listar(ByVal oePersonaDocumento As e_PersonaDocumento) As List(Of e_PersonaDocumento)

    <OperationContract()> _
    Function Validar(ByVal oePersonaDocumento As e_PersonaDocumento) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oePersonaDocumento As e_PersonaDocumento) As Boolean

    <OperationContract()> _
    Function GuardarMasivo(ByVal lePersonaDocumento As List(Of e_PersonaDocumento)) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oePersonaDocumento As e_PersonaDocumento) As Boolean

    <OperationContract()> _
    Function CrearDT() As Data.DataTable

    <OperationContract()> _
    Function CompletaConCeros(ByVal ls_Tex As String, ByVal lnCantidad As Integer) As String

End Interface
