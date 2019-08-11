Imports System.ServiceModel
Imports ISL.EntidadesWCF

<ServiceContract()> _
Public Interface Il_Requerimiento

    <OperationContract()> _
    Function Listar(ByVal oeRequerimiento As e_Requerimiento) As List(Of e_Requerimiento)

    <OperationContract()> _
    Function Guardar(ByVal oeRequerimiento As e_Requerimiento) As Boolean

    <OperationContract()> _
    Function GuardarLista(ByVal lstRequerimientos As List(Of e_Requerimiento)) As Boolean

    <OperationContract()> _
    Function Obtener(ByVal oeRequerimiento As e_Requerimiento) As e_Requerimiento

    <OperationContract()> _
    Function Eliminar(ByVal oeRequerimiento As e_Requerimiento) As Boolean

    <OperationContract()> _
    Function Validar(ByVal oeRequerimiento As e_Requerimiento) As Boolean

    <OperationContract()> _
    Function ActualizaOT(ByVal oeRequerimiento As e_Requerimiento) As Boolean

End Interface
