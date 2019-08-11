Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_ConfiguracionDato" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_ConfiguracionDato

    <OperationContract()>
    Function Obtener(ByVal configuraciondato As e_ConfiguracionDato) As e_ConfiguracionDato

End Interface
