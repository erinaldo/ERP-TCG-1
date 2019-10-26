Imports System.ServiceModel
Imports ERP.EntidadesWCF
' NOTA: si cambia aquí el nombre de clase "Il_MaterialesNegociadosDet", también debe actualizar la referencia a "Il_MaterialesNegociadosDet" en Web.config.
<ServiceContract()> _
Public Interface Il_MaterialesNegociadosDet

    <OperationContract()> _
Function Obtener(ByVal oeMaterialesNegociadosDet As e_MaterialesNegociadosDet) As e_MaterialesNegociadosDet

    <OperationContract()> _
    Function Listar(ByVal oeMaterialesNegociadosDet As e_MaterialesNegociadosDet) As List(Of e_MaterialesNegociadosDet)

    <OperationContract()> _
    Function Validar(ByVal oeMaterialesNegociadosDet As e_MaterialesNegociadosDet) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeMaterialesNegociadosDet As e_MaterialesNegociadosDet) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeMaterialesNegociadosDet As e_MaterialesNegociadosDet) As Boolean

End Interface
