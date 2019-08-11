Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_DetalleGratificacion" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_DetalleGratificacion

    <OperationContract()>
    Function obtener(ByVal oeDetalleGratificacion As e_DetalleGratificacion) As e_DetalleGratificacion

End Interface
