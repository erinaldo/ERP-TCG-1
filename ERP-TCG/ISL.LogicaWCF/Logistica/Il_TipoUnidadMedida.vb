Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_TipoUnidadMedida", también debe actualizar la referencia a "Il_TipoUnidadMedida" en Web.config.
<ServiceContract()> _
Public Interface Il_TipoUnidadMedida

    <OperationContract()> _
    Function Obtener(ByVal oeTipoUnidadMedida As e_TipoUnidadMedida) As e_TipoUnidadMedida

    <OperationContract()> _
    Function Listar(ByVal oeTipoUnidadMedida As e_TipoUnidadMedida) As List(Of e_TipoUnidadMedida)

    <OperationContract()> _
    Function Guardar(ByVal oeTipoUnidadMedida As e_TipoUnidadMedida) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeTipoUnidadMedida As e_TipoUnidadMedida) As Boolean

    <OperationContract()> _
    Function Validar(ByVal oeTipoUnidadMedida As e_TipoUnidadMedida) As Boolean

    <OperationContract()> _
    Function ValidarDuplicado(ByVal id As String, ByVal valor As String, ByVal campo As String) As Boolean

End Interface
