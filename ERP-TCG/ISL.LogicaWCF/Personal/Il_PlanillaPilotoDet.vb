Imports System.ServiceModel
Imports ISL.EntidadesWCF
' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_PlanillaPilotoDet" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_PlanillaPilotoDet

    <OperationContract()> _
    Function Obtener(ByVal oePlanillaPilotoDet As e_PlanillaPilotoDet) As e_PlanillaPilotoDet

    <OperationContract()> _
    Function Listar(ByVal oePlanillaPilotoDet As e_PlanillaPilotoDet) As List(Of e_PlanillaPilotoDet)

    <OperationContract()> _
    Function Validar(ByVal oePlanillaPilotoDet As e_PlanillaPilotoDet) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oePlanillaPilotoDet As e_PlanillaPilotoDet) As Boolean

End Interface
