Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_ConceptoIngresos", también debe actualizar la referencia a "Il_ConceptoIngresos" en Web.config.
<ServiceContract()> _
Public Interface Il_ConceptoIngresos

    <OperationContract()> _
    Function Obtener(ByVal oeConceptoIngresos As e_ConceptoIngresos) As e_ConceptoIngresos

    <OperationContract()> _
    Function Listar(ByVal oeConceptoIngresos As e_ConceptoIngresos) As List(Of e_ConceptoIngresos)

    <OperationContract()> _
    Function Validar(ByVal oeConceptoIngresos As e_ConceptoIngresos) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeConceptoIngresos As e_ConceptoIngresos) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeConceptoIngresos As e_ConceptoIngresos) As Boolean

End Interface
