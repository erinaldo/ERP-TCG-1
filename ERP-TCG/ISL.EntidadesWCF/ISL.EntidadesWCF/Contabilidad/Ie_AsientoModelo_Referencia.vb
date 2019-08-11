Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_AsientoModelo_Referencia" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_AsientoModelo_Referencia

    <OperationContract()>
    Function Obtener(ByVal asientomodeloreferencia As e_AsientoModelo_Referencia) As e_AsientoModelo_Referencia

End Interface
