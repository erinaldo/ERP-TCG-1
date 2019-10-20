Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_GastoVehiculo", también debe actualizar la referencia a "Il_GastoVehiculo" en Web.config.
<ServiceContract()> _
Public Interface Il_GastoVehiculo

    <OperationContract()> _
    Function Obtener(ByVal oeGrupo As e_GastoVehiculo) As e_GastoVehiculo

    <OperationContract()> _
    Function Listar(ByVal oeGrupo As e_GastoVehiculo) As List(Of e_GastoVehiculo)

    <OperationContract()> _
    Function Validar(ByVal oeGrupo As e_GastoVehiculo) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeGrupo As e_GastoVehiculo) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeGrupo As e_GastoVehiculo) As Boolean

End Interface
