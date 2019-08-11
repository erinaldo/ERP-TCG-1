Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_SituacionAdministrativa", también debe actualizar la referencia a "Ie_SituacionAdministrativa" en Web.config.
<ServiceContract()> _
Public Interface Ie_SituacionAdministrativa

    <OperationContract()> _
    Function Obtener(ByVal situacionAdministrativa As e_SituacionAdministrativa) As e_SituacionAdministrativa

End Interface
