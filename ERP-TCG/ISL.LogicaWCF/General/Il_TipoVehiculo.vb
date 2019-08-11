Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_TipoVehiculo", también debe actualizar la referencia a "Il_TipoVehiculo" en Web.config.
<ServiceContract()> _
Public Interface Il_TipoVehiculo

    <OperationContract()> _
    Function ValidarDuplicado(ByVal ls_Id As String, ByVal ls_Nombre As String) As Boolean

    <OperationContract()> _
    Function Obtener(ByVal oeTipoVehiculo As e_TipoVehiculo) As e_TipoVehiculo

    <OperationContract()> _
    Function Listar(ByVal oeTipoVehiculo As e_TipoVehiculo) As List(Of e_TipoVehiculo)

    <OperationContract()> _
    Function Validar(ByVal oeTipoVehiculo As e_TipoVehiculo) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeTipoVehiculo As e_TipoVehiculo) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeTipoVehiculo As e_TipoVehiculo) As Boolean

    <OperationContract()> _
    Function ComboGrilla(ByVal ListaTipoVehiculo As List(Of e_TipoVehiculo))

End Interface
