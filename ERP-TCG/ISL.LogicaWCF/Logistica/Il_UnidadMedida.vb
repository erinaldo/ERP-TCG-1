Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_UnidadMedida", también debe actualizar la referencia a "Il_UnidadMedida" en Web.config.
<ServiceContract()> _
Public Interface Il_UnidadMedida

    <OperationContract()> _
    Function Obtener(ByVal oeUnidadMedida As e_UnidadMedida) As e_UnidadMedida

    <OperationContract()> _
    Function Listar(ByVal oeUnidadMedida As e_UnidadMedida) As List(Of e_UnidadMedida)

    <OperationContract()> _
    Function ListarD(ByVal oeUnidadMedida As e_UnidadMedida) As DataSet

    <OperationContract()> _
    Function Guardar(ByVal oeUnidadMedida As e_UnidadMedida) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeUnidadMedida As e_UnidadMedida) As Boolean

    <OperationContract()> _
    Function Validar(ByVal oeUnidadMedida As e_UnidadMedida) As Boolean

    <OperationContract()> _
    Function ValidarDuplicado(ByVal id As String, ByVal valor As String, ByVal campo As String) As Boolean

    <OperationContract()> _
    Function ComboGrilla(ByVal oeUnidadMedida As e_UnidadMedida)

    <OperationContract()> _
    Function ValidarTipoUnidadMedida(ByVal id As String) As Boolean

End Interface
