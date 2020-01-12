Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_GRR_Venta" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_GRR_Venta

    <OperationContract()>
    Function Eliminar(ByVal oeGuiaRemitente As e_GRR_Venta) As Boolean

    <OperationContract()>
    Function Guardar(ByVal oeGuiaRemitente As e_GRR_Venta) As Boolean

    <OperationContract()>
    Function Listar(ByVal oeGuiaRemitente As e_GRR_Venta) As System.Collections.Generic.List(Of e_GRR_Venta)

    <OperationContract()>
    Function Obtener(ByVal oeGuiaRemitente As e_GRR_Venta) As e_GRR_Venta

End Interface
