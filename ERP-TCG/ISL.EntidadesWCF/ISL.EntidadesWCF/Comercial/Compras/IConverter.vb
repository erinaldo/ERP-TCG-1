Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "IConverter", también debe actualizar la referencia a "IConverter" en Web.config.
<ServiceContract()> _
Public Interface IConverter

    <OperationContract()> _
    Function Convert(ByVal items As List(Of Object)) As DataTable

End Interface
