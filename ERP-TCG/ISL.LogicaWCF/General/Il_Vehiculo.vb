Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Vehiculo", también debe actualizar la referencia a "Il_Vehiculo" en Web.config.
<ServiceContract()> _
Public Interface Il_Vehiculo

    <OperationContract()> _
    Function ValidarDuplicado(ByVal ls_Placa As String) As Boolean

    <OperationContract()> _
    Function Validar(ByVal oeVehiculo As e_Vehiculo) As Boolean

    <OperationContract()> _
    Function ValidarVehiculo(ByVal oeVehiculo As e_Vehiculo) As e_Vehiculo

    <OperationContract()> _
    Function Guardar(ByVal oeVehiculo As e_Vehiculo) As Boolean

    <OperationContract()> _
    Function Obtener(ByVal oeVehiculo As e_Vehiculo) As e_Vehiculo

    <OperationContract()> _
    Function Listar(ByVal oeVehiculo As e_Vehiculo) As List(Of e_Vehiculo)

    <OperationContract()> _
    Function ListarSituacional(ByVal oeVehiculo As e_Vehiculo) As DataSet

    <OperationContract()> _
    Function Eliminar(ByVal oeVehiculo As e_Vehiculo) As Boolean

    <OperationContract()> _
    Function ComboGrilla(ByVal listaVehiculo As List(Of e_Vehiculo))

    <OperationContract()> _
    Function ValidarTractoMantenimiento(ByVal Id As String) As Boolean

    <OperationContract()> _
    Function ValidarCarretaMantenimiento(ByVal Id As String) As Boolean

    <OperationContract()> _
    Function ObtenerEstado(ByVal oeVehiculoEstado As e_VehiculoEstado) As e_VehiculoEstado

    <OperationContract()> _
    Function ListarEstado(ByVal oeVehiculoEstado As e_VehiculoEstado) As List(Of e_VehiculoEstado)

    <OperationContract()> _
    Function ValidarEstado(ByVal oeVehiculoEstado As e_VehiculoEstado) As Boolean

    <OperationContract()> _
    Function GuardarEstado(ByVal oeVehiculoEstado As e_VehiculoEstado) As Boolean

    <OperationContract()> _
    Function EliminarEstado(ByVal oeVehiculoEstado As e_VehiculoEstado) As Boolean

    <OperationContract()> _
    Function EditarEstado(ByVal oeVehiculoEstado As e_VehiculoEstado) As Boolean

End Interface
