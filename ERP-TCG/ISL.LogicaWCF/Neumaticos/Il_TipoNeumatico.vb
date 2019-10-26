Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_TipoNeumatico", también debe actualizar la referencia a "Il_TipoNeumatico" en Web.config.
<ServiceContract()> _
Public Interface Il_TipoNeumatico

    <OperationContract()> _
    Function Obtener(ByVal oeTipoNeumatico As e_TipoNeumatico) As e_TipoNeumatico

    <OperationContract()> _
    Function Listar(ByVal oeTipoNeumatico As e_TipoNeumatico) As List(Of e_TipoNeumatico)

    <OperationContract()> _
    Function Validar(ByVal oeTipoNeumatico As e_TipoNeumatico) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeTipoNeumatico As e_TipoNeumatico) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeTipoNeumatico As e_TipoNeumatico) As Boolean

End Interface
