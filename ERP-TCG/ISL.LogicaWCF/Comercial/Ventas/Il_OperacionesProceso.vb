Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_OperacionesProceso" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_OperacionesProceso

    <OperationContract()> _
    Function Obtener(ByVal oeOperacionesProceso As e_OperacionesProceso) As e_OperacionesProceso

    <OperationContract()> _
    Function Listar(ByVal oeOperacionesProceso As e_OperacionesProceso) As List(Of e_OperacionesProceso)

    <OperationContract()> _
    Function Validar(ByVal oeOperacionesProceso As e_OperacionesProceso) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeOperacionesProceso As e_OperacionesProceso) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeOperacionesProceso As e_OperacionesProceso) As Boolean

    'OperacionProcesoDetalle
    <OperationContract()> _
    Function ObtenerDetalle(ByVal oeOperacionesProcesoDetalle As e_OperacionesProcesoDetalle) As e_OperacionesProcesoDetalle

    <OperationContract()> _
    Function ListarDetalle(ByVal oeOperacionesProcesoDetalle As e_OperacionesProcesoDetalle) As List(Of e_OperacionesProcesoDetalle)

    <OperationContract()> _
    Function ValidarDetalle(ByVal oeOperacionesProcesoDetalle As e_OperacionesProcesoDetalle) As Boolean

    <OperationContract()> _
    Function GuardarDetalle(ByVal oeOperacionesProcesoDetalle As e_OperacionesProcesoDetalle) As Boolean

    <OperationContract()> _
    Function EliminarDetalle(ByVal oeOperacionesProcesoDetalle As e_OperacionesProcesoDetalle) As Boolean


End Interface
