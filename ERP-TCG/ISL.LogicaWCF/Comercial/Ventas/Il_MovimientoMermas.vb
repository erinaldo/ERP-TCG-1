Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_MovimientoMermas", también debe actualizar la referencia a "Il_MovimientoMermas" en Web.config.
<ServiceContract()> _
Public Interface Il_MovimientoMermas

    <OperationContract()> _
   Function Obtener(ByVal oeMomivimientoMermas As e_MovimientoMermas) As e_MovimientoMermas

    <OperationContract()> _
    Function Listar(ByVal oeMomivimientoMermas As e_MovimientoMermas) As List(Of e_MovimientoMermas)

    <OperationContract()> _
    Function Guardar(ByVal oeMomivimientoMermas As e_MovimientoMermas) As Boolean

    <OperationContract()> _
    Function Cobrar(ByVal loMovMer As List(Of e_MovimientoMermas), oeOtrosIngresos As e_OtrosIngresos) As String

    <OperationContract()> _
    Function Eliminar(ByVal oeMomivimientoMermas As e_MovimientoMermas) As Boolean

End Interface
