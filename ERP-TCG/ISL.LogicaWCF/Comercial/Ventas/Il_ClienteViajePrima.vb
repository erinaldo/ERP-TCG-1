Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_ClienteViajePrima" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_ClienteViajePrima

    <OperationContract()> _
    Function Obtener(ByVal oeClienteViajePrima As e_ClienteViajePrima) As e_ClienteViajePrima

    <OperationContract()> _
    Function Listar(ByVal oeClienteViajePrima As e_ClienteViajePrima) As List(Of e_ClienteViajePrima)

    <OperationContract()> _
    Function Guardar(ByVal oeClienteViajePrima As e_ClienteViajePrima) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeClienteViajePrima As e_ClienteViajePrima) As Boolean

    <OperationContract()> _
    Function Validar(ByVal oeClienteViajePrima As e_ClienteViajePrima) As Boolean

End Interface
