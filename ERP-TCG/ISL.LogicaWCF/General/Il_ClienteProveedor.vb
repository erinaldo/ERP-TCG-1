Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_ClienteProveedor", también debe actualizar la referencia a "Il_ClienteProveedor" en Web.config.
<ServiceContract()> _
Public Interface Il_ClienteProveedor

    <OperationContract()> _
    Function Obtener(ByVal oeClienteProveedor As e_ClienteProveedor) As e_ClienteProveedor

    <OperationContract()> _
    Function Listar(ByVal oeClienteProveedor As e_ClienteProveedor) As List(Of e_ClienteProveedor)

    <OperationContract()> _
    Function Validar(ByVal oeClienteProveedor As e_ClienteProveedor) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeClienteProveedor As e_ClienteProveedor) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeClienteProveedor As e_ClienteProveedor) As Boolean

End Interface
