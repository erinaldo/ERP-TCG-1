Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_ControlPersonaVehiculoES", también debe actualizar la referencia a "Il_ControlPersonaVehiculoES" en Web.config.
<ServiceContract()> _
Public Interface Il_ControlPersonaVehiculoES

    <OperationContract()> _
    Function Obtener(ByVal oeControlPersonaVehiculoES As e_ControlPersonaVehiculoES) As e_ControlPersonaVehiculoES

    <OperationContract()> _
    Function Listar(ByVal oeControlPersonaVehiculoES As e_ControlPersonaVehiculoES) As List(Of e_ControlPersonaVehiculoES)

    <OperationContract()> _
   Function ListarTablas(ByVal oeControlPersonaVehiculoES As e_ControlPersonaVehiculoES) As DataSet

    <OperationContract()> _
    Function Validar(ByVal oeControlPersonaVehiculoES As e_ControlPersonaVehiculoES) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeControlPersonaVehiculoES As e_ControlPersonaVehiculoES) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeControlPersonaVehiculoES As e_ControlPersonaVehiculoES) As Boolean

End Interface
