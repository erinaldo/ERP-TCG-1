Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_PlanillaPiloto" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_PlanillaPiloto

    <OperationContract()> _
    Function Obtener(ByVal oePlanillaPiloto As e_PlanillaPiloto) As e_PlanillaPiloto

    <OperationContract()> _
    Function Listar(ByVal oePlanillaPiloto As e_PlanillaPiloto) As List(Of e_PlanillaPiloto)

    <OperationContract()> _
    Function ListarDS(ByVal oePlanillaPiloto As e_PlanillaPiloto) As System.Data.DataSet

    <OperationContract()> _
    Function Validar(ByVal oePlanillaPiloto As e_PlanillaPiloto) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oePlanillaPiloto As e_PlanillaPiloto) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oePlanillaPiloto As e_PlanillaPiloto) As Boolean

End Interface
