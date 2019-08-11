Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_CotizacionDetalleMat", también debe actualizar la referencia a "Ie_CotizacionDetalleMat" en Web.config.
<ServiceContract()> _
Public Interface Ie_CotizacionDetalleMatMat

    <OperationContract()> _
    Function Obtener(ByVal cotizacionDetalle As e_CotizacionDetalleMat) As e_CotizacionDetalleMat

End Interface
