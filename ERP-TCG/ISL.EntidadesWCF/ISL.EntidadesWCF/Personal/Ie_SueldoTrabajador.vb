Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_SueldoTrabajador", también debe actualizar la referencia a "Ie_SueldoTrabajador" en Web.config.
<ServiceContract()> _
Public Interface Ie_SueldoTrabajador

    <OperationContract()> _
    Function obtener(ByVal oeSueldoTrabajador As e_SueldoTrabajador) As e_SueldoTrabajador

End Interface
