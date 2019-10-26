Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_SeguroContraRiesgo" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_SeguroContraRiesgo

    <OperationContract()> _
    Function Obtener(ByVal oeSeguroContraRiesgo As e_SeguroContraRiesgo) As e_SeguroContraRiesgo

    <OperationContract()> _
    Function Listar(ByVal oeSeguroContraRiesgo As e_SeguroContraRiesgo) As List(Of e_SeguroContraRiesgo)

    <OperationContract()> _
    Function Validar(ByVal oeSeguroContraRiesgo As e_SeguroContraRiesgo) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeSeguroContraRiesgo As e_SeguroContraRiesgo) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeSeguroContraRiesgo As e_SeguroContraRiesgo) As Boolean

End Interface
