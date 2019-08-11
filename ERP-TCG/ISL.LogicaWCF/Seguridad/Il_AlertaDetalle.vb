Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_AlertaDetalle", también debe actualizar la referencia a "Il_AlertaDetalle" en Web.config.
<ServiceContract()> _
Public Interface Il_AlertaDetalle

    <OperationContract()> _
    Function Obtener(ByVal oeAlertaDetalle As e_AlertaDetalle) As e_AlertaDetalle

    <OperationContract()> _
    Function Listar(ByVal oeAlertaDetalle As e_AlertaDetalle) As List(Of e_AlertaDetalle)

    <OperationContract()> _
    Function Validar(ByVal oeAlertaDetalle As e_AlertaDetalle) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeAlertaDetalle As e_AlertaDetalle) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeAlertaDetalle As e_AlertaDetalle) As Boolean

End Interface
