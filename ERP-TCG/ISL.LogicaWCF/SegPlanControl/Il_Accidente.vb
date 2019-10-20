Imports System.ServiceModel
Imports ERP.EntidadesWCF

<ServiceContract()> _
Public Interface Il_Accidente

    <OperationContract()> _
    Function Obtener(ByVal oeAccidente As e_Accidente) As e_Accidente

    <OperationContract()> _
    Function Listar(ByVal oeAccidente As e_Accidente) As List(Of e_Accidente)

    <OperationContract()> _
    Function Validar(ByVal oeAccidente As e_Accidente) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeAccidente As e_Accidente) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeAccidente As e_Accidente) As Boolean

End Interface
