Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_CuadreCajaBolsa" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_CuadreCajaBolsa

    <OperationContract()> _
    Function Obtener(ByVal oeCuadreCajaBolsa As e_CuadreCajaBolsa) As e_CuadreCajaBolsa

    <OperationContract()> _
    Function Listar(ByVal oeCuadreCajaBolsa As e_CuadreCajaBolsa) As List(Of e_CuadreCajaBolsa)

    <OperationContract()> _
    Function Validar(ByVal oeCuadreCajaBolsa As e_CuadreCajaBolsa) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeCuadreCajaBolsa As e_CuadreCajaBolsa) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeCuadreCajaBolsa As e_CuadreCajaBolsa) As Boolean

End Interface
