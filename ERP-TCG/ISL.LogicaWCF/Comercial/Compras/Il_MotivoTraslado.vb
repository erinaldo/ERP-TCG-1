Imports System.ServiceModel
Imports ISL.EntidadesWCF

<ServiceContract()> _
Public Interface Il_MotivoTraslado

    <OperationContract()> _
    Function Obtener(ByVal oeMotivoTraslado As e_MotivoTraslado) As e_MotivoTraslado

    <OperationContract()> _
    Function Listar(ByVal oeMotivoTraslado As e_MotivoTraslado) As List(Of e_MotivoTraslado)

    <OperationContract()> _
    Function Validar(ByVal oeMotivoTraslado As e_MotivoTraslado) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeMotivoTraslado As e_MotivoTraslado) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeMotivoTraslado As e_MotivoTraslado) As Boolean

End Interface
