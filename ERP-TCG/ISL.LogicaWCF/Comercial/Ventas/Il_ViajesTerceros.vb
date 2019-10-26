Imports System.ServiceModel
Imports ERP.EntidadesWCF
' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_ViajesTerceros" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_ViajesTerceros

    
    '<OperationContract()>
    'Sub DoWork()
    <OperationContract()> _
    Function Obtener(ByVal oeViajesTerceros As e_ViajesTerceros) As e_ViajesTerceros

    <OperationContract()> _
    Function Listar(ByVal oeViajesTerceros As e_ViajesTerceros) As List(Of e_ViajesTerceros)

    <OperationContract()> _
    Function Validar(ByVal oeViajesTerceros As e_ViajesTerceros) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeViajesTerceros As e_ViajesTerceros) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeViajesTerceros As e_ViajesTerceros) As Boolean
End Interface
