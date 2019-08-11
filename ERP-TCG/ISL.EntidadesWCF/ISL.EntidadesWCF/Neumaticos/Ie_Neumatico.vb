Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Neumatico", también debe actualizar la referencia a "Ie_Neumatico" en Web.config.
<ServiceContract()> _
Public Interface Ie_Neumatico

    <OperationContract()> _
    Function Obtener(ByVal neumatico As e_Neumatico) As e_Neumatico

End Interface
