Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_RubroEEFFDetalle_CuentaContable" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_RubroEEFFDetalle_CuentaContable

    <OperationContract()>
    Function Obtener(ByVal rubroeeffdetalle_cuentacontable As e_RubroEEFFDetalle_CuentaContable) As e_RubroEEFFDetalle_CuentaContable

End Interface
