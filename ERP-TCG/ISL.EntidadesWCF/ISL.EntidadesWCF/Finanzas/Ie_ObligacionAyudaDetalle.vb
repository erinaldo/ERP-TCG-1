Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_FactoryFEED", también debe actualizar la referencia a "Ie_FactoryFEED" en Web.config.
<ServiceContract()> _
Public Interface Ie_ObligacionAyudaDetalle
    <OperationContract()> _
    Function Obtener(ByVal factoryFEED As e_ObligacionAyudaDetalle) As e_ObligacionAyudaDetalle

End Interface
