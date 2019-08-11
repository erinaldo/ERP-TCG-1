Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Lugar", también debe actualizar la referencia a "Ie_Lugar" en Web.config.
<ServiceContract()> _
Public Interface Ie_Lugar

    <OperationContract()> _
    Function Obtener(ByVal lugar As e_Lugar) As e_Lugar

End Interface
