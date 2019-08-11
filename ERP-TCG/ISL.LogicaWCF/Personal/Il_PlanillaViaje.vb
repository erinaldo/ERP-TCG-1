Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_PlanillaViaje" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_PlanillaViaje

    <OperationContract()> _
    Function Listar(ByVal oePlanillaViaje As e_PlanillaViaje) As List(Of e_PlanillaViaje)

    <OperationContract()> _
    Function GuardarMasivo(ByVal loPlanillaViaje As List(Of e_PlanillaViaje)) As Boolean

    <OperationContract()> _
    Function CrearDT() As Data.DataTable

    <OperationContract()> _
    Function CompletaConCeros(ByVal ls_Tex As String, ByVal lnCantidad As Integer) As String

End Interface
