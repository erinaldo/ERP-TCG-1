Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_AccidenteVehiculo", también debe actualizar la referencia a "Il_AccidenteVehiculo" en Web.config.
<ServiceContract()> _
Public Interface Il_AccidenteVehiculo

    <OperationContract()> _
    Function Obtener(ByVal oeAccidenteVehiculo As e_AccidenteVehiculo) As e_AccidenteVehiculo

    <OperationContract()> _
    Function Listar(ByVal oeAccidenteVehiculo As e_AccidenteVehiculo) As List(Of e_AccidenteVehiculo)

    <OperationContract()> _
    Function Validar(ByVal oeAccidenteVehiculo As e_AccidenteVehiculo) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeAccidenteVehiculo As e_AccidenteVehiculo) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeAccidenteVehiculo As e_AccidenteVehiculo) As Boolean

    <OperationContract()> _
    Function EliminacionDefinitiva(ByVal oeAccidenteVehiculo As e_AccidenteVehiculo) As Boolean

End Interface
