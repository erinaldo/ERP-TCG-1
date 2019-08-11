Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Actividad", también debe actualizar la referencia a "Il_Actividad" en Web.config.
<ServiceContract()> _
Public Interface Il_Actividad

    <OperationContract()> _
    Function ValidarDuplicado(ByVal ID As String, ByVal NOMBRE As String) As Boolean

    <OperationContract()> _
    Function Obtener(ByVal oeActividad As e_Actividad) As e_Actividad

    <OperationContract()> _
    Function Listar(ByVal oeActividad As e_Actividad) As List(Of e_Actividad)

    <OperationContract()> _
    Function Validar(ByVal oeActividad As e_Actividad) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeActividad As e_Actividad) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeActividad As e_Actividad) As Boolean

End Interface
