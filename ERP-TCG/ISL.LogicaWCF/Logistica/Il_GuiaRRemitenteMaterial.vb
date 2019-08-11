Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_GuiaRRemitenteMaterial", también debe actualizar la referencia a "Il_GuiaRRemitenteMaterial" en Web.config.
<ServiceContract()> _
Public Interface Il_GuiaRRemitenteMaterial

    <OperationContract()> _
    Function Obtener(ByVal oeGuiaRRemitenteMaterial As e_GuiaRRemitenteMaterial) As e_GuiaRRemitenteMaterial

    <OperationContract()> _
    Function Listar(ByVal oeGuiaRRemitenteMaterial As e_GuiaRRemitenteMaterial) As List(Of e_GuiaRRemitenteMaterial)

    <OperationContract()> _
    Function Validar(ByVal oeGuiaRRemitenteMaterial As e_GuiaRRemitenteMaterial) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeGuiaRRemitenteMaterial As e_GuiaRRemitenteMaterial) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeGuiaRRemitenteMaterial As e_GuiaRRemitenteMaterial) As Boolean

End Interface
