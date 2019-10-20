Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_OrdenCmp_OrdenTrb" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_OrdenCmp_OrdenTrb

    <OperationContract()> _
    Function Obtener(ByVal oeOrdenCmp_OrdenTrb As e_OrdenCmp_OrdenTrb) As e_OrdenCmp_OrdenTrb

    <OperationContract()> _
    Function Guardar(ByVal oeOrdenCmp_OrdenTrb As e_OrdenCmp_OrdenTrb) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeOrdenCmp_OrdenTrb As e_OrdenCmp_OrdenTrb) As Boolean


End Interface
