Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_TipoOpeCon" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_TipoOpeCon

    <OperationContract()> _
    Function Obtener(ByVal tipoopecon As e_TipoOpeCon) As e_TipoOpeCon

End Interface
