Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Gasto_Caja", también debe actualizar la referencia a "Ie_Gasto_Caja" en Web.config.
<ServiceContract()> _
Public Interface Ie_Gasto_Caja

    <OperationContract()> _
    Function Obtener(ByVal gasto_Caja As e_Gasto_Caja) As e_Gasto_Caja

End Interface
