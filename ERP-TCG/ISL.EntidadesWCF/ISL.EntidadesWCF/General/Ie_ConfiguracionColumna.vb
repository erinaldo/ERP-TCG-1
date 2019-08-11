Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_ConfiguracionColumna" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_ConfiguracionColumna

    <OperationContract()>
    Function Obtener(ByVal configuracioncolumna As e_ConfiguracionColumna) As e_ConfiguracionColumna

End Interface
