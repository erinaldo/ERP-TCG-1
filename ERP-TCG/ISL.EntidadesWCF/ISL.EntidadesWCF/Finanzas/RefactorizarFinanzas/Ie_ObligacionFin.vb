Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_ObligacionFin" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_ObligacionFin

    <OperationContract()>
    Function Obtener(ByVal factoryFEED As e_ObligacionAyudaDetalle) As e_ObligacionAyudaDetalle

End Interface
