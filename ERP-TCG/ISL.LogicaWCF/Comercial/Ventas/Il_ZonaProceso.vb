Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_ZonaProceso" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_ZonaProceso

    '<OperationContract()>
    'Sub DoWork()
    <OperationContract()> _
    Function Obtener(oeZonaProceso As e_ZonaProceso) As e_ZonaProceso

    <OperationContract()> _
    Function Listar(oeZonaProceso As e_ZonaProceso) As List(Of e_ZonaProceso)

    <OperationContract()> _
    Function Guardar(oeZonaProceso As e_ZonaProceso) As Boolean

    <OperationContract()> _
    Function Eliminar(oeZonaProceso As e_ZonaProceso) As Boolean
End Interface
