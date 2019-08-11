Imports System.ServiceModel
Imports ISL.EntidadesWCF

<ServiceContract()> _
Public Interface Il_Gerencia

    <OperationContract()> _
    Function Obtener(ByVal oeGerencia As e_Gerencia) As e_Gerencia

    <OperationContract()> _
    Function Listar(ByVal oeGerencia As e_Gerencia) As List(Of e_Gerencia)

    <OperationContract()> _
    Function Validar(ByVal oeGerencia As e_Gerencia) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeGerencia As e_Gerencia) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeGerencia As e_Gerencia) As Boolean

End Interface