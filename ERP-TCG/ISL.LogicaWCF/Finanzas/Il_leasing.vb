Imports System.ServiceModel
Imports ISL.EntidadesWCF

<ServiceContract()> _
Public Interface Il_leasing

    <OperationContract()> _
    Function Obtener(ByVal oeLeasing As e_Leasing) As e_Leasing

    <OperationContract()> _
    Function Listar(ByVal oeLeasing As e_Leasing) As List(Of e_Leasing)

    <OperationContract()> _
    Function Validar(ByVal oeLeasing As e_Leasing) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeLeasing As e_Leasing) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeLeasing As e_Leasing) As Boolean

End Interface
