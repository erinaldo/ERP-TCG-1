Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_UsuarioSucursal" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_UsuarioSucursal

    <OperationContract()>
    Function Obtener(ByVal usuarioSucursal As e_UsuarioSucursal) As e_UsuarioSucursal

End Interface
