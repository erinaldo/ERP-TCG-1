Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_CatalagoCodigoSunat" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_CatalagoCodigoSunat

    <OperationContract()> _
    Function Obtener(ByVal oeCatalagoCodigoSunat As e_CatalagoCodigoSunat) As e_CatalagoCodigoSunat

    <OperationContract()> _
    Function Listar(ByVal oeCatalagoCodigoSunat As e_CatalagoCodigoSunat) As List(Of e_CatalagoCodigoSunat)

    <OperationContract()> _
    Function Validar(ByVal oeCatalagoCodigoSunat As e_CatalagoCodigoSunat) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeCatalagoCodigoSunat As e_CatalagoCodigoSunat) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeCatalagoCodigoSunat As e_CatalagoCodigoSunat) As Boolean

End Interface
