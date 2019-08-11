Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_CtaCtbleSubFamiliaMat" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_CtaCtbleSubFamiliaMat

    <OperationContract()> _
    Function Obtener(ByVal ctactblesubfamilia As e_CtaCtbleSubFamiliaMat) As e_CtaCtbleSubFamiliaMat

End Interface
