Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_ProcesoNegocio", también debe actualizar la referencia a "Il_ProcesoNegocio" en Web.config.
<ServiceContract()> _
Public Interface Il_ProcesoNegocio

    <OperationContract()> _
    Function Obtener(ByVal oeProcesoNegocio As e_ProcesoNegocio) As e_ProcesoNegocio

    <OperationContract()> _
    Function Listar(ByVal oeProcesoNegocio As e_ProcesoNegocio) As List(Of e_ProcesoNegocio)

    <OperationContract()> _
    Function Validar(ByVal oeProcesoNegocio As e_ProcesoNegocio) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeProcesoNegocio As e_ProcesoNegocio) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeProcesoNegocio As e_ProcesoNegocio) As Boolean

End Interface
