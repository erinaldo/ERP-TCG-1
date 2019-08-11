Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_ClienteViajePrimaCon" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_ClienteViajePrimaCon

    <OperationContract()> _
    Function Obtener(ByVal oeClienteViajePrimaCon As e_ClienteViajePrimaCon) As e_ClienteViajePrimaCon

    <OperationContract()> _
    Function Listar(ByVal oeClienteViajePrimaCon As e_ClienteViajePrimaCon) As List(Of e_ClienteViajePrimaCon)

    <OperationContract()> _
    Function Guardar(ByVal oeClienteViajePrimaCon As e_ClienteViajePrimaCon) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeClienteViajePrimaCon As e_ClienteViajePrimaCon) As Boolean

    <OperationContract()> _
    Function Validar(ByVal oeClienteViajePrimaCon As e_ClienteViajePrimaCon) As Boolean

End Interface
