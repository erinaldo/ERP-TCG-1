Imports System.ServiceModel
Imports ERP.EntidadesWCF
' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_VehiculoTarjeta" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_VehiculoTarjeta

    <OperationContract()> _
    Function Guardar(oeVehiculoTarjeta As e_VehiculoTarjeta) As Boolean

    <OperationContract()> _
    Function Obtener(oeVehiculoTarjeta As e_VehiculoTarjeta) As e_VehiculoTarjeta

    <OperationContract()> _
    Function Listar(oeVehiculoTarjeta As e_VehiculoTarjeta) As List(Of e_VehiculoTarjeta)

    <OperationContract()> _
    Function Eliminar(oeVehiculoTarjeta As e_VehiculoTarjeta) As Boolean

End Interface
