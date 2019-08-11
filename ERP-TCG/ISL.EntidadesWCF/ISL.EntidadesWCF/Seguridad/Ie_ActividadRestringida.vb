Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_ActividadRestringida", también debe actualizar la referencia a "Ie_ActividadRestringida" en Web.config.
<ServiceContract()> _
Public Interface Ie_ActividadRestringida

    <OperationContract()> _
      Function Obtener(ByVal actividadrestringida As e_ActividadRestringida) As e_ActividadRestringida

End Interface
