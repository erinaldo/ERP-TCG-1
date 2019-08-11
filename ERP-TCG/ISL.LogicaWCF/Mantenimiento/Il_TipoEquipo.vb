Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_TipoEquipo", también debe actualizar la referencia a "Il_TipoEquipo" en Web.config.
<ServiceContract()> _
Public Interface Il_TipoEquipo

    <OperationContract()> _
    Function Obtener(ByVal oeTipoEquipo As e_TipoEquipo) As e_TipoEquipo

    <OperationContract()> _
    Function Listar(ByVal oeTipoEquipo As e_TipoEquipo) As List(Of e_TipoEquipo)

    <OperationContract()> _
    Function Validar(ByVal oeTipoEquipo As e_TipoEquipo) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeTipoEquipo As e_TipoEquipo) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeTipoEquipo As e_TipoEquipo) As Boolean

End Interface
