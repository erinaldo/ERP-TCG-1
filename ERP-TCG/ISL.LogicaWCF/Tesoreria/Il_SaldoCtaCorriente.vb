Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_SaldoCtaCorriente", también debe actualizar la referencia a "Il_SaldoCtaCorriente" en Web.config.
<ServiceContract()> _
Public Interface Il_SaldoCtaCorriente

    <OperationContract()> _
    Function Obtener(ByVal oeSaldoCtaCorriente As e_SaldoCtaCorriente) As e_SaldoCtaCorriente

    <OperationContract()> _
    Function Listar(ByVal oeSaldoCtaCorriente As e_SaldoCtaCorriente) As List(Of e_SaldoCtaCorriente)

    <OperationContract()> _
    Function Validar(ByVal oeSaldoCtaCorriente As e_SaldoCtaCorriente) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeSaldoCtaCorriente As e_SaldoCtaCorriente) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeSaldoCtaCorriente As e_SaldoCtaCorriente) As Boolean

End Interface
