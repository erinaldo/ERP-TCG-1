Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_ActividadRestringida_Usuario", también debe actualizar la referencia a "Ie_ActividadRestringida_Usuario" en Web.config.
<ServiceContract()> _
Public Interface Ie_ActividadRestringida_Usuario

    <OperationContract()> _
     Function Obtener(ByVal actividadrestringida_usuario As e_ActividadRestringida_Usuario) As e_ActividadRestringida_Usuario

End Interface
