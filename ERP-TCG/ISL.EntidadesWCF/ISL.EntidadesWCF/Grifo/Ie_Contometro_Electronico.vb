Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_Contometro_Electronico" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_Contometro_Electronico

    <OperationContract()>
    Function Obtener(ByVal contometro_electronico As e_Contometro_Electronico) As e_Contometro_Electronico

End Interface
