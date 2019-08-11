Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_MedidaNeumatico", también debe actualizar la referencia a "Il_MedidaNeumatico" en Web.config.
<ServiceContract()> _
Public Interface Il_MedidaNeumatico

    <OperationContract()> _
    Function Obtener(ByVal oeMedidaNeumatico As e_MedidaNeumatico) As e_MedidaNeumatico

    <OperationContract()> _
    Function Listar(ByVal oeMedidaNeumatico As e_MedidaNeumatico) As List(Of e_MedidaNeumatico)

    <OperationContract()> _
    Function Validar(ByVal oeMedidaNeumatico As e_MedidaNeumatico) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeMedidaNeumatico As e_MedidaNeumatico) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeMedidaNeumatico As e_MedidaNeumatico) As Boolean

End Interface
