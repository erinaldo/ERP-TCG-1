Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_ConfiguracionTabla" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_ConfiguracionTabla

    <OperationContract()>
    Function Obtener(ByVal configuraciontabla As e_ConfiguracionTabla) As e_ConfiguracionTabla

End Interface
