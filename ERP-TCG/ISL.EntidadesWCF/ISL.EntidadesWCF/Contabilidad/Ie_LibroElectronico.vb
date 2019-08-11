Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_LibroElectronico", también debe actualizar la referencia a "Ie_LibroElectronico" en Web.config.
<ServiceContract()> _
Public Interface Ie_LibroElectronico

    <OperationContract()> _
    Function Obtener(ByVal libroelectronico As e_LibroElectronico) As e_LibroElectronico

End Interface
