Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Impuesto", también debe actualizar la referencia a "Ie_Impuesto" en Web.config.
<ServiceContract()> _
Public Interface Ie_Impuesto

    <OperationContract()> _
    Function Obtener(ByVal impuesto As e_Impuesto) As e_Impuesto

End Interface
