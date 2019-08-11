Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_EstadoOT", también debe actualizar la referencia a "Il_EstadoOT" en Web.config.
<ServiceContract()> _
Public Interface Il_EstadoOT

    <OperationContract()> _
    Function Obtener(ByVal oeEstadoOT As e_EstadoOT) As e_EstadoOT

    <OperationContract()> _
    Function Listar(ByVal oeEstadoOT As e_EstadoOT) As List(Of e_EstadoOT)

    <OperationContract()> _
    Function Validar(ByVal oeEstadoOT As e_EstadoOT) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeEstadoOT As e_EstadoOT) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeEstadoOT As e_EstadoOT) As Boolean

End Interface
