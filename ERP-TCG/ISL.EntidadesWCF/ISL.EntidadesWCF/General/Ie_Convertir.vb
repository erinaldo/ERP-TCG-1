Imports System.ServiceModel
Imports System.Reflection

' NOTA: si cambia aquí el nombre de clase "Ie_Convertir", también debe actualizar la referencia a "Ie_Convertir" en Web.config.
<ServiceContract()> _
Public Interface Ie_Convertir

    <OperationContract()> _
    Function ConvertirDataTable(ByVal items As List(Of Object)) As DataTable

End Interface
