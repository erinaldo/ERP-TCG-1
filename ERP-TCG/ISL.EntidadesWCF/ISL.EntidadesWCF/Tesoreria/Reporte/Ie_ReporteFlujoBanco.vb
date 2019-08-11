Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_ReporteFlujoBanco" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_ReporteFlujoBanco

    <OperationContract()> _
    Function Obtener(ByVal ReporteFlujoBanco As e_ReporteFlujoBanco) As e_ReporteFlujoBanco

End Interface
