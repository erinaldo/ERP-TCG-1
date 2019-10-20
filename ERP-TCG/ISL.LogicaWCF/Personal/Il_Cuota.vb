Imports System.ServiceModel
Imports ERP.EntidadesWCF

<ServiceContract()> _
Public Interface Il_Cuota

    <OperationContract()> _
    Function ValidarCodigo(ByVal Codigo As String) As Boolean

    <OperationContract()> _
    Function Validar(ByVal oeCuota As e_Cuota) As Boolean

    <OperationContract()> _
    Function ValidarRutaImagen(ByVal RutaImagen As String) As Boolean

    <OperationContract()> _
    Overloads Function Obtener(ByVal oeCuota As e_Cuota) As e_Cuota

    <OperationContract()> _
    Overloads Function Listar(ByVal oeCuota As e_Cuota) As List(Of e_Cuota)

    <OperationContract()> _
    Overloads Function Guardar(ByVal oeCuota As e_Cuota) As Boolean

    <OperationContract()> _
    Overloads Function Eliminar(ByVal oeCuota As e_Cuota) As Boolean

End Interface
