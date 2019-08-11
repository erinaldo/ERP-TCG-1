Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Archivo", también debe actualizar la referencia a "Ie_Archivo" en Web.config.
<ServiceContract()> _
Public Interface Ie_Archivo

    <OperationContract()> _
    Function Obtener(ByVal archivo As e_Archivo) As e_Archivo

End Interface
