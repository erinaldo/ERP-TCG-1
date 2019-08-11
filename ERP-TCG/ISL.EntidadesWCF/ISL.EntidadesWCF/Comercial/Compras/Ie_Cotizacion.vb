Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Cotizacion", también debe actualizar la referencia a "Ie_Cotizacion" en Web.config.
<ServiceContract()> _
Public Interface Ie_Cotizacion

    <OperationContract()> _
    Function Obtener(ByVal cotizacion As e_Cotizacion) As e_Cotizacion

End Interface
