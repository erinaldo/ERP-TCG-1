Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_ControlCargaVehiculoES", también debe actualizar la referencia a "Il_ControlCargaVehiculoES" en Web.config.
<ServiceContract()> _
Public Interface Il_ControlCargaVehiculoES

    <OperationContract()> _
    Function Obtener(ByVal oeControlCargaVehiculoES As e_ControlCargaVehiculoES) As e_ControlCargaVehiculoES

    <OperationContract()> _
    Function Listar(ByVal oeControlCargaVehiculoES As e_ControlCargaVehiculoES) As List(Of e_ControlCargaVehiculoES)

    <OperationContract()> _
    Function Validar(ByVal oeControlCargaVehiculoES As e_ControlCargaVehiculoES) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeControlCargaVehiculoES As e_ControlCargaVehiculoES) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeControlCargaVehiculoES As e_ControlCargaVehiculoES) As Boolean

End Interface
