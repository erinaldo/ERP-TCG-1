Imports System.ServiceModel
Imports ISL.EntidadesWCF

<ServiceContract()> _
Public Interface Il_EntornoTrabajo

    <OperationContract()> _
    Function Obtener(ByVal oeEntornoTrabajo As e_EntornoTrabajo) As e_EntornoTrabajo

    <OperationContract()> _
    Function Listar(ByVal oeEntornoTrabajo As e_EntornoTrabajo) As List(Of e_EntornoTrabajo)

    <OperationContract()> _
    Function Validar(ByVal oeEntornoTrabajo As e_EntornoTrabajo) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeEntornoTrabajo As e_EntornoTrabajo) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeEntornoTrabajo As e_EntornoTrabajo) As Boolean

End Interface
