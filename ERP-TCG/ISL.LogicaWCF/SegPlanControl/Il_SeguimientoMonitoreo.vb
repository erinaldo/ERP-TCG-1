Imports System.ServiceModel
Imports ERP.EntidadesWCF
' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_SeguimientoMonitoreo" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_SeguimientoMonitoreo

    Function Eliminar(oeSeguimientoMonitoreo As e_SeguimientoMonitoreo) As Boolean

    Function Guardar(oeSeguimientoMonitoreo As e_SeguimientoMonitoreo) As Boolean

    Function Validar(oeSeguimientoMonitoreo As e_SeguimientoMonitoreo) As Boolean

    Function Listar(oeSeguimientoMonitoreo As e_SeguimientoMonitoreo) As List(Of e_SeguimientoMonitoreo)

    Function Obtener(oeSeguimientoMonitoreo As e_SeguimientoMonitoreo) As e_SeguimientoMonitoreo

    <OperationContract()>
    Sub DoWork()

End Interface
