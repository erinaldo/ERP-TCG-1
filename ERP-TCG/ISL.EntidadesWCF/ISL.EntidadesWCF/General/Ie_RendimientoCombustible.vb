Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_RendimientoCombustible" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_RendimientoCombustible

    <OperationContract()> _
    Function Obtener(ByVal rendimientocombustible As e_RendimientoCombustible) As e_RendimientoCombustible

End Interface
