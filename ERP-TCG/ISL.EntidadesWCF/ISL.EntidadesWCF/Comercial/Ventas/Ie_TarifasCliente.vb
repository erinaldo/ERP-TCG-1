Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_TarifasCliente", también debe actualizar la referencia a "Ie_TarifasCliente" en Web.config.
<ServiceContract()> _
Public Interface Ie_TarifasCliente

    '<OperationContract()> _
    'Sub DoWork()

    <OperationContract()> _
    Function Obtener(ByVal TarifasCliente As e_TarifasCliente) As e_TarifasCliente
End Interface
