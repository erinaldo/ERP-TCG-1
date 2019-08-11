Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_MontoRuta" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_MontoRuta

    <OperationContract()> _
    Function Obtener(ByVal montoruta As e_MontoRuta) As e_MontoRuta

End Interface
