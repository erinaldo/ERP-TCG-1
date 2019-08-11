Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Transferencia", también debe actualizar la referencia a "Il_Transferencia" en Web.config.
<ServiceContract()> _
Public Interface Il_Transferencia

    <OperationContract()> _
    Function Obtener(ByVal oeTransferencia As e_Transferencia) As e_Transferencia

    <OperationContract()> _
    Function Listar(ByVal oeTransferencia As e_Transferencia) As List(Of e_Transferencia)

    <OperationContract()> _
    Function Validar(ByVal oeTransferencia As e_Transferencia) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeTransferencia As e_Transferencia) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeTransferencia As e_Transferencia) As Boolean

End Interface
