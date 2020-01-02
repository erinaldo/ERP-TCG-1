Imports System.ServiceModel
Imports ERP.EntidadesWCF

<ServiceContract()>
Public Interface Il_Lado

    <OperationContract()>
    Function Obtener(ByVal oeLado As e_Lado) As e_Lado


    <OperationContract()>
    Function Listar(ByVal oeLado As e_Lado) As List(Of e_Lado)


    <OperationContract()>
    Function Guardar(ByVal oeLado As e_Lado) As e_Lado


    <OperationContract()>
    Function Eliminar(ByVal oeLado As e_Lado) As Boolean


End Interface