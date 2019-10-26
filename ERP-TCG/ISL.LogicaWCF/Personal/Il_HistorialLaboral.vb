Imports System.ServiceModel
Imports ERP.EntidadesWCF

<ServiceContract()> _
Public Interface Il_HistorialLaboral

    <OperationContract()> _
    Function Obtener(ByVal oeHistorialLaboral As e_HistorialLaboral) As e_HistorialLaboral

    <OperationContract()> _
    Function Listar(ByVal oeHistorialLaboral As e_HistorialLaboral) As List(Of e_HistorialLaboral)

    <OperationContract()> _
    Function Validar(ByVal oeHistorialLaboral As e_HistorialLaboral) As Boolean

    <OperationContract()> _
    Function ValidarDuplicado(ByVal oeHistorialLaboral As e_HistorialLaboral) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeHistorialLaboral As e_HistorialLaboral) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeHistorialLaboral As e_HistorialLaboral) As Boolean

End Interface
