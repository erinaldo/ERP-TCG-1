Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_ProcesoGlosa", también debe actualizar la referencia a "Il_ProcesoGlosa" en Web.config.
<ServiceContract()> _
Public Interface Il_ProcesoGlosa

    <OperationContract()> _
    Function Obtener(ByVal oeProcesoGlosa As e_ProcesoGlosa) As e_ProcesoGlosa

    <OperationContract()> _
    Function Listar(ByVal oeProcesoGlosa As e_ProcesoGlosa) As List(Of e_ProcesoGlosa)

    <OperationContract()> _
    Function Validar(ByVal oeProcesoGlosa As e_ProcesoGlosa) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal loProcesoGlosa As List(Of e_ProcesoGlosa)) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeProcesoGlosa As e_ProcesoGlosa) As Boolean

End Interface
