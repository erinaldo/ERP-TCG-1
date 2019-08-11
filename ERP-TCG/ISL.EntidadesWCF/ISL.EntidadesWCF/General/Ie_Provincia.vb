Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Provincia", también debe actualizar la referencia a "Ie_Provincia" en Web.config.
<ServiceContract()> _
Public Interface Ie_Provincia

    <OperationContract()> _
    Function Obtener(ByVal provincia As e_Provincia) As e_Provincia

End Interface
