Imports System.ServiceModel
Imports ISL.EntidadesWCF

<ServiceContract()> _
Public Interface Il_ReporteConfiguracion

    <OperationContract()> _
    Function Obtener(ByVal oeReporteConfiguracion As e_ReporteConfiguracion) As e_ReporteConfiguracion

    <OperationContract()> _
    Function Listar(ByVal oeReporteConfiguracion As e_ReporteConfiguracion) As List(Of e_ReporteConfiguracion)

    <OperationContract()> _
    Function Guardar(ByVal oeReporteConfiguracion As e_ReporteConfiguracion) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeReporteConfiguracion As e_ReporteConfiguracion) As Boolean

    <OperationContract()> _
    Function Validar(ByVal oeReporteConfiguracion As e_ReporteConfiguracion) As Boolean

End Interface
