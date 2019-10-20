Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Equipo", también debe actualizar la referencia a "Il_Equipo" en Web.config.
<ServiceContract()> _
Public Interface Il_Equipo

    <OperationContract()> _
    Function ValidarDuplicado(ByVal ls_Id As String, ByVal ls_Nombre As String) As Boolean

    <OperationContract()> _
    Function Obtener(ByVal oeEquipo As e_Equipo) As e_Equipo

    <OperationContract()> _
    Function Listar(ByVal oeEquipo As e_Equipo) As List(Of e_Equipo)

    <OperationContract()> _
    Function Validar(ByVal oeEquipo As e_Equipo) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeEquipo As e_Equipo) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeEquipo As e_Equipo) As Boolean

End Interface
