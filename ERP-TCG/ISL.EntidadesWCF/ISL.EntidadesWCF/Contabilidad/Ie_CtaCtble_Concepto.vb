Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_CtaCtble_Concepto" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_CtaCtble_Concepto

    <OperationContract()> _
    Function Obtener(ByVal ctactble_concepto As e_CtaCtble_Concepto) As e_CtaCtble_Concepto

End Interface
