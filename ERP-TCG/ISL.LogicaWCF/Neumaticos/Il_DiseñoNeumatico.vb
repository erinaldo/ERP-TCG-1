Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_DiseñoNeumatico", también debe actualizar la referencia a "Il_DiseñoNeumatico" en Web.config.
<ServiceContract()> _
Public Interface Il_DiseñoNeumatico

    <OperationContract()> _
    Function Obtener(ByVal oeDiseñoNeumatico As e_DiseñoNeumatico) As e_DiseñoNeumatico

    <OperationContract()> _
    Function Listar(ByVal oeDiseñoNeumatico As e_DiseñoNeumatico) As List(Of e_DiseñoNeumatico)

    <OperationContract()> _
    Function Validar(ByVal oeDiseñoNeumatico As e_DiseñoNeumatico) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeDiseñoNeumatico As e_DiseñoNeumatico) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeDiseñoNeumatico As e_DiseñoNeumatico) As Boolean

End Interface
