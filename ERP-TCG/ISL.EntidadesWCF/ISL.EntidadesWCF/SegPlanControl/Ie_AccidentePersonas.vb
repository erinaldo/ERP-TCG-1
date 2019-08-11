Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_AccidentePersonas", también debe actualizar la referencia a "Ie_AccidentePersonas" en Web.config.
<ServiceContract()> _
Public Interface Ie_AccidentePersonas

    <OperationContract()> _
    Function Obtener(ByVal listaAccidentePersona As List(Of e_AccidentePersona)) As List(Of e_AccidentePersona)

    <OperationContract()> _
    Function Agregar(ByVal accidentePersona As e_AccidentePersona) As List(Of e_AccidentePersona)

    <OperationContract()> _
    Function Quitar(ByVal accidentePersona As e_AccidentePersona) As List(Of e_AccidentePersona)

    <OperationContract()> _
    Function Filtrar(ByVal accidentePersona As e_AccidentePersona) As List(Of e_AccidentePersona)

    <OperationContract()> _
    Function Cuantos() As Integer

End Interface
