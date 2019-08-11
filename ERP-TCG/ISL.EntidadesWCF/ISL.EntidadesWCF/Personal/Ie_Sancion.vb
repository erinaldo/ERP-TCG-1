Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Sancion", también debe actualizar la referencia a "Ie_Sancion" en Web.config.
<ServiceContract()> _
Public Interface Ie_Sancion

    <OperationContract()> _
    Function Obtener(ByVal sancion As e_Sancion) As e_Sancion

End Interface
