Imports System.ServiceModel
Imports ERP.EntidadesWCF

<ServiceContract()> _
Public Interface Il_Area

    <OperationContract()> _
    Function Obtener(ByVal oeArea As e_Area) As e_Area

    <OperationContract()> _
    Function Listar(ByVal oeArea As e_Area) As List(Of e_Area)

    <OperationContract()> _
    Function Validar(ByVal oeArea As e_Area) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeArea As e_Area) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeArea As e_Area) As Boolean

End Interface
