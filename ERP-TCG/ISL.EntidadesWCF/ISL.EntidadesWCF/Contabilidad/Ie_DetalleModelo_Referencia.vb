Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_DetalleModelo_Referencia" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_DetalleModelo_Referencia

    <OperationContract()>
    Function Obtener(ByVal detallemodeloreferencia As e_DetalleModelo_Referencia) As e_DetalleModelo_Referencia

End Interface
