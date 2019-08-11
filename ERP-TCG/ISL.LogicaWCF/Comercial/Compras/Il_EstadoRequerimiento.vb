Imports System.ServiceModel
Imports ISL.EntidadesWCF

<ServiceContract()> _
Public Interface Il_EstadoRequerimiento

    <OperationContract()> _
    Function Obtener(ByVal oeEstadoRequerimiento As e_EstadoRequerimiento) As e_EstadoRequerimiento

    <OperationContract()> _
    Function Listar(ByVal oeEstadoRequerimiento As e_EstadoRequerimiento) As List(Of e_EstadoRequerimiento)

    <OperationContract()> _
    Function Validar(ByVal oeEstadoRequerimiento As e_EstadoRequerimiento) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeEstadoRequerimiento As e_EstadoRequerimiento) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeEstadoRequerimiento As e_EstadoRequerimiento) As Boolean

End Interface
