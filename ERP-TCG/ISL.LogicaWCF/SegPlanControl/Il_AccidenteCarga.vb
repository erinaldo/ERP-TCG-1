Imports ERP.EntidadesWCF
Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Il_AccidenteCarga", también debe actualizar la referencia a "Il_AccidenteCarga" en Web.config.
<ServiceContract()> _
Public Interface Il_AccidenteCarga

    <OperationContract()> _
Function Obtener(ByVal oeAccidenteCarga As e_AccidenteCarga) As e_AccidenteCarga

    <OperationContract()> _
    Function Listar(ByVal oeAccidenteCarga As e_AccidenteCarga) As List(Of e_AccidenteCarga)

    <OperationContract()> _
    Function Validar(ByVal oeAccidenteCarga As e_AccidenteCarga) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeAccidenteCarga As e_AccidenteCarga) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeAccidenteCarga As e_AccidenteCarga) As Boolean

End Interface
