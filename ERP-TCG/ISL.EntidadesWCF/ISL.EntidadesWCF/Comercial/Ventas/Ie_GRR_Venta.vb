Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_GRR_Venta" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_GRR_Venta

    <OperationContract()>
    Sub DoWork()
    Function Obtener(guiaRemitente As e_GRR_Venta) As e_GRR_Venta
End Interface
