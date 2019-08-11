Imports System.ServiceModel
Imports ISL.EntidadesWCF

<ServiceContract()> _
Public Interface Il_SituacionAdministrativa

    <OperationContract()> _
    Function Obtener(ByVal oeSituacionAdministrativa As e_SituacionAdministrativa) As e_SituacionAdministrativa

    <OperationContract()> _
    Function Listar(ByVal oeSituacionAdministrativa As e_SituacionAdministrativa) As List(Of e_SituacionAdministrativa)

    <OperationContract()> _
    Function Guardar(ByVal oeSituacionAdministrativa As e_SituacionAdministrativa) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeSituacionAdministrativa As e_SituacionAdministrativa) As Boolean

    <OperationContract()> _
    Function Validar(ByVal oeSituacionAdministrativa As e_SituacionAdministrativa) As Boolean

    <OperationContract()> _
    Function ValidarDuplicado(ByVal id As String, ByVal valor As String, ByVal campo As String) As Boolean

End Interface
