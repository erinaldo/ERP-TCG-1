Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_AlertaDestino", también debe actualizar la referencia a "Il_AlertaDestino" en Web.config.
<ServiceContract()> _
Public Interface Il_AlertaDestino

    <OperationContract()> _
    Function Obtener(ByVal oeAlertaDestino As e_AlertaDestino) As e_AlertaDestino

    <OperationContract()> _
    Function Listar(ByVal oeAlertaDestino As e_AlertaDestino) As List(Of e_AlertaDestino)

    <OperationContract()> _
    Function Validar(ByVal oeAlertaDestino As e_AlertaDestino) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeAlertaDestino As e_AlertaDestino) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeAlertaDestino As e_AlertaDestino) As Boolean

End Interface
