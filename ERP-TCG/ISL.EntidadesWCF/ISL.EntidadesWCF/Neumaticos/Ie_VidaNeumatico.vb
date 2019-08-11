Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_VidaNeumatico", también debe actualizar la referencia a "Ie_VidaNeumatico" en Web.config.
<ServiceContract()> _
Public Interface Ie_VidaNeumatico

    <OperationContract()> _
    Function Obtener(ByVal vidaNeumatico As e_VidaNeumatico) As e_VidaNeumatico

End Interface
