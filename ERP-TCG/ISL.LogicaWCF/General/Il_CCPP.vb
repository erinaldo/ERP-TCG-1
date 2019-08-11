Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_CCPP", también debe actualizar la referencia a "Il_CCPP" en Web.config.
<ServiceContract()> _
Public Interface Il_CCPP

    <OperationContract()> _
    Function Obtener(ByVal oeCCPP As e_CCPP) As e_CCPP

    <OperationContract()> _
    Function Listar(ByVal oeCCPP As e_CCPP) As List(Of e_CCPP)

    <OperationContract()> _
    Function Guardar(ByVal oeCCPP As e_CCPP) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeCCPP As e_CCPP) As Boolean

    <OperationContract()> _
    Function Validar(ByVal oeCCPP As e_CCPP) As Boolean

End Interface
