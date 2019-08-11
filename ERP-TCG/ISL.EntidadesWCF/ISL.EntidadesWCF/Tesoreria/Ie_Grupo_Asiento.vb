Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Grupo_Asiento", también debe actualizar la referencia a "Ie_Grupo_Asiento" en Web.config.
<ServiceContract()> _
Public Interface Ie_Grupo_Asiento

    <OperationContract()> _
    Function Obtener(ByVal grupo_Asiento As e_Grupo_Asiento) As e_Grupo_Asiento

End Interface
