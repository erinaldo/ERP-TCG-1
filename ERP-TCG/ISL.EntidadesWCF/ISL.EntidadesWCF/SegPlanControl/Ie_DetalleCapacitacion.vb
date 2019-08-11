Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_DetalleCapacitacion" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_DetalleCapacitacion

    <OperationContract()>
    Function Obtener(ByVal detallecapacitacion As e_DetalleCapacitacion) As e_DetalleCapacitacion

End Interface
