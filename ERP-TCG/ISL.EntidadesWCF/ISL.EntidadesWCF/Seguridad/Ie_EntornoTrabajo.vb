Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_EntornoTrabajo", también debe actualizar la referencia a "Ie_EntornoTrabajo" en Web.config.
<ServiceContract()> _
Public Interface Ie_EntornoTrabajo

    <OperationContract()> _
    Function Obtener(ByVal entornoTrabajo As e_EntornoTrabajo) As e_EntornoTrabajo

End Interface
