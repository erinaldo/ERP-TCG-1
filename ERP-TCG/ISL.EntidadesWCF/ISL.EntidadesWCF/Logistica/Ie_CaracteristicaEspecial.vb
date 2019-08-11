Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_CaracteristicaEspecial", también debe actualizar la referencia a "Ie_CaracteristicaEspecial" en Web.config.
<ServiceContract()> _
Public Interface Ie_CaracteristicaEspecial

    <OperationContract()> _
    Function Obtener(ByVal caracteristicaespecial As e_CaracteristicaEspecial) As e_CaracteristicaEspecial

End Interface
