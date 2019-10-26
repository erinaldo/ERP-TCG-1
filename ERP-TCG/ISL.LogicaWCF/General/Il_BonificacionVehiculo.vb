Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_BonificacionVehiculo", también debe actualizar la referencia a "Il_BonificacionVehiculo" en Web.config.
<ServiceContract()> _
Public Interface Il_BonificacionVehiculo

    <OperationContract()> _
     Function Listar(ByVal oeBonificacionVehiculo As e_BonificacionVehiculo) As List(Of e_BonificacionVehiculo)

    <OperationContract()> _
     Function Validar(ByVal oeBonificacionVehiculo As e_BonificacionVehiculo) As Boolean

    <OperationContract()> _
     Function Guardar(ByVal oeBonificacionVehiculo As e_BonificacionVehiculo) As Boolean

End Interface
