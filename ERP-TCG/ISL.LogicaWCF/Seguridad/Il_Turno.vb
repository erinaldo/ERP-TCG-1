Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Turno", también debe actualizar la referencia a "Il_Turno" en Web.config.
<ServiceContract()> _
Public Interface Il_Turno

    <OperationContract()> _
    Function Obtener(ByVal oeTurno As e_Turno) As e_Turno

    <OperationContract()> _
    Function Listar(ByVal oeTurno As e_Turno) As List(Of e_Turno)

    <OperationContract()> _
    Function Validar(ByVal oeTurno As e_Turno) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeTurno As e_Turno) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeTurno As e_Turno) As Boolean

End Interface
