Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Mantenimiento", también debe actualizar la referencia a "Il_Mantenimiento" en Web.config.
<ServiceContract()> _
Public Interface Il_Mantenimiento

    <OperationContract()> _
    Function ListarProyeccionMantenimiento(ByVal ls_IdMarca As String, ByVal ls_IdModelo As String, ByVal ls_TipoProyeccion As String) As Data.DataSet

    <OperationContract()> _
    Function Obtener(ByVal oeMantenimiento As e_Mantenimiento) As e_Mantenimiento

    <OperationContract()> _
    Function Listar(ByVal oeMantenimiento As e_Mantenimiento) As List(Of e_Mantenimiento)

    <OperationContract()> _
    Function ListarProyMant(ByVal oeProyMant As e_ProyMantenimiento) As List(Of e_ProyMantenimiento)

    <OperationContract()> _
    Function ListarDS(ByVal oeMantenimiento As e_Mantenimiento) As Data.DataSet

    <OperationContract()> _
    Function ValidarDuplicado(ByVal ls_Id As String, ByVal ls_Nombre As String) As Boolean

    <OperationContract()> _
    Function Validar(ByVal oeMantenimiento As e_Mantenimiento) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeMantenimiento As e_Mantenimiento) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeMantenimiento As e_Mantenimiento) As Boolean

End Interface
