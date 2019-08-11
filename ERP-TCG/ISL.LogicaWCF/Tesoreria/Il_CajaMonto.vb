Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_CajaMonto", también debe actualizar la referencia a "Il_CajaMonto" en Web.config.
<ServiceContract()> _
Public Interface Il_CajaMonto

    <OperationContract()> _
    Function Obtener(ByVal oeCajaMonto As e_CajaMonto) As e_CajaMonto

    <OperationContract()> _
    Function Listar(ByVal oeCajaMonto As e_CajaMonto) As List(Of e_CajaMonto)

    <OperationContract()> _
    Function Validar(ByVal oeCajaMonto As e_CajaMonto) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeCajaMonto As e_CajaMonto) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeCajaMonto As e_CajaMonto) As Boolean

End Interface
