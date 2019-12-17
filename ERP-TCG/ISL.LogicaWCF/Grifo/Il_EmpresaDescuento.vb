Imports System.ServiceModel
Imports ERP.EntidadesWCF

<ServiceContract()>
Public Interface Il_EmpresaDescuento

    <OperationContract()>
    Function Obtener(ByVal oeEmpresaDescuento As e_EmpresaDescuento) As e_EmpresaDescuento

    <OperationContract()>
    Function Listar(ByVal oeEmpresaDescuento As e_EmpresaDescuento) As List(Of e_EmpresaDescuento)

    <OperationContract()>
    Function Guardar(ByVal oeEmpresaDescuento As e_EmpresaDescuento) As Boolean

    <OperationContract()>
    Function Eliminar(ByVal oeEmpresaDescuento As e_EmpresaDescuento) As Boolean

End Interface