Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "IGeneral_Centro" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface IGeneral_Centro

    <OperationContract()>
    Function Obtener(ByVal oeCentro As e_Centro) As e_Centro

    <OperationContract()>
    Function Listar(ByVal oeCentro As e_Centro) As List(Of e_Centro)

    <OperationContract()>
    Function ObtenerSAlmacen(ByVal oeCentro As e_Centro) As e_Centro

    <OperationContract()>
    Function Guardar(ByVal oeCentro As e_Centro) As Boolean

    <OperationContract()>
    Function Eliminar(ByVal oeCentro As e_Centro) As Boolean

    <OperationContract()>
    Function Validar(ByVal oeCentro As e_Centro) As Boolean

    <OperationContract()>
    Function ValidarDuplicado(ByVal id As String, ByVal valor As String, ByVal campo As String) As Boolean

    <OperationContract()>
    Function ComboGrilla(ByVal ListaCentro As List(Of e_Centro))

End Interface
