Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_CtaCtble_Concepto" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_CtaCtble_Concepto

    <OperationContract()> _
    Function Obtener(ByVal oeCtaCtble_Concepto As e_CtaCtble_Concepto) As e_CtaCtble_Concepto

    <OperationContract()> _
    Function Listar(ByVal oeCtaCtble_Concepto As e_CtaCtble_Concepto) As List(Of e_CtaCtble_Concepto)

End Interface
