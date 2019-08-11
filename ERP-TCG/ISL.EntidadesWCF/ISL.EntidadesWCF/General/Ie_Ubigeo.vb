Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Ubigeo", también debe actualizar la referencia a "Ie_Ubigeo" en Web.config.
<ServiceContract()> _
Public Interface Ie_Ubigeo

    <OperationContract()> _
    Function Obtener(ByVal ubigeo As e_Ubigeo) As e_Ubigeo

End Interface
