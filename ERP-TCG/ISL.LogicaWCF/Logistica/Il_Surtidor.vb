Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_Surtidor" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_Surtidor

    <OperationContract()> _
    Function Obtener(ByVal oeSurtidor As e_Surtidor) As e_Surtidor

    <OperationContract()> _
    Function Listar(ByVal oeSurtidor As e_Surtidor) As List(Of e_Surtidor)

End Interface
