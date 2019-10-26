Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_TipoVia", también debe actualizar la referencia a "Il_TipoVia" en Web.config.
<ServiceContract()> _
Public Interface Il_TipoVia

    <OperationContract()> _
    Function Obtener(ByVal oeTipoVia As e_TipoVia) As e_TipoVia

    <OperationContract()> _
    Function Listar(ByVal oeTipoVia As e_TipoVia) As List(Of e_TipoVia)

    <OperationContract()> _
    Function Validar(ByVal oeTipoVia As e_TipoVia) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeTipoVia As e_TipoVia) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeTipoVia As e_TipoVia) As Boolean

End Interface
