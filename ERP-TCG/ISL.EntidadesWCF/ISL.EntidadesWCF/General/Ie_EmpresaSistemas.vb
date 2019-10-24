Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_EmpresaSistemas" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_EmpresaSistemas

    <OperationContract()>
    Sub DoWork()
    <OperationContract()>
    Function Obtener(ByVal empresaSistemas As e_EmpresaSistemas) As e_EmpresaSistemas

End Interface
