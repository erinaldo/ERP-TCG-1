Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_DetalleLibroElectronico", también debe actualizar la referencia a "Ie_DetalleLibroElectronico" en Web.config.
<ServiceContract()> _
Public Interface Ie_DetalleLibroElectronico

    <OperationContract()> _
    Function Obtener(ByVal detallelibroelectronico As e_DetalleLibroElectronico) As e_DetalleLibroElectronico

End Interface
