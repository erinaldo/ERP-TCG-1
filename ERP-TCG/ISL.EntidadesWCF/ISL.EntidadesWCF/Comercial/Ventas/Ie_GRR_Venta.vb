﻿Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_GRR_Venta" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_GRR_Venta

    <OperationContract()>
    Sub DoWork()

End Interface
