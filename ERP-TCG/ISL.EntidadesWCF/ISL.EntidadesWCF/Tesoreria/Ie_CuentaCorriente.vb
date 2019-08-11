Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_CuentaCorriente", también debe actualizar la referencia a "Ie_CuentaCorriente" en Web.config.
<ServiceContract()> _
Public Interface Ie_CuentaCorriente

    <OperationContract()> _
    Function Obtener(ByVal cuentaCorriente As e_CuentaCorriente) As e_CuentaCorriente

End Interface
