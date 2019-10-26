Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_ControlPermisos", también debe actualizar la referencia a "Il_ControlPermisos" en Web.config.
<ServiceContract()> _
Public Interface Il_ControlPermisos

    <OperationContract()> _
    Overloads Function Validar(ByVal oeControlPermisos As e_ControlPermisos) As Boolean

    <OperationContract()> _
    Overloads Function Obtener(ByVal oeControlPermisos As e_ControlPermisos) As e_ControlPermisos

    <OperationContract()> _
    Overloads Function Listar(ByVal oeControlPermisos As e_ControlPermisos) As List(Of e_ControlPermisos)

    <OperationContract()> _
    Overloads Function Guardar(ByVal oeControlPermisos As e_ControlPermisos) As Boolean

    <OperationContract()>
    Overloads Function GuardarMasivo(ByVal loControlPermisos As List(Of e_ControlPermisos), ByVal PrefijoID As String) As Boolean

    <OperationContract()> _
    Overloads Function Eliminar(ByVal oeControlPermisos As e_ControlPermisos) As Boolean

End Interface

