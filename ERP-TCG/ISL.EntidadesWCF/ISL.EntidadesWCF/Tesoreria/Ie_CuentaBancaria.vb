Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_CuentaBancaria", también debe actualizar la referencia a "Ie_CuentaBancaria" en Web.config.
<ServiceContract()> _
Public Interface Ie_CuentaBancaria

    <OperationContract()> _
    Function Obtener(ByVal cuentaBancaria As e_CuentaBancaria) As e_CuentaBancaria

End Interface
