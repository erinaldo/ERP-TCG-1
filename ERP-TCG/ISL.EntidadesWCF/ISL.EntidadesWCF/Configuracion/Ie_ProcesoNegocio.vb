Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_ProcesoNegocio", también debe actualizar la referencia a "Ie_ProcesoNegocio" en Web.config.
<ServiceContract()> _
Public Interface Ie_ProcesoNegocio

    <OperationContract()> _
    Function Obtener(ByVal procesoNegocio As e_ProcesoNegocio) As e_ProcesoNegocio

End Interface
