Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_CuadreCaja" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_CuadreCaja

    <OperationContract()> _
    Function Obtener(ByVal oeCuadreCaja As e_CuadreCaja) As e_CuadreCaja

    <OperationContract()> _
    Function Listar(ByVal oeCuadreCaja As e_CuadreCaja) As List(Of e_CuadreCaja)

    <OperationContract()> _
    Function Validar(ByVal oeCuadreCaja As e_CuadreCaja) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeCuadreCaja As e_CuadreCaja) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeCuadreCaja As e_CuadreCaja) As Boolean

End Interface
