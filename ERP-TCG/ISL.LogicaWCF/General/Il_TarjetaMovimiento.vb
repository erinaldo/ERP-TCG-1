Imports System.ServiceModel
Imports ERP.EntidadesWCF
' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_TarjetaMovimiento" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_TarjetaMovimiento

    <OperationContract()> _
    Function Guardar(oeTarjetaMovimiento As e_TarjetaMovimiento) As Boolean

    <OperationContract()>
    Function GuardarMasivo(ListaMovTarjeta As List(Of e_TarjetaMovimiento), ByVal PrefijoID As String) As Boolean

    <OperationContract()> _
    Function Obtener(oeTarjetaMovimiento As e_TarjetaMovimiento) As e_TarjetaMovimiento

    <OperationContract()> _
    Function Listar(oeTarjetaMovimiento As e_TarjetaMovimiento) As List(Of e_TarjetaMovimiento)

    <OperationContract()> _
    Function Eliminar(oeTarjetaMovimiento As e_TarjetaMovimiento) As Boolean

    <OperationContract()>
    Function ActualizarMasivo(XML As String, ByVal PrefijoID As String) As Boolean

End Interface
