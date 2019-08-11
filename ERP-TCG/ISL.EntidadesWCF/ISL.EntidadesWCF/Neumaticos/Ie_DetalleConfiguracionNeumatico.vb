Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_DetalleConfiguracionNeumatico", también debe actualizar la referencia a "Ie_DetalleConfiguracionNeumatico" en Web.config.
<ServiceContract()> _
Public Interface Ie_DetalleConfiguracionNeumatico

    <OperationContract()> _
    Function Obtener(ByVal detalleConfiguracionNeumatico As e_DetalleConfiguracionNeumatico) As e_DetalleConfiguracionNeumatico

End Interface
