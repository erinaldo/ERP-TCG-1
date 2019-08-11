Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_SeguroContraRiesgo" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_SeguroContraRiesgo

    <OperationContract()>
    Function Obtener(ByVal oeSeguroContraRiesgo As e_SeguroContraRiesgo) As e_SeguroContraRiesgo

End Interface
