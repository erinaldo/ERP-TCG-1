Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_TipoMantenimiento", también debe actualizar la referencia a "Ie_TipoMantenimiento" en Web.config.
<ServiceContract()> _
Public Interface Ie_TipoMantenimiento

    <OperationContract()> _
    Function Obtener(ByVal tipoMantenimiento As e_TipoMantenimiento) As e_TipoMantenimiento

End Interface
