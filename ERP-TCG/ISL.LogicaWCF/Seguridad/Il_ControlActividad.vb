Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_ControlActividad", también debe actualizar la referencia a "Il_ControlActividad" en Web.config.
<ServiceContract()> _
Public Interface Il_ControlActividad

    <OperationContract()> _
    Function Obtener(ByVal oeControlActividad As e_ControlActividad) As e_ControlActividad

    <OperationContract()> _
    Function Listar(ByVal oeControlActividad As e_ControlActividad) As List(Of e_ControlActividad)

    <OperationContract()> _
    Function Validar(ByVal oeControlActividad As e_ControlActividad) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeControlActividad As e_ControlActividad) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeControlActividad As e_ControlActividad) As Boolean

End Interface
