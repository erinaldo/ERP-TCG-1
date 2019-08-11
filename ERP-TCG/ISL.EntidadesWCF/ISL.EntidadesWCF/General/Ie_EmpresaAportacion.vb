Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_EmpresaAportacion" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_EmpresaAportacion

    <OperationContract()> _
    Function Obtener(ByVal empresa As e_EmpresaAportacion) As e_EmpresaAportacion

End Interface
