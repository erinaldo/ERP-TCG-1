Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_ChequesControl", también debe actualizar la referencia a "Il_ChequesControl" en Web.config.
<ServiceContract()> _
Public Interface Il_ChequesControl

    <OperationContract()> _
    Function Obtener(ByVal oeChequesControl As e_ChequesControl) As e_ChequesControl

    <OperationContract()> _
    Function Listar(ByVal oeChequesControl As e_ChequesControl) As List(Of e_ChequesControl)

    <OperationContract()> _
    Function Validar(ByVal oeChequesControl As e_ChequesControl) As Boolean

    <OperationContract()> _
    Function ValidarCuentaBancaria(ByVal IdCuentaBancaria As String) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeChequesControl As e_ChequesControl) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeChequesControl As e_ChequesControl) As Boolean

End Interface
