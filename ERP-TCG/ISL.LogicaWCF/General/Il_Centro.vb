Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Centro", también debe actualizar la referencia a "Il_Centro" en Web.config.
<ServiceContract()> _
Public Interface Il_Centro

    <OperationContract()> _
    Function Obtener(ByVal oeCentro As e_Centro) As e_Centro

    <OperationContract()> _
    Function Listar(ByVal oeCentro As e_Centro) As List(Of e_Centro)

    <OperationContract()> _
    Function ObtenerSAlmacen(ByVal oeCentro As e_Centro) As e_Centro

    <OperationContract()> _
    Function Guardar(ByVal oeCentro As e_Centro) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeCentro As e_Centro) As Boolean

    <OperationContract()> _
    Function Validar(ByVal oeCentro As e_Centro) As Boolean

    <OperationContract()> _
    Function ValidarDuplicado(ByVal id As String, ByVal valor As String, ByVal campo As String) As Boolean

    <OperationContract()> _
    Function ComboGrilla(ByVal ListaCentro As List(Of e_Centro))
End Interface
