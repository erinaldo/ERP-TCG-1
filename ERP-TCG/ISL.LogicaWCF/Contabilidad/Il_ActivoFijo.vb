Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_ActivoFijo" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_ActivoFijo

#Region "ActivoFijo"

    <OperationContract()> _
    Function Obtener(oeActivoFijo As e_ActivoFijo, lbAFCuentaContable As Boolean, lbReadecuaciones As Boolean) As e_ActivoFijo

    <OperationContract()> _
    Function Listar(oeActivoFijo As e_ActivoFijo) As List(Of e_ActivoFijo)

    <OperationContract()> _
    Function ListarDS(oeActivoFijo As e_ActivoFijo) As DataSet

    <OperationContract()> _
    Function Guardar(oeActivoFijo As e_ActivoFijo) As Boolean

    <OperationContract()> _
    Function Eliminar(oeActivoFijo As e_ActivoFijo) As Boolean

#End Region

#Region "ActivoFijo_CuentaContable"

    <OperationContract()> _
    Function ObtenerAF_CuentaContable(oeActivoFijo_CuentaContable As e_ActivoFijo_CuentaContable) As e_ActivoFijo_CuentaContable

    <OperationContract()> _
    Function ListarAF_CuentaContable(oeActivoFijo_CuentaContable As e_ActivoFijo_CuentaContable) As List(Of e_ActivoFijo_CuentaContable)

    <OperationContract()> _
    Function GuardarAF_CuentaContable(oeActivoFijo_CuentaContable As e_ActivoFijo_CuentaContable) As Boolean

    <OperationContract()> _
    Function EliminarAF_CuentaContable(oeActivoFijo_CuentaContable As e_ActivoFijo_CuentaContable) As Boolean

#End Region

#Region "MovimientoActivoFijo"

    <OperationContract()> _
    Function ObtenerMovimientoAF(oeMovimientoActivoFijo As e_MovimientoActivoFijo) As e_MovimientoActivoFijo

    <OperationContract()> _
    Function ListarMovimientoAF(oeMovimientoActivoFijo As e_MovimientoActivoFijo) As List(Of e_MovimientoActivoFijo)

    <OperationContract()> _
    Function GuardarMovimientoAF(oeMovimientoActivoFijo As e_MovimientoActivoFijo) As Boolean

    <OperationContract()> _
    Function EliminarMovimientoAF(oeMovimientoActivoFijo As e_MovimientoActivoFijo) As Boolean

#End Region

#Region "ReadecuacionActivoFijo"

    <OperationContract()> _
    Function ObtenerReadecuacionAF(oeReadecuacionActivoFijo As e_ReadecuacionActivoFijo) As e_ReadecuacionActivoFijo

    <OperationContract()> _
    Function ListarReadecuacionAF(oeReadecuacionActivoFijo As e_ReadecuacionActivoFijo) As List(Of e_ReadecuacionActivoFijo)

    <OperationContract()> _
    Function GuardarReadecuacionAF(oeReadecuacionActivoFijo As e_ReadecuacionActivoFijo) As Boolean

    <OperationContract()> _
    Function EliminarReadecuacionAF(oeReadecuacionActivoFijo As e_ReadecuacionActivoFijo) As Boolean

#End Region

#Region "DepreciacionActivoFijo"

    <OperationContract()> _
    Function ObtenerDepreciacionAF(oeDepreciacionActivoFijo As e_DepreciacionActivoFijo) As e_DepreciacionActivoFijo

    <OperationContract()> _
    Function ListarDepreciacionAF(oeDepreciacionActivoFijo As e_DepreciacionActivoFijo) As List(Of e_DepreciacionActivoFijo)

    <OperationContract()> _
    Function GuardarDepreciacionAF(oeDepreciacionActivoFijo As e_DepreciacionActivoFijo) As Boolean

    <OperationContract()>
    Function GuardarDepreciacionPeriodo(lstDepreciacion As List(Of e_DepreciacionActivoFijo), ByVal PrefijoId As String) As Boolean

    <OperationContract()> _
    Function EliminarDepreciacionAF(oeDepreciacionActivoFijo As e_DepreciacionActivoFijo) As Boolean

    <OperationContract()> _
    Function ExtornarAsientoDepreciacion(oeAsiento As e_Asiento) As Boolean

    <OperationContract()> _
    Function CrearDTDepreciacion() As DataTable

#End Region

End Interface
