Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Operacion", también debe actualizar la referencia a "Ie_Operacion" en Web.config.
<ServiceContract()> _
Public Interface Ie_Operacion

    <OperationContract()> _
    Function Obtener(ByVal operacion As e_Operacion) As e_Operacion

End Interface
