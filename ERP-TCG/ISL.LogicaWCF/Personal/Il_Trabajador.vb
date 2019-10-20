Imports System.ServiceModel
Imports ERP.EntidadesWCF

<ServiceContract()> _
Public Interface Il_Trabajador

    <OperationContract()> _
    Function ValidarCodigo(ByVal Codigo As String) As Boolean

    <OperationContract()> _
    Function ValidarRutaImagen(ByVal RutaImagen As String) As Boolean

    <OperationContract()> _
    Overloads Function Validar(ByVal oeTrabajador As e_Trabajador) As Boolean

    <OperationContract()> _
    Overloads Function Obtener(ByVal oeTrabajador As e_Trabajador) As e_Trabajador

    <OperationContract()> _
    Overloads Function ObtenerObjeto(ByVal oeTrabajador As e_Trabajador) As e_Trabajador

    <OperationContract()> _
    Overloads Function Listar(ByVal oeTrabajador As e_Trabajador) As List(Of e_Trabajador)

    <OperationContract()> _
    Overloads Function Listar2(ByVal oeTrabajador As e_Trabajador) As List(Of e_Trabajador)

    <OperationContract()> _
    Function ListarOnomasticos(ByVal mes As String, Optional ByVal dia As String = "") As List(Of e_Onomastico)

    <OperationContract()> _
    Overloads Function Guardar(ByVal oeTrabajador As e_Trabajador) As Boolean

    <OperationContract()> _
    Overloads Function GambiarClaveSeguridad(ByVal oeTrabajador As e_Trabajador) As Boolean

    <OperationContract()> _
    Overloads Function Eliminar(ByVal oeTrabajador As e_Trabajador) As Boolean

    <OperationContract()> _
    Overloads Function EliminacionDefinitiva(ByVal oeTrabajador As e_Trabajador) As Boolean

    <OperationContract()> _
    Function ComboGrilla(ByVal ListaTrabajador As List(Of e_Trabajador))

    <OperationContract()> _
    Function ValidarTrabajador(ByVal Id As String) As Boolean

    <OperationContract()> _
    Function CargarDatosGenerales(ByVal oeTrabajador As e_Trabajador) As Data.DataSet

    <OperationContract()> _
    Function Migrar(ByVal oeTrabajador As e_Trabajador) As Boolean

End Interface
