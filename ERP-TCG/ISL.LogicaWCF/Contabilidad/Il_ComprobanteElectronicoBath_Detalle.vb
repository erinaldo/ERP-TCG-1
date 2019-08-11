Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_ComprobanteElectronicoBath_Detalle" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_ComprobanteElectronicoBath_Detalle

    <OperationContract()> _
    Function Obtener(ByVal oeComprobanteElectronicoBath_Detalle As e_ComprobanteElectronicoBath_Detalle) As e_ComprobanteElectronicoBath_Detalle

    <OperationContract()> _
    Function Listar(ByVal oeComprobanteElectronicoBath_Detalle As e_ComprobanteElectronicoBath_Detalle) As List(Of e_ComprobanteElectronicoBath_Detalle)

    <OperationContract()> _
    Function Validar(ByVal oeComprobanteElectronicoBath_Detalle As e_ComprobanteElectronicoBath_Detalle) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeComprobanteElectronicoBath_Detalle As e_ComprobanteElectronicoBath_Detalle) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeComprobanteElectronicoBath_Detalle As e_ComprobanteElectronicoBath_Detalle) As Boolean

End Interface
