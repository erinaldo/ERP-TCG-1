Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_ComprobanteElectronicoBath" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_ComprobanteElectronicoBath

    <OperationContract()> _
    Function Obtener(ByVal oeComprobanteElectronicoBath As e_ComprobanteElectronicoBath) As e_ComprobanteElectronicoBath

    <OperationContract()> _
    Function Listar(ByVal oeComprobanteElectronicoBath As e_ComprobanteElectronicoBath) As List(Of e_ComprobanteElectronicoBath)

    <OperationContract()> _
    Function Validar(ByVal oeComprobanteElectronicoBath As e_ComprobanteElectronicoBath) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeComprobanteElectronicoBath As e_ComprobanteElectronicoBath) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeComprobanteElectronicoBath As e_ComprobanteElectronicoBath) As Boolean

End Interface
