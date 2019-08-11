Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_SeguroComplementario" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_SeguroComplementario

    <OperationContract()>
    Function obtener(ByVal oeSeguroComplementario As e_SeguroComplementario) As e_SeguroComplementario

End Interface
