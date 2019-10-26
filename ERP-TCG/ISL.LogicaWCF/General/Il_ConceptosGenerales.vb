Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_ConceptosGenerales", también debe actualizar la referencia a "Il_ConceptosGenerales" en Web.config.
<ServiceContract()> _
Public Interface Il_ConceptosGenerales

    <OperationContract()> _
    Function Obtener(ByVal oeConceptosGenerales As e_ConceptosGenerales) As e_ConceptosGenerales

    <OperationContract()> _
    Function Listar(ByVal oeConceptosGenerales As e_ConceptosGenerales) As List(Of e_ConceptosGenerales)

    <OperationContract()> _
    Function Validar(ByVal oeConceptosGenerales As e_ConceptosGenerales) As Boolean

    <OperationContract()> _
    Function ValidarDuplicado(ByVal oeConceptosGenerales As e_ConceptosGenerales) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeConceptosGenerales As e_ConceptosGenerales) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeConceptosGenerales As e_ConceptosGenerales) As Boolean

End Interface
