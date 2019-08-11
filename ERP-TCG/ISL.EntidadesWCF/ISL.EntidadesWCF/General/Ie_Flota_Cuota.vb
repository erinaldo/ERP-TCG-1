Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_Flota_Cuota" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_Flota_Cuota

    <OperationContract()>
    Function Obtener(ByVal flota_cuota As e_Flota_Cuota) As e_Flota_Cuota

End Interface
