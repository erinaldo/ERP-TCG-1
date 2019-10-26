Imports System.ServiceModel
Imports ERP.EntidadesWCF
' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_Detraccion" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_Detraccion

    <OperationContract()>
    Function Obtener(ByVal oeDetraccion As e_Detraccion) As e_Detraccion

    <OperationContract()>
    Function Listar(ByVal oeDetraccion As e_Detraccion) As List(Of e_Detraccion)

    <OperationContract()>
    Function Guardar(ByVal oeDetraccion As e_Detraccion) As Boolean

    <OperationContract()>
    Function Eliminar(ByVal oeDetraccion As e_Detraccion) As Boolean

    <OperationContract()>
    Function GuardarAsiento(oeDetraccion As e_Detraccion, loDetDetalle As List(Of e_DetraccionDetalle), loCtaCtble As List(Of e_Combo)) As Boolean

End Interface
