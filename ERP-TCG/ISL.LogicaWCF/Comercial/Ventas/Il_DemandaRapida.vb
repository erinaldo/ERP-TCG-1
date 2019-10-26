Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_DemandaRapida", también debe actualizar la referencia a "Il_DemandaRapida" en Web.config.
<ServiceContract()> _
Public Interface Il_DemandaRapida

    <OperationContract()> _
    Function Obtener(ByVal oeDemandaRapida As e_DemandaRapida) As e_DemandaRapida

    <OperationContract()> _
    Function Listar(ByVal oeDemandaRapida As e_DemandaRapida) As List(Of e_DemandaRapida)

    <OperationContract()> _
    Function ValidarRuta(ByVal Id As String) As Boolean

    <OperationContract()> _
    Function ValidarCliente(ByVal Id As String) As Boolean

    <OperationContract()> _
    Function ValidarComision(ByVal Id As String) As Boolean

    <OperationContract()> _
    Function Validar(ByVal oeDemandaRapida As e_DemandaRapida) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeDemandaRapida As e_DemandaRapida) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeDemandaRapida As e_DemandaRapida) As Boolean

End Interface
