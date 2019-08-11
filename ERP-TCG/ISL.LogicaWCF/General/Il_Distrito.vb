Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Distrito", también debe actualizar la referencia a "Il_Distrito" en Web.config.
<ServiceContract()> _
Public Interface Il_Distrito

    <OperationContract()> _
    Function Obtener(ByVal oeDistrito As e_Distrito) As e_Distrito

    <OperationContract()> _
    Function Listar(ByVal oeDistrito As e_Distrito) As List(Of e_Distrito)

    <OperationContract()> _
    Function Guardar(ByVal oeDistrito As e_Distrito) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeDistrito As e_Distrito) As Boolean

    <OperationContract()> _
    Function Validar(ByVal oeDistrito As e_Distrito) As Boolean

End Interface
