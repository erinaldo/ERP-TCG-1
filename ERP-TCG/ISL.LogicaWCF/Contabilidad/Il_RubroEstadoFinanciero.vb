Imports System.ServiceModel
Imports ISL.EntidadesWCF

<ServiceContract()>
Public Interface Il_RubroEstadoFinanciero

    <OperationContract()>
    Function Obtener(ByVal oeRubroEstadoFinanciero As e_RubroEstadoFinanciero) As e_RubroEstadoFinanciero

    <OperationContract()>
    Function Listar(ByVal oeRubroEstadoFinanciero As e_RubroEstadoFinanciero) As List(Of e_RubroEstadoFinanciero)

    <OperationContract()>
    Function Guardar(ByVal oeRubroEstadoFinanciero As e_RubroEstadoFinanciero) As Boolean

    <OperationContract()>
    Function Eliminar(ByVal oeRubroEstadoFinanciero As e_RubroEstadoFinanciero) As Boolean

End Interface
