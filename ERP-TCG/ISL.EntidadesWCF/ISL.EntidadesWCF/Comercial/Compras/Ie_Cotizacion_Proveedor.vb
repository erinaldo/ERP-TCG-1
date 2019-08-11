Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Cotizacion_Proveedor", también debe actualizar la referencia a "Ie_Cotizacion_Proveedor" en Web.config.
<ServiceContract()> _
Public Interface Ie_Cotizacion_Proveedor

    <OperationContract()> _
    Function Obtener(ByVal cotizacion_Proveedor As e_Cotizacion_Proveedor) As e_Cotizacion_Proveedor

End Interface
