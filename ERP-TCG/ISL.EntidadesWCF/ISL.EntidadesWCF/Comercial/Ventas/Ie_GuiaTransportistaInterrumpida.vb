Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_GuiaTransportistaInterrumpida", también debe actualizar la referencia a "Ie_GuiaTransportistaInterrumpida" en Web.config.
<ServiceContract()> _
Public Interface Ie_GuiaTransportistaInterrumpida

    <OperationContract()> _
    Function Obtener(ByVal guiaTransportistaInterrumpida As e_GuiaTransportistaInterrumpida) As e_GuiaTransportistaInterrumpida

End Interface
