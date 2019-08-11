Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_OtrosDescuentos" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_OtrosDescuentos

    <OperationContract()>
    Function obtener(ByVal oeOtrosDescuentos As e_OtrosDescuentos) As e_OtrosDescuentos

End Interface
