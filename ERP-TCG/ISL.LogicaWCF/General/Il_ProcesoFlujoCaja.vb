Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_ProcesoFlujoCaja", también debe actualizar la referencia a "Il_ProcesoFlujoCaja" en Web.config.
<ServiceContract()> _
Public Interface Il_ProcesoFlujoCaja

    <OperationContract()> _
    Function Obtener(ByVal oeProcesoFlujoCaja As e_ProcesoFlujoCaja) As e_ProcesoFlujoCaja

    <OperationContract()> _
    Function Listar(ByVal oeProcesoFlujoCaja As e_ProcesoFlujoCaja) As List(Of e_ProcesoFlujoCaja)

    <OperationContract()> _
    Function Validar(ByVal oeProcesoFlujoCaja As e_ProcesoFlujoCaja) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeProcesoFlujoCaja As e_ProcesoFlujoCaja) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeProcesoFlujoCaja As e_ProcesoFlujoCaja) As Boolean

End Interface
