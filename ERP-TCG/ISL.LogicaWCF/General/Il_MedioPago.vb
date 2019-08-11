Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_MedioPago", también debe actualizar la referencia a "Il_MedioPago" en Web.config.
<ServiceContract()> _
Public Interface Il_MedioPago

    <OperationContract()> _
    Function Obtener(ByVal oeMedioPago As e_MedioPago) As e_MedioPago

    <OperationContract()> _
    Function Listar(ByVal oeMedioPago As e_MedioPago) As List(Of e_MedioPago)

    <OperationContract()> _
    Function Validar(ByVal oeMedioPago As e_MedioPago) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeMedioPago As e_MedioPago) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeMedioPago As e_MedioPago) As Boolean

End Interface
