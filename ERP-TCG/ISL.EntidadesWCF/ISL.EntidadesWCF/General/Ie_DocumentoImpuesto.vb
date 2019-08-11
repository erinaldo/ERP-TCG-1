Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_DocumentoImpuesto", también debe actualizar la referencia a "Ie_DocumentoImpuesto" en Web.config.
<ServiceContract()> _
Public Interface Ie_DocumentoImpuesto

    <OperationContract()> _
    Function Obtener(ByVal documentoImpuesto As e_DocumentoImpuesto) As e_DocumentoImpuesto

End Interface
