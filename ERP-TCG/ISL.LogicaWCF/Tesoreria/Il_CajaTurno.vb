Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_CajaTurno", también debe actualizar la referencia a "Il_CajaTurno" en Web.config.
<ServiceContract()> _
Public Interface Il_CajaTurno

    <OperationContract()> _
    Function Obtener(ByVal oeCajaTurno As e_CajaTurno) As e_CajaTurno

    <OperationContract()> _
    Function Listar(ByVal oeCajaTurno As e_CajaTurno) As List(Of e_CajaTurno)

    <OperationContract()> _
    Function Validar(ByVal oeCajaTurno As e_CajaTurno) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeCajaTurno As e_CajaTurno) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeCajaTurno As e_CajaTurno) As Boolean

End Interface
