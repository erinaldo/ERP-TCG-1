Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_EmpresaCuenta", también debe actualizar la referencia a "Il_EmpresaCuenta" en Web.config.
<ServiceContract()> _
Public Interface Il_EmpresaCuenta

    <OperationContract()> _
    Function Obtener(ByVal oeEmpresaCuenta As e_EmpresaCuenta) As e_EmpresaCuenta

    <OperationContract()> _
    Function Listar(ByVal oeEmpresaCuenta As e_EmpresaCuenta) As List(Of e_EmpresaCuenta)

    <OperationContract()> _
    Function Validar(ByVal oeEmpresaCuenta As e_EmpresaCuenta) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeEmpresaCuenta As e_EmpresaCuenta) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeEmpresaCuenta As e_EmpresaCuenta) As Boolean

End Interface
