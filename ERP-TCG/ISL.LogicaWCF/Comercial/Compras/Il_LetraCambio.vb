Imports System.ServiceModel
Imports ISL.EntidadesWCF

<ServiceContract()> _
Public Interface Il_LetraCambio

    <OperationContract()> _
    Function Obtener(ByVal oeLetraCambio As e_LetraCambio) As e_LetraCambio

    <OperationContract()> _
    Function Listar(ByVal oeLetraCambio As e_LetraCambio) As List(Of e_LetraCambio)

    <OperationContract()> _
    Function Validar(ByVal oeLetraCambio As e_LetraCambio) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeLetraCambio As e_LetraCambio) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeLetraCambio As e_LetraCambio) As Boolean

End Interface
