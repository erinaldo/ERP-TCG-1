Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
<ServiceContract()> _
Public Interface Il_FecLetras

    <OperationContract()> _
    Function CrearDT() As Data.DataTable

End Interface
