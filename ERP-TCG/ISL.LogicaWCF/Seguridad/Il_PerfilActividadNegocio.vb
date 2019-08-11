Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_PerfilActividadNegocio", también debe actualizar la referencia a "Il_PerfilActividadNegocio" en Web.config.
<ServiceContract()> _
Public Interface Il_PerfilActividadNegocio

    <OperationContract()> _
    Function Obtener(ByVal oePerfilActividadNegocio As e_PerfilActividadNegocio) As e_PerfilActividadNegocio

    <OperationContract()> _
    Function Listar(ByVal oePerfilActividadNegocio As e_PerfilActividadNegocio) As List(Of e_PerfilActividadNegocio)

    <OperationContract()> _
    Function ListarTodos(ByVal oePerfilActividadNegocio As e_PerfilActividadNegocio) As List(Of e_PerfilActividadNegocio)

    <OperationContract()> _
    Function Validar(ByVal oePerfilActividadNegocio As e_PerfilActividadNegocio) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oePerfilActividadNegocio As e_PerfilActividadNegocio) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oePerfilActividadNegocio As e_PerfilActividadNegocio) As Boolean

End Interface
