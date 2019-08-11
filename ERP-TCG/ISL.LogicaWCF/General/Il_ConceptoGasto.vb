Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_ConceptoGasto", también debe actualizar la referencia a "Il_ConceptoGasto" en Web.config.
<ServiceContract()> _
Public Interface Il_ConceptoGasto

    <OperationContract()> _
    Function Obtener(ByVal oeConceptoGasto As e_ConceptoGasto) As e_ConceptoGasto

    <OperationContract()> _
    Function Listar(ByVal oeConceptoGasto As e_ConceptoGasto) As List(Of e_ConceptoGasto)

    <OperationContract()> _
    Function Validar(ByVal oeConceptoGasto As e_ConceptoGasto) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeConceptoGasto As e_ConceptoGasto) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeConceptoGasto As e_ConceptoGasto) As Boolean

    <OperationContract()> _
    Function ComboGrilla(ByVal ListaConceptoGasto As List(Of e_ConceptoGasto))

End Interface
