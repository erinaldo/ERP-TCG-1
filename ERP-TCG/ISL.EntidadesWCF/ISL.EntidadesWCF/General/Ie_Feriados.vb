Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_Feriados" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_Feriados

    <OperationContract()> _
    Function Obtener(ByVal feriados As e_Feriados) As e_Feriados

End Interface
