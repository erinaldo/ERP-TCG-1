Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_ComprobanteElectronico" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_ComprobanteElectronico

    <OperationContract()> _
    Function Obtener(ByVal oeComprobanteElectronico As e_ComprobanteElectronico) As e_ComprobanteElectronico

    <OperationContract()> _
    Function Listar(ByVal oeComprobanteElectronico As e_ComprobanteElectronico) As List(Of e_ComprobanteElectronico)

    <OperationContract()> _
    Function Validar(ByVal oeComprobanteElectronico As e_ComprobanteElectronico) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeComprobanteElectronico As e_ComprobanteElectronico) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeComprobanteElectronico As e_ComprobanteElectronico) As Boolean

End Interface
