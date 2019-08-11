Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_DetalleConceptoPonderado" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_DetalleConceptoPonderado

    <OperationContract()>
    Function Obtener(ByVal DetalleConceptoPonderado As e_DetalleConceptoPonderado) As e_DetalleConceptoPonderado

End Interface
