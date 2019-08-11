Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_SeguimientoMonitoreo" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_SeguimientoMonitoreo

    Function Eliminar(oeSeguimientoMonitoreo As EntidadesWCF.e_SeguimientoMonitoreo) As Boolean

    Function Guardar(oeSeguimientoMonitoreo As EntidadesWCF.e_SeguimientoMonitoreo) As Boolean

    Function Validar(oeSeguimientoMonitoreo As EntidadesWCF.e_SeguimientoMonitoreo) As Boolean

    Function Listar(oeSeguimientoMonitoreo As EntidadesWCF.e_SeguimientoMonitoreo) As List(Of EntidadesWCF.e_SeguimientoMonitoreo)

    Function Obtener(oeSeguimientoMonitoreo As EntidadesWCF.e_SeguimientoMonitoreo) As EntidadesWCF.e_SeguimientoMonitoreo

    <OperationContract()>
    Sub DoWork()

End Interface
