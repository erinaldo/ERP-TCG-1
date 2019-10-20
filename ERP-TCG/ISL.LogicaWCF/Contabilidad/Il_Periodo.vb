Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Periodo", también debe actualizar la referencia a "Il_Periodo" en Web.config.
<ServiceContract()> _
Public Interface Il_Periodo

    <OperationContract()> _
    Function Obtener(ByVal oeEjercicio As e_Periodo) As e_Periodo

    <OperationContract()> _
    Function ObtenerPeriodoVigente(ByVal oePeriodo As e_Periodo, ByVal mes As Integer) As e_Periodo

    <OperationContract()> _
    Function Listar(ByVal oeEjercicio As e_Periodo) As List(Of e_Periodo)

    <OperationContract()> _
    Function Validar(ByVal oePeriodo As e_Periodo) As Boolean

    <OperationContract()> _
    Function ValidarDuplicado(ByVal id As String, ByVal valor As String, ByVal campo As String) As Boolean

    <OperationContract()> _
    Function ValidarTipoCambio(ByVal Com As Double, ByVal Ven As Double) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeEjercicio As e_Periodo) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeEjercicio As e_Periodo) As Boolean

End Interface
