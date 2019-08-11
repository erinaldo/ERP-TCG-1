Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_CaracteristicaMaterial", también debe actualizar la referencia a "Ie_CaracteristicaMaterial" en Web.config.
<ServiceContract()> _
Public Interface Ie_CaracteristicaMaterial

    <OperationContract()> _
    Function Obtener(ByVal caracteristicamaterial As e_CaracteristicaMaterial) As e_CaracteristicaMaterial

End Interface
