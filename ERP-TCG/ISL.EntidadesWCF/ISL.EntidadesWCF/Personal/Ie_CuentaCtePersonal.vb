Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_CuentaCtePersonal", también debe actualizar la referencia a "Ie_CuentaCtePersonal" en Web.config.
<ServiceContract()> _
Public Interface Ie_CuentaCtePersonal

    <OperationContract()> _
     Function obtener(ByVal oeCuentaCtePersonal As e_CuentaCtePersonal) As e_CuentaCtePersonal

End Interface
