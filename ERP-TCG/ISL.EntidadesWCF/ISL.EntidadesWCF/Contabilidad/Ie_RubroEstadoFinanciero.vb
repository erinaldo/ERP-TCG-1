Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_RubroEstadoFinanciero" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_RubroEstadoFinanciero

    <OperationContract()>
    Function Obtener(ByVal rubroestadofinanciero As e_RubroEstadoFinanciero) As e_RubroEstadoFinanciero

End Interface
