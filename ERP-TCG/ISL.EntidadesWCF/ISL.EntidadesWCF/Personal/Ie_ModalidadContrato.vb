Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_ModalidadContrato" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_ModalidadContrato

    <OperationContract()> _
    Function Obtener(ByVal modalidadpersonal As e_ModalidadContrato) As e_ModalidadContrato

End Interface
