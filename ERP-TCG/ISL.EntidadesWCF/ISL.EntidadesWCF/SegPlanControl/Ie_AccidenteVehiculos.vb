Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_AccidenteVehiculos", también debe actualizar la referencia a "Ie_AccidenteVehiculos" en Web.config.
<ServiceContract()> _
Public Interface Ie_AccidenteVehiculos

    <OperationContract()> _
    Function Obtener(ByVal listaAccidenteVehiculo As List(Of e_AccidenteVehiculo)) As List(Of e_AccidenteVehiculo)

    <OperationContract()> _
    Function Agregar(ByVal accidenteVehiculo As e_AccidenteVehiculo) As List(Of e_AccidenteVehiculo)

    <OperationContract()> _
    Function Quitar(ByVal accidenteVehiculo As e_AccidenteVehiculo) As List(Of e_AccidenteVehiculo)

    <OperationContract()> _
    Function Filtrar(ByVal accidenteVehiculo As e_AccidenteVehiculo) As List(Of e_AccidenteVehiculo)

    <OperationContract()> _
    Function Cuantos() As Integer

End Interface
