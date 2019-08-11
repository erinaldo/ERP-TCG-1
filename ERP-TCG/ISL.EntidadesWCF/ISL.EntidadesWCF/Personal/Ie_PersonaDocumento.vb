Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_PersonaDocumento" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_PersonaDocumento

    <OperationContract()>
    Function obtener(ByVal oePersonaDocumento As e_PersonaDocumento) As e_PersonaDocumento

End Interface
