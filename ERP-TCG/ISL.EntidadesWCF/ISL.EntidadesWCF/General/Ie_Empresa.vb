Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Empresa", también debe actualizar la referencia a "Ie_Empresa" en Web.config.
<ServiceContract()> _
Public Interface Ie_Empresa

    <OperationContract()> _
    Function Obtener(ByVal empresa As e_Empresa) As e_Empresa

End Interface
