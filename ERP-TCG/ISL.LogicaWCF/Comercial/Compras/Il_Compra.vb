Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Compra", también debe actualizar la referencia a "Il_Compra" en Web.config.
<ServiceContract()> _
Public Interface Il_Compra

    <OperationContract()> _
    Function Obtener(ByVal oeCompra As e_Compra) As e_Compra

    <OperationContract()> _
    Function Listar(ByVal oeCompra As e_Compra) As List(Of e_Compra)

    <OperationContract()> _
    Function Validar(ByVal oeCompra As e_Compra) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeCompra As e_Compra) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeCompra As e_Compra) As Boolean

    <OperationContract()> _
    Function CrearDT() As Data.DataTable

End Interface
