Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_CuadreCajaGasto" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_CuadreCajaGasto

    <OperationContract()> _
    Function Obtener(ByVal cuadrecaja As e_CuadreCajaGasto) As e_CuadreCajaGasto

End Interface
