Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_OrdenCmpCotizacion" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_OrdenCmpCotizacion

    <OperationContract()> _
    Function Obtener(ByVal oe As e_OrdenCmpCotizacion) As e_OrdenCmpCotizacion

End Interface
