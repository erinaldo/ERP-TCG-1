Imports System.ServiceModel
Imports ISL.EntidadesWCF
' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_ProcesarTarifasProceso" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_ProcesarTarifasProceso

    '<OperationContract()>
    'Sub DoWork()
    <OperationContract()> _
    Function Obtener(ByVal oeProcesarTarifasProceso As e_ProcesarTarifasProceso) As e_ProcesarTarifasProceso

    <OperationContract()> _
    Function Listar(ByVal oeProcesarTarifasProceso As e_ProcesarTarifasProceso) As List(Of e_ProcesarTarifasProceso)

    <OperationContract()> _
    Function Validar(ByVal oeProcesarTarifasProceso As e_ProcesarTarifasProceso) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeProcesarTarifasProceso As e_ProcesarTarifasProceso) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeProcesarTarifasProceso As e_ProcesarTarifasProceso) As Boolean
End Interface
