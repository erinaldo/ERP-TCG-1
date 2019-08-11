Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_MontoFlujoDiario", también debe actualizar la referencia a "Il_MontoFlujoDiario" en Web.config.
<ServiceContract()> _
Public Interface Il_MontoFlujoDiario

    <OperationContract()> _
    Function Obtener(ByVal oeMontoFlujoDiario As e_MontoFlujoDiario) As e_MontoFlujoDiario

    <OperationContract()> _
    Function Listar(ByVal oeMontoFlujoDiario As e_MontoFlujoDiario) As List(Of e_MontoFlujoDiario)

    <OperationContract()> _
    Function Validar(ByVal oeMontoFlujoDiario As e_MontoFlujoDiario) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeMontoFlujoDiario As e_MontoFlujoDiario) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeMontoFlujoDiario As e_MontoFlujoDiario) As Boolean

End Interface
