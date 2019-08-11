Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_DetalleValorizacionNeumatico", también debe actualizar la referencia a "Ie_DetalleValorizacionNeumatico" en Web.config.
<ServiceContract()> _
Public Interface Ie_DetalleValorizacionNeumatico

    <OperationContract()> _
    Function Obtener(ByVal detalleValorizacionNeumatico As e_DetalleValorizacionNeumatico) As e_DetalleValorizacionNeumatico

End Interface
