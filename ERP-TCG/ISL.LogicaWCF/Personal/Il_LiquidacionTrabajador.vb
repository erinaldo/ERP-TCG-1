Imports ERP.EntidadesWCF
Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_LiquidacionTrabajador" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_LiquidacionTrabajador

    <OperationContract()> _
    Overloads Function Validar(ByVal oeLiquidacionTrabajador As e_LiquidacionTrabajador) As Boolean

    <OperationContract()> _
    Overloads Function Obtener(ByVal oeLiquidacionTrabajador As e_LiquidacionTrabajador) As e_LiquidacionTrabajador

    <OperationContract()> _
    Overloads Function Listar(ByVal oeLiquidacionTrabajador As e_LiquidacionTrabajador) As List(Of e_LiquidacionTrabajador)

    <OperationContract()> _
    Overloads Function Guardar(ByVal oeLiquidacionTrabajador As e_LiquidacionTrabajador, Optional oeMovCajaBanco As e_MovimientoCajaBanco = Nothing) As Boolean

    <OperationContract()> _
    Overloads Function Eliminar(ByVal oeLiquidacionTrabajador As e_LiquidacionTrabajador) As Boolean

End Interface
