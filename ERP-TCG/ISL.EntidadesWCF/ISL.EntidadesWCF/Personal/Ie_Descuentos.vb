Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_Descuentos" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_Descuentos

    <OperationContract()>
    Function obtener(ByVal oeDescuentos As e_Descuentos) As e_Descuentos

End Interface
