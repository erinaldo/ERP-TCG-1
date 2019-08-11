Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_KmMackDet" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_KmMackDet

    <OperationContract()> _
    Function Obtener(ByVal kmmack As e_KmMackDet) As e_KmMackDet

End Interface
