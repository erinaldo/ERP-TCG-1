Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_DerechoHabiente" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_DerechoHabiente

    <OperationContract()>
    Function obtener(ByVal oeDerechoHabiente As e_DerechoHabiente) As e_DerechoHabiente

End Interface
