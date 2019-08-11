Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_EmpresaCuenta", también debe actualizar la referencia a "Ie_EmpresaCuenta" en Web.config.
<ServiceContract()> _
Public Interface Ie_EmpresaCuenta

    <OperationContract()> _
    Function Obtener(ByVal empresaCuenta As e_EmpresaCuenta) As e_EmpresaCuenta

End Interface
