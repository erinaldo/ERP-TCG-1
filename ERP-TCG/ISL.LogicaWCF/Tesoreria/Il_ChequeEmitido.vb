Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_ChequeEmitido", también debe actualizar la referencia a "Il_ChequeEmitido" en Web.config.
<ServiceContract()> _
Public Interface Il_ChequeEmitido

    <OperationContract()> _
    Function Obtener(ByVal oeChequeEmitido As e_ChequeEmitido) As e_ChequeEmitido

    <OperationContract()> _
    Function Listar(ByVal oeChequeEmitido As e_ChequeEmitido) As List(Of e_ChequeEmitido)

    <OperationContract()> _
    Function Validar(ByVal oeChequeEmitido As e_ChequeEmitido) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeChequeEmitido As e_ChequeEmitido, ByVal loCtaCtbleConcepto As List(Of e_CtaCtble_Concepto), lo As List(Of e_Combo)) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeChequeEmitido As e_ChequeEmitido) As Boolean
End Interface
