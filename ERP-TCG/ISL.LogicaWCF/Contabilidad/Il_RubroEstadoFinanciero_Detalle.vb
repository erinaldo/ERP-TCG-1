Imports System.ServiceModel
Imports ERP.EntidadesWCF

<ServiceContract()>
Public Interface Il_RubroEstadoFinanciero_Detalle

    <OperationContract()>
    Function Obtener(ByVal oeRubroEstadoFinanciero_Detalle As e_RubroEstadoFinanciero_Detalle) As e_RubroEstadoFinanciero_Detalle

    <OperationContract()>
    Function Listar(ByVal oeRubroEstadoFinanciero_Detalle As e_RubroEstadoFinanciero_Detalle) As List(Of e_RubroEstadoFinanciero_Detalle)

    <OperationContract()>
    Function Guardar(ByVal oeRubroEstadoFinanciero_Detalle As e_RubroEstadoFinanciero_Detalle) As Boolean

    <OperationContract()>
    Function Eliminar(ByVal oeRubroEstadoFinanciero_Detalle As e_RubroEstadoFinanciero_Detalle) As Boolean

End Interface
