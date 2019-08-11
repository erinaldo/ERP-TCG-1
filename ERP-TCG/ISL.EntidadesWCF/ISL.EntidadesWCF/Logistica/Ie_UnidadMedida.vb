Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_UnidadMedida", también debe actualizar la referencia a "Ie_UnidadMedida" en Web.config.
<ServiceContract()> _
Public Interface Ie_UnidadMedida

    <OperationContract()> _
    Function Obtener(ByVal unidadMedida As e_UnidadMedida) As e_UnidadMedida

End Interface
