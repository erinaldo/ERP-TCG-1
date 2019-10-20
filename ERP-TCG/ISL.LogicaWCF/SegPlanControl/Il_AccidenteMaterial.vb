Imports System.ServiceModel
Imports ERP.EntidadesWCF
' NOTA: si cambia aquí el nombre de clase "Il_AccidenteMaterial", también debe actualizar la referencia a "Il_AccidenteMaterial" en Web.config.
<ServiceContract()> _
Public Interface Il_AccidenteMaterial

    <OperationContract()> _
   Function Obtener(ByVal oeAccidenteMaterial As e_AccidenteMaterial) As e_AccidenteMaterial

    <OperationContract()> _
    Function Listar(ByVal oeAccidenteMaterial As e_AccidenteMaterial) As List(Of e_AccidenteMaterial)

    <OperationContract()> _
    Function Validar(ByVal oeAccidenteMaterial As e_AccidenteMaterial) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeAccidenteMaterial As e_AccidenteMaterial) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeAccidenteMaterial As e_AccidenteMaterial) As Boolean

End Interface
