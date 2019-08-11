Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Grupo", también debe actualizar la referencia a "Il_Grupo" en Web.config.
<ServiceContract()> _
Public Interface Il_Grupo

    <OperationContract()> _
    Function Obtener(ByVal oeGrupo As e_Grupo) As e_Grupo

    <OperationContract()> _
    Function Listar(ByVal oeGrupo As e_Grupo) As List(Of e_Grupo)

    <OperationContract()> _
    Function Validar(ByVal oeGrupo As e_Grupo) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeGrupo As e_Grupo) As Boolean

    <OperationContract()> _
    Function Enviar(ByVal oeGrupo As e_Grupo) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeGrupo As e_Grupo) As Boolean

End Interface
