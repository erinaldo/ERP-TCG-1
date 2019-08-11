Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_EquivalenciaRuta" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_EquivalenciaRuta

    <OperationContract()> _
    Function Obtener(ByVal equivalenciaruta As e_EquivalenciaRuta) As e_EquivalenciaRuta

End Interface
