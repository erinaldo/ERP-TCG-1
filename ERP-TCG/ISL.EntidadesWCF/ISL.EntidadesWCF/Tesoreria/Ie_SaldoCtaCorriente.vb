Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_SaldoCtaCorriente", también debe actualizar la referencia a "Ie_SaldoCtaCorriente" en Web.config.
<ServiceContract()> _
Public Interface Ie_SaldoCtaCorriente

    <OperationContract()> _
     Function Obtener(ByVal saldoctacorriente As e_SaldoCtaCorriente) As e_SaldoCtaCorriente

End Interface
