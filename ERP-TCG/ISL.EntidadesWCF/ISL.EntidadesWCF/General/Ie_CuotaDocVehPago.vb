Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_CuotaDocVehPago

    <OperationContract()> _
    Function Obtener(ByVal cuotadocvehpago As e_CuotaDocVehPago) As e_CuotaDocVehPago

End Interface
