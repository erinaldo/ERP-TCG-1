Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_BonificacionProduccion" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_BonificacionProduccion

    <OperationContract()>
    Function obtener(ByVal oeBonificacionProduccion As e_BonificacionProduccion) As e_BonificacionProduccion

End Interface
