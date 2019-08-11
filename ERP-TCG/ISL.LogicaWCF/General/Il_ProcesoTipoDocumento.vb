Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_ProcesoTipoDocumento", también debe actualizar la referencia a "Il_ProcesoTipoDocumento" en Web.config.
<ServiceContract()> _
Public Interface Il_ProcesoTipoDocumento

    <OperationContract()> _
    Function Obtener(ByVal oeProcesoTipoDocumento As e_ProcesoTipoDocumento) As e_ProcesoTipoDocumento

    <OperationContract()> _
    Function Listar(ByVal oeProcesoTipoDocumento As e_ProcesoTipoDocumento) As List(Of e_ProcesoTipoDocumento)

    <OperationContract()> _
    Function Validar(ByVal oeProcesoTipoDocumento As e_ProcesoTipoDocumento) As Boolean

    <OperationContract()> _
    Function ValidarDuplicado(ByVal oeProcesoTipoDocumento As e_ProcesoTipoDocumento) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeProcesoTipoDocumento As e_ProcesoTipoDocumento) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeProcesoTipoDocumento As e_ProcesoTipoDocumento) As Boolean

End Interface
