Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_ItemGasto", también debe actualizar la referencia a "Ie_ItemGasto" en Web.config.
<ServiceContract()> _
Public Interface Ie_Kardex

    <OperationContract()> _
    Function Obtener(ByVal Kardex As e_Kardex) As e_Kardex

End Interface

