Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_CtaCtbleCatServicio" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_CtaCtbleCatServicio

    <OperationContract()> _
    Function Obtener(ByVal oeCtaCtbleCatServicio As e_CtaCtbleCatServicio) As e_CtaCtbleCatServicio

    <OperationContract()> _
    Function Listar(ByVal oeCtaCtbleCatServicio As e_CtaCtbleCatServicio) As List(Of e_CtaCtbleCatServicio)

    <OperationContract()> _
    Function Validar(ByVal oeCtaCtbleCatServicio As e_CtaCtbleCatServicio) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeCtaCtbleCatServicio As e_CtaCtbleCatServicio) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeCtaCtbleCatServicio As e_CtaCtbleCatServicio) As Boolean

End Interface
