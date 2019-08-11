Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Caja", también debe actualizar la referencia a "Ie_Caja" en Web.config.
<ServiceContract()> _
Public Interface Ie_Caja

    <OperationContract()> _
    Function Obtener(ByVal caja As e_Caja) As e_Caja

End Interface
