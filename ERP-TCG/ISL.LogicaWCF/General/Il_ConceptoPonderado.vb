Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_ConceptoPonderado" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_ConceptoPonderado

    <OperationContract()> _
    Function Obtener(ByVal oeConceptoPonderado As e_ConceptoPonderado) As e_ConceptoPonderado

    <OperationContract()> _
    Function Listar(ByVal oeConceptoPonderado As e_ConceptoPonderado) As List(Of e_ConceptoPonderado)

    <OperationContract()> _
    Function Validar(ByVal oeConceptoPonderado As e_ConceptoPonderado) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeConceptoPonderado As e_ConceptoPonderado) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeConceptoPonderado As e_ConceptoPonderado) As Boolean

End Interface
