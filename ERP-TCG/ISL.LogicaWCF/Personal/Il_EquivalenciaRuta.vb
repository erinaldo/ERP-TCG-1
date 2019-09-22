Imports System.ServiceModel
Imports ISL.EntidadesWCF
' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_EquivalenciaRuta" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_EquivalenciaRuta

    <OperationContract()> _
    Overloads Function Validar(ByVal oeEquivalenciaRuta As e_EquivalenciaRuta) As Boolean

    <OperationContract()> _
    Overloads Function Obtener(ByVal oeEquivalenciaRuta As e_EquivalenciaRuta) As e_EquivalenciaRuta

    <OperationContract()> _
    Overloads Function Listar(ByVal oeEquivalenciaRuta As e_EquivalenciaRuta) As List(Of e_EquivalenciaRuta)

    <OperationContract()> _
    Overloads Function Guardar(ByVal oeEquivalenciaRuta As e_EquivalenciaRuta) As Boolean

    <OperationContract()> _
    Overloads Function Eliminar(ByVal oeEquivalenciaRuta As e_EquivalenciaRuta) As Boolean

    <OperationContract()> _
    Function CrearDT() As Data.DataTable

    <OperationContract()> _
    Function CompletaConCeros(ByVal ls_Tex As String, ByVal lnCantidad As Integer) As String

    <OperationContract()>
    Function GuardarMasivo(ByVal lista As List(Of e_EquivalenciaRuta), ByVal PrefijoID As String) As Boolean

End Interface
