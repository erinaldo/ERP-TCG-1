Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_ActividadNegocio", también debe actualizar la referencia a "Ie_ActividadNegocio" en Web.config.
<ServiceContract()> _
Public Interface Ie_ActividadNegocio

    <OperationContract()> _
    Function Obtener(ByVal actividadNegocio As e_ActividadNegocio) As e_ActividadNegocio

End Interface
