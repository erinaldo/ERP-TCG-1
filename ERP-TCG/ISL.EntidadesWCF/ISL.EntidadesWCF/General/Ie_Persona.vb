Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Persona", también debe actualizar la referencia a "Ie_Persona" en Web.config.
<ServiceContract()> _
Public Interface Ie_Persona

    <OperationContract()> _
    Function Obtener(ByVal persona As e_Persona) As e_Persona

    '<OperationContract()> _
    'Function IdPadre() As String

    '<OperationContract()> _
    'Function IdHijo() As String

    '<OperationContract()> _
    'Function CodigoPadre() As String

    '<OperationContract()> _
    'Function CodigoHijo() As String

    '<OperationContract()> _
    'Function ActivoPadre() As Boolean

    '<OperationContract()> _
    'Function ActivoHijo() As Boolean

    '<OperationContract()> _
    'Function TipoOperacionPadre() As String

    '<OperationContract()> _
    'Function TipoOperacionHijo() As String

End Interface
