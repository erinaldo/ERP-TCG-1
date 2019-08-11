Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_CierreCaja", también debe actualizar la referencia a "Ie_CierreCaja" en Web.config.
<ServiceContract()> _
Public Interface Ie_CierreCaja

    <OperationContract()> _
    Function Obtener(ByVal cierrecaja As e_CierreCaja) As e_CierreCaja


End Interface
