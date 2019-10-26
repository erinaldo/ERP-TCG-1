Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_OperacionNeumatico", también debe actualizar la referencia a "Il_OperacionNeumatico" en Web.config.
<ServiceContract()> _
Public Interface Il_OperacionNeumatico

    <OperationContract()> _
    Function Obtener(ByVal oeOperacionNeumatico As e_OperacionNeumatico) As e_OperacionNeumatico

    <OperationContract()> _
    Function Listar(ByVal oeOperacionNeumatico As e_OperacionNeumatico) As List(Of e_OperacionNeumatico)

    <OperationContract()> _
    Function Validar(ByVal oeOperacionNeumatico As e_OperacionNeumatico) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeOperacionNeumatico As e_OperacionNeumatico) As Boolean

    <OperationContract()> _
    Function GuardarLista(ByVal leOperacionNeumatico As List(Of e_OperacionNeumatico)) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeOperacionNeumatico As e_OperacionNeumatico) As Boolean

End Interface
