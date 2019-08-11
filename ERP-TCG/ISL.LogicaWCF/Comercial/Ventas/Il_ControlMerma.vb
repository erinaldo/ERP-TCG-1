Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_ControlMerma", también debe actualizar la referencia a "Il_ControlMerma" en Web.config.
<ServiceContract()> _
Public Interface Il_ControlMerma

    <OperationContract()> _
   Function Obtener(ByVal oeMerma As e_ControlMerma) As e_ControlMerma

    <OperationContract()> _
    Function Listar(ByVal oeMerma As e_ControlMerma) As List(Of e_ControlMerma)

    <OperationContract()> _
    Function Validar(ByVal oeMerma As e_ControlMerma, ByVal IndIngresoSalida As Integer) As Boolean


    <OperationContract()> _
    Function Guardar(ByVal oeMerma As e_ControlMerma) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeMerma As e_ControlMerma) As Boolean

End Interface
