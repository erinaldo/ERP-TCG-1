Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_ZonaCombustible" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_ZonaCombustible

    <OperationContract()> _
    Function Obtener(ByVal oeZonaCombustible As e_ZonaCombustible) As e_ZonaCombustible

    <OperationContract()> _
    Function Listar(ByVal oeZonaCombustible As e_ZonaCombustible) As List(Of e_ZonaCombustible)

    <OperationContract()> _
    Function Validar(ByVal oeZonaCombustible As e_zonacombustible) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeZonaCombustible As e_ZonaCombustible) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeZonaCombustible As e_ZonaCombustible) As Boolean

End Interface
