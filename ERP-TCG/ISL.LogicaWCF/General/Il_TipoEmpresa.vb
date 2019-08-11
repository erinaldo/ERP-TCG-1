Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_TipoEmpresa", también debe actualizar la referencia a "Il_TipoEmpresa" en Web.config.
<ServiceContract()> _
Public Interface Il_TipoEmpresa

    <OperationContract()> _
    Function Obtener(ByVal oeTipoEmpresa As e_TipoEmpresa) As e_TipoEmpresa

    <OperationContract()> _
    Function Listar(ByVal oeTipoEmpresa As e_TipoEmpresa) As List(Of e_TipoEmpresa)

    <OperationContract()> _
    Function Validar(ByVal oeTipoEmpresa As e_TipoEmpresa) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeTipoEmpresa As e_TipoEmpresa) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeTipoEmpresa As e_TipoEmpresa) As Boolean

End Interface
