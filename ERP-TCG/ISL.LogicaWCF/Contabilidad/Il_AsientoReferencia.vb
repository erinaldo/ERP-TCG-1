Imports System.ServiceModel
Imports ISL.EntidadesWCF

<ServiceContract()>
Public Interface Il_AsientoReferencia

    <OperationContract()>
    Function Obtener(oeAsientoReferencia As e_AsientoReferencia) As e_AsientoReferencia

    <OperationContract()>
    Function Listar(oeAsientoReferencia As e_AsientoReferencia) As List(Of e_AsientoReferencia)

    <OperationContract()>
    Function Guardar(oeAsientoReferencia As e_AsientoReferencia) As Boolean

    <OperationContract()>
    Function Eliminar(oeAsientoReferencia As e_AsientoReferencia) As Boolean

    <OperationContract()>
    Function CrearDT() As System.Data.DataTable

End Interface
