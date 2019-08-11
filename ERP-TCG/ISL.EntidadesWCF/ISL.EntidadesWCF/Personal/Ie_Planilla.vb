Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_Planilla" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_Planilla

    <OperationContract()>
    Function obtener(ByVal oePlanilla As e_Planilla) As e_Planilla

End Interface
