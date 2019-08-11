Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_MontoFlujoDiario_Det", también debe actualizar la referencia a "Il_MontoFlujoDiario_Det" en Web.config.
<ServiceContract()> _
Public Interface Il_MontoFlujoDiario_Det

    <OperationContract()> _
    Function Obtener(ByVal oeMontoFlujoDiario_Det As e_MontoFlujoDiario_Det) As e_MontoFlujoDiario_Det

    <OperationContract()> _
    Function Listar(ByVal oeMontoFlujoDiario_Det As e_MontoFlujoDiario_Det) As List(Of e_MontoFlujoDiario_Det)

    <OperationContract()> _
    Function Validar(ByVal oeMontoFlujoDiario_Det As e_MontoFlujoDiario_Det) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeMontoFlujoDiario_Det As e_MontoFlujoDiario_Det) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeMontoFlujoDiario_Det As e_MontoFlujoDiario_Det) As Boolean

End Interface
