Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_ProcesoServicio", también debe actualizar la referencia a "Il_ProcesoServicio" en Web.config.
<ServiceContract()> _
Public Interface Il_ProcesoServicio

    <OperationContract()> _
    Function Obtener(ByVal oeProcesoServicio As e_ProcesoServicio) As e_ProcesoServicio

    <OperationContract()> _
    Function Listar(ByVal oeProcesoServicio As e_ProcesoServicio) As List(Of e_ProcesoServicio)

    <OperationContract()> _
    Function Validar(ByVal oeProcesoServicio As e_ProcesoServicio) As Boolean

    <OperationContract()> _
    Function ValidarDuplicado(ByVal oeProcesoServicio As e_ProcesoServicio) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeProcesoServicio As e_ProcesoServicio) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeProcesoServicio As e_ProcesoServicio) As Boolean

End Interface
