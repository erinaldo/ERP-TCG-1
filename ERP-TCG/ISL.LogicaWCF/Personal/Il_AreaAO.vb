Imports System.ServiceModel
Imports ERP.EntidadesWCF

<ServiceContract()> _
Public Interface Il_AreaAO

    <OperationContract()> _
    Function Obtener(ByVal oeAreaAO As e_AreaAO) As e_AreaAO

    <OperationContract()> _
    Function Listar(ByVal oeAreaAO As e_AreaAO) As List(Of e_AreaAO)

    <OperationContract()> _
    Function Validar(ByVal oeAreaAO As e_AreaAO) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeAreaAO As e_AreaAO) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeAreaAO As e_AreaAO) As Boolean

End Interface
