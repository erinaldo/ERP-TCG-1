Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_DetalleAsientoModelo" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_DetalleAsientoModelo

    <OperationContract()>
    Function Obtener(ByVal detalleasientomodelo As e_DetalleAsientoModelo) As e_DetalleAsientoModelo

End Interface
