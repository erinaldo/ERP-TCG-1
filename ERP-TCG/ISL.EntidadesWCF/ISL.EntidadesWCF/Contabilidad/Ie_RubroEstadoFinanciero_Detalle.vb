Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_RubroEstadoFinanciero_Detalle" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_RubroEstadoFinanciero_Detalle

    <OperationContract()>
    Function Obtener(ByVal rubroestadofinanciero_detalle As e_RubroEstadoFinanciero_Detalle) As e_RubroEstadoFinanciero_Detalle

End Interface
