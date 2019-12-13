Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_CierreTurno" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_CierreTurno

    <OperationContract()>
    Function Obtener(ByVal Item As e_CierreTurno) As e_CierreTurno

End Interface
