Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_ConceptoPonderado" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_ConceptoPonderado

    <OperationContract()>
    Function Obtener(ByVal ConceptoPonderado As e_ConceptoPonderado) As e_ConceptoPonderado

End Interface
