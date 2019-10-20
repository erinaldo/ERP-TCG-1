Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_ConfiguracionTabla" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_ConfiguracionTabla

    <OperationContract()> _
    Function Obtener(ByVal oeConfiguracionTabla As e_ConfiguracionTabla) As e_ConfiguracionTabla

    <OperationContract()> _
    Function Listar(ByVal oeConfiguracionTabla As e_ConfiguracionTabla) As List(Of e_ConfiguracionTabla)

    <OperationContract()> _
    Function Validar(ByVal oeConfiguracionTabla As e_ConfiguracionTabla) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeConfiguracionTabla As e_ConfiguracionTabla) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeConfiguracionTabla As e_ConfiguracionTabla) As Boolean

End Interface
