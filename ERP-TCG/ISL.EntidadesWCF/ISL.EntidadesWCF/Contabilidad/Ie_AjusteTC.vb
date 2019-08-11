Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_AjusteTC" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_AjusteTC

    <OperationContract()>
    Function Obtener(ByVal ajustetc As e_AjusteTC) As e_AjusteTC

End Interface
