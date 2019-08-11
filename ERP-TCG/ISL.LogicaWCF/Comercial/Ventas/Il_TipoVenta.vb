Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_TipoVenta", también debe actualizar la referencia a "Il_TipoVenta" en Web.config.
<ServiceContract()> _
Public Interface Il_TipoVenta

    <OperationContract()> _
    Function Obtener(ByVal oeTipoVenta As e_TipoVenta) As e_TipoVenta

    <OperationContract()> _
    Function Listar(ByVal oeTipoVenta As e_TipoVenta) As List(Of e_TipoVenta)

    <OperationContract()> _
    Function Validar(ByVal oeTipoVenta As e_TipoVenta) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeTipoVenta As e_TipoVenta) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeTipoVenta As e_TipoVenta) As Boolean

End Interface
