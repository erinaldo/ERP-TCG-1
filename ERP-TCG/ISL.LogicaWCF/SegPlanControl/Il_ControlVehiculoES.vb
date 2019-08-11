Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_ControlVehiculoES", también debe actualizar la referencia a "Il_ControlVehiculoES" en Web.config.
<ServiceContract()> _
Public Interface Il_ControlVehiculoES

    <OperationContract()> _
    Function Obtener(ByVal oeControlVehiculoES As e_ControlVehiculoES) As e_ControlVehiculoES

    <OperationContract()> _
    Function Listar(ByVal oeControlVehiculoES As e_ControlVehiculoES) As List(Of e_ControlVehiculoES)

    <OperationContract()> _
    Function Validar(ByVal oeControlVehiculoES As e_ControlVehiculoES) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeControlVehiculoES As e_ControlVehiculoES) As Boolean

    <OperationContract()> _
    Function GuardarLista(ByVal lstControlVehiculoES As List(Of e_ControlVehiculoES)) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeControlVehiculoES As e_ControlVehiculoES) As Boolean

End Interface
