Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_ImagenesDocumentosVehiculos" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_ImagenesDocumentos

    <OperationContract()> _
    Function Obtener(ByVal ImagenesDocumentosVehiculos As e_ImagenesDocumentos) As e_ImagenesDocumentos

End Interface
