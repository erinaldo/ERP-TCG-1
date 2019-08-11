Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_DetalleOrdenNeumatico", también debe actualizar la referencia a "Ie_DetalleOrdenNeumatico" en Web.config.
<ServiceContract()> _
Public Interface Ie_DetalleOrdenNeumatico

    <OperationContract()> _
     Function Obtener(ByVal detalleordenneumatico As e_DetalleOrdenNeumatico) As e_DetalleOrdenNeumatico

End Interface
