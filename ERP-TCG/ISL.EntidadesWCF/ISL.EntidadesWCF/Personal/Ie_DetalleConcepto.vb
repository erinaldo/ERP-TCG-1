Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_DetalleConcepto" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_DetalleConcepto

    <OperationContract()>
    Function obtener(ByVal oeDetalleConcepto As e_DetalleConcepto) As e_DetalleConcepto

End Interface
