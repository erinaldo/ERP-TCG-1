Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Empresa", también debe actualizar la referencia a "Il_Empresa" en Web.config.
<ServiceContract()> _
Public Interface Il_Empresa

    <OperationContract()> _
    Function ValidarId(ByVal Id As String) As Boolean

    <OperationContract()> _
    Function ValidarRuc(ByVal Ruc As String) As Boolean

    <OperationContract()> _
    Function ValidarNombre(ByVal Nombre As String) As Boolean

    <OperationContract()> _
    Function Obtener(ByVal oeEmpresa As e_Empresa) As e_Empresa

    <OperationContract()> _
    Function Listar(ByVal oeEmpresa As e_Empresa) As List(Of e_Empresa)

    <OperationContract()> _
    Function ComboGrilla(ByVal Empresa As List(Of e_Empresa))

    <OperationContract()> _
    Function Validar(ByVal oeEmpresa As e_Empresa) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeEmpresa As e_Empresa) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeEmpresa As e_Empresa) As Boolean

    <OperationContract()> _
    Function ValidarDuplicado(ByVal id As String, ByVal valor As String, ByVal campo As String) As Boolean

    <OperationContract()> _
    Function ValidarTipoPago(ByVal oeClieProv As e_ClienteProveedor, ByVal leTipPag As List(Of e_PersonaEmpresa_TipoPago)) As Boolean

    <OperationContract()> _
    Function ActualizaFec(ByVal oeEmpresa As e_Empresa) As Boolean

End Interface
