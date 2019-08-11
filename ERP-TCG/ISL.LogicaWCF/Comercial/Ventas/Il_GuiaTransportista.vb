Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_GuiaTransportista", también debe actualizar la referencia a "Il_GuiaTransportista" en Web.config.
<ServiceContract()> _
Public Interface Il_GuiaTransportista

    <OperationContract()> _
    Function Obtener(ByVal oeGuiaTransportista As e_GuiaTransportista) As e_GuiaTransportista

    <OperationContract()> _
    Function Listar(ByVal oeGuiaTransportista As e_GuiaTransportista) As List(Of e_GuiaTransportista)

    <OperationContract()> _
    Function ListarInformeGrt(ByVal oeGuiaTransportista As e_GuiaTransportista) As DataTable

    <OperationContract()> _
    Function ListarDS(ByVal oeGuiaTransportista As e_GuiaTransportista) As List(Of e_GuiaTransportista)

    <OperationContract()> _
    Function Validar(ByVal oeGuiaTransportista As e_GuiaTransportista) As Boolean

    <OperationContract()> _
    Function GuardarSeguimiento(ByVal oeGuiaTransportista As e_Seguimiento) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeGuiaTransportista As e_GuiaTransportista) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeGuiaTransportista As e_GuiaTransportista) As Boolean

End Interface
