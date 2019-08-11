Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Neumatico", también debe actualizar la referencia a "Il_Neumatico" en Web.config.
<ServiceContract()> _
Public Interface Il_Neumatico

    Function GuardarSinValidar(oeNeumatico As e_Neumatico) As Boolean

    Function ActualizarKmGeneral() As Boolean

    <OperationContract()> _
    Function ValidarDuplicado(ByVal ls_Id As String, ByVal ls_Codigo As String) As Boolean

    <OperationContract()> _
    Function Obtener(ByVal oeNeumatico As e_Neumatico) As e_Neumatico

    <OperationContract()> _
    Function Listar(ByVal oeNeumatico As e_Neumatico) As List(Of e_Neumatico)

    <OperationContract()> _
    Function ListarDS(ByVal oeNeumatico As e_Neumatico) As Data.DataSet

    <OperationContract()> _
    Function Validar(ByVal oeNeumatico As e_Neumatico) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeNeumatico As e_Neumatico) As Boolean

    <OperationContract()> _
    Function Confirmar(ByVal oeNeumatico As e_Neumatico) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeNeumatico As e_Neumatico) As Boolean

End Interface
