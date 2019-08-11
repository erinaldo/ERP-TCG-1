Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_TipoZona", también debe actualizar la referencia a "Il_TipoZona" en Web.config.
<ServiceContract()> _
Public Interface Il_TipoZona

    <OperationContract()> _
    Function Obtener(ByVal oeTipoZona As e_TipoZona) As e_TipoZona

    <OperationContract()> _
    Function Listar(ByVal oeTipoZona As e_TipoZona) As List(Of e_TipoZona)

    <OperationContract()> _
    Function Validar(ByVal oeTipoZona As e_TipoZona) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeTipoZona As e_TipoZona) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeTipoZona As e_TipoZona) As Boolean

End Interface
