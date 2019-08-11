Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_TipoHorario" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_TipoHorario

    <OperationContract()> _
    Function Obtener(ByVal tipohorario As e_TipoHorario) As e_TipoHorario

End Interface
