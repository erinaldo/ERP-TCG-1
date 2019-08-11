Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Boton", también debe actualizar la referencia a "Ie_Boton" en Web.config.
<ServiceContract()> _
Public Interface Ie_Boton

    <OperationContract()> _
    Function Obtener(ByVal boton As e_Boton) As e_Boton

End Interface
