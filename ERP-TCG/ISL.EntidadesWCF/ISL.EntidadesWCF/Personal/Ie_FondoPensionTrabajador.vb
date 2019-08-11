Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_FondoPensionTrabajador", también debe actualizar la referencia a "Ie_FondoPensionTrabajador" en Web.config.
<ServiceContract()> _
Public Interface Ie_FondoPensionTrabajador

    <OperationContract()> _
    Function obtener(ByVal oeFondoPensionTrabajador As e_FondoPensionTrabajador) As e_FondoPensionTrabajador

End Interface
