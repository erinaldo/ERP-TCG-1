Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_ConfiguracionDato" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_ConfiguracionDato

    <OperationContract()> _
    Function Obtener(ByVal oeConfiguracionDato As e_ConfiguracionDato) As e_ConfiguracionDato

    <OperationContract()> _
    Function Listar(ByVal oeConfiguracionDato As e_ConfiguracionDato) As List(Of e_ConfiguracionDato)

    <OperationContract()> _
    Function Validar(ByVal oeConfiguracionDato As e_ConfiguracionDato) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeConfiguracionDato As e_ConfiguracionDato) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeConfiguracionDato As e_ConfiguracionDato) As Boolean

    <OperationContract()> _
    Function CrearDT() As Data.DataTable

    <OperationContract()> _
    Function CompletaConCeros(ByVal ls_Tex As String, ByVal lnCantidad As Integer) As String

End Interface
