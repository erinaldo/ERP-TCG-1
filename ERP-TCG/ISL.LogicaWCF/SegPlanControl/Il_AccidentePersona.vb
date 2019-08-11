Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_AccidentePersonaPersona", también debe actualizar la referencia a "Il_AccidentePersonaPersona" en Web.config.
<ServiceContract()> _
Public Interface Il_AccidentePersona

    <OperationContract()> _
    Function Obtener(ByVal oeAccidentePersona As e_AccidentePersona) As e_AccidentePersona

    <OperationContract()> _
    Function Listar(ByVal oeAccidentePersona As e_AccidentePersona) As List(Of e_AccidentePersona)

    <OperationContract()> _
    Function Validar(ByVal oeAccidentePersona As e_AccidentePersona) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeAccidentePersona As e_AccidentePersona) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeAccidentePersona As e_AccidentePersona) As Boolean

    <OperationContract()> _
    Function EliminacionDefinitiva(ByVal oeAccidentePersona As e_AccidentePersona) As Boolean

End Interface
