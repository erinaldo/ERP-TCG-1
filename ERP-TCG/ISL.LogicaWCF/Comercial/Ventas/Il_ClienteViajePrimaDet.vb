Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_ClienteViajePrimaDet" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_ClienteViajePrimaDet

    <OperationContract()> _
    Function Obtener(ByVal oeClienteViajePrimaDet As e_ClienteViajePrimaDet) As e_ClienteViajePrimaDet

    <OperationContract()> _
    Function Listar(ByVal oeClienteViajePrimaDet As e_ClienteViajePrimaDet) As List(Of e_ClienteViajePrimaDet)

    <OperationContract()> _
    Function Guardar(ByVal oeClienteViajePrimaDet As e_ClienteViajePrimaDet) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeClienteViajePrimaDet As e_ClienteViajePrimaDet) As Boolean

    <OperationContract()> _
    Function CrearDT() As Data.DataTable

End Interface
