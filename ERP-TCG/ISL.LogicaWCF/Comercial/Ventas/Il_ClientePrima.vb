Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_ClientePrima" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_ClientePrima

    <OperationContract()> _
    Function Obtener(ByVal oeClientePrima As e_ClientePrima) As e_ClientePrima

    <OperationContract()> _
    Function Listar(ByVal oeClientePrima As e_ClientePrima) As List(Of e_ClientePrima)

    <OperationContract()> _
    Function Guardar(ByVal oeClientePrima As e_ClientePrima) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeClientePrima As e_ClientePrima) As Boolean

    <OperationContract()> _
    Function Validar(ByVal oeClientePrima As e_ClientePrima) As Boolean

End Interface
