Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "ICuadreCajaBolsa" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_CuadreCajaBolsa

    <OperationContract()> _
    Function Obtener(ByVal cuadrecaja As e_CuadreCajaBolsa) As e_CuadreCajaBolsa

End Interface
