Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Ruta", también debe actualizar la referencia a "Il_Ruta" en Web.config.
<ServiceContract()> _
Public Interface Il_Ruta

    <OperationContract()> _
    Function Obtener(ByVal oeRuta As e_Ruta) As e_Ruta

    <OperationContract()> _
    Function Listar(ByVal oeRuta As e_Ruta) As List(Of e_Ruta)

    <OperationContract()> _
    Function ListarGrupos(ByVal oeRuta As e_Ruta) As DataSet

    <OperationContract()> _
    Function ValidarOrigen(ByVal Id As String) As Boolean

    <OperationContract()> _
    Function ValidarDestino(ByVal Id As String) As Boolean

    <OperationContract()> _
    Function ValidarCentro(ByVal Id As String) As Boolean

    <OperationContract()> _
    Function ValidarFlota(ByVal Id As String) As Boolean

    <OperationContract()> _
    Function ValidarRuta(ByVal oeRuta As e_Ruta) As Boolean

    <OperationContract()> _
    Function ValidarRutaNueva(ByVal oeRuta As e_Ruta) As Boolean

    <OperationContract()> _
    Function Validar(ByVal oeRuta As e_Ruta) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeRuta As e_Ruta) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeRuta As e_Ruta) As Boolean

    <OperationContract()> _
    Function ValidarZonaD2(ByVal oeRuta As e_Ruta) As Boolean

End Interface
