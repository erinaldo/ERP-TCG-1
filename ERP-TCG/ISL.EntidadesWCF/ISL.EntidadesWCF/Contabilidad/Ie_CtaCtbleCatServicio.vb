Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_CtaCtbleCatServicio" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_CtaCtbleCatServicio

    <OperationContract()> _
    Function Obtener(ByVal ctactblecatservicio As e_CtaCtbleCatServicio) As e_CtaCtbleCatServicio

End Interface
