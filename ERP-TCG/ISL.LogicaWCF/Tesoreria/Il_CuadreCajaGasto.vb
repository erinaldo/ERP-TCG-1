Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_CuadreCajaGasto" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_CuadreCajaGasto

    <OperationContract()> _
    Function Obtener(ByVal oeCuadreCajaGasto As e_CuadreCajaGasto) As e_CuadreCajaGasto

    <OperationContract()> _
    Function Listar(ByVal oeCuadreCajaGasto As e_CuadreCajaGasto) As List(Of e_CuadreCajaGasto)

    <OperationContract()> _
    Function Validar(ByVal oeCuadreCajaGasto As e_CuadreCajaGasto) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeCuadreCajaGasto As e_CuadreCajaGasto) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeCuadreCajaGasto As e_CuadreCajaGasto) As Boolean

End Interface
